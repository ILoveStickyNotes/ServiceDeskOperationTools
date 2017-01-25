using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HelpdeskOperationsTools.HEATdbDataSetTableAdapters
{
    [HelpKeyword("vs.data.TableAdapterManager")]
    [DesignerCategory("code")]
    [ToolboxItem(true)]
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    public class TableAdapterManager : Component
    {
        private UpdateOrderOption _updateOrder;
        private AsgnmntTableAdapter _asgnmntTableAdapter;
        private AssigneeTableAdapter _assigneeTableAdapter;
        private AssigneeMasterTableAdapter _assigneeMasterTableAdapter;
        private CalendarStatsTableAdapter _calendarStatsTableAdapter;
        private CallLogTableAdapter _callLogTableAdapter;
        private DetailTableAdapter _detailTableAdapter;
        private FacilitiesTableAdapter _facilitiesTableAdapter;
        private HeatcaiTableAdapter _hEatcaiTableAdapter;
        private HeatLoginStatusTableAdapter _hEatLoginStatusTableAdapter;
        private JournalTableAdapter _journalTableAdapter;
        private ProfileTableAdapter _profileTableAdapter;
        private SapAssetsTableAdapter _sApAssetsTableAdapter;
        private SubsetTableAdapter _subsetTableAdapter;
        private TrackerTableAdapter _trackerTableAdapter;
        private bool _backupDataSetBeforeUpdate;
        private IDbConnection _connection;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public UpdateOrderOption UpdateOrder
        {
            get { return _updateOrder; }
            set { _updateOrder = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [DebuggerNonUserCode]
        public AsgnmntTableAdapter AsgnmntTableAdapter
        {
            get { return _asgnmntTableAdapter; }
            set { _asgnmntTableAdapter = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        public AssigneeTableAdapter AssigneeTableAdapter
        {
            get { return _assigneeTableAdapter; }
            set { _assigneeTableAdapter = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [DebuggerNonUserCode]
        public AssigneeMasterTableAdapter AssigneeMasterTableAdapter
        {
            get { return _assigneeMasterTableAdapter; }
            set { _assigneeMasterTableAdapter = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        public CalendarStatsTableAdapter CalendarStatsTableAdapter
        {
            get { return _calendarStatsTableAdapter; }
            set { _calendarStatsTableAdapter = value; }
        }

        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CallLogTableAdapter CallLogTableAdapter
        {
            get { return _callLogTableAdapter; }
            set { _callLogTableAdapter = value; }
        }

        [DebuggerNonUserCode]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DetailTableAdapter DetailTableAdapter
        {
            get { return _detailTableAdapter; }
            set { _detailTableAdapter = value; }
        }

        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FacilitiesTableAdapter FacilitiesTableAdapter
        {
            get { return _facilitiesTableAdapter; }
            set { _facilitiesTableAdapter = value; }
        }

        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public HeatcaiTableAdapter HeatcaiTableAdapter
        {
            get { return _hEatcaiTableAdapter; }
            set { _hEatcaiTableAdapter = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        public HeatLoginStatusTableAdapter HeatLoginStatusTableAdapter
        {
            get { return _hEatLoginStatusTableAdapter; }
            set { _hEatLoginStatusTableAdapter = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        public JournalTableAdapter JournalTableAdapter
        {
            get { return _journalTableAdapter; }
            set { _journalTableAdapter = value; }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        public ProfileTableAdapter ProfileTableAdapter
        {
            get { return _profileTableAdapter; }
            set { _profileTableAdapter = value; }
        }

        [DebuggerNonUserCode]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public SapAssetsTableAdapter SapAssetsTableAdapter
        {
            get { return _sApAssetsTableAdapter; }
            set { _sApAssetsTableAdapter = value; }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        public SubsetTableAdapter SubsetTableAdapter
        {
            get { return _subsetTableAdapter; }
            set { _subsetTableAdapter = value; }
        }

        [Editor(
             "Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             "System.Drawing.Design.UITypeEditor")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TrackerTableAdapter TrackerTableAdapter
        {
            get { return _trackerTableAdapter; }
            set { _trackerTableAdapter = value; }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool BackupDataSetBeforeUpdate
        {
            get { return _backupDataSetBeforeUpdate; }
            set { _backupDataSetBeforeUpdate = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        [DebuggerNonUserCode]
        public IDbConnection Connection
        {
            get
            {
                if (_connection != null)
                    return _connection;
                if (_asgnmntTableAdapter != null && _asgnmntTableAdapter.Connection != null)
                    return (IDbConnection) _asgnmntTableAdapter.Connection;
                if (_assigneeTableAdapter != null && _assigneeTableAdapter.Connection != null)
                    return (IDbConnection) _assigneeTableAdapter.Connection;
                if (_assigneeMasterTableAdapter != null && _assigneeMasterTableAdapter.Connection != null)
                    return (IDbConnection) _assigneeMasterTableAdapter.Connection;
                if (_calendarStatsTableAdapter != null && _calendarStatsTableAdapter.Connection != null)
                    return (IDbConnection) _calendarStatsTableAdapter.Connection;
                if (_callLogTableAdapter != null && _callLogTableAdapter.Connection != null)
                    return (IDbConnection) _callLogTableAdapter.Connection;
                if (_detailTableAdapter != null && _detailTableAdapter.Connection != null)
                    return (IDbConnection) _detailTableAdapter.Connection;
                if (_facilitiesTableAdapter != null && _facilitiesTableAdapter.Connection != null)
                    return (IDbConnection) _facilitiesTableAdapter.Connection;
                if (_hEatcaiTableAdapter != null && _hEatcaiTableAdapter.Connection != null)
                    return (IDbConnection) _hEatcaiTableAdapter.Connection;
                if (_hEatLoginStatusTableAdapter != null && _hEatLoginStatusTableAdapter.Connection != null)
                    return (IDbConnection) _hEatLoginStatusTableAdapter.Connection;
                if (_journalTableAdapter != null && _journalTableAdapter.Connection != null)
                    return (IDbConnection) _journalTableAdapter.Connection;
                if (_profileTableAdapter != null && _profileTableAdapter.Connection != null)
                    return (IDbConnection) _profileTableAdapter.Connection;
                if (_sApAssetsTableAdapter != null && _sApAssetsTableAdapter.Connection != null)
                    return (IDbConnection) _sApAssetsTableAdapter.Connection;
                if (_subsetTableAdapter != null && _subsetTableAdapter.Connection != null)
                    return (IDbConnection) _subsetTableAdapter.Connection;
                if (_trackerTableAdapter != null && _trackerTableAdapter.Connection != null)
                    return (IDbConnection) _trackerTableAdapter.Connection;
                return (IDbConnection) null;
            }
            set { _connection = value; }
        }

        [Browsable(false)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int TableAdapterInstanceCount
        {
            get
            {
                int num = 0;
                if (_asgnmntTableAdapter != null)
                    ++num;
                if (_assigneeTableAdapter != null)
                    ++num;
                if (_assigneeMasterTableAdapter != null)
                    ++num;
                if (_calendarStatsTableAdapter != null)
                    ++num;
                if (_callLogTableAdapter != null)
                    ++num;
                if (_detailTableAdapter != null)
                    ++num;
                if (_facilitiesTableAdapter != null)
                    ++num;
                if (_hEatcaiTableAdapter != null)
                    ++num;
                if (_hEatLoginStatusTableAdapter != null)
                    ++num;
                if (_journalTableAdapter != null)
                    ++num;
                if (_profileTableAdapter != null)
                    ++num;
                if (_sApAssetsTableAdapter != null)
                    ++num;
                if (_subsetTableAdapter != null)
                    ++num;
                if (_trackerTableAdapter != null)
                    ++num;
                return num;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private int UpdateUpdatedRows(HeaTdbDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
        {
            int num = 0;
            if (_journalTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Journal.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _journalTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_hEatLoginStatusTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.HeatLoginStatus.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _hEatLoginStatusTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_hEatcaiTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Heatcai.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _hEatcaiTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_profileTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Profile.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _profileTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_trackerTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Tracker.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _trackerTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_subsetTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Subset.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _subsetTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_sApAssetsTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.SapAssets.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _sApAssetsTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_assigneeMasterTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.AssigneeMaster.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _assigneeMasterTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_assigneeTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Assignee.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _assigneeTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_asgnmntTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Asgnmnt.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _asgnmntTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_calendarStatsTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.CalendarStats.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _calendarStatsTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_facilitiesTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Facilities.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _facilitiesTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_detailTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.Detail.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _detailTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            if (_callLogTableAdapter != null)
            {
                DataRow[] realUpdatedRows =
                    GetRealUpdatedRows(
                        dataSet.CallLog.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent),
                        allAddedRows);
                if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
                {
                    num += _callLogTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private int UpdateInsertedRows(HeaTdbDataSet dataSet, List<DataRow> allAddedRows)
        {
            int num = 0;
            if (_journalTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Journal.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _journalTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_hEatLoginStatusTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.HeatLoginStatus.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _hEatLoginStatusTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_hEatcaiTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Heatcai.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _hEatcaiTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_profileTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Profile.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _profileTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_trackerTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Tracker.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _trackerTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_subsetTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Subset.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _subsetTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_sApAssetsTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.SapAssets.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _sApAssetsTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_assigneeMasterTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.AssigneeMaster.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _assigneeMasterTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_assigneeTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Assignee.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _assigneeTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_asgnmntTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Asgnmnt.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _asgnmntTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_calendarStatsTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.CalendarStats.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _calendarStatsTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_facilitiesTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Facilities.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _facilitiesTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_detailTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Detail.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _detailTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_callLogTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.CallLog.Select((string) null, (string) null, DataViewRowState.Added);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _callLogTableAdapter.Update(dataRows);
                    allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private int UpdateDeletedRows(HeaTdbDataSet dataSet, List<DataRow> allChangedRows)
        {
            int num = 0;
            if (_callLogTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.CallLog.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _callLogTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_detailTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Detail.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _detailTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_facilitiesTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Facilities.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _facilitiesTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_calendarStatsTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.CalendarStats.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _calendarStatsTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_asgnmntTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Asgnmnt.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _asgnmntTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_assigneeTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Assignee.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _assigneeTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_assigneeMasterTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.AssigneeMaster.Select((string) null, (string) null,
                    DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _assigneeMasterTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_sApAssetsTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.SapAssets.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _sApAssetsTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_subsetTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Subset.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _subsetTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_trackerTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Tracker.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _trackerTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_profileTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Profile.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _profileTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_hEatcaiTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Heatcai.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _hEatcaiTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_hEatLoginStatusTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.HeatLoginStatus.Select((string) null, (string) null,
                    DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _hEatLoginStatusTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            if (_journalTableAdapter != null)
            {
                DataRow[] dataRows = dataSet.Journal.Select((string) null, (string) null, DataViewRowState.Deleted);
                if (dataRows != null && 0 < dataRows.Length)
                {
                    num += _journalTableAdapter.Update(dataRows);
                    allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
        {
            if (updatedRows == null || updatedRows.Length < 1 || (allAddedRows == null || allAddedRows.Count < 1))
                return updatedRows;
            List<DataRow> dataRowList = new List<DataRow>();
            for (int index = 0; index < updatedRows.Length; ++index)
            {
                DataRow updatedRow = updatedRows[index];
                if (!allAddedRows.Contains(updatedRow))
                    dataRowList.Add(updatedRow);
            }
            return dataRowList.ToArray();
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int UpdateAll(HeaTdbDataSet dataSet)
        {
            if (dataSet == null)
                throw new ArgumentNullException("dataSet");
            if (!dataSet.HasChanges())
                return 0;
            if (_asgnmntTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _asgnmntTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_assigneeTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _assigneeTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_assigneeMasterTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _assigneeMasterTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_calendarStatsTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _calendarStatsTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_callLogTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _callLogTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_detailTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _detailTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_facilitiesTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _facilitiesTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_hEatcaiTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _hEatcaiTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_hEatLoginStatusTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _hEatLoginStatusTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_journalTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _journalTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_profileTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _profileTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_sApAssetsTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _sApAssetsTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_subsetTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _subsetTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            if (_trackerTableAdapter != null &&
                !MatchTableAdapterConnection((IDbConnection) _trackerTableAdapter.Connection))
                throw new ArgumentException(
                    "All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            IDbConnection connection = Connection;
            if (connection == null)
                throw new ApplicationException(
                    "TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
            bool flag = false;
            if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
                connection.Close();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                flag = true;
            }
            IDbTransaction dbTransaction = connection.BeginTransaction();
            if (dbTransaction == null)
                throw new ApplicationException(
                    "The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
            List<DataRow> allChangedRows = new List<DataRow>();
            List<DataRow> allAddedRows = new List<DataRow>();
            List<DataAdapter> dataAdapterList = new List<DataAdapter>();
            Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
            int num = 0;
            DataSet dataSet1 = (DataSet) null;
            if (BackupDataSetBeforeUpdate)
            {
                dataSet1 = new DataSet();
                dataSet1.Merge((DataSet) dataSet);
            }
            try
            {
                if (_asgnmntTableAdapter != null)
                {
                    dictionary.Add((object) _asgnmntTableAdapter, (IDbConnection) _asgnmntTableAdapter.Connection);
                    _asgnmntTableAdapter.Connection = (SqlConnection) connection;
                    _asgnmntTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_asgnmntTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _asgnmntTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _asgnmntTableAdapter.Adapter);
                    }
                }
                if (_assigneeTableAdapter != null)
                {
                    dictionary.Add((object) _assigneeTableAdapter, (IDbConnection) _assigneeTableAdapter.Connection);
                    _assigneeTableAdapter.Connection = (SqlConnection) connection;
                    _assigneeTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_assigneeTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _assigneeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _assigneeTableAdapter.Adapter);
                    }
                }
                if (_assigneeMasterTableAdapter != null)
                {
                    dictionary.Add((object) _assigneeMasterTableAdapter,
                        (IDbConnection) _assigneeMasterTableAdapter.Connection);
                    _assigneeMasterTableAdapter.Connection = (SqlConnection) connection;
                    _assigneeMasterTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_assigneeMasterTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _assigneeMasterTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _assigneeMasterTableAdapter.Adapter);
                    }
                }
                if (_calendarStatsTableAdapter != null)
                {
                    dictionary.Add((object) _calendarStatsTableAdapter,
                        (IDbConnection) _calendarStatsTableAdapter.Connection);
                    _calendarStatsTableAdapter.Connection = (SqlConnection) connection;
                    _calendarStatsTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_calendarStatsTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _calendarStatsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _calendarStatsTableAdapter.Adapter);
                    }
                }
                if (_callLogTableAdapter != null)
                {
                    dictionary.Add((object) _callLogTableAdapter, (IDbConnection) _callLogTableAdapter.Connection);
                    _callLogTableAdapter.Connection = (SqlConnection) connection;
                    _callLogTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_callLogTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _callLogTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _callLogTableAdapter.Adapter);
                    }
                }
                if (_detailTableAdapter != null)
                {
                    dictionary.Add((object) _detailTableAdapter, (IDbConnection) _detailTableAdapter.Connection);
                    _detailTableAdapter.Connection = (SqlConnection) connection;
                    _detailTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_detailTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _detailTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _detailTableAdapter.Adapter);
                    }
                }
                if (_facilitiesTableAdapter != null)
                {
                    dictionary.Add((object) _facilitiesTableAdapter, (IDbConnection) _facilitiesTableAdapter.Connection);
                    _facilitiesTableAdapter.Connection = (SqlConnection) connection;
                    _facilitiesTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_facilitiesTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _facilitiesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _facilitiesTableAdapter.Adapter);
                    }
                }
                if (_hEatcaiTableAdapter != null)
                {
                    dictionary.Add((object) _hEatcaiTableAdapter, (IDbConnection) _hEatcaiTableAdapter.Connection);
                    _hEatcaiTableAdapter.Connection = (SqlConnection) connection;
                    _hEatcaiTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_hEatcaiTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _hEatcaiTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _hEatcaiTableAdapter.Adapter);
                    }
                }
                if (_hEatLoginStatusTableAdapter != null)
                {
                    dictionary.Add((object) _hEatLoginStatusTableAdapter,
                        (IDbConnection) _hEatLoginStatusTableAdapter.Connection);
                    _hEatLoginStatusTableAdapter.Connection = (SqlConnection) connection;
                    _hEatLoginStatusTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_hEatLoginStatusTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _hEatLoginStatusTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _hEatLoginStatusTableAdapter.Adapter);
                    }
                }
                if (_journalTableAdapter != null)
                {
                    dictionary.Add((object) _journalTableAdapter, (IDbConnection) _journalTableAdapter.Connection);
                    _journalTableAdapter.Connection = (SqlConnection) connection;
                    _journalTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_journalTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _journalTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _journalTableAdapter.Adapter);
                    }
                }
                if (_profileTableAdapter != null)
                {
                    dictionary.Add((object) _profileTableAdapter, (IDbConnection) _profileTableAdapter.Connection);
                    _profileTableAdapter.Connection = (SqlConnection) connection;
                    _profileTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_profileTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _profileTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _profileTableAdapter.Adapter);
                    }
                }
                if (_sApAssetsTableAdapter != null)
                {
                    dictionary.Add((object) _sApAssetsTableAdapter, (IDbConnection) _sApAssetsTableAdapter.Connection);
                    _sApAssetsTableAdapter.Connection = (SqlConnection) connection;
                    _sApAssetsTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_sApAssetsTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _sApAssetsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _sApAssetsTableAdapter.Adapter);
                    }
                }
                if (_subsetTableAdapter != null)
                {
                    dictionary.Add((object) _subsetTableAdapter, (IDbConnection) _subsetTableAdapter.Connection);
                    _subsetTableAdapter.Connection = (SqlConnection) connection;
                    _subsetTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_subsetTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _subsetTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _subsetTableAdapter.Adapter);
                    }
                }
                if (_trackerTableAdapter != null)
                {
                    dictionary.Add((object) _trackerTableAdapter, (IDbConnection) _trackerTableAdapter.Connection);
                    _trackerTableAdapter.Connection = (SqlConnection) connection;
                    _trackerTableAdapter.Transaction = (SqlTransaction) dbTransaction;
                    if (_trackerTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _trackerTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        dataAdapterList.Add((DataAdapter) _trackerTableAdapter.Adapter);
                    }
                }
                if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
                {
                    num += UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                    num += UpdateInsertedRows(dataSet, allAddedRows);
                }
                else
                {
                    num += UpdateInsertedRows(dataSet, allAddedRows);
                    num += UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                }
                num += UpdateDeletedRows(dataSet, allChangedRows);
                dbTransaction.Commit();
                if (0 < allAddedRows.Count)
                {
                    DataRow[] array = new DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(array);
                    for (int index = 0; index < array.Length; ++index)
                        array[index].AcceptChanges();
                }
                if (0 < allChangedRows.Count)
                {
                    DataRow[] array = new DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(array);
                    for (int index = 0; index < array.Length; ++index)
                        array[index].AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                if (BackupDataSetBeforeUpdate)
                {
                    dataSet.Clear();
                    dataSet.Merge(dataSet1);
                }
                else if (0 < allAddedRows.Count)
                {
                    DataRow[] array = new DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(array);
                    for (int index = 0; index < array.Length; ++index)
                    {
                        DataRow dataRow = array[index];
                        dataRow.AcceptChanges();
                        dataRow.SetAdded();
                    }
                }
                throw ex;
            }
            finally
            {
                if (flag)
                    connection.Close();
                if (_asgnmntTableAdapter != null)
                {
                    _asgnmntTableAdapter.Connection = (SqlConnection) dictionary[(object) _asgnmntTableAdapter];
                    _asgnmntTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_assigneeTableAdapter != null)
                {
                    _assigneeTableAdapter.Connection = (SqlConnection) dictionary[(object) _assigneeTableAdapter];
                    _assigneeTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_assigneeMasterTableAdapter != null)
                {
                    _assigneeMasterTableAdapter.Connection =
                        (SqlConnection) dictionary[(object) _assigneeMasterTableAdapter];
                    _assigneeMasterTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_calendarStatsTableAdapter != null)
                {
                    _calendarStatsTableAdapter.Connection =
                        (SqlConnection) dictionary[(object) _calendarStatsTableAdapter];
                    _calendarStatsTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_callLogTableAdapter != null)
                {
                    _callLogTableAdapter.Connection = (SqlConnection) dictionary[(object) _callLogTableAdapter];
                    _callLogTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_detailTableAdapter != null)
                {
                    _detailTableAdapter.Connection = (SqlConnection) dictionary[(object) _detailTableAdapter];
                    _detailTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_facilitiesTableAdapter != null)
                {
                    _facilitiesTableAdapter.Connection = (SqlConnection) dictionary[(object) _facilitiesTableAdapter];
                    _facilitiesTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_hEatcaiTableAdapter != null)
                {
                    _hEatcaiTableAdapter.Connection = (SqlConnection) dictionary[(object) _hEatcaiTableAdapter];
                    _hEatcaiTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_hEatLoginStatusTableAdapter != null)
                {
                    _hEatLoginStatusTableAdapter.Connection =
                        (SqlConnection) dictionary[(object) _hEatLoginStatusTableAdapter];
                    _hEatLoginStatusTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_journalTableAdapter != null)
                {
                    _journalTableAdapter.Connection = (SqlConnection) dictionary[(object) _journalTableAdapter];
                    _journalTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_profileTableAdapter != null)
                {
                    _profileTableAdapter.Connection = (SqlConnection) dictionary[(object) _profileTableAdapter];
                    _profileTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_sApAssetsTableAdapter != null)
                {
                    _sApAssetsTableAdapter.Connection = (SqlConnection) dictionary[(object) _sApAssetsTableAdapter];
                    _sApAssetsTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_subsetTableAdapter != null)
                {
                    _subsetTableAdapter.Connection = (SqlConnection) dictionary[(object) _subsetTableAdapter];
                    _subsetTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (_trackerTableAdapter != null)
                {
                    _trackerTableAdapter.Connection = (SqlConnection) dictionary[(object) _trackerTableAdapter];
                    _trackerTableAdapter.Transaction = (SqlTransaction) null;
                }
                if (0 < dataAdapterList.Count)
                {
                    DataAdapter[] array = new DataAdapter[dataAdapterList.Count];
                    dataAdapterList.CopyTo(array);
                    for (int index = 0; index < array.Length; ++index)
                        array[index].AcceptChangesDuringUpdate = true;
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
        {
            Array.Sort<DataRow>(rows, (IComparer<DataRow>) new SelfReferenceComparer(relation, childFirst));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
        {
            return _connection != null || Connection == null ||
                   (inputConnection == null ||
                    string.Equals(Connection.ConnectionString, inputConnection.ConnectionString,
                        StringComparison.Ordinal));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption
        {
            InsertUpdateDelete,
            UpdateInsertDelete,
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : IComparer<DataRow>
        {
            private DataRelation _relation;
            private int _childFirst;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal SelfReferenceComparer(DataRelation relation, bool childFirst)
            {
                _relation = relation;
                if (childFirst)
                    _childFirst = -1;
                else
                    _childFirst = 1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private DataRow GetRoot(DataRow row, out int distance)
            {
                DataRow dataRow = row;
                distance = 0;
                IDictionary<DataRow, DataRow> dictionary =
                    (IDictionary<DataRow, DataRow>) new Dictionary<DataRow, DataRow>();
                dictionary[row] = row;
                for (DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Default);
                    parentRow != null && !dictionary.ContainsKey(parentRow);
                    parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default))
                {
                    distance = distance + 1;
                    dataRow = parentRow;
                    dictionary[parentRow] = parentRow;
                }
                if (distance == 0)
                {
                    dictionary.Clear();
                    dictionary[row] = row;
                    for (DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Original);
                        parentRow != null && !dictionary.ContainsKey(parentRow);
                        parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original))
                    {
                        distance = distance + 1;
                        dataRow = parentRow;
                        dictionary[parentRow] = parentRow;
                    }
                }
                return dataRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int Compare(DataRow row1, DataRow row2)
            {
                if (ReferenceEquals((object) row1, (object) row2))
                    return 0;
                if (row1 == null)
                    return -1;
                if (row2 == null)
                    return 1;
                int distance1 = 0;
                DataRow root1 = GetRoot(row1, out distance1);
                int distance2 = 0;
                DataRow root2 = GetRoot(row2, out distance2);
                if (ReferenceEquals((object) root1, (object) root2))
                    return _childFirst*distance1.CompareTo(distance2);
                return root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2) ? -1 : 1;
            }
        }
    }
}