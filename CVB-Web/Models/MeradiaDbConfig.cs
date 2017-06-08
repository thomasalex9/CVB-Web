using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace CVB_Web.Models
{
    public class MeradiaDbConfig : DbConfiguration
    {
        public MeradiaDbConfig()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(5, TimeSpan.FromSeconds(30)));
        }
    }
}