using System.Data;

namespace AmazonMerchantFulfillment.DataDefinition
{
    public class Order : DataSet
    {
        public const string TableName = "Order";
        public const string PK = "PK";

        public Order()
        {
            BuildStructure();
        }

        private void BuildStructure()
        {
            var tab = new DataTable(TableName);
            tab.Columns.Add(PK, typeof(System.Int64));

            this.Tables.Add(tab);
        }
    }
}
