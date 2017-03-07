using System.Data;

namespace AmazonMerchantFulfillment.DataDefinition
{
    public class Para : DataSet
    {
        public const string TableName = "Para";
        public const string PK = "PK";
        public const string ParaId = "ParaId";
        public const string ParaName = "ParaName";
        public const string ParaValue = "ParaValue";

        public Para()
        {
            BuildStructure();
        }

        private void BuildStructure()
        {
            var tab = new DataTable(TableName);
            tab.Columns.Add(PK, typeof(System.Int64));
            tab.Columns.Add(ParaId, typeof(System.String));
            tab.Columns.Add(ParaName, typeof(System.String));
            tab.Columns.Add(ParaValue, typeof(System.String));

            this.Tables.Add(tab);
        }
    }
}
