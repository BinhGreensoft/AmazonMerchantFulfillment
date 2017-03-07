using System;
using AmazonMerchantFulfillment.DataDefinition;
using AmazonMerchantFulfillment.DataAccess;
using System.Data;

namespace AmazonMerchantFulfillment.Business
{
    public class ParaBs : BaseBs
    {
        /// <summary>
        /// Get list of parameters from database and input them to Para dataset
        /// </summary>
        /// <param name="ds"> Para dataset </param>
        /// <returns> true if success, false otherwise </returns>
        public bool GetData(ref Para ds)
        {
            shipping_outDA sp = new shipping_outDA();
            sp.Update("1", "Binh2");

            ParaDA da = new ParaDA();
            try
            {
                ds = da.GetData(DBNull.Value);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Update changed row from data set to database
        /// </summary>
        /// <param name="ds"> Para dataset </param>
        /// <returns> true if success, false otherwise </returns>
        public bool Update(Para dsPara)
        {
        	// Check if data is valid
            DataTable tab = dsPara.Tables[Para.TableName];
            decimal dec = 0;
            foreach (DataRow r in tab.Rows)
            {
                if (!decimal.TryParse(r[Para.ParaValue].ToString(), out dec))
                {
                    ErrorMessage = "Data type of [" + r[Para.ParaName] + "] is invalid!";
                    r.SetColumnError(Para.ParaValue, ErrorMessage);
                    return false;
                }
            }

            ParaDA da = new ParaDA();
            try
            {
                da.Update(dsPara);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
            dsPara.AcceptChanges();

            return true;

        }
    }
}
