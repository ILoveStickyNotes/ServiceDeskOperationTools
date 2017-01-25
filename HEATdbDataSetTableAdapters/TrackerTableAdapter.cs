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
    [HelpKeyword("vs.data.TableAdapter")]
    [DesignerCategory("code")]
    [ToolboxItem(true)]
    [DataObject(true)]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    public class TrackerTableAdapter : Component
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get { return _clearBeforeFill; }
            set { _clearBeforeFill = value; }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TrackerTableAdapter()
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
                DataSetTable = "Tracker",
                ColumnMappings =
                {
                    {
                        "LoginID",
                        "LoginID"
                    },
                    {
                        "FullName",
                        "FullName"
                    },
                    {
                        "HEATPass",
                        "HEATPass"
                    },
                    {
                        "SecGroup",
                        "SecGroup"
                    },
                    {
                        "Manager",
                        "Manager"
                    },
                    {
                        "Status",
                        "Status"
                    },
                    {
                        "ModPWDate",
                        "ModPWDate"
                    },
                    {
                        "ModWho",
                        "ModWho"
                    },
                    {
                        "ModDate",
                        "ModDate"
                    },
                    {
                        "ModTime",
                        "ModTime"
                    },
                    {
                        "DefTracker",
                        "DefTracker"
                    },
                    {
                        "eMailName",
                        "eMailName"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Tracker] WHERE (([LoginID] = @Original_LoginID) AND ((@IsNull_FullName = 1 AND [FullName] IS NULL) OR ([FullName] = @Original_FullName)) AND ((@IsNull_HEATPass = 1 AND [HEATPass] IS NULL) OR ([HEATPass] = @Original_HEATPass)) AND ((@IsNull_SecGroup = 1 AND [SecGroup] IS NULL) OR ([SecGroup] = @Original_SecGroup)) AND ((@IsNull_Manager = 1 AND [Manager] IS NULL) OR ([Manager] = @Original_Manager)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)) AND ((@IsNull_ModPWDate = 1 AND [ModPWDate] IS NULL) OR ([ModPWDate] = @Original_ModPWDate)) AND ((@IsNull_ModWho = 1 AND [ModWho] IS NULL) OR ([ModWho] = @Original_ModWho)) AND ((@IsNull_ModDate = 1 AND [ModDate] IS NULL) OR ([ModDate] = @Original_ModDate)) AND ((@IsNull_ModTime = 1 AND [ModTime] IS NULL) OR ([ModTime] = @Original_ModTime)) AND ((@IsNull_DefTracker = 1 AND [DefTracker] IS NULL) OR ([DefTracker] = @Original_DefTracker)) AND ((@IsNull_eMailName = 1 AND [eMailName] IS NULL) OR ([eMailName] = @Original_eMailName)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FullName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FullName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FullName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FullName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HEATPass", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATPass", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HEATPass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATPass", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SecGroup", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecGroup", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SecGroup", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecGroup", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Manager", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Manager", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Manager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Manager", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ModPWDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModPWDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ModPWDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModPWDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ModWho", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModWho", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ModWho", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModWho", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ModDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ModTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DefTracker", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DefTracker", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DefTracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DefTracker", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_eMailName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "eMailName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_eMailName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "eMailName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Tracker] ([LoginID], [FullName], [HEATPass], [SecGroup], [Manager], [Status], [ModPWDate], [ModWho], [ModDate], [ModTime], [DefTracker], [eMailName]) VALUES (@LoginID, @FullName, @HEATPass, @SecGroup, @Manager, @Status, @ModPWDate, @ModWho, @ModDate, @ModTime, @DefTracker, @eMailName);\r\nSELECT LoginID, FullName, HEATPass, SecGroup, Manager, Status, ModPWDate, ModWho, ModDate, ModTime, DefTracker, eMailName FROM Tracker WHERE (LoginID = @LoginID)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FullName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FullName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HEATPass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATPass", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SecGroup", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecGroup", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Manager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Manager", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModPWDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModPWDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModWho", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModWho", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DefTracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DefTracker", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@eMailName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "eMailName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Tracker] SET [LoginID] = @LoginID, [FullName] = @FullName, [HEATPass] = @HEATPass, [SecGroup] = @SecGroup, [Manager] = @Manager, [Status] = @Status, [ModPWDate] = @ModPWDate, [ModWho] = @ModWho, [ModDate] = @ModDate, [ModTime] = @ModTime, [DefTracker] = @DefTracker, [eMailName] = @eMailName WHERE (([LoginID] = @Original_LoginID) AND ((@IsNull_FullName = 1 AND [FullName] IS NULL) OR ([FullName] = @Original_FullName)) AND ((@IsNull_HEATPass = 1 AND [HEATPass] IS NULL) OR ([HEATPass] = @Original_HEATPass)) AND ((@IsNull_SecGroup = 1 AND [SecGroup] IS NULL) OR ([SecGroup] = @Original_SecGroup)) AND ((@IsNull_Manager = 1 AND [Manager] IS NULL) OR ([Manager] = @Original_Manager)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)) AND ((@IsNull_ModPWDate = 1 AND [ModPWDate] IS NULL) OR ([ModPWDate] = @Original_ModPWDate)) AND ((@IsNull_ModWho = 1 AND [ModWho] IS NULL) OR ([ModWho] = @Original_ModWho)) AND ((@IsNull_ModDate = 1 AND [ModDate] IS NULL) OR ([ModDate] = @Original_ModDate)) AND ((@IsNull_ModTime = 1 AND [ModTime] IS NULL) OR ([ModTime] = @Original_ModTime)) AND ((@IsNull_DefTracker = 1 AND [DefTracker] IS NULL) OR ([DefTracker] = @Original_DefTracker)) AND ((@IsNull_eMailName = 1 AND [eMailName] IS NULL) OR ([eMailName] = @Original_eMailName)));\r\nSELECT LoginID, FullName, HEATPass, SecGroup, Manager, Status, ModPWDate, ModWho, ModDate, ModTime, DefTracker, eMailName FROM Tracker WHERE (LoginID = @LoginID)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FullName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FullName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HEATPass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATPass", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SecGroup", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecGroup", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Manager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Manager", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModPWDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModPWDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModWho", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModWho", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DefTracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DefTracker", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@eMailName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "eMailName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FullName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FullName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FullName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FullName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HEATPass", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATPass", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HEATPass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATPass", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SecGroup", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecGroup", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SecGroup", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SecGroup", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Manager", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Manager", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Manager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Manager", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Status", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ModPWDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModPWDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ModPWDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModPWDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ModWho", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModWho", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ModWho", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModWho", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ModDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ModTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DefTracker", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DefTracker", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DefTracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DefTracker", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_eMailName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "eMailName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_eMailName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "eMailName", DataRowVersion.Original, false, (object) null,
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
                "SELECT LoginID, FullName, HEATPass, SecGroup, Manager, Status, ModPWDate, ModWho, ModDate, ModTime, DefTracker, eMailName FROM dbo.Tracker";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Fill(HeaTdbDataSet.TrackerDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        [DebuggerNonUserCode]
        public virtual HeaTdbDataSet.TrackerDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.TrackerDataTable trackerDataTable = new HeaTdbDataSet.TrackerDataTable();
            Adapter.Fill((DataTable) trackerDataTable);
            return trackerDataTable;
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.TrackerDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Tracker");
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return Adapter.Update(new DataRow[1] {dataRow});
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return Adapter.Update(dataRows);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(string originalLoginId, string originalFullName, string originalHeatPass,
            string originalSecGroup, string originalManager, int? originalStatus, string originalModPwDate,
            string originalModWho, string originalModDate, string originalModTime, string originalDefTracker,
            string originalEMailName)
        {
            if (originalLoginId == null)
                throw new ArgumentNullException("originalLoginId");
            Adapter.DeleteCommand.Parameters[0].Value = (object) originalLoginId;
            if (originalFullName == null)
            {
                Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[2].Value = (object) originalFullName;
            }
            if (originalHeatPass == null)
            {
                Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[4].Value = (object) originalHeatPass;
            }
            if (originalSecGroup == null)
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[6].Value = (object) originalSecGroup;
            }
            if (originalManager == null)
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[8].Value = (object) originalManager;
            }
            if (originalStatus.HasValue)
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[10].Value = (object) originalStatus.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
            }
            if (originalModPwDate == null)
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[12].Value = (object) originalModPwDate;
            }
            if (originalModWho == null)
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[14].Value = (object) originalModWho;
            }
            if (originalModDate == null)
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[16].Value = (object) originalModDate;
            }
            if (originalModTime == null)
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[18].Value = (object) originalModTime;
            }
            if (originalDefTracker == null)
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[20].Value = (object) originalDefTracker;
            }
            if (originalEMailName == null)
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[22].Value = (object) originalEMailName;
            }
            ConnectionState state = Adapter.DeleteCommand.Connection.State;
            if ((Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
                Adapter.DeleteCommand.Connection.Open();
            try
            {
                return Adapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                    Adapter.DeleteCommand.Connection.Close();
            }
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [DebuggerNonUserCode]
        public virtual int Insert(string loginId, string fullName, string heatPass, string secGroup, string manager,
            int? status, string modPwDate, string modWho, string modDate, string modTime, string defTracker,
            string eMailName)
        {
            if (loginId == null)
                throw new ArgumentNullException("loginId");
            Adapter.InsertCommand.Parameters[0].Value = (object) loginId;
            if (fullName == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) fullName;
            if (heatPass == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) heatPass;
            if (secGroup == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) secGroup;
            if (manager == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) manager;
            if (status.HasValue)
                Adapter.InsertCommand.Parameters[5].Value = (object) status.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            if (modPwDate == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) modPwDate;
            if (modWho == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) modWho;
            if (modDate == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) modDate;
            if (modTime == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) modTime;
            if (defTracker == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) defTracker;
            if (eMailName == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) eMailName;
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

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string loginId, string fullName, string heatPass, string secGroup, string manager,
            int? status, string modPwDate, string modWho, string modDate, string modTime, string defTracker,
            string eMailName, string originalLoginId, string originalFullName, string originalHeatPass,
            string originalSecGroup, string originalManager, int? originalStatus, string originalModPwDate,
            string originalModWho, string originalModDate, string originalModTime, string originalDefTracker,
            string originalEMailName)
        {
            if (loginId == null)
                throw new ArgumentNullException("loginId");
            Adapter.UpdateCommand.Parameters[0].Value = (object) loginId;
            if (fullName == null)
                Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[1].Value = (object) fullName;
            if (heatPass == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) heatPass;
            if (secGroup == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) secGroup;
            if (manager == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) manager;
            if (status.HasValue)
                Adapter.UpdateCommand.Parameters[5].Value = (object) status.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            if (modPwDate == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) modPwDate;
            if (modWho == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) modWho;
            if (modDate == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) modDate;
            if (modTime == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) modTime;
            if (defTracker == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) defTracker;
            if (eMailName == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) eMailName;
            if (originalLoginId == null)
                throw new ArgumentNullException("originalLoginId");
            Adapter.UpdateCommand.Parameters[12].Value = (object) originalLoginId;
            if (originalFullName == null)
            {
                Adapter.UpdateCommand.Parameters[13].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[13].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[14].Value = (object) originalFullName;
            }
            if (originalHeatPass == null)
            {
                Adapter.UpdateCommand.Parameters[15].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[15].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[16].Value = (object) originalHeatPass;
            }
            if (originalSecGroup == null)
            {
                Adapter.UpdateCommand.Parameters[17].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[17].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[18].Value = (object) originalSecGroup;
            }
            if (originalManager == null)
            {
                Adapter.UpdateCommand.Parameters[19].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[19].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[20].Value = (object) originalManager;
            }
            if (originalStatus.HasValue)
            {
                Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[22].Value = (object) originalStatus.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            if (originalModPwDate == null)
            {
                Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[24].Value = (object) originalModPwDate;
            }
            if (originalModWho == null)
            {
                Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[26].Value = (object) originalModWho;
            }
            if (originalModDate == null)
            {
                Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[28].Value = (object) originalModDate;
            }
            if (originalModTime == null)
            {
                Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[30].Value = (object) originalModTime;
            }
            if (originalDefTracker == null)
            {
                Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[32].Value = (object) originalDefTracker;
            }
            if (originalEMailName == null)
            {
                Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[34].Value = (object) originalEMailName;
            }
            ConnectionState state = Adapter.UpdateCommand.Connection.State;
            if ((Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
                Adapter.UpdateCommand.Connection.Open();
            try
            {
                return Adapter.UpdateCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                    Adapter.UpdateCommand.Connection.Close();
            }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public virtual int Update(string fullName, string heatPass, string secGroup, string manager, int? status,
            string modPwDate, string modWho, string modDate, string modTime, string defTracker, string eMailName,
            string originalLoginId, string originalFullName, string originalHeatPass, string originalSecGroup,
            string originalManager, int? originalStatus, string originalModPwDate, string originalModWho,
            string originalModDate, string originalModTime, string originalDefTracker, string originalEMailName)
        {
            return Update(originalLoginId, fullName, heatPass, secGroup, manager, status, modPwDate, modWho,
                modDate, modTime, defTracker, eMailName, originalLoginId, originalFullName, originalHeatPass,
                originalSecGroup, originalManager, originalStatus, originalModPwDate, originalModWho, originalModDate,
                originalModTime, originalDefTracker, originalEMailName);
        }
    }
}