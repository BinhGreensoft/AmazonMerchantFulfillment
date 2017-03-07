using System;
using System.Data.SqlClient;
using System.Data;

namespace AmazonMerchantFulfillment.DataAccess
{
    internal class DataAdapter
    {
        internal static DataSet Fill(SqlCommand selectCommand)
        {
            SqlDataAdapter da = new SqlDataAdapter(selectCommand);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        internal static void Update(DataSet dataSet, string tableName, SqlCommand insertCommand, SqlCommand updateCommand, SqlCommand deleteCommand)
        {
            ConnectionState cs = OpenConnection(insertCommand, updateCommand, deleteCommand);

            if (deleteCommand != null) ExecDeleteCommand(dataSet.Tables[tableName], deleteCommand);
            if (updateCommand != null) ExecUpdateCommand(dataSet.Tables[tableName], updateCommand);
            if (insertCommand != null) ExecInsertCommand(dataSet.Tables[tableName], insertCommand);

            CloseConnection(cs, insertCommand, updateCommand, deleteCommand);
        }

        #region Execute commands
        private static void ExecDeleteCommand(DataTable tab, SqlCommand command)
        {
            if (command == null) return;

            DataRow curr = null;
            try
            {
                foreach (DataRow r in tab.Rows)
                {
                    if (r.RowState == DataRowState.Deleted)
                    {
                        r.ClearErrors();
                        curr = r;

                        SetParameterValues(r, command, DataRowVersion.Original);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                SetError(curr, ex);
                throw;
            }
        }

        private static void ExecUpdateCommand(DataTable tab, SqlCommand command)
        {
            if (command == null) return;

            DataRow curr = null;
            try
            {
                foreach (DataRow r in tab.Rows)
                {
                    if (r.RowState == DataRowState.Modified)
                    {
                        r.ClearErrors();
                        curr = r;

                        SetParameterValues(r, command, DataRowVersion.Current);
                        command.ExecuteNonQuery();
                        GetParameterValues(r, command);
                    }
                }
            }
            catch (Exception ex)
            {
                SetError(curr, ex);
                throw;
            }
        }

        private static void ExecInsertCommand(DataTable tab, SqlCommand command)
        {
            if (command == null) return;

            DataRow curr = null;
            try
            {
                foreach (DataRow r in tab.Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        r.ClearErrors();
                        curr = r;

                        SetParameterValues(r, command, DataRowVersion.Current);
                        command.ExecuteNonQuery();
                        GetParameterValues(r, command);
                    }
                }
            }
            catch (Exception ex)
            {
                SetError(curr, ex);
                throw;
            }
        }
        #endregion

        #region Parameter & error
        private static void SetParameterValues(DataRow row, SqlCommand command, DataRowVersion rowVersion)
        {
            foreach (SqlParameter para in command.Parameters)
            {
                string sourceColumn = para.SourceColumn;
                if (!string.IsNullOrEmpty(sourceColumn))
                {
                    if (para.Direction != ParameterDirection.Output && para.Direction != ParameterDirection.ReturnValue)
                    {
                        para.Value = row[sourceColumn, rowVersion];
                    }
                }
            }
        }

        private static void GetParameterValues(DataRow row, SqlCommand command)
        {
            foreach (SqlParameter para in command.Parameters)
            {
                string sourceColumn = para.SourceColumn;
                if (!string.IsNullOrEmpty(sourceColumn))
                {
                    if (para.Direction == ParameterDirection.Output ||
                        para.Direction == ParameterDirection.ReturnValue ||
                        para.Direction == ParameterDirection.InputOutput)
                    {
                        row[sourceColumn] = para.Value;
                    }
                }
            }
        }

        private static void SetError(DataRow r, Exception e)
        {
            if (r != null)
            {
                r.RowError = e.Message;
                foreach (DataColumn col in r.Table.Columns)
                {
                    if (e.Message.Contains(col.ColumnName)) r.SetColumnError(col, e.Message);
                }
            }
        }
        #endregion

        #region Connection
        private static ConnectionState OpenConnection(SqlCommand insertCommand, SqlCommand updateCommand, SqlCommand deleteCommand)
        {
            SqlCommand cmd = null;
            if (insertCommand != null) cmd = insertCommand;
            else
                if (updateCommand != null) cmd = updateCommand;
                else
                    if (deleteCommand != null) cmd = deleteCommand;

            if (cmd == null) return ConnectionState.Open;

            ConnectionState connState = cmd.Connection.State;
            if (connState != ConnectionState.Open) cmd.Connection.Open();

            return connState;
        }

        private static void CloseConnection(ConnectionState connState, SqlCommand insertCommand, SqlCommand updateCommand, SqlCommand deleteCommand)
        {
            SqlCommand cmd = null;
            if (insertCommand != null) cmd = insertCommand;
            else
                if (updateCommand != null) cmd = updateCommand;
                else
                    if (deleteCommand != null) cmd = deleteCommand;

            if (cmd != null && connState == ConnectionState.Closed) cmd.Connection.Close();
        }
        #endregion
    }
}
