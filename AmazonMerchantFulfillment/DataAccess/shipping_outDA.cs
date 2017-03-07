using AmazonMerchantFulfillment.DataDefinition;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AmazonMerchantFulfillment.DataAccess
{
    public class shipping_outDA : BaseDA
    {
        /// <summary>
        /// Update data changes to database
        /// </summary>
        /// <param name="dsPara"> Parameter dataset </param>
        public void Update(string pk, string name)
        {
            using (MySqlConnection conn = GetMySQLConnection())
            {
                string sql = "update abc set name = @name where pk = @pk";

                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@pk", pk);
                    cmd.Parameters.AddWithValue("@name", name);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    conn.Close();
                    throw;
                }
                conn.Close();
            }
        }
    }
}