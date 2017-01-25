using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HelpdeskOperationsTools.HEATdbDataSetTableAdapters
{
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [HelpKeyword("vs.data.TableAdapter")]
    [ToolboxItem(true)]
    [DataObject(true)]
    [DesignerCategory("code")]
    public class HeatcaiTableAdapter : Component
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal SqlDataAdapter Adapter
        {
            get
            {
                if (_adapter == null)
                    InitAdapter();
                return _adapter;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        internal SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    InitConnection();
                return _connection;
            }
            set
            {
                _connection = value;
                if (Adapter.InsertCommand != null)
                    Adapter.InsertCommand.Connection = value;
                if (Adapter.DeleteCommand != null)
                    Adapter.DeleteCommand.Connection = value;
                if (Adapter.UpdateCommand != null)
                    Adapter.UpdateCommand.Connection = value;
                for (int index = 0; index < CommandCollection.Length; ++index)
                {
                    if (CommandCollection[index] != null)
                        CommandCollection[index].Connection = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        internal SqlTransaction Transaction
        {
            get { return _transaction; }
            set
            {
                _transaction = value;
                for (int index = 0; index < CommandCollection.Length; ++index)
                    CommandCollection[index].Transaction = _transaction;
                if (Adapter != null && Adapter.DeleteCommand != null)
                    Adapter.DeleteCommand.Transaction = _transaction;
                if (Adapter != null && Adapter.InsertCommand != null)
                    Adapter.InsertCommand.Transaction = _transaction;
                if (Adapter == null || Adapter.UpdateCommand == null)
                    return;
                Adapter.UpdateCommand.Transaction = _transaction;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        protected SqlCommand[] CommandCollection
        {
            get
            {
                if (_commandCollection == null)
                    InitCommandCollection();
                return _commandCollection;
            }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get { return _clearBeforeFill; }
            set { _clearBeforeFill = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public HeatcaiTableAdapter()
        {
            ClearBeforeFill = true;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private void InitAdapter()
        {
            _adapter = new SqlDataAdapter();
            _adapter.TableMappings.Add((object) new DataTableMapping()
            {
                SourceTable = "Table",
                DataSetTable = "HEATCAI",
                ColumnMappings =
                {
                    {
                        "LoginID",
                        "LoginID"
                    },
                    {
                        "CustID",
                        "CustID"
                    },
                    {
                        "CustType",
                        "CustType"
                    },
                    {
                        "Password",
                        "Password"
                    },
                    {
                        "SecretQ",
                        "SecretQ"
                    },
                    {
                        "SecretA",
                        "SecretA"
                    },
                    {
                        "Flags",
                        "Flags"
                    },
                    {
                        "DTCreated",
                        "DTCreated"
                    },
                    {
                        "DTLastMod",
                        "DTLastMod"
                    },
                    {
                        "LastModBy",
                        "LastModBy"
                    }
                }
            });
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[HEATCAI] ([LoginID], [CustID], [CustType], [Password], [SecretQ], [SecretA], [Flags], [DTCreated], [DTLastMod], [LastModBy]) VALUES (@LoginID, @CustID, @CustType, @Password, @SecretQ, @SecretA, @Flags, @DTCreated, @DTLastMod, @LastModBy)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Password", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SecretQ", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecretQ", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SecretA", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecretA", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Flags", SqlDbType.Int, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "Flags", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTCreated", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTCreated", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LastModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastModBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            _commandCollection = new SqlCommand[1];
            _commandCollection[0] = new SqlCommand();
            _commandCollection[0].Connection = Connection;
            _commandCollection[0].CommandText =
                "SELECT LoginID, CustID, CustType, Password, SecretQ, SecretA, Flags, DTCreated, DTLastMod, LastModBy FROM dbo.HEATCAI";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        public virtual int Fill(HeaTdbDataSet.HeatcaiDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual HeaTdbDataSet.HeatcaiDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.HeatcaiDataTable heatcaiDataTable = new HeaTdbDataSet.HeatcaiDataTable();
            Adapter.Fill((DataTable) heatcaiDataTable);
            return heatcaiDataTable;
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.HeatcaiDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "HEATCAI");
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return Adapter.Update(new DataRow[1] {dataRow});
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(DataRow[] dataRows)
        {
            return Adapter.Update(dataRows);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public virtual int Insert(string loginId, string custId, string custType, string password, string secretQ,
            string secretA, int? flags, int? dtCreated, int? dtLastMod, string lastModBy)
        {
            if (loginId == null)
                throw new ArgumentNullException("loginId");
            Adapter.InsertCommand.Parameters[0].Value = (object) loginId;
            if (custId == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) custId;
            if (custType == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) custType;
            if (password == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) password;
            if (secretQ == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) secretQ;
            if (secretA == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) secretA;
            if (flags.HasValue)
                Adapter.InsertCommand.Parameters[6].Value = (object) flags.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            if (dtCreated.HasValue)
                Adapter.InsertCommand.Parameters[7].Value = (object) dtCreated.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            if (dtLastMod.HasValue)
                Adapter.InsertCommand.Parameters[8].Value = (object) dtLastMod.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            if (lastModBy == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) lastModBy;
            ConnectionState state = Adapter.InsertCommand.Connection.State;
            if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
                Adapter.InsertCommand.Connection.Open();
            try
            {
                return Adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                    Adapter.InsertCommand.Connection.Close();
            }
        }
    }
}