using System.Collections.Generic;
using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Crawling.Dynamics365.Integration.Test
{
  public static class Dynamics365Configuration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { Dynamics365Constants.KeyName.ConnectionString, "Server=localhost;Database=Mock;Trusted_Connection=True;" },
                { Dynamics365Constants.KeyName.SqlPageSize, 5 },
                { Dynamics365Constants.KeyName.SqlDataCount, 10 },
            };
    }
  }
}
