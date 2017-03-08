using MarketplaceWebServiceOrders;
using MarketplaceWebServiceOrders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMerchantFulfillment.Business
{
    public class OrderBs : BaseBs
    {
        /// <summary>
        /// Get order information from Amazon order id
        /// </summary>
        /// <param name="amazonOrderId"></param>
        /// <returns></returns>
        public bool GetOrder (string amazonOrderId)
        {
            MarketplaceWebServiceOrdersConfig config = new MarketplaceWebServiceOrdersConfig();
            config.ServiceURL = AmazonServiceURL;

            MarketplaceWebServiceOrders.MarketplaceWebServiceOrders client = new MarketplaceWebServiceOrdersClient(AmazonAccessKey, AmazonSecretKey, AmazonAppName, AmazonAppVersion, config);

            GetOrderRequest request = new GetOrderRequest();
            request.SellerId = AmazonSellerId;
            request.MWSAuthToken = AmazonMWSAuthToken;

            List<string> amazonOrderIds = new List<string>();
            request.AmazonOrderId = amazonOrderIds;

            try
            {
                GetOrderResponse response = client.GetOrder(request);
            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(ex.Message)) ErrorMessage = "Cannot connect to Amazon.\nPlease check your network.";
                else ErrorMessage = ex.Message;
                return false;
            }

            return true;
        }
    }
}
