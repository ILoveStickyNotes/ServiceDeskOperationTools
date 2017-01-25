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
    [DataObject(true)]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [HelpKeyword("vs.data.TableAdapter")]
    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public class AsgnmntTableAdapter : Component
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
        public AsgnmntTableAdapter()
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
                DataSetTable = "Asgnmnt",
                ColumnMappings =
                {
                    {
                        "AssignedBy",
                        "AssignedBy"
                    },
                    {
                        "DateAssign",
                        "DateAssign"
                    },
                    {
                        "TimeAssign",
                        "TimeAssign"
                    },
                    {
                        "GroupName",
                        "GroupName"
                    },
                    {
                        "Assignee",
                        "Assignee"
                    },
                    {
                        "Phone",
                        "Phone"
                    },
                    {
                        "Notes",
                        "Notes"
                    },
                    {
                        "DateAcknow",
                        "DateAcknow"
                    },
                    {
                        "TimeAcknow",
                        "TimeAcknow"
                    },
                    {
                        "DateResolv",
                        "DateResolv"
                    },
                    {
                        "TimeResolv",
                        "TimeResolv"
                    },
                    {
                        "Resolution",
                        "Resolution"
                    },
                    {
                        "CallID",
                        "CallID"
                    },
                    {
                        "HEATSeq",
                        "HEATSeq"
                    },
                    {
                        "EMail",
                        "EMail"
                    },
                    {
                        "Pager",
                        "Pager"
                    },
                    {
                        "DTLastMod",
                        "DTLastMod"
                    },
                    {
                        "WhoAcknow",
                        "WhoAcknow"
                    },
                    {
                        "WhoResolv",
                        "WhoResolv"
                    },
                    {
                        "LoginID",
                        "LoginID"
                    },
                    {
                        "PhoneExt",
                        "PhoneExt"
                    },
                    {
                        "TargetTime",
                        "TargetTime"
                    },
                    {
                        "TargetDate",
                        "TargetDate"
                    },
                    {
                        "SLAResTime",
                        "SLAResTime"
                    },
                    {
                        "TotalAsgnmntTime",
                        "TotalAsgnmntTime"
                    },
                    {
                        "Availability",
                        "Availability"
                    },
                    {
                        "CallType",
                        "CallType"
                    },
                    {
                        "Vacation",
                        "Vacation"
                    },
                    {
                        "ResolveOrder",
                        "ResolveOrder"
                    },
                    {
                        "GrpEmail",
                        "GrpEmail"
                    },
                    {
                        "MgrEmail",
                        "MgrEmail"
                    },
                    {
                        "WorkDate",
                        "WorkDate"
                    },
                    {
                        "WorkTime",
                        "WorkTime"
                    },
                    {
                        "WorkNotes",
                        "WorkNotes"
                    },
                    {
                        "CellEmail",
                        "CellEmail"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Asgnmnt] WHERE (((@IsNull_AssignedBy = 1 AND [AssignedBy] IS NULL) OR ([AssignedBy] = @Original_AssignedBy)) AND ((@IsNull_DateAssign = 1 AND [DateAssign] IS NULL) OR ([DateAssign] = @Original_DateAssign)) AND ((@IsNull_TimeAssign = 1 AND [TimeAssign] IS NULL) OR ([TimeAssign] = @Original_TimeAssign)) AND ((@IsNull_GroupName = 1 AND [GroupName] IS NULL) OR ([GroupName] = @Original_GroupName)) AND ((@IsNull_Assignee = 1 AND [Assignee] IS NULL) OR ([Assignee] = @Original_Assignee)) AND ((@IsNull_Phone = 1 AND [Phone] IS NULL) OR ([Phone] = @Original_Phone)) AND ((@IsNull_DateAcknow = 1 AND [DateAcknow] IS NULL) OR ([DateAcknow] = @Original_DateAcknow)) AND ((@IsNull_TimeAcknow = 1 AND [TimeAcknow] IS NULL) OR ([TimeAcknow] = @Original_TimeAcknow)) AND ((@IsNull_DateResolv = 1 AND [DateResolv] IS NULL) OR ([DateResolv] = @Original_DateResolv)) AND ((@IsNull_TimeResolv = 1 AND [TimeResolv] IS NULL) OR ([TimeResolv] = @Original_TimeResolv)) AND ((@IsNull_Resolution = 1 AND [Resolution] IS NULL) OR ([Resolution] = @Original_Resolution)) AND ([CallID] = @Original_CallID) AND ([HEATSeq] = @Original_HEATSeq) AND ((@IsNull_EMail = 1 AND [EMail] IS NULL) OR ([EMail] = @Original_EMail)) AND ((@IsNull_Pager = 1 AND [Pager] IS NULL) OR ([Pager] = @Original_Pager)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_WhoAcknow = 1 AND [WhoAcknow] IS NULL) OR ([WhoAcknow] = @Original_WhoAcknow)) AND ((@IsNull_WhoResolv = 1 AND [WhoResolv] IS NULL) OR ([WhoResolv] = @Original_WhoResolv)) AND ((@IsNull_LoginID = 1 AND [LoginID] IS NULL) OR ([LoginID] = @Original_LoginID)) AND ((@IsNull_PhoneExt = 1 AND [PhoneExt] IS NULL) OR ([PhoneExt] = @Original_PhoneExt)) AND ((@IsNull_TargetTime = 1 AND [TargetTime] IS NULL) OR ([TargetTime] = @Original_TargetTime)) AND ((@IsNull_TargetDate = 1 AND [TargetDate] IS NULL) OR ([TargetDate] = @Original_TargetDate)) AND ((@IsNull_SLAResTime = 1 AND [SLAResTime] IS NULL) OR ([SLAResTime] = @Original_SLAResTime)) AND ((@IsNull_TotalAsgnmntTime = 1 AND [TotalAsgnmntTime] IS NULL) OR ([TotalAsgnmntTime] = @Original_TotalAsgnmntTime)) AND ((@IsNull_Availability = 1 AND [Availability] IS NULL) OR ([Availability] = @Original_Availability)) AND ((@IsNull_CallType = 1 AND [CallType] IS NULL) OR ([CallType] = @Original_CallType)) AND ((@IsNull_Vacation = 1 AND [Vacation] IS NULL) OR ([Vacation] = @Original_Vacation)) AND ((@IsNull_ResolveOrder = 1 AND [ResolveOrder] IS NULL) OR ([ResolveOrder] = @Original_ResolveOrder)) AND ((@IsNull_GrpEmail = 1 AND [GrpEmail] IS NULL) OR ([GrpEmail] = @Original_GrpEmail)) AND ((@IsNull_MgrEmail = 1 AND [MgrEmail] IS NULL) OR ([MgrEmail] = @Original_MgrEmail)) AND ((@IsNull_WorkDate = 1 AND [WorkDate] IS NULL) OR ([WorkDate] = @Original_WorkDate)) AND ((@IsNull_WorkTime = 1 AND [WorkTime] IS NULL) OR ([WorkTime] = @Original_WorkTime)) AND ((@IsNull_CellEmail = 1 AND [CellEmail] IS NULL) OR ([CellEmail] = @Original_CellEmail)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AssignedBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssignedBy", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AssignedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssignedBy", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DateAssign", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAssign", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DateAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAssign", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TimeAssign", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAssign", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TimeAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAssign", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GroupName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GroupName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DateAcknow", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAcknow", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DateAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAcknow", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TimeAcknow", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAcknow", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TimeAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAcknow", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DateResolv", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateResolv", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DateResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateResolv", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TimeResolv", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeResolv", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TimeResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeResolv", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Resolution", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Resolution", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Resolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Resolution", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EMail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EMail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Pager", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Pager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_WhoAcknow", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoAcknow", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_WhoAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoAcknow", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_WhoResolv", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoResolv", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_WhoResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoResolv", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PhoneExt", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TargetTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TargetTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TargetDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TargetDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetDate", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SLAResTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAResTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SLAResTime", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 2, "SLAResTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TotalAsgnmntTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalAsgnmntTime", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TotalAsgnmntTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalAsgnmntTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Availability", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Availability", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CallType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Vacation", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vacation", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Vacation", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vacation", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ResolveOrder", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ResolveOrder", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ResolveOrder", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ResolveOrder", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_GrpEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GrpEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_GrpEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GrpEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MgrEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MgrEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_WorkDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_WorkDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_WorkTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_WorkTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CellEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CellEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Asgnmnt] ([AssignedBy], [DateAssign], [TimeAssign], [GroupName], [Assignee], [Phone], [Notes], [DateAcknow], [TimeAcknow], [DateResolv], [TimeResolv], [Resolution], [CallID], [HEATSeq], [EMail], [Pager], [DTLastMod], [WhoAcknow], [WhoResolv], [LoginID], [PhoneExt], [TargetTime], [TargetDate], [SLAResTime], [TotalAsgnmntTime], [Availability], [CallType], [Vacation], [ResolveOrder], [GrpEmail], [MgrEmail], [WorkDate], [WorkTime], [WorkNotes], [CellEmail]) VALUES (@AssignedBy, @DateAssign, @TimeAssign, @GroupName, @Assignee, @Phone, @Notes, @DateAcknow, @TimeAcknow, @DateResolv, @TimeResolv, @Resolution, @CallID, @HEATSeq, @EMail, @Pager, @DTLastMod, @WhoAcknow, @WhoResolv, @LoginID, @PhoneExt, @TargetTime, @TargetDate, @SLAResTime, @TotalAsgnmntTime, @Availability, @CallType, @Vacation, @ResolveOrder, @GrpEmail, @MgrEmail, @WorkDate, @WorkTime, @WorkNotes, @CellEmail);\r\nSELECT AssignedBy, DateAssign, TimeAssign, GroupName, Assignee, Phone, Notes, DateAcknow, TimeAcknow, DateResolv, TimeResolv, Resolution, CallID, HEATSeq, EMail, Pager, DTLastMod, WhoAcknow, WhoResolv, LoginID, PhoneExt, TargetTime, TargetDate, SLAResTime, TotalAsgnmntTime, Availability, CallType, Vacation, ResolveOrder, GrpEmail, MgrEmail, WorkDate, WorkTime, WorkNotes, CellEmail FROM Asgnmnt WHERE (CallID = @CallID) AND (HEATSeq = @HEATSeq)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AssignedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssignedBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAssign", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAssign", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Notes", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Notes", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAcknow", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAcknow", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateResolv", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeResolv", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Resolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Resolution", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EMail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@WhoAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoAcknow", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@WhoResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoResolv", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@PhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TargetTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TargetDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SLAResTime", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 2, "SLAResTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TotalAsgnmntTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalAsgnmntTime", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Availability", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Vacation", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vacation", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ResolveOrder", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ResolveOrder", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@GrpEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GrpEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@MgrEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@WorkDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@WorkTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@WorkNotes", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkNotes", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CellEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Asgnmnt] SET [AssignedBy] = @AssignedBy, [DateAssign] = @DateAssign, [TimeAssign] = @TimeAssign, [GroupName] = @GroupName, [Assignee] = @Assignee, [Phone] = @Phone, [Notes] = @Notes, [DateAcknow] = @DateAcknow, [TimeAcknow] = @TimeAcknow, [DateResolv] = @DateResolv, [TimeResolv] = @TimeResolv, [Resolution] = @Resolution, [CallID] = @CallID, [HEATSeq] = @HEATSeq, [EMail] = @EMail, [Pager] = @Pager, [DTLastMod] = @DTLastMod, [WhoAcknow] = @WhoAcknow, [WhoResolv] = @WhoResolv, [LoginID] = @LoginID, [PhoneExt] = @PhoneExt, [TargetTime] = @TargetTime, [TargetDate] = @TargetDate, [SLAResTime] = @SLAResTime, [TotalAsgnmntTime] = @TotalAsgnmntTime, [Availability] = @Availability, [CallType] = @CallType, [Vacation] = @Vacation, [ResolveOrder] = @ResolveOrder, [GrpEmail] = @GrpEmail, [MgrEmail] = @MgrEmail, [WorkDate] = @WorkDate, [WorkTime] = @WorkTime, [WorkNotes] = @WorkNotes, [CellEmail] = @CellEmail WHERE (((@IsNull_AssignedBy = 1 AND [AssignedBy] IS NULL) OR ([AssignedBy] = @Original_AssignedBy)) AND ((@IsNull_DateAssign = 1 AND [DateAssign] IS NULL) OR ([DateAssign] = @Original_DateAssign)) AND ((@IsNull_TimeAssign = 1 AND [TimeAssign] IS NULL) OR ([TimeAssign] = @Original_TimeAssign)) AND ((@IsNull_GroupName = 1 AND [GroupName] IS NULL) OR ([GroupName] = @Original_GroupName)) AND ((@IsNull_Assignee = 1 AND [Assignee] IS NULL) OR ([Assignee] = @Original_Assignee)) AND ((@IsNull_Phone = 1 AND [Phone] IS NULL) OR ([Phone] = @Original_Phone)) AND ((@IsNull_DateAcknow = 1 AND [DateAcknow] IS NULL) OR ([DateAcknow] = @Original_DateAcknow)) AND ((@IsNull_TimeAcknow = 1 AND [TimeAcknow] IS NULL) OR ([TimeAcknow] = @Original_TimeAcknow)) AND ((@IsNull_DateResolv = 1 AND [DateResolv] IS NULL) OR ([DateResolv] = @Original_DateResolv)) AND ((@IsNull_TimeResolv = 1 AND [TimeResolv] IS NULL) OR ([TimeResolv] = @Original_TimeResolv)) AND ((@IsNull_Resolution = 1 AND [Resolution] IS NULL) OR ([Resolution] = @Original_Resolution)) AND ([CallID] = @Original_CallID) AND ([HEATSeq] = @Original_HEATSeq) AND ((@IsNull_EMail = 1 AND [EMail] IS NULL) OR ([EMail] = @Original_EMail)) AND ((@IsNull_Pager = 1 AND [Pager] IS NULL) OR ([Pager] = @Original_Pager)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_WhoAcknow = 1 AND [WhoAcknow] IS NULL) OR ([WhoAcknow] = @Original_WhoAcknow)) AND ((@IsNull_WhoResolv = 1 AND [WhoResolv] IS NULL) OR ([WhoResolv] = @Original_WhoResolv)) AND ((@IsNull_LoginID = 1 AND [LoginID] IS NULL) OR ([LoginID] = @Original_LoginID)) AND ((@IsNull_PhoneExt = 1 AND [PhoneExt] IS NULL) OR ([PhoneExt] = @Original_PhoneExt)) AND ((@IsNull_TargetTime = 1 AND [TargetTime] IS NULL) OR ([TargetTime] = @Original_TargetTime)) AND ((@IsNull_TargetDate = 1 AND [TargetDate] IS NULL) OR ([TargetDate] = @Original_TargetDate)) AND ((@IsNull_SLAResTime = 1 AND [SLAResTime] IS NULL) OR ([SLAResTime] = @Original_SLAResTime)) AND ((@IsNull_TotalAsgnmntTime = 1 AND [TotalAsgnmntTime] IS NULL) OR ([TotalAsgnmntTime] = @Original_TotalAsgnmntTime)) AND ((@IsNull_Availability = 1 AND [Availability] IS NULL) OR ([Availability] = @Original_Availability)) AND ((@IsNull_CallType = 1 AND [CallType] IS NULL) OR ([CallType] = @Original_CallType)) AND ((@IsNull_Vacation = 1 AND [Vacation] IS NULL) OR ([Vacation] = @Original_Vacation)) AND ((@IsNull_ResolveOrder = 1 AND [ResolveOrder] IS NULL) OR ([ResolveOrder] = @Original_ResolveOrder)) AND ((@IsNull_GrpEmail = 1 AND [GrpEmail] IS NULL) OR ([GrpEmail] = @Original_GrpEmail)) AND ((@IsNull_MgrEmail = 1 AND [MgrEmail] IS NULL) OR ([MgrEmail] = @Original_MgrEmail)) AND ((@IsNull_WorkDate = 1 AND [WorkDate] IS NULL) OR ([WorkDate] = @Original_WorkDate)) AND ((@IsNull_WorkTime = 1 AND [WorkTime] IS NULL) OR ([WorkTime] = @Original_WorkTime)) AND ((@IsNull_CellEmail = 1 AND [CellEmail] IS NULL) OR ([CellEmail] = @Original_CellEmail)));\r\nSELECT AssignedBy, DateAssign, TimeAssign, GroupName, Assignee, Phone, Notes, DateAcknow, TimeAcknow, DateResolv, TimeResolv, Resolution, CallID, HEATSeq, EMail, Pager, DTLastMod, WhoAcknow, WhoResolv, LoginID, PhoneExt, TargetTime, TargetDate, SLAResTime, TotalAsgnmntTime, Availability, CallType, Vacation, ResolveOrder, GrpEmail, MgrEmail, WorkDate, WorkTime, WorkNotes, CellEmail FROM Asgnmnt WHERE (CallID = @CallID) AND (HEATSeq = @HEATSeq)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AssignedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssignedBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAssign", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TimeAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAssign", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Notes", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Notes", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAcknow", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TimeAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAcknow", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateResolv", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TimeResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeResolv", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Resolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Resolution", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EMail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Pager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@WhoAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoAcknow", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@WhoResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoResolv", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TargetTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TargetDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SLAResTime", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 2, "SLAResTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TotalAsgnmntTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalAsgnmntTime", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Availability", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Vacation", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vacation", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ResolveOrder", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ResolveOrder", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GrpEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GrpEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MgrEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@WorkDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@WorkTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@WorkNotes", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkNotes", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CellEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AssignedBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssignedBy", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AssignedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssignedBy", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DateAssign", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAssign", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DateAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAssign", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TimeAssign", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAssign", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TimeAssign", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAssign", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GroupName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GroupName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GroupName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DateAcknow", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAcknow", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DateAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateAcknow", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TimeAcknow", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAcknow", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TimeAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeAcknow", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DateResolv", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateResolv", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DateResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateResolv", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TimeResolv", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeResolv", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TimeResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeResolv", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Resolution", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Resolution", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Resolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Resolution", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EMail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EMail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMail", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Pager", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Pager", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Pager", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_WhoAcknow", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoAcknow", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_WhoAcknow", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoAcknow", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_WhoResolv", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoResolv", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_WhoResolv", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WhoResolv", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PhoneExt", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PhoneExt", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TargetTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TargetTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TargetDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TargetDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TargetDate", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SLAResTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAResTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SLAResTime", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 2, "SLAResTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TotalAsgnmntTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalAsgnmntTime", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TotalAsgnmntTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalAsgnmntTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Availability", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Availability", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Availability", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CallType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Vacation", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vacation", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Vacation", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vacation", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ResolveOrder", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ResolveOrder", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ResolveOrder", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ResolveOrder", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_GrpEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GrpEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_GrpEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "GrpEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MgrEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MgrEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MgrEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_WorkDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_WorkDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_WorkTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_WorkTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "WorkTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CellEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CellEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CellEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
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
                "SELECT AssignedBy, DateAssign, TimeAssign, GroupName, Assignee, Phone, Notes, DateAcknow, TimeAcknow, DateResolv, TimeResolv, Resolution, CallID, HEATSeq, EMail, Pager, DTLastMod, WhoAcknow, WhoResolv, LoginID, PhoneExt, TargetTime, TargetDate, SLAResTime, TotalAsgnmntTime, Availability, CallType, Vacation, ResolveOrder, GrpEmail, MgrEmail, WorkDate, WorkTime, WorkNotes, CellEmail FROM dbo.Asgnmnt";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Fill(HeaTdbDataSet.AsgnmntDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual HeaTdbDataSet.AsgnmntDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.AsgnmntDataTable asgnmntDataTable = new HeaTdbDataSet.AsgnmntDataTable();
            Adapter.Fill((DataTable) asgnmntDataTable);
            return asgnmntDataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(HeaTdbDataSet.AsgnmntDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Asgnmnt");
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
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

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Delete(string originalAssignedBy, string originalDateAssign, string originalTimeAssign,
            string originalGroupName, string originalAssignee, string originalPhone, string originalDateAcknow,
            string originalTimeAcknow, string originalDateResolv, string originalTimeResolv, string originalResolution,
            string originalCallId, int originalHeatSeq, string originalEMail, string originalPager,
            int? originalDtLastMod, string originalWhoAcknow, string originalWhoResolv, string originalLoginId,
            string originalPhoneExt, string originalTargetTime, string originalTargetDate, Decimal? originalSlaResTime,
            int? originalTotalAsgnmntTime, string originalAvailability, string originalCallType, string originalVacation,
            int? originalResolveOrder, string originalGrpEmail, string originalMgrEmail, string originalWorkDate,
            int? originalWorkTime, string originalCellEmail)
        {
            if (originalAssignedBy == null)
            {
                Adapter.DeleteCommand.Parameters[0].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[1].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[0].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[1].Value = (object) originalAssignedBy;
            }
            if (originalDateAssign == null)
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[3].Value = (object) originalDateAssign;
            }
            if (originalTimeAssign == null)
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[5].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[5].Value = (object) originalTimeAssign;
            }
            if (originalGroupName == null)
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[7].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[7].Value = (object) originalGroupName;
            }
            if (originalAssignee == null)
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[9].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[9].Value = (object) originalAssignee;
            }
            if (originalPhone == null)
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[11].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[11].Value = (object) originalPhone;
            }
            if (originalDateAcknow == null)
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[13].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[13].Value = (object) originalDateAcknow;
            }
            if (originalTimeAcknow == null)
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[15].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[15].Value = (object) originalTimeAcknow;
            }
            if (originalDateResolv == null)
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[17].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[17].Value = (object) originalDateResolv;
            }
            if (originalTimeResolv == null)
            {
                Adapter.DeleteCommand.Parameters[18].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[19].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[18].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[19].Value = (object) originalTimeResolv;
            }
            if (originalResolution == null)
            {
                Adapter.DeleteCommand.Parameters[20].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[21].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[20].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[21].Value = (object) originalResolution;
            }
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.DeleteCommand.Parameters[22].Value = (object) originalCallId;
            Adapter.DeleteCommand.Parameters[23].Value = (object) originalHeatSeq;
            if (originalEMail == null)
            {
                Adapter.DeleteCommand.Parameters[24].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[25].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[24].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[25].Value = (object) originalEMail;
            }
            if (originalPager == null)
            {
                Adapter.DeleteCommand.Parameters[26].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[27].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[26].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[27].Value = (object) originalPager;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.DeleteCommand.Parameters[28].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[29].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[28].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[29].Value = (object) DBNull.Value;
            }
            if (originalWhoAcknow == null)
            {
                Adapter.DeleteCommand.Parameters[30].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[31].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[30].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[31].Value = (object) originalWhoAcknow;
            }
            if (originalWhoResolv == null)
            {
                Adapter.DeleteCommand.Parameters[32].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[33].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[32].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[33].Value = (object) originalWhoResolv;
            }
            if (originalLoginId == null)
            {
                Adapter.DeleteCommand.Parameters[34].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[35].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[34].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[35].Value = (object) originalLoginId;
            }
            if (originalPhoneExt == null)
            {
                Adapter.DeleteCommand.Parameters[36].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[37].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[36].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[37].Value = (object) originalPhoneExt;
            }
            if (originalTargetTime == null)
            {
                Adapter.DeleteCommand.Parameters[38].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[39].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[38].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[39].Value = (object) originalTargetTime;
            }
            if (originalTargetDate == null)
            {
                Adapter.DeleteCommand.Parameters[40].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[41].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[40].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[41].Value = (object) originalTargetDate;
            }
            if (originalSlaResTime.HasValue)
            {
                Adapter.DeleteCommand.Parameters[42].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[43].Value = (object) originalSlaResTime.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[42].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[43].Value = (object) DBNull.Value;
            }
            if (originalTotalAsgnmntTime.HasValue)
            {
                Adapter.DeleteCommand.Parameters[44].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[45].Value = (object) originalTotalAsgnmntTime.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[44].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[45].Value = (object) DBNull.Value;
            }
            if (originalAvailability == null)
            {
                Adapter.DeleteCommand.Parameters[46].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[47].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[46].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[47].Value = (object) originalAvailability;
            }
            if (originalCallType == null)
            {
                Adapter.DeleteCommand.Parameters[48].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[49].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[48].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[49].Value = (object) originalCallType;
            }
            if (originalVacation == null)
            {
                Adapter.DeleteCommand.Parameters[50].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[51].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[50].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[51].Value = (object) originalVacation;
            }
            if (originalResolveOrder.HasValue)
            {
                Adapter.DeleteCommand.Parameters[52].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[53].Value = (object) originalResolveOrder.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[52].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[53].Value = (object) DBNull.Value;
            }
            if (originalGrpEmail == null)
            {
                Adapter.DeleteCommand.Parameters[54].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[55].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[54].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[55].Value = (object) originalGrpEmail;
            }
            if (originalMgrEmail == null)
            {
                Adapter.DeleteCommand.Parameters[56].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[57].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[56].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[57].Value = (object) originalMgrEmail;
            }
            if (originalWorkDate == null)
            {
                Adapter.DeleteCommand.Parameters[58].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[59].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[58].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[59].Value = (object) originalWorkDate;
            }
            if (originalWorkTime.HasValue)
            {
                Adapter.DeleteCommand.Parameters[60].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[61].Value = (object) originalWorkTime.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[60].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[61].Value = (object) DBNull.Value;
            }
            if (originalCellEmail == null)
            {
                Adapter.DeleteCommand.Parameters[62].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[63].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[62].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[63].Value = (object) originalCellEmail;
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
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public virtual int Insert(string assignedBy, string dateAssign, string timeAssign, string groupName,
            string assignee, string phone, string notes, string dateAcknow, string timeAcknow, string dateResolv,
            string timeResolv, string resolution, string callId, int heatSeq, string eMail, string pager, int? dtLastMod,
            string whoAcknow, string whoResolv, string loginId, string phoneExt, string targetTime, string targetDate,
            Decimal? slaResTime, int? totalAsgnmntTime, string availability, string callType, string vacation,
            int? resolveOrder, string grpEmail, string mgrEmail, string workDate, int? workTime, string workNotes,
            string cellEmail)
        {
            if (assignedBy == null)
                Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[0].Value = (object) assignedBy;
            if (dateAssign == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) dateAssign;
            if (timeAssign == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) timeAssign;
            if (groupName == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) groupName;
            if (assignee == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) assignee;
            if (phone == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) phone;
            if (notes == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) notes;
            if (dateAcknow == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) dateAcknow;
            if (timeAcknow == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) timeAcknow;
            if (dateResolv == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) dateResolv;
            if (timeResolv == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) timeResolv;
            if (resolution == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) resolution;
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.InsertCommand.Parameters[12].Value = (object) callId;
            Adapter.InsertCommand.Parameters[13].Value = (object) heatSeq;
            if (eMail == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) eMail;
            if (pager == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) pager;
            if (dtLastMod.HasValue)
                Adapter.InsertCommand.Parameters[16].Value = (object) dtLastMod.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            if (whoAcknow == null)
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) whoAcknow;
            if (whoResolv == null)
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) whoResolv;
            if (loginId == null)
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) loginId;
            if (phoneExt == null)
                Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[20].Value = (object) phoneExt;
            if (targetTime == null)
                Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[21].Value = (object) targetTime;
            if (targetDate == null)
                Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[22].Value = (object) targetDate;
            if (slaResTime.HasValue)
                Adapter.InsertCommand.Parameters[23].Value = (object) slaResTime.Value;
            else
                Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
            if (totalAsgnmntTime.HasValue)
                Adapter.InsertCommand.Parameters[24].Value = (object) totalAsgnmntTime.Value;
            else
                Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
            if (availability == null)
                Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[25].Value = (object) availability;
            if (callType == null)
                Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[26].Value = (object) callType;
            if (vacation == null)
                Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[27].Value = (object) vacation;
            if (resolveOrder.HasValue)
                Adapter.InsertCommand.Parameters[28].Value = (object) resolveOrder.Value;
            else
                Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
            if (grpEmail == null)
                Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[29].Value = (object) grpEmail;
            if (mgrEmail == null)
                Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[30].Value = (object) mgrEmail;
            if (workDate == null)
                Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[31].Value = (object) workDate;
            if (workTime.HasValue)
                Adapter.InsertCommand.Parameters[32].Value = (object) workTime.Value;
            else
                Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
            if (workNotes == null)
                Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[33].Value = (object) workNotes;
            if (cellEmail == null)
                Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[34].Value = (object) cellEmail;
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public virtual int Update(string assignedBy, string dateAssign, string timeAssign, string groupName,
            string assignee, string phone, string notes, string dateAcknow, string timeAcknow, string dateResolv,
            string timeResolv, string resolution, string callId, int heatSeq, string eMail, string pager, int? dtLastMod,
            string whoAcknow, string whoResolv, string loginId, string phoneExt, string targetTime, string targetDate,
            Decimal? slaResTime, int? totalAsgnmntTime, string availability, string callType, string vacation,
            int? resolveOrder, string grpEmail, string mgrEmail, string workDate, int? workTime, string workNotes,
            string cellEmail, string originalAssignedBy, string originalDateAssign, string originalTimeAssign,
            string originalGroupName, string originalAssignee, string originalPhone, string originalDateAcknow,
            string originalTimeAcknow, string originalDateResolv, string originalTimeResolv, string originalResolution,
            string originalCallId, int originalHeatSeq, string originalEMail, string originalPager,
            int? originalDtLastMod, string originalWhoAcknow, string originalWhoResolv, string originalLoginId,
            string originalPhoneExt, string originalTargetTime, string originalTargetDate, Decimal? originalSlaResTime,
            int? originalTotalAsgnmntTime, string originalAvailability, string originalCallType, string originalVacation,
            int? originalResolveOrder, string originalGrpEmail, string originalMgrEmail, string originalWorkDate,
            int? originalWorkTime, string originalCellEmail)
        {
            if (assignedBy == null)
                Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[0].Value = (object) assignedBy;
            if (dateAssign == null)
                Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[1].Value = (object) dateAssign;
            if (timeAssign == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) timeAssign;
            if (groupName == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) groupName;
            if (assignee == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) assignee;
            if (phone == null)
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) phone;
            if (notes == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) notes;
            if (dateAcknow == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) dateAcknow;
            if (timeAcknow == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) timeAcknow;
            if (dateResolv == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) dateResolv;
            if (timeResolv == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) timeResolv;
            if (resolution == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) resolution;
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.UpdateCommand.Parameters[12].Value = (object) callId;
            Adapter.UpdateCommand.Parameters[13].Value = (object) heatSeq;
            if (eMail == null)
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[14].Value = (object) eMail;
            if (pager == null)
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[15].Value = (object) pager;
            if (dtLastMod.HasValue)
                Adapter.UpdateCommand.Parameters[16].Value = (object) dtLastMod.Value;
            else
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            if (whoAcknow == null)
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[17].Value = (object) whoAcknow;
            if (whoResolv == null)
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[18].Value = (object) whoResolv;
            if (loginId == null)
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[19].Value = (object) loginId;
            if (phoneExt == null)
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[20].Value = (object) phoneExt;
            if (targetTime == null)
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[21].Value = (object) targetTime;
            if (targetDate == null)
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[22].Value = (object) targetDate;
            if (slaResTime.HasValue)
                Adapter.UpdateCommand.Parameters[23].Value = (object) slaResTime.Value;
            else
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            if (totalAsgnmntTime.HasValue)
                Adapter.UpdateCommand.Parameters[24].Value = (object) totalAsgnmntTime.Value;
            else
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            if (availability == null)
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[25].Value = (object) availability;
            if (callType == null)
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[26].Value = (object) callType;
            if (vacation == null)
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[27].Value = (object) vacation;
            if (resolveOrder.HasValue)
                Adapter.UpdateCommand.Parameters[28].Value = (object) resolveOrder.Value;
            else
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            if (grpEmail == null)
                Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[29].Value = (object) grpEmail;
            if (mgrEmail == null)
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[30].Value = (object) mgrEmail;
            if (workDate == null)
                Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[31].Value = (object) workDate;
            if (workTime.HasValue)
                Adapter.UpdateCommand.Parameters[32].Value = (object) workTime.Value;
            else
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            if (workNotes == null)
                Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[33].Value = (object) workNotes;
            if (cellEmail == null)
                Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[34].Value = (object) cellEmail;
            if (originalAssignedBy == null)
            {
                Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[36].Value = (object) originalAssignedBy;
            }
            if (originalDateAssign == null)
            {
                Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[38].Value = (object) originalDateAssign;
            }
            if (originalTimeAssign == null)
            {
                Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[40].Value = (object) originalTimeAssign;
            }
            if (originalGroupName == null)
            {
                Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[42].Value = (object) originalGroupName;
            }
            if (originalAssignee == null)
            {
                Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[44].Value = (object) originalAssignee;
            }
            if (originalPhone == null)
            {
                Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[46].Value = (object) originalPhone;
            }
            if (originalDateAcknow == null)
            {
                Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[48].Value = (object) originalDateAcknow;
            }
            if (originalTimeAcknow == null)
            {
                Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[50].Value = (object) originalTimeAcknow;
            }
            if (originalDateResolv == null)
            {
                Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[52].Value = (object) originalDateResolv;
            }
            if (originalTimeResolv == null)
            {
                Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[54].Value = (object) originalTimeResolv;
            }
            if (originalResolution == null)
            {
                Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[56].Value = (object) originalResolution;
            }
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.UpdateCommand.Parameters[57].Value = (object) originalCallId;
            Adapter.UpdateCommand.Parameters[58].Value = (object) originalHeatSeq;
            if (originalEMail == null)
            {
                Adapter.UpdateCommand.Parameters[59].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[59].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[60].Value = (object) originalEMail;
            }
            if (originalPager == null)
            {
                Adapter.UpdateCommand.Parameters[61].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[62].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[61].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[62].Value = (object) originalPager;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.UpdateCommand.Parameters[63].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[64].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[63].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[64].Value = (object) DBNull.Value;
            }
            if (originalWhoAcknow == null)
            {
                Adapter.UpdateCommand.Parameters[65].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[66].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[65].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[66].Value = (object) originalWhoAcknow;
            }
            if (originalWhoResolv == null)
            {
                Adapter.UpdateCommand.Parameters[67].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[68].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[67].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[68].Value = (object) originalWhoResolv;
            }
            if (originalLoginId == null)
            {
                Adapter.UpdateCommand.Parameters[69].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[70].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[69].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[70].Value = (object) originalLoginId;
            }
            if (originalPhoneExt == null)
            {
                Adapter.UpdateCommand.Parameters[71].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[72].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[71].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[72].Value = (object) originalPhoneExt;
            }
            if (originalTargetTime == null)
            {
                Adapter.UpdateCommand.Parameters[73].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[74].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[73].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[74].Value = (object) originalTargetTime;
            }
            if (originalTargetDate == null)
            {
                Adapter.UpdateCommand.Parameters[75].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[76].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[75].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[76].Value = (object) originalTargetDate;
            }
            if (originalSlaResTime.HasValue)
            {
                Adapter.UpdateCommand.Parameters[77].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[78].Value = (object) originalSlaResTime.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[77].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[78].Value = (object) DBNull.Value;
            }
            if (originalTotalAsgnmntTime.HasValue)
            {
                Adapter.UpdateCommand.Parameters[79].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[80].Value = (object) originalTotalAsgnmntTime.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[79].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[80].Value = (object) DBNull.Value;
            }
            if (originalAvailability == null)
            {
                Adapter.UpdateCommand.Parameters[81].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[82].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[81].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[82].Value = (object) originalAvailability;
            }
            if (originalCallType == null)
            {
                Adapter.UpdateCommand.Parameters[83].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[84].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[83].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[84].Value = (object) originalCallType;
            }
            if (originalVacation == null)
            {
                Adapter.UpdateCommand.Parameters[85].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[86].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[85].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[86].Value = (object) originalVacation;
            }
            if (originalResolveOrder.HasValue)
            {
                Adapter.UpdateCommand.Parameters[87].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[88].Value = (object) originalResolveOrder.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[87].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[88].Value = (object) DBNull.Value;
            }
            if (originalGrpEmail == null)
            {
                Adapter.UpdateCommand.Parameters[89].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[90].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[89].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[90].Value = (object) originalGrpEmail;
            }
            if (originalMgrEmail == null)
            {
                Adapter.UpdateCommand.Parameters[91].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[92].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[91].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[92].Value = (object) originalMgrEmail;
            }
            if (originalWorkDate == null)
            {
                Adapter.UpdateCommand.Parameters[93].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[94].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[93].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[94].Value = (object) originalWorkDate;
            }
            if (originalWorkTime.HasValue)
            {
                Adapter.UpdateCommand.Parameters[95].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[96].Value = (object) originalWorkTime.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[95].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[96].Value = (object) DBNull.Value;
            }
            if (originalCellEmail == null)
            {
                Adapter.UpdateCommand.Parameters[97].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[98].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[97].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[98].Value = (object) originalCellEmail;
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

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string assignedBy, string dateAssign, string timeAssign, string groupName,
            string assignee, string phone, string notes, string dateAcknow, string timeAcknow, string dateResolv,
            string timeResolv, string resolution, string eMail, string pager, int? dtLastMod, string whoAcknow,
            string whoResolv, string loginId, string phoneExt, string targetTime, string targetDate, Decimal? slaResTime,
            int? totalAsgnmntTime, string availability, string callType, string vacation, int? resolveOrder,
            string grpEmail, string mgrEmail, string workDate, int? workTime, string workNotes, string cellEmail,
            string originalAssignedBy, string originalDateAssign, string originalTimeAssign, string originalGroupName,
            string originalAssignee, string originalPhone, string originalDateAcknow, string originalTimeAcknow,
            string originalDateResolv, string originalTimeResolv, string originalResolution, string originalCallId,
            int originalHeatSeq, string originalEMail, string originalPager, int? originalDtLastMod,
            string originalWhoAcknow, string originalWhoResolv, string originalLoginId, string originalPhoneExt,
            string originalTargetTime, string originalTargetDate, Decimal? originalSlaResTime,
            int? originalTotalAsgnmntTime, string originalAvailability, string originalCallType, string originalVacation,
            int? originalResolveOrder, string originalGrpEmail, string originalMgrEmail, string originalWorkDate,
            int? originalWorkTime, string originalCellEmail)
        {
            return Update(assignedBy, dateAssign, timeAssign, groupName, assignee, phone, notes, dateAcknow,
                timeAcknow, dateResolv, timeResolv, resolution, originalCallId, originalHeatSeq, eMail, pager, dtLastMod,
                whoAcknow, whoResolv, loginId, phoneExt, targetTime, targetDate, slaResTime, totalAsgnmntTime,
                availability, callType, vacation, resolveOrder, grpEmail, mgrEmail, workDate, workTime, workNotes,
                cellEmail, originalAssignedBy, originalDateAssign, originalTimeAssign, originalGroupName,
                originalAssignee, originalPhone, originalDateAcknow, originalTimeAcknow, originalDateResolv,
                originalTimeResolv, originalResolution, originalCallId, originalHeatSeq, originalEMail, originalPager,
                originalDtLastMod, originalWhoAcknow, originalWhoResolv, originalLoginId, originalPhoneExt,
                originalTargetTime, originalTargetDate, originalSlaResTime, originalTotalAsgnmntTime,
                originalAvailability, originalCallType, originalVacation, originalResolveOrder, originalGrpEmail,
                originalMgrEmail, originalWorkDate, originalWorkTime, originalCellEmail);
        }
    }
}