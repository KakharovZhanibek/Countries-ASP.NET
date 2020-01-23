using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Implementation
{
    public class GetConnection
    {
        protected IDbConnection db_con
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            }
        }
    }
}