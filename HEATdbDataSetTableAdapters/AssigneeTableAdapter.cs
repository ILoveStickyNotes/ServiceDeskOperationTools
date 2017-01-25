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
    [ToolboxItem(true)]
    [DesignerCategory("code")]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObject(true)]
    public class AssigneeTableAdapter : Component
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public AssigneeTableAdapter()
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
                DataSetTable = "Assignee",
                ColumnMappings =
                {
                    {
                        "Assignee",
                        "Assignee"
                    },
                    {
                        "GroupName",
                        "GroupName"
                    },
                    {
                        "CallType",
                        "CallType"
                    },
                    {
                        "Phone",
                        "Phone"
                    },
                    {
                        "Pager",
                        "Pager"
                    },
                    {
                        "LoginID",
                        "LoginID"
                    },
                    {
                        "Comments",
                        "Comments"
                    },
                    {
                        "EMail",
                        "EMail"
                    },
                    {
                        "PhoneExt",
                        "PhoneExt"
                    },
                    {
                        "Availability",
                        "Availability"
                    },
                    {
                        "OutOfOffice",
                        "OutOfOffice"
                    },
                    {
                        "CellEmail",
                        "CellEmail"
                    },
                    {
                        "MgrEmail",
                        "MgrEmail"
                    },
                    {
                        "ModBy",
                        "ModBy"
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
                        "CellPhone",
                        "CellPhone"
                    }
                }
            });
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Assignee] ([Assignee], [GroupName], [CallType], [Phone], [Pager], [LoginID], [Comments], [EMail], [PhoneExt], [Availability], [OutOfOffice], [CellEmail], [MgrEmail], [ModBy], [ModDate], [ModTime], [CellPhone]) VALUES (@Assignee, @GroupName, @CallType, @Phone, @Pager, @LoginID, @Comments, @EMail, @PhoneExt, @Availability, @OutOfOffice, @CellEmail, @MgrEmail, @ModBy, @ModDate, @ModTime, @CellPhone)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Comments", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Comments", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EMail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@PhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Availability", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@OutOfOffice", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OutOfOffice", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CellEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@MgrEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CellPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellPhone", DataRowVersion.Current, false, (object) null,
                "", "", ""));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private void InitConnection()
        {
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private void InitCommandCollection()
        {
            _commandCollection = new SqlCommand[1];
            _commandCollection[0] = new SqlCommand();
            _commandCollection[0].Connection = Connection;
            _commandCollection[0].CommandText =
                "SELECT Assignee, GroupName, CallType, Phone, Pager, LoginID, Comments, EMail, PhoneExt, Availability, OutOfOffice, CellEmail, MgrEmail, ModBy, ModDate, ModTime, CellPhone FROM dbo.Assignee";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        public virtual int Fill(HeaTdbDataSet.AssigneeDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual HeaTdbDataSet.AssigneeDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.AssigneeDataTable assigneeDataTable = new HeaTdbDataSet.AssigneeDataTable();
            Adapter.Fill((DataTable) assigneeDataTable);
            return assigneeDataTable;
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.AssigneeDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Assignee");
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return Adapter.Update(new DataRow[1] {dataRow});
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow[] dataRows)
        {
            return Adapter.Update(dataRows);
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(string assignee, string groupName, string callType, string phone, string pager,
            string loginId, string comments, string eMail, string phoneExt, string availability, string outOfOffice,
            string cellEmail, string mgrEmail, string modBy, string modDate, string modTime, string cellPhone)
        {
            if (assignee == null)
                throw new ArgumentNullException("assignee");
            Adapter.InsertCommand.Parameters[0].Value = (object) assignee;
            if (groupName == null)
                throw new ArgumentNullException("groupName");
            Adapter.InsertCommand.Parameters[1].Value = (object) groupName;
            if (callType == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) callType;
            if (phone == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) phone;
            if (pager == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) pager;
            if (loginId == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) loginId;
            if (comments == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) comments;
            if (eMail == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) eMail;
            if (phoneExt == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) phoneExt;
            if (availability == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) availability;
            if (outOfOffice == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) outOfOffice;
            if (cellEmail == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) cellEmail;
            if (mgrEmail == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) mgrEmail;
            if (modBy == null)
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) modBy;
            if (modDate == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) modDate;
            if (modTime == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) modTime;
            if (cellPhone == null)
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) cellPhone;
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