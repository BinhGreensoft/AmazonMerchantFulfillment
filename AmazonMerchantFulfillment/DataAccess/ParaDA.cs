using AmazonMerchantFulfillment.DataDefinition;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AmazonMerchantFulfillment.DataAccess
{
    public class ParaDA : BaseDA
    {
        // Get parameters from Para table
        // If paraId is null, get all
        public Para GetData(object paraId)
        {
            SqlCommand cmd = new SqlCommand("ParaFetch", GetSQLConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (paraId != null && paraId.ToString() != string.Empty) cmd.Parameters.AddWithValue("@paraId", paraId);

            Para ds = new Para();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, Para.TableName );
            return ds;
        }

        private SqlCommand GetUpdateCmd(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("ParaUpdate", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@PK", SqlDbType.BigInt, 8, Para.PK);
            cmd.Parameters.Add("@ParaName", SqlDbType.NVarChar, 200, Para.ParaName);
            cmd.Parameters.Add("@ParaValue", SqlDbType.NVarChar, 200, Para.ParaValue);
            return cmd;
        }

        /// <summary>
        /// Update data changes to database
        /// </summary>
        /// <param name="dsPara"> Parameter dataset </param>
        public void Update(Para dsPara)
        {
            using (SqlConnection conn = GetSQLConnection())
            {
                SqlCommand upd = GetUpdateCmd(conn);

                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                upd.Transaction = trans;

                try
                {
                    DataAdapter.Update(dsPara, Para.TableName, null, upd, null);
                }
                catch (Exception)
                {
                    trans.Rollback();
                    conn.Close();
                    throw;
                }
                trans.Commit();
                conn.Close();
            }
        }
    }
}