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
    public class ProfileTableAdapter : Component
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProfileTableAdapter()
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
                DataSetTable = "Profile",
                ColumnMappings =
                {
                    {
                        "CustID",
                        "CustID"
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
                        "Title",
                        "Title"
                    },
                    {
                        "EMailID",
                        "EMailID"
                    },
                    {
                        "Notes",
                        "Notes"
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
                        "SLAClass",
                        "SLAClass"
                    },
                    {
                        "DTLastMod",
                        "DTLastMod"
                    },
                    {
                        "MiddleName",
                        "MiddleName"
                    },
                    {
                        "NetworkLoginID",
                        "NetworkLoginID"
                    },
                    {
                        "DateTimeAUP",
                        "DateTimeAUP"
                    },
                    {
                        "DateTimeMailbox",
                        "DateTimeMailbox"
                    },
                    {
                        "DateTimeLogged",
                        "DateTimeLogged"
                    },
                    {
                        "AuthorizedMailbox",
                        "AuthorizedMailbox"
                    },
                    {
                        "JobCode",
                        "JobCode"
                    },
                    {
                        "JobDescription",
                        "JobDescription"
                    },
                    {
                        "ADSLDAPPath",
                        "ADSLDAPPath"
                    },
                    {
                        "ADSHomeDirectory",
                        "ADSHomeDirectory"
                    },
                    {
                        "ADSProfilePath",
                        "ADSProfilePath"
                    },
                    {
                        "ADSScriptPath",
                        "ADSScriptPath"
                    },
                    {
                        "ADSSIFREFID",
                        "ADSSIFREFID"
                    },
                    {
                        "RCNumber",
                        "RCNumber"
                    },
                    {
                        "Region",
                        "Region"
                    },
                    {
                        "RCName",
                        "RCName"
                    },
                    {
                        "RCAddress1",
                        "RCAddress1"
                    },
                    {
                        "RCCity",
                        "RCCity"
                    },
                    {
                        "RCState",
                        "RCState"
                    },
                    {
                        "RCZipCode",
                        "RCZipCode"
                    },
                    {
                        "RCPhone",
                        "RCPhone"
                    },
                    {
                        "RCFax",
                        "RCFax"
                    },
                    {
                        "CompanyName",
                        "CompanyName"
                    },
                    {
                        "CompanyRegion",
                        "CompanyRegion"
                    },
                    {
                        "CompanyPhone",
                        "CompanyPhone"
                    },
                    {
                        "CompanyFax",
                        "CompanyFax"
                    },
                    {
                        "ProfileType",
                        "ProfileType"
                    },
                    {
                        "RCZone",
                        "RCZone"
                    },
                    {
                        "DisplayName",
                        "DisplayName"
                    },
                    {
                        "uDomain",
                        "uDomain"
                    },
                    {
                        "CompanyPhoneExt",
                        "CompanyPhoneExt"
                    },
                    {
                        "CompanyCity",
                        "CompanyCity"
                    },
                    {
                        "CompanyState",
                        "CompanyState"
                    },
                    {
                        "CompanyZip",
                        "CompanyZip"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Profile] WHERE (([CustID] = @Original_CustID) AND ([CustType] = @Original_CustType) AND ((@IsNull_FirstName = 1 AND [FirstName] IS NULL) OR ([FirstName] = @Original_FirstName)) AND ((@IsNull_LastName = 1 AND [LastName] IS NULL) OR ([LastName] = @Original_LastName)) AND ((@IsNull_Title = 1 AND [Title] IS NULL) OR ([Title] = @Original_Title)) AND ((@IsNull_EMailID = 1 AND [EMailID] IS NULL) OR ([EMailID] = @Original_EMailID)) AND ((@IsNull_ModBy = 1 AND [ModBy] IS NULL) OR ([ModBy] = @Original_ModBy)) AND ((@IsNull_ModDate = 1 AND [ModDate] IS NULL) OR ([ModDate] = @Original_ModDate)) AND ((@IsNull_ModTime = 1 AND [ModTime] IS NULL) OR ([ModTime] = @Original_ModTime)) AND ((@IsNull_SLAClass = 1 AND [SLAClass] IS NULL) OR ([SLAClass] = @Original_SLAClass)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_MiddleName = 1 AND [MiddleName] IS NULL) OR ([MiddleName] = @Original_MiddleName)) AND ((@IsNull_NetworkLoginID = 1 AND [NetworkLoginID] IS NULL) OR ([NetworkLoginID] = @Original_NetworkLoginID)) AND ((@IsNull_DateTimeAUP = 1 AND [DateTimeAUP] IS NULL) OR ([DateTimeAUP] = @Original_DateTimeAUP)) AND ((@IsNull_DateTimeMailbox = 1 AND [DateTimeMailbox] IS NULL) OR ([DateTimeMailbox] = @Original_DateTimeMailbox)) AND ((@IsNull_DateTimeLogged = 1 AND [DateTimeLogged] IS NULL) OR ([DateTimeLogged] = @Original_DateTimeLogged)) AND ((@IsNull_AuthorizedMailbox = 1 AND [AuthorizedMailbox] IS NULL) OR ([AuthorizedMailbox] = @Original_AuthorizedMailbox)) AND ((@IsNull_JobCode = 1 AND [JobCode] IS NULL) OR ([JobCode] = @Original_JobCode)) AND ((@IsNull_JobDescription = 1 AND [JobDescription] IS NULL) OR ([JobDescription] = @Original_JobDescription)) AND ((@IsNull_ADSSIFREFID = 1 AND [ADSSIFREFID] IS NULL) OR ([ADSSIFREFID] = @Original_ADSSIFREFID)) AND ((@IsNull_RCNumber = 1 AND [RCNumber] IS NULL) OR ([RCNumber] = @Original_RCNumber)) AND ((@IsNull_Region = 1 AND [Region] IS NULL) OR ([Region] = @Original_Region)) AND ((@IsNull_RCName = 1 AND [RCName] IS NULL) OR ([RCName] = @Original_RCName)) AND ((@IsNull_RCAddress1 = 1 AND [RCAddress1] IS NULL) OR ([RCAddress1] = @Original_RCAddress1)) AND ((@IsNull_RCCity = 1 AND [RCCity] IS NULL) OR ([RCCity] = @Original_RCCity)) AND ((@IsNull_RCState = 1 AND [RCState] IS NULL) OR ([RCState] = @Original_RCState)) AND ((@IsNull_RCZipCode = 1 AND [RCZipCode] IS NULL) OR ([RCZipCode] = @Original_RCZipCode)) AND ((@IsNull_RCPhone = 1 AND [RCPhone] IS NULL) OR ([RCPhone] = @Original_RCPhone)) AND ((@IsNull_RCFax = 1 AND [RCFax] IS NULL) OR ([RCFax] = @Original_RCFax)) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_CompanyRegion = 1 AND [CompanyRegion] IS NULL) OR ([CompanyRegion] = @Original_CompanyRegion)) AND ((@IsNull_CompanyPhone = 1 AND [CompanyPhone] IS NULL) OR ([CompanyPhone] = @Original_CompanyPhone)) AND ((@IsNull_CompanyFax = 1 AND [CompanyFax] IS NULL) OR ([CompanyFax] = @Original_CompanyFax)) AND ((@IsNull_ProfileType = 1 AND [ProfileType] IS NULL) OR ([ProfileType] = @Original_ProfileType)) AND ((@IsNull_RCZone = 1 AND [RCZone] IS NULL) OR ([RCZone] = @Original_RCZone)) AND ((@IsNull_DisplayName = 1 AND [DisplayName] IS NULL) OR ([DisplayName] = @Original_DisplayName)) AND ((@IsNull_uDomain = 1 AND [uDomain] IS NULL) OR ([uDomain] = @Original_uDomain)) AND ((@IsNull_CompanyPhoneExt = 1 AND [CompanyPhoneExt] IS NULL) OR ([CompanyPhoneExt] = @Original_CompanyPhoneExt)) AND ((@IsNull_CompanyCity = 1 AND [CompanyCity] IS NULL) OR ([CompanyCity] = @Original_CompanyCity)) AND ((@IsNull_CompanyState = 1 AND [CompanyState] IS NULL) OR ([CompanyState] = @Original_CompanyState)) AND ((@IsNull_CompanyZip = 1 AND [CompanyZip] IS NULL) OR ([CompanyZip] = @Original_CompanyZip)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, false, (object) null,
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
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Title", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Title", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EMailID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, false, (object) null,
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
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SLAClass", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAClass", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SLAClass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAClass", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_MiddleName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MiddleName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MiddleName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MiddleName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_NetworkLoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "NetworkLoginID", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_NetworkLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "NetworkLoginID", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DateTimeAUP", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeAUP", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DateTimeAUP", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeAUP", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DateTimeMailbox", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeMailbox", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DateTimeMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeMailbox", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DateTimeLogged", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeLogged", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DateTimeLogged", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeLogged", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AuthorizedMailbox", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AuthorizedMailbox", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AuthorizedMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AuthorizedMailbox", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_JobCode", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobCode", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_JobCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobCode", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_JobDescription", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ADSSIFREFID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSSIFREFID", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ADSSIFREFID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSSIFREFID", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Region", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Region", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCAddress1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCAddress1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCAddress1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCAddress1", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCCity", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCCity", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCCity", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCState", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCState", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCState", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCZipCode", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZipCode", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZipCode", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCPhone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCFax", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCFax", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCFax", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyRegion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyRegion", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyRegion", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyPhone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhone", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhone", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyFax", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyFax", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyFax", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ProfileType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProfileType", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ProfileType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProfileType", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RCZone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DisplayName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_uDomain", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "uDomain", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_uDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "uDomain", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyPhoneExt", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhoneExt", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhoneExt", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyCity", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyCity", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyCity", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyState", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyState", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyState", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyZip", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyZip", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CompanyZip", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyZip", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Profile] ([CustID], [CustType], [FirstName], [LastName], [Title], [EMailID], [Notes], [ModBy], [ModDate], [ModTime], [SLAClass], [DTLastMod], [MiddleName], [NetworkLoginID], [DateTimeAUP], [DateTimeMailbox], [DateTimeLogged], [AuthorizedMailbox], [JobCode], [JobDescription], [ADSLDAPPath], [ADSHomeDirectory], [ADSProfilePath], [ADSScriptPath], [ADSSIFREFID], [RCNumber], [Region], [RCName], [RCAddress1], [RCCity], [RCState], [RCZipCode], [RCPhone], [RCFax], [CompanyName], [CompanyRegion], [CompanyPhone], [CompanyFax], [ProfileType], [RCZone], [DisplayName], [uDomain], [CompanyPhoneExt], [CompanyCity], [CompanyState], [CompanyZip]) VALUES (@CustID, @CustType, @FirstName, @LastName, @Title, @EMailID, @Notes, @ModBy, @ModDate, @ModTime, @SLAClass, @DTLastMod, @MiddleName, @NetworkLoginID, @DateTimeAUP, @DateTimeMailbox, @DateTimeLogged, @AuthorizedMailbox, @JobCode, @JobDescription, @ADSLDAPPath, @ADSHomeDirectory, @ADSProfilePath, @ADSScriptPath, @ADSSIFREFID, @RCNumber, @Region, @RCName, @RCAddress1, @RCCity, @RCState, @RCZipCode, @RCPhone, @RCFax, @CompanyName, @CompanyRegion, @CompanyPhone, @CompanyFax, @ProfileType, @RCZone, @DisplayName, @uDomain, @CompanyPhoneExt, @CompanyCity, @CompanyState, @CompanyZip);\r\nSELECT CustID, CustType, FirstName, LastName, Title, EMailID, Notes, ModBy, ModDate, ModTime, SLAClass, DTLastMod, MiddleName, NetworkLoginID, DateTimeAUP, DateTimeMailbox, DateTimeLogged, AuthorizedMailbox, JobCode, JobDescription, ADSLDAPPath, ADSHomeDirectory, ADSProfilePath, ADSScriptPath, ADSSIFREFID, RCNumber, Region, RCName, RCAddress1, RCCity, RCState, RCZipCode, RCPhone, RCFax, CompanyName, CompanyRegion, CompanyPhone, CompanyFax, ProfileType, RCZone, DisplayName, uDomain, CompanyPhoneExt, CompanyCity, CompanyState, CompanyZip FROM Profile WHERE (CustID = @CustID) AND (CustType = @CustType)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
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
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Title", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Title", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Notes", SqlDbType.Text, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "Notes", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SLAClass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAClass", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MiddleName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@NetworkLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "NetworkLoginID", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateTimeAUP", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeAUP", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateTimeMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeMailbox", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateTimeLogged", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeLogged", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AuthorizedMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AuthorizedMailbox", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@JobCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobCode", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADSLDAPPath", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSLDAPPath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADSHomeDirectory", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSHomeDirectory", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADSProfilePath", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSProfilePath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADSScriptPath", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSScriptPath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADSSIFREFID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSSIFREFID", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Region", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCAddress1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCAddress1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCCity", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCState", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZipCode", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCFax", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyRegion", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhone", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyFax", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ProfileType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProfileType", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@uDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "uDomain", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhoneExt", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyCity", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyState", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CompanyZip", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyZip", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Profile] SET [CustID] = @CustID, [CustType] = @CustType, [FirstName] = @FirstName, [LastName] = @LastName, [Title] = @Title, [EMailID] = @EMailID, [Notes] = @Notes, [ModBy] = @ModBy, [ModDate] = @ModDate, [ModTime] = @ModTime, [SLAClass] = @SLAClass, [DTLastMod] = @DTLastMod, [MiddleName] = @MiddleName, [NetworkLoginID] = @NetworkLoginID, [DateTimeAUP] = @DateTimeAUP, [DateTimeMailbox] = @DateTimeMailbox, [DateTimeLogged] = @DateTimeLogged, [AuthorizedMailbox] = @AuthorizedMailbox, [JobCode] = @JobCode, [JobDescription] = @JobDescription, [ADSLDAPPath] = @ADSLDAPPath, [ADSHomeDirectory] = @ADSHomeDirectory, [ADSProfilePath] = @ADSProfilePath, [ADSScriptPath] = @ADSScriptPath, [ADSSIFREFID] = @ADSSIFREFID, [RCNumber] = @RCNumber, [Region] = @Region, [RCName] = @RCName, [RCAddress1] = @RCAddress1, [RCCity] = @RCCity, [RCState] = @RCState, [RCZipCode] = @RCZipCode, [RCPhone] = @RCPhone, [RCFax] = @RCFax, [CompanyName] = @CompanyName, [CompanyRegion] = @CompanyRegion, [CompanyPhone] = @CompanyPhone, [CompanyFax] = @CompanyFax, [ProfileType] = @ProfileType, [RCZone] = @RCZone, [DisplayName] = @DisplayName, [uDomain] = @uDomain, [CompanyPhoneExt] = @CompanyPhoneExt, [CompanyCity] = @CompanyCity, [CompanyState] = @CompanyState, [CompanyZip] = @CompanyZip WHERE (([CustID] = @Original_CustID) AND ([CustType] = @Original_CustType) AND ((@IsNull_FirstName = 1 AND [FirstName] IS NULL) OR ([FirstName] = @Original_FirstName)) AND ((@IsNull_LastName = 1 AND [LastName] IS NULL) OR ([LastName] = @Original_LastName)) AND ((@IsNull_Title = 1 AND [Title] IS NULL) OR ([Title] = @Original_Title)) AND ((@IsNull_EMailID = 1 AND [EMailID] IS NULL) OR ([EMailID] = @Original_EMailID)) AND ((@IsNull_ModBy = 1 AND [ModBy] IS NULL) OR ([ModBy] = @Original_ModBy)) AND ((@IsNull_ModDate = 1 AND [ModDate] IS NULL) OR ([ModDate] = @Original_ModDate)) AND ((@IsNull_ModTime = 1 AND [ModTime] IS NULL) OR ([ModTime] = @Original_ModTime)) AND ((@IsNull_SLAClass = 1 AND [SLAClass] IS NULL) OR ([SLAClass] = @Original_SLAClass)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_MiddleName = 1 AND [MiddleName] IS NULL) OR ([MiddleName] = @Original_MiddleName)) AND ((@IsNull_NetworkLoginID = 1 AND [NetworkLoginID] IS NULL) OR ([NetworkLoginID] = @Original_NetworkLoginID)) AND ((@IsNull_DateTimeAUP = 1 AND [DateTimeAUP] IS NULL) OR ([DateTimeAUP] = @Original_DateTimeAUP)) AND ((@IsNull_DateTimeMailbox = 1 AND [DateTimeMailbox] IS NULL) OR ([DateTimeMailbox] = @Original_DateTimeMailbox)) AND ((@IsNull_DateTimeLogged = 1 AND [DateTimeLogged] IS NULL) OR ([DateTimeLogged] = @Original_DateTimeLogged)) AND ((@IsNull_AuthorizedMailbox = 1 AND [AuthorizedMailbox] IS NULL) OR ([AuthorizedMailbox] = @Original_AuthorizedMailbox)) AND ((@IsNull_JobCode = 1 AND [JobCode] IS NULL) OR ([JobCode] = @Original_JobCode)) AND ((@IsNull_JobDescription = 1 AND [JobDescription] IS NULL) OR ([JobDescription] = @Original_JobDescription)) AND ((@IsNull_ADSSIFREFID = 1 AND [ADSSIFREFID] IS NULL) OR ([ADSSIFREFID] = @Original_ADSSIFREFID)) AND ((@IsNull_RCNumber = 1 AND [RCNumber] IS NULL) OR ([RCNumber] = @Original_RCNumber)) AND ((@IsNull_Region = 1 AND [Region] IS NULL) OR ([Region] = @Original_Region)) AND ((@IsNull_RCName = 1 AND [RCName] IS NULL) OR ([RCName] = @Original_RCName)) AND ((@IsNull_RCAddress1 = 1 AND [RCAddress1] IS NULL) OR ([RCAddress1] = @Original_RCAddress1)) AND ((@IsNull_RCCity = 1 AND [RCCity] IS NULL) OR ([RCCity] = @Original_RCCity)) AND ((@IsNull_RCState = 1 AND [RCState] IS NULL) OR ([RCState] = @Original_RCState)) AND ((@IsNull_RCZipCode = 1 AND [RCZipCode] IS NULL) OR ([RCZipCode] = @Original_RCZipCode)) AND ((@IsNull_RCPhone = 1 AND [RCPhone] IS NULL) OR ([RCPhone] = @Original_RCPhone)) AND ((@IsNull_RCFax = 1 AND [RCFax] IS NULL) OR ([RCFax] = @Original_RCFax)) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_CompanyRegion = 1 AND [CompanyRegion] IS NULL) OR ([CompanyRegion] = @Original_CompanyRegion)) AND ((@IsNull_CompanyPhone = 1 AND [CompanyPhone] IS NULL) OR ([CompanyPhone] = @Original_CompanyPhone)) AND ((@IsNull_CompanyFax = 1 AND [CompanyFax] IS NULL) OR ([CompanyFax] = @Original_CompanyFax)) AND ((@IsNull_ProfileType = 1 AND [ProfileType] IS NULL) OR ([ProfileType] = @Original_ProfileType)) AND ((@IsNull_RCZone = 1 AND [RCZone] IS NULL) OR ([RCZone] = @Original_RCZone)) AND ((@IsNull_DisplayName = 1 AND [DisplayName] IS NULL) OR ([DisplayName] = @Original_DisplayName)) AND ((@IsNull_uDomain = 1 AND [uDomain] IS NULL) OR ([uDomain] = @Original_uDomain)) AND ((@IsNull_CompanyPhoneExt = 1 AND [CompanyPhoneExt] IS NULL) OR ([CompanyPhoneExt] = @Original_CompanyPhoneExt)) AND ((@IsNull_CompanyCity = 1 AND [CompanyCity] IS NULL) OR ([CompanyCity] = @Original_CompanyCity)) AND ((@IsNull_CompanyState = 1 AND [CompanyState] IS NULL) OR ([CompanyState] = @Original_CompanyState)) AND ((@IsNull_CompanyZip = 1 AND [CompanyZip] IS NULL) OR ([CompanyZip] = @Original_CompanyZip)));\r\nSELECT CustID, CustType, FirstName, LastName, Title, EMailID, Notes, ModBy, ModDate, ModTime, SLAClass, DTLastMod, MiddleName, NetworkLoginID, DateTimeAUP, DateTimeMailbox, DateTimeLogged, AuthorizedMailbox, JobCode, JobDescription, ADSLDAPPath, ADSHomeDirectory, ADSProfilePath, ADSScriptPath, ADSSIFREFID, RCNumber, Region, RCName, RCAddress1, RCCity, RCState, RCZipCode, RCPhone, RCFax, CompanyName, CompanyRegion, CompanyPhone, CompanyFax, ProfileType, RCZone, DisplayName, uDomain, CompanyPhoneExt, CompanyCity, CompanyState, CompanyZip FROM Profile WHERE (CustID = @CustID) AND (CustType = @CustType)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Current, false, (object) null, "",
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
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Title", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Title", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Notes", SqlDbType.Text, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "Notes", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModBy", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModBy", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ModTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ModTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SLAClass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAClass", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MiddleName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NetworkLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "NetworkLoginID", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateTimeAUP", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeAUP", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateTimeMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeMailbox", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateTimeLogged", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeLogged", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AuthorizedMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AuthorizedMailbox", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@JobCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobCode", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADSLDAPPath", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSLDAPPath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADSHomeDirectory", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSHomeDirectory", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADSProfilePath", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSProfilePath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADSScriptPath", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSScriptPath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADSSIFREFID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSSIFREFID", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Region", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCAddress1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCAddress1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCCity", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCState", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZipCode", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCFax", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyRegion", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhone", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyFax", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ProfileType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProfileType", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@uDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "uDomain", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhoneExt", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyCity", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyState", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CompanyZip", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyZip", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CustID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CustID", DataRowVersion.Original, false, (object) null,
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
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Title", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Title", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EMailID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EMailID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EMailID", DataRowVersion.Original, false, (object) null,
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
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SLAClass", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAClass", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SLAClass", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SLAClass", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_MiddleName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MiddleName", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MiddleName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "MiddleName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_NetworkLoginID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "NetworkLoginID", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_NetworkLoginID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "NetworkLoginID", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DateTimeAUP", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeAUP", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DateTimeAUP", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeAUP", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DateTimeMailbox", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeMailbox", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DateTimeMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeMailbox", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DateTimeLogged", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeLogged", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DateTimeLogged", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DateTimeLogged", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AuthorizedMailbox", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AuthorizedMailbox", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AuthorizedMailbox", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AuthorizedMailbox", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_JobCode", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobCode", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_JobCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobCode", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_JobDescription", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_JobDescription", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JobDescription", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ADSSIFREFID", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSSIFREFID", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ADSSIFREFID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADSSIFREFID", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCNumber", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Region", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Region", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCAddress1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCAddress1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCAddress1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCAddress1", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCCity", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCCity", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCCity", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCState", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCState", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCState", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCZipCode", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZipCode", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZipCode", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCPhone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCPhone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCFax", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCFax", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCFax", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyRegion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyRegion", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyRegion", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyPhone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhone", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyPhone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhone", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyFax", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyFax", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyFax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyFax", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ProfileType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProfileType", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ProfileType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ProfileType", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RCZone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RCZone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RCZone", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DisplayName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DisplayName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_uDomain", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "uDomain", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_uDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "uDomain", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyPhoneExt", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhoneExt", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyPhoneExt", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyPhoneExt", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyCity", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyCity", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyCity", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyCity", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyState", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyState", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyState", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyState", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CompanyZip", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyZip", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CompanyZip", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyZip", DataRowVersion.Original, false,
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
                "SELECT CustID, CustType, FirstName, LastName, Title, EMailID, Notes, ModBy, ModDate, ModTime, SLAClass, DTLastMod, MiddleName, NetworkLoginID, DateTimeAUP, DateTimeMailbox, DateTimeLogged, AuthorizedMailbox, JobCode, JobDescription, ADSLDAPPath, ADSHomeDirectory, ADSProfilePath, ADSScriptPath, ADSSIFREFID, RCNumber, Region, RCName, RCAddress1, RCCity, RCState, RCZipCode, RCPhone, RCFax, CompanyName, CompanyRegion, CompanyPhone, CompanyFax, ProfileType, RCZone, DisplayName, uDomain, CompanyPhoneExt, CompanyCity, CompanyState, CompanyZip FROM dbo.Profile";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Fill(HeaTdbDataSet.ProfileDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual HeaTdbDataSet.ProfileDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.ProfileDataTable profileDataTable = new HeaTdbDataSet.ProfileDataTable();
            Adapter.Fill((DataTable) profileDataTable);
            return profileDataTable;
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.ProfileDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Profile");
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return Adapter.Update(new DataRow[1] {dataRow});
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public virtual int Update(DataRow[] dataRows)
        {
            return Adapter.Update(dataRows);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Delete(string originalCustId, string originalCustType, string originalFirstName,
            string originalLastName, string originalTitle, string originalEMailId, string originalModBy,
            string originalModDate, string originalModTime, string originalSlaClass, int? originalDtLastMod,
            string originalMiddleName, string originalNetworkLoginId, string originalDateTimeAup,
            string originalDateTimeMailbox, string originalDateTimeLogged, string originalAuthorizedMailbox,
            string originalJobCode, string originalJobDescription, string originalAdssifrefid, string originalRcNumber,
            string originalRegion, string originalRcName, string originalRcAddress1, string originalRcCity,
            string originalRcState, string originalRcZipCode, string originalRcPhone, string originalRcFax,
            string originalCompanyName, string originalCompanyRegion, string originalCompanyPhone,
            string originalCompanyFax, string originalProfileType, string originalRcZone, string originalDisplayName,
            string originalUDomain, string originalCompanyPhoneExt, string originalCompanyCity,
            string originalCompanyState, string originalCompanyZip)
        {
            if (originalCustId == null)
                throw new ArgumentNullException("originalCustId");
            Adapter.DeleteCommand.Parameters[0].Value = (object) originalCustId;
            if (originalCustType == null)
                throw new ArgumentNullException("originalCustType");
            Adapter.DeleteCommand.Parameters[1].Value = (object) originalCustType;
            if (originalFirstName == null)
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[3].Value = (object) originalFirstName;
            }
            if (originalLastName == null)
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[5].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[5].Value = (object) originalLastName;
            }
            if (originalTitle == null)
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[7].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[7].Value = (object) originalTitle;
            }
            if (originalEMailId == null)
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[9].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[9].Value = (object) originalEMailId;
            }
            if (originalModBy == null)
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[11].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[11].Value = (object) originalModBy;
            }
            if (originalModDate == null)
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[13].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[13].Value = (object) originalModDate;
            }
            if (originalModTime == null)
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[15].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[15].Value = (object) originalModTime;
            }
            if (originalSlaClass == null)
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[17].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[17].Value = (object) originalSlaClass;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.DeleteCommand.Parameters[18].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[19].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[18].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[19].Value = (object) DBNull.Value;
            }
            if (originalMiddleName == null)
            {
                Adapter.DeleteCommand.Parameters[20].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[21].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[20].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[21].Value = (object) originalMiddleName;
            }
            if (originalNetworkLoginId == null)
            {
                Adapter.DeleteCommand.Parameters[22].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[23].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[22].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[23].Value = (object) originalNetworkLoginId;
            }
            if (originalDateTimeAup == null)
            {
                Adapter.DeleteCommand.Parameters[24].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[25].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[24].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[25].Value = (object) originalDateTimeAup;
            }
            if (originalDateTimeMailbox == null)
            {
                Adapter.DeleteCommand.Parameters[26].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[27].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[26].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[27].Value = (object) originalDateTimeMailbox;
            }
            if (originalDateTimeLogged == null)
            {
                Adapter.DeleteCommand.Parameters[28].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[29].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[28].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[29].Value = (object) originalDateTimeLogged;
            }
            if (originalAuthorizedMailbox == null)
            {
                Adapter.DeleteCommand.Parameters[30].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[31].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[30].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[31].Value = (object) originalAuthorizedMailbox;
            }
            if (originalJobCode == null)
            {
                Adapter.DeleteCommand.Parameters[32].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[33].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[32].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[33].Value = (object) originalJobCode;
            }
            if (originalJobDescription == null)
            {
                Adapter.DeleteCommand.Parameters[34].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[35].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[34].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[35].Value = (object) originalJobDescription;
            }
            if (originalAdssifrefid == null)
            {
                Adapter.DeleteCommand.Parameters[36].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[37].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[36].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[37].Value = (object) originalAdssifrefid;
            }
            if (originalRcNumber == null)
            {
                Adapter.DeleteCommand.Parameters[38].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[39].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[38].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[39].Value = (object) originalRcNumber;
            }
            if (originalRegion == null)
            {
                Adapter.DeleteCommand.Parameters[40].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[41].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[40].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[41].Value = (object) originalRegion;
            }
            if (originalRcName == null)
            {
                Adapter.DeleteCommand.Parameters[42].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[43].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[42].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[43].Value = (object) originalRcName;
            }
            if (originalRcAddress1 == null)
            {
                Adapter.DeleteCommand.Parameters[44].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[45].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[44].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[45].Value = (object) originalRcAddress1;
            }
            if (originalRcCity == null)
            {
                Adapter.DeleteCommand.Parameters[46].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[47].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[46].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[47].Value = (object) originalRcCity;
            }
            if (originalRcState == null)
            {
                Adapter.DeleteCommand.Parameters[48].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[49].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[48].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[49].Value = (object) originalRcState;
            }
            if (originalRcZipCode == null)
            {
                Adapter.DeleteCommand.Parameters[50].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[51].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[50].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[51].Value = (object) originalRcZipCode;
            }
            if (originalRcPhone == null)
            {
                Adapter.DeleteCommand.Parameters[52].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[53].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[52].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[53].Value = (object) originalRcPhone;
            }
            if (originalRcFax == null)
            {
                Adapter.DeleteCommand.Parameters[54].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[55].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[54].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[55].Value = (object) originalRcFax;
            }
            if (originalCompanyName == null)
            {
                Adapter.DeleteCommand.Parameters[56].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[57].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[56].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[57].Value = (object) originalCompanyName;
            }
            if (originalCompanyRegion == null)
            {
                Adapter.DeleteCommand.Parameters[58].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[59].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[58].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[59].Value = (object) originalCompanyRegion;
            }
            if (originalCompanyPhone == null)
            {
                Adapter.DeleteCommand.Parameters[60].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[61].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[60].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[61].Value = (object) originalCompanyPhone;
            }
            if (originalCompanyFax == null)
            {
                Adapter.DeleteCommand.Parameters[62].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[63].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[62].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[63].Value = (object) originalCompanyFax;
            }
            if (originalProfileType == null)
            {
                Adapter.DeleteCommand.Parameters[64].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[65].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[64].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[65].Value = (object) originalProfileType;
            }
            if (originalRcZone == null)
            {
                Adapter.DeleteCommand.Parameters[66].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[67].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[66].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[67].Value = (object) originalRcZone;
            }
            if (originalDisplayName == null)
            {
                Adapter.DeleteCommand.Parameters[68].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[69].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[68].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[69].Value = (object) originalDisplayName;
            }
            if (originalUDomain == null)
            {
                Adapter.DeleteCommand.Parameters[70].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[71].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[70].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[71].Value = (object) originalUDomain;
            }
            if (originalCompanyPhoneExt == null)
            {
                Adapter.DeleteCommand.Parameters[72].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[73].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[72].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[73].Value = (object) originalCompanyPhoneExt;
            }
            if (originalCompanyCity == null)
            {
                Adapter.DeleteCommand.Parameters[74].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[75].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[74].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[75].Value = (object) originalCompanyCity;
            }
            if (originalCompanyState == null)
            {
                Adapter.DeleteCommand.Parameters[76].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[77].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[76].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[77].Value = (object) originalCompanyState;
            }
            if (originalCompanyZip == null)
            {
                Adapter.DeleteCommand.Parameters[78].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[79].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[78].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[79].Value = (object) originalCompanyZip;
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

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Insert(string custId, string custType, string firstName, string lastName, string title,
            string eMailId, string notes, string modBy, string modDate, string modTime, string slaClass, int? dtLastMod,
            string middleName, string networkLoginId, string dateTimeAup, string dateTimeMailbox, string dateTimeLogged,
            string authorizedMailbox, string jobCode, string jobDescription, string adsldapPath, string adsHomeDirectory,
            string adsProfilePath, string adsScriptPath, string adssifrefid, string rcNumber, string region,
            string rcName, string rcAddress1, string rcCity, string rcState, string rcZipCode, string rcPhone,
            string rcFax, string companyName, string companyRegion, string companyPhone, string companyFax,
            string profileType, string rcZone, string displayName, string uDomain, string companyPhoneExt,
            string companyCity, string companyState, string companyZip)
        {
            if (custId == null)
                throw new ArgumentNullException("custId");
            Adapter.InsertCommand.Parameters[0].Value = (object) custId;
            if (custType == null)
                throw new ArgumentNullException("custType");
            Adapter.InsertCommand.Parameters[1].Value = (object) custType;
            if (firstName == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) firstName;
            if (lastName == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) lastName;
            if (title == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) title;
            if (eMailId == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) eMailId;
            if (notes == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) notes;
            if (modBy == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) modBy;
            if (modDate == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) modDate;
            if (modTime == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) modTime;
            if (slaClass == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) slaClass;
            if (dtLastMod.HasValue)
                Adapter.InsertCommand.Parameters[11].Value = (object) dtLastMod.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            if (middleName == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) middleName;
            if (networkLoginId == null)
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) networkLoginId;
            if (dateTimeAup == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) dateTimeAup;
            if (dateTimeMailbox == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) dateTimeMailbox;
            if (dateTimeLogged == null)
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) dateTimeLogged;
            if (authorizedMailbox == null)
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) authorizedMailbox;
            if (jobCode == null)
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) jobCode;
            if (jobDescription == null)
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) jobDescription;
            if (adsldapPath == null)
                Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[20].Value = (object) adsldapPath;
            if (adsHomeDirectory == null)
                Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[21].Value = (object) adsHomeDirectory;
            if (adsProfilePath == null)
                Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[22].Value = (object) adsProfilePath;
            if (adsScriptPath == null)
                Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[23].Value = (object) adsScriptPath;
            if (adssifrefid == null)
                Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[24].Value = (object) adssifrefid;
            if (rcNumber == null)
                Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[25].Value = (object) rcNumber;
            if (region == null)
                Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[26].Value = (object) region;
            if (rcName == null)
                Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[27].Value = (object) rcName;
            if (rcAddress1 == null)
                Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[28].Value = (object) rcAddress1;
            if (rcCity == null)
                Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[29].Value = (object) rcCity;
            if (rcState == null)
                Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[30].Value = (object) rcState;
            if (rcZipCode == null)
                Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[31].Value = (object) rcZipCode;
            if (rcPhone == null)
                Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[32].Value = (object) rcPhone;
            if (rcFax == null)
                Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[33].Value = (object) rcFax;
            if (companyName == null)
                Adapter.InsertCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[34].Value = (object) companyName;
            if (companyRegion == null)
                Adapter.InsertCommand.Parameters[35].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[35].Value = (object) companyRegion;
            if (companyPhone == null)
                Adapter.InsertCommand.Parameters[36].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[36].Value = (object) companyPhone;
            if (companyFax == null)
                Adapter.InsertCommand.Parameters[37].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[37].Value = (object) companyFax;
            if (profileType == null)
                Adapter.InsertCommand.Parameters[38].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[38].Value = (object) profileType;
            if (rcZone == null)
                Adapter.InsertCommand.Parameters[39].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[39].Value = (object) rcZone;
            if (displayName == null)
                Adapter.InsertCommand.Parameters[40].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[40].Value = (object) displayName;
            if (uDomain == null)
                Adapter.InsertCommand.Parameters[41].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[41].Value = (object) uDomain;
            if (companyPhoneExt == null)
                Adapter.InsertCommand.Parameters[42].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[42].Value = (object) companyPhoneExt;
            if (companyCity == null)
                Adapter.InsertCommand.Parameters[43].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[43].Value = (object) companyCity;
            if (companyState == null)
                Adapter.InsertCommand.Parameters[44].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[44].Value = (object) companyState;
            if (companyZip == null)
                Adapter.InsertCommand.Parameters[45].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[45].Value = (object) companyZip;
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

        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string custId, string custType, string firstName, string lastName, string title,
            string eMailId, string notes, string modBy, string modDate, string modTime, string slaClass, int? dtLastMod,
            string middleName, string networkLoginId, string dateTimeAup, string dateTimeMailbox, string dateTimeLogged,
            string authorizedMailbox, string jobCode, string jobDescription, string adsldapPath, string adsHomeDirectory,
            string adsProfilePath, string adsScriptPath, string adssifrefid, string rcNumber, string region,
            string rcName, string rcAddress1, string rcCity, string rcState, string rcZipCode, string rcPhone,
            string rcFax, string companyName, string companyRegion, string companyPhone, string companyFax,
            string profileType, string rcZone, string displayName, string uDomain, string companyPhoneExt,
            string companyCity, string companyState, string companyZip, string originalCustId, string originalCustType,
            string originalFirstName, string originalLastName, string originalTitle, string originalEMailId,
            string originalModBy, string originalModDate, string originalModTime, string originalSlaClass,
            int? originalDtLastMod, string originalMiddleName, string originalNetworkLoginId, string originalDateTimeAup,
            string originalDateTimeMailbox, string originalDateTimeLogged, string originalAuthorizedMailbox,
            string originalJobCode, string originalJobDescription, string originalAdssifrefid, string originalRcNumber,
            string originalRegion, string originalRcName, string originalRcAddress1, string originalRcCity,
            string originalRcState, string originalRcZipCode, string originalRcPhone, string originalRcFax,
            string originalCompanyName, string originalCompanyRegion, string originalCompanyPhone,
            string originalCompanyFax, string originalProfileType, string originalRcZone, string originalDisplayName,
            string originalUDomain, string originalCompanyPhoneExt, string originalCompanyCity,
            string originalCompanyState, string originalCompanyZip)
        {
            if (custId == null)
                throw new ArgumentNullException("custId");
            Adapter.UpdateCommand.Parameters[0].Value = (object) custId;
            if (custType == null)
                throw new ArgumentNullException("custType");
            Adapter.UpdateCommand.Parameters[1].Value = (object) custType;
            if (firstName == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) firstName;
            if (lastName == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) lastName;
            if (title == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) title;
            if (eMailId == null)
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) eMailId;
            if (notes == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) notes;
            if (modBy == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) modBy;
            if (modDate == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) modDate;
            if (modTime == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) modTime;
            if (slaClass == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) slaClass;
            if (dtLastMod.HasValue)
                Adapter.UpdateCommand.Parameters[11].Value = (object) dtLastMod.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            if (middleName == null)
                Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[12].Value = (object) middleName;
            if (networkLoginId == null)
                Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[13].Value = (object) networkLoginId;
            if (dateTimeAup == null)
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[14].Value = (object) dateTimeAup;
            if (dateTimeMailbox == null)
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[15].Value = (object) dateTimeMailbox;
            if (dateTimeLogged == null)
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[16].Value = (object) dateTimeLogged;
            if (authorizedMailbox == null)
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[17].Value = (object) authorizedMailbox;
            if (jobCode == null)
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[18].Value = (object) jobCode;
            if (jobDescription == null)
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[19].Value = (object) jobDescription;
            if (adsldapPath == null)
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[20].Value = (object) adsldapPath;
            if (adsHomeDirectory == null)
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[21].Value = (object) adsHomeDirectory;
            if (adsProfilePath == null)
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[22].Value = (object) adsProfilePath;
            if (adsScriptPath == null)
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[23].Value = (object) adsScriptPath;
            if (adssifrefid == null)
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[24].Value = (object) adssifrefid;
            if (rcNumber == null)
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[25].Value = (object) rcNumber;
            if (region == null)
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[26].Value = (object) region;
            if (rcName == null)
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[27].Value = (object) rcName;
            if (rcAddress1 == null)
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[28].Value = (object) rcAddress1;
            if (rcCity == null)
                Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[29].Value = (object) rcCity;
            if (rcState == null)
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[30].Value = (object) rcState;
            if (rcZipCode == null)
                Adapter.UpdateCommand.Parameters[31].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[31].Value = (object) rcZipCode;
            if (rcPhone == null)
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[32].Value = (object) rcPhone;
            if (rcFax == null)
                Adapter.UpdateCommand.Parameters[33].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[33].Value = (object) rcFax;
            if (companyName == null)
                Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[34].Value = (object) companyName;
            if (companyRegion == null)
                Adapter.UpdateCommand.Parameters[35].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[35].Value = (object) companyRegion;
            if (companyPhone == null)
                Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[36].Value = (object) companyPhone;
            if (companyFax == null)
                Adapter.UpdateCommand.Parameters[37].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[37].Value = (object) companyFax;
            if (profileType == null)
                Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[38].Value = (object) profileType;
            if (rcZone == null)
                Adapter.UpdateCommand.Parameters[39].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[39].Value = (object) rcZone;
            if (displayName == null)
                Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[40].Value = (object) displayName;
            if (uDomain == null)
                Adapter.UpdateCommand.Parameters[41].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[41].Value = (object) uDomain;
            if (companyPhoneExt == null)
                Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[42].Value = (object) companyPhoneExt;
            if (companyCity == null)
                Adapter.UpdateCommand.Parameters[43].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[43].Value = (object) companyCity;
            if (companyState == null)
                Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[44].Value = (object) companyState;
            if (companyZip == null)
                Adapter.UpdateCommand.Parameters[45].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[45].Value = (object) companyZip;
            if (originalCustId == null)
                throw new ArgumentNullException("originalCustId");
            Adapter.UpdateCommand.Parameters[46].Value = (object) originalCustId;
            if (originalCustType == null)
                throw new ArgumentNullException("originalCustType");
            Adapter.UpdateCommand.Parameters[47].Value = (object) originalCustType;
            if (originalFirstName == null)
            {
                Adapter.UpdateCommand.Parameters[48].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[49].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[48].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[49].Value = (object) originalFirstName;
            }
            if (originalLastName == null)
            {
                Adapter.UpdateCommand.Parameters[50].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[51].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[50].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[51].Value = (object) originalLastName;
            }
            if (originalTitle == null)
            {
                Adapter.UpdateCommand.Parameters[52].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[53].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[52].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[53].Value = (object) originalTitle;
            }
            if (originalEMailId == null)
            {
                Adapter.UpdateCommand.Parameters[54].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[55].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[54].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[55].Value = (object) originalEMailId;
            }
            if (originalModBy == null)
            {
                Adapter.UpdateCommand.Parameters[56].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[57].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[56].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[57].Value = (object) originalModBy;
            }
            if (originalModDate == null)
            {
                Adapter.UpdateCommand.Parameters[58].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[59].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[58].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[59].Value = (object) originalModDate;
            }
            if (originalModTime == null)
            {
                Adapter.UpdateCommand.Parameters[60].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[61].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[60].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[61].Value = (object) originalModTime;
            }
            if (originalSlaClass == null)
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[63].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[62].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[63].Value = (object) originalSlaClass;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[65].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[64].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[65].Value = (object) DBNull.Value;
            }
            if (originalMiddleName == null)
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[67].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[66].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[67].Value = (object) originalMiddleName;
            }
            if (originalNetworkLoginId == null)
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[69].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[68].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[69].Value = (object) originalNetworkLoginId;
            }
            if (originalDateTimeAup == null)
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[71].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[70].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[71].Value = (object) originalDateTimeAup;
            }
            if (originalDateTimeMailbox == null)
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[73].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[72].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[73].Value = (object) originalDateTimeMailbox;
            }
            if (originalDateTimeLogged == null)
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[75].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[74].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[75].Value = (object) originalDateTimeLogged;
            }
            if (originalAuthorizedMailbox == null)
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[77].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[76].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[77].Value = (object) originalAuthorizedMailbox;
            }
            if (originalJobCode == null)
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[79].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[78].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[79].Value = (object) originalJobCode;
            }
            if (originalJobDescription == null)
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[81].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[80].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[81].Value = (object) originalJobDescription;
            }
            if (originalAdssifrefid == null)
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[83].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[82].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[83].Value = (object) originalAdssifrefid;
            }
            if (originalRcNumber == null)
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[85].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[84].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[85].Value = (object) originalRcNumber;
            }
            if (originalRegion == null)
            {
                Adapter.UpdateCommand.Parameters[86].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[87].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[86].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[87].Value = (object) originalRegion;
            }
            if (originalRcName == null)
            {
                Adapter.UpdateCommand.Parameters[88].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[89].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[88].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[89].Value = (object) originalRcName;
            }
            if (originalRcAddress1 == null)
            {
                Adapter.UpdateCommand.Parameters[90].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[91].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[90].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[91].Value = (object) originalRcAddress1;
            }
            if (originalRcCity == null)
            {
                Adapter.UpdateCommand.Parameters[92].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[93].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[92].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[93].Value = (object) originalRcCity;
            }
            if (originalRcState == null)
            {
                Adapter.UpdateCommand.Parameters[94].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[95].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[94].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[95].Value = (object) originalRcState;
            }
            if (originalRcZipCode == null)
            {
                Adapter.UpdateCommand.Parameters[96].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[97].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[96].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[97].Value = (object) originalRcZipCode;
            }
            if (originalRcPhone == null)
            {
                Adapter.UpdateCommand.Parameters[98].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[99].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[98].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[99].Value = (object) originalRcPhone;
            }
            if (originalRcFax == null)
            {
                Adapter.UpdateCommand.Parameters[100].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[101].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[100].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[101].Value = (object) originalRcFax;
            }
            if (originalCompanyName == null)
            {
                Adapter.UpdateCommand.Parameters[102].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[103].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[102].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[103].Value = (object) originalCompanyName;
            }
            if (originalCompanyRegion == null)
            {
                Adapter.UpdateCommand.Parameters[104].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[105].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[104].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[105].Value = (object) originalCompanyRegion;
            }
            if (originalCompanyPhone == null)
            {
                Adapter.UpdateCommand.Parameters[106].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[107].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[106].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[107].Value = (object) originalCompanyPhone;
            }
            if (originalCompanyFax == null)
            {
                Adapter.UpdateCommand.Parameters[108].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[109].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[108].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[109].Value = (object) originalCompanyFax;
            }
            if (originalProfileType == null)
            {
                Adapter.UpdateCommand.Parameters[110].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[111].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[110].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[111].Value = (object) originalProfileType;
            }
            if (originalRcZone == null)
            {
                Adapter.UpdateCommand.Parameters[112].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[113].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[112].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[113].Value = (object) originalRcZone;
            }
            if (originalDisplayName == null)
            {
                Adapter.UpdateCommand.Parameters[114].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[115].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[114].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[115].Value = (object) originalDisplayName;
            }
            if (originalUDomain == null)
            {
                Adapter.UpdateCommand.Parameters[116].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[117].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[116].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[117].Value = (object) originalUDomain;
            }
            if (originalCompanyPhoneExt == null)
            {
                Adapter.UpdateCommand.Parameters[118].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[119].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[118].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[119].Value = (object) originalCompanyPhoneExt;
            }
            if (originalCompanyCity == null)
            {
                Adapter.UpdateCommand.Parameters[120].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[121].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[120].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[121].Value = (object) originalCompanyCity;
            }
            if (originalCompanyState == null)
            {
                Adapter.UpdateCommand.Parameters[122].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[123].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[122].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[123].Value = (object) originalCompanyState;
            }
            if (originalCompanyZip == null)
            {
                Adapter.UpdateCommand.Parameters[124].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[125].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[124].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[125].Value = (object) originalCompanyZip;
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
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string firstName, string lastName, string title, string eMailId, string notes,
            string modBy, string modDate, string modTime, string slaClass, int? dtLastMod, string middleName,
            string networkLoginId, string dateTimeAup, string dateTimeMailbox, string dateTimeLogged,
            string authorizedMailbox, string jobCode, string jobDescription, string adsldapPath, string adsHomeDirectory,
            string adsProfilePath, string adsScriptPath, string adssifrefid, string rcNumber, string region,
            string rcName, string rcAddress1, string rcCity, string rcState, string rcZipCode, string rcPhone,
            string rcFax, string companyName, string companyRegion, string companyPhone, string companyFax,
            string profileType, string rcZone, string displayName, string uDomain, string companyPhoneExt,
            string companyCity, string companyState, string companyZip, string originalCustId, string originalCustType,
            string originalFirstName, string originalLastName, string originalTitle, string originalEMailId,
            string originalModBy, string originalModDate, string originalModTime, string originalSlaClass,
            int? originalDtLastMod, string originalMiddleName, string originalNetworkLoginId, string originalDateTimeAup,
            string originalDateTimeMailbox, string originalDateTimeLogged, string originalAuthorizedMailbox,
            string originalJobCode, string originalJobDescription, string originalAdssifrefid, string originalRcNumber,
            string originalRegion, string originalRcName, string originalRcAddress1, string originalRcCity,
            string originalRcState, string originalRcZipCode, string originalRcPhone, string originalRcFax,
            string originalCompanyName, string originalCompanyRegion, string originalCompanyPhone,
            string originalCompanyFax, string originalProfileType, string originalRcZone, string originalDisplayName,
            string originalUDomain, string originalCompanyPhoneExt, string originalCompanyCity,
            string originalCompanyState, string originalCompanyZip)
        {
            return Update(originalCustId, originalCustType, firstName, lastName, title, eMailId, notes, modBy, modDate,
                modTime, slaClass, dtLastMod, middleName, networkLoginId, dateTimeAup, dateTimeMailbox, dateTimeLogged,
                authorizedMailbox, jobCode, jobDescription, adsldapPath, adsHomeDirectory, adsProfilePath, adsScriptPath,
                adssifrefid, rcNumber, region, rcName, rcAddress1, rcCity, rcState, rcZipCode, rcPhone, rcFax,
                companyName, companyRegion, companyPhone, companyFax, profileType, rcZone, displayName, uDomain,
                companyPhoneExt, companyCity, companyState, companyZip, originalCustId, originalCustType,
                originalFirstName, originalLastName, originalTitle, originalEMailId, originalModBy, originalModDate,
                originalModTime, originalSlaClass, originalDtLastMod, originalMiddleName, originalNetworkLoginId,
                originalDateTimeAup, originalDateTimeMailbox, originalDateTimeLogged, originalAuthorizedMailbox,
                originalJobCode, originalJobDescription, originalAdssifrefid, originalRcNumber, originalRegion,
                originalRcName, originalRcAddress1, originalRcCity, originalRcState, originalRcZipCode, originalRcPhone,
                originalRcFax, originalCompanyName, originalCompanyRegion, originalCompanyPhone, originalCompanyFax,
                originalProfileType, originalRcZone, originalDisplayName, originalUDomain, originalCompanyPhoneExt,
                originalCompanyCity, originalCompanyState, originalCompanyZip);
        }
    }
}