using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Dynamics365.Infrastructure
{
    public static class PrimaryKeyMappings
    {
        public static string GetPrimaryKey(string tableName)
        {
            switch (tableName)
            {
                case "Account":
                    return "AccountId";
                default:
                    throw new ArgumentException($"Unknown table name {tableName}. Not able to determine primary key.");
            }
        }
    }
}
