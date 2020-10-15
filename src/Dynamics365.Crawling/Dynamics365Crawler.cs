using System.Collections.Generic;
using System.Linq;
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

            foreach (var account in client.Get<Account>("Accounts", "AccountId"))
            {
                yield return account;
            }

        }

    }
}
