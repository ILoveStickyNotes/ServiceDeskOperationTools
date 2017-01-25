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
    [DesignerCategory("code")]
    [ToolboxItem(true)]
    [DataObject(true)]
    public class HeatLoginStatusTableAdapter : Component
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
        public HeatLoginStatusTableAdapter()
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
                DataSetTable = "HEATLoginStatus",
                ColumnMappings =
                {
                    {
                        "ComputerName",
                        "ComputerName"
                    },
                    {
                        "ComputerDomain",
                        "ComputerDomain"
                    },
                    {
                        "UserName",
                        "UserName"
                    },
                    {
                        "UserDomain",
                        "UserDomain"
                    },
                    {
                        "AppName",
                        "AppName"
                    },
                    {
                        "HeatLogin",
                        "HeatLogin"
                    },
                    {
                        "LoginTime",
                        "LoginTime"
                    },
                    {
                        "LoginServerTime",
                        "LoginServerTime"
                    },
                    {
                        "LoginSuccess",
                        "LoginSuccess"
                    },
                    {
                        "LogoutTime",
                        "LogoutTime"
                    },
                    {
                        "HeatVersion",
                        "HeatVersion"
                    },
                    {
                        "HeatTimeZoneOffset",
                        "HeatTimeZoneOffset"
                    },
                    {
                        "SystemTimeZoneOffset",
                        "SystemTimeZoneOffset"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[HEATLoginStatus] WHERE (([ComputerName] = @Original_ComputerName) AND ([ComputerDomain] = @Original_ComputerDomain) AND ([UserName] = @Original_UserName) AND ([UserDomain] = @Original_UserDomain) AND ([AppName] = @Original_AppName) AND ([HeatLogin] = @Original_HeatLogin) AND ((@IsNull_LoginTime = 1 AND [LoginTime] IS NULL) OR ([LoginTime] = @Original_LoginTime)) AND ((@IsNull_LoginServerTime = 1 AND [LoginServerTime] IS NULL) OR ([LoginServerTime] = @Original_LoginServerTime)) AND ((@IsNull_LoginSuccess = 1 AND [LoginSuccess] IS NULL) OR ([LoginSuccess] = @Original_LoginSuccess)) AND ((@IsNull_LogoutTime = 1 AND [LogoutTime] IS NULL) OR ([LogoutTime] = @Original_LogoutTime)) AND ((@IsNull_HeatVersion = 1 AND [HeatVersion] IS NULL) OR ([HeatVersion] = @Original_HeatVersion)) AND ((@IsNull_HeatTimeZoneOffset = 1 AND [HeatTimeZoneOffset] IS NULL) OR ([HeatTimeZoneOffset] = @Original_HeatTimeZoneOffset)) AND ((@IsNull_SystemTimeZoneOffset = 1 AND [SystemTimeZoneOffset] IS NULL) OR ([SystemTimeZoneOffset] = @Original_SystemTimeZoneOffset)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ComputerDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerDomain", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UserDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserDomain", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AppName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AppName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HeatLogin", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatLogin", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LoginTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoginTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LoginServerTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginServerTime", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoginServerTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginServerTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LoginSuccess", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginSuccess", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoginSuccess", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginSuccess", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_LogoutTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LogoutTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LogoutTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LogoutTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HeatVersion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatVersion", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HeatVersion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatVersion", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HeatTimeZoneOffset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatTimeZoneOffset", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HeatTimeZoneOffset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatTimeZoneOffset", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_SystemTimeZoneOffset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SystemTimeZoneOffset", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_SystemTimeZoneOffset", SqlDbType.VarChar,
                0, ParameterDirection.Input, (byte) 0, (byte) 0, "SystemTimeZoneOffset", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[HEATLoginStatus] ([ComputerName], [ComputerDomain], [UserName], [UserDomain], [AppName], [HeatLogin], [LoginTime], [LoginServerTime], [LoginSuccess], [LogoutTime], [HeatVersion], [HeatTimeZoneOffset], [SystemTimeZoneOffset]) VALUES (@ComputerName, @ComputerDomain, @UserName, @UserDomain, @AppName, @HeatLogin, @LoginTime, @LoginServerTime, @LoginSuccess, @LogoutTime, @HeatVersion, @HeatTimeZoneOffset, @SystemTimeZoneOffset);\r\nSELECT ComputerName, ComputerDomain, UserName, UserDomain, AppName, HeatLogin, LoginTime, LoginServerTime, LoginSuccess, LogoutTime, HeatVersion, HeatTimeZoneOffset, SystemTimeZoneOffset FROM HEATLoginStatus WHERE (AppName = @AppName) AND (ComputerDomain = @ComputerDomain) AND (ComputerName = @ComputerName) AND (HeatLogin = @HeatLogin) AND (UserDomain = @UserDomain) AND (UserName = @UserName)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ComputerDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerDomain", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserDomain", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AppName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AppName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HeatLogin", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatLogin", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginServerTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginServerTime", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoginSuccess", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginSuccess", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@LogoutTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LogoutTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HeatVersion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatVersion", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HeatTimeZoneOffset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatTimeZoneOffset", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@SystemTimeZoneOffset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SystemTimeZoneOffset", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[HEATLoginStatus] SET [ComputerName] = @ComputerName, [ComputerDomain] = @ComputerDomain, [UserName] = @UserName, [UserDomain] = @UserDomain, [AppName] = @AppName, [HeatLogin] = @HeatLogin, [LoginTime] = @LoginTime, [LoginServerTime] = @LoginServerTime, [LoginSuccess] = @LoginSuccess, [LogoutTime] = @LogoutTime, [HeatVersion] = @HeatVersion, [HeatTimeZoneOffset] = @HeatTimeZoneOffset, [SystemTimeZoneOffset] = @SystemTimeZoneOffset WHERE (([ComputerName] = @Original_ComputerName) AND ([ComputerDomain] = @Original_ComputerDomain) AND ([UserName] = @Original_UserName) AND ([UserDomain] = @Original_UserDomain) AND ([AppName] = @Original_AppName) AND ([HeatLogin] = @Original_HeatLogin) AND ((@IsNull_LoginTime = 1 AND [LoginTime] IS NULL) OR ([LoginTime] = @Original_LoginTime)) AND ((@IsNull_LoginServerTime = 1 AND [LoginServerTime] IS NULL) OR ([LoginServerTime] = @Original_LoginServerTime)) AND ((@IsNull_LoginSuccess = 1 AND [LoginSuccess] IS NULL) OR ([LoginSuccess] = @Original_LoginSuccess)) AND ((@IsNull_LogoutTime = 1 AND [LogoutTime] IS NULL) OR ([LogoutTime] = @Original_LogoutTime)) AND ((@IsNull_HeatVersion = 1 AND [HeatVersion] IS NULL) OR ([HeatVersion] = @Original_HeatVersion)) AND ((@IsNull_HeatTimeZoneOffset = 1 AND [HeatTimeZoneOffset] IS NULL) OR ([HeatTimeZoneOffset] = @Original_HeatTimeZoneOffset)) AND ((@IsNull_SystemTimeZoneOffset = 1 AND [SystemTimeZoneOffset] IS NULL) OR ([SystemTimeZoneOffset] = @Original_SystemTimeZoneOffset)));\r\nSELECT ComputerName, ComputerDomain, UserName, UserDomain, AppName, HeatLogin, LoginTime, LoginServerTime, LoginSuccess, LogoutTime, HeatVersion, HeatTimeZoneOffset, SystemTimeZoneOffset FROM HEATLoginStatus WHERE (AppName = @AppName) AND (ComputerDomain = @ComputerDomain) AND (ComputerName = @ComputerName) AND (HeatLogin = @HeatLogin) AND (UserDomain = @UserDomain) AND (UserName = @UserName)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ComputerDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerDomain", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UserDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserDomain", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AppName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AppName", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HeatLogin", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatLogin", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoginTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoginServerTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginServerTime", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoginSuccess", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginSuccess", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LogoutTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LogoutTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HeatVersion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatVersion", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HeatTimeZoneOffset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatTimeZoneOffset", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SystemTimeZoneOffset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SystemTimeZoneOffset", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ComputerName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ComputerDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ComputerDomain", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UserDomain", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "UserDomain", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AppName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AppName", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HeatLogin", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatLogin", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LoginTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoginTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LoginServerTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginServerTime", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoginServerTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginServerTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LoginSuccess", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginSuccess", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoginSuccess", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LoginSuccess", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_LogoutTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LogoutTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LogoutTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "LogoutTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HeatVersion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatVersion", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HeatVersion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatVersion", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HeatTimeZoneOffset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatTimeZoneOffset", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HeatTimeZoneOffset", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HeatTimeZoneOffset", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_SystemTimeZoneOffset", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "SystemTimeZoneOffset", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_SystemTimeZoneOffset", SqlDbType.VarChar,
                0, ParameterDirection.Input, (byte) 0, (byte) 0, "SystemTimeZoneOffset", DataRowVersion.Original, false,
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
                "SELECT ComputerName, ComputerDomain, UserName, UserDomain, AppName, HeatLogin, LoginTime, LoginServerTime, LoginSuccess, LogoutTime, HeatVersion, HeatTimeZoneOffset, SystemTimeZoneOffset FROM dbo.HEATLoginStatus";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        public virtual int Fill(HeaTdbDataSet.HeatLoginStatusDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public virtual HeaTdbDataSet.HeatLoginStatusDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.HeatLoginStatusDataTable loginStatusDataTable = new HeaTdbDataSet.HeatLoginStatusDataTable();
            Adapter.Fill((DataTable) loginStatusDataTable);
            return loginStatusDataTable;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(HeaTdbDataSet.HeatLoginStatusDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "HEATLoginStatus");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
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

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public virtual int Delete(string originalComputerName, string originalComputerDomain, string originalUserName,
            string originalUserDomain, string originalAppName, string originalHeatLogin, string originalLoginTime,
            string originalLoginServerTime, string originalLoginSuccess, string originalLogoutTime,
            string originalHeatVersion, string originalHeatTimeZoneOffset, string originalSystemTimeZoneOffset)
        {
            if (originalComputerName == null)
                throw new ArgumentNullException("originalComputerName");
            Adapter.DeleteCommand.Parameters[0].Value = (object) originalComputerName;
            if (originalComputerDomain == null)
                throw new ArgumentNullException("originalComputerDomain");
            Adapter.DeleteCommand.Parameters[1].Value = (object) originalComputerDomain;
            if (originalUserName == null)
                throw new ArgumentNullException("originalUserName");
            Adapter.DeleteCommand.Parameters[2].Value = (object) originalUserName;
            if (originalUserDomain == null)
                throw new ArgumentNullException("originalUserDomain");
            Adapter.DeleteCommand.Parameters[3].Value = (object) originalUserDomain;
            if (originalAppName == null)
                throw new ArgumentNullException("originalAppName");
            Adapter.DeleteCommand.Parameters[4].Value = (object) originalAppName;
            if (originalHeatLogin == null)
                throw new ArgumentNullException("originalHeatLogin");
            Adapter.DeleteCommand.Parameters[5].Value = (object) originalHeatLogin;
            if (originalLoginTime == null)
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[7].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[7].Value = (object) originalLoginTime;
            }
            if (originalLoginServerTime == null)
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[9].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[9].Value = (object) originalLoginServerTime;
            }
            if (originalLoginSuccess == null)
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[11].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[11].Value = (object) originalLoginSuccess;
            }
            if (originalLogoutTime == null)
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[13].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[13].Value = (object) originalLogoutTime;
            }
            if (originalHeatVersion == null)
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[15].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[15].Value = (object) originalHeatVersion;
            }
            if (originalHeatTimeZoneOffset == null)
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[17].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[17].Value = (object) originalHeatTimeZoneOffset;
            }
            if (originalSystemTimeZoneOffset == null)
            {
                Adapter.DeleteCommand.Parameters[18].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[19].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[18].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[19].Value = (object) originalSystemTimeZoneOffset;
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
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Insert(string computerName, string computerDomain, string userName, string userDomain,
            string appName, string heatLogin, string loginTime, string loginServerTime, string loginSuccess,
            string logoutTime, string heatVersion, string heatTimeZoneOffset, string systemTimeZoneOffset)
        {
            if (computerName == null)
                throw new ArgumentNullException("computerName");
            Adapter.InsertCommand.Parameters[0].Value = (object) computerName;
            if (computerDomain == null)
                throw new ArgumentNullException("computerDomain");
            Adapter.InsertCommand.Parameters[1].Value = (object) computerDomain;
            if (userName == null)
                throw new ArgumentNullException("userName");
            Adapter.InsertCommand.Parameters[2].Value = (object) userName;
            if (userDomain == null)
                throw new ArgumentNullException("userDomain");
            Adapter.InsertCommand.Parameters[3].Value = (object) userDomain;
            if (appName == null)
                throw new ArgumentNullException("appName");
            Adapter.InsertCommand.Parameters[4].Value = (object) appName;
            if (heatLogin == null)
                throw new ArgumentNullException("heatLogin");
            Adapter.InsertCommand.Parameters[5].Value = (object) heatLogin;
            if (loginTime == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) loginTime;
            if (loginServerTime == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) loginServerTime;
            if (loginSuccess == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) loginSuccess;
            if (logoutTime == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) logoutTime;
            if (heatVersion == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) heatVersion;
            if (heatTimeZoneOffset == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) heatTimeZoneOffset;
            if (systemTimeZoneOffset == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) systemTimeZoneOffset;
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

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        [DebuggerNonUserCode]
        public virtual int Update(string computerName, string computerDomain, string userName, string userDomain,
            string appName, string heatLogin, string loginTime, string loginServerTime, string loginSuccess,
            string logoutTime, string heatVersion, string heatTimeZoneOffset, string systemTimeZoneOffset,
            string originalComputerName, string originalComputerDomain, string originalUserName,
            string originalUserDomain, string originalAppName, string originalHeatLogin, string originalLoginTime,
            string originalLoginServerTime, string originalLoginSuccess, string originalLogoutTime,
            string originalHeatVersion, string originalHeatTimeZoneOffset, string originalSystemTimeZoneOffset)
        {
            if (computerName == null)
                throw new ArgumentNullException("computerName");
            Adapter.UpdateCommand.Parameters[0].Value = (object) computerName;
            if (computerDomain == null)
                throw new ArgumentNullException("computerDomain");
            Adapter.UpdateCommand.Parameters[1].Value = (object) computerDomain;
            if (userName == null)
                throw new ArgumentNullException("userName");
            Adapter.UpdateCommand.Parameters[2].Value = (object) userName;
            if (userDomain == null)
                throw new ArgumentNullException("userDomain");
            Adapter.UpdateCommand.Parameters[3].Value = (object) userDomain;
            if (appName == null)
                throw new ArgumentNullException("appName");
            Adapter.UpdateCommand.Parameters[4].Value = (object) appName;
            if (heatLogin == null)
                throw new ArgumentNullException("heatLogin");
            Adapter.UpdateCommand.Parameters[5].Value = (object) heatLogin;
            if (loginTime == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) loginTime;
            if (loginServerTime == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) loginServerTime;
            if (loginSuccess == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) loginSuccess;
            if (logoutTime == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) logoutTime;
            if (heatVersion == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) heatVersion;
            if (heatTimeZoneOffset == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) heatTimeZoneOffset;
            if (systemTimeZoneOffset == null)
                Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[12].Value = (object) systemTimeZoneOffset;
            if (originalComputerName == null)
                throw new ArgumentNullException("originalComputerName");
            Adapter.UpdateCommand.Parameters[13].Value = (object) originalComputerName;
            if (originalComputerDomain == null)
                throw new ArgumentNullException("originalComputerDomain");
            Adapter.UpdateCommand.Parameters[14].Value = (object) originalComputerDomain;
            if (originalUserName == null)
                throw new ArgumentNullException("originalUserName");
            Adapter.UpdateCommand.Parameters[15].Value = (object) originalUserName;
            if (originalUserDomain == null)
                throw new ArgumentNullException("originalUserDomain");
            Adapter.UpdateCommand.Parameters[16].Value = (object) originalUserDomain;
            if (originalAppName == null)
                throw new ArgumentNullException("originalAppName");
            Adapter.UpdateCommand.Parameters[17].Value = (object) originalAppName;
            if (originalHeatLogin == null)
                throw new ArgumentNullException("originalHeatLogin");
            Adapter.UpdateCommand.Parameters[18].Value = (object) originalHeatLogin;
            if (originalLoginTime == null)
            {
                Adapter.UpdateCommand.Parameters[19].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[19].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[20].Value = (object) originalLoginTime;
            }
            if (originalLoginServerTime == null)
            {
                Adapter.UpdateCommand.Parameters[21].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[21].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[22].Value = (object) originalLoginServerTime;
            }
            if (originalLoginSuccess == null)
            {
                Adapter.UpdateCommand.Parameters[23].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[23].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[24].Value = (object) originalLoginSuccess;
            }
            if (originalLogoutTime == null)
            {
                Adapter.UpdateCommand.Parameters[25].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[26].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[25].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[26].Value = (object) originalLogoutTime;
            }
            if (originalHeatVersion == null)
            {
                Adapter.UpdateCommand.Parameters[27].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[27].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[28].Value = (object) originalHeatVersion;
            }
            if (originalHeatTimeZoneOffset == null)
            {
                Adapter.UpdateCommand.Parameters[29].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[29].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[30].Value = (object) originalHeatTimeZoneOffset;
            }
            if (originalSystemTimeZoneOffset == null)
            {
                Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[32].Value = (object) originalSystemTimeZoneOffset;
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string loginTime, string loginServerTime, string loginSuccess, string logoutTime,
            string heatVersion, string heatTimeZoneOffset, string systemTimeZoneOffset, string originalComputerName,
            string originalComputerDomain, string originalUserName, string originalUserDomain, string originalAppName,
            string originalHeatLogin, string originalLoginTime, string originalLoginServerTime,
            string originalLoginSuccess, string originalLogoutTime, string originalHeatVersion,
            string originalHeatTimeZoneOffset, string originalSystemTimeZoneOffset)
        {
            return Update(originalComputerName, originalComputerDomain, originalUserName, originalUserDomain,
                originalAppName, originalHeatLogin, loginTime, loginServerTime, loginSuccess, logoutTime, heatVersion,
                heatTimeZoneOffset, systemTimeZoneOffset, originalComputerName, originalComputerDomain, originalUserName,
                originalUserDomain, originalAppName, originalHeatLogin, originalLoginTime, originalLoginServerTime,
                originalLoginSuccess, originalLogoutTime, originalHeatVersion, originalHeatTimeZoneOffset,
                originalSystemTimeZoneOffset);
        }
    }
}