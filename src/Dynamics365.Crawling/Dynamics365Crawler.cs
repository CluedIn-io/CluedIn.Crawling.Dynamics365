using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Infrastructure.Factories;

namespace CluedIn.Crawling.Dynamics365
{
    public class Dynamics365Crawler : ICrawlerDataGenerator
    {
        private readonly IDynamics365ClientFactory clientFactory;
        public Dynamics365Crawler(IDynamics365ClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is Dynamics365CrawlJobData dynamics365crawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(dynamics365crawlJobData);

            foreach (var obj in  client.GetAsync<ResultList<Account>>("accounts").Result?.Value)
            {
                yield return obj;
            }
        }
    }
}
