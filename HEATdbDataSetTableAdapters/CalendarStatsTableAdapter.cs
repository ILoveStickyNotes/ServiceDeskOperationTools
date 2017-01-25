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
    public class CalendarStatsTableAdapter : Component
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
        public CalendarStatsTableAdapter()
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
                DataSetTable = "CalendarStats",
                ColumnMappings =
                {
                    {
                        "ID",
                        "ID"
                    },
                    {
                        "CDate",
                        "CDate"
                    },
                    {
                        "CalDate",
                        "CalDate"
                    },
                    {
                        "CalYear",
                        "CalYear"
                    },
                    {
                        "CalFY",
                        "CalFY"
                    },
                    {
                        "CalQuarter",
                        "CalQuarter"
                    },
                    {
                        "CMonth",
                        "CMonth"
                    },
                    {
                        "CalMonth",
                        "CalMonth"
                    },
                    {
                        "CalFM",
                        "CalFM"
                    },
                    {
                        "CalYearMonth",
                        "CalYearMonth"
                    },
                    {
                        "CalNameOfMonth",
                        "CalNameOfMonth"
                    },
                    {
                        "CalShortNameOfMonth",
                        "CalShortNameOfMonth"
                    },
                    {
                        "CalDayOfYear",
                        "CalDayOfYear"
                    },
                    {
                        "CalDay",
                        "CalDay"
                    },
                    {
                        "CalWeek",
                        "CalWeek"
                    },
                    {
                        "CalDayOfWeek",
                        "CalDayOfWeek"
                    },
                    {
                        "CalWeekOf",
                        "CalWeekOf"
                    },
                    {
                        "CalWeekIsOdd",
                        "CalWeekIsOdd"
                    },
                    {
                        "CalDayOfMonth",
                        "CalDayOfMonth"
                    },
                    {
                        "CalTrimester",
                        "CalTrimester"
                    },
                    {
                        "CalIsWeekday",
                        "CalIsWeekday"
                    },
                    {
                        "CalIsWorkday",
                        "CalIsWorkday"
                    }
                }
            });
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[CalendarStats] ([ID], [CDate], [CalDate], [CalYear], [CalFY], [CalQuarter], [CMonth], [CalMonth], [CalFM], [CalYearMonth], [CalNameOfMonth], [CalShortNameOfMonth], [CalDayOfYear], [CalDay], [CalWeek], [CalDayOfWeek], [CalWeekOf], [CalWeekIsOdd], [CalDayOfMonth], [CalTrimester], [CalIsWeekday], [CalIsWorkday]) VALUES (@ID, @CDate, @CalDate, @CalYear, @CalFY, @CalQuarter, @CMonth, @CalMonth, @CalFM, @CalYearMonth, @CalNameOfMonth, @CalShortNameOfMonth, @CalDayOfYear, @CalDay, @CalWeek, @CalDayOfWeek, @CalWeekOf, @CalWeekIsOdd, @CalDayOfMonth, @CalTrimester, @CalIsWeekday, @CalIsWorkday)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 0, ParameterDirection.Input,
                (byte) 10, (byte) 0, "ID", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CDate", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CDate", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalDate", SqlDbType.DateTime, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalDate", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalYear", SqlDbType.SmallInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalYear", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalFY", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalFY", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalQuarter", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalQuarter", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CMonth", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CMonth", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalMonth", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalMonth", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalFM", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalFM", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalYearMonth", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalYearMonth", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalNameOfMonth", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalNameOfMonth", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalShortNameOfMonth", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalShortNameOfMonth", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalDayOfYear", SqlDbType.SmallInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalDayOfYear", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalDay", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalDay", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalWeek", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalWeek", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalDayOfWeek", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalDayOfWeek", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalWeekOf", SqlDbType.DateTime, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalWeekOf", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalWeekIsOdd", SqlDbType.Bit, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalWeekIsOdd", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalDayOfMonth", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalDayOfMonth", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalTrimester", SqlDbType.TinyInt, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalTrimester", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalIsWeekday", SqlDbType.Bit, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalIsWeekday", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@CalIsWorkday", SqlDbType.Bit, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "CalIsWorkday", DataRowVersion.Current, false,
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
                "SELECT ID, CDate, CalDate, CalYear, CalFY, CalQuarter, CMonth, CalMonth, CalFM, CalYearMonth, CalNameOfMonth, CalShortNameOfMonth, CalDayOfYear, CalDay, CalWeek, CalDayOfWeek, CalWeekOf, CalWeekIsOdd, CalDayOfMonth, CalTrimester, CalIsWeekday, CalIsWorkday FROM dbo.CalendarStats";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        public virtual int Fill(HeaTdbDataSet.CalendarStatsDataTable dataTable)
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
        public virtual HeaTdbDataSet.CalendarStatsDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.CalendarStatsDataTable calendarStatsDataTable = new HeaTdbDataSet.CalendarStatsDataTable();
            Adapter.Fill((DataTable) calendarStatsDataTable);
            return calendarStatsDataTable;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(HeaTdbDataSet.CalendarStatsDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "CalendarStats");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [HelpKeyword("vs.data.TableAdapter")]
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

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(Decimal id, string cDate, DateTime? calDate, short? calYear, string calFy,
            byte? calQuarter, string cMonth, byte? calMonth, byte? calFm, string calYearMonth, string calNameOfMonth,
            string calShortNameOfMonth, short? calDayOfYear, byte? calDay, byte? calWeek, byte? calDayOfWeek,
            DateTime? calWeekOf, bool? calWeekIsOdd, byte? calDayOfMonth, byte? calTrimester, bool? calIsWeekday,
            bool? calIsWorkday)
        {
            Adapter.InsertCommand.Parameters[0].Value = (object) id;
            if (cDate == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) cDate;
            if (calDate.HasValue)
                Adapter.InsertCommand.Parameters[2].Value = (object) calDate.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            if (calYear.HasValue)
                Adapter.InsertCommand.Parameters[3].Value = (object) calYear.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            if (calFy == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) calFy;
            if (calQuarter.HasValue)
                Adapter.InsertCommand.Parameters[5].Value = (object) calQuarter.Value;
            else
                Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
            if (cMonth == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) cMonth;
            if (calMonth.HasValue)
                Adapter.InsertCommand.Parameters[7].Value = (object) calMonth.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            if (calFm.HasValue)
                Adapter.InsertCommand.Parameters[8].Value = (object) calFm.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            if (calYearMonth == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) calYearMonth;
            if (calNameOfMonth == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) calNameOfMonth;
            if (calShortNameOfMonth == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) calShortNameOfMonth;
            if (calDayOfYear.HasValue)
                Adapter.InsertCommand.Parameters[12].Value = (object) calDayOfYear.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            if (calDay.HasValue)
                Adapter.InsertCommand.Parameters[13].Value = (object) calDay.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            if (calWeek.HasValue)
                Adapter.InsertCommand.Parameters[14].Value = (object) calWeek.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            if (calDayOfWeek.HasValue)
                Adapter.InsertCommand.Parameters[15].Value = (object) calDayOfWeek.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            if (calWeekOf.HasValue)
                Adapter.InsertCommand.Parameters[16].Value = (object) calWeekOf.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            if (calWeekIsOdd.HasValue)
                Adapter.InsertCommand.Parameters[17].Value = (object) calWeekIsOdd.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            if (calDayOfMonth.HasValue)
                Adapter.InsertCommand.Parameters[18].Value = (object) calDayOfMonth.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            if (calTrimester.HasValue)
                Adapter.InsertCommand.Parameters[19].Value = (object) calTrimester.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            if (calIsWeekday.HasValue)
                Adapter.InsertCommand.Parameters[20].Value = (object) calIsWeekday.Value;
            else
                Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
            if (calIsWorkday.HasValue)
                Adapter.InsertCommand.Parameters[21].Value = (object) calIsWorkday.Value;
            else
                Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
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