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
    public class JournalTableAdapter : Component
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
        public JournalTableAdapter()
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
                DataSetTable = "Journal",
                ColumnMappings =
                {
                    {
                        "CallID",
                        "CallID"
                    },
                    {
                        "HEATSeq",
                        "HEATSeq"
                    },
                    {
                        "Tracker",
                        "Tracker"
                    },
                    {
                        "EntryDate",
                        "EntryDate"
                    },
                    {
                        "EntryTime",
                        "EntryTime"
                    },
                    {
                        "EntryText",
                        "EntryText"
                    },
                    {
                        "JournalType",
                        "JournalType"
                    },
                    {
                        "DTLastMod",
                        "DTLastMod"
                    },
                    {
                        "TempField",
                        "TempField"
                    },
                    {
                        "TotalJournalTime",
                        "TotalJournalTime"
                    },
                    {
                        "DisplayHSS",
                        "DisplayHSS"
                    },
                    {
                        "PMOSecurity",
                        "PMOSecurity"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Journal] WHERE (([CallID] = @Original_CallID) AND ([HEATSeq] = @Original_HEATSeq) AND ((@IsNull_Tracker = 1 AND [Tracker] IS NULL) OR ([Tracker] = @Original_Tracker)) AND ((@IsNull_EntryDate = 1 AND [EntryDate] IS NULL) OR ([EntryDate] = @Original_EntryDate)) AND ((@IsNull_EntryTime = 1 AND [EntryTime] IS NULL) OR ([EntryTime] = @Original_EntryTime)) AND ((@IsNull_JournalType = 1 AND [JournalType] IS NULL) OR ([JournalType] = @Original_JournalType)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_TempField = 1 AND [TempField] IS NULL) OR ([TempField] = @Original_TempField)) AND ((@IsNull_TotalJournalTime = 1 AND [TotalJournalTime] IS NULL) OR ([TotalJournalTime] = @Original_TotalJournalTime)) AND ((@IsNull_DisplayHSS = 1 AND [DisplayHSS] IS NULL) OR ([DisplayHSS] = @Original_DisplayHSS)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Tracker", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EntryDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EntryDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EntryTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EntryTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_JournalType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JournalType", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_JournalType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JournalType", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TempField", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TempField", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TempField", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TempField", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TotalJournalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalJournalTime", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TotalJournalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalJournalTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_DisplayHSS", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayHSS", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_DisplayHSS", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayHSS", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Journal] ([CallID], [HEATSeq], [Tracker], [EntryDate], [EntryTime], [EntryText], [JournalType], [DTLastMod], [TempField], [TotalJournalTime], [DisplayHSS], [PMOSecurity]) VALUES (@CallID, @HEATSeq, @Tracker, @EntryDate, @EntryTime, @EntryText, @JournalType, @DTLastMod, @TempField, @TotalJournalTime, @DisplayHSS, @PMOSecurity);\r\nSELECT CallID, HEATSeq, Tracker, EntryDate, EntryTime, EntryText, JournalType, DTLastMod, TempField, TotalJournalTime, DisplayHSS, PMOSecurity FROM Journal WHERE (CallID = @CallID) AND (HEATSeq = @HEATSeq)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EntryTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@EntryText", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryText", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@JournalType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JournalType", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TempField", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TempField", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@TotalJournalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalJournalTime", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@DisplayHSS", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayHSS", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@PMOSecurity", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PMOSecurity", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Journal] SET [CallID] = @CallID, [HEATSeq] = @HEATSeq, [Tracker] = @Tracker, [EntryDate] = @EntryDate, [EntryTime] = @EntryTime, [EntryText] = @EntryText, [JournalType] = @JournalType, [DTLastMod] = @DTLastMod, [TempField] = @TempField, [TotalJournalTime] = @TotalJournalTime, [DisplayHSS] = @DisplayHSS, [PMOSecurity] = @PMOSecurity WHERE (([CallID] = @Original_CallID) AND ([HEATSeq] = @Original_HEATSeq) AND ((@IsNull_Tracker = 1 AND [Tracker] IS NULL) OR ([Tracker] = @Original_Tracker)) AND ((@IsNull_EntryDate = 1 AND [EntryDate] IS NULL) OR ([EntryDate] = @Original_EntryDate)) AND ((@IsNull_EntryTime = 1 AND [EntryTime] IS NULL) OR ([EntryTime] = @Original_EntryTime)) AND ((@IsNull_JournalType = 1 AND [JournalType] IS NULL) OR ([JournalType] = @Original_JournalType)) AND ((@IsNull_DTLastMod = 1 AND [DTLastMod] IS NULL) OR ([DTLastMod] = @Original_DTLastMod)) AND ((@IsNull_TempField = 1 AND [TempField] IS NULL) OR ([TempField] = @Original_TempField)) AND ((@IsNull_TotalJournalTime = 1 AND [TotalJournalTime] IS NULL) OR ([TotalJournalTime] = @Original_TotalJournalTime)) AND ((@IsNull_DisplayHSS = 1 AND [DisplayHSS] IS NULL) OR ([DisplayHSS] = @Original_DisplayHSS)));\r\nSELECT CallID, HEATSeq, Tracker, EntryDate, EntryTime, EntryText, JournalType, DTLastMod, TempField, TotalJournalTime, DisplayHSS, PMOSecurity FROM Journal WHERE (CallID = @CallID) AND (HEATSeq = @HEATSeq)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EntryTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryTime", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EntryText", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryText", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@JournalType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JournalType", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TempField", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TempField", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TotalJournalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalJournalTime", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DisplayHSS", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayHSS", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PMOSecurity", SqlDbType.Text, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "PMOSecurity", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CallID", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CallID", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HEATSeq", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HEATSeq", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Tracker", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Tracker", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Tracker", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EntryDate", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryDate", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EntryDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryDate", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EntryTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryTime", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EntryTime", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "EntryTime", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_JournalType", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JournalType", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_JournalType", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "JournalType", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DTLastMod", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DTLastMod", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TempField", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TempField", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TempField", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TempField", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TotalJournalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalJournalTime", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TotalJournalTime", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "TotalJournalTime", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_DisplayHSS", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayHSS", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_DisplayHSS", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "DisplayHSS", DataRowVersion.Original, false,
                (object) null, "", "", ""));
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
                "SELECT CallID, HEATSeq, Tracker, EntryDate, EntryTime, EntryText, JournalType, DTLastMod, TempField, TotalJournalTime, DisplayHSS, PMOSecurity FROM dbo.Journal";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Fill(HeaTdbDataSet.JournalDataTable dataTable)
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
        public virtual HeaTdbDataSet.JournalDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.JournalDataTable journalDataTable = new HeaTdbDataSet.JournalDataTable();
            Adapter.Fill((DataTable) journalDataTable);
            return journalDataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet.JournalDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Journal");
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return Adapter.Update(new DataRow[1] {dataRow});
        }

        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow[] dataRows)
        {
            return Adapter.Update(dataRows);
        }

        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(string originalCallId, int originalHeatSeq, string originalTracker,
            string originalEntryDate, string originalEntryTime, string originalJournalType, int? originalDtLastMod,
            string originalTempField, int? originalTotalJournalTime, string originalDisplayHss)
        {
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.DeleteCommand.Parameters[0].Value = (object) originalCallId;
            Adapter.DeleteCommand.Parameters[1].Value = (object) originalHeatSeq;
            if (originalTracker == null)
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[3].Value = (object) originalTracker;
            }
            if (originalEntryDate == null)
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[5].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[5].Value = (object) originalEntryDate;
            }
            if (originalEntryTime == null)
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[7].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[7].Value = (object) originalEntryTime;
            }
            if (originalJournalType == null)
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[9].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[9].Value = (object) originalJournalType;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[11].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[10].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[11].Value = (object) DBNull.Value;
            }
            if (originalTempField == null)
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[13].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[12].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[13].Value = (object) originalTempField;
            }
            if (originalTotalJournalTime.HasValue)
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[15].Value = (object) originalTotalJournalTime.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[14].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[15].Value = (object) DBNull.Value;
            }
            if (originalDisplayHss == null)
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[17].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[16].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[17].Value = (object) originalDisplayHss;
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
        public virtual int Insert(string callId, int heatSeq, string tracker, string entryDate, string entryTime,
            string entryText, string journalType, int? dtLastMod, string tempField, int? totalJournalTime,
            string displayHss, string pmoSecurity)
        {
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.InsertCommand.Parameters[0].Value = (object) callId;
            Adapter.InsertCommand.Parameters[1].Value = (object) heatSeq;
            if (tracker == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) tracker;
            if (entryDate == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) entryDate;
            if (entryTime == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) entryTime;
            if (entryText == null)
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) entryText;
            if (journalType == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) journalType;
            if (dtLastMod.HasValue)
                Adapter.InsertCommand.Parameters[7].Value = (object) dtLastMod.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            if (tempField == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) tempField;
            if (totalJournalTime.HasValue)
                Adapter.InsertCommand.Parameters[9].Value = (object) totalJournalTime.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            if (displayHss == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) displayHss;
            if (pmoSecurity == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) pmoSecurity;
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
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public virtual int Update(string callId, int heatSeq, string tracker, string entryDate, string entryTime,
            string entryText, string journalType, int? dtLastMod, string tempField, int? totalJournalTime,
            string displayHss, string pmoSecurity, string originalCallId, int originalHeatSeq, string originalTracker,
            string originalEntryDate, string originalEntryTime, string originalJournalType, int? originalDtLastMod,
            string originalTempField, int? originalTotalJournalTime, string originalDisplayHss)
        {
            if (callId == null)
                throw new ArgumentNullException("callId");
            Adapter.UpdateCommand.Parameters[0].Value = (object) callId;
            Adapter.UpdateCommand.Parameters[1].Value = (object) heatSeq;
            if (tracker == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) tracker;
            if (entryDate == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) entryDate;
            if (entryTime == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) entryTime;
            if (entryText == null)
                Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[5].Value = (object) entryText;
            if (journalType == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) journalType;
            if (dtLastMod.HasValue)
                Adapter.UpdateCommand.Parameters[7].Value = (object) dtLastMod.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            if (tempField == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) tempField;
            if (totalJournalTime.HasValue)
                Adapter.UpdateCommand.Parameters[9].Value = (object) totalJournalTime.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            if (displayHss == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) displayHss;
            if (pmoSecurity == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) pmoSecurity;
            if (originalCallId == null)
                throw new ArgumentNullException("originalCallId");
            Adapter.UpdateCommand.Parameters[12].Value = (object) originalCallId;
            Adapter.UpdateCommand.Parameters[13].Value = (object) originalHeatSeq;
            if (originalTracker == null)
            {
                Adapter.UpdateCommand.Parameters[14].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[15].Value = (object) originalTracker;
            }
            if (originalEntryDate == null)
            {
                Adapter.UpdateCommand.Parameters[16].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[17].Value = (object) originalEntryDate;
            }
            if (originalEntryTime == null)
            {
                Adapter.UpdateCommand.Parameters[18].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[18].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[19].Value = (object) originalEntryTime;
            }
            if (originalJournalType == null)
            {
                Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[21].Value = (object) originalJournalType;
            }
            if (originalDtLastMod.HasValue)
            {
                Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[23].Value = (object) originalDtLastMod.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            }
            if (originalTempField == null)
            {
                Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[25].Value = (object) originalTempField;
            }
            if (originalTotalJournalTime.HasValue)
            {
                Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[27].Value = (object) originalTotalJournalTime.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            }
            if (originalDisplayHss == null)
            {
                Adapter.UpdateCommand.Parameters[28].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[29].Value = (object) originalDisplayHss;
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
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string tracker, string entryDate, string entryTime, string entryText,
            string journalType, int? dtLastMod, string tempField, int? totalJournalTime, string displayHss,
            string pmoSecurity, string originalCallId, int originalHeatSeq, string originalTracker,
            string originalEntryDate, string originalEntryTime, string originalJournalType, int? originalDtLastMod,
            string originalTempField, int? originalTotalJournalTime, string originalDisplayHss)
        {
            return Update(originalCallId, originalHeatSeq, tracker, entryDate, entryTime, entryText, journalType,
                dtLastMod, tempField, totalJournalTime, displayHss, pmoSecurity, originalCallId, originalHeatSeq,
                originalTracker, originalEntryDate, originalEntryTime, originalJournalType, originalDtLastMod,
                originalTempField, originalTotalJournalTime, originalDisplayHss);
        }
    }
}