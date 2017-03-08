namespace AmazonMerchantFulfillment.Business
{
    public class BaseBs
    {
        public string ErrorMessage { get; set; }

        #region Amazon configuration
        protected internal string AmazonAccessKey
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonAccessKey"];
            }
        }

        protected internal string AmazonSecretKey
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonSecretKey"];
            }
        }

        protected internal string AmazonAppName
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonAppName"];
            }
        }

        protected internal string AmazonAppVersion
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonAppVersion"];
            }
        }

        protected internal string AmazonServiceURL
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonServiceURL"];
            }
        }

        protected internal string AmazonSellerId
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonSellerId"];
            }
        }

        protected internal string AmazonMWSAuthToken
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["AmazonMWSAuthToken"];
            }
        }
        #endregion
    }
}
