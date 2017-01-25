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
    [DataObject(true)]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [ToolboxItem(true)]
    [HelpKeyword("vs.data.TableAdapter")]
    public class DetailTableAdapter : Component
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public bool ClearBeforeFill
        {
            get { return _clearBeforeFill; }
            set { _clearBeforeFill = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public DetailTableAdapter()
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
                DataSetTable = "Detail",
                ColumnMappings =
                {
                    {
                        "CallID",
                        "CallID"
                    },
                    {
                        "SerialNo",
                        "SerialNo"
                    },
                    {
                        "Product",
                        "Product"
                    },
                    {
                        "Notes",
                        "Notes"
                    },
                    {
                        "SubCallType",
                        "SubCallType"
                    },
                    {
                        "ProductLine",
                        "ProductLine"
                    },
                    {
                        "Date1",
                        "Date1"
                    },
                    {
                        "Date2",
                        "Date2"
                    },
                    {
                        "Date3",
                        "Date3"
                    },
                    {
                        "Code2",
                        "Code2"
                    },
                    {
                        "DTLastMod",
                        "DTLastMod"
                    },
                    {
                        "ReturnReason",
                        "ReturnReason"
                    },
                    {
                        "YesNo1",
                        "YesNo1"
                    },
                    {
                        "YesNo2",
                        "YesNo2"
                    },
                    {
                        "Document1",
                        "Document1"
                    },
                    {
                        "Document2",
                        "Document2"
                    },
                    {
                        "Document3",
                        "Document3"
                    },
                    {
                        "Document4",
                        "Document4"
                    },
                    {
                        "Document5",
                        "Document5"
                    },
                    {
                        "FilePath1",
                        "FilePath1"
                    },
                    {
                        "FilePath2",
                        "FilePath2"
                    },
                    {
                        "FilePath3",
                        "FilePath3"
                    },
                    {
                        "FilePath4",
                        "FilePath4"
                    },
                    {
                        "FilePath5",
                        "FilePath5"
                    },
                    {
                        "Directory1",
                        "Directory1"
                    },
                    {
                        "Directory2",
                        "Directory2"
                    },
                    {
                        "Directory3",
                        "Directory3"
                    },
                    {
                        "AsgGrp1",
                        "AsgGrp1"
                    },
                    {
                        "AsgGrp2",
                        "AsgGrp2"
                    },
                    {
                        "AsgGrp3",
                        "AsgGrp3"
                    },
                    {
                        "MoveFrom",
                        "MoveFrom"
                    },
                    {
                        "MoveTo",
                        "MoveTo"
                    },
                    {
                        "TimeFrame",
                        "TimeFrame"
                    },
                    {
                        "EquipType",
                        "EquipType"
                    },
                    {
                        "Asset",
                        "Asset"
                    },
                    {
                        "SerialNum",
                        "SerialNum"
                    },
                    {
                        "ComputerName",
                        "ComputerName"
                    },
                    {
                        "Building",
                        "Building"
                    },
                    {
                        "RoomNum",
                        "RoomNum"
                    },
                    {
                        "FRRCComVote",
                        "FRRCComVote"
                    },
                    {
                        "FRRCFundingStatus",
                        "FRRCFundingStatus"
                    },
                    {
                        "FRRCAddOn",
                        "FRRCAddOn"
                    },
                    {
                        "FRRCTimeFrame",
                        "FRRCTimeFrame"
                    },
                    {
                        "FRRCMeetingDate",
                        "FRRCMeetingDate"
                    },
                    {
                        "FRRCResponsibility",
                        "FRRCResponsibility"
                    },
                    {
                        "CircuitID",
                        "CircuitID"
                    },
                    {
                        "CircuitProvider",
                        "CircuitProvider"
                    },
                    {
                        "ActionType1",
                        "ActionType1"
                    },
                    {
                        "ActionType2",
                        "ActionType2"
                    },
                    {
                        "ActionType3",
                        "ActionType3"
                    },
                    {
                        "Assignee1",
                        "Assignee1"
                    },
                    {
                        "Assignee2",
                        "Assignee2"
                    },
                    {
                        "Assignee3",
                        "Assignee3"
                    },
                    {
                        "HWAsset",
                        "HWAsset"
                    },
                    {
                        "HWSerialNum",
                        "HWSerialNum"
                    },
                    {
                        "HWComputerName",
                        "HWComputerName"
                    },
                    {
                        "Vendor",
                        "Vendor"
                    },
                    {
                        "OperatingSystem",
                        "OperatingSystem"
                    },
                    {
                        "Model",
                        "Model"
                    },
                    {
                        "OSType",
                        "OSType"
                    },
                    {
                        "Version",
                        "Version"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Detail] WHERE (([CallID] = @Original_CallID) AND ((@IsNull_SerialNo = 1 AND [SerialNo] IS NULL) OR ([SerialNo] = @Original_SerialNo)) AND ((@IsNull_Product = 1 AND [Product] IS NULL) OR ([Product] = @Original_Product)) AND ((@IsNull_SubCallType = 1 AND [SubCallType] IS NULL) OR ([SubCallType] = @Original_SubCallType)) AND ((@IsNull_ProductLine = 1 AND [ProductLine] IS NULL) OR ([ProductLine] = @Original_ProductLine)) AND ((@IsNull_Date1 = 1 AND [Date1] IS NULL) OR ([Date1] = @Original_Date1)) AND ((@IsNull_Date2 = 1 AND [Date2] IS NULL) OR ([Date2] = @Original_Date2)) AND ((@IsNull_Date3 = 1 AND [Date3] IS NULL) OR ([Date3] = @Original_Date3)) AND ((@IsNull_Code2 = 1 AND [Code2] IS NULL) OR ([Code2] = @Original_Code2)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_YesNo1 = 1 AND [YesNo1] IS NULL) OR ([YesNo1] = @Original_YesNo1)) AND ((@IsNull_YesNo2 = 1 AND [YesNo2] IS NULL) OR ([YesNo2] = @Original_YesNo2)) AND ((@IsNull_Document1 = 1 AND [Document1] IS NULL) OR ([Document1] = @Original_Document1)) AND ((@IsNull_Document2 = 1 AND [Document2] IS NULL) OR ([Document2] = @Original_Document2)) AND ((@IsNull_Document3 = 1 AND [Document3] IS NULL) OR ([Document3] = @Original_Document3)) AND ((@IsNull_Document4 = 1 AND [Document4] IS NULL) OR ([Document4] = @Original_Document4)) AND ((@IsNull_Document5 = 1 AND [Document5] IS NULL) OR ([Document5] = @Original_Document5)) AND ((@IsNull_FilePath1 = 1 AND [FilePath1] IS NULL) OR ([FilePath1] = @Original_FilePath1)) AND ((@IsNull_FilePath2 = 1 AND [FilePath2] IS NULL) OR ([FilePath2] = @Original_FilePath2)) AND ((@IsNull_FilePath3 = 1 AND [FilePath3] IS NULL) OR ([FilePath3] = @Original_FilePath3)) AND ((@IsNull_FilePath4 = 1 AND [FilePath4] IS NULL) OR ([FilePath4] = @Original_FilePath4)) AND ((@IsNull_FilePath5 = 1 AND [FilePath5] IS NULL) OR ([FilePath5] = @Original_FilePath5)) AND ((@IsNull_Directory1 = 1 AND [Directory1] IS NULL) OR ([Directory1] = @Original_Directory1)) AND ((@IsNull_Directory2 = 1 AND [Directory2] IS NULL) OR ([Directory2] = @Original_Directory2)) AND ((@IsNull_Directory3 = 1 AND [Directory3] IS NULL) OR ([Directory3] = @Original_Directory3)) AND ((@IsNull_AsgGrp1 = 1 AND [AsgGrp1] IS NULL) OR ([AsgGrp1] = @Original_AsgGrp1)) AND ((@IsNull_AsgGrp2 = 1 AND [AsgGrp2] IS NULL) OR ([AsgGrp2] = @Original_AsgGrp2)) AND ((@IsNull_AsgGrp3 = 1 AND [AsgGrp3] IS NULL) OR ([AsgGrp3] = @Original_AsgGrp3)) AND ((@IsNull_MoveFrom = 1 AND [MoveFrom] IS NULL) OR ([MoveFrom] = @Original_MoveFrom)) AND ((@IsNull_MoveTo = 1 AND [MoveTo] IS NULL) OR ([MoveTo] = @Original_MoveTo)) AND ((@IsNull_TimeFrame = 1 AND [TimeFrame] IS NULL) OR ([TimeFrame] = @Original_TimeFrame)) AND ((@IsNull_EquipType = 1 AND [EquipType] IS NULL) OR ([EquipType] = @Original_EquipType)) AND ((@IsNull_Asset = 1 AND [Asset] IS NULL) OR ([Asset] = @Original_Asset)) AND ((@IsNull_SerialNum = 1 AND [SerialNum] IS NULL) OR ([SerialNum] = @Original_SerialNum)) AND ((@IsNull_ComputerName = 1 AND [ComputerName] IS NULL) OR ([ComputerName] = @Original_ComputerName)) AND ((@IsNull_Building = 1 AND [Building] IS NULL) OR ([Building] = @Original_Building)) AND ((@IsNull_RoomNum = 1 AND [RoomNum] IS NULL) OR ([RoomNum] = @Original_RoomNum)) AND ((@IsNull_FRRCComVote = 1 AND [FRRCComVote] IS NULL) OR ([FRRCComVote] = @Original_FRRCComVote)) AND ((@IsNull_FRRCFundingStatus = 1 AND [FRRCFundingStatus] IS NULL) OR ([FRRCFundingStatus] = @Original_FRRCFundingStatus)) AND ((@IsNull_FRRCAddOn = 1 AND [FRRCAddOn] IS NULL) OR ([FRRCAddOn] = @Original_FRRCAddOn)) AND ((@IsNull_FRRCTimeFrame = 1 AND [FRRCTimeFrame] IS NULL) OR ([FRRCTimeFrame] = @Original_FRRCTimeFrame)) AND ((@IsNull_FRRCMeetingDate = 1 AND [FRRCMeetingDate] IS NULL) OR ([FRRCMeetingDate] = @Original_FRRCMeetingDate)) AND ((@IsNull_FRRCResponsibility = 1 AND [FRRCResponsibility] IS NULL) OR ([FRRCResponsibility] = @Original_FRRCResponsibility)) AND ((@IsNull_CircuitID = 1 AND [CircuitID] IS NULL) OR ([CircuitID] = @Original_CircuitID)) AND ((@IsNull_CircuitProvider = 1 AND [CircuitProvider] IS NULL) OR ([CircuitProvider] = @Original_CircuitProvider)) AND ((@IsNull_ActionType1 = 1 AND [ActionType1] IS NULL) OR ([ActionType1] = @Original_ActionType1)) AND ((@IsNull_ActionType2 = 1 AND [ActionType2] IS NULL) OR ([ActionType2] = @Original_ActionType2)) AND ((@IsNull_ActionType3 = 1 AND [ActionType3] IS NULL) OR ([ActionType3] = @Original_ActionType3)) AND ((@IsNull_Assignee1 = 1 AND [Assignee1] IS NULL) OR ([Assignee1] = @Original_Assignee1)) AND ((@IsNull_Assignee2 = 1 AND [Assignee2] IS NULL) OR ([Assignee2] = @Original_Assignee2)) AND ((@IsNull_Assignee3 = 1 AND [Assignee3] IS NULL) OR ([Assignee3] = @Original_Assignee3)) AND ((@IsNull_HWAsset = 1 AND [HWAsset] IS NULL) OR ([HWAsset] = @Original_HWAsset)) AND ((@IsNull_HWSerialNum = 1 AND [HWSerialNum] IS NULL) OR ([HWSerialNum] = @Original_HWSerialNum)) AND ((@IsNull_HWComputerName = 1 AND [HWComputerName] IS NULL) OR ([HWComputerName] = @Original_HWComputerName)) AND ((@IsNull_Vendor = 1 AND [Vendor] IS NULL) OR ([Vendor] = @Original_Vendor)) AND ((@IsNull_OperatingSystem = 1 AND [OperatingSystem] IS NULL) OR ([OperatingSystem] = @Original_OperatingSystem)) AND ((@IsNull_Model = 1 AND [Model] IS NULL) OR ([Model] = @Original_Model)) AND ((@IsNull_OSType = 1 AND [OSType] IS NULL) OR ([OSType] = @Original_OSType)) AND ((@IsNull_Version = 1 AND [Version] IS NULL) OR ([Version] = @Original_Version)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SerialNo", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNo", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SerialNo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNo", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Product", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Product", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Product", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Product", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SubCallType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubCallType", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SubCallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubCallType", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ProductLine", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProductLine", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ProductLine", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProductLine", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Date1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date1", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Date1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date1", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Date2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date2", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Date2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date2", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Date3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date3", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Date3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date3", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Code2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Code2", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Code2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Code2", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YesNo1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo1", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YesNo1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_YesNo2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo2", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_YesNo2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Document1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Document1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Document2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Document2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Document3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Document3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Document4", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document4", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Document4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document4", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Document5", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document5", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Document5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document5", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FilePath1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FilePath2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FilePath3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath4", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath4", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FilePath4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath4", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath5", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath5", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FilePath5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath5", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Directory1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Directory1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory1", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Directory2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Directory2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory2", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Directory3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Directory3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory3", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AsgGrp1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AsgGrp1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AsgGrp2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AsgGrp2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AsgGrp3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AsgGrp3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MoveFrom", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveFrom", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MoveFrom", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveFrom", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MoveTo", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveTo", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MoveTo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveTo", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TimeFrame", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeFrame", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeFrame", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EquipType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EquipType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EquipType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EquipType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Asset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Asset", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Asset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Asset", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SerialNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ComputerName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Building", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Building", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Building", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Building", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RoomNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCComVote", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCComVote", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FRRCComVote", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCComVote", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCFundingStatus", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCFundingStatus", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FRRCFundingStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCFundingStatus", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCAddOn", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCAddOn", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FRRCAddOn", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCAddOn", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCTimeFrame", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCTimeFrame", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FRRCTimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCTimeFrame", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCMeetingDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCMeetingDate", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FRRCMeetingDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCMeetingDate", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCResponsibility", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCResponsibility", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FRRCResponsibility", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCResponsibility", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CircuitID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CircuitID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CircuitProvider", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitProvider", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CircuitProvider", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitProvider", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ActionType1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType1", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ActionType1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType1", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ActionType2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType2", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ActionType2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType2", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ActionType3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType3", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ActionType3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType3", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Assignee1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Assignee2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Assignee3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HWAsset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWAsset", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HWAsset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWAsset", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HWSerialNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWSerialNum", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HWSerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWSerialNum", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HWComputerName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWComputerName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HWComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWComputerName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Vendor", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vendor", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Vendor", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vendor", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OperatingSystem", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OperatingSystem", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OperatingSystem", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OperatingSystem", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Model", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Model", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OSType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OSType", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OSType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OSType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Version", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Version", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Version", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Version", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Detail] ([CallID], [SerialNo], [Product], [Notes], [SubCallType], [ProductLine], [Date1], [Date2], [Date3], [Code2], [DTLastMod], [ReturnReason], [YesNo1], [YesNo2], [Document1], [Document2], [Document3], [Document4], [Document5], [FilePath1], [FilePath2], [FilePath3], [FilePath4], [FilePath5], [Directory1], [Directory2], [Directory3], [AsgGrp1], [AsgGrp2], [AsgGrp3], [MoveFrom], [MoveTo], [TimeFrame], [EquipType], [Asset], [SerialNum], [ComputerName], [Building], [RoomNum], [FRRCComVote], [FRRCFundingStatus], [FRRCAddOn], [FRRCTimeFrame], [FRRCMeetingDate], [FRRCResponsibility], [CircuitID], [CircuitProvider], [ActionType1], [ActionType2], [ActionType3], [Assignee1], [Assignee2], [Assignee3], [HWAsset], [HWSerialNum], [HWComputerName], [Vendor], [OperatingSystem], [Model], [OSType], [Version]) VALUES (@CallID, @SerialNo, @Product, @Notes, @SubCallType, @ProductLine, @Date1, @Date2, @Date3, @Code2, @DTLastMod, @ReturnReason, @YesNo1, @YesNo2, @Document1, @Document2, @Document3, @Document4, @Document5, @FilePath1, @FilePath2, @FilePath3, @FilePath4, @FilePath5, @Directory1, @Directory2, @Directory3, @AsgGrp1, @AsgGrp2, @AsgGrp3, @MoveFrom, @MoveTo, @TimeFrame, @EquipType, @Asset, @SerialNum, @ComputerName, @Building, @RoomNum, @FRRCComVote, @FRRCFundingStatus, @FRRCAddOn, @FRRCTimeFrame, @FRRCMeetingDate, @FRRCResponsibility, @CircuitID, @CircuitProvider, @ActionType1, @ActionType2, @ActionType3, @Assignee1, @Assignee2, @Assignee3, @HWAsset, @HWSerialNum, @HWComputerName, @Vendor, @OperatingSystem, @Model, @OSType, @Version);\r\nSELECT CallID, SerialNo, Product, Notes, SubCallType, ProductLine, Date1, Date2, Date3, Code2, DTLastMod, ReturnReason, YesNo1, YesNo2, Document1, Document2, Document3, Document4, Document5, FilePath1, FilePath2, FilePath3, FilePath4, FilePath5, Directory1, Directory2, Directory3, AsgGrp1, AsgGrp2, AsgGrp3, MoveFrom, MoveTo, TimeFrame, EquipType, Asset, SerialNum, ComputerName, Building, RoomNum, FRRCComVote, FRRCFundingStatus, FRRCAddOn, FRRCTimeFrame, FRRCMeetingDate, FRRCResponsibility, CircuitID, CircuitProvider, ActionType1, ActionType2, ActionType3, Assignee1, Assignee2, Assignee3, HWAsset, HWSerialNum, HWComputerName, Vendor, OperatingSystem, Model, OSType, Version FROM Detail WHERE (CallID = @CallID)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SerialNo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNo", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Product", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Product", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Notes", SqlDbType.Text, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "Notes", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SubCallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubCallType", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ProductLine", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProductLine", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date1", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date2", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date3", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Code2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Code2", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ReturnReason", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ReturnReason", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@YesNo1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo1", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@YesNo2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo2", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Document1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Document2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Document3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Document4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document4", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Document5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document5", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FilePath1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FilePath2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FilePath3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FilePath4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath4", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FilePath5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath5", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Directory1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Directory2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Directory3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AsgGrp1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AsgGrp2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AsgGrp3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@MoveFrom", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveFrom", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@MoveTo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveTo", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeFrame", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EquipType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EquipType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Asset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Asset", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Building", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Building", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FRRCComVote", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCComVote", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FRRCFundingStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCFundingStatus", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FRRCAddOn", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCAddOn", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FRRCTimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCTimeFrame", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FRRCMeetingDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCMeetingDate", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FRRCResponsibility", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCResponsibility", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CircuitID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CircuitProvider", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitProvider", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ActionType1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType1", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ActionType2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType2", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ActionType3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType3", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Assignee1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Assignee2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Assignee3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HWAsset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWAsset", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HWSerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWSerialNum", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HWComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWComputerName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Vendor", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vendor", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@OperatingSystem", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OperatingSystem", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@OSType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OSType", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Version", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Version", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Detail] SET [CallID] = @CallID, [SerialNo] = @SerialNo, [Product] = @Product, [Notes] = @Notes, [SubCallType] = @SubCallType, [ProductLine] = @ProductLine, [Date1] = @Date1, [Date2] = @Date2, [Date3] = @Date3, [Code2] = @Code2, [DTLastMod] = @DTLastMod, [ReturnReason] = @ReturnReason, [YesNo1] = @YesNo1, [YesNo2] = @YesNo2, [Document1] = @Document1, [Document2] = @Document2, [Document3] = @Document3, [Document4] = @Document4, [Document5] = @Document5, [FilePath1] = @FilePath1, [FilePath2] = @FilePath2, [FilePath3] = @FilePath3, [FilePath4] = @FilePath4, [FilePath5] = @FilePath5, [Directory1] = @Directory1, [Directory2] = @Directory2, [Directory3] = @Directory3, [AsgGrp1] = @AsgGrp1, [AsgGrp2] = @AsgGrp2, [AsgGrp3] = @AsgGrp3, [MoveFrom] = @MoveFrom, [MoveTo] = @MoveTo, [TimeFrame] = @TimeFrame, [EquipType] = @EquipType, [Asset] = @Asset, [SerialNum] = @SerialNum, [ComputerName] = @ComputerName, [Building] = @Building, [RoomNum] = @RoomNum, [FRRCComVote] = @FRRCComVote, [FRRCFundingStatus] = @FRRCFundingStatus, [FRRCAddOn] = @FRRCAddOn, [FRRCTimeFrame] = @FRRCTimeFrame, [FRRCMeetingDate] = @FRRCMeetingDate, [FRRCResponsibility] = @FRRCResponsibility, [CircuitID] = @CircuitID, [CircuitProvider] = @CircuitProvider, [ActionType1] = @ActionType1, [ActionType2] = @ActionType2, [ActionType3] = @ActionType3, [Assignee1] = @Assignee1, [Assignee2] = @Assignee2, [Assignee3] = @Assignee3, [HWAsset] = @HWAsset, [HWSerialNum] = @HWSerialNum, [HWComputerName] = @HWComputerName, [Vendor] = @Vendor, [OperatingSystem] = @OperatingSystem, [Model] = @Model, [OSType] = @OSType, [Version] = @Version WHERE (([CallID] = @Original_CallID) AND ((@IsNull_SerialNo = 1 AND [SerialNo] IS NULL) OR ([SerialNo] = @Original_SerialNo)) AND ((@IsNull_Product = 1 AND [Product] IS NULL) OR ([Product] = @Original_Product)) AND ((@IsNull_SubCallType = 1 AND [SubCallType] IS NULL) OR ([SubCallType] = @Original_SubCallType)) AND ((@IsNull_ProductLine = 1 AND [ProductLine] IS NULL) OR ([ProductLine] = @Original_ProductLine)) AND ((@IsNull_Date1 = 1 AND [Date1] IS NULL) OR ([Date1] = @Original_Date1)) AND ((@IsNull_Date2 = 1 AND [Date2] IS NULL) OR ([Date2] = @Original_Date2)) AND ((@IsNull_Date3 = 1 AND [Date3] IS NULL) OR ([Date3] = @Original_Date3)) AND ((@IsNull_Code2 = 1 AND [Code2] IS NULL) OR ([Code2] = @Original_Code2)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_YesNo1 = 1 AND [YesNo1] IS NULL) OR ([YesNo1] = @Original_YesNo1)) AND ((@IsNull_YesNo2 = 1 AND [YesNo2] IS NULL) OR ([YesNo2] = @Original_YesNo2)) AND ((@IsNull_Document1 = 1 AND [Document1] IS NULL) OR ([Document1] = @Original_Document1)) AND ((@IsNull_Document2 = 1 AND [Document2] IS NULL) OR ([Document2] = @Original_Document2)) AND ((@IsNull_Document3 = 1 AND [Document3] IS NULL) OR ([Document3] = @Original_Document3)) AND ((@IsNull_Document4 = 1 AND [Document4] IS NULL) OR ([Document4] = @Original_Document4)) AND ((@IsNull_Document5 = 1 AND [Document5] IS NULL) OR ([Document5] = @Original_Document5)) AND ((@IsNull_FilePath1 = 1 AND [FilePath1] IS NULL) OR ([FilePath1] = @Original_FilePath1)) AND ((@IsNull_FilePath2 = 1 AND [FilePath2] IS NULL) OR ([FilePath2] = @Original_FilePath2)) AND ((@IsNull_FilePath3 = 1 AND [FilePath3] IS NULL) OR ([FilePath3] = @Original_FilePath3)) AND ((@IsNull_FilePath4 = 1 AND [FilePath4] IS NULL) OR ([FilePath4] = @Original_FilePath4)) AND ((@IsNull_FilePath5 = 1 AND [FilePath5] IS NULL) OR ([FilePath5] = @Original_FilePath5)) AND ((@IsNull_Directory1 = 1 AND [Directory1] IS NULL) OR ([Directory1] = @Original_Directory1)) AND ((@IsNull_Directory2 = 1 AND [Directory2] IS NULL) OR ([Directory2] = @Original_Directory2)) AND ((@IsNull_Directory3 = 1 AND [Directory3] IS NULL) OR ([Directory3] = @Original_Directory3)) AND ((@IsNull_AsgGrp1 = 1 AND [AsgGrp1] IS NULL) OR ([AsgGrp1] = @Original_AsgGrp1)) AND ((@IsNull_AsgGrp2 = 1 AND [AsgGrp2] IS NULL) OR ([AsgGrp2] = @Original_AsgGrp2)) AND ((@IsNull_AsgGrp3 = 1 AND [AsgGrp3] IS NULL) OR ([AsgGrp3] = @Original_AsgGrp3)) AND ((@IsNull_MoveFrom = 1 AND [MoveFrom] IS NULL) OR ([MoveFrom] = @Original_MoveFrom)) AND ((@IsNull_MoveTo = 1 AND [MoveTo] IS NULL) OR ([MoveTo] = @Original_MoveTo)) AND ((@IsNull_TimeFrame = 1 AND [TimeFrame] IS NULL) OR ([TimeFrame] = @Original_TimeFrame)) AND ((@IsNull_EquipType = 1 AND [EquipType] IS NULL) OR ([EquipType] = @Original_EquipType)) AND ((@IsNull_Asset = 1 AND [Asset] IS NULL) OR ([Asset] = @Original_Asset)) AND ((@IsNull_SerialNum = 1 AND [SerialNum] IS NULL) OR ([SerialNum] = @Original_SerialNum)) AND ((@IsNull_ComputerName = 1 AND [ComputerName] IS NULL) OR ([ComputerName] = @Original_ComputerName)) AND ((@IsNull_Building = 1 AND [Building] IS NULL) OR ([Building] = @Original_Building)) AND ((@IsNull_RoomNum = 1 AND [RoomNum] IS NULL) OR ([RoomNum] = @Original_RoomNum)) AND ((@IsNull_FRRCComVote = 1 AND [FRRCComVote] IS NULL) OR ([FRRCComVote] = @Original_FRRCComVote)) AND ((@IsNull_FRRCFundingStatus = 1 AND [FRRCFundingStatus] IS NULL) OR ([FRRCFundingStatus] = @Original_FRRCFundingStatus)) AND ((@IsNull_FRRCAddOn = 1 AND [FRRCAddOn] IS NULL) OR ([FRRCAddOn] = @Original_FRRCAddOn)) AND ((@IsNull_FRRCTimeFrame = 1 AND [FRRCTimeFrame] IS NULL) OR ([FRRCTimeFrame] = @Original_FRRCTimeFrame)) AND ((@IsNull_FRRCMeetingDate = 1 AND [FRRCMeetingDate] IS NULL) OR ([FRRCMeetingDate] = @Original_FRRCMeetingDate)) AND ((@IsNull_FRRCResponsibility = 1 AND [FRRCResponsibility] IS NULL) OR ([FRRCResponsibility] = @Original_FRRCResponsibility)) AND ((@IsNull_CircuitID = 1 AND [CircuitID] IS NULL) OR ([CircuitID] = @Original_CircuitID)) AND ((@IsNull_CircuitProvider = 1 AND [CircuitProvider] IS NULL) OR ([CircuitProvider] = @Original_CircuitProvider)) AND ((@IsNull_ActionType1 = 1 AND [ActionType1] IS NULL) OR ([ActionType1] = @Original_ActionType1)) AND ((@IsNull_ActionType2 = 1 AND [ActionType2] IS NULL) OR ([ActionType2] = @Original_ActionType2)) AND ((@IsNull_ActionType3 = 1 AND [ActionType3] IS NULL) OR ([ActionType3] = @Original_ActionType3)) AND ((@IsNull_Assignee1 = 1 AND [Assignee1] IS NULL) OR ([Assignee1] = @Original_Assignee1)) AND ((@IsNull_Assignee2 = 1 AND [Assignee2] IS NULL) OR ([Assignee2] = @Original_Assignee2)) AND ((@IsNull_Assignee3 = 1 AND [Assignee3] IS NULL) OR ([Assignee3] = @Original_Assignee3)) AND ((@IsNull_HWAsset = 1 AND [HWAsset] IS NULL) OR ([HWAsset] = @Original_HWAsset)) AND ((@IsNull_HWSerialNum = 1 AND [HWSerialNum] IS NULL) OR ([HWSerialNum] = @Original_HWSerialNum)) AND ((@IsNull_HWComputerName = 1 AND [HWComputerName] IS NULL) OR ([HWComputerName] = @Original_HWComputerName)) AND ((@IsNull_Vendor = 1 AND [Vendor] IS NULL) OR ([Vendor] = @Original_Vendor)) AND ((@IsNull_OperatingSystem = 1 AND [OperatingSystem] IS NULL) OR ([OperatingSystem] = @Original_OperatingSystem)) AND ((@IsNull_Model = 1 AND [Model] IS NULL) OR ([Model] = @Original_Model)) AND ((@IsNull_OSType = 1 AND [OSType] IS NULL) OR ([OSType] = @Original_OSType)) AND ((@IsNull_Version = 1 AND [Version] IS NULL) OR ([Version] = @Original_Version)));\r\nSELECT CallID, SerialNo, Product, Notes, SubCallType, ProductLine, Date1, Date2, Date3, Code2, DTLastMod, ReturnReason, YesNo1, YesNo2, Document1, Document2, Document3, Document4, Document5, FilePath1, FilePath2, FilePath3, FilePath4, FilePath5, Directory1, Directory2, Directory3, AsgGrp1, AsgGrp2, AsgGrp3, MoveFrom, MoveTo, TimeFrame, EquipType, Asset, SerialNum, ComputerName, Building, RoomNum, FRRCComVote, FRRCFundingStatus, FRRCAddOn, FRRCTimeFrame, FRRCMeetingDate, FRRCResponsibility, CircuitID, CircuitProvider, ActionType1, ActionType2, ActionType3, Assignee1, Assignee2, Assignee3, HWAsset, HWSerialNum, HWComputerName, Vendor, OperatingSystem, Model, OSType, Version FROM Detail WHERE (CallID = @CallID)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SerialNo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNo", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Product", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Product", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Notes", SqlDbType.Text, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "Notes", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SubCallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubCallType", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ProductLine", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProductLine", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Date1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date1", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Date2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date2", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Date3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date3", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Code2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Code2", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ReturnReason", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ReturnReason", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YesNo1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo1", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@YesNo2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo2", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Document1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Document2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Document3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Document4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document4", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Document5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document5", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FilePath1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FilePath2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FilePath3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FilePath4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath4", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FilePath5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath5", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Directory1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Directory2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Directory3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AsgGrp1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AsgGrp2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AsgGrp3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MoveFrom", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveFrom", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MoveTo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveTo", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeFrame", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EquipType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EquipType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Asset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Asset", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Building", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Building", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FRRCComVote", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCComVote", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FRRCFundingStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCFundingStatus", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FRRCAddOn", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCAddOn", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FRRCTimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCTimeFrame", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FRRCMeetingDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCMeetingDate", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FRRCResponsibility", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCResponsibility", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CircuitID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CircuitProvider", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitProvider", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ActionType1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType1", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ActionType2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType2", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ActionType3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType3", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Assignee1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Assignee2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee2", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Assignee3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee3", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HWAsset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWAsset", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HWSerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWSerialNum", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HWComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWComputerName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Vendor", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vendor", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OperatingSystem", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OperatingSystem", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OSType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OSType", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Version", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Version", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SerialNo", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNo", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SerialNo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNo", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Product", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Product", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Product", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Product", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SubCallType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubCallType", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SubCallType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SubCallType", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ProductLine", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProductLine", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ProductLine", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProductLine", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Date1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date1", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Date1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date1", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Date2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date2", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Date2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date2", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Date3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date3", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Date3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Date3", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Code2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Code2", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Code2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Code2", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YesNo1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo1", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YesNo1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_YesNo2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo2", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_YesNo2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "YesNo2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Document1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Document1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Document2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Document2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Document3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Document3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Document4", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document4", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Document4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document4", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Document5", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document5", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Document5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Document5", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FilePath1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FilePath2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FilePath3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath4", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath4", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FilePath4", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath4", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FilePath5", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath5", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FilePath5", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FilePath5", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Directory1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Directory1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory1", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Directory2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Directory2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory2", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Directory3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Directory3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Directory3", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AsgGrp1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AsgGrp1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AsgGrp2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AsgGrp2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AsgGrp3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AsgGrp3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AsgGrp3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MoveFrom", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveFrom", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MoveFrom", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveFrom", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MoveTo", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveTo", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MoveTo", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MoveTo", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TimeFrame", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeFrame", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TimeFrame", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EquipType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EquipType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EquipType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EquipType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Asset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Asset", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Asset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Asset", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SerialNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ComputerName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Building", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Building", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Building", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Building", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RoomNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCComVote", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCComVote", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FRRCComVote", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCComVote", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCFundingStatus", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCFundingStatus", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FRRCFundingStatus", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCFundingStatus", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCAddOn", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCAddOn", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FRRCAddOn", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCAddOn", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCTimeFrame", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCTimeFrame", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FRRCTimeFrame", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCTimeFrame", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCMeetingDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCMeetingDate", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FRRCMeetingDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCMeetingDate", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FRRCResponsibility", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCResponsibility", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FRRCResponsibility", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FRRCResponsibility", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CircuitID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CircuitID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CircuitProvider", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitProvider", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CircuitProvider", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CircuitProvider", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ActionType1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType1", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ActionType1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType1", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ActionType2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType2", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ActionType2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType2", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ActionType3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType3", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ActionType3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ActionType3", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Assignee1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee2", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee2", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Assignee2", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee2", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Assignee3", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee3", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Assignee3", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Assignee3", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HWAsset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWAsset", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HWAsset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWAsset", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HWSerialNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWSerialNum", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HWSerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWSerialNum", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HWComputerName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWComputerName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HWComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HWComputerName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Vendor", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vendor", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Vendor", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Vendor", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OperatingSystem", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OperatingSystem", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OperatingSystem", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OperatingSystem", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Model", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Model", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Model", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OSType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OSType", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OSType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OSType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Version", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Version", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Version", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Version", DataRowVersion.Original, false, (object) null,
                "", "", ""));
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
                "SELECT CallID, SerialNo, Product, Notes, SubCallType, ProductLine, Date1, Date2, Date3, Code2, DTLastMod, ReturnReason, YesNo1, YesNo2, Document1, Document2, Document3, Document4, Document5, FilePath1, FilePath2, FilePath3, FilePath4, FilePath5, Directory1, Directory2, Directory3, AsgGrp1, AsgGrp2, AsgGrp3, MoveFrom, MoveTo, TimeFrame, EquipType, Asset, SerialNum, ComputerName, Building, RoomNum, FRRCComVote, FRRCFundingStatus, FRRCAddOn, FRRCTimeFrame, FRRCMeetingDate, FRRCResponsibility, CircuitID, CircuitProvider, ActionType1, ActionType2, ActionType3, Assignee1, Assignee2, Assignee3, HWAsset, HWSerialNum, HWComputerName, Vendor, OperatingSystem, Model, OSType, Version FROM dbo.Detail";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public virtual int Fill(HeaTdbDataSet.DetailDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual HeaTdbDataSet.DetailDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.DetailDataTable detailDataTable = new HeaTdbDataSet.DetailDataTable();
            Adapter.Fill((DataTable) detailDataTable);
            return detailDataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet.DetailDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Detail");
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(string originalCallId, string originalSerialNo, string originalProduct,
            string originalSubCallType, string originalProductLine, string originalDate1, string originalDate2,
            string originalDate3, string originalCode2, int? originalDtLastMod, string originalYesNo1,
            string originalYesNo2, string originalDocument1, string originalDocument2, string originalDocument3,
            string originalDocument4, string originalDocument5, string originalFilePath1, string originalFilePath2,
            string originalFilePath3, string originalFilePath4, string originalFilePath5, string originalDirectory1,
            string originalDirectory2, string originalDirectory3, string originalAsgGrp1, string originalAsgGrp2,
            string originalAsgGrp3, string originalMoveFrom, string originalMoveTo, string originalTimeFrame,
            string originalEquipType, string originalAsset, string originalSerialNum, string originalComputerName,
            string originalBuilding, string originalRoomNum, string originalFrrcComVote,
            string originalFrrcFundingStatus, string originalFrrcAddOn, string originalFrrcTimeFrame,
            string originalFrrcMeetingDate, string originalFrrcResponsibility, string originalCircuitId,
            string originalCircuitProvider, string originalActionType1, string originalActionType2,
            string originalActionType3, string originalAssignee1, string originalAssignee2, string originalAssignee3,
            string originalHwAsset, string originalHwSerialNum, string originalHwComputerName, string originalVendor,
            string originalOperatingSystem, string originalModel, string originalOsType, string originalVersion)
        {
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.DeleteCommand.Parameters[0].Value = (object) originalCallId;
            if (originalSerialNo == null)
            {
                Adapter.DeleteCommand.Parameters[1].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[2].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[1].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[2].Value = (object) originalSerialNo;
            }
            if (originalProduct == null)
            {
                Adapter.DeleteCommand.Parameters[3].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[4].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[3].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[4].Value = (object) originalProduct;
            }
            if (originalSubCallType == null)
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[6].Value = (object) originalSubCallType;
            }
            if (originalProductLine == null)
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[8].Value = (object) originalProductLine;
            }
            if (originalDate1 == null)
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[10].Value = (object) originalDate1;
            }
            if (originalDate2 == null)
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[12].Value = (object) originalDate2;
            }
            if (originalDate3 == null)
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[14].Value = (object) originalDate3;
            }
            if (originalCode2 == null)
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[16].Value = (object) originalCode2;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[18].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
            }
            if (originalYesNo1 == null)
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[20].Value = (object) originalYesNo1;
            }
            if (originalYesNo2 == null)
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[22].Value = (object) originalYesNo2;
            }
            if (originalDocument1 == null)
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[24].Value = (object) originalDocument1;
            }
            if (originalDocument2 == null)
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[26].Value = (object) originalDocument2;
            }
            if (originalDocument3 == null)
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[28].Value = (object) originalDocument3;
            }
            if (originalDocument4 == null)
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[30].Value = (object) originalDocument4;
            }
            if (originalDocument5 == null)
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[32].Value = (object) originalDocument5;
            }
            if (originalFilePath1 == null)
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[34].Value = (object) originalFilePath1;
            }
            if (originalFilePath2 == null)
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[36].Value = (object) originalFilePath2;
            }
            if (originalFilePath3 == null)
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[38].Value = (object) originalFilePath3;
            }
            if (originalFilePath4 == null)
            {
                Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[40].Value = (object) originalFilePath4;
            }
            if (originalFilePath5 == null)
            {
                Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[42].Value = (object) originalFilePath5;
            }
            if (originalDirectory1 == null)
            {
                Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[44].Value = (object) originalDirectory1;
            }
            if (originalDirectory2 == null)
            {
                Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[46].Value = (object) originalDirectory2;
            }
            if (originalDirectory3 == null)
            {
                Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[48].Value = (object) originalDirectory3;
            }
            if (originalAsgGrp1 == null)
            {
                Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[50].Value = (object) originalAsgGrp1;
            }
            if (originalAsgGrp2 == null)
            {
                Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[52].Value = (object) originalAsgGrp2;
            }
            if (originalAsgGrp3 == null)
            {
                Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[54].Value = (object) originalAsgGrp3;
            }
            if (originalMoveFrom == null)
            {
                Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[56].Value = (object) originalMoveFrom;
            }
            if (originalMoveTo == null)
            {
                Adapter.DeleteCommand.Parameters[57].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[58].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[57].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[58].Value = (object) originalMoveTo;
            }
            if (originalTimeFrame == null)
            {
                Adapter.DeleteCommand.Parameters[59].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[60].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[59].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[60].Value = (object) originalTimeFrame;
            }
            if (originalEquipType == null)
            {
                Adapter.DeleteCommand.Parameters[61].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[62].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[61].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[62].Value = (object) originalEquipType;
            }
            if (originalAsset == null)
            {
                Adapter.DeleteCommand.Parameters[63].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[64].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[63].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[64].Value = (object) originalAsset;
            }
            if (originalSerialNum == null)
            {
                Adapter.DeleteCommand.Parameters[65].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[66].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[65].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[66].Value = (object) originalSerialNum;
            }
            if (originalComputerName == null)
            {
                Adapter.DeleteCommand.Parameters[67].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[68].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[67].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[68].Value = (object) originalComputerName;
            }
            if (originalBuilding == null)
            {
                Adapter.DeleteCommand.Parameters[69].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[70].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[69].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[70].Value = (object) originalBuilding;
            }
            if (originalRoomNum == null)
            {
                Adapter.DeleteCommand.Parameters[71].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[72].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[71].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[72].Value = (object) originalRoomNum;
            }
            if (originalFrrcComVote == null)
            {
                Adapter.DeleteCommand.Parameters[73].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[74].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[73].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[74].Value = (object) originalFrrcComVote;
            }
            if (originalFrrcFundingStatus == null)
            {
                Adapter.DeleteCommand.Parameters[75].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[76].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[75].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[76].Value = (object) originalFrrcFundingStatus;
            }
            if (originalFrrcAddOn == null)
            {
                Adapter.DeleteCommand.Parameters[77].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[78].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[77].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[78].Value = (object) originalFrrcAddOn;
            }
            if (originalFrrcTimeFrame == null)
            {
                Adapter.DeleteCommand.Parameters[79].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[80].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[79].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[80].Value = (object) originalFrrcTimeFrame;
            }
            if (originalFrrcMeetingDate == null)
            {
                Adapter.DeleteCommand.Parameters[81].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[82].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[81].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[82].Value = (object) originalFrrcMeetingDate;
            }
            if (originalFrrcResponsibility == null)
            {
                Adapter.DeleteCommand.Parameters[83].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[84].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[83].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[84].Value = (object) originalFrrcResponsibility;
            }
            if (originalCircuitId == null)
            {
                Adapter.DeleteCommand.Parameters[85].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[86].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[85].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[86].Value = (object) originalCircuitId;
            }
            if (originalCircuitProvider == null)
            {
                Adapter.DeleteCommand.Parameters[87].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[88].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[87].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[88].Value = (object) originalCircuitProvider;
            }
            if (originalActionType1 == null)
            {
                Adapter.DeleteCommand.Parameters[89].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[90].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[89].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[90].Value = (object) originalActionType1;
            }
            if (originalActionType2 == null)
            {
                Adapter.DeleteCommand.Parameters[91].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[92].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[91].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[92].Value = (object) originalActionType2;
            }
            if (originalActionType3 == null)
            {
                Adapter.DeleteCommand.Parameters[93].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[94].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[93].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[94].Value = (object) originalActionType3;
            }
            if (originalAssignee1 == null)
            {
                Adapter.DeleteCommand.Parameters[95].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[96].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[95].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[96].Value = (object) originalAssignee1;
            }
            if (originalAssignee2 == null)
            {
                Adapter.DeleteCommand.Parameters[97].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[98].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[97].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[98].Value = (object) originalAssignee2;
            }
            if (originalAssignee3 == null)
            {
                Adapter.DeleteCommand.Parameters[99].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[100].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[99].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[100].Value = (object) originalAssignee3;
            }
            if (originalHwAsset == null)
            {
                Adapter.DeleteCommand.Parameters[101].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[102].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[101].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[102].Value = (object) originalHwAsset;
            }
            if (originalHwSerialNum == null)
            {
                Adapter.DeleteCommand.Parameters[103].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[104].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[103].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[104].Value = (object) originalHwSerialNum;
            }
            if (originalHwComputerName == null)
            {
                Adapter.DeleteCommand.Parameters[105].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[106].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[105].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[106].Value = (object) originalHwComputerName;
            }
            if (originalVendor == null)
            {
                Adapter.DeleteCommand.Parameters[107].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[108].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[107].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[108].Value = (object) originalVendor;
            }
            if (originalOperatingSystem == null)
            {
                Adapter.DeleteCommand.Parameters[109].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[110].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[109].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[110].Value = (object) originalOperatingSystem;
            }
            if (originalModel == null)
            {
                Adapter.DeleteCommand.Parameters[111].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[112].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[111].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[112].Value = (object) originalModel;
            }
            if (originalOsType == null)
            {
                Adapter.DeleteCommand.Parameters[113].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[114].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[113].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[114].Value = (object) originalOsType;
            }
            if (originalVersion == null)
            {
                Adapter.DeleteCommand.Parameters[115].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[116].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[115].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[116].Value = (object) originalVersion;
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
        public virtual int Insert(string callId, string serialNo, string product, string notes, string subCallType,
            string productLine, string date1, string date2, string date3, string code2, int? dtLastMod,
            string returnReason, string yesNo1, string yesNo2, string document1, string document2, string document3,
            string document4, string document5, string filePath1, string filePath2, string filePath3, string filePath4,
            string filePath5, string directory1, string directory2, string directory3, string asgGrp1, string asgGrp2,
            string asgGrp3, string moveFrom, string moveTo, string timeFrame, string equipType, string asset,
            string serialNum, string computerName, string building, string roomNum, string frrcComVote,
            string frrcFundingStatus, string frrcAddOn, string frrcTimeFrame, string frrcMeetingDate,
            string frrcResponsibility, string circuitId, string circuitProvider, string actionType1, string actionType2,
            string actionType3, string assignee1, string assignee2, string assignee3, string hwAsset, string hwSerialNum,
            string hwComputerName, string vendor, string operatingSystem, string model, string osType, string version)
        {
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.InsertCommand.Parameters[0].Value = (object) callId;
            if (serialNo == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) serialNo;
            if (product == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) product;
            if (notes == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) notes;
            if (subCallType == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) subCallType;
            if (productLine == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) productLine;
            if (date1 == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) date1;
            if (date2 == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) date2;
            if (date3 == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) date3;
            if (code2 == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) code2;
            if (dtLastMod.HasValue)
                Adapter.InsertCommand.Parameters[10].Value = (object) dtLastMod.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            if (returnReason == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) returnReason;
            if (yesNo1 == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) yesNo1;
            if (yesNo2 == null)
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) yesNo2;
            if (document1 == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) document1;
            if (document2 == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) document2;
            if (document3 == null)
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) document3;
            if (document4 == null)
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) document4;
            if (document5 == null)
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) document5;
            if (filePath1 == null)
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) filePath1;
            if (filePath2 == null)
                Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[20].Value = (object) filePath2;
            if (filePath3 == null)
                Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[21].Value = (object) filePath3;
            if (filePath4 == null)
                Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[22].Value = (object) filePath4;
            if (filePath5 == null)
                Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[23].Value = (object) filePath5;
            if (directory1 == null)
                Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[24].Value = (object) directory1;
            if (directory2 == null)
                Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[25].Value = (object) directory2;
            if (directory3 == null)
                Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[26].Value = (object) directory3;
            if (asgGrp1 == null)
                Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[27].Value = (object) asgGrp1;
            if (asgGrp2 == null)
                Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[28].Value = (object) asgGrp2;
            if (asgGrp3 == null)
                Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[29].Value = (object) asgGrp3;
            if (moveFrom == null)
                Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[30].Value = (object) moveFrom;
            if (moveTo == null)
                Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[31].Value = (object) moveTo;
            if (timeFrame == null)
                Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[32].Value = (object) timeFrame;
            if (equipType == null)
                Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[33].Value = (object) equipType;
            if (asset == null)
                Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[34].Value = (object) asset;
            if (serialNum == null)
                Adapter.InsertCommand.Parameters[35].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[35].Value = (object) serialNum;
            if (computerName == null)
                Adapter.InsertCommand.Parameters[36].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[36].Value = (object) computerName;
            if (building == null)
                Adapter.InsertCommand.Parameters[37].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[37].Value = (object) building;
            if (roomNum == null)
                Adapter.InsertCommand.Parameters[38].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[38].Value = (object) roomNum;
            if (frrcComVote == null)
                Adapter.InsertCommand.Parameters[39].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[39].Value = (object) frrcComVote;
            if (frrcFundingStatus == null)
                Adapter.InsertCommand.Parameters[40].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[40].Value = (object) frrcFundingStatus;
            if (frrcAddOn == null)
                Adapter.InsertCommand.Parameters[41].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[41].Value = (object) frrcAddOn;
            if (frrcTimeFrame == null)
                Adapter.InsertCommand.Parameters[42].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[42].Value = (object) frrcTimeFrame;
            if (frrcMeetingDate == null)
                Adapter.InsertCommand.Parameters[43].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[43].Value = (object) frrcMeetingDate;
            if (frrcResponsibility == null)
                Adapter.InsertCommand.Parameters[44].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[44].Value = (object) frrcResponsibility;
            if (circuitId == null)
                Adapter.InsertCommand.Parameters[45].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[45].Value = (object) circuitId;
            if (circuitProvider == null)
                Adapter.InsertCommand.Parameters[46].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[46].Value = (object) circuitProvider;
            if (actionType1 == null)
                Adapter.InsertCommand.Parameters[47].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[47].Value = (object) actionType1;
            if (actionType2 == null)
                Adapter.InsertCommand.Parameters[48].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[48].Value = (object) actionType2;
            if (actionType3 == null)
                Adapter.InsertCommand.Parameters[49].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[49].Value = (object) actionType3;
            if (assignee1 == null)
                Adapter.InsertCommand.Parameters[50].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[50].Value = (object) assignee1;
            if (assignee2 == null)
                Adapter.InsertCommand.Parameters[51].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[51].Value = (object) assignee2;
            if (assignee3 == null)
                Adapter.InsertCommand.Parameters[52].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[52].Value = (object) assignee3;
            if (hwAsset == null)
                Adapter.InsertCommand.Parameters[53].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[53].Value = (object) hwAsset;
            if (hwSerialNum == null)
                Adapter.InsertCommand.Parameters[54].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[54].Value = (object) hwSerialNum;
            if (hwComputerName == null)
                Adapter.InsertCommand.Parameters[55].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[55].Value = (object) hwComputerName;
            if (vendor == null)
                Adapter.InsertCommand.Parameters[56].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[56].Value = (object) vendor;
            if (operatingSystem == null)
                Adapter.InsertCommand.Parameters[57].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[57].Value = (object) operatingSystem;
            if (model == null)
                Adapter.InsertCommand.Parameters[58].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[58].Value = (object) model;
            if (osType == null)
                Adapter.InsertCommand.Parameters[59].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[59].Value = (object) osType;
            if (version == null)
                Adapter.InsertCommand.Parameters[60].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[60].Value = (object) version;
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
        public virtual int Update(string callId, string serialNo, string product, string notes, string subCallType,
            string productLine, string date1, string date2, string date3, string code2, int? dtLastMod,
            string returnReason, string yesNo1, string yesNo2, string document1, string document2, string document3,
            string document4, string document5, string filePath1, string filePath2, string filePath3, string filePath4,
            string filePath5, string directory1, string directory2, string directory3, string asgGrp1, string asgGrp2,
            string asgGrp3, string moveFrom, string moveTo, string timeFrame, string equipType, string asset,
            string serialNum, string computerName, string building, string roomNum, string frrcComVote,
            string frrcFundingStatus, string frrcAddOn, string frrcTimeFrame, string frrcMeetingDate,
            string frrcResponsibility, string circuitId, string circuitProvider, string actionType1, string actionType2,
            string actionType3, string assignee1, string assignee2, string assignee3, string hwAsset, string hwSerialNum,
            string hwComputerName, string vendor, string operatingSystem, string model, string osType, string version,
            string originalCallId, string originalSerialNo, string originalProduct, string originalSubCallType,
            string originalProductLine, string originalDate1, string originalDate2, string originalDate3,
            string originalCode2, int? originalDtLastMod, string originalYesNo1, string originalYesNo2,
            string originalDocument1, string originalDocument2, string originalDocument3, string originalDocument4,
            string originalDocument5, string originalFilePath1, string originalFilePath2, string originalFilePath3,
            string originalFilePath4, string originalFilePath5, string originalDirectory1, string originalDirectory2,
            string originalDirectory3, string originalAsgGrp1, string originalAsgGrp2, string originalAsgGrp3,
            string originalMoveFrom, string originalMoveTo, string originalTimeFrame, string originalEquipType,
            string originalAsset, string originalSerialNum, string originalComputerName, string originalBuilding,
            string originalRoomNum, string originalFrrcComVote, string originalFrrcFundingStatus,
            string originalFrrcAddOn, string originalFrrcTimeFrame, string originalFrrcMeetingDate,
            string originalFrrcResponsibility, string originalCircuitId, string originalCircuitProvider,
            string originalActionType1, string originalActionType2, string originalActionType3, string originalAssignee1,
            string originalAssignee2, string originalAssignee3, string originalHwAsset, string originalHwSerialNum,
            string originalHwComputerName, string originalVendor, string originalOperatingSystem, string originalModel,
            string originalOsType, string originalVersion)
        {
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.UpdateCommand.Parameters[0].Value = (object) callId;
            if (serialNo == null)
                Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[1].Value = (object) serialNo;
            if (product == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) product;
            if (notes == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) notes;
            if (subCallType == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) subCallType;
            if (productLine == null)
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) productLine;
            if (date1 == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) date1;
            if (date2 == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) date2;
            if (date3 == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) date3;
            if (code2 == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) code2;
            if (dtLastMod.HasValue)
                Adapter.UpdateCommand.Parameters[10].Value = (object) dtLastMod.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            if (returnReason == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) returnReason;
            if (yesNo1 == null)
                Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[12].Value = (object) yesNo1;
            if (yesNo2 == null)
                Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[13].Value = (object) yesNo2;
            if (document1 == null)
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[14].Value = (object) document1;
            if (document2 == null)
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[15].Value = (object) document2;
            if (document3 == null)
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[16].Value = (object) document3;
            if (document4 == null)
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[17].Value = (object) document4;
            if (document5 == null)
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[18].Value = (object) document5;
            if (filePath1 == null)
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[19].Value = (object) filePath1;
            if (filePath2 == null)
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[20].Value = (object) filePath2;
            if (filePath3 == null)
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[21].Value = (object) filePath3;
            if (filePath4 == null)
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[22].Value = (object) filePath4;
            if (filePath5 == null)
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[23].Value = (object) filePath5;
            if (directory1 == null)
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[24].Value = (object) directory1;
            if (directory2 == null)
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[25].Value = (object) directory2;
            if (directory3 == null)
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[26].Value = (object) directory3;
            if (asgGrp1 == null)
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[27].Value = (object) asgGrp1;
            if (asgGrp2 == null)
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[28].Value = (object) asgGrp2;
            if (asgGrp3 == null)
                Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[29].Value = (object) asgGrp3;
            if (moveFrom == null)
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[30].Value = (object) moveFrom;
            if (moveTo == null)
                Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[31].Value = (object) moveTo;
            if (timeFrame == null)
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[32].Value = (object) timeFrame;
            if (equipType == null)
                Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[33].Value = (object) equipType;
            if (asset == null)
                Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[34].Value = (object) asset;
            if (serialNum == null)
                Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[35].Value = (object) serialNum;
            if (computerName == null)
                Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[36].Value = (object) computerName;
            if (building == null)
                Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[37].Value = (object) building;
            if (roomNum == null)
                Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[38].Value = (object) roomNum;
            if (frrcComVote == null)
                Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[39].Value = (object) frrcComVote;
            if (frrcFundingStatus == null)
                Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[40].Value = (object) frrcFundingStatus;
            if (frrcAddOn == null)
                Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[41].Value = (object) frrcAddOn;
            if (frrcTimeFrame == null)
                Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[42].Value = (object) frrcTimeFrame;
            if (frrcMeetingDate == null)
                Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[43].Value = (object) frrcMeetingDate;
            if (frrcResponsibility == null)
                Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[44].Value = (object) frrcResponsibility;
            if (circuitId == null)
                Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[45].Value = (object) circuitId;
            if (circuitProvider == null)
                Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[46].Value = (object) circuitProvider;
            if (actionType1 == null)
                Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[47].Value = (object) actionType1;
            if (actionType2 == null)
                Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[48].Value = (object) actionType2;
            if (actionType3 == null)
                Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[49].Value = (object) actionType3;
            if (assignee1 == null)
                Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[50].Value = (object) assignee1;
            if (assignee2 == null)
                Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[51].Value = (object) assignee2;
            if (assignee3 == null)
                Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[52].Value = (object) assignee3;
            if (hwAsset == null)
                Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[53].Value = (object) hwAsset;
            if (hwSerialNum == null)
                Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[54].Value = (object) hwSerialNum;
            if (hwComputerName == null)
                Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[55].Value = (object) hwComputerName;
            if (vendor == null)
                Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[56].Value = (object) vendor;
            if (operatingSystem == null)
                Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[57].Value = (object) operatingSystem;
            if (model == null)
                Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[58].Value = (object) model;
            if (osType == null)
                Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[59].Value = (object) osType;
            if (version == null)
                Adapter.UpdateCommand.Parameters[60].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[60].Value = (object) version;
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.UpdateCommand.Parameters[61].Value = (object) originalCallId;
            if (originalSerialNo == null)
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[63].Value = (object) originalSerialNo;
            }
            if (originalProduct == null)
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[65].Value = (object) originalProduct;
            }
            if (originalSubCallType == null)
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[67].Value = (object) originalSubCallType;
            }
            if (originalProductLine == null)
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[69].Value = (object) originalProductLine;
            }
            if (originalDate1 == null)
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[71].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[71].Value = (object) originalDate1;
            }
            if (originalDate2 == null)
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[73].Value = (object) originalDate2;
            }
            if (originalDate3 == null)
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[75].Value = (object) originalDate3;
            }
            if (originalCode2 == null)
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[77].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[77].Value = (object) originalCode2;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[79].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[79].Value = (object) DBNull.Value;
            }
            if (originalYesNo1 == null)
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[81].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[81].Value = (object) originalYesNo1;
            }
            if (originalYesNo2 == null)
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[83].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[83].Value = (object) originalYesNo2;
            }
            if (originalDocument1 == null)
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[85].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[85].Value = (object) originalDocument1;
            }
            if (originalDocument2 == null)
            {
                Adapter.UpdateCommand.Parameters[86].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[87].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[86].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[87].Value = (object) originalDocument2;
            }
            if (originalDocument3 == null)
            {
                Adapter.UpdateCommand.Parameters[88].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[89].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[88].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[89].Value = (object) originalDocument3;
            }
            if (originalDocument4 == null)
            {
                Adapter.UpdateCommand.Parameters[90].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[91].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[90].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[91].Value = (object) originalDocument4;
            }
            if (originalDocument5 == null)
            {
                Adapter.UpdateCommand.Parameters[92].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[93].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[92].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[93].Value = (object) originalDocument5;
            }
            if (originalFilePath1 == null)
            {
                Adapter.UpdateCommand.Parameters[94].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[95].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[94].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[95].Value = (object) originalFilePath1;
            }
            if (originalFilePath2 == null)
            {
                Adapter.UpdateCommand.Parameters[96].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[97].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[96].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[97].Value = (object) originalFilePath2;
            }
            if (originalFilePath3 == null)
            {
                Adapter.UpdateCommand.Parameters[98].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[99].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[98].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[99].Value = (object) originalFilePath3;
            }
            if (originalFilePath4 == null)
            {
                Adapter.UpdateCommand.Parameters[100].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[101].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[100].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[101].Value = (object) originalFilePath4;
            }
            if (originalFilePath5 == null)
            {
                Adapter.UpdateCommand.Parameters[102].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[103].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[102].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[103].Value = (object) originalFilePath5;
            }
            if (originalDirectory1 == null)
            {
                Adapter.UpdateCommand.Parameters[104].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[105].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[104].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[105].Value = (object) originalDirectory1;
            }
            if (originalDirectory2 == null)
            {
                Adapter.UpdateCommand.Parameters[106].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[107].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[106].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[107].Value = (object) originalDirectory2;
            }
            if (originalDirectory3 == null)
            {
                Adapter.UpdateCommand.Parameters[108].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[109].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[108].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[109].Value = (object) originalDirectory3;
            }
            if (originalAsgGrp1 == null)
            {
                Adapter.UpdateCommand.Parameters[110].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[111].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[110].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[111].Value = (object) originalAsgGrp1;
            }
            if (originalAsgGrp2 == null)
            {
                Adapter.UpdateCommand.Parameters[112].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[113].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[112].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[113].Value = (object) originalAsgGrp2;
            }
            if (originalAsgGrp3 == null)
            {
                Adapter.UpdateCommand.Parameters[114].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[115].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[114].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[115].Value = (object) originalAsgGrp3;
            }
            if (originalMoveFrom == null)
            {
                Adapter.UpdateCommand.Parameters[116].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[117].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[116].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[117].Value = (object) originalMoveFrom;
            }
            if (originalMoveTo == null)
            {
                Adapter.UpdateCommand.Parameters[118].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[119].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[118].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[119].Value = (object) originalMoveTo;
            }
            if (originalTimeFrame == null)
            {
                Adapter.UpdateCommand.Parameters[120].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[121].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[120].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[121].Value = (object) originalTimeFrame;
            }
            if (originalEquipType == null)
            {
                Adapter.UpdateCommand.Parameters[122].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[123].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[122].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[123].Value = (object) originalEquipType;
            }
            if (originalAsset == null)
            {
                Adapter.UpdateCommand.Parameters[124].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[125].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[124].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[125].Value = (object) originalAsset;
            }
            if (originalSerialNum == null)
            {
                Adapter.UpdateCommand.Parameters[126].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[126].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[(int) sbyte.MaxValue].Value = (object) originalSerialNum;
            }
            if (originalComputerName == null)
            {
                Adapter.UpdateCommand.Parameters[128].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[129].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[128].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[129].Value = (object) originalComputerName;
            }
            if (originalBuilding == null)
            {
                Adapter.UpdateCommand.Parameters[130].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[131].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[130].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[131].Value = (object) originalBuilding;
            }
            if (originalRoomNum == null)
            {
                Adapter.UpdateCommand.Parameters[132].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[133].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[132].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[133].Value = (object) originalRoomNum;
            }
            if (originalFrrcComVote == null)
            {
                Adapter.UpdateCommand.Parameters[134].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[135].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[134].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[135].Value = (object) originalFrrcComVote;
            }
            if (originalFrrcFundingStatus == null)
            {
                Adapter.UpdateCommand.Parameters[136].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[137].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[136].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[137].Value = (object) originalFrrcFundingStatus;
            }
            if (originalFrrcAddOn == null)
            {
                Adapter.UpdateCommand.Parameters[138].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[139].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[138].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[139].Value = (object) originalFrrcAddOn;
            }
            if (originalFrrcTimeFrame == null)
            {
                Adapter.UpdateCommand.Parameters[140].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[141].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[140].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[141].Value = (object) originalFrrcTimeFrame;
            }
            if (originalFrrcMeetingDate == null)
            {
                Adapter.UpdateCommand.Parameters[142].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[143].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[142].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[143].Value = (object) originalFrrcMeetingDate;
            }
            if (originalFrrcResponsibility == null)
            {
                Adapter.UpdateCommand.Parameters[144].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[145].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[144].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[145].Value = (object) originalFrrcResponsibility;
            }
            if (originalCircuitId == null)
            {
                Adapter.UpdateCommand.Parameters[146].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[147].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[146].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[147].Value = (object) originalCircuitId;
            }
            if (originalCircuitProvider == null)
            {
                Adapter.UpdateCommand.Parameters[148].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[149].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[148].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[149].Value = (object) originalCircuitProvider;
            }
            if (originalActionType1 == null)
            {
                Adapter.UpdateCommand.Parameters[150].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[151].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[150].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[151].Value = (object) originalActionType1;
            }
            if (originalActionType2 == null)
            {
                Adapter.UpdateCommand.Parameters[152].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[153].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[152].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[153].Value = (object) originalActionType2;
            }
            if (originalActionType3 == null)
            {
                Adapter.UpdateCommand.Parameters[154].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[155].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[154].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[155].Value = (object) originalActionType3;
            }
            if (originalAssignee1 == null)
            {
                Adapter.UpdateCommand.Parameters[156].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[157].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[156].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[157].Value = (object) originalAssignee1;
            }
            if (originalAssignee2 == null)
            {
                Adapter.UpdateCommand.Parameters[158].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[159].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[158].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[159].Value = (object) originalAssignee2;
            }
            if (originalAssignee3 == null)
            {
                Adapter.UpdateCommand.Parameters[160].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[161].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[160].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[161].Value = (object) originalAssignee3;
            }
            if (originalHwAsset == null)
            {
                Adapter.UpdateCommand.Parameters[162].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[163].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[162].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[163].Value = (object) originalHwAsset;
            }
            if (originalHwSerialNum == null)
            {
                Adapter.UpdateCommand.Parameters[164].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[165].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[164].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[165].Value = (object) originalHwSerialNum;
            }
            if (originalHwComputerName == null)
            {
                Adapter.UpdateCommand.Parameters[166].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[167].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[166].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[167].Value = (object) originalHwComputerName;
            }
            if (originalVendor == null)
            {
                Adapter.UpdateCommand.Parameters[168].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[169].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[168].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[169].Value = (object) originalVendor;
            }
            if (originalOperatingSystem == null)
            {
                Adapter.UpdateCommand.Parameters[170].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[171].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[170].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[171].Value = (object) originalOperatingSystem;
            }
            if (originalModel == null)
            {
                Adapter.UpdateCommand.Parameters[172].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[173].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[172].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[173].Value = (object) originalModel;
            }
            if (originalOsType == null)
            {
                Adapter.UpdateCommand.Parameters[174].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[175].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[174].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[175].Value = (object) originalOsType;
            }
            if (originalVersion == null)
            {
                Adapter.UpdateCommand.Parameters[176].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[177].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[176].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[177].Value = (object) originalVersion;
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
        public virtual int Update(string serialNo, string product, string notes, string subCallType, string productLine,
            string date1, string date2, string date3, string code2, int? dtLastMod, string returnReason, string yesNo1,
            string yesNo2, string document1, string document2, string document3, string document4, string document5,
            string filePath1, string filePath2, string filePath3, string filePath4, string filePath5, string directory1,
            string directory2, string directory3, string asgGrp1, string asgGrp2, string asgGrp3, string moveFrom,
            string moveTo, string timeFrame, string equipType, string asset, string serialNum, string computerName,
            string building, string roomNum, string frrcComVote, string frrcFundingStatus, string frrcAddOn,
            string frrcTimeFrame, string frrcMeetingDate, string frrcResponsibility, string circuitId,
            string circuitProvider, string actionType1, string actionType2, string actionType3, string assignee1,
            string assignee2, string assignee3, string hwAsset, string hwSerialNum, string hwComputerName, string vendor,
            string operatingSystem, string model, string osType, string version, string originalCallId,
            string originalSerialNo, string originalProduct, string originalSubCallType, string originalProductLine,
            string originalDate1, string originalDate2, string originalDate3, string originalCode2,
            int? originalDtLastMod, string originalYesNo1, string originalYesNo2, string originalDocument1,
            string originalDocument2, string originalDocument3, string originalDocument4, string originalDocument5,
            string originalFilePath1, string originalFilePath2, string originalFilePath3, string originalFilePath4,
            string originalFilePath5, string originalDirectory1, string originalDirectory2, string originalDirectory3,
            string originalAsgGrp1, string originalAsgGrp2, string originalAsgGrp3, string originalMoveFrom,
            string originalMoveTo, string originalTimeFrame, string originalEquipType, string originalAsset,
            string originalSerialNum, string originalComputerName, string originalBuilding, string originalRoomNum,
            string originalFrrcComVote, string originalFrrcFundingStatus, string originalFrrcAddOn,
            string originalFrrcTimeFrame, string originalFrrcMeetingDate, string originalFrrcResponsibility,
            string originalCircuitId, string originalCircuitProvider, string originalActionType1,
            string originalActionType2, string originalActionType3, string originalAssignee1, string originalAssignee2,
            string originalAssignee3, string originalHwAsset, string originalHwSerialNum, string originalHwComputerName,
            string originalVendor, string originalOperatingSystem, string originalModel, string originalOsType,
            string originalVersion)
        {
            return Update(originalCallId, serialNo, product, notes, subCallType, productLine, date1, date2, date3, code2,
                dtLastMod, returnReason, yesNo1, yesNo2, document1, document2, document3, document4, document5,
                filePath1, filePath2, filePath3, filePath4, filePath5, directory1, directory2, directory3, asgGrp1,
                asgGrp2, asgGrp3, moveFrom, moveTo, timeFrame, equipType, asset, serialNum, computerName, building,
                roomNum, frrcComVote, frrcFundingStatus, frrcAddOn, frrcTimeFrame, frrcMeetingDate, frrcResponsibility,
                circuitId, circuitProvider, actionType1, actionType2, actionType3, assignee1, assignee2, assignee3,
                hwAsset, hwSerialNum, hwComputerName, vendor, operatingSystem, model, osType, version, originalCallId,
                originalSerialNo, originalProduct, originalSubCallType, originalProductLine, originalDate1,
                originalDate2, originalDate3, originalCode2, originalDtLastMod, originalYesNo1, originalYesNo2,
                originalDocument1, originalDocument2, originalDocument3, originalDocument4, originalDocument5,
                originalFilePath1, originalFilePath2, originalFilePath3, originalFilePath4, originalFilePath5,
                originalDirectory1, originalDirectory2, originalDirectory3, originalAsgGrp1, originalAsgGrp2,
                originalAsgGrp3, originalMoveFrom, originalMoveTo, originalTimeFrame, originalEquipType, originalAsset,
                originalSerialNum, originalComputerName, originalBuilding, originalRoomNum, originalFrrcComVote,
                originalFrrcFundingStatus, originalFrrcAddOn, originalFrrcTimeFrame, originalFrrcMeetingDate,
                originalFrrcResponsibility, originalCircuitId, originalCircuitProvider, originalActionType1,
                originalActionType2, originalActionType3, originalAssignee1, originalAssignee2, originalAssignee3,
                originalHwAsset, originalHwSerialNum, originalHwComputerName, originalVendor, originalOperatingSystem,
                originalModel, originalOsType, originalVersion);
        }
    }
}