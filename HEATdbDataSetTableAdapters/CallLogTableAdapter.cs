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
    [HelpKeyword("vs.data.TableAdapter")]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [DesignerCategory("code")]
    [DataObject(true)]
    public class CallLogTableAdapter : Component
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
        public CallLogTableAdapter()
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
                DataSetTable = "CallLog",
                ColumnMappings =
                {
                    {
                        "CallID",
                        "CallID"
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
                        "CallType",
                        "CallType"
                    },
                    {
                        "Tracker",
                        "Tracker"
                    },
                    {
                        "CallStatus",
                        "CallStatus"
                    },
                    {
                        "Priority",
                        "Priority"
                    },
                    {
                        "CDuration",
                        "CDuration"
                    },
                    {
                        "CallCount",
                        "CallCount"
                    },
                    {
                        "StopWatch",
                        "StopWatch"
                    },
                    {
                        "ClosedBy",
                        "ClosedBy"
                    },
                    {
                        "ClosedDate",
                        "ClosedDate"
                    },
                    {
                        "ClosedTime",
                        "ClosedTime"
                    },
                    {
                        "Cause",
                        "Cause"
                    },
                    {
                        "CallDesc",
                        "CallDesc"
                    },
                    {
                        "CloseDesc",
                        "CloseDesc"
                    },
                    {
                        "RecvdBy",
                        "RecvdBy"
                    },
                    {
                        "RecvdDate",
                        "RecvdDate"
                    },
                    {
                        "RecvdTime",
                        "RecvdTime"
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
                        "DTLastMod",
                        "DTLastMod"
                    },
                    {
                        "CallSource",
                        "CallSource"
                    },
                    {
                        "QuickCall",
                        "QuickCall"
                    },
                    {
                        "Category",
                        "Category"
                    },
                    {
                        "CatHeading",
                        "CatHeading"
                    },
                    {
                        "TotalTime",
                        "TotalTime"
                    },
                    {
                        "SL_Warn_Goal",
                        "SL_Warn_Goal"
                    },
                    {
                        "SL_Warn_Date",
                        "SL_Warn_Date"
                    },
                    {
                        "SL_Warn_Time",
                        "SL_Warn_Time"
                    },
                    {
                        "SL_Complete_Goal",
                        "SL_Complete_Goal"
                    },
                    {
                        "SL_Complete_Date",
                        "SL_Complete_Date"
                    },
                    {
                        "SL_Complete_Time",
                        "SL_Complete_Time"
                    },
                    {
                        "SL_Clock_Status",
                        "SL_Clock_Status"
                    },
                    {
                        "SL_Button_Status",
                        "SL_Button_Status"
                    },
                    {
                        "FirstResolution",
                        "FirstResolution"
                    },
                    {
                        "SL_Complete_Status",
                        "SL_Complete_Status"
                    },
                    {
                        "ShortDesc",
                        "ShortDesc"
                    },
                    {
                        "Urg_Name",
                        "Urg_Name"
                    },
                    {
                        "Urg_Value",
                        "Urg_Value"
                    },
                    {
                        "Imp_Name",
                        "Imp_Name"
                    },
                    {
                        "Imp_Value",
                        "Imp_Value"
                    },
                    {
                        "PriorityValue",
                        "PriorityValue"
                    },
                    {
                        "DetailsReq",
                        "DetailsReq"
                    },
                    {
                        "Vandalism",
                        "Vandalism"
                    },
                    {
                        "AsgnGrp",
                        "AsgnGrp"
                    },
                    {
                        "Assignee",
                        "Assignee"
                    },
                    {
                        "ManagerID",
                        "ManagerID"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[CallLog] WHERE (([CallID] = @Original_CallID) AND ((@IsNull_CustID = 1 AND [CustID] IS NULL) OR ([CustID] = @Original_CustID)) AND ((@IsNull_CustType = 1 AND [CustType] IS NULL) OR ([CustType] = @Original_CustType)) AND ((@IsNull_CallType = 1 AND [CallType] IS NULL) OR ([CallType] = @Original_CallType)) AND ((@IsNull_Tracker = 1 AND [Tracker] IS NULL) OR ([Tracker] = @Original_Tracker)) AND ((@IsNull_CallStatus = 1 AND [CallStatus] IS NULL) OR ([CallStatus] = @Original_CallStatus)) AND ((@IsNull_Priority = 1 AND [Priority] IS NULL) OR ([Priority] = @Original_Priority)) AND ((@IsNull_CDuration = 1 AND [CDuration] IS NULL) OR ([CDuration] = @Original_CDuration)) AND ((@IsNull_CallCount = 1 AND [CallCount] IS NULL) OR ([CallCount] = @Original_CallCount)) AND ((@IsNull_StopWatch = 1 AND [StopWatch] IS NULL) OR ([StopWatch] = @Original_StopWatch)) AND ((@IsNull_ClosedBy = 1 AND [ClosedBy] IS NULL) OR ([ClosedBy] = @Original_ClosedBy)) AND ((@IsNull_ClosedDate = 1 AND [ClosedDate] IS NULL) OR ([ClosedDate] = @Original_ClosedDate)) AND ((@IsNull_ClosedTime = 1 AND [ClosedTime] IS NULL) OR ([ClosedTime] = @Original_ClosedTime)) AND ((@IsNull_Cause = 1 AND [Cause] IS NULL) OR ([Cause] = @Original_Cause)) AND ((@IsNull_RecvdBy = 1 AND [RecvdBy] IS NULL) OR ([RecvdBy] = @Original_RecvdBy)) AND ((@IsNull_RecvdDate = 1 AND [RecvdDate] IS NULL) OR ([RecvdDate] = @Original_RecvdDate)) AND ((@IsNull_RecvdTime = 1 AND [RecvdTime] IS NULL) OR ([RecvdTime] = @Original_RecvdTime)) AND ((@IsNull_ModBy = 1 AND [ModBy] IS NULL) OR ([ModBy] = @Original_ModBy)) AND ((@IsNull_ModDate = 1 AND [ModDate] IS NULL) OR ([ModDate] = @Original_ModDate)) AND ((@IsNull_ModTime = 1 AND [ModTime] IS NULL) OR ([ModTime] = @Original_ModTime)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_CallSource = 1 AND [CallSource] IS NULL) OR ([CallSource] = @Original_CallSource)) AND ((@IsNull_QuickCall = 1 AND [QuickCall] IS NULL) OR ([QuickCall] = @Original_QuickCall)) AND ((@IsNull_Category = 1 AND [Category] IS NULL) OR ([Category] = @Original_Category)) AND ((@IsNull_CatHeading = 1 AND [CatHeading] IS NULL) OR ([CatHeading] = @Original_CatHeading)) AND ((@IsNull_TotalTime = 1 AND [TotalTime] IS NULL) OR ([TotalTime] = @Original_TotalTime)) AND ((@IsNull_SL_Warn_Goal = 1 AND [SL_Warn_Goal] IS NULL) OR ([SL_Warn_Goal] = @Original_SL_Warn_Goal)) AND ((@IsNull_SL_Warn_Date = 1 AND [SL_Warn_Date] IS NULL) OR ([SL_Warn_Date] = @Original_SL_Warn_Date)) AND ((@IsNull_SL_Warn_Time = 1 AND [SL_Warn_Time] IS NULL) OR ([SL_Warn_Time] = @Original_SL_Warn_Time)) AND ((@IsNull_SL_Complete_Goal = 1 AND [SL_Complete_Goal] IS NULL) OR ([SL_Complete_Goal] = @Original_SL_Complete_Goal)) AND ((@IsNull_SL_Complete_Date = 1 AND [SL_Complete_Date] IS NULL) OR ([SL_Complete_Date] = @Original_SL_Complete_Date)) AND ((@IsNull_SL_Complete_Time = 1 AND [SL_Complete_Time] IS NULL) OR ([SL_Complete_Time] = @Original_SL_Complete_Time)) AND ((@IsNull_SL_Clock_Status = 1 AND [SL_Clock_Status] IS NULL) OR ([SL_Clock_Status] = @Original_SL_Clock_Status)) AND ((@IsNull_SL_Button_Status = 1 AND [SL_Button_Status] IS NULL) OR ([SL_Button_Status] = @Original_SL_Button_Status)) AND ((@IsNull_FirstResolution = 1 AND [FirstResolution] IS NULL) OR ([FirstResolution] = @Original_FirstResolution)) AND ((@IsNull_SL_Complete_Status = 1 AND [SL_Complete_Status] IS NULL) OR ([SL_Complete_Status] = @Original_SL_Complete_Status)) AND ((@IsNull_ShortDesc = 1 AND [ShortDesc] IS NULL) OR ([ShortDesc] = @Original_ShortDesc)) AND ((@IsNull_Urg_Name = 1 AND [Urg_Name] IS NULL) OR ([Urg_Name] = @Original_Urg_Name)) AND ((@IsNull_Urg_Value = 1 AND [Urg_Value] IS NULL) OR ([Urg_Value] = @Original_Urg_Value)) AND ((@IsNull_Imp_Name = 1 AND [Imp_Name] IS NULL) OR ([Imp_Name] = @Original_Imp_Name)) AND ((@IsNull_Imp_Value = 1 AND [Imp_Value] IS NULL) OR ([Imp_Value] = @Original_Imp_Value)) AND ((@IsNull_PriorityValue = 1 AND [PriorityValue] IS NULL) OR ([PriorityValue] = @Original_PriorityValue)) AND ((@IsNull_DetailsReq = 1 AND [DetailsReq] IS NULL) OR ([DetailsReq] = @Original_DetailsReq)) AND ((@IsNull_Vandalism = 1 AND [Vandalism] IS NULL) OR ([Vandalism] = @Original_Vandalism)) AND ((@IsNull_AsgnGrp = 1 AND [AsgnGrp] IS NULL) OR ([AsgnGrp] = @Original_AsgnGrp)) AND ((@IsNull_Assignee = 1 AND [Assignee] IS NULL) OR ([Assignee] = @Original_Assignee)) AND ((@IsNull_ManagerID = 1 AND [ManagerID] IS NULL) OR ([ManagerID] = @Original_ManagerID)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CustID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CustType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CallType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Tracker", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CallStatus", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallStatus", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallStatus", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Priority", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Priority", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Priority", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Priority", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CDuration", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CDuration", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CDuration", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "CDuration", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CallCount", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallCount", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallCount", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 5, (byte) 2, "CallCount", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_StopWatch", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "StopWatch", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_StopWatch", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "StopWatch", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ClosedBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedBy", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ClosedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedBy", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ClosedDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ClosedDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedDate", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ClosedTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ClosedTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Cause", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Cause", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Cause", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Cause", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RecvdBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdBy", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RecvdBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdBy", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RecvdDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RecvdDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RecvdTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RecvdTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ModBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Original, false, (object) null, "",
                "", ""));
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
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CallSource", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallSource", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallSource", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallSource", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_QuickCall", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "QuickCall", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_QuickCall", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "QuickCall", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Category", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Category", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Category", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Category", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CatHeading", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CatHeading", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CatHeading", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CatHeading", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TotalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TotalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Warn_Goal", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Goal", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Warn_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Goal", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Warn_Date", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Date", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Warn_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Date", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Warn_Time", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Time", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Warn_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Time", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Goal", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Goal", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Goal", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Date", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Date", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Date", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Time", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Time", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Time", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Clock_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Clock_Status", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Clock_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Clock_Status", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Button_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Button_Status", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Button_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Button_Status", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FirstResolution", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstResolution", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FirstResolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstResolution", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Status", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Status", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ShortDesc", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ShortDesc", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ShortDesc", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ShortDesc", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Urg_Name", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Name", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Urg_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Name", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Urg_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Value", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Urg_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Value", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Imp_Name", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Name", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Imp_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Name", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Imp_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Value", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Imp_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Value", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PriorityValue", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PriorityValue", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PriorityValue", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PriorityValue", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DetailsReq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DetailsReq", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DetailsReq", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DetailsReq", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Vandalism", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vandalism", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Vandalism", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vandalism", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AsgnGrp", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgnGrp", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AsgnGrp", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgnGrp", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ManagerID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ManagerID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ManagerID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ManagerID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[CallLog] ([CallID], [CustID], [CustType], [CallType], [Tracker], [CallStatus], [Priority], [CDuration], [CallCount], [StopWatch], [ClosedBy], [ClosedDate], [ClosedTime], [Cause], [CallDesc], [CloseDesc], [RecvdBy], [RecvdDate], [RecvdTime], [ModBy], [ModDate], [ModTime], [DTLastMod], [CallSource], [QuickCall], [Category], [CatHeading], [TotalTime], [SL_Warn_Goal], [SL_Warn_Date], [SL_Warn_Time], [SL_Complete_Goal], [SL_Complete_Date], [SL_Complete_Time], [SL_Clock_Status], [SL_Button_Status], [FirstResolution], [SL_Complete_Status], [ShortDesc], [Urg_Name], [Urg_Value], [Imp_Name], [Imp_Value], [PriorityValue], [DetailsReq], [Vandalism], [AsgnGrp], [Assignee], [ManagerID]) VALUES (@CallID, @CustID, @CustType, @CallType, @Tracker, @CallStatus, @Priority, @CDuration, @CallCount, @StopWatch, @ClosedBy, @ClosedDate, @ClosedTime, @Cause, @CallDesc, @CloseDesc, @RecvdBy, @RecvdDate, @RecvdTime, @ModBy, @ModDate, @ModTime, @DTLastMod, @CallSource, @QuickCall, @Category, @CatHeading, @TotalTime, @SL_Warn_Goal, @SL_Warn_Date, @SL_Warn_Time, @SL_Complete_Goal, @SL_Complete_Date, @SL_Complete_Time, @SL_Clock_Status, @SL_Button_Status, @FirstResolution, @SL_Complete_Status, @ShortDesc, @Urg_Name, @Urg_Value, @Imp_Name, @Imp_Value, @PriorityValue, @DetailsReq, @Vandalism, @AsgnGrp, @Assignee, @ManagerID);\r\nSELECT CallID, CustID, CustType, CallType, Tracker, CallStatus, Priority, CDuration, CallCount, StopWatch, ClosedBy, ClosedDate, ClosedTime, Cause, CallDesc, CloseDesc, RecvdBy, RecvdDate, RecvdTime, ModBy, ModDate, ModTime, DTLastMod, CallSource, QuickCall, Category, CatHeading, TotalTime, SL_Warn_Goal, SL_Warn_Date, SL_Warn_Time, SL_Complete_Goal, SL_Complete_Date, SL_Complete_Time, SL_Clock_Status, SL_Button_Status, FirstResolution, SL_Complete_Status, ShortDesc, Urg_Name, Urg_Value, Imp_Name, Imp_Value, PriorityValue, DetailsReq, Vandalism, AsgnGrp, Assignee, ManagerID FROM CallLog WHERE (CallID = @CallID)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallStatus", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Priority", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Priority", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CDuration", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "CDuration", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallCount", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 5, (byte) 2, "CallCount", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@StopWatch", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "StopWatch", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ClosedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ClosedDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ClosedTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Cause", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Cause", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallDesc", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallDesc", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CloseDesc", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CloseDesc", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RecvdBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RecvdDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RecvdTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdTime", DataRowVersion.Current, false, (object) null,
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
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallSource", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallSource", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@QuickCall", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "QuickCall", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Category", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Category", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CatHeading", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CatHeading", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TotalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Warn_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Goal", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Warn_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Date", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Warn_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Time", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Complete_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Goal", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Complete_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Date", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Complete_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Time", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Clock_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Clock_Status", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Button_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Button_Status", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FirstResolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstResolution", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SL_Complete_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Status", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShortDesc", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ShortDesc", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Urg_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Name", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Urg_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Value", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Imp_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Name", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Imp_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Value", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@PriorityValue", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PriorityValue", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DetailsReq", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DetailsReq", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Vandalism", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vandalism", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AsgnGrp", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgnGrp", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ManagerID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ManagerID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[CallLog] SET [CallID] = @CallID, [CustID] = @CustID, [CustType] = @CustType, [CallType] = @CallType, [Tracker] = @Tracker, [CallStatus] = @CallStatus, [Priority] = @Priority, [CDuration] = @CDuration, [CallCount] = @CallCount, [StopWatch] = @StopWatch, [ClosedBy] = @ClosedBy, [ClosedDate] = @ClosedDate, [ClosedTime] = @ClosedTime, [Cause] = @Cause, [CallDesc] = @CallDesc, [CloseDesc] = @CloseDesc, [RecvdBy] = @RecvdBy, [RecvdDate] = @RecvdDate, [RecvdTime] = @RecvdTime, [ModBy] = @ModBy, [ModDate] = @ModDate, [ModTime] = @ModTime, [DTLastMod] = @DTLastMod, [CallSource] = @CallSource, [QuickCall] = @QuickCall, [Category] = @Category, [CatHeading] = @CatHeading, [TotalTime] = @TotalTime, [SL_Warn_Goal] = @SL_Warn_Goal, [SL_Warn_Date] = @SL_Warn_Date, [SL_Warn_Time] = @SL_Warn_Time, [SL_Complete_Goal] = @SL_Complete_Goal, [SL_Complete_Date] = @SL_Complete_Date, [SL_Complete_Time] = @SL_Complete_Time, [SL_Clock_Status] = @SL_Clock_Status, [SL_Button_Status] = @SL_Button_Status, [FirstResolution] = @FirstResolution, [SL_Complete_Status] = @SL_Complete_Status, [ShortDesc] = @ShortDesc, [Urg_Name] = @Urg_Name, [Urg_Value] = @Urg_Value, [Imp_Name] = @Imp_Name, [Imp_Value] = @Imp_Value, [PriorityValue] = @PriorityValue, [DetailsReq] = @DetailsReq, [Vandalism] = @Vandalism, [AsgnGrp] = @AsgnGrp, [Assignee] = @Assignee, [ManagerID] = @ManagerID WHERE (([CallID] = @Original_CallID) AND ((@IsNull_CustID = 1 AND [CustID] IS NULL) OR ([CustID] = @Original_CustID)) AND ((@IsNull_CustType = 1 AND [CustType] IS NULL) OR ([CustType] = @Original_CustType)) AND ((@IsNull_CallType = 1 AND [CallType] IS NULL) OR ([CallType] = @Original_CallType)) AND ((@IsNull_Tracker = 1 AND [Tracker] IS NULL) OR ([Tracker] = @Original_Tracker)) AND ((@IsNull_CallStatus = 1 AND [CallStatus] IS NULL) OR ([CallStatus] = @Original_CallStatus)) AND ((@IsNull_Priority = 1 AND [Priority] IS NULL) OR ([Priority] = @Original_Priority)) AND ((@IsNull_CDuration = 1 AND [CDuration] IS NULL) OR ([CDuration] = @Original_CDuration)) AND ((@IsNull_CallCount = 1 AND [CallCount] IS NULL) OR ([CallCount] = @Original_CallCount)) AND ((@IsNull_StopWatch = 1 AND [StopWatch] IS NULL) OR ([StopWatch] = @Original_StopWatch)) AND ((@IsNull_ClosedBy = 1 AND [ClosedBy] IS NULL) OR ([ClosedBy] = @Original_ClosedBy)) AND ((@IsNull_ClosedDate = 1 AND [ClosedDate] IS NULL) OR ([ClosedDate] = @Original_ClosedDate)) AND ((@IsNull_ClosedTime = 1 AND [ClosedTime] IS NULL) OR ([ClosedTime] = @Original_ClosedTime)) AND ((@IsNull_Cause = 1 AND [Cause] IS NULL) OR ([Cause] = @Original_Cause)) AND ((@IsNull_RecvdBy = 1 AND [RecvdBy] IS NULL) OR ([RecvdBy] = @Original_RecvdBy)) AND ((@IsNull_RecvdDate = 1 AND [RecvdDate] IS NULL) OR ([RecvdDate] = @Original_RecvdDate)) AND ((@IsNull_RecvdTime = 1 AND [RecvdTime] IS NULL) OR ([RecvdTime] = @Original_RecvdTime)) AND ((@IsNull_ModBy = 1 AND [ModBy] IS NULL) OR ([ModBy] = @Original_ModBy)) AND ((@IsNull_ModDate = 1 AND [ModDate] IS NULL) OR ([ModDate] = @Original_ModDate)) AND ((@IsNull_ModTime = 1 AND [ModTime] IS NULL) OR ([ModTime] = @Original_ModTime)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_CallSource = 1 AND [CallSource] IS NULL) OR ([CallSource] = @Original_CallSource)) AND ((@IsNull_QuickCall = 1 AND [QuickCall] IS NULL) OR ([QuickCall] = @Original_QuickCall)) AND ((@IsNull_Category = 1 AND [Category] IS NULL) OR ([Category] = @Original_Category)) AND ((@IsNull_CatHeading = 1 AND [CatHeading] IS NULL) OR ([CatHeading] = @Original_CatHeading)) AND ((@IsNull_TotalTime = 1 AND [TotalTime] IS NULL) OR ([TotalTime] = @Original_TotalTime)) AND ((@IsNull_SL_Warn_Goal = 1 AND [SL_Warn_Goal] IS NULL) OR ([SL_Warn_Goal] = @Original_SL_Warn_Goal)) AND ((@IsNull_SL_Warn_Date = 1 AND [SL_Warn_Date] IS NULL) OR ([SL_Warn_Date] = @Original_SL_Warn_Date)) AND ((@IsNull_SL_Warn_Time = 1 AND [SL_Warn_Time] IS NULL) OR ([SL_Warn_Time] = @Original_SL_Warn_Time)) AND ((@IsNull_SL_Complete_Goal = 1 AND [SL_Complete_Goal] IS NULL) OR ([SL_Complete_Goal] = @Original_SL_Complete_Goal)) AND ((@IsNull_SL_Complete_Date = 1 AND [SL_Complete_Date] IS NULL) OR ([SL_Complete_Date] = @Original_SL_Complete_Date)) AND ((@IsNull_SL_Complete_Time = 1 AND [SL_Complete_Time] IS NULL) OR ([SL_Complete_Time] = @Original_SL_Complete_Time)) AND ((@IsNull_SL_Clock_Status = 1 AND [SL_Clock_Status] IS NULL) OR ([SL_Clock_Status] = @Original_SL_Clock_Status)) AND ((@IsNull_SL_Button_Status = 1 AND [SL_Button_Status] IS NULL) OR ([SL_Button_Status] = @Original_SL_Button_Status)) AND ((@IsNull_FirstResolution = 1 AND [FirstResolution] IS NULL) OR ([FirstResolution] = @Original_FirstResolution)) AND ((@IsNull_SL_Complete_Status = 1 AND [SL_Complete_Status] IS NULL) OR ([SL_Complete_Status] = @Original_SL_Complete_Status)) AND ((@IsNull_ShortDesc = 1 AND [ShortDesc] IS NULL) OR ([ShortDesc] = @Original_ShortDesc)) AND ((@IsNull_Urg_Name = 1 AND [Urg_Name] IS NULL) OR ([Urg_Name] = @Original_Urg_Name)) AND ((@IsNull_Urg_Value = 1 AND [Urg_Value] IS NULL) OR ([Urg_Value] = @Original_Urg_Value)) AND ((@IsNull_Imp_Name = 1 AND [Imp_Name] IS NULL) OR ([Imp_Name] = @Original_Imp_Name)) AND ((@IsNull_Imp_Value = 1 AND [Imp_Value] IS NULL) OR ([Imp_Value] = @Original_Imp_Value)) AND ((@IsNull_PriorityValue = 1 AND [PriorityValue] IS NULL) OR ([PriorityValue] = @Original_PriorityValue)) AND ((@IsNull_DetailsReq = 1 AND [DetailsReq] IS NULL) OR ([DetailsReq] = @Original_DetailsReq)) AND ((@IsNull_Vandalism = 1 AND [Vandalism] IS NULL) OR ([Vandalism] = @Original_Vandalism)) AND ((@IsNull_AsgnGrp = 1 AND [AsgnGrp] IS NULL) OR ([AsgnGrp] = @Original_AsgnGrp)) AND ((@IsNull_Assignee = 1 AND [Assignee] IS NULL) OR ([Assignee] = @Original_Assignee)) AND ((@IsNull_ManagerID = 1 AND [ManagerID] IS NULL) OR ([ManagerID] = @Original_ManagerID)));\r\nSELECT CallID, CustID, CustType, CallType, Tracker, CallStatus, Priority, CDuration, CallCount, StopWatch, ClosedBy, ClosedDate, ClosedTime, Cause, CallDesc, CloseDesc, RecvdBy, RecvdDate, RecvdTime, ModBy, ModDate, ModTime, DTLastMod, CallSource, QuickCall, Category, CatHeading, TotalTime, SL_Warn_Goal, SL_Warn_Date, SL_Warn_Time, SL_Complete_Goal, SL_Complete_Date, SL_Complete_Time, SL_Clock_Status, SL_Button_Status, FirstResolution, SL_Complete_Status, ShortDesc, Urg_Name, Urg_Value, Imp_Name, Imp_Value, PriorityValue, DetailsReq, Vandalism, AsgnGrp, Assignee, ManagerID FROM CallLog WHERE (CallID = @CallID)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallStatus", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Priority", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Priority", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CDuration", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "CDuration", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallCount", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 5, (byte) 2, "CallCount", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@StopWatch", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "StopWatch", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ClosedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ClosedDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ClosedTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Cause", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Cause", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallDesc", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallDesc", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CloseDesc", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CloseDesc", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RecvdBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdBy", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RecvdDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RecvdTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallSource", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallSource", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@QuickCall", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "QuickCall", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Category", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Category", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CatHeading", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CatHeading", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TotalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Warn_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Goal", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Warn_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Date", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Warn_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Time", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Complete_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Goal", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Complete_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Date", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Complete_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Time", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Clock_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Clock_Status", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Button_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Button_Status", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FirstResolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstResolution", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SL_Complete_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Status", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ShortDesc", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ShortDesc", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Urg_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Name", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Urg_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Value", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Imp_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Name", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Imp_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Value", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PriorityValue", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PriorityValue", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DetailsReq", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DetailsReq", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Vandalism", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vandalism", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AsgnGrp", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgnGrp", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ManagerID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ManagerID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CustID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CustType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CallType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Tracker", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CallStatus", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallStatus", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallStatus", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Priority", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Priority", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Priority", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Priority", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CDuration", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CDuration", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CDuration", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "CDuration", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CallCount", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallCount", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallCount", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 5, (byte) 2, "CallCount", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_StopWatch", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "StopWatch", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_StopWatch", SqlDbType.Decimal, 0,
                ParameterDirection.Input, (byte) 9, (byte) 4, "StopWatch", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ClosedBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedBy", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ClosedBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedBy", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ClosedDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ClosedDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedDate", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ClosedTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ClosedTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClosedTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Cause", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Cause", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Cause", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Cause", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RecvdBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdBy", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RecvdBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdBy", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RecvdDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RecvdDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RecvdTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RecvdTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RecvdTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ModBy", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Original, false, (object) null, "",
                "", ""));
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
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CallSource", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallSource", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallSource", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallSource", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_QuickCall", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "QuickCall", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_QuickCall", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "QuickCall", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Category", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Category", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Category", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Category", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CatHeading", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CatHeading", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CatHeading", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CatHeading", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TotalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TotalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Warn_Goal", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Goal", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Warn_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Goal", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Warn_Date", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Date", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Warn_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Date", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Warn_Time", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Time", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Warn_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Warn_Time", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Goal", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Goal", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Goal", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Goal", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Date", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Date", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Date", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Date", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Time", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Time", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Time", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Time", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Clock_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Clock_Status", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Clock_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Clock_Status", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Button_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Button_Status", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Button_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Button_Status", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FirstResolution", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstResolution", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FirstResolution", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstResolution", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SL_Complete_Status", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Status", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SL_Complete_Status", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SL_Complete_Status", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ShortDesc", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ShortDesc", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ShortDesc", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ShortDesc", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Urg_Name", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Name", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Urg_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Name", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Urg_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Value", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Urg_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Urg_Value", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Imp_Name", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Name", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Imp_Name", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Name", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Imp_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Value", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Imp_Value", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Imp_Value", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PriorityValue", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PriorityValue", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PriorityValue", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PriorityValue", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DetailsReq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DetailsReq", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DetailsReq", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DetailsReq", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Vandalism", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vandalism", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Vandalism", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vandalism", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AsgnGrp", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgnGrp", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AsgnGrp", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgnGrp", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Assignee", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ManagerID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ManagerID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ManagerID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ManagerID", DataRowVersion.Original, false, (object) null,
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
                "SELECT CallID, CustID, CustType, CallType, Tracker, CallStatus, Priority, CDuration, CallCount, StopWatch, ClosedBy, ClosedDate, ClosedTime, Cause, CallDesc, CloseDesc, RecvdBy, RecvdDate, RecvdTime, ModBy, ModDate, ModTime, DTLastMod, CallSource, QuickCall, Category, CatHeading, TotalTime, SL_Warn_Goal, SL_Warn_Date, SL_Warn_Time, SL_Complete_Goal, SL_Complete_Date, SL_Complete_Time, SL_Clock_Status, SL_Button_Status, FirstResolution, SL_Complete_Status, ShortDesc, Urg_Name, Urg_Value, Imp_Name, Imp_Value, PriorityValue, DetailsReq, Vandalism, AsgnGrp, Assignee, ManagerID FROM dbo.CallLog";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Fill(HeaTdbDataSet.CallLogDataTable dataTable)
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
        public virtual HeaTdbDataSet.CallLogDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.CallLogDataTable callLogDataTable = new HeaTdbDataSet.CallLogDataTable();
            Adapter.Fill((DataTable) callLogDataTable);
            return callLogDataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet.CallLogDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "CallLog");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(string originalCallId, string originalCustId, string originalCustType,
            string originalCallType, string originalTracker, string originalCallStatus, string originalPriority,
            Decimal? originalCDuration, Decimal? originalCallCount, Decimal? originalStopWatch, string originalClosedBy,
            string originalClosedDate, string originalClosedTime, string originalCause, string originalRecvdBy,
            string originalRecvdDate, string originalRecvdTime, string originalModBy, string originalModDate,
            string originalModTime, int? originalDtLastMod, string originalCallSource, string originalQuickCall,
            string originalCategory, string originalCatHeading, int? originalTotalTime, string originalSlWarnGoal,
            string originalSlWarnDate, string originalSlWarnTime, string originalSlCompleteGoal,
            string originalSlCompleteDate, string originalSlCompleteTime, string originalSlClockStatus,
            string originalSlButtonStatus, string originalFirstResolution, string originalSlCompleteStatus,
            string originalShortDesc, string originalUrgName, int? originalUrgValue, string originalImpName,
            int? originalImpValue, int? originalPriorityValue, string originalDetailsReq, string originalVandalism,
            string originalAsgnGrp, string originalAssignee, string originalManagerId)
        {
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.DeleteCommand.Parameters[0].Value = (object) originalCallId;
            if (originalCustId == null)
            {
                Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[2].Value = (object) originalCustId;
            }
            if (originalCustType == null)
            {
                Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[4].Value = (object) originalCustType;
            }
            if (originalCallType == null)
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[6].Value = (object) originalCallType;
            }
            if (originalTracker == null)
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[8].Value = (object) originalTracker;
            }
            if (originalCallStatus == null)
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[10].Value = (object) originalCallStatus;
            }
            if (originalPriority == null)
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[12].Value = (object) originalPriority;
            }
            if (originalCDuration.HasValue)
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[14].Value = (object) originalCDuration.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
            }
            if (originalCallCount.HasValue)
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[16].Value = (object) originalCallCount.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
            }
            if (originalStopWatch.HasValue)
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[18].Value = (object) originalStopWatch.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
            }
            if (originalClosedBy == null)
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[20].Value = (object) originalClosedBy;
            }
            if (originalClosedDate == null)
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[22].Value = (object) originalClosedDate;
            }
            if (originalClosedTime == null)
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[24].Value = (object) originalClosedTime;
            }
            if (originalCause == null)
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[26].Value = (object) originalCause;
            }
            if (originalRecvdBy == null)
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[28].Value = (object) originalRecvdBy;
            }
            if (originalRecvdDate == null)
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[30].Value = (object) originalRecvdDate;
            }
            if (originalRecvdTime == null)
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[32].Value = (object) originalRecvdTime;
            }
            if (originalModBy == null)
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[34].Value = (object) originalModBy;
            }
            if (originalModDate == null)
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[36].Value = (object) originalModDate;
            }
            if (originalModTime == null)
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[38].Value = (object) originalModTime;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[40].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
            }
            if (originalCallSource == null)
            {
                Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[42].Value = (object) originalCallSource;
            }
            if (originalQuickCall == null)
            {
                Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[44].Value = (object) originalQuickCall;
            }
            if (originalCategory == null)
            {
                Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[46].Value = (object) originalCategory;
            }
            if (originalCatHeading == null)
            {
                Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[48].Value = (object) originalCatHeading;
            }
            if (originalTotalTime.HasValue)
            {
                Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[50].Value = (object) originalTotalTime.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
            }
            if (originalSlWarnGoal == null)
            {
                Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[52].Value = (object) originalSlWarnGoal;
            }
            if (originalSlWarnDate == null)
            {
                Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[54].Value = (object) originalSlWarnDate;
            }
            if (originalSlWarnTime == null)
            {
                Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[56].Value = (object) originalSlWarnTime;
            }
            if (originalSlCompleteGoal == null)
            {
                Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[58].Value = (object) originalSlCompleteGoal;
            }
            if (originalSlCompleteDate == null)
            {
                Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[60].Value = (object) originalSlCompleteDate;
            }
            if (originalSlCompleteTime == null)
            {
                Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[62].Value = (object) originalSlCompleteTime;
            }
            if (originalSlClockStatus == null)
            {
                Adapter.DeleteCommand.Parameters[63].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[64].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[63].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[64].Value = (object) originalSlClockStatus;
            }
            if (originalSlButtonStatus == null)
            {
                Adapter.DeleteCommand.Parameters[65].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[66].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[65].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[66].Value = (object) originalSlButtonStatus;
            }
            if (originalFirstResolution == null)
            {
                Adapter.DeleteCommand.Parameters[67].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[68].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[67].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[68].Value = (object) originalFirstResolution;
            }
            if (originalSlCompleteStatus == null)
            {
                Adapter.DeleteCommand.Parameters[69].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[70].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[69].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[70].Value = (object) originalSlCompleteStatus;
            }
            if (originalShortDesc == null)
            {
                Adapter.DeleteCommand.Parameters[71].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[72].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[71].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[72].Value = (object) originalShortDesc;
            }
            if (originalUrgName == null)
            {
                Adapter.DeleteCommand.Parameters[73].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[74].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[73].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[74].Value = (object) originalUrgName;
            }
            if (originalUrgValue.HasValue)
            {
                Adapter.DeleteCommand.Parameters[75].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[76].Value = (object) originalUrgValue.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[75].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[76].Value = (object) DBNull.Value;
            }
            if (originalImpName == null)
            {
                Adapter.DeleteCommand.Parameters[77].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[78].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[77].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[78].Value = (object) originalImpName;
            }
            if (originalImpValue.HasValue)
            {
                Adapter.DeleteCommand.Parameters[79].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[80].Value = (object) originalImpValue.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[79].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[80].Value = (object) DBNull.Value;
            }
            if (originalPriorityValue.HasValue)
            {
                Adapter.DeleteCommand.Parameters[81].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[82].Value = (object) originalPriorityValue.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[81].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[82].Value = (object) DBNull.Value;
            }
            if (originalDetailsReq == null)
            {
                Adapter.DeleteCommand.Parameters[83].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[84].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[83].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[84].Value = (object) originalDetailsReq;
            }
            if (originalVandalism == null)
            {
                Adapter.DeleteCommand.Parameters[85].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[86].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[85].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[86].Value = (object) originalVandalism;
            }
            if (originalAsgnGrp == null)
            {
                Adapter.DeleteCommand.Parameters[87].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[88].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[87].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[88].Value = (object) originalAsgnGrp;
            }
            if (originalAssignee == null)
            {
                Adapter.DeleteCommand.Parameters[89].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[90].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[89].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[90].Value = (object) originalAssignee;
            }
            if (originalManagerId == null)
            {
                Adapter.DeleteCommand.Parameters[91].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[92].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[91].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[92].Value = (object) originalManagerId;
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
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Insert(string callId, string custId, string custType, string callType, string tracker,
            string callStatus, string priority, Decimal? cDuration, Decimal? callCount, Decimal? stopWatch,
            string closedBy, string closedDate, string closedTime, string cause, string callDesc, string closeDesc,
            string recvdBy, string recvdDate, string recvdTime, string modBy, string modDate, string modTime,
            int? dtLastMod, string callSource, string quickCall, string category, string catHeading, int? totalTime,
            string slWarnGoal, string slWarnDate, string slWarnTime, string slCompleteGoal, string slCompleteDate,
            string slCompleteTime, string slClockStatus, string slButtonStatus, string firstResolution,
            string slCompleteStatus, string shortDesc, string urgName, int? urgValue, string impName, int? impValue,
            int? priorityValue, string detailsReq, string vandalism, string asgnGrp, string assignee, string managerId)
        {
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.InsertCommand.Parameters[0].Value = (object) callId;
            if (custId == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) custId;
            if (custType == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) custType;
            if (callType == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) callType;
            if (tracker == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) tracker;
            if (callStatus == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) callStatus;
            if (priority == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) priority;
            if (cDuration.HasValue)
                Adapter.InsertCommand.Parameters[7].Value = (object) cDuration.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            if (callCount.HasValue)
                Adapter.InsertCommand.Parameters[8].Value = (object) callCount.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            if (stopWatch.HasValue)
                Adapter.InsertCommand.Parameters[9].Value = (object) stopWatch.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            if (closedBy == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) closedBy;
            if (closedDate == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) closedDate;
            if (closedTime == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) closedTime;
            if (cause == null)
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) cause;
            if (callDesc == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) callDesc;
            if (closeDesc == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) closeDesc;
            if (recvdBy == null)
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) recvdBy;
            if (recvdDate == null)
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) recvdDate;
            if (recvdTime == null)
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) recvdTime;
            if (modBy == null)
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) modBy;
            if (modDate == null)
                Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[20].Value = (object) modDate;
            if (modTime == null)
                Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[21].Value = (object) modTime;
            if (dtLastMod.HasValue)
                Adapter.InsertCommand.Parameters[22].Value = (object) dtLastMod.Value;
            else
                Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
            if (callSource == null)
                Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[23].Value = (object) callSource;
            if (quickCall == null)
                Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[24].Value = (object) quickCall;
            if (category == null)
                Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[25].Value = (object) category;
            if (catHeading == null)
                Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[26].Value = (object) catHeading;
            if (totalTime.HasValue)
                Adapter.InsertCommand.Parameters[27].Value = (object) totalTime.Value;
            else
                Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
            if (slWarnGoal == null)
                Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[28].Value = (object) slWarnGoal;
            if (slWarnDate == null)
                Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[29].Value = (object) slWarnDate;
            if (slWarnTime == null)
                Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[30].Value = (object) slWarnTime;
            if (slCompleteGoal == null)
                Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[31].Value = (object) slCompleteGoal;
            if (slCompleteDate == null)
                Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[32].Value = (object) slCompleteDate;
            if (slCompleteTime == null)
                Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[33].Value = (object) slCompleteTime;
            if (slClockStatus == null)
                Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[34].Value = (object) slClockStatus;
            if (slButtonStatus == null)
                Adapter.InsertCommand.Parameters[35].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[35].Value = (object) slButtonStatus;
            if (firstResolution == null)
                Adapter.InsertCommand.Parameters[36].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[36].Value = (object) firstResolution;
            if (slCompleteStatus == null)
                Adapter.InsertCommand.Parameters[37].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[37].Value = (object) slCompleteStatus;
            if (shortDesc == null)
                Adapter.InsertCommand.Parameters[38].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[38].Value = (object) shortDesc;
            if (urgName == null)
                Adapter.InsertCommand.Parameters[39].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[39].Value = (object) urgName;
            if (urgValue.HasValue)
                Adapter.InsertCommand.Parameters[40].Value = (object) urgValue.Value;
            else
                Adapter.InsertCommand.Parameters[40].Value = (object) DBNull.Value;
            if (impName == null)
                Adapter.InsertCommand.Parameters[41].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[41].Value = (object) impName;
            if (impValue.HasValue)
                Adapter.InsertCommand.Parameters[42].Value = (object) impValue.Value;
            else
                Adapter.InsertCommand.Parameters[42].Value = (object) DBNull.Value;
            if (priorityValue.HasValue)
                Adapter.InsertCommand.Parameters[43].Value = (object) priorityValue.Value;
            else
                Adapter.InsertCommand.Parameters[43].Value = (object) DBNull.Value;
            if (detailsReq == null)
                Adapter.InsertCommand.Parameters[44].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[44].Value = (object) detailsReq;
            if (vandalism == null)
                Adapter.InsertCommand.Parameters[45].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[45].Value = (object) vandalism;
            if (asgnGrp == null)
                Adapter.InsertCommand.Parameters[46].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[46].Value = (object) asgnGrp;
            if (assignee == null)
                Adapter.InsertCommand.Parameters[47].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[47].Value = (object) assignee;
            if (managerId == null)
                Adapter.InsertCommand.Parameters[48].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[48].Value = (object) managerId;
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
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string callId, string custId, string custType, string callType, string tracker,
            string callStatus, string priority, Decimal? cDuration, Decimal? callCount, Decimal? stopWatch,
            string closedBy, string closedDate, string closedTime, string cause, string callDesc, string closeDesc,
            string recvdBy, string recvdDate, string recvdTime, string modBy, string modDate, string modTime,
            int? dtLastMod, string callSource, string quickCall, string category, string catHeading, int? totalTime,
            string slWarnGoal, string slWarnDate, string slWarnTime, string slCompleteGoal, string slCompleteDate,
            string slCompleteTime, string slClockStatus, string slButtonStatus, string firstResolution,
            string slCompleteStatus, string shortDesc, string urgName, int? urgValue, string impName, int? impValue,
            int? priorityValue, string detailsReq, string vandalism, string asgnGrp, string assignee, string managerId,
            string originalCallId, string originalCustId, string originalCustType, string originalCallType,
            string originalTracker, string originalCallStatus, string originalPriority, Decimal? originalCDuration,
            Decimal? originalCallCount, Decimal? originalStopWatch, string originalClosedBy, string originalClosedDate,
            string originalClosedTime, string originalCause, string originalRecvdBy, string originalRecvdDate,
            string originalRecvdTime, string originalModBy, string originalModDate, string originalModTime,
            int? originalDtLastMod, string originalCallSource, string originalQuickCall, string originalCategory,
            string originalCatHeading, int? originalTotalTime, string originalSlWarnGoal, string originalSlWarnDate,
            string originalSlWarnTime, string originalSlCompleteGoal, string originalSlCompleteDate,
            string originalSlCompleteTime, string originalSlClockStatus, string originalSlButtonStatus,
            string originalFirstResolution, string originalSlCompleteStatus, string originalShortDesc,
            string originalUrgName, int? originalUrgValue, string originalImpName, int? originalImpValue,
            int? originalPriorityValue, string originalDetailsReq, string originalVandalism, string originalAsgnGrp,
            string originalAssignee, string originalManagerId)
        {
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.UpdateCommand.Parameters[0].Value = (object) callId;
            if (custId == null)
                Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[1].Value = (object) custId;
            if (custType == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) custType;
            if (callType == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) callType;
            if (tracker == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) tracker;
            if (callStatus == null)
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) callStatus;
            if (priority == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) priority;
            if (cDuration.HasValue)
                Adapter.UpdateCommand.Parameters[7].Value = (object) cDuration.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            if (callCount.HasValue)
                Adapter.UpdateCommand.Parameters[8].Value = (object) callCount.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            if (stopWatch.HasValue)
                Adapter.UpdateCommand.Parameters[9].Value = (object) stopWatch.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            if (closedBy == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) closedBy;
            if (closedDate == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) closedDate;
            if (closedTime == null)
                Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[12].Value = (object) closedTime;
            if (cause == null)
                Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[13].Value = (object) cause;
            if (callDesc == null)
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[14].Value = (object) callDesc;
            if (closeDesc == null)
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[15].Value = (object) closeDesc;
            if (recvdBy == null)
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[16].Value = (object) recvdBy;
            if (recvdDate == null)
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[17].Value = (object) recvdDate;
            if (recvdTime == null)
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[18].Value = (object) recvdTime;
            if (modBy == null)
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[19].Value = (object) modBy;
            if (modDate == null)
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[20].Value = (object) modDate;
            if (modTime == null)
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[21].Value = (object) modTime;
            if (dtLastMod.HasValue)
                Adapter.UpdateCommand.Parameters[22].Value = (object) dtLastMod.Value;
            else
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            if (callSource == null)
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[23].Value = (object) callSource;
            if (quickCall == null)
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[24].Value = (object) quickCall;
            if (category == null)
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[25].Value = (object) category;
            if (catHeading == null)
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[26].Value = (object) catHeading;
            if (totalTime.HasValue)
                Adapter.UpdateCommand.Parameters[27].Value = (object) totalTime.Value;
            else
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            if (slWarnGoal == null)
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[28].Value = (object) slWarnGoal;
            if (slWarnDate == null)
                Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[29].Value = (object) slWarnDate;
            if (slWarnTime == null)
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[30].Value = (object) slWarnTime;
            if (slCompleteGoal == null)
                Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[31].Value = (object) slCompleteGoal;
            if (slCompleteDate == null)
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[32].Value = (object) slCompleteDate;
            if (slCompleteTime == null)
                Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[33].Value = (object) slCompleteTime;
            if (slClockStatus == null)
                Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[34].Value = (object) slClockStatus;
            if (slButtonStatus == null)
                Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[35].Value = (object) slButtonStatus;
            if (firstResolution == null)
                Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[36].Value = (object) firstResolution;
            if (slCompleteStatus == null)
                Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[37].Value = (object) slCompleteStatus;
            if (shortDesc == null)
                Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[38].Value = (object) shortDesc;
            if (urgName == null)
                Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[39].Value = (object) urgName;
            if (urgValue.HasValue)
                Adapter.UpdateCommand.Parameters[40].Value = (object) urgValue.Value;
            else
                Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
            if (impName == null)
                Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[41].Value = (object) impName;
            if (impValue.HasValue)
                Adapter.UpdateCommand.Parameters[42].Value = (object) impValue.Value;
            else
                Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
            if (priorityValue.HasValue)
                Adapter.UpdateCommand.Parameters[43].Value = (object) priorityValue.Value;
            else
                Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
            if (detailsReq == null)
                Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[44].Value = (object) detailsReq;
            if (vandalism == null)
                Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[45].Value = (object) vandalism;
            if (asgnGrp == null)
                Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[46].Value = (object) asgnGrp;
            if (assignee == null)
                Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[47].Value = (object) assignee;
            if (managerId == null)
                Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[48].Value = (object) managerId;
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.UpdateCommand.Parameters[49].Value = (object) originalCallId;
            if (originalCustId == null)
            {
                Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[51].Value = (object) originalCustId;
            }
            if (originalCustType == null)
            {
                Adapter.UpdateCommand.Parameters[52].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[52].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[53].Value = (object) originalCustType;
            }
            if (originalCallType == null)
            {
                Adapter.UpdateCommand.Parameters[54].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[54].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[55].Value = (object) originalCallType;
            }
            if (originalTracker == null)
            {
                Adapter.UpdateCommand.Parameters[56].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[56].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[57].Value = (object) originalTracker;
            }
            if (originalCallStatus == null)
            {
                Adapter.UpdateCommand.Parameters[58].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[58].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[59].Value = (object) originalCallStatus;
            }
            if (originalPriority == null)
            {
                Adapter.UpdateCommand.Parameters[60].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[60].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[61].Value = (object) originalPriority;
            }
            if (originalCDuration.HasValue)
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[63].Value = (object) originalCDuration.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
            }
            if (originalCallCount.HasValue)
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[65].Value = (object) originalCallCount.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
            }
            if (originalStopWatch.HasValue)
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[67].Value = (object) originalStopWatch.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
            }
            if (originalClosedBy == null)
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[69].Value = (object) originalClosedBy;
            }
            if (originalClosedDate == null)
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[71].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[71].Value = (object) originalClosedDate;
            }
            if (originalClosedTime == null)
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[73].Value = (object) originalClosedTime;
            }
            if (originalCause == null)
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[75].Value = (object) originalCause;
            }
            if (originalRecvdBy == null)
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[77].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[77].Value = (object) originalRecvdBy;
            }
            if (originalRecvdDate == null)
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[79].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[79].Value = (object) originalRecvdDate;
            }
            if (originalRecvdTime == null)
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[81].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[81].Value = (object) originalRecvdTime;
            }
            if (originalModBy == null)
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[83].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[83].Value = (object) originalModBy;
            }
            if (originalModDate == null)
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[85].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[85].Value = (object) originalModDate;
            }
            if (originalModTime == null)
            {
                Adapter.UpdateCommand.Parameters[86].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[87].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[86].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[87].Value = (object) originalModTime;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.UpdateCommand.Parameters[88].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[89].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[88].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[89].Value = (object) DBNull.Value;
            }
            if (originalCallSource == null)
            {
                Adapter.UpdateCommand.Parameters[90].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[91].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[90].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[91].Value = (object) originalCallSource;
            }
            if (originalQuickCall == null)
            {
                Adapter.UpdateCommand.Parameters[92].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[93].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[92].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[93].Value = (object) originalQuickCall;
            }
            if (originalCategory == null)
            {
                Adapter.UpdateCommand.Parameters[94].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[95].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[94].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[95].Value = (object) originalCategory;
            }
            if (originalCatHeading == null)
            {
                Adapter.UpdateCommand.Parameters[96].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[97].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[96].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[97].Value = (object) originalCatHeading;
            }
            if (originalTotalTime.HasValue)
            {
                Adapter.UpdateCommand.Parameters[98].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[99].Value = (object) originalTotalTime.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[98].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[99].Value = (object) DBNull.Value;
            }
            if (originalSlWarnGoal == null)
            {
                Adapter.UpdateCommand.Parameters[100].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[101].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[100].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[101].Value = (object) originalSlWarnGoal;
            }
            if (originalSlWarnDate == null)
            {
                Adapter.UpdateCommand.Parameters[102].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[103].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[102].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[103].Value = (object) originalSlWarnDate;
            }
            if (originalSlWarnTime == null)
            {
                Adapter.UpdateCommand.Parameters[104].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[105].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[104].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[105].Value = (object) originalSlWarnTime;
            }
            if (originalSlCompleteGoal == null)
            {
                Adapter.UpdateCommand.Parameters[106].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[107].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[106].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[107].Value = (object) originalSlCompleteGoal;
            }
            if (originalSlCompleteDate == null)
            {
                Adapter.UpdateCommand.Parameters[108].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[109].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[108].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[109].Value = (object) originalSlCompleteDate;
            }
            if (originalSlCompleteTime == null)
            {
                Adapter.UpdateCommand.Parameters[110].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[111].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[110].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[111].Value = (object) originalSlCompleteTime;
            }
            if (originalSlClockStatus == null)
            {
                Adapter.UpdateCommand.Parameters[112].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[113].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[112].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[113].Value = (object) originalSlClockStatus;
            }
            if (originalSlButtonStatus == null)
            {
                Adapter.UpdateCommand.Parameters[114].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[115].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[114].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[115].Value = (object) originalSlButtonStatus;
            }
            if (originalFirstResolution == null)
            {
                Adapter.UpdateCommand.Parameters[116].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[117].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[116].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[117].Value = (object) originalFirstResolution;
            }
            if (originalSlCompleteStatus == null)
            {
                Adapter.UpdateCommand.Parameters[118].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[119].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[118].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[119].Value = (object) originalSlCompleteStatus;
            }
            if (originalShortDesc == null)
            {
                Adapter.UpdateCommand.Parameters[120].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[121].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[120].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[121].Value = (object) originalShortDesc;
            }
            if (originalUrgName == null)
            {
                Adapter.UpdateCommand.Parameters[122].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[123].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[122].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[123].Value = (object) originalUrgName;
            }
            if (originalUrgValue.HasValue)
            {
                Adapter.UpdateCommand.Parameters[124].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[125].Value = (object) originalUrgValue.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[124].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[125].Value = (object) DBNull.Value;
            }
            if (originalImpName == null)
            {
                Adapter.UpdateCommand.Parameters[126].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[126].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) originalImpName;
            }
            if (originalImpValue.HasValue)
            {
                Adapter.UpdateCommand.Parameters[128].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[129].Value = (object) originalImpValue.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[128].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[129].Value = (object) DBNull.Value;
            }
            if (originalPriorityValue.HasValue)
            {
                Adapter.UpdateCommand.Parameters[130].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[131].Value = (object) originalPriorityValue.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[130].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[131].Value = (object) DBNull.Value;
            }
            if (originalDetailsReq == null)
            {
                Adapter.UpdateCommand.Parameters[132].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[133].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[132].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[133].Value = (object) originalDetailsReq;
            }
            if (originalVandalism == null)
            {
                Adapter.UpdateCommand.Parameters[134].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[135].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[134].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[135].Value = (object) originalVandalism;
            }
            if (originalAsgnGrp == null)
            {
                Adapter.UpdateCommand.Parameters[136].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[137].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[136].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[137].Value = (object) originalAsgnGrp;
            }
            if (originalAssignee == null)
            {
                Adapter.UpdateCommand.Parameters[138].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[139].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[138].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[139].Value = (object) originalAssignee;
            }
            if (originalManagerId == null)
            {
                Adapter.UpdateCommand.Parameters[140].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[141].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[140].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[141].Value = (object) originalManagerId;
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
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string custId, string custType, string callType, string tracker, string callStatus,
            string priority, Decimal? cDuration, Decimal? callCount, Decimal? stopWatch, string closedBy,
            string closedDate, string closedTime, string cause, string callDesc, string closeDesc, string recvdBy,
            string recvdDate, string recvdTime, string modBy, string modDate, string modTime, int? dtLastMod,
            string callSource, string quickCall, string category, string catHeading, int? totalTime, string slWarnGoal,
            string slWarnDate, string slWarnTime, string slCompleteGoal, string slCompleteDate, string slCompleteTime,
            string slClockStatus, string slButtonStatus, string firstResolution, string slCompleteStatus,
            string shortDesc, string urgName, int? urgValue, string impName, int? impValue, int? priorityValue,
            string detailsReq, string vandalism, string asgnGrp, string assignee, string managerId,
            string originalCallId, string originalCustId, string originalCustType, string originalCallType,
            string originalTracker, string originalCallStatus, string originalPriority, Decimal? originalCDuration,
            Decimal? originalCallCount, Decimal? originalStopWatch, string originalClosedBy, string originalClosedDate,
            string originalClosedTime, string originalCause, string originalRecvdBy, string originalRecvdDate,
            string originalRecvdTime, string originalModBy, string originalModDate, string originalModTime,
            int? originalDtLastMod, string originalCallSource, string originalQuickCall, string originalCategory,
            string originalCatHeading, int? originalTotalTime, string originalSlWarnGoal, string originalSlWarnDate,
            string originalSlWarnTime, string originalSlCompleteGoal, string originalSlCompleteDate,
            string originalSlCompleteTime, string originalSlClockStatus, string originalSlButtonStatus,
            string originalFirstResolution, string originalSlCompleteStatus, string originalShortDesc,
            string originalUrgName, int? originalUrgValue, string originalImpName, int? originalImpValue,
            int? originalPriorityValue, string originalDetailsReq, string originalVandalism, string originalAsgnGrp,
            string originalAssignee, string originalManagerId)
        {
            return Update(originalCallId, custId, custType, callType, tracker, callStatus, priority, cDuration,
                callCount, stopWatch, closedBy, closedDate, closedTime, cause, callDesc, closeDesc, recvdBy, recvdDate,
                recvdTime, modBy, modDate, modTime, dtLastMod, callSource, quickCall, category, catHeading, totalTime,
                slWarnGoal, slWarnDate, slWarnTime, slCompleteGoal, slCompleteDate, slCompleteTime, slClockStatus,
                slButtonStatus, firstResolution, slCompleteStatus, shortDesc, urgName, urgValue, impName, impValue,
                priorityValue, detailsReq, vandalism, asgnGrp, assignee, managerId, originalCallId, originalCustId,
                originalCustType, originalCallType, originalTracker, originalCallStatus, originalPriority,
                originalCDuration, originalCallCount, originalStopWatch, originalClosedBy, originalClosedDate,
                originalClosedTime, originalCause, originalRecvdBy, originalRecvdDate, originalRecvdTime, originalModBy,
                originalModDate, originalModTime, originalDtLastMod, originalCallSource, originalQuickCall,
                originalCategory, originalCatHeading, originalTotalTime, originalSlWarnGoal, originalSlWarnDate,
                originalSlWarnTime, originalSlCompleteGoal, originalSlCompleteDate, originalSlCompleteTime,
                originalSlClockStatus, originalSlButtonStatus, originalFirstResolution, originalSlCompleteStatus,
                originalShortDesc, originalUrgName, originalUrgValue, originalImpName, originalImpValue,
                originalPriorityValue, originalDetailsReq, originalVandalism, originalAsgnGrp, originalAssignee,
                originalManagerId);
        }
    }
}