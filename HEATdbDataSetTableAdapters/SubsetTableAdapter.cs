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
    public class SubsetTableAdapter : Component
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public SubsetTableAdapter()
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
                DataSetTable = "Subset",
                ColumnMappings =
                {
                    {
                        "CustID",
                        "CustID"
                    },
                    {
                        "CallID",
                        "CallID"
                    },
                    {
                        "CustType",
                        "CustType"
                    },
                    {
                        "FirstName",
                        "FirstName"
                    },
                    {
                        "LastName",
                        "LastName"
                    },
                    {
                        "EMailID",
                        "EMailID"
                    },
                    {
                        "LoginID",
                        "LoginID"
                    },
                    {
                        "JobDescription",
                        "JobDescription"
                    },
                    {
                        "RBCustID",
                        "RBCustID"
                    },
                    {
                        "RBLoginID",
                        "RBLoginID"
                    },
                    {
                        "RBFirstName",
                        "RBFirstName"
                    },
                    {
                        "RBLastName",
                        "RBLastName"
                    },
                    {
                        "RBJobDescription",
                        "RBJobDescription"
                    },
                    {
                        "RBEmail",
                        "RBEmail"
                    },
                    {
                        "AssetNum",
                        "AssetNum"
                    },
                    {
                        "SerialNum",
                        "SerialNum"
                    },
                    {
                        "PCName",
                        "PCName"
                    },
                    {
                        "BldgNum",
                        "BldgNum"
                    },
                    {
                        "RoomNum",
                        "RoomNum"
                    },
                    {
                        "RCNumber",
                        "RCNumber"
                    },
                    {
                        "RCRegion",
                        "RCRegion"
                    },
                    {
                        "RCZone",
                        "RCZone"
                    },
                    {
                        "RCName",
                        "RCName"
                    },
                    {
                        "RCPhone",
                        "RCPhone"
                    },
                    {
                        "RCPhoneExt",
                        "RCPhoneExt"
                    },
                    {
                        "OnSiteTechnician",
                        "OnSiteTechnician"
                    },
                    {
                        "Caller",
                        "Caller"
                    },
                    {
                        "Contact",
                        "Contact"
                    },
                    {
                        "DisplayName",
                        "DisplayName"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Subset] WHERE (((@IsNull_CustID = 1 AND [CustID] IS NULL) OR ([CustID] = @Original_CustID)) AND ([CallID] = @Original_CallID) AND ((@IsNull_CustType = 1 AND [CustType] IS NULL) OR ([CustType] = @Original_CustType)) AND ((@IsNull_FirstName = 1 AND [FirstName] IS NULL) OR ([FirstName] = @Original_FirstName)) AND ((@IsNull_LastName = 1 AND [LastName] IS NULL) OR ([LastName] = @Original_LastName)) AND ((@IsNull_EMailID = 1 AND [EMailID] IS NULL) OR ([EMailID] = @Original_EMailID)) AND ((@IsNull_LoginID = 1 AND [LoginID] IS NULL) OR ([LoginID] = @Original_LoginID)) AND ((@IsNull_JobDescription = 1 AND [JobDescription] IS NULL) OR ([JobDescription] = @Original_JobDescription)) AND ((@IsNull_RBCustID = 1 AND [RBCustID] IS NULL) OR ([RBCustID] = @Original_RBCustID)) AND ((@IsNull_RBLoginID = 1 AND [RBLoginID] IS NULL) OR ([RBLoginID] = @Original_RBLoginID)) AND ((@IsNull_RBFirstName = 1 AND [RBFirstName] IS NULL) OR ([RBFirstName] = @Original_RBFirstName)) AND ((@IsNull_RBLastName = 1 AND [RBLastName] IS NULL) OR ([RBLastName] = @Original_RBLastName)) AND ((@IsNull_RBJobDescription = 1 AND [RBJobDescription] IS NULL) OR ([RBJobDescription] = @Original_RBJobDescription)) AND ((@IsNull_RBEmail = 1 AND [RBEmail] IS NULL) OR ([RBEmail] = @Original_RBEmail)) AND ((@IsNull_AssetNum = 1 AND [AssetNum] IS NULL) OR ([AssetNum] = @Original_AssetNum)) AND ((@IsNull_SerialNum = 1 AND [SerialNum] IS NULL) OR ([SerialNum] = @Original_SerialNum)) AND ((@IsNull_PCName = 1 AND [PCName] IS NULL) OR ([PCName] = @Original_PCName)) AND ((@IsNull_BldgNum = 1 AND [BldgNum] IS NULL) OR ([BldgNum] = @Original_BldgNum)) AND ((@IsNull_RoomNum = 1 AND [RoomNum] IS NULL) OR ([RoomNum] = @Original_RoomNum)) AND ((@IsNull_RCNumber = 1 AND [RCNumber] IS NULL) OR ([RCNumber] = @Original_RCNumber)) AND ((@IsNull_RCRegion = 1 AND [RCRegion] IS NULL) OR ([RCRegion] = @Original_RCRegion)) AND ((@IsNull_RCZone = 1 AND [RCZone] IS NULL) OR ([RCZone] = @Original_RCZone)) AND ((@IsNull_RCName = 1 AND [RCName] IS NULL) OR ([RCName] = @Original_RCName)) AND ((@IsNull_RCPhone = 1 AND [RCPhone] IS NULL) OR ([RCPhone] = @Original_RCPhone)) AND ((@IsNull_RCPhoneExt = 1 AND [RCPhoneExt] IS NULL) OR ([RCPhoneExt] = @Original_RCPhoneExt)) AND ((@IsNull_OnSiteTechnician = 1 AND [OnSiteTechnician] IS NULL) OR ([OnSiteTechnician] = @Original_OnSiteTechnician)) AND ((@IsNull_Caller = 1 AND [Caller] IS NULL) OR ([Caller] = @Original_Caller)) AND ((@IsNull_Contact = 1 AND [Contact] IS NULL) OR ([Contact] = @Original_Contact)) AND ((@IsNull_DisplayName = 1 AND [DisplayName] IS NULL) OR ([DisplayName] = @Original_DisplayName)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CustID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CustType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FirstName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LastName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EMailID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_JobDescription", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RBCustID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBCustID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RBCustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBCustID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RBLoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLoginID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RBLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RBFirstName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBFirstName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RBFirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBFirstName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RBLastName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLastName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RBLastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLastName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RBJobDescription", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBJobDescription", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RBJobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBJobDescription", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RBEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RBEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AssetNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AssetNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SerialNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_PCName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PCName", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_PCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PCName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_BldgNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_BldgNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RoomNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCRegion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCRegion", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCRegion", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCZone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCPhone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCPhoneExt", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhoneExt", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhoneExt", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OnSiteTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Caller", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Caller", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Caller", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Caller", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Contact", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Contact", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Contact", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Contact", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DisplayName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Subset] ([CustID], [CallID], [CustType], [FirstName], [LastName], [EMailID], [LoginID], [JobDescription], [RBCustID], [RBLoginID], [RBFirstName], [RBLastName], [RBJobDescription], [RBEmail], [AssetNum], [SerialNum], [PCName], [BldgNum], [RoomNum], [RCNumber], [RCRegion], [RCZone], [RCName], [RCPhone], [RCPhoneExt], [OnSiteTechnician], [Caller], [Contact], [DisplayName]) VALUES (@CustID, @CallID, @CustType, @FirstName, @LastName, @EMailID, @LoginID, @JobDescription, @RBCustID, @RBLoginID, @RBFirstName, @RBLastName, @RBJobDescription, @RBEmail, @AssetNum, @SerialNum, @PCName, @BldgNum, @RoomNum, @RCNumber, @RCRegion, @RCZone, @RCName, @RCPhone, @RCPhoneExt, @OnSiteTechnician, @Caller, @Contact, @DisplayName);\r\nSELECT CustID, CallID, CustType, FirstName, LastName, EMailID, LoginID, JobDescription, RBCustID, RBLoginID, RBFirstName, RBLastName, RBJobDescription, RBEmail, AssetNum, SerialNum, PCName, BldgNum, RoomNum, RCNumber, RCRegion, RCZone, RCName, RCPhone, RCPhoneExt, OnSiteTechnician, Caller, Contact, DisplayName FROM Subset WHERE (CallID = @CallID)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RBCustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBCustID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RBLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RBFirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBFirstName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RBLastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLastName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RBJobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBJobDescription", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RBEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AssetNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@PCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PCName", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@BldgNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCRegion", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhoneExt", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Caller", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Caller", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Contact", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Contact", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Subset] SET [CustID] = @CustID, [CallID] = @CallID, [CustType] = @CustType, [FirstName] = @FirstName, [LastName] = @LastName, [EMailID] = @EMailID, [LoginID] = @LoginID, [JobDescription] = @JobDescription, [RBCustID] = @RBCustID, [RBLoginID] = @RBLoginID, [RBFirstName] = @RBFirstName, [RBLastName] = @RBLastName, [RBJobDescription] = @RBJobDescription, [RBEmail] = @RBEmail, [AssetNum] = @AssetNum, [SerialNum] = @SerialNum, [PCName] = @PCName, [BldgNum] = @BldgNum, [RoomNum] = @RoomNum, [RCNumber] = @RCNumber, [RCRegion] = @RCRegion, [RCZone] = @RCZone, [RCName] = @RCName, [RCPhone] = @RCPhone, [RCPhoneExt] = @RCPhoneExt, [OnSiteTechnician] = @OnSiteTechnician, [Caller] = @Caller, [Contact] = @Contact, [DisplayName] = @DisplayName WHERE (((@IsNull_CustID = 1 AND [CustID] IS NULL) OR ([CustID] = @Original_CustID)) AND ([CallID] = @Original_CallID) AND ((@IsNull_CustType = 1 AND [CustType] IS NULL) OR ([CustType] = @Original_CustType)) AND ((@IsNull_FirstName = 1 AND [FirstName] IS NULL) OR ([FirstName] = @Original_FirstName)) AND ((@IsNull_LastName = 1 AND [LastName] IS NULL) OR ([LastName] = @Original_LastName)) AND ((@IsNull_EMailID = 1 AND [EMailID] IS NULL) OR ([EMailID] = @Original_EMailID)) AND ((@IsNull_LoginID = 1 AND [LoginID] IS NULL) OR ([LoginID] = @Original_LoginID)) AND ((@IsNull_JobDescription = 1 AND [JobDescription] IS NULL) OR ([JobDescription] = @Original_JobDescription)) AND ((@IsNull_RBCustID = 1 AND [RBCustID] IS NULL) OR ([RBCustID] = @Original_RBCustID)) AND ((@IsNull_RBLoginID = 1 AND [RBLoginID] IS NULL) OR ([RBLoginID] = @Original_RBLoginID)) AND ((@IsNull_RBFirstName = 1 AND [RBFirstName] IS NULL) OR ([RBFirstName] = @Original_RBFirstName)) AND ((@IsNull_RBLastName = 1 AND [RBLastName] IS NULL) OR ([RBLastName] = @Original_RBLastName)) AND ((@IsNull_RBJobDescription = 1 AND [RBJobDescription] IS NULL) OR ([RBJobDescription] = @Original_RBJobDescription)) AND ((@IsNull_RBEmail = 1 AND [RBEmail] IS NULL) OR ([RBEmail] = @Original_RBEmail)) AND ((@IsNull_AssetNum = 1 AND [AssetNum] IS NULL) OR ([AssetNum] = @Original_AssetNum)) AND ((@IsNull_SerialNum = 1 AND [SerialNum] IS NULL) OR ([SerialNum] = @Original_SerialNum)) AND ((@IsNull_PCName = 1 AND [PCName] IS NULL) OR ([PCName] = @Original_PCName)) AND ((@IsNull_BldgNum = 1 AND [BldgNum] IS NULL) OR ([BldgNum] = @Original_BldgNum)) AND ((@IsNull_RoomNum = 1 AND [RoomNum] IS NULL) OR ([RoomNum] = @Original_RoomNum)) AND ((@IsNull_RCNumber = 1 AND [RCNumber] IS NULL) OR ([RCNumber] = @Original_RCNumber)) AND ((@IsNull_RCRegion = 1 AND [RCRegion] IS NULL) OR ([RCRegion] = @Original_RCRegion)) AND ((@IsNull_RCZone = 1 AND [RCZone] IS NULL) OR ([RCZone] = @Original_RCZone)) AND ((@IsNull_RCName = 1 AND [RCName] IS NULL) OR ([RCName] = @Original_RCName)) AND ((@IsNull_RCPhone = 1 AND [RCPhone] IS NULL) OR ([RCPhone] = @Original_RCPhone)) AND ((@IsNull_RCPhoneExt = 1 AND [RCPhoneExt] IS NULL) OR ([RCPhoneExt] = @Original_RCPhoneExt)) AND ((@IsNull_OnSiteTechnician = 1 AND [OnSiteTechnician] IS NULL) OR ([OnSiteTechnician] = @Original_OnSiteTechnician)) AND ((@IsNull_Caller = 1 AND [Caller] IS NULL) OR ([Caller] = @Original_Caller)) AND ((@IsNull_Contact = 1 AND [Contact] IS NULL) OR ([Contact] = @Original_Contact)) AND ((@IsNull_DisplayName = 1 AND [DisplayName] IS NULL) OR ([DisplayName] = @Original_DisplayName)));\r\nSELECT CustID, CallID, CustType, FirstName, LastName, EMailID, LoginID, JobDescription, RBCustID, RBLoginID, RBFirstName, RBLastName, RBJobDescription, RBEmail, AssetNum, SerialNum, PCName, BldgNum, RoomNum, RCNumber, RCRegion, RCZone, RCName, RCPhone, RCPhoneExt, OnSiteTechnician, Caller, Contact, DisplayName FROM Subset WHERE (CallID = @CallID)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RBCustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBCustID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RBLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLoginID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RBFirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBFirstName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RBLastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLastName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RBJobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBJobDescription", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RBEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBEmail", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AssetNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PCName", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@BldgNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCRegion", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhoneExt", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Caller", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Caller", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Contact", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Contact", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CustID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CustType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CustType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustType", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FirstName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LastName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LastName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EMailID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_JobDescription", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RBCustID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBCustID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RBCustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBCustID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RBLoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLoginID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RBLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLoginID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RBFirstName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBFirstName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RBFirstName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBFirstName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RBLastName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLastName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RBLastName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBLastName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RBJobDescription", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBJobDescription", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RBJobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBJobDescription", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RBEmail", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBEmail", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RBEmail", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RBEmail", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AssetNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AssetNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AssetNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SerialNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SerialNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SerialNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_PCName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PCName", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_PCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PCName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_BldgNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_BldgNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "BldgNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RoomNum", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RoomNum", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNum", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCRegion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCRegion", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCRegion", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCZone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCPhone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCPhoneExt", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhoneExt", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhoneExt", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OnSiteTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Caller", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Caller", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Caller", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Caller", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Contact", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Contact", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Contact", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Contact", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DisplayName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
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
                "SELECT CustID, CallID, CustType, FirstName, LastName, EMailID, LoginID, JobDescription, RBCustID, RBLoginID, RBFirstName, RBLastName, RBJobDescription, RBEmail, AssetNum, SerialNum, PCName, BldgNum, RoomNum, RCNumber, RCRegion, RCZone, RCName, RCPhone, RCPhoneExt, OnSiteTechnician, Caller, Contact, DisplayName FROM dbo.Subset";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        public virtual int Fill(HeaTdbDataSet.SubsetDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual HeaTdbDataSet.SubsetDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.SubsetDataTable subsetDataTable = new HeaTdbDataSet.SubsetDataTable();
            Adapter.Fill((DataTable) subsetDataTable);
            return subsetDataTable;
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.SubsetDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Subset");
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public virtual int Update(DataRow dataRow)
        {
            return Adapter.Update(new DataRow[1] {dataRow});
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return Adapter.Update(dataRows);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(string originalCustId, string originalCallId, string originalCustType,
            string originalFirstName, string originalLastName, string originalEMailId, string originalLoginId,
            string originalJobDescription, string originalRbCustId, string originalRbLoginId, string originalRbFirstName,
            string originalRbLastName, string originalRbJobDescription, string originalRbEmail, string originalAssetNum,
            string originalSerialNum, string originalPcName, string originalBldgNum, string originalRoomNum,
            string originalRcNumber, string originalRcRegion, string originalRcZone, string originalRcName,
            string originalRcPhone, string originalRcPhoneExt, string originalOnSiteTechnician, string originalCaller,
            string originalContact, string originalDisplayName)
        {
            if (originalCustId == null)
            {
                Adapter.DeleteCommand.Parameters[0].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[1].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[0].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[1].Value = (object) originalCustId;
            }
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.DeleteCommand.Parameters[2].Value = (object) originalCallId;
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
            if (originalFirstName == null)
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[6].Value = (object) originalFirstName;
            }
            if (originalLastName == null)
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[8].Value = (object) originalLastName;
            }
            if (originalEMailId == null)
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[10].Value = (object) originalEMailId;
            }
            if (originalLoginId == null)
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[12].Value = (object) originalLoginId;
            }
            if (originalJobDescription == null)
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[14].Value = (object) originalJobDescription;
            }
            if (originalRbCustId == null)
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[16].Value = (object) originalRbCustId;
            }
            if (originalRbLoginId == null)
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[18].Value = (object) originalRbLoginId;
            }
            if (originalRbFirstName == null)
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[20].Value = (object) originalRbFirstName;
            }
            if (originalRbLastName == null)
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[22].Value = (object) originalRbLastName;
            }
            if (originalRbJobDescription == null)
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[24].Value = (object) originalRbJobDescription;
            }
            if (originalRbEmail == null)
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[26].Value = (object) originalRbEmail;
            }
            if (originalAssetNum == null)
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[28].Value = (object) originalAssetNum;
            }
            if (originalSerialNum == null)
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[30].Value = (object) originalSerialNum;
            }
            if (originalPcName == null)
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[32].Value = (object) originalPcName;
            }
            if (originalBldgNum == null)
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[34].Value = (object) originalBldgNum;
            }
            if (originalRoomNum == null)
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[36].Value = (object) originalRoomNum;
            }
            if (originalRcNumber == null)
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[38].Value = (object) originalRcNumber;
            }
            if (originalRcRegion == null)
            {
                Adapter.DeleteCommand.Parameters[39].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[40].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[39].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[40].Value = (object) originalRcRegion;
            }
            if (originalRcZone == null)
            {
                Adapter.DeleteCommand.Parameters[41].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[42].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[41].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[42].Value = (object) originalRcZone;
            }
            if (originalRcName == null)
            {
                Adapter.DeleteCommand.Parameters[43].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[44].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[43].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[44].Value = (object) originalRcName;
            }
            if (originalRcPhone == null)
            {
                Adapter.DeleteCommand.Parameters[45].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[46].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[45].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[46].Value = (object) originalRcPhone;
            }
            if (originalRcPhoneExt == null)
            {
                Adapter.DeleteCommand.Parameters[47].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[48].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[47].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[48].Value = (object) originalRcPhoneExt;
            }
            if (originalOnSiteTechnician == null)
            {
                Adapter.DeleteCommand.Parameters[49].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[50].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[49].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[50].Value = (object) originalOnSiteTechnician;
            }
            if (originalCaller == null)
            {
                Adapter.DeleteCommand.Parameters[51].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[52].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[51].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[52].Value = (object) originalCaller;
            }
            if (originalContact == null)
            {
                Adapter.DeleteCommand.Parameters[53].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[54].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[53].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[54].Value = (object) originalContact;
            }
            if (originalDisplayName == null)
            {
                Adapter.DeleteCommand.Parameters[55].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[56].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[55].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[56].Value = (object) originalDisplayName;
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

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(string custId, string callId, string custType, string firstName, string lastName,
            string eMailId, string loginId, string jobDescription, string rbCustId, string rbLoginId, string rbFirstName,
            string rbLastName, string rbJobDescription, string rbEmail, string assetNum, string serialNum, string pcName,
            string bldgNum, string roomNum, string rcNumber, string rcRegion, string rcZone, string rcName,
            string rcPhone, string rcPhoneExt, string onSiteTechnician, string caller, string contact,
            string displayName)
        {
            if (custId == null)
                Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[0].Value = (object) custId;
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.InsertCommand.Parameters[1].Value = (object) callId;
            if (custType == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) custType;
            if (firstName == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) firstName;
            if (lastName == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) lastName;
            if (eMailId == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) eMailId;
            if (loginId == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) loginId;
            if (jobDescription == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) jobDescription;
            if (rbCustId == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) rbCustId;
            if (rbLoginId == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) rbLoginId;
            if (rbFirstName == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) rbFirstName;
            if (rbLastName == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) rbLastName;
            if (rbJobDescription == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) rbJobDescription;
            if (rbEmail == null)
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) rbEmail;
            if (assetNum == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) assetNum;
            if (serialNum == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) serialNum;
            if (pcName == null)
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) pcName;
            if (bldgNum == null)
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) bldgNum;
            if (roomNum == null)
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) roomNum;
            if (rcNumber == null)
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) rcNumber;
            if (rcRegion == null)
                Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[20].Value = (object) rcRegion;
            if (rcZone == null)
                Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[21].Value = (object) rcZone;
            if (rcName == null)
                Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[22].Value = (object) rcName;
            if (rcPhone == null)
                Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[23].Value = (object) rcPhone;
            if (rcPhoneExt == null)
                Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[24].Value = (object) rcPhoneExt;
            if (onSiteTechnician == null)
                Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[25].Value = (object) onSiteTechnician;
            if (caller == null)
                Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[26].Value = (object) caller;
            if (contact == null)
                Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[27].Value = (object) contact;
            if (displayName == null)
                Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[28].Value = (object) displayName;
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
        public virtual int Update(string custId, string callId, string custType, string firstName, string lastName,
            string eMailId, string loginId, string jobDescription, string rbCustId, string rbLoginId, string rbFirstName,
            string rbLastName, string rbJobDescription, string rbEmail, string assetNum, string serialNum, string pcName,
            string bldgNum, string roomNum, string rcNumber, string rcRegion, string rcZone, string rcName,
            string rcPhone, string rcPhoneExt, string onSiteTechnician, string caller, string contact,
            string displayName, string originalCustId, string originalCallId, string originalCustType,
            string originalFirstName, string originalLastName, string originalEMailId, string originalLoginId,
            string originalJobDescription, string originalRbCustId, string originalRbLoginId, string originalRbFirstName,
            string originalRbLastName, string originalRbJobDescription, string originalRbEmail, string originalAssetNum,
            string originalSerialNum, string originalPcName, string originalBldgNum, string originalRoomNum,
            string originalRcNumber, string originalRcRegion, string originalRcZone, string originalRcName,
            string originalRcPhone, string originalRcPhoneExt, string originalOnSiteTechnician, string originalCaller,
            string originalContact, string originalDisplayName)
        {
            if (custId == null)
                Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[0].Value = (object) custId;
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.UpdateCommand.Parameters[1].Value = (object) callId;
            if (custType == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) custType;
            if (firstName == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) firstName;
            if (lastName == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) lastName;
            if (eMailId == null)
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) eMailId;
            if (loginId == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) loginId;
            if (jobDescription == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) jobDescription;
            if (rbCustId == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) rbCustId;
            if (rbLoginId == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) rbLoginId;
            if (rbFirstName == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) rbFirstName;
            if (rbLastName == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) rbLastName;
            if (rbJobDescription == null)
                Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[12].Value = (object) rbJobDescription;
            if (rbEmail == null)
                Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[13].Value = (object) rbEmail;
            if (assetNum == null)
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[14].Value = (object) assetNum;
            if (serialNum == null)
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[15].Value = (object) serialNum;
            if (pcName == null)
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[16].Value = (object) pcName;
            if (bldgNum == null)
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[17].Value = (object) bldgNum;
            if (roomNum == null)
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[18].Value = (object) roomNum;
            if (rcNumber == null)
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[19].Value = (object) rcNumber;
            if (rcRegion == null)
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[20].Value = (object) rcRegion;
            if (rcZone == null)
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[21].Value = (object) rcZone;
            if (rcName == null)
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[22].Value = (object) rcName;
            if (rcPhone == null)
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[23].Value = (object) rcPhone;
            if (rcPhoneExt == null)
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[24].Value = (object) rcPhoneExt;
            if (onSiteTechnician == null)
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[25].Value = (object) onSiteTechnician;
            if (caller == null)
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[26].Value = (object) caller;
            if (contact == null)
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[27].Value = (object) contact;
            if (displayName == null)
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[28].Value = (object) displayName;
            if (originalCustId == null)
            {
                Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[30].Value = (object) originalCustId;
            }
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.UpdateCommand.Parameters[31].Value = (object) originalCallId;
            if (originalCustType == null)
            {
                Adapter.UpdateCommand.Parameters[32].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[32].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[33].Value = (object) originalCustType;
            }
            if (originalFirstName == null)
            {
                Adapter.UpdateCommand.Parameters[34].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[34].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[35].Value = (object) originalFirstName;
            }
            if (originalLastName == null)
            {
                Adapter.UpdateCommand.Parameters[36].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[36].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[37].Value = (object) originalLastName;
            }
            if (originalEMailId == null)
            {
                Adapter.UpdateCommand.Parameters[38].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[38].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[39].Value = (object) originalEMailId;
            }
            if (originalLoginId == null)
            {
                Adapter.UpdateCommand.Parameters[40].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[40].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[41].Value = (object) originalLoginId;
            }
            if (originalJobDescription == null)
            {
                Adapter.UpdateCommand.Parameters[42].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[42].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[43].Value = (object) originalJobDescription;
            }
            if (originalRbCustId == null)
            {
                Adapter.UpdateCommand.Parameters[44].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[44].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[45].Value = (object) originalRbCustId;
            }
            if (originalRbLoginId == null)
            {
                Adapter.UpdateCommand.Parameters[46].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[47].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[46].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[47].Value = (object) originalRbLoginId;
            }
            if (originalRbFirstName == null)
            {
                Adapter.UpdateCommand.Parameters[48].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[48].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[49].Value = (object) originalRbFirstName;
            }
            if (originalRbLastName == null)
            {
                Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[51].Value = (object) originalRbLastName;
            }
            if (originalRbJobDescription == null)
            {
                Adapter.UpdateCommand.Parameters[52].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[52].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[53].Value = (object) originalRbJobDescription;
            }
            if (originalRbEmail == null)
            {
                Adapter.UpdateCommand.Parameters[54].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[54].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[55].Value = (object) originalRbEmail;
            }
            if (originalAssetNum == null)
            {
                Adapter.UpdateCommand.Parameters[56].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[56].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[57].Value = (object) originalAssetNum;
            }
            if (originalSerialNum == null)
            {
                Adapter.UpdateCommand.Parameters[58].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[58].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[59].Value = (object) originalSerialNum;
            }
            if (originalPcName == null)
            {
                Adapter.UpdateCommand.Parameters[60].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[60].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[61].Value = (object) originalPcName;
            }
            if (originalBldgNum == null)
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[63].Value = (object) originalBldgNum;
            }
            if (originalRoomNum == null)
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[65].Value = (object) originalRoomNum;
            }
            if (originalRcNumber == null)
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[67].Value = (object) originalRcNumber;
            }
            if (originalRcRegion == null)
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[69].Value = (object) originalRcRegion;
            }
            if (originalRcZone == null)
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[71].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[71].Value = (object) originalRcZone;
            }
            if (originalRcName == null)
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[73].Value = (object) originalRcName;
            }
            if (originalRcPhone == null)
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[75].Value = (object) originalRcPhone;
            }
            if (originalRcPhoneExt == null)
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[77].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[77].Value = (object) originalRcPhoneExt;
            }
            if (originalOnSiteTechnician == null)
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[79].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[79].Value = (object) originalOnSiteTechnician;
            }
            if (originalCaller == null)
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[81].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[81].Value = (object) originalCaller;
            }
            if (originalContact == null)
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[83].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[83].Value = (object) originalContact;
            }
            if (originalDisplayName == null)
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[85].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[85].Value = (object) originalDisplayName;
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
        public virtual int Update(string custId, string custType, string firstName, string lastName, string eMailId,
            string loginId, string jobDescription, string rbCustId, string rbLoginId, string rbFirstName,
            string rbLastName, string rbJobDescription, string rbEmail, string assetNum, string serialNum, string pcName,
            string bldgNum, string roomNum, string rcNumber, string rcRegion, string rcZone, string rcName,
            string rcPhone, string rcPhoneExt, string onSiteTechnician, string caller, string contact,
            string displayName, string originalCustId, string originalCallId, string originalCustType,
            string originalFirstName, string originalLastName, string originalEMailId, string originalLoginId,
            string originalJobDescription, string originalRbCustId, string originalRbLoginId, string originalRbFirstName,
            string originalRbLastName, string originalRbJobDescription, string originalRbEmail, string originalAssetNum,
            string originalSerialNum, string originalPcName, string originalBldgNum, string originalRoomNum,
            string originalRcNumber, string originalRcRegion, string originalRcZone, string originalRcName,
            string originalRcPhone, string originalRcPhoneExt, string originalOnSiteTechnician, string originalCaller,
            string originalContact, string originalDisplayName)
        {
            return Update(custId, originalCallId, custType, firstName, lastName, eMailId, loginId, jobDescription,
                rbCustId, rbLoginId, rbFirstName, rbLastName, rbJobDescription, rbEmail, assetNum, serialNum, pcName,
                bldgNum, roomNum, rcNumber, rcRegion, rcZone, rcName, rcPhone, rcPhoneExt, onSiteTechnician, caller,
                contact, displayName, originalCustId, originalCallId, originalCustType, originalFirstName,
                originalLastName, originalEMailId, originalLoginId, originalJobDescription, originalRbCustId,
                originalRbLoginId, originalRbFirstName, originalRbLastName, originalRbJobDescription, originalRbEmail,
                originalAssetNum, originalSerialNum, originalPcName, originalBldgNum, originalRoomNum, originalRcNumber,
                originalRcRegion, originalRcZone, originalRcName, originalRcPhone, originalRcPhoneExt,
                originalOnSiteTechnician, originalCaller, originalContact, originalDisplayName);
        }
    }
}