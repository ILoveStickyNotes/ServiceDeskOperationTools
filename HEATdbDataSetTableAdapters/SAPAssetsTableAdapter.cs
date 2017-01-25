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
    [DesignerCategory("code")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObject(true)]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [ToolboxItem(true)]
    public class SapAssetsTableAdapter : Component
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected SqlCommand[] CommandCollection
        {
            get
            {
                if (_commandCollection == null)
                    InitCommandCollection();
                return _commandCollection;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public bool ClearBeforeFill
        {
            get { return _clearBeforeFill; }
            set { _clearBeforeFill = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public SapAssetsTableAdapter()
        {
            ClearBeforeFill = true;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            _adapter = new SqlDataAdapter();
            _adapter.TableMappings.Add((object) new DataTableMapping()
            {
                SourceTable = "Table",
                DataSetTable = "SAPAssets",
                ColumnMappings =
                {
                    {
                        "AssetNumber",
                        "AssetNumber"
                    },
                    {
                        "SubNumber",
                        "SubNumber"
                    },
                    {
                        "Description",
                        "Description"
                    },
                    {
                        "SubClass",
                        "SubClass"
                    },
                    {
                        "SerialNumber",
                        "SerialNumber"
                    },
                    {
                        "Location",
                        "Location"
                    },
                    {
                        "BldgRoom",
                        "BldgRoom"
                    },
                    {
                        "CostCenter",
                        "CostCenter"
                    },
                    {
                        "CapitalizationDate",
                        "CapitalizationDate"
                    },
                    {
                        "Cost",
                        "Cost"
                    },
                    {
                        "InventoryNumber",
                        "InventoryNumber"
                    },
                    {
                        "Status",
                        "Status"
                    },
                    {
                        "FunctionalArea",
                        "FunctionalArea"
                    }
                }
            });
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[SAPAssets] ([AssetNumber], [SubNumber], [Description], [SubClass], [SerialNumber], [Location], [BldgRoom], [CostCenter], [CapitalizationDate], [Cost], [InventoryNumber], [Status], [FunctionalArea]) VALUES (@AssetNumber, @SubNumber, @Description, @SubClass, @SerialNumber, @Location, @BldgRoom, @CostCenter, @CapitalizationDate, @Cost, @InventoryNumber, @Status, @FunctionalArea)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AssetNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SubNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Description", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SubClass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubClass", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SerialNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Location", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@BldgRoom", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgRoom", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CostCenter", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CostCenter", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CapitalizationDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CapitalizationDate", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Cost", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 2, "Cost", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@InventoryNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "InventoryNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FunctionalArea", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FunctionalArea", DataRowVersion.Current, false,
                (object) null, "", "", ""));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
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
                "SELECT AssetNumber, SubNumber, Description, SubClass, SerialNumber, Location, BldgRoom, CostCenter, CapitalizationDate, Cost, InventoryNumber, Status, FunctionalArea FROM dbo.SAPAssets";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public virtual int Fill(HeaTdbDataSet.SapAssetsDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual HeaTdbDataSet.SapAssetsDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.SapAssetsDataTable sapAssetsDataTable = new HeaTdbDataSet.SapAssetsDataTable();
            Adapter.Fill((DataTable) sapAssetsDataTable);
            return sapAssetsDataTable;
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.SapAssetsDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "SAPAssets");
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
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
        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Insert(string assetNumber, string subNumber, string description, string subClass,
            string serialNumber, string location, string bldgRoom, string costCenter, string capitalizationDate,
            Decimal? cost, string inventoryNumber, string status, string functionalArea)
        {
            if (assetNumber == null)
                Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[0].Value = (object) assetNumber;
            if (subNumber == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) subNumber;
            if (description == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) description;
            if (subClass == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) subClass;
            if (serialNumber == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) serialNumber;
            if (location == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) location;
            if (bldgRoom == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) bldgRoom;
            if (costCenter == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) costCenter;
            if (capitalizationDate == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) capitalizationDate;
            if (cost.HasValue)
                Adapter.InsertCommand.Parameters[9].Value = (object) cost.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            if (inventoryNumber == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) inventoryNumber;
            if (status == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) status;
            if (functionalArea == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) functionalArea;
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