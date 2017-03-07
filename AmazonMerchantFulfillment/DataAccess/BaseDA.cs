using System.Data.SqlClient;

namespace AmazonMerchantFulfillment.DataAccess
{
    public class BaseDA
    {
        internal protected SqlConnection GetSQLConnection()
        {
            string conns = System.Configuration.ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            return (new SqlConnection(conns));
        }
    }
}
