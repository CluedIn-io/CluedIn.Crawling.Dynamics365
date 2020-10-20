using System.Collections.Generic;
using System.Configuration;
using CluedIn.Core;
using CluedIn.Core.Configuration;
using CluedIn.Core.Crawling;

namespace CluedIn.Crawling.Dynamics365.Core
{
    public class Dynamics365CrawlJobData : CrawlJobData
    {
        public Dynamics365CrawlJobData()
        {

        }

        public Dynamics365CrawlJobData(IDictionary<string, object> configuration)
        {
            ConnectionString = configuration.GetValue(Dynamics365Constants.KeyName.ConnectionString, string.Empty);
            SqlPageSize = configuration.GetValue(Dynamics365Constants.KeyName.SqlPageSize, 0);
            SqlDataCount = configuration.GetValue(Dynamics365Constants.KeyName.SqlDataCount, 0);
        }

        public string ConnectionString { get; set; }
        public int SqlPageSize { get; set; }
        public int? SqlDataCount { get; set; }
    }
}
