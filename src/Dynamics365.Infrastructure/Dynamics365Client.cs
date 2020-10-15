using System;
using System.Collections.Generic;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Dynamics365.Core;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace CluedIn.Crawling.Dynamics365.Infrastructure
{
    public class Dynamics365Client
    {
        private readonly ILogger<Dynamics365Client> _log;
        private Dynamics365CrawlJobData _crawlJobData;

        public Dynamics365Client(ILogger<Dynamics365Client> log, Dynamics365CrawlJobData dynamics365CrawlJobData)
        {
            if (log == null)
                throw new ArgumentNullException(nameof(log));

            if (dynamics365CrawlJobData == null)
                throw new ArgumentNullException(nameof(dynamics365CrawlJobData));

            _log = log;
            _crawlJobData = dynamics365CrawlJobData;
        }

        public IEnumerable<T> Get<T>(string tableName, string fieldThatIncrements)
        { 
            var modifiedOnRowName = "ModifiedOn";
            var offset = 0;
            var pageSize = _crawlJobData.SqlPageSize;
            var lastCrawlTime = _crawlJobData.LastCrawlFinishTime.ToString("yyyy-MM-dd HH:mm:ss");

            using (var connection = new SqlConnection(_crawlJobData.ConnectionString))
            {
                connection.Open();
                
                while (true)
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @$"SELECT *
                                             FROM [{tableName}]
                                             WHERE [{modifiedOnRowName}] > '{lastCrawlTime}'
                                             ORDER BY {fieldThatIncrements}
                                             OFFSET {offset} ROWS
                                             FETCH NEXT {pageSize} ROWS ONLY";
                    command.Prepare();

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();
                    }
                    catch (Exception e)
                    {
                        _log.LogError($"Failed to execute SQL query. Exception message: {e.Message}");
                        continue;
                    }

                    if (!reader.HasRows)
                    {
                        yield break;
                    }

                    var recordsFetched = 0;

                    while (reader.Read())
                    {
                        T obj;
                        try
                        {
                            obj = (T)Activator.CreateInstance(typeof(T), reader);
                        }
                        catch (Exception e)
                        {
                            _log.LogError($"Unable to instantiate object from table row. Exception message: {e.Message}");
                            continue;
                        }

                        recordsFetched++;
                        yield return obj;
                    }

                    var reachedEndOfRecords = recordsFetched < pageSize;
                    if (reachedEndOfRecords)
                    {
                        yield break;
                    }

                    if (_crawlJobData.SqlDataCount.HasValue)
                    {
                        var reachedUpperLimit = (offset + recordsFetched) >= _crawlJobData.SqlDataCount.Value;
                        if (reachedUpperLimit)
                        {
                            yield break;
                        }
                    }

                    offset += recordsFetched;

                    reader.Close();
                }
            }
        }

        public AccountInformation GetAccountInformation()
        {
            return new AccountInformation("", "");
        }
    }
}
