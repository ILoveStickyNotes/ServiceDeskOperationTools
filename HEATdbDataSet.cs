





using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HelpdeskOperationsTools
{
    [XmlRoot("HEATdbDataSet")]
    [ToolboxItem(true)]
    [XmlSchemaProvider("GetTypedDataSetSchema")]
    [DesignerCategory("code")]
    [HelpKeyword("vs.data.DataSet")]
    [Serializable]
    public class HeaTdbDataSet : DataSet
    {
        private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        private AsgnmntDataTable _tableAsgnmnt;
        private AssigneeDataTable _tableAssignee;
        private AssigneeMasterDataTable _tableAssigneeMaster;
        private CalendarStatsDataTable _tableCalendarStats;
        private CallLogDataTable _tableCallLog;
        private DetailDataTable _tableDetail;
        private FacilitiesDataTable _tableFacilities;
        private HeatcaiDataTable _tableHeatcai;
        private HeatLoginStatusDataTable _tableHeatLoginStatus;
        private JournalDataTable _tableJournal;
        private ProfileDataTable _tableProfile;
        private SapAssetsDataTable _tableSapAssets;
        private SubsetDataTable _tableSubset;
        private TrackerDataTable _tableTracker;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AsgnmntDataTable Asgnmnt
        {
            get { return _tableAsgnmnt; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        [DebuggerNonUserCode]
        public AssigneeDataTable Assignee
        {
            get { return _tableAssignee; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        [DebuggerNonUserCode]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AssigneeMasterDataTable AssigneeMaster
        {
            get { return _tableAssigneeMaster; }
        }

        [Browsable(false)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [DebuggerNonUserCode]
        public CalendarStatsDataTable CalendarStats
        {
            get { return _tableCalendarStats; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [DebuggerNonUserCode]
        public CallLogDataTable CallLog
        {
            get { return _tableCallLog; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DetailDataTable Detail
        {
            get { return _tableDetail; }
        }

        [DebuggerNonUserCode]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FacilitiesDataTable Facilities
        {
            get { return _tableFacilities; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public HeatcaiDataTable Heatcai
        {
            get { return _tableHeatcai; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        public HeatLoginStatusDataTable HeatLoginStatus
        {
            get { return _tableHeatLoginStatus; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public JournalDataTable Journal
        {
            get { return _tableJournal; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [DebuggerNonUserCode]
        public ProfileDataTable Profile
        {
            get { return _tableProfile; }
        }

        [DebuggerNonUserCode]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        public SapAssetsDataTable SapAssets
        {
            get { return _tableSapAssets; }
        }

        [DebuggerNonUserCode]
        [Browsable(false)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SubsetDataTable Subset
        {
            get { return _tableSubset; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TrackerDataTable Tracker
        {
            get { return _tableTracker; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public override SchemaSerializationMode SchemaSerializationMode
        {
            get { return _schemaSerializationMode; }
            set { _schemaSerializationMode = value; }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataTableCollection Tables
        {
            get { return base.Tables; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public new DataRelationCollection Relations
        {
            get { return base.Relations; }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public HeaTdbDataSet()
        {
            BeginInit();
            InitClass();
            var changeEventHandler = new CollectionChangeEventHandler(SchemaChanged);
            base.Tables.CollectionChanged += changeEventHandler;
            base.Relations.CollectionChanged += changeEventHandler;
            EndInit();
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected HeaTdbDataSet(SerializationInfo info, StreamingContext context)
            : base(info, context, false)
        {
            if (IsBinarySerialized(info, context))
            {
                InitVars(false);
                var changeEventHandler = new CollectionChangeEventHandler(SchemaChanged);
                Tables.CollectionChanged += changeEventHandler;
                Relations.CollectionChanged += changeEventHandler;
            }
            else
            {
                var s = (string) info.GetValue("XmlSchema", typeof(string));
                if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
                {
                    var dataSet = new DataSet();
                    dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
                    if (dataSet.Tables["Asgnmnt"] != null)
                        base.Tables.Add((DataTable) new AsgnmntDataTable(dataSet.Tables["Asgnmnt"]));
                    if (dataSet.Tables["Assignee"] != null)
                        base.Tables.Add((DataTable) new AssigneeDataTable(dataSet.Tables["Assignee"]));
                    if (dataSet.Tables["AssigneeMaster"] != null)
                        base.Tables.Add(
                            (DataTable) new AssigneeMasterDataTable(dataSet.Tables["AssigneeMaster"]));
                    if (dataSet.Tables["CalendarStats"] != null)
                        base.Tables.Add(
                            (DataTable) new CalendarStatsDataTable(dataSet.Tables["CalendarStats"]));
                    if (dataSet.Tables["CallLog"] != null)
                        base.Tables.Add((DataTable) new CallLogDataTable(dataSet.Tables["CallLog"]));
                    if (dataSet.Tables["Detail"] != null)
                        base.Tables.Add((DataTable) new DetailDataTable(dataSet.Tables["Detail"]));
                    if (dataSet.Tables["Facilities"] != null)
                        base.Tables.Add((DataTable) new FacilitiesDataTable(dataSet.Tables["Facilities"]));
                    if (dataSet.Tables["HEATCAI"] != null)
                        base.Tables.Add((DataTable) new HeatcaiDataTable(dataSet.Tables["HEATCAI"]));
                    if (dataSet.Tables["HEATLoginStatus"] != null)
                        base.Tables.Add(
                            (DataTable) new HeatLoginStatusDataTable(dataSet.Tables["HEATLoginStatus"]));
                    if (dataSet.Tables["Journal"] != null)
                        base.Tables.Add((DataTable) new JournalDataTable(dataSet.Tables["Journal"]));
                    if (dataSet.Tables["Profile"] != null)
                        base.Tables.Add((DataTable) new ProfileDataTable(dataSet.Tables["Profile"]));
                    if (dataSet.Tables["SAPAssets"] != null)
                        base.Tables.Add((DataTable) new SapAssetsDataTable(dataSet.Tables["SAPAssets"]));
                    if (dataSet.Tables["Subset"] != null)
                        base.Tables.Add((DataTable) new SubsetDataTable(dataSet.Tables["Subset"]));
                    if (dataSet.Tables["Tracker"] != null)
                        base.Tables.Add((DataTable) new TrackerDataTable(dataSet.Tables["Tracker"]));
                    DataSetName = dataSet.DataSetName;
                    Prefix = dataSet.Prefix;
                    Namespace = dataSet.Namespace;
                    Locale = dataSet.Locale;
                    CaseSensitive = dataSet.CaseSensitive;
                    EnforceConstraints = dataSet.EnforceConstraints;
                    Merge(dataSet, false, MissingSchemaAction.Add);
                    InitVars();
                }
                else
                    ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
                GetSerializationData(info, context);
                var changeEventHandler = new CollectionChangeEventHandler(SchemaChanged);
                base.Tables.CollectionChanged += changeEventHandler;
                Relations.CollectionChanged += changeEventHandler;
            }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            BeginInit();
            InitClass();
            EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        public override DataSet Clone()
        {
            var heaTdbDataSet = (HeaTdbDataSet) base.Clone();
            heaTdbDataSet.InitVars();
            heaTdbDataSet.SchemaSerializationMode = SchemaSerializationMode;
            return (DataSet) heaTdbDataSet;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
            {
                Reset();
                var dataSet = new DataSet();
                var num = (int) dataSet.ReadXml(reader);
                if (dataSet.Tables["Asgnmnt"] != null)
                    base.Tables.Add((DataTable) new AsgnmntDataTable(dataSet.Tables["Asgnmnt"]));
                if (dataSet.Tables["Assignee"] != null)
                    base.Tables.Add((DataTable) new AssigneeDataTable(dataSet.Tables["Assignee"]));
                if (dataSet.Tables["AssigneeMaster"] != null)
                    base.Tables.Add(
                        (DataTable) new AssigneeMasterDataTable(dataSet.Tables["AssigneeMaster"]));
                if (dataSet.Tables["CalendarStats"] != null)
                    base.Tables.Add(
                        (DataTable) new CalendarStatsDataTable(dataSet.Tables["CalendarStats"]));
                if (dataSet.Tables["CallLog"] != null)
                    base.Tables.Add((DataTable) new CallLogDataTable(dataSet.Tables["CallLog"]));
                if (dataSet.Tables["Detail"] != null)
                    base.Tables.Add((DataTable) new DetailDataTable(dataSet.Tables["Detail"]));
                if (dataSet.Tables["Facilities"] != null)
                    base.Tables.Add((DataTable) new FacilitiesDataTable(dataSet.Tables["Facilities"]));
                if (dataSet.Tables["HEATCAI"] != null)
                    base.Tables.Add((DataTable) new HeatcaiDataTable(dataSet.Tables["HEATCAI"]));
                if (dataSet.Tables["HEATLoginStatus"] != null)
                    base.Tables.Add(
                        (DataTable) new HeatLoginStatusDataTable(dataSet.Tables["HEATLoginStatus"]));
                if (dataSet.Tables["Journal"] != null)
                    base.Tables.Add((DataTable) new JournalDataTable(dataSet.Tables["Journal"]));
                if (dataSet.Tables["Profile"] != null)
                    base.Tables.Add((DataTable) new ProfileDataTable(dataSet.Tables["Profile"]));
                if (dataSet.Tables["SAPAssets"] != null)
                    base.Tables.Add((DataTable) new SapAssetsDataTable(dataSet.Tables["SAPAssets"]));
                if (dataSet.Tables["Subset"] != null)
                    base.Tables.Add((DataTable) new SubsetDataTable(dataSet.Tables["Subset"]));
                if (dataSet.Tables["Tracker"] != null)
                    base.Tables.Add((DataTable) new TrackerDataTable(dataSet.Tables["Tracker"]));
                DataSetName = dataSet.DataSetName;
                Prefix = dataSet.Prefix;
                Namespace = dataSet.Namespace;
                Locale = dataSet.Locale;
                CaseSensitive = dataSet.CaseSensitive;
                EnforceConstraints = dataSet.EnforceConstraints;
                Merge(dataSet, false, MissingSchemaAction.Add);
                InitVars();
            }
            else
            {
                var num = (int) ReadXml(reader);
                InitVars();
            }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override XmlSchema GetSchemaSerializable()
        {
            var memoryStream = new MemoryStream();
            WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
            memoryStream.Position = 0L;
            return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        internal void InitVars()
        {
            InitVars(true);
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable)
        {
            _tableAsgnmnt = (AsgnmntDataTable) base.Tables["Asgnmnt"];
            if (initTable && (_tableAsgnmnt != null))
                _tableAsgnmnt.InitVars();
            _tableAssignee = (AssigneeDataTable) base.Tables["Assignee"];
            if (initTable && (_tableAssignee != null))
                _tableAssignee.InitVars();
            _tableAssigneeMaster = (AssigneeMasterDataTable) base.Tables["AssigneeMaster"];
            if (initTable && (_tableAssigneeMaster != null))
                _tableAssigneeMaster.InitVars();
            _tableCalendarStats = (CalendarStatsDataTable) base.Tables["CalendarStats"];
            if (initTable && (_tableCalendarStats != null))
                _tableCalendarStats.InitVars();
            _tableCallLog = (CallLogDataTable) base.Tables["CallLog"];
            if (initTable && (_tableCallLog != null))
                _tableCallLog.InitVars();
            _tableDetail = (DetailDataTable) base.Tables["Detail"];
            if (initTable && (_tableDetail != null))
                _tableDetail.InitVars();
            _tableFacilities = (FacilitiesDataTable) base.Tables["Facilities"];
            if (initTable && (_tableFacilities != null))
                _tableFacilities.InitVars();
            _tableHeatcai = (HeatcaiDataTable) base.Tables["HEATCAI"];
            if (initTable && (_tableHeatcai != null))
                _tableHeatcai.InitVars();
            _tableHeatLoginStatus = (HeatLoginStatusDataTable) base.Tables["HEATLoginStatus"];
            if (initTable && (_tableHeatLoginStatus != null))
                _tableHeatLoginStatus.InitVars();
            _tableJournal = (JournalDataTable) base.Tables["Journal"];
            if (initTable && (_tableJournal != null))
                _tableJournal.InitVars();
            _tableProfile = (ProfileDataTable) base.Tables["Profile"];
            if (initTable && (_tableProfile != null))
                _tableProfile.InitVars();
            _tableSapAssets = (SapAssetsDataTable) base.Tables["SAPAssets"];
            if (initTable && (_tableSapAssets != null))
                _tableSapAssets.InitVars();
            _tableSubset = (SubsetDataTable) base.Tables["Subset"];
            if (initTable && (_tableSubset != null))
                _tableSubset.InitVars();
            _tableTracker = (TrackerDataTable) base.Tables["Tracker"];
            if (!initTable || (_tableTracker == null))
                return;
            _tableTracker.InitVars();
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            DataSetName = "HEATdbDataSet";
            Prefix = "";
            Namespace = "http://tempuri.org/HEATdbDataSet.xsd";
            EnforceConstraints = true;
            SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            _tableAsgnmnt = new AsgnmntDataTable();
            base.Tables.Add((DataTable) _tableAsgnmnt);
            _tableAssignee = new AssigneeDataTable();
            base.Tables.Add((DataTable) _tableAssignee);
            _tableAssigneeMaster = new AssigneeMasterDataTable();
            base.Tables.Add((DataTable) _tableAssigneeMaster);
            _tableCalendarStats = new CalendarStatsDataTable();
            base.Tables.Add((DataTable) _tableCalendarStats);
            _tableCallLog = new CallLogDataTable();
            base.Tables.Add((DataTable) _tableCallLog);
            _tableDetail = new DetailDataTable();
            base.Tables.Add((DataTable) _tableDetail);
            _tableFacilities = new FacilitiesDataTable();
            base.Tables.Add((DataTable) _tableFacilities);
            _tableHeatcai = new HeatcaiDataTable();
            base.Tables.Add((DataTable) _tableHeatcai);
            _tableHeatLoginStatus = new HeatLoginStatusDataTable();
            base.Tables.Add((DataTable) _tableHeatLoginStatus);
            _tableJournal = new JournalDataTable();
            base.Tables.Add((DataTable) _tableJournal);
            _tableProfile = new ProfileDataTable();
            base.Tables.Add((DataTable) _tableProfile);
            _tableSapAssets = new SapAssetsDataTable();
            base.Tables.Add((DataTable) _tableSapAssets);
            _tableSubset = new SubsetDataTable();
            base.Tables.Add((DataTable) _tableSubset);
            _tableTracker = new TrackerDataTable();
            base.Tables.Add((DataTable) _tableTracker);
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeAsgnmnt()
        {
            return false;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeAssignee()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeAssigneeMaster()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeCalendarStats()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeCallLog()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeDetail()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeFacilities()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeHeatcai()
        {
            return false;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeHeatLoginStatus()
        {
            return false;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeJournal()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeProfile()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeSapAssets()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeSubset()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        private bool ShouldSerializeTracker()
        {
            return false;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action != CollectionChangeAction.Remove)
                return;
            InitVars();
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
        {
            var heaTdbDataSet = new HeaTdbDataSet();
            var schemaComplexType = new XmlSchemaComplexType();
            var xmlSchemaSequence = new XmlSchemaSequence();
            xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
            {
                Namespace = heaTdbDataSet.Namespace
            });
            schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
            var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
            if (xs.Contains(schemaSerializable.TargetNamespace))
            {
                var memoryStream1 = new MemoryStream();
                var memoryStream2 = new MemoryStream();
                try
                {
                    schemaSerializable.Write((Stream) memoryStream1);
                    foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                    {
                        memoryStream2.SetLength(0L);
                        schema.Write((Stream) memoryStream2);
                        if (memoryStream1.Length == memoryStream2.Length)
                        {
                            memoryStream1.Position = 0L;
                            memoryStream2.Position = 0L;
                            do
                            {
                                ;
                            } while ((memoryStream1.Position != memoryStream1.Length) &&
                                     (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                            if (memoryStream1.Position == memoryStream1.Length)
                                return schemaComplexType;
                        }
                    }
                }
                finally
                {
                    if (memoryStream1 != null)
                        memoryStream1.Close();
                    if (memoryStream2 != null)
                        memoryStream2.Close();
                }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void AsgnmntRowChangeEventHandler(object sender, AsgnmntRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void AssigneeRowChangeEventHandler(object sender, AssigneeRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void AssigneeMasterRowChangeEventHandler(
            object sender, AssigneeMasterRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CalendarStatsRowChangeEventHandler(
            object sender, CalendarStatsRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CallLogRowChangeEventHandler(object sender, CallLogRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void DetailRowChangeEventHandler(object sender, DetailRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void FacilitiesRowChangeEventHandler(object sender, FacilitiesRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void HeatcaiRowChangeEventHandler(object sender, HeatcaiRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void HeatLoginStatusRowChangeEventHandler(
            object sender, HeatLoginStatusRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void JournalRowChangeEventHandler(object sender, JournalRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void ProfileRowChangeEventHandler(object sender, ProfileRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void SapAssetsRowChangeEventHandler(object sender, SapAssetsRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void SubsetRowChangeEventHandler(object sender, SubsetRowChangeEvent e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void TrackerRowChangeEventHandler(object sender, TrackerRowChangeEvent e);

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class AsgnmntDataTable : TypedTableBase<AsgnmntRow>
        {
            private DataColumn _columnAssignedBy;
            private DataColumn _columnDateAssign;
            private DataColumn _columnTimeAssign;
            private DataColumn _columnGroupName;
            private DataColumn _columnAssignee;
            private DataColumn _columnPhone;
            private DataColumn _columnNotes;
            private DataColumn _columnDateAcknow;
            private DataColumn _columnTimeAcknow;
            private DataColumn _columnDateResolv;
            private DataColumn _columnTimeResolv;
            private DataColumn _columnResolution;
            private DataColumn _columnCallId;
            private DataColumn _columnHeatSeq;
            private DataColumn _columnEMail;
            private DataColumn _columnPager;
            private DataColumn _columnDtLastMod;
            private DataColumn _columnWhoAcknow;
            private DataColumn _columnWhoResolv;
            private DataColumn _columnLoginId;
            private DataColumn _columnPhoneExt;
            private DataColumn _columnTargetTime;
            private DataColumn _columnTargetDate;
            private DataColumn _columnSlaResTime;
            private DataColumn _columnTotalAsgnmntTime;
            private DataColumn _columnAvailability;
            private DataColumn _columnCallType;
            private DataColumn _columnVacation;
            private DataColumn _columnResolveOrder;
            private DataColumn _columnGrpEmail;
            private DataColumn _columnMgrEmail;
            private DataColumn _columnWorkDate;
            private DataColumn _columnWorkTime;
            private DataColumn _columnWorkNotes;
            private DataColumn _columnCellEmail;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AssignedByColumn
            {
                get { return _columnAssignedBy; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateAssignColumn
            {
                get { return _columnDateAssign; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TimeAssignColumn
            {
                get { return _columnTimeAssign; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn GroupNameColumn
            {
                get { return _columnGroupName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AssigneeColumn
            {
                get { return _columnAssignee; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PhoneColumn
            {
                get { return _columnPhone; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NotesColumn
            {
                get { return _columnNotes; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DateAcknowColumn
            {
                get { return _columnDateAcknow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TimeAcknowColumn
            {
                get { return _columnTimeAcknow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DateResolvColumn
            {
                get { return _columnDateResolv; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TimeResolvColumn
            {
                get { return _columnTimeResolv; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ResolutionColumn
            {
                get { return _columnResolution; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CallIdColumn
            {
                get { return _columnCallId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HeatSeqColumn
            {
                get { return _columnHeatSeq; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EMailColumn
            {
                get { return _columnEMail; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PagerColumn
            {
                get { return _columnPager; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DtLastModColumn
            {
                get { return _columnDtLastMod; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn WhoAcknowColumn
            {
                get { return _columnWhoAcknow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn WhoResolvColumn
            {
                get { return _columnWhoResolv; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginIdColumn
            {
                get { return _columnLoginId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PhoneExtColumn
            {
                get { return _columnPhoneExt; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TargetTimeColumn
            {
                get { return _columnTargetTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TargetDateColumn
            {
                get { return _columnTargetDate; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SlaResTimeColumn
            {
                get { return _columnSlaResTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TotalAsgnmntTimeColumn
            {
                get { return _columnTotalAsgnmntTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AvailabilityColumn
            {
                get { return _columnAvailability; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CallTypeColumn
            {
                get { return _columnCallType; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn VacationColumn
            {
                get { return _columnVacation; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ResolveOrderColumn
            {
                get { return _columnResolveOrder; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn GrpEmailColumn
            {
                get { return _columnGrpEmail; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MgrEmailColumn
            {
                get { return _columnMgrEmail; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn WorkDateColumn
            {
                get { return _columnWorkDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn WorkTimeColumn
            {
                get { return _columnWorkTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn WorkNotesColumn
            {
                get { return _columnWorkNotes; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CellEmailColumn
            {
                get { return _columnCellEmail; }
            }

            [Browsable(false)]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int Count
            {
                get { return Rows.Count; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AsgnmntRow this[int index]
            {
                get { return (AsgnmntRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AsgnmntRowChangeEventHandler AsgnmntRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AsgnmntRowChangeEventHandler AsgnmntRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AsgnmntRowChangeEventHandler AsgnmntRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AsgnmntRowChangeEventHandler AsgnmntRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AsgnmntDataTable()
            {
                TableName = "Asgnmnt";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal AsgnmntDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected AsgnmntDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddAsgnmntRow(AsgnmntRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AsgnmntRow AddAsgnmntRow(string assignedBy, string dateAssign, string timeAssign,
                string groupName, string assignee, string phone, string notes, string dateAcknow, string timeAcknow,
                string dateResolv, string timeResolv, string resolution, string callId, int heatSeq, string eMail,
                string pager, int dtLastMod, string whoAcknow, string whoResolv, string loginId, string phoneExt,
                string targetTime, string targetDate, decimal slaResTime, int totalAsgnmntTime, string availability,
                string callType, string vacation, int resolveOrder, string grpEmail, string mgrEmail, string workDate,
                int workTime, string workNotes, string cellEmail)
            {
                var asgnmntRow = (AsgnmntRow) NewRow();
                var objArray = new object[35]
                {
                    (object) assignedBy,
                    (object) dateAssign,
                    (object) timeAssign,
                    (object) groupName,
                    (object) assignee,
                    (object) phone,
                    (object) notes,
                    (object) dateAcknow,
                    (object) timeAcknow,
                    (object) dateResolv,
                    (object) timeResolv,
                    (object) resolution,
                    (object) callId,
                    (object) heatSeq,
                    (object) eMail,
                    (object) pager,
                    (object) dtLastMod,
                    (object) whoAcknow,
                    (object) whoResolv,
                    (object) loginId,
                    (object) phoneExt,
                    (object) targetTime,
                    (object) targetDate,
                    (object) slaResTime,
                    (object) totalAsgnmntTime,
                    (object) availability,
                    (object) callType,
                    (object) vacation,
                    (object) resolveOrder,
                    (object) grpEmail,
                    (object) mgrEmail,
                    (object) workDate,
                    (object) workTime,
                    (object) workNotes,
                    (object) cellEmail
                };
                asgnmntRow.ItemArray = objArray;
                Rows.Add((DataRow) asgnmntRow);
                return asgnmntRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AsgnmntRow FindByCallIdheatSeq(string callId, int heatSeq)
            {
                return (AsgnmntRow) Rows.Find(new object[2]
                {
                    (object) callId,
                    (object) heatSeq
                });
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                var asgnmntDataTable = (AsgnmntDataTable) base.Clone();
                asgnmntDataTable.InitVars();
                return (DataTable) asgnmntDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new AsgnmntDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnAssignedBy = Columns["AssignedBy"];
                _columnDateAssign = Columns["DateAssign"];
                _columnTimeAssign = Columns["TimeAssign"];
                _columnGroupName = Columns["GroupName"];
                _columnAssignee = Columns["Assignee"];
                _columnPhone = Columns["Phone"];
                _columnNotes = Columns["Notes"];
                _columnDateAcknow = Columns["DateAcknow"];
                _columnTimeAcknow = Columns["TimeAcknow"];
                _columnDateResolv = Columns["DateResolv"];
                _columnTimeResolv = Columns["TimeResolv"];
                _columnResolution = Columns["Resolution"];
                _columnCallId = Columns["CallID"];
                _columnHeatSeq = Columns["HEATSeq"];
                _columnEMail = Columns["EMail"];
                _columnPager = Columns["Pager"];
                _columnDtLastMod = Columns["DTLastMod"];
                _columnWhoAcknow = Columns["WhoAcknow"];
                _columnWhoResolv = Columns["WhoResolv"];
                _columnLoginId = Columns["LoginID"];
                _columnPhoneExt = Columns["PhoneExt"];
                _columnTargetTime = Columns["TargetTime"];
                _columnTargetDate = Columns["TargetDate"];
                _columnSlaResTime = Columns["SLAResTime"];
                _columnTotalAsgnmntTime = Columns["TotalAsgnmntTime"];
                _columnAvailability = Columns["Availability"];
                _columnCallType = Columns["CallType"];
                _columnVacation = Columns["Vacation"];
                _columnResolveOrder = Columns["ResolveOrder"];
                _columnGrpEmail = Columns["GrpEmail"];
                _columnMgrEmail = Columns["MgrEmail"];
                _columnWorkDate = Columns["WorkDate"];
                _columnWorkTime = Columns["WorkTime"];
                _columnWorkNotes = Columns["WorkNotes"];
                _columnCellEmail = Columns["CellEmail"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnAssignedBy = new DataColumn("AssignedBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignedBy);
                _columnDateAssign = new DataColumn("DateAssign", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDateAssign);
                _columnTimeAssign = new DataColumn("TimeAssign", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTimeAssign);
                _columnGroupName = new DataColumn("GroupName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnGroupName);
                _columnAssignee = new DataColumn("Assignee", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee);
                _columnPhone = new DataColumn("Phone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhone);
                _columnNotes = new DataColumn("Notes", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnNotes);
                _columnDateAcknow = new DataColumn("DateAcknow", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDateAcknow);
                _columnTimeAcknow = new DataColumn("TimeAcknow", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTimeAcknow);
                _columnDateResolv = new DataColumn("DateResolv", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDateResolv);
                _columnTimeResolv = new DataColumn("TimeResolv", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTimeResolv);
                _columnResolution = new DataColumn("Resolution", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnResolution);
                _columnCallId = new DataColumn("CallID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallId);
                _columnHeatSeq = new DataColumn("HEATSeq", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnHeatSeq);
                _columnEMail = new DataColumn("EMail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEMail);
                _columnPager = new DataColumn("Pager", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPager);
                _columnDtLastMod = new DataColumn("DTLastMod", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtLastMod);
                _columnWhoAcknow = new DataColumn("WhoAcknow", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnWhoAcknow);
                _columnWhoResolv = new DataColumn("WhoResolv", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnWhoResolv);
                _columnLoginId = new DataColumn("LoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginId);
                _columnPhoneExt = new DataColumn("PhoneExt", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhoneExt);
                _columnTargetTime = new DataColumn("TargetTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTargetTime);
                _columnTargetDate = new DataColumn("TargetDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTargetDate);
                _columnSlaResTime = new DataColumn("SLAResTime", typeof(decimal), (string) null, MappingType.Element);
                Columns.Add(_columnSlaResTime);
                _columnTotalAsgnmntTime = new DataColumn("TotalAsgnmntTime", typeof(int), (string) null,
                    MappingType.Element);
                Columns.Add(_columnTotalAsgnmntTime);
                _columnAvailability = new DataColumn("Availability", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAvailability);
                _columnCallType = new DataColumn("CallType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallType);
                _columnVacation = new DataColumn("Vacation", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnVacation);
                _columnResolveOrder = new DataColumn("ResolveOrder", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnResolveOrder);
                _columnGrpEmail = new DataColumn("GrpEmail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnGrpEmail);
                _columnMgrEmail = new DataColumn("MgrEmail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnMgrEmail);
                _columnWorkDate = new DataColumn("WorkDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnWorkDate);
                _columnWorkTime = new DataColumn("WorkTime", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnWorkTime);
                _columnWorkNotes = new DataColumn("WorkNotes", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnWorkNotes);
                _columnCellEmail = new DataColumn("CellEmail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCellEmail);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
                {
                    _columnCallId,
                    _columnHeatSeq
                }, 1 != 0));
                _columnAssignedBy.MaxLength = 96;
                _columnDateAssign.MaxLength = 10;
                _columnTimeAssign.MaxLength = 8;
                _columnGroupName.MaxLength = 75;
                _columnAssignee.MaxLength = 96;
                _columnPhone.MaxLength = 25;
                _columnNotes.MaxLength = int.MaxValue;
                _columnDateAcknow.MaxLength = 10;
                _columnTimeAcknow.MaxLength = 8;
                _columnDateResolv.MaxLength = 10;
                _columnTimeResolv.MaxLength = 8;
                _columnResolution.MaxLength = 50;
                _columnCallId.AllowDBNull = false;
                _columnCallId.MaxLength = 8;
                _columnHeatSeq.AllowDBNull = false;
                _columnEMail.MaxLength = 50;
                _columnPager.MaxLength = 50;
                _columnWhoAcknow.MaxLength = 96;
                _columnWhoResolv.MaxLength = 96;
                _columnLoginId.MaxLength = 96;
                _columnPhoneExt.MaxLength = 6;
                _columnTargetTime.MaxLength = 8;
                _columnTargetDate.MaxLength = 10;
                _columnAvailability.MaxLength = 25;
                _columnCallType.MaxLength = 100;
                _columnVacation.MaxLength = 1;
                _columnGrpEmail.MaxLength = 100;
                _columnMgrEmail.MaxLength = 100;
                _columnWorkDate.MaxLength = 10;
                _columnWorkNotes.MaxLength = int.MaxValue;
                _columnCellEmail.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AsgnmntRow NewAsgnmntRow()
            {
                return (AsgnmntRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new AsgnmntRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(AsgnmntRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (AsgnmntRowChanged == null)
                    return;
                AsgnmntRowChanged((object) this,
                    new AsgnmntRowChangeEvent((AsgnmntRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (AsgnmntRowChanging == null)
                    return;
                AsgnmntRowChanging((object) this,
                    new AsgnmntRowChangeEvent((AsgnmntRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (AsgnmntRowDeleted == null)
                    return;
                AsgnmntRowDeleted((object) this,
                    new AsgnmntRowChangeEvent((AsgnmntRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (AsgnmntRowDeleting == null)
                    return;
                AsgnmntRowDeleting((object) this,
                    new AsgnmntRowChangeEvent((AsgnmntRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveAsgnmntRow(AsgnmntRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "AsgnmntDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class AssigneeDataTable : TypedTableBase<AssigneeRow>
        {
            private DataColumn _columnAssignee;
            private DataColumn _columnGroupName;
            private DataColumn _columnCallType;
            private DataColumn _columnPhone;
            private DataColumn _columnPager;
            private DataColumn _columnLoginId;
            private DataColumn _columnComments;
            private DataColumn _columnEMail;
            private DataColumn _columnPhoneExt;
            private DataColumn _columnAvailability;
            private DataColumn _columnOutOfOffice;
            private DataColumn _columnCellEmail;
            private DataColumn _columnMgrEmail;
            private DataColumn _columnModBy;
            private DataColumn _columnModDate;
            private DataColumn _columnModTime;
            private DataColumn _columnCellPhone;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AssigneeColumn
            {
                get { return _columnAssignee; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn GroupNameColumn
            {
                get { return _columnGroupName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallTypeColumn
            {
                get { return _columnCallType; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PhoneColumn
            {
                get { return _columnPhone; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PagerColumn
            {
                get { return _columnPager; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn LoginIdColumn
            {
                get { return _columnLoginId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CommentsColumn
            {
                get { return _columnComments; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EMailColumn
            {
                get { return _columnEMail; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PhoneExtColumn
            {
                get { return _columnPhoneExt; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AvailabilityColumn
            {
                get { return _columnAvailability; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn OutOfOfficeColumn
            {
                get { return _columnOutOfOffice; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CellEmailColumn
            {
                get { return _columnCellEmail; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MgrEmailColumn
            {
                get { return _columnMgrEmail; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ModByColumn
            {
                get { return _columnModBy; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModDateColumn
            {
                get { return _columnModDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModTimeColumn
            {
                get { return _columnModTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CellPhoneColumn
            {
                get { return _columnCellPhone; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeRow this[int index]
            {
                get { return (AssigneeRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeRowChangeEventHandler AssigneeRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeRowChangeEventHandler AssigneeRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeRowChangeEventHandler AssigneeRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeRowChangeEventHandler AssigneeRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AssigneeDataTable()
            {
                TableName = "Assignee";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal AssigneeDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected AssigneeDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddAssigneeRow(AssigneeRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AssigneeRow AddAssigneeRow(string assignee, string groupName, string callType,
                string phone, string pager, string loginId, string comments, string eMail, string phoneExt,
                string availability, string outOfOffice, string cellEmail, string mgrEmail, string modBy, string modDate,
                string modTime, string cellPhone)
            {
                var assigneeRow = (AssigneeRow) NewRow();
                var objArray = new object[17]
                {
                    (object) assignee,
                    (object) groupName,
                    (object) callType,
                    (object) phone,
                    (object) pager,
                    (object) loginId,
                    (object) comments,
                    (object) eMail,
                    (object) phoneExt,
                    (object) availability,
                    (object) outOfOffice,
                    (object) cellEmail,
                    (object) mgrEmail,
                    (object) modBy,
                    (object) modDate,
                    (object) modTime,
                    (object) cellPhone
                };
                assigneeRow.ItemArray = objArray;
                Rows.Add((DataRow) assigneeRow);
                return assigneeRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var assigneeDataTable = (AssigneeDataTable) base.Clone();
                assigneeDataTable.InitVars();
                return (DataTable) assigneeDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new AssigneeDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnAssignee = Columns["Assignee"];
                _columnGroupName = Columns["GroupName"];
                _columnCallType = Columns["CallType"];
                _columnPhone = Columns["Phone"];
                _columnPager = Columns["Pager"];
                _columnLoginId = Columns["LoginID"];
                _columnComments = Columns["Comments"];
                _columnEMail = Columns["EMail"];
                _columnPhoneExt = Columns["PhoneExt"];
                _columnAvailability = Columns["Availability"];
                _columnOutOfOffice = Columns["OutOfOffice"];
                _columnCellEmail = Columns["CellEmail"];
                _columnMgrEmail = Columns["MgrEmail"];
                _columnModBy = Columns["ModBy"];
                _columnModDate = Columns["ModDate"];
                _columnModTime = Columns["ModTime"];
                _columnCellPhone = Columns["CellPhone"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnAssignee = new DataColumn("Assignee", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee);
                _columnGroupName = new DataColumn("GroupName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnGroupName);
                _columnCallType = new DataColumn("CallType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallType);
                _columnPhone = new DataColumn("Phone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhone);
                _columnPager = new DataColumn("Pager", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPager);
                _columnLoginId = new DataColumn("LoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginId);
                _columnComments = new DataColumn("Comments", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnComments);
                _columnEMail = new DataColumn("EMail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEMail);
                _columnPhoneExt = new DataColumn("PhoneExt", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhoneExt);
                _columnAvailability = new DataColumn("Availability", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAvailability);
                _columnOutOfOffice = new DataColumn("OutOfOffice", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnOutOfOffice);
                _columnCellEmail = new DataColumn("CellEmail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCellEmail);
                _columnMgrEmail = new DataColumn("MgrEmail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnMgrEmail);
                _columnModBy = new DataColumn("ModBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModBy);
                _columnModDate = new DataColumn("ModDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModDate);
                _columnModTime = new DataColumn("ModTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModTime);
                _columnCellPhone = new DataColumn("CellPhone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCellPhone);
                _columnAssignee.AllowDBNull = false;
                _columnAssignee.MaxLength = 96;
                _columnGroupName.AllowDBNull = false;
                _columnGroupName.MaxLength = 75;
                _columnCallType.MaxLength = 100;
                _columnPhone.MaxLength = 25;
                _columnPager.MaxLength = 50;
                _columnLoginId.MaxLength = 96;
                _columnComments.MaxLength = int.MaxValue;
                _columnEMail.MaxLength = 50;
                _columnPhoneExt.MaxLength = 6;
                _columnAvailability.MaxLength = 25;
                _columnOutOfOffice.MaxLength = 1;
                _columnCellEmail.MaxLength = 100;
                _columnMgrEmail.MaxLength = 100;
                _columnModBy.MaxLength = 100;
                _columnModDate.MaxLength = 10;
                _columnModTime.MaxLength = 8;
                _columnCellPhone.MaxLength = 25;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeRow NewAssigneeRow()
            {
                return (AssigneeRow) NewRow();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new AssigneeRow(builder);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(AssigneeRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (AssigneeRowChanged == null)
                    return;
                AssigneeRowChanged((object) this,
                    new AssigneeRowChangeEvent((AssigneeRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (AssigneeRowChanging == null)
                    return;
                AssigneeRowChanging((object) this,
                    new AssigneeRowChangeEvent((AssigneeRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (AssigneeRowDeleted == null)
                    return;
                AssigneeRowDeleted((object) this,
                    new AssigneeRowChangeEvent((AssigneeRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (AssigneeRowDeleting == null)
                    return;
                AssigneeRowDeleting((object) this,
                    new AssigneeRowChangeEvent((AssigneeRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveAssigneeRow(AssigneeRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "AssigneeDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class AssigneeMasterDataTable : TypedTableBase<AssigneeMasterRow>
        {
            private DataColumn _columnAssignee;
            private DataColumn _columnGroupName;
            private DataColumn _columnCallType;
            private DataColumn _columnPhone;
            private DataColumn _columnPager;
            private DataColumn _columnLoginId;
            private DataColumn _columnFirstName;
            private DataColumn _columnLastName;
            private DataColumn _columnEmail;
            private DataColumn _columnPhoneExt;
            private DataColumn _columnCellPhone;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AssigneeColumn
            {
                get { return _columnAssignee; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn GroupNameColumn
            {
                get { return _columnGroupName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CallTypeColumn
            {
                get { return _columnCallType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PhoneColumn
            {
                get { return _columnPhone; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PagerColumn
            {
                get { return _columnPager; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn LoginIdColumn
            {
                get { return _columnLoginId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FirstNameColumn
            {
                get { return _columnFirstName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LastNameColumn
            {
                get { return _columnLastName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn EmailColumn
            {
                get { return _columnEmail; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PhoneExtColumn
            {
                get { return _columnPhoneExt; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CellPhoneColumn
            {
                get { return _columnCellPhone; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            [DebuggerNonUserCode]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AssigneeMasterRow this[int index]
            {
                get { return (AssigneeMasterRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeMasterRowChangeEventHandler AssigneeMasterRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeMasterRowChangeEventHandler AssigneeMasterRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeMasterRowChangeEventHandler AssigneeMasterRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AssigneeMasterRowChangeEventHandler AssigneeMasterRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeMasterDataTable()
            {
                TableName = "AssigneeMaster";
                BeginInit();
                InitClass();
                EndInit();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal AssigneeMasterDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected AssigneeMasterDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddAssigneeMasterRow(AssigneeMasterRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AssigneeMasterRow AddAssigneeMasterRow(string assignee, string groupName,
                string callType, string phone, string pager, string loginId, string firstName, string lastName,
                string email, string phoneExt, string cellPhone)
            {
                var assigneeMasterRow = (AssigneeMasterRow) NewRow();
                var objArray = new object[11]
                {
                    (object) assignee,
                    (object) groupName,
                    (object) callType,
                    (object) phone,
                    (object) pager,
                    (object) loginId,
                    (object) firstName,
                    (object) lastName,
                    (object) email,
                    (object) phoneExt,
                    (object) cellPhone
                };
                assigneeMasterRow.ItemArray = objArray;
                Rows.Add((DataRow) assigneeMasterRow);
                return assigneeMasterRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var assigneeMasterDataTable =
                    (AssigneeMasterDataTable) base.Clone();
                assigneeMasterDataTable.InitVars();
                return (DataTable) assigneeMasterDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new AssigneeMasterDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnAssignee = Columns["Assignee"];
                _columnGroupName = Columns["GroupName"];
                _columnCallType = Columns["CallType"];
                _columnPhone = Columns["Phone"];
                _columnPager = Columns["Pager"];
                _columnLoginId = Columns["LoginID"];
                _columnFirstName = Columns["FirstName"];
                _columnLastName = Columns["LastName"];
                _columnEmail = Columns["Email"];
                _columnPhoneExt = Columns["PhoneExt"];
                _columnCellPhone = Columns["CellPhone"];
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                _columnAssignee = new DataColumn("Assignee", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee);
                _columnGroupName = new DataColumn("GroupName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnGroupName);
                _columnCallType = new DataColumn("CallType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallType);
                _columnPhone = new DataColumn("Phone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhone);
                _columnPager = new DataColumn("Pager", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPager);
                _columnLoginId = new DataColumn("LoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginId);
                _columnFirstName = new DataColumn("FirstName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFirstName);
                _columnLastName = new DataColumn("LastName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLastName);
                _columnEmail = new DataColumn("Email", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEmail);
                _columnPhoneExt = new DataColumn("PhoneExt", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhoneExt);
                _columnCellPhone = new DataColumn("CellPhone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCellPhone);
                _columnAssignee.MaxLength = 96;
                _columnGroupName.MaxLength = 75;
                _columnCallType.MaxLength = 100;
                _columnPhone.MaxLength = 25;
                _columnPager.MaxLength = 50;
                _columnLoginId.MaxLength = 96;
                _columnFirstName.MaxLength = 50;
                _columnLastName.MaxLength = 50;
                _columnEmail.MaxLength = 50;
                _columnPhoneExt.MaxLength = 6;
                _columnCellPhone.MaxLength = 25;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeMasterRow NewAssigneeMasterRow()
            {
                return (AssigneeMasterRow) NewRow();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new AssigneeMasterRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(AssigneeMasterRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (AssigneeMasterRowChanged == null)
                    return;
                AssigneeMasterRowChanged((object) this,
                    new AssigneeMasterRowChangeEvent((AssigneeMasterRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (AssigneeMasterRowChanging == null)
                    return;
                AssigneeMasterRowChanging((object) this,
                    new AssigneeMasterRowChangeEvent((AssigneeMasterRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (AssigneeMasterRowDeleted == null)
                    return;
                AssigneeMasterRowDeleted((object) this,
                    new AssigneeMasterRowChangeEvent((AssigneeMasterRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (AssigneeMasterRowDeleting == null)
                    return;
                AssigneeMasterRowDeleting((object) this,
                    new AssigneeMasterRowChangeEvent((AssigneeMasterRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void RemoveAssigneeMasterRow(AssigneeMasterRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "AssigneeMasterDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class CalendarStatsDataTable : TypedTableBase<CalendarStatsRow>
        {
            private DataColumn _columnId;
            private DataColumn _columnCDate;
            private DataColumn _columnCalDate;
            private DataColumn _columnCalYear;
            private DataColumn _columnCalFy;
            private DataColumn _columnCalQuarter;
            private DataColumn _columnCMonth;
            private DataColumn _columnCalMonth;
            private DataColumn _columnCalFm;
            private DataColumn _columnCalYearMonth;
            private DataColumn _columnCalNameOfMonth;
            private DataColumn _columnCalShortNameOfMonth;
            private DataColumn _columnCalDayOfYear;
            private DataColumn _columnCalDay;
            private DataColumn _columnCalWeek;
            private DataColumn _columnCalDayOfWeek;
            private DataColumn _columnCalWeekOf;
            private DataColumn _columnCalWeekIsOdd;
            private DataColumn _columnCalDayOfMonth;
            private DataColumn _columnCalTrimester;
            private DataColumn _columnCalIsWeekday;
            private DataColumn _columnCalIsWorkday;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn IdColumn
            {
                get { return _columnId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CDateColumn
            {
                get { return _columnCDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalDateColumn
            {
                get { return _columnCalDate; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalYearColumn
            {
                get { return _columnCalYear; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalFyColumn
            {
                get { return _columnCalFy; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalQuarterColumn
            {
                get { return _columnCalQuarter; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CMonthColumn
            {
                get { return _columnCMonth; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalMonthColumn
            {
                get { return _columnCalMonth; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalFmColumn
            {
                get { return _columnCalFm; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalYearMonthColumn
            {
                get { return _columnCalYearMonth; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalNameOfMonthColumn
            {
                get { return _columnCalNameOfMonth; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalShortNameOfMonthColumn
            {
                get { return _columnCalShortNameOfMonth; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalDayOfYearColumn
            {
                get { return _columnCalDayOfYear; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalDayColumn
            {
                get { return _columnCalDay; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalWeekColumn
            {
                get { return _columnCalWeek; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalDayOfWeekColumn
            {
                get { return _columnCalDayOfWeek; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalWeekOfColumn
            {
                get { return _columnCalWeekOf; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalWeekIsOddColumn
            {
                get { return _columnCalWeekIsOdd; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CalDayOfMonthColumn
            {
                get { return _columnCalDayOfMonth; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalTrimesterColumn
            {
                get { return _columnCalTrimester; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalIsWeekdayColumn
            {
                get { return _columnCalIsWeekday; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CalIsWorkdayColumn
            {
                get { return _columnCalIsWorkday; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CalendarStatsRow this[int index]
            {
                get { return (CalendarStatsRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CalendarStatsRowChangeEventHandler CalendarStatsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CalendarStatsRowChangeEventHandler CalendarStatsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CalendarStatsRowChangeEventHandler CalendarStatsRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CalendarStatsRowChangeEventHandler CalendarStatsRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CalendarStatsDataTable()
            {
                TableName = "CalendarStats";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal CalendarStatsDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected CalendarStatsDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddCalendarStatsRow(CalendarStatsRow row)
            {
                Rows.Add((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CalendarStatsRow AddCalendarStatsRow(decimal id, string cDate, DateTime calDate,
                short calYear, string calFy, byte calQuarter, string cMonth, byte calMonth, byte calFm,
                string calYearMonth, string calNameOfMonth, string calShortNameOfMonth, short calDayOfYear, byte calDay,
                byte calWeek, byte calDayOfWeek, DateTime calWeekOf, bool calWeekIsOdd, byte calDayOfMonth,
                byte calTrimester, bool calIsWeekday, bool calIsWorkday)
            {
                var calendarStatsRow = (CalendarStatsRow) NewRow();
                var objArray = new object[22]
                {
                    (object) id,
                    (object) cDate,
                    (object) calDate,
                    (object) calYear,
                    (object) calFy,
                    (object) calQuarter,
                    (object) cMonth,
                    (object) calMonth,
                    (object) calFm,
                    (object) calYearMonth,
                    (object) calNameOfMonth,
                    (object) calShortNameOfMonth,
                    (object) calDayOfYear,
                    (object) calDay,
                    (object) calWeek,
                    (object) calDayOfWeek,
                    (object) calWeekOf,
                    (object) calWeekIsOdd,
                    (object) calDayOfMonth,
                    (object) calTrimester,
                    (object) calIsWeekday,
                    (object) calIsWorkday
                };
                calendarStatsRow.ItemArray = objArray;
                Rows.Add((DataRow) calendarStatsRow);
                return calendarStatsRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var calendarStatsDataTable =
                    (CalendarStatsDataTable) base.Clone();
                calendarStatsDataTable.InitVars();
                return (DataTable) calendarStatsDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new CalendarStatsDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnId = Columns["ID"];
                _columnCDate = Columns["CDate"];
                _columnCalDate = Columns["CalDate"];
                _columnCalYear = Columns["CalYear"];
                _columnCalFy = Columns["CalFY"];
                _columnCalQuarter = Columns["CalQuarter"];
                _columnCMonth = Columns["CMonth"];
                _columnCalMonth = Columns["CalMonth"];
                _columnCalFm = Columns["CalFM"];
                _columnCalYearMonth = Columns["CalYearMonth"];
                _columnCalNameOfMonth = Columns["CalNameOfMonth"];
                _columnCalShortNameOfMonth = Columns["CalShortNameOfMonth"];
                _columnCalDayOfYear = Columns["CalDayOfYear"];
                _columnCalDay = Columns["CalDay"];
                _columnCalWeek = Columns["CalWeek"];
                _columnCalDayOfWeek = Columns["CalDayOfWeek"];
                _columnCalWeekOf = Columns["CalWeekOf"];
                _columnCalWeekIsOdd = Columns["CalWeekIsOdd"];
                _columnCalDayOfMonth = Columns["CalDayOfMonth"];
                _columnCalTrimester = Columns["CalTrimester"];
                _columnCalIsWeekday = Columns["CalIsWeekday"];
                _columnCalIsWorkday = Columns["CalIsWorkday"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnId = new DataColumn("ID", typeof(decimal), (string) null, MappingType.Element);
                Columns.Add(_columnId);
                _columnCDate = new DataColumn("CDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCDate);
                _columnCalDate = new DataColumn("CalDate", typeof(DateTime), (string) null, MappingType.Element);
                Columns.Add(_columnCalDate);
                _columnCalYear = new DataColumn("CalYear", typeof(short), (string) null, MappingType.Element);
                Columns.Add(_columnCalYear);
                _columnCalFy = new DataColumn("CalFY", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCalFy);
                _columnCalQuarter = new DataColumn("CalQuarter", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalQuarter);
                _columnCMonth = new DataColumn("CMonth", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCMonth);
                _columnCalMonth = new DataColumn("CalMonth", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalMonth);
                _columnCalFm = new DataColumn("CalFM", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalFm);
                _columnCalYearMonth = new DataColumn("CalYearMonth", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCalYearMonth);
                _columnCalNameOfMonth = new DataColumn("CalNameOfMonth", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnCalNameOfMonth);
                _columnCalShortNameOfMonth = new DataColumn("CalShortNameOfMonth", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnCalShortNameOfMonth);
                _columnCalDayOfYear = new DataColumn("CalDayOfYear", typeof(short), (string) null, MappingType.Element);
                Columns.Add(_columnCalDayOfYear);
                _columnCalDay = new DataColumn("CalDay", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalDay);
                _columnCalWeek = new DataColumn("CalWeek", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalWeek);
                _columnCalDayOfWeek = new DataColumn("CalDayOfWeek", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalDayOfWeek);
                _columnCalWeekOf = new DataColumn("CalWeekOf", typeof(DateTime), (string) null, MappingType.Element);
                Columns.Add(_columnCalWeekOf);
                _columnCalWeekIsOdd = new DataColumn("CalWeekIsOdd", typeof(bool), (string) null, MappingType.Element);
                Columns.Add(_columnCalWeekIsOdd);
                _columnCalDayOfMonth = new DataColumn("CalDayOfMonth", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalDayOfMonth);
                _columnCalTrimester = new DataColumn("CalTrimester", typeof(byte), (string) null, MappingType.Element);
                Columns.Add(_columnCalTrimester);
                _columnCalIsWeekday = new DataColumn("CalIsWeekday", typeof(bool), (string) null, MappingType.Element);
                Columns.Add(_columnCalIsWeekday);
                _columnCalIsWorkday = new DataColumn("CalIsWorkday", typeof(bool), (string) null, MappingType.Element);
                Columns.Add(_columnCalIsWorkday);
                _columnId.AllowDBNull = false;
                _columnCDate.MaxLength = 10;
                _columnCalFy.MaxLength = 5;
                _columnCMonth.MaxLength = 2;
                _columnCalYearMonth.MaxLength = 7;
                _columnCalNameOfMonth.MaxLength = 9;
                _columnCalShortNameOfMonth.MaxLength = 3;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CalendarStatsRow NewCalendarStatsRow()
            {
                return (CalendarStatsRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new CalendarStatsRow(builder);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(CalendarStatsRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (CalendarStatsRowChanged == null)
                    return;
                CalendarStatsRowChanged((object) this,
                    new CalendarStatsRowChangeEvent((CalendarStatsRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (CalendarStatsRowChanging == null)
                    return;
                CalendarStatsRowChanging((object) this,
                    new CalendarStatsRowChangeEvent((CalendarStatsRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (CalendarStatsRowDeleted == null)
                    return;
                CalendarStatsRowDeleted((object) this,
                    new CalendarStatsRowChangeEvent((CalendarStatsRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (CalendarStatsRowDeleting == null)
                    return;
                CalendarStatsRowDeleting((object) this,
                    new CalendarStatsRowChangeEvent((CalendarStatsRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void RemoveCalendarStatsRow(CalendarStatsRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "CalendarStatsDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class CallLogDataTable : TypedTableBase<CallLogRow>
        {
            private DataColumn _columnCallId;
            private DataColumn _columnCustId;
            private DataColumn _columnCustType;
            private DataColumn _columnCallType;
            private DataColumn _columnTracker;
            private DataColumn _columnCallStatus;
            private DataColumn _columnPriority;
            private DataColumn _columnCDuration;
            private DataColumn _columnCallCount;
            private DataColumn _columnStopWatch;
            private DataColumn _columnClosedBy;
            private DataColumn _columnClosedDate;
            private DataColumn _columnClosedTime;
            private DataColumn _columnCause;
            private DataColumn _columnCallDesc;
            private DataColumn _columnCloseDesc;
            private DataColumn _columnRecvdBy;
            private DataColumn _columnRecvdDate;
            private DataColumn _columnRecvdTime;
            private DataColumn _columnModBy;
            private DataColumn _columnModDate;
            private DataColumn _columnModTime;
            private DataColumn _columnDtLastMod;
            private DataColumn _columnCallSource;
            private DataColumn _columnQuickCall;
            private DataColumn _columnCategory;
            private DataColumn _columnCatHeading;
            private DataColumn _columnTotalTime;
            private DataColumn _columnSlWarnGoal;
            private DataColumn _columnSlWarnDate;
            private DataColumn _columnSlWarnTime;
            private DataColumn _columnSlCompleteGoal;
            private DataColumn _columnSlCompleteDate;
            private DataColumn _columnSlCompleteTime;
            private DataColumn _columnSlClockStatus;
            private DataColumn _columnSlButtonStatus;
            private DataColumn _columnFirstResolution;
            private DataColumn _columnSlCompleteStatus;
            private DataColumn _columnShortDesc;
            private DataColumn _columnUrgName;
            private DataColumn _columnUrgValue;
            private DataColumn _columnImpName;
            private DataColumn _columnImpValue;
            private DataColumn _columnPriorityValue;
            private DataColumn _columnDetailsReq;
            private DataColumn _columnVandalism;
            private DataColumn _columnAsgnGrp;
            private DataColumn _columnAssignee;
            private DataColumn _columnManagerId;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CallIdColumn
            {
                get { return _columnCallId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CustIdColumn
            {
                get { return _columnCustId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CustTypeColumn
            {
                get { return _columnCustType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallTypeColumn
            {
                get { return _columnCallType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TrackerColumn
            {
                get { return _columnTracker; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallStatusColumn
            {
                get { return _columnCallStatus; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PriorityColumn
            {
                get { return _columnPriority; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CDurationColumn
            {
                get { return _columnCDuration; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CallCountColumn
            {
                get { return _columnCallCount; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn StopWatchColumn
            {
                get { return _columnStopWatch; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ClosedByColumn
            {
                get { return _columnClosedBy; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ClosedDateColumn
            {
                get { return _columnClosedDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ClosedTimeColumn
            {
                get { return _columnClosedTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CauseColumn
            {
                get { return _columnCause; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallDescColumn
            {
                get { return _columnCallDesc; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CloseDescColumn
            {
                get { return _columnCloseDesc; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RecvdByColumn
            {
                get { return _columnRecvdBy; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RecvdDateColumn
            {
                get { return _columnRecvdDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RecvdTimeColumn
            {
                get { return _columnRecvdTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ModByColumn
            {
                get { return _columnModBy; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModDateColumn
            {
                get { return _columnModDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModTimeColumn
            {
                get { return _columnModTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DtLastModColumn
            {
                get { return _columnDtLastMod; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallSourceColumn
            {
                get { return _columnCallSource; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn QuickCallColumn
            {
                get { return _columnQuickCall; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CategoryColumn
            {
                get { return _columnCategory; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CatHeadingColumn
            {
                get { return _columnCatHeading; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TotalTimeColumn
            {
                get { return _columnTotalTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SlWarnGoalColumn
            {
                get { return _columnSlWarnGoal; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SlWarnDateColumn
            {
                get { return _columnSlWarnDate; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SlWarnTimeColumn
            {
                get { return _columnSlWarnTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SlCompleteGoalColumn
            {
                get { return _columnSlCompleteGoal; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SlCompleteDateColumn
            {
                get { return _columnSlCompleteDate; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SlCompleteTimeColumn
            {
                get { return _columnSlCompleteTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SlClockStatusColumn
            {
                get { return _columnSlClockStatus; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SlButtonStatusColumn
            {
                get { return _columnSlButtonStatus; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FirstResolutionColumn
            {
                get { return _columnFirstResolution; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SlCompleteStatusColumn
            {
                get { return _columnSlCompleteStatus; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ShortDescColumn
            {
                get { return _columnShortDesc; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn UrgNameColumn
            {
                get { return _columnUrgName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn UrgValueColumn
            {
                get { return _columnUrgValue; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ImpNameColumn
            {
                get { return _columnImpName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ImpValueColumn
            {
                get { return _columnImpValue; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PriorityValueColumn
            {
                get { return _columnPriorityValue; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DetailsReqColumn
            {
                get { return _columnDetailsReq; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn VandalismColumn
            {
                get { return _columnVandalism; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AsgnGrpColumn
            {
                get { return _columnAsgnGrp; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AssigneeColumn
            {
                get { return _columnAssignee; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ManagerIdColumn
            {
                get { return _columnManagerId; }
            }

            [Browsable(false)]
            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CallLogRow this[int index]
            {
                get { return (CallLogRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CallLogRowChangeEventHandler CallLogRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CallLogRowChangeEventHandler CallLogRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CallLogRowChangeEventHandler CallLogRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CallLogRowChangeEventHandler CallLogRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CallLogDataTable()
            {
                TableName = "CallLog";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal CallLogDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected CallLogDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddCallLogRow(CallLogRow row)
            {
                Rows.Add((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CallLogRow AddCallLogRow(string callId, string custId, string custType, string callType,
                string tracker, string callStatus, string priority, decimal cDuration, decimal callCount,
                decimal stopWatch, string closedBy, string closedDate, string closedTime, string cause, string callDesc,
                string closeDesc, string recvdBy, string recvdDate, string recvdTime, string modBy, string modDate,
                string modTime, int dtLastMod, string callSource, string quickCall, string category, string catHeading,
                int totalTime, string slWarnGoal, string slWarnDate, string slWarnTime, string slCompleteGoal,
                string slCompleteDate, string slCompleteTime, string slClockStatus, string slButtonStatus,
                string firstResolution, string slCompleteStatus, string shortDesc, string urgName, int urgValue,
                string impName, int impValue, int priorityValue, string detailsReq, string vandalism, string asgnGrp,
                string assignee, string managerId)
            {
                var callLogRow = (CallLogRow) NewRow();
                var objArray = new object[49]
                {
                    (object) callId,
                    (object) custId,
                    (object) custType,
                    (object) callType,
                    (object) tracker,
                    (object) callStatus,
                    (object) priority,
                    (object) cDuration,
                    (object) callCount,
                    (object) stopWatch,
                    (object) closedBy,
                    (object) closedDate,
                    (object) closedTime,
                    (object) cause,
                    (object) callDesc,
                    (object) closeDesc,
                    (object) recvdBy,
                    (object) recvdDate,
                    (object) recvdTime,
                    (object) modBy,
                    (object) modDate,
                    (object) modTime,
                    (object) dtLastMod,
                    (object) callSource,
                    (object) quickCall,
                    (object) category,
                    (object) catHeading,
                    (object) totalTime,
                    (object) slWarnGoal,
                    (object) slWarnDate,
                    (object) slWarnTime,
                    (object) slCompleteGoal,
                    (object) slCompleteDate,
                    (object) slCompleteTime,
                    (object) slClockStatus,
                    (object) slButtonStatus,
                    (object) firstResolution,
                    (object) slCompleteStatus,
                    (object) shortDesc,
                    (object) urgName,
                    (object) urgValue,
                    (object) impName,
                    (object) impValue,
                    (object) priorityValue,
                    (object) detailsReq,
                    (object) vandalism,
                    (object) asgnGrp,
                    (object) assignee,
                    (object) managerId
                };
                callLogRow.ItemArray = objArray;
                Rows.Add((DataRow) callLogRow);
                return callLogRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CallLogRow FindByCallId(string callId)
            {
                return (CallLogRow) Rows.Find(new object[1]
                {
                    (object) callId
                });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var callLogDataTable = (CallLogDataTable) base.Clone();
                callLogDataTable.InitVars();
                return (DataTable) callLogDataTable;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new CallLogDataTable();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                _columnCallId = Columns["CallID"];
                _columnCustId = Columns["CustID"];
                _columnCustType = Columns["CustType"];
                _columnCallType = Columns["CallType"];
                _columnTracker = Columns["Tracker"];
                _columnCallStatus = Columns["CallStatus"];
                _columnPriority = Columns["Priority"];
                _columnCDuration = Columns["CDuration"];
                _columnCallCount = Columns["CallCount"];
                _columnStopWatch = Columns["StopWatch"];
                _columnClosedBy = Columns["ClosedBy"];
                _columnClosedDate = Columns["ClosedDate"];
                _columnClosedTime = Columns["ClosedTime"];
                _columnCause = Columns["Cause"];
                _columnCallDesc = Columns["CallDesc"];
                _columnCloseDesc = Columns["CloseDesc"];
                _columnRecvdBy = Columns["RecvdBy"];
                _columnRecvdDate = Columns["RecvdDate"];
                _columnRecvdTime = Columns["RecvdTime"];
                _columnModBy = Columns["ModBy"];
                _columnModDate = Columns["ModDate"];
                _columnModTime = Columns["ModTime"];
                _columnDtLastMod = Columns["DTLastMod"];
                _columnCallSource = Columns["CallSource"];
                _columnQuickCall = Columns["QuickCall"];
                _columnCategory = Columns["Category"];
                _columnCatHeading = Columns["CatHeading"];
                _columnTotalTime = Columns["TotalTime"];
                _columnSlWarnGoal = Columns["SL_Warn_Goal"];
                _columnSlWarnDate = Columns["SL_Warn_Date"];
                _columnSlWarnTime = Columns["SL_Warn_Time"];
                _columnSlCompleteGoal = Columns["SL_Complete_Goal"];
                _columnSlCompleteDate = Columns["SL_Complete_Date"];
                _columnSlCompleteTime = Columns["SL_Complete_Time"];
                _columnSlClockStatus = Columns["SL_Clock_Status"];
                _columnSlButtonStatus = Columns["SL_Button_Status"];
                _columnFirstResolution = Columns["FirstResolution"];
                _columnSlCompleteStatus = Columns["SL_Complete_Status"];
                _columnShortDesc = Columns["ShortDesc"];
                _columnUrgName = Columns["Urg_Name"];
                _columnUrgValue = Columns["Urg_Value"];
                _columnImpName = Columns["Imp_Name"];
                _columnImpValue = Columns["Imp_Value"];
                _columnPriorityValue = Columns["PriorityValue"];
                _columnDetailsReq = Columns["DetailsReq"];
                _columnVandalism = Columns["Vandalism"];
                _columnAsgnGrp = Columns["AsgnGrp"];
                _columnAssignee = Columns["Assignee"];
                _columnManagerId = Columns["ManagerID"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnCallId = new DataColumn("CallID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallId);
                _columnCustId = new DataColumn("CustID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustId);
                _columnCustType = new DataColumn("CustType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustType);
                _columnCallType = new DataColumn("CallType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallType);
                _columnTracker = new DataColumn("Tracker", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTracker);
                _columnCallStatus = new DataColumn("CallStatus", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallStatus);
                _columnPriority = new DataColumn("Priority", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPriority);
                _columnCDuration = new DataColumn("CDuration", typeof(decimal), (string) null, MappingType.Element);
                Columns.Add(_columnCDuration);
                _columnCallCount = new DataColumn("CallCount", typeof(decimal), (string) null, MappingType.Element);
                Columns.Add(_columnCallCount);
                _columnStopWatch = new DataColumn("StopWatch", typeof(decimal), (string) null, MappingType.Element);
                Columns.Add(_columnStopWatch);
                _columnClosedBy = new DataColumn("ClosedBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnClosedBy);
                _columnClosedDate = new DataColumn("ClosedDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnClosedDate);
                _columnClosedTime = new DataColumn("ClosedTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnClosedTime);
                _columnCause = new DataColumn("Cause", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCause);
                _columnCallDesc = new DataColumn("CallDesc", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallDesc);
                _columnCloseDesc = new DataColumn("CloseDesc", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCloseDesc);
                _columnRecvdBy = new DataColumn("RecvdBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRecvdBy);
                _columnRecvdDate = new DataColumn("RecvdDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRecvdDate);
                _columnRecvdTime = new DataColumn("RecvdTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRecvdTime);
                _columnModBy = new DataColumn("ModBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModBy);
                _columnModDate = new DataColumn("ModDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModDate);
                _columnModTime = new DataColumn("ModTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModTime);
                _columnDtLastMod = new DataColumn("DTLastMod", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtLastMod);
                _columnCallSource = new DataColumn("CallSource", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallSource);
                _columnQuickCall = new DataColumn("QuickCall", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnQuickCall);
                _columnCategory = new DataColumn("Category", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCategory);
                _columnCatHeading = new DataColumn("CatHeading", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCatHeading);
                _columnTotalTime = new DataColumn("TotalTime", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnTotalTime);
                _columnSlWarnGoal = new DataColumn("SL_Warn_Goal", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSlWarnGoal);
                _columnSlWarnDate = new DataColumn("SL_Warn_Date", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSlWarnDate);
                _columnSlWarnTime = new DataColumn("SL_Warn_Time", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSlWarnTime);
                _columnSlCompleteGoal = new DataColumn("SL_Complete_Goal", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSlCompleteGoal);
                _columnSlCompleteDate = new DataColumn("SL_Complete_Date", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSlCompleteDate);
                _columnSlCompleteTime = new DataColumn("SL_Complete_Time", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSlCompleteTime);
                _columnSlClockStatus = new DataColumn("SL_Clock_Status", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSlClockStatus);
                _columnSlButtonStatus = new DataColumn("SL_Button_Status", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSlButtonStatus);
                _columnFirstResolution = new DataColumn("FirstResolution", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFirstResolution);
                _columnSlCompleteStatus = new DataColumn("SL_Complete_Status", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSlCompleteStatus);
                _columnShortDesc = new DataColumn("ShortDesc", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnShortDesc);
                _columnUrgName = new DataColumn("Urg_Name", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnUrgName);
                _columnUrgValue = new DataColumn("Urg_Value", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnUrgValue);
                _columnImpName = new DataColumn("Imp_Name", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnImpName);
                _columnImpValue = new DataColumn("Imp_Value", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnImpValue);
                _columnPriorityValue = new DataColumn("PriorityValue", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnPriorityValue);
                _columnDetailsReq = new DataColumn("DetailsReq", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDetailsReq);
                _columnVandalism = new DataColumn("Vandalism", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnVandalism);
                _columnAsgnGrp = new DataColumn("AsgnGrp", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAsgnGrp);
                _columnAssignee = new DataColumn("Assignee", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee);
                _columnManagerId = new DataColumn("ManagerID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnManagerId);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
                {
                    _columnCallId
                }, 1 != 0));
                _columnCallId.AllowDBNull = false;
                _columnCallId.Unique = true;
                _columnCallId.MaxLength = 8;
                _columnCustId.MaxLength = 50;
                _columnCustType.MaxLength = 50;
                _columnCallType.MaxLength = 100;
                _columnTracker.MaxLength = 96;
                _columnCallStatus.MaxLength = 50;
                _columnPriority.MaxLength = 2;
                _columnClosedBy.MaxLength = 96;
                _columnClosedDate.MaxLength = 10;
                _columnClosedTime.MaxLength = 8;
                _columnCause.MaxLength = 50;
                _columnCallDesc.MaxLength = int.MaxValue;
                _columnCloseDesc.MaxLength = int.MaxValue;
                _columnRecvdBy.MaxLength = 96;
                _columnRecvdDate.MaxLength = 10;
                _columnRecvdTime.MaxLength = 8;
                _columnModBy.MaxLength = 96;
                _columnModDate.MaxLength = 10;
                _columnModTime.MaxLength = 8;
                _columnCallSource.MaxLength = 15;
                _columnQuickCall.MaxLength = 1;
                _columnCategory.MaxLength = 50;
                _columnCatHeading.MaxLength = 25;
                _columnSlWarnGoal.MaxLength = 14;
                _columnSlWarnDate.MaxLength = 10;
                _columnSlWarnTime.MaxLength = 8;
                _columnSlCompleteGoal.MaxLength = 14;
                _columnSlCompleteDate.MaxLength = 10;
                _columnSlCompleteTime.MaxLength = 8;
                _columnSlClockStatus.MaxLength = 20;
                _columnSlButtonStatus.MaxLength = 20;
                _columnFirstResolution.MaxLength = 3;
                _columnSlCompleteStatus.MaxLength = 25;
                _columnShortDesc.MaxLength = 100;
                _columnUrgName.MaxLength = 50;
                _columnImpName.MaxLength = 50;
                _columnDetailsReq.MaxLength = 45;
                _columnVandalism.MaxLength = 1;
                _columnAsgnGrp.MaxLength = 75;
                _columnAssignee.MaxLength = 75;
                _columnManagerId.MaxLength = 50;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CallLogRow NewCallLogRow()
            {
                return (CallLogRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new CallLogRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(CallLogRow);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (CallLogRowChanged == null)
                    return;
                CallLogRowChanged((object) this,
                    new CallLogRowChangeEvent((CallLogRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (CallLogRowChanging == null)
                    return;
                CallLogRowChanging((object) this,
                    new CallLogRowChangeEvent((CallLogRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (CallLogRowDeleted == null)
                    return;
                CallLogRowDeleted((object) this,
                    new CallLogRowChangeEvent((CallLogRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (CallLogRowDeleting == null)
                    return;
                CallLogRowDeleting((object) this,
                    new CallLogRowChangeEvent((CallLogRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void RemoveCallLogRow(CallLogRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "CallLogDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class DetailDataTable : TypedTableBase<DetailRow>
        {
            private DataColumn _columnCallId;
            private DataColumn _columnSerialNo;
            private DataColumn _columnProduct;
            private DataColumn _columnNotes;
            private DataColumn _columnSubCallType;
            private DataColumn _columnProductLine;
            private DataColumn _columnDate1;
            private DataColumn _columnDate2;
            private DataColumn _columnDate3;
            private DataColumn _columnCode2;
            private DataColumn _columnDtLastMod;
            private DataColumn _columnReturnReason;
            private DataColumn _columnYesNo1;
            private DataColumn _columnYesNo2;
            private DataColumn _columnDocument1;
            private DataColumn _columnDocument2;
            private DataColumn _columnDocument3;
            private DataColumn _columnDocument4;
            private DataColumn _columnDocument5;
            private DataColumn _columnFilePath1;
            private DataColumn _columnFilePath2;
            private DataColumn _columnFilePath3;
            private DataColumn _columnFilePath4;
            private DataColumn _columnFilePath5;
            private DataColumn _columnDirectory1;
            private DataColumn _columnDirectory2;
            private DataColumn _columnDirectory3;
            private DataColumn _columnAsgGrp1;
            private DataColumn _columnAsgGrp2;
            private DataColumn _columnAsgGrp3;
            private DataColumn _columnMoveFrom;
            private DataColumn _columnMoveTo;
            private DataColumn _columnTimeFrame;
            private DataColumn _columnEquipType;
            private DataColumn _columnAsset;
            private DataColumn _columnSerialNum;
            private DataColumn _columnComputerName;
            private DataColumn _columnBuilding;
            private DataColumn _columnRoomNum;
            private DataColumn _columnFrrcComVote;
            private DataColumn _columnFrrcFundingStatus;
            private DataColumn _columnFrrcAddOn;
            private DataColumn _columnFrrcTimeFrame;
            private DataColumn _columnFrrcMeetingDate;
            private DataColumn _columnFrrcResponsibility;
            private DataColumn _columnCircuitId;
            private DataColumn _columnCircuitProvider;
            private DataColumn _columnActionType1;
            private DataColumn _columnActionType2;
            private DataColumn _columnActionType3;
            private DataColumn _columnAssignee1;
            private DataColumn _columnAssignee2;
            private DataColumn _columnAssignee3;
            private DataColumn _columnHwAsset;
            private DataColumn _columnHwSerialNum;
            private DataColumn _columnHwComputerName;
            private DataColumn _columnVendor;
            private DataColumn _columnOperatingSystem;
            private DataColumn _columnModel;
            private DataColumn _columnOsType;
            private DataColumn _columnVersion;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CallIdColumn
            {
                get { return _columnCallId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SerialNoColumn
            {
                get { return _columnSerialNo; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ProductColumn
            {
                get { return _columnProduct; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NotesColumn
            {
                get { return _columnNotes; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SubCallTypeColumn
            {
                get { return _columnSubCallType; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ProductLineColumn
            {
                get { return _columnProductLine; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Date1Column
            {
                get { return _columnDate1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Date2Column
            {
                get { return _columnDate2; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Date3Column
            {
                get { return _columnDate3; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Code2Column
            {
                get { return _columnCode2; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DtLastModColumn
            {
                get { return _columnDtLastMod; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ReturnReasonColumn
            {
                get { return _columnReturnReason; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn YesNo1Column
            {
                get { return _columnYesNo1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn YesNo2Column
            {
                get { return _columnYesNo2; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Document1Column
            {
                get { return _columnDocument1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Document2Column
            {
                get { return _columnDocument2; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Document3Column
            {
                get { return _columnDocument3; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Document4Column
            {
                get { return _columnDocument4; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Document5Column
            {
                get { return _columnDocument5; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FilePath1Column
            {
                get { return _columnFilePath1; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FilePath2Column
            {
                get { return _columnFilePath2; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn FilePath3Column
            {
                get { return _columnFilePath3; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FilePath4Column
            {
                get { return _columnFilePath4; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FilePath5Column
            {
                get { return _columnFilePath5; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Directory1Column
            {
                get { return _columnDirectory1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Directory2Column
            {
                get { return _columnDirectory2; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Directory3Column
            {
                get { return _columnDirectory3; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AsgGrp1Column
            {
                get { return _columnAsgGrp1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AsgGrp2Column
            {
                get { return _columnAsgGrp2; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AsgGrp3Column
            {
                get { return _columnAsgGrp3; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MoveFromColumn
            {
                get { return _columnMoveFrom; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MoveToColumn
            {
                get { return _columnMoveTo; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TimeFrameColumn
            {
                get { return _columnTimeFrame; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EquipTypeColumn
            {
                get { return _columnEquipType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AssetColumn
            {
                get { return _columnAsset; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SerialNumColumn
            {
                get { return _columnSerialNum; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ComputerNameColumn
            {
                get { return _columnComputerName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn BuildingColumn
            {
                get { return _columnBuilding; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RoomNumColumn
            {
                get { return _columnRoomNum; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FrrcComVoteColumn
            {
                get { return _columnFrrcComVote; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FrrcFundingStatusColumn
            {
                get { return _columnFrrcFundingStatus; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn FrrcAddOnColumn
            {
                get { return _columnFrrcAddOn; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FrrcTimeFrameColumn
            {
                get { return _columnFrrcTimeFrame; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FrrcMeetingDateColumn
            {
                get { return _columnFrrcMeetingDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn FrrcResponsibilityColumn
            {
                get { return _columnFrrcResponsibility; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CircuitIdColumn
            {
                get { return _columnCircuitId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CircuitProviderColumn
            {
                get { return _columnCircuitProvider; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ActionType1Column
            {
                get { return _columnActionType1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ActionType2Column
            {
                get { return _columnActionType2; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ActionType3Column
            {
                get { return _columnActionType3; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Assignee1Column
            {
                get { return _columnAssignee1; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Assignee2Column
            {
                get { return _columnAssignee2; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn Assignee3Column
            {
                get { return _columnAssignee3; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HwAssetColumn
            {
                get { return _columnHwAsset; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn HwSerialNumColumn
            {
                get { return _columnHwSerialNum; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn HwComputerNameColumn
            {
                get { return _columnHwComputerName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn VendorColumn
            {
                get { return _columnVendor; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn OperatingSystemColumn
            {
                get { return _columnOperatingSystem; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModelColumn
            {
                get { return _columnModel; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OsTypeColumn
            {
                get { return _columnOsType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn VersionColumn
            {
                get { return _columnVersion; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DetailRow this[int index]
            {
                get { return (DetailRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DetailRowChangeEventHandler DetailRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DetailRowChangeEventHandler DetailRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DetailRowChangeEventHandler DetailRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DetailRowChangeEventHandler DetailRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DetailDataTable()
            {
                TableName = "Detail";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal DetailDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected DetailDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddDetailRow(DetailRow row)
            {
                Rows.Add((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DetailRow AddDetailRow(string callId, string serialNo, string product, string notes,
                string subCallType, string productLine, string date1, string date2, string date3, string code2,
                int dtLastMod, string returnReason, string yesNo1, string yesNo2, string document1, string document2,
                string document3, string document4, string document5, string filePath1, string filePath2,
                string filePath3, string filePath4, string filePath5, string directory1, string directory2,
                string directory3, string asgGrp1, string asgGrp2, string asgGrp3, string moveFrom, string moveTo,
                string timeFrame, string equipType, string asset, string serialNum, string computerName, string building,
                string roomNum, string frrcComVote, string frrcFundingStatus, string frrcAddOn, string frrcTimeFrame,
                string frrcMeetingDate, string frrcResponsibility, string circuitId, string circuitProvider,
                string actionType1, string actionType2, string actionType3, string assignee1, string assignee2,
                string assignee3, string hwAsset, string hwSerialNum, string hwComputerName, string vendor,
                string operatingSystem, string model, string osType, string version)
            {
                var detailRow = (DetailRow) NewRow();
                var objArray = new object[61]
                {
                    (object) callId,
                    (object) serialNo,
                    (object) product,
                    (object) notes,
                    (object) subCallType,
                    (object) productLine,
                    (object) date1,
                    (object) date2,
                    (object) date3,
                    (object) code2,
                    (object) dtLastMod,
                    (object) returnReason,
                    (object) yesNo1,
                    (object) yesNo2,
                    (object) document1,
                    (object) document2,
                    (object) document3,
                    (object) document4,
                    (object) document5,
                    (object) filePath1,
                    (object) filePath2,
                    (object) filePath3,
                    (object) filePath4,
                    (object) filePath5,
                    (object) directory1,
                    (object) directory2,
                    (object) directory3,
                    (object) asgGrp1,
                    (object) asgGrp2,
                    (object) asgGrp3,
                    (object) moveFrom,
                    (object) moveTo,
                    (object) timeFrame,
                    (object) equipType,
                    (object) asset,
                    (object) serialNum,
                    (object) computerName,
                    (object) building,
                    (object) roomNum,
                    (object) frrcComVote,
                    (object) frrcFundingStatus,
                    (object) frrcAddOn,
                    (object) frrcTimeFrame,
                    (object) frrcMeetingDate,
                    (object) frrcResponsibility,
                    (object) circuitId,
                    (object) circuitProvider,
                    (object) actionType1,
                    (object) actionType2,
                    (object) actionType3,
                    (object) assignee1,
                    (object) assignee2,
                    (object) assignee3,
                    (object) hwAsset,
                    (object) hwSerialNum,
                    (object) hwComputerName,
                    (object) vendor,
                    (object) operatingSystem,
                    (object) model,
                    (object) osType,
                    (object) version
                };
                detailRow.ItemArray = objArray;
                Rows.Add((DataRow) detailRow);
                return detailRow;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DetailRow FindByCallId(string callId)
            {
                return (DetailRow) Rows.Find(new object[1]
                {
                    (object) callId
                });
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                var detailDataTable = (DetailDataTable) base.Clone();
                detailDataTable.InitVars();
                return (DataTable) detailDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new DetailDataTable();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                _columnCallId = Columns["CallID"];
                _columnSerialNo = Columns["SerialNo"];
                _columnProduct = Columns["Product"];
                _columnNotes = Columns["Notes"];
                _columnSubCallType = Columns["SubCallType"];
                _columnProductLine = Columns["ProductLine"];
                _columnDate1 = Columns["Date1"];
                _columnDate2 = Columns["Date2"];
                _columnDate3 = Columns["Date3"];
                _columnCode2 = Columns["Code2"];
                _columnDtLastMod = Columns["DTLastMod"];
                _columnReturnReason = Columns["ReturnReason"];
                _columnYesNo1 = Columns["YesNo1"];
                _columnYesNo2 = Columns["YesNo2"];
                _columnDocument1 = Columns["Document1"];
                _columnDocument2 = Columns["Document2"];
                _columnDocument3 = Columns["Document3"];
                _columnDocument4 = Columns["Document4"];
                _columnDocument5 = Columns["Document5"];
                _columnFilePath1 = Columns["FilePath1"];
                _columnFilePath2 = Columns["FilePath2"];
                _columnFilePath3 = Columns["FilePath3"];
                _columnFilePath4 = Columns["FilePath4"];
                _columnFilePath5 = Columns["FilePath5"];
                _columnDirectory1 = Columns["Directory1"];
                _columnDirectory2 = Columns["Directory2"];
                _columnDirectory3 = Columns["Directory3"];
                _columnAsgGrp1 = Columns["AsgGrp1"];
                _columnAsgGrp2 = Columns["AsgGrp2"];
                _columnAsgGrp3 = Columns["AsgGrp3"];
                _columnMoveFrom = Columns["MoveFrom"];
                _columnMoveTo = Columns["MoveTo"];
                _columnTimeFrame = Columns["TimeFrame"];
                _columnEquipType = Columns["EquipType"];
                _columnAsset = Columns["Asset"];
                _columnSerialNum = Columns["SerialNum"];
                _columnComputerName = Columns["ComputerName"];
                _columnBuilding = Columns["Building"];
                _columnRoomNum = Columns["RoomNum"];
                _columnFrrcComVote = Columns["FRRCComVote"];
                _columnFrrcFundingStatus = Columns["FRRCFundingStatus"];
                _columnFrrcAddOn = Columns["FRRCAddOn"];
                _columnFrrcTimeFrame = Columns["FRRCTimeFrame"];
                _columnFrrcMeetingDate = Columns["FRRCMeetingDate"];
                _columnFrrcResponsibility = Columns["FRRCResponsibility"];
                _columnCircuitId = Columns["CircuitID"];
                _columnCircuitProvider = Columns["CircuitProvider"];
                _columnActionType1 = Columns["ActionType1"];
                _columnActionType2 = Columns["ActionType2"];
                _columnActionType3 = Columns["ActionType3"];
                _columnAssignee1 = Columns["Assignee1"];
                _columnAssignee2 = Columns["Assignee2"];
                _columnAssignee3 = Columns["Assignee3"];
                _columnHwAsset = Columns["HWAsset"];
                _columnHwSerialNum = Columns["HWSerialNum"];
                _columnHwComputerName = Columns["HWComputerName"];
                _columnVendor = Columns["Vendor"];
                _columnOperatingSystem = Columns["OperatingSystem"];
                _columnModel = Columns["Model"];
                _columnOsType = Columns["OSType"];
                _columnVersion = Columns["Version"];
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                _columnCallId = new DataColumn("CallID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallId);
                _columnSerialNo = new DataColumn("SerialNo", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSerialNo);
                _columnProduct = new DataColumn("Product", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnProduct);
                _columnNotes = new DataColumn("Notes", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnNotes);
                _columnSubCallType = new DataColumn("SubCallType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSubCallType);
                _columnProductLine = new DataColumn("ProductLine", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnProductLine);
                _columnDate1 = new DataColumn("Date1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDate1);
                _columnDate2 = new DataColumn("Date2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDate2);
                _columnDate3 = new DataColumn("Date3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDate3);
                _columnCode2 = new DataColumn("Code2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCode2);
                _columnDtLastMod = new DataColumn("DTLastMod", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtLastMod);
                _columnReturnReason = new DataColumn("ReturnReason", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnReturnReason);
                _columnYesNo1 = new DataColumn("YesNo1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnYesNo1);
                _columnYesNo2 = new DataColumn("YesNo2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnYesNo2);
                _columnDocument1 = new DataColumn("Document1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDocument1);
                _columnDocument2 = new DataColumn("Document2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDocument2);
                _columnDocument3 = new DataColumn("Document3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDocument3);
                _columnDocument4 = new DataColumn("Document4", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDocument4);
                _columnDocument5 = new DataColumn("Document5", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDocument5);
                _columnFilePath1 = new DataColumn("FilePath1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFilePath1);
                _columnFilePath2 = new DataColumn("FilePath2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFilePath2);
                _columnFilePath3 = new DataColumn("FilePath3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFilePath3);
                _columnFilePath4 = new DataColumn("FilePath4", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFilePath4);
                _columnFilePath5 = new DataColumn("FilePath5", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFilePath5);
                _columnDirectory1 = new DataColumn("Directory1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDirectory1);
                _columnDirectory2 = new DataColumn("Directory2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDirectory2);
                _columnDirectory3 = new DataColumn("Directory3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDirectory3);
                _columnAsgGrp1 = new DataColumn("AsgGrp1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAsgGrp1);
                _columnAsgGrp2 = new DataColumn("AsgGrp2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAsgGrp2);
                _columnAsgGrp3 = new DataColumn("AsgGrp3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAsgGrp3);
                _columnMoveFrom = new DataColumn("MoveFrom", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnMoveFrom);
                _columnMoveTo = new DataColumn("MoveTo", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnMoveTo);
                _columnTimeFrame = new DataColumn("TimeFrame", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTimeFrame);
                _columnEquipType = new DataColumn("EquipType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEquipType);
                _columnAsset = new DataColumn("Asset", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAsset);
                _columnSerialNum = new DataColumn("SerialNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSerialNum);
                _columnComputerName = new DataColumn("ComputerName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnComputerName);
                _columnBuilding = new DataColumn("Building", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnBuilding);
                _columnRoomNum = new DataColumn("RoomNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRoomNum);
                _columnFrrcComVote = new DataColumn("FRRCComVote", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFrrcComVote);
                _columnFrrcFundingStatus = new DataColumn("FRRCFundingStatus", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFrrcFundingStatus);
                _columnFrrcAddOn = new DataColumn("FRRCAddOn", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFrrcAddOn);
                _columnFrrcTimeFrame = new DataColumn("FRRCTimeFrame", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFrrcTimeFrame);
                _columnFrrcMeetingDate = new DataColumn("FRRCMeetingDate", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFrrcMeetingDate);
                _columnFrrcResponsibility = new DataColumn("FRRCResponsibility", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFrrcResponsibility);
                _columnCircuitId = new DataColumn("CircuitID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCircuitId);
                _columnCircuitProvider = new DataColumn("CircuitProvider", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnCircuitProvider);
                _columnActionType1 = new DataColumn("ActionType1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnActionType1);
                _columnActionType2 = new DataColumn("ActionType2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnActionType2);
                _columnActionType3 = new DataColumn("ActionType3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnActionType3);
                _columnAssignee1 = new DataColumn("Assignee1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee1);
                _columnAssignee2 = new DataColumn("Assignee2", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee2);
                _columnAssignee3 = new DataColumn("Assignee3", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssignee3);
                _columnHwAsset = new DataColumn("HWAsset", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnHwAsset);
                _columnHwSerialNum = new DataColumn("HWSerialNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnHwSerialNum);
                _columnHwComputerName = new DataColumn("HWComputerName", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnHwComputerName);
                _columnVendor = new DataColumn("Vendor", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnVendor);
                _columnOperatingSystem = new DataColumn("OperatingSystem", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnOperatingSystem);
                _columnModel = new DataColumn("Model", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModel);
                _columnOsType = new DataColumn("OSType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnOsType);
                _columnVersion = new DataColumn("Version", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnVersion);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
                {
                    _columnCallId
                }, 1 != 0));
                _columnCallId.AllowDBNull = false;
                _columnCallId.Unique = true;
                _columnCallId.MaxLength = 8;
                _columnSerialNo.MaxLength = 25;
                _columnProduct.MaxLength = 25;
                _columnNotes.MaxLength = int.MaxValue;
                _columnSubCallType.MaxLength = 45;
                _columnProductLine.MaxLength = 35;
                _columnDate1.MaxLength = 10;
                _columnDate2.MaxLength = 10;
                _columnDate3.MaxLength = 10;
                _columnCode2.MaxLength = 25;
                _columnReturnReason.MaxLength = int.MaxValue;
                _columnYesNo1.MaxLength = 3;
                _columnYesNo2.MaxLength = 3;
                _columnDocument1.MaxLength = 50;
                _columnDocument2.MaxLength = 50;
                _columnDocument3.MaxLength = 50;
                _columnDocument4.MaxLength = 50;
                _columnDocument5.MaxLength = 50;
                _columnFilePath1.MaxLength = 100;
                _columnFilePath2.MaxLength = 100;
                _columnFilePath3.MaxLength = 100;
                _columnFilePath4.MaxLength = 100;
                _columnFilePath5.MaxLength = 100;
                _columnDirectory1.MaxLength = 50;
                _columnDirectory2.MaxLength = 50;
                _columnDirectory3.MaxLength = 50;
                _columnAsgGrp1.MaxLength = 75;
                _columnAsgGrp2.MaxLength = 75;
                _columnAsgGrp3.MaxLength = 75;
                _columnMoveFrom.MaxLength = 30;
                _columnMoveTo.MaxLength = 30;
                _columnTimeFrame.MaxLength = 20;
                _columnEquipType.MaxLength = 25;
                _columnAsset.MaxLength = 20;
                _columnSerialNum.MaxLength = 20;
                _columnComputerName.MaxLength = 30;
                _columnBuilding.MaxLength = 15;
                _columnRoomNum.MaxLength = 15;
                _columnFrrcComVote.MaxLength = 15;
                _columnFrrcFundingStatus.MaxLength = 35;
                _columnFrrcAddOn.MaxLength = 25;
                _columnFrrcTimeFrame.MaxLength = 35;
                _columnFrrcMeetingDate.MaxLength = 10;
                _columnFrrcResponsibility.MaxLength = 15;
                _columnCircuitId.MaxLength = 30;
                _columnCircuitProvider.MaxLength = 20;
                _columnActionType1.MaxLength = 20;
                _columnActionType2.MaxLength = 20;
                _columnActionType3.MaxLength = 20;
                _columnAssignee1.MaxLength = 50;
                _columnAssignee2.MaxLength = 50;
                _columnAssignee3.MaxLength = 50;
                _columnHwAsset.MaxLength = 10;
                _columnHwSerialNum.MaxLength = 10;
                _columnHwComputerName.MaxLength = 20;
                _columnVendor.MaxLength = 25;
                _columnOperatingSystem.MaxLength = 30;
                _columnModel.MaxLength = 15;
                _columnOsType.MaxLength = 10;
                _columnVersion.MaxLength = 10;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DetailRow NewDetailRow()
            {
                return (DetailRow) NewRow();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new DetailRow(builder);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DetailRow);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (DetailRowChanged == null)
                    return;
                DetailRowChanged((object) this,
                    new DetailRowChangeEvent((DetailRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (DetailRowChanging == null)
                    return;
                DetailRowChanging((object) this,
                    new DetailRowChangeEvent((DetailRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (DetailRowDeleted == null)
                    return;
                DetailRowDeleted((object) this,
                    new DetailRowChangeEvent((DetailRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (DetailRowDeleting == null)
                    return;
                DetailRowDeleting((object) this,
                    new DetailRowChangeEvent((DetailRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void RemoveDetailRow(DetailRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "DetailDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class FacilitiesDataTable : TypedTableBase<FacilitiesRow>
        {
            private DataColumn _columnAddress1;
            private DataColumn _columnZipCode;
            private DataColumn _columnCity;
            private DataColumn _columnState;
            private DataColumn _columnFacilityName;
            private DataColumn _columnRc;
            private DataColumn _columnRegionNumber;
            private DataColumn _columnPhone;
            private DataColumn _columnAdsLdapPath;
            private DataColumn _columnOldRegion;
            private DataColumn _columnZoneNumber;
            private DataColumn _columnClusterNumber;
            private DataColumn _columnEseCluster;
            private DataColumn _columnAreaTech;
            private DataColumn _columnFax;
            private DataColumn _columnFieldTechnician;
            private DataColumn _columnInfrastructureTechnician;
            private DataColumn _columnOnSiteTechnician;
            private DataColumn _columnServerTechnician;
            private DataColumn _columnHardwareTechnician;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Address1Column
            {
                get { return _columnAddress1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ZipCodeColumn
            {
                get { return _columnZipCode; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CityColumn
            {
                get { return _columnCity; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn StateColumn
            {
                get { return _columnState; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FacilityNameColumn
            {
                get { return _columnFacilityName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcColumn
            {
                get { return _columnRc; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RegionNumberColumn
            {
                get { return _columnRegionNumber; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PhoneColumn
            {
                get { return _columnPhone; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AdsLdapPathColumn
            {
                get { return _columnAdsLdapPath; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn OldRegionColumn
            {
                get { return _columnOldRegion; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ZoneNumberColumn
            {
                get { return _columnZoneNumber; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ClusterNumberColumn
            {
                get { return _columnClusterNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EseClusterColumn
            {
                get { return _columnEseCluster; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AreaTechColumn
            {
                get { return _columnAreaTech; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FaxColumn
            {
                get { return _columnFax; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn FieldTechnicianColumn
            {
                get { return _columnFieldTechnician; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn InfrastructureTechnicianColumn
            {
                get { return _columnInfrastructureTechnician; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn OnSiteTechnicianColumn
            {
                get { return _columnOnSiteTechnician; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ServerTechnicianColumn
            {
                get { return _columnServerTechnician; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn HardwareTechnicianColumn
            {
                get { return _columnHardwareTechnician; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public FacilitiesRow this[int index]
            {
                get { return (FacilitiesRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event FacilitiesRowChangeEventHandler FacilitiesRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event FacilitiesRowChangeEventHandler FacilitiesRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event FacilitiesRowChangeEventHandler FacilitiesRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event FacilitiesRowChangeEventHandler FacilitiesRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public FacilitiesDataTable()
            {
                TableName = "Facilities";
                BeginInit();
                InitClass();
                EndInit();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal FacilitiesDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected FacilitiesDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddFacilitiesRow(FacilitiesRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public FacilitiesRow AddFacilitiesRow(string address1, string zipCode, string city,
                string state, string facilityName, string rc, string regionNumber, string phone, string adsLdapPath,
                string oldRegion, string zoneNumber, string clusterNumber, string eseCluster, string areaTech,
                string fax, string fieldTechnician, string infrastructureTechnician, string onSiteTechnician,
                string serverTechnician, string hardwareTechnician)
            {
                var facilitiesRow = (FacilitiesRow) NewRow();
                var objArray = new object[20]
                {
                    (object) address1,
                    (object) zipCode,
                    (object) city,
                    (object) state,
                    (object) facilityName,
                    (object) rc,
                    (object) regionNumber,
                    (object) phone,
                    (object) adsLdapPath,
                    (object) oldRegion,
                    (object) zoneNumber,
                    (object) clusterNumber,
                    (object) eseCluster,
                    (object) areaTech,
                    (object) fax,
                    (object) fieldTechnician,
                    (object) infrastructureTechnician,
                    (object) onSiteTechnician,
                    (object) serverTechnician,
                    (object) hardwareTechnician
                };
                facilitiesRow.ItemArray = objArray;
                Rows.Add((DataRow) facilitiesRow);
                return facilitiesRow;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public FacilitiesRow FindByRc(string rc)
            {
                return (FacilitiesRow) Rows.Find(new object[1]
                {
                    (object) rc
                });
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                var facilitiesDataTable = (FacilitiesDataTable) base.Clone();
                facilitiesDataTable.InitVars();
                return (DataTable) facilitiesDataTable;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new FacilitiesDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnAddress1 = Columns["Address1"];
                _columnZipCode = Columns["ZipCode"];
                _columnCity = Columns["City"];
                _columnState = Columns["State"];
                _columnFacilityName = Columns["FacilityName"];
                _columnRc = Columns["RC"];
                _columnRegionNumber = Columns["RegionNumber"];
                _columnPhone = Columns["Phone"];
                _columnAdsLdapPath = Columns["ADsLDAPPath"];
                _columnOldRegion = Columns["OldRegion"];
                _columnZoneNumber = Columns["ZoneNumber"];
                _columnClusterNumber = Columns["ClusterNumber"];
                _columnEseCluster = Columns["ESECluster"];
                _columnAreaTech = Columns["AreaTech"];
                _columnFax = Columns["Fax"];
                _columnFieldTechnician = Columns["FieldTechnician"];
                _columnInfrastructureTechnician = Columns["InfrastructureTechnician"];
                _columnOnSiteTechnician = Columns["OnSiteTechnician"];
                _columnServerTechnician = Columns["ServerTechnician"];
                _columnHardwareTechnician = Columns["HardwareTechnician"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnAddress1 = new DataColumn("Address1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAddress1);
                _columnZipCode = new DataColumn("ZipCode", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnZipCode);
                _columnCity = new DataColumn("City", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCity);
                _columnState = new DataColumn("State", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnState);
                _columnFacilityName = new DataColumn("FacilityName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFacilityName);
                _columnRc = new DataColumn("RC", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRc);
                _columnRegionNumber = new DataColumn("RegionNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRegionNumber);
                _columnPhone = new DataColumn("Phone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPhone);
                _columnAdsLdapPath = new DataColumn("ADsLDAPPath", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAdsLdapPath);
                _columnOldRegion = new DataColumn("OldRegion", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnOldRegion);
                _columnZoneNumber = new DataColumn("ZoneNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnZoneNumber);
                _columnClusterNumber = new DataColumn("ClusterNumber", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnClusterNumber);
                _columnEseCluster = new DataColumn("ESECluster", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEseCluster);
                _columnAreaTech = new DataColumn("AreaTech", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAreaTech);
                _columnFax = new DataColumn("Fax", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFax);
                _columnFieldTechnician = new DataColumn("FieldTechnician", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFieldTechnician);
                _columnInfrastructureTechnician = new DataColumn("InfrastructureTechnician", typeof(string),
                    (string) null, MappingType.Element);
                Columns.Add(_columnInfrastructureTechnician);
                _columnOnSiteTechnician = new DataColumn("OnSiteTechnician", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnOnSiteTechnician);
                _columnServerTechnician = new DataColumn("ServerTechnician", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnServerTechnician);
                _columnHardwareTechnician = new DataColumn("HardwareTechnician", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnHardwareTechnician);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
                {
                    _columnRc
                }, 1 != 0));
                _columnAddress1.MaxLength = 50;
                _columnZipCode.MaxLength = 10;
                _columnCity.MaxLength = 30;
                _columnState.MaxLength = 2;
                _columnFacilityName.MaxLength = 50;
                _columnRc.AllowDBNull = false;
                _columnRc.Unique = true;
                _columnRc.MaxLength = 4;
                _columnRegionNumber.MaxLength = 2;
                _columnPhone.MaxLength = 14;
                _columnAdsLdapPath.MaxLength = 100;
                _columnOldRegion.MaxLength = 2;
                _columnZoneNumber.MaxLength = 2;
                _columnClusterNumber.MaxLength = 6;
                _columnEseCluster.MaxLength = 5;
                _columnAreaTech.MaxLength = 1;
                _columnFax.MaxLength = 14;
                _columnFieldTechnician.MaxLength = 96;
                _columnInfrastructureTechnician.MaxLength = 96;
                _columnOnSiteTechnician.MaxLength = 50;
                _columnServerTechnician.MaxLength = 96;
                _columnHardwareTechnician.MaxLength = 96;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public FacilitiesRow NewFacilitiesRow()
            {
                return (FacilitiesRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new FacilitiesRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(FacilitiesRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (FacilitiesRowChanged == null)
                    return;
                FacilitiesRowChanged((object) this,
                    new FacilitiesRowChangeEvent((FacilitiesRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (FacilitiesRowChanging == null)
                    return;
                FacilitiesRowChanging((object) this,
                    new FacilitiesRowChangeEvent((FacilitiesRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (FacilitiesRowDeleted == null)
                    return;
                FacilitiesRowDeleted((object) this,
                    new FacilitiesRowChangeEvent((FacilitiesRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (FacilitiesRowDeleting == null)
                    return;
                FacilitiesRowDeleting((object) this,
                    new FacilitiesRowChangeEvent((FacilitiesRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveFacilitiesRow(FacilitiesRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "FacilitiesDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class HeatcaiDataTable : TypedTableBase<HeatcaiRow>
        {
            private DataColumn _columnLoginId;
            private DataColumn _columnCustId;
            private DataColumn _columnCustType;
            private DataColumn _columnPassword;
            private DataColumn _columnSecretQ;
            private DataColumn _columnSecretA;
            private DataColumn _columnFlags;
            private DataColumn _columnDtCreated;
            private DataColumn _columnDtLastMod;
            private DataColumn _columnLastModBy;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginIdColumn
            {
                get { return _columnLoginId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CustIdColumn
            {
                get { return _columnCustId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CustTypeColumn
            {
                get { return _columnCustType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PasswordColumn
            {
                get { return _columnPassword; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SecretQColumn
            {
                get { return _columnSecretQ; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SecretAColumn
            {
                get { return _columnSecretA; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FlagsColumn
            {
                get { return _columnFlags; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DtCreatedColumn
            {
                get { return _columnDtCreated; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DtLastModColumn
            {
                get { return _columnDtLastMod; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LastModByColumn
            {
                get { return _columnLastModBy; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatcaiRow this[int index]
            {
                get { return (HeatcaiRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatcaiRowChangeEventHandler HeatcaiRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatcaiRowChangeEventHandler HeatcaiRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatcaiRowChangeEventHandler HeatcaiRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatcaiRowChangeEventHandler HeatcaiRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HeatcaiDataTable()
            {
                TableName = "HEATCAI";
                BeginInit();
                InitClass();
                EndInit();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal HeatcaiDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected HeatcaiDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddHeatcaiRow(HeatcaiRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatcaiRow AddHeatcaiRow(string loginId, string custId, string custType,
                string password, string secretQ, string secretA, int flags, int dtCreated, int dtLastMod,
                string lastModBy)
            {
                var heatcaiRow = (HeatcaiRow) NewRow();
                var objArray = new object[10]
                {
                    (object) loginId,
                    (object) custId,
                    (object) custType,
                    (object) password,
                    (object) secretQ,
                    (object) secretA,
                    (object) flags,
                    (object) dtCreated,
                    (object) dtLastMod,
                    (object) lastModBy
                };
                heatcaiRow.ItemArray = objArray;
                Rows.Add((DataRow) heatcaiRow);
                return heatcaiRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var heatcaiDataTable = (HeatcaiDataTable) base.Clone();
                heatcaiDataTable.InitVars();
                return (DataTable) heatcaiDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new HeatcaiDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnLoginId = Columns["LoginID"];
                _columnCustId = Columns["CustID"];
                _columnCustType = Columns["CustType"];
                _columnPassword = Columns["Password"];
                _columnSecretQ = Columns["SecretQ"];
                _columnSecretA = Columns["SecretA"];
                _columnFlags = Columns["Flags"];
                _columnDtCreated = Columns["DTCreated"];
                _columnDtLastMod = Columns["DTLastMod"];
                _columnLastModBy = Columns["LastModBy"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnLoginId = new DataColumn("LoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginId);
                _columnCustId = new DataColumn("CustID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustId);
                _columnCustType = new DataColumn("CustType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustType);
                _columnPassword = new DataColumn("Password", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPassword);
                _columnSecretQ = new DataColumn("SecretQ", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSecretQ);
                _columnSecretA = new DataColumn("SecretA", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSecretA);
                _columnFlags = new DataColumn("Flags", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnFlags);
                _columnDtCreated = new DataColumn("DTCreated", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtCreated);
                _columnDtLastMod = new DataColumn("DTLastMod", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtLastMod);
                _columnLastModBy = new DataColumn("LastModBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLastModBy);
                _columnLoginId.AllowDBNull = false;
                _columnLoginId.MaxLength = 96;
                _columnCustId.MaxLength = 50;
                _columnCustType.MaxLength = 50;
                _columnPassword.MaxLength = 75;
                _columnSecretQ.MaxLength = 100;
                _columnSecretA.MaxLength = 50;
                _columnLastModBy.MaxLength = 96;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatcaiRow NewHeatcaiRow()
            {
                return (HeatcaiRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new HeatcaiRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(HeatcaiRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (HeatcaiRowChanged == null)
                    return;
                HeatcaiRowChanged((object) this,
                    new HeatcaiRowChangeEvent((HeatcaiRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (HeatcaiRowChanging == null)
                    return;
                HeatcaiRowChanging((object) this,
                    new HeatcaiRowChangeEvent((HeatcaiRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (HeatcaiRowDeleted == null)
                    return;
                HeatcaiRowDeleted((object) this,
                    new HeatcaiRowChangeEvent((HeatcaiRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (HeatcaiRowDeleting == null)
                    return;
                HeatcaiRowDeleting((object) this,
                    new HeatcaiRowChangeEvent((HeatcaiRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveHeatcaiRow(HeatcaiRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "HEATCAIDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class HeatLoginStatusDataTable : TypedTableBase<HeatLoginStatusRow>
        {
            private DataColumn _columnComputerName;
            private DataColumn _columnComputerDomain;
            private DataColumn _columnUserName;
            private DataColumn _columnUserDomain;
            private DataColumn _columnAppName;
            private DataColumn _columnHeatLogin;
            private DataColumn _columnLoginTime;
            private DataColumn _columnLoginServerTime;
            private DataColumn _columnLoginSuccess;
            private DataColumn _columnLogoutTime;
            private DataColumn _columnHeatVersion;
            private DataColumn _columnHeatTimeZoneOffset;
            private DataColumn _columnSystemTimeZoneOffset;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ComputerNameColumn
            {
                get { return _columnComputerName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ComputerDomainColumn
            {
                get { return _columnComputerDomain; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn UserNameColumn
            {
                get { return _columnUserName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn UserDomainColumn
            {
                get { return _columnUserDomain; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AppNameColumn
            {
                get { return _columnAppName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HeatLoginColumn
            {
                get { return _columnHeatLogin; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginTimeColumn
            {
                get { return _columnLoginTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginServerTimeColumn
            {
                get { return _columnLoginServerTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginSuccessColumn
            {
                get { return _columnLoginSuccess; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LogoutTimeColumn
            {
                get { return _columnLogoutTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HeatVersionColumn
            {
                get { return _columnHeatVersion; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HeatTimeZoneOffsetColumn
            {
                get { return _columnHeatTimeZoneOffset; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SystemTimeZoneOffsetColumn
            {
                get { return _columnSystemTimeZoneOffset; }
            }

            [Browsable(false)]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatLoginStatusRow this[int index]
            {
                get { return (HeatLoginStatusRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatLoginStatusRowChangeEventHandler HeatLoginStatusRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatLoginStatusRowChangeEventHandler HeatLoginStatusRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatLoginStatusRowChangeEventHandler HeatLoginStatusRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HeatLoginStatusRowChangeEventHandler HeatLoginStatusRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatLoginStatusDataTable()
            {
                TableName = "HEATLoginStatus";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal HeatLoginStatusDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected HeatLoginStatusDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddHeatLoginStatusRow(HeatLoginStatusRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatLoginStatusRow AddHeatLoginStatusRow(string computerName, string computerDomain,
                string userName, string userDomain, string appName, string heatLogin, string loginTime,
                string loginServerTime, string loginSuccess, string logoutTime, string heatVersion,
                string heatTimeZoneOffset, string systemTimeZoneOffset)
            {
                var heatLoginStatusRow = (HeatLoginStatusRow) NewRow();
                var objArray = new object[13]
                {
                    (object) computerName,
                    (object) computerDomain,
                    (object) userName,
                    (object) userDomain,
                    (object) appName,
                    (object) heatLogin,
                    (object) loginTime,
                    (object) loginServerTime,
                    (object) loginSuccess,
                    (object) logoutTime,
                    (object) heatVersion,
                    (object) heatTimeZoneOffset,
                    (object) systemTimeZoneOffset
                };
                heatLoginStatusRow.ItemArray = objArray;
                Rows.Add((DataRow) heatLoginStatusRow);
                return heatLoginStatusRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatLoginStatusRow FindByComputerNameComputerDomainUserNameUserDomainAppNameHeatLogin(
                string computerName, string computerDomain, string userName, string userDomain, string appName,
                string heatLogin)
            {
                return (HeatLoginStatusRow) Rows.Find(new object[6]
                {
                    (object) computerName,
                    (object) computerDomain,
                    (object) userName,
                    (object) userDomain,
                    (object) appName,
                    (object) heatLogin
                });
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                var loginStatusDataTable =
                    (HeatLoginStatusDataTable) base.Clone();
                loginStatusDataTable.InitVars();
                return (DataTable) loginStatusDataTable;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new HeatLoginStatusDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnComputerName = Columns["ComputerName"];
                _columnComputerDomain = Columns["ComputerDomain"];
                _columnUserName = Columns["UserName"];
                _columnUserDomain = Columns["UserDomain"];
                _columnAppName = Columns["AppName"];
                _columnHeatLogin = Columns["HeatLogin"];
                _columnLoginTime = Columns["LoginTime"];
                _columnLoginServerTime = Columns["LoginServerTime"];
                _columnLoginSuccess = Columns["LoginSuccess"];
                _columnLogoutTime = Columns["LogoutTime"];
                _columnHeatVersion = Columns["HeatVersion"];
                _columnHeatTimeZoneOffset = Columns["HeatTimeZoneOffset"];
                _columnSystemTimeZoneOffset = Columns["SystemTimeZoneOffset"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnComputerName = new DataColumn("ComputerName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnComputerName);
                _columnComputerDomain = new DataColumn("ComputerDomain", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnComputerDomain);
                _columnUserName = new DataColumn("UserName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnUserName);
                _columnUserDomain = new DataColumn("UserDomain", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnUserDomain);
                _columnAppName = new DataColumn("AppName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAppName);
                _columnHeatLogin = new DataColumn("HeatLogin", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnHeatLogin);
                _columnLoginTime = new DataColumn("LoginTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginTime);
                _columnLoginServerTime = new DataColumn("LoginServerTime", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnLoginServerTime);
                _columnLoginSuccess = new DataColumn("LoginSuccess", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginSuccess);
                _columnLogoutTime = new DataColumn("LogoutTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLogoutTime);
                _columnHeatVersion = new DataColumn("HeatVersion", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnHeatVersion);
                _columnHeatTimeZoneOffset = new DataColumn("HeatTimeZoneOffset", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnHeatTimeZoneOffset);
                _columnSystemTimeZoneOffset = new DataColumn("SystemTimeZoneOffset", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnSystemTimeZoneOffset);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[6]
                {
                    _columnComputerName,
                    _columnComputerDomain,
                    _columnUserName,
                    _columnUserDomain,
                    _columnAppName,
                    _columnHeatLogin
                }, 1 != 0));
                _columnComputerName.AllowDBNull = false;
                _columnComputerName.MaxLength = (int) byte.MaxValue;
                _columnComputerDomain.AllowDBNull = false;
                _columnComputerDomain.MaxLength = (int) byte.MaxValue;
                _columnUserName.AllowDBNull = false;
                _columnUserName.MaxLength = (int) byte.MaxValue;
                _columnUserDomain.AllowDBNull = false;
                _columnUserDomain.MaxLength = (int) byte.MaxValue;
                _columnAppName.AllowDBNull = false;
                _columnAppName.MaxLength = 50;
                _columnHeatLogin.AllowDBNull = false;
                _columnHeatLogin.MaxLength = 96;
                _columnLoginTime.MaxLength = 50;
                _columnLoginServerTime.MaxLength = 50;
                _columnLoginSuccess.MaxLength = 1;
                _columnLogoutTime.MaxLength = 50;
                _columnHeatVersion.MaxLength = 15;
                _columnHeatTimeZoneOffset.MaxLength = 6;
                _columnSystemTimeZoneOffset.MaxLength = 6;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HeatLoginStatusRow NewHeatLoginStatusRow()
            {
                return (HeatLoginStatusRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new HeatLoginStatusRow(builder);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(HeatLoginStatusRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (HeatLoginStatusRowChanged == null)
                    return;
                HeatLoginStatusRowChanged((object) this,
                    new HeatLoginStatusRowChangeEvent((HeatLoginStatusRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (HeatLoginStatusRowChanging == null)
                    return;
                HeatLoginStatusRowChanging((object) this,
                    new HeatLoginStatusRowChangeEvent((HeatLoginStatusRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (HeatLoginStatusRowDeleted == null)
                    return;
                HeatLoginStatusRowDeleted((object) this,
                    new HeatLoginStatusRowChangeEvent((HeatLoginStatusRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (HeatLoginStatusRowDeleting == null)
                    return;
                HeatLoginStatusRowDeleting((object) this,
                    new HeatLoginStatusRowChangeEvent((HeatLoginStatusRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void RemoveHeatLoginStatusRow(HeatLoginStatusRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "HEATLoginStatusDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class JournalDataTable : TypedTableBase<JournalRow>
        {
            private DataColumn _columnCallId;
            private DataColumn _columnHeatSeq;
            private DataColumn _columnTracker;
            private DataColumn _columnEntryDate;
            private DataColumn _columnEntryTime;
            private DataColumn _columnEntryText;
            private DataColumn _columnJournalType;
            private DataColumn _columnDtLastMod;
            private DataColumn _columnTempField;
            private DataColumn _columnTotalJournalTime;
            private DataColumn _columnDisplayHss;
            private DataColumn _columnPmoSecurity;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallIdColumn
            {
                get { return _columnCallId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn HeatSeqColumn
            {
                get { return _columnHeatSeq; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TrackerColumn
            {
                get { return _columnTracker; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn EntryDateColumn
            {
                get { return _columnEntryDate; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn EntryTimeColumn
            {
                get { return _columnEntryTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EntryTextColumn
            {
                get { return _columnEntryText; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn JournalTypeColumn
            {
                get { return _columnJournalType; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DtLastModColumn
            {
                get { return _columnDtLastMod; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TempFieldColumn
            {
                get { return _columnTempField; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TotalJournalTimeColumn
            {
                get { return _columnTotalJournalTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DisplayHssColumn
            {
                get { return _columnDisplayHss; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PmoSecurityColumn
            {
                get { return _columnPmoSecurity; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            [DebuggerNonUserCode]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public JournalRow this[int index]
            {
                get { return (JournalRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event JournalRowChangeEventHandler JournalRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event JournalRowChangeEventHandler JournalRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event JournalRowChangeEventHandler JournalRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event JournalRowChangeEventHandler JournalRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public JournalDataTable()
            {
                TableName = "Journal";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal JournalDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected JournalDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddJournalRow(JournalRow row)
            {
                Rows.Add((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public JournalRow AddJournalRow(string callId, int heatSeq, string tracker, string entryDate,
                string entryTime, string entryText, string journalType, int dtLastMod, string tempField,
                int totalJournalTime, string displayHss, string pmoSecurity)
            {
                var journalRow = (JournalRow) NewRow();
                var objArray = new object[12]
                {
                    (object) callId,
                    (object) heatSeq,
                    (object) tracker,
                    (object) entryDate,
                    (object) entryTime,
                    (object) entryText,
                    (object) journalType,
                    (object) dtLastMod,
                    (object) tempField,
                    (object) totalJournalTime,
                    (object) displayHss,
                    (object) pmoSecurity
                };
                journalRow.ItemArray = objArray;
                Rows.Add((DataRow) journalRow);
                return journalRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public JournalRow FindByCallIdheatSeq(string callId, int heatSeq)
            {
                return (JournalRow) Rows.Find(new object[2]
                {
                    (object) callId,
                    (object) heatSeq
                });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var journalDataTable = (JournalDataTable) base.Clone();
                journalDataTable.InitVars();
                return (DataTable) journalDataTable;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new JournalDataTable();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                _columnCallId = Columns["CallID"];
                _columnHeatSeq = Columns["HEATSeq"];
                _columnTracker = Columns["Tracker"];
                _columnEntryDate = Columns["EntryDate"];
                _columnEntryTime = Columns["EntryTime"];
                _columnEntryText = Columns["EntryText"];
                _columnJournalType = Columns["JournalType"];
                _columnDtLastMod = Columns["DTLastMod"];
                _columnTempField = Columns["TempField"];
                _columnTotalJournalTime = Columns["TotalJournalTime"];
                _columnDisplayHss = Columns["DisplayHSS"];
                _columnPmoSecurity = Columns["PMOSecurity"];
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                _columnCallId = new DataColumn("CallID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallId);
                _columnHeatSeq = new DataColumn("HEATSeq", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnHeatSeq);
                _columnTracker = new DataColumn("Tracker", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTracker);
                _columnEntryDate = new DataColumn("EntryDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEntryDate);
                _columnEntryTime = new DataColumn("EntryTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEntryTime);
                _columnEntryText = new DataColumn("EntryText", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEntryText);
                _columnJournalType = new DataColumn("JournalType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnJournalType);
                _columnDtLastMod = new DataColumn("DTLastMod", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtLastMod);
                _columnTempField = new DataColumn("TempField", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTempField);
                _columnTotalJournalTime = new DataColumn("TotalJournalTime", typeof(int), (string) null,
                    MappingType.Element);
                Columns.Add(_columnTotalJournalTime);
                _columnDisplayHss = new DataColumn("DisplayHSS", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDisplayHss);
                _columnPmoSecurity = new DataColumn("PMOSecurity", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPmoSecurity);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
                {
                    _columnCallId,
                    _columnHeatSeq
                }, 1 != 0));
                _columnCallId.AllowDBNull = false;
                _columnCallId.MaxLength = 8;
                _columnHeatSeq.AllowDBNull = false;
                _columnTracker.MaxLength = 96;
                _columnEntryDate.MaxLength = 10;
                _columnEntryTime.MaxLength = 8;
                _columnEntryText.MaxLength = int.MaxValue;
                _columnJournalType.MaxLength = 25;
                _columnTempField.MaxLength = 100;
                _columnDisplayHss.MaxLength = 1;
                _columnPmoSecurity.MaxLength = int.MaxValue;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public JournalRow NewJournalRow()
            {
                return (JournalRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new JournalRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(JournalRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (JournalRowChanged == null)
                    return;
                JournalRowChanged((object) this,
                    new JournalRowChangeEvent((JournalRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (JournalRowChanging == null)
                    return;
                JournalRowChanging((object) this,
                    new JournalRowChangeEvent((JournalRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (JournalRowDeleted == null)
                    return;
                JournalRowDeleted((object) this,
                    new JournalRowChangeEvent((JournalRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (JournalRowDeleting == null)
                    return;
                JournalRowDeleting((object) this,
                    new JournalRowChangeEvent((JournalRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveJournalRow(JournalRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "JournalDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class ProfileDataTable : TypedTableBase<ProfileRow>
        {
            private DataColumn _columnCustId;
            private DataColumn _columnCustType;
            private DataColumn _columnFirstName;
            private DataColumn _columnLastName;
            private DataColumn _columnTitle;
            private DataColumn _columnEMailId;
            private DataColumn _columnNotes;
            private DataColumn _columnModBy;
            private DataColumn _columnModDate;
            private DataColumn _columnModTime;
            private DataColumn _columnSlaClass;
            private DataColumn _columnDtLastMod;
            private DataColumn _columnMiddleName;
            private DataColumn _columnNetworkLoginId;
            private DataColumn _columnDateTimeAup;
            private DataColumn _columnDateTimeMailbox;
            private DataColumn _columnDateTimeLogged;
            private DataColumn _columnAuthorizedMailbox;
            private DataColumn _columnJobCode;
            private DataColumn _columnJobDescription;
            private DataColumn _columnAdsldapPath;
            private DataColumn _columnAdsHomeDirectory;
            private DataColumn _columnAdsProfilePath;
            private DataColumn _columnAdsScriptPath;
            private DataColumn _columnAdssifrefid;
            private DataColumn _columnRcNumber;
            private DataColumn _columnRegion;
            private DataColumn _columnRcName;
            private DataColumn _columnRcAddress1;
            private DataColumn _columnRcCity;
            private DataColumn _columnRcState;
            private DataColumn _columnRcZipCode;
            private DataColumn _columnRcPhone;
            private DataColumn _columnRcFax;
            private DataColumn _columnCompanyName;
            private DataColumn _columnCompanyRegion;
            private DataColumn _columnCompanyPhone;
            private DataColumn _columnCompanyFax;
            private DataColumn _columnProfileType;
            private DataColumn _columnRcZone;
            private DataColumn _columnDisplayName;
            private DataColumn _columnuDomain;
            private DataColumn _columnCompanyPhoneExt;
            private DataColumn _columnCompanyCity;
            private DataColumn _columnCompanyState;
            private DataColumn _columnCompanyZip;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CustIdColumn
            {
                get { return _columnCustId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CustTypeColumn
            {
                get { return _columnCustType; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn FirstNameColumn
            {
                get { return _columnFirstName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn LastNameColumn
            {
                get { return _columnLastName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn TitleColumn
            {
                get { return _columnTitle; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EMailIdColumn
            {
                get { return _columnEMailId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn NotesColumn
            {
                get { return _columnNotes; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModByColumn
            {
                get { return _columnModBy; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ModDateColumn
            {
                get { return _columnModDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModTimeColumn
            {
                get { return _columnModTime; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SlaClassColumn
            {
                get { return _columnSlaClass; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DtLastModColumn
            {
                get { return _columnDtLastMod; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MiddleNameColumn
            {
                get { return _columnMiddleName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn NetworkLoginIdColumn
            {
                get { return _columnNetworkLoginId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DateTimeAupColumn
            {
                get { return _columnDateTimeAup; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateTimeMailboxColumn
            {
                get { return _columnDateTimeMailbox; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateTimeLoggedColumn
            {
                get { return _columnDateTimeLogged; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AuthorizedMailboxColumn
            {
                get { return _columnAuthorizedMailbox; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn JobCodeColumn
            {
                get { return _columnJobCode; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn JobDescriptionColumn
            {
                get { return _columnJobDescription; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AdsldapPathColumn
            {
                get { return _columnAdsldapPath; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AdsHomeDirectoryColumn
            {
                get { return _columnAdsHomeDirectory; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AdsProfilePathColumn
            {
                get { return _columnAdsProfilePath; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AdsScriptPathColumn
            {
                get { return _columnAdsScriptPath; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AdssifrefidColumn
            {
                get { return _columnAdssifrefid; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcNumberColumn
            {
                get { return _columnRcNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RegionColumn
            {
                get { return _columnRegion; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcNameColumn
            {
                get { return _columnRcName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcAddress1Column
            {
                get { return _columnRcAddress1; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcCityColumn
            {
                get { return _columnRcCity; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcStateColumn
            {
                get { return _columnRcState; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcZipCodeColumn
            {
                get { return _columnRcZipCode; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcPhoneColumn
            {
                get { return _columnRcPhone; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcFaxColumn
            {
                get { return _columnRcFax; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CompanyNameColumn
            {
                get { return _columnCompanyName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CompanyRegionColumn
            {
                get { return _columnCompanyRegion; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CompanyPhoneColumn
            {
                get { return _columnCompanyPhone; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CompanyFaxColumn
            {
                get { return _columnCompanyFax; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ProfileTypeColumn
            {
                get { return _columnProfileType; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcZoneColumn
            {
                get { return _columnRcZone; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DisplayNameColumn
            {
                get { return _columnDisplayName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn UDomainColumn
            {
                get { return _columnuDomain; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CompanyPhoneExtColumn
            {
                get { return _columnCompanyPhoneExt; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CompanyCityColumn
            {
                get { return _columnCompanyCity; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CompanyStateColumn
            {
                get { return _columnCompanyState; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CompanyZipColumn
            {
                get { return _columnCompanyZip; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public ProfileRow this[int index]
            {
                get { return (ProfileRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProfileRowChangeEventHandler ProfileRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProfileRowChangeEventHandler ProfileRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProfileRowChangeEventHandler ProfileRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProfileRowChangeEventHandler ProfileRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public ProfileDataTable()
            {
                TableName = "Profile";
                BeginInit();
                InitClass();
                EndInit();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ProfileDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ProfileDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddProfileRow(ProfileRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public ProfileRow AddProfileRow(string custId, string custType, string firstName,
                string lastName, string title, string eMailId, string notes, string modBy, string modDate,
                string modTime, string slaClass, int dtLastMod, string middleName, string networkLoginId,
                string dateTimeAup, string dateTimeMailbox, string dateTimeLogged, string authorizedMailbox,
                string jobCode, string jobDescription, string adsldapPath, string adsHomeDirectory,
                string adsProfilePath, string adsScriptPath, string adssifrefid, string rcNumber, string region,
                string rcName, string rcAddress1, string rcCity, string rcState, string rcZipCode, string rcPhone,
                string rcFax, string companyName, string companyRegion, string companyPhone, string companyFax,
                string profileType, string rcZone, string displayName, string uDomain, string companyPhoneExt,
                string companyCity, string companyState, string companyZip)
            {
                var profileRow = (ProfileRow) NewRow();
                var objArray = new object[46]
                {
                    (object) custId,
                    (object) custType,
                    (object) firstName,
                    (object) lastName,
                    (object) title,
                    (object) eMailId,
                    (object) notes,
                    (object) modBy,
                    (object) modDate,
                    (object) modTime,
                    (object) slaClass,
                    (object) dtLastMod,
                    (object) middleName,
                    (object) networkLoginId,
                    (object) dateTimeAup,
                    (object) dateTimeMailbox,
                    (object) dateTimeLogged,
                    (object) authorizedMailbox,
                    (object) jobCode,
                    (object) jobDescription,
                    (object) adsldapPath,
                    (object) adsHomeDirectory,
                    (object) adsProfilePath,
                    (object) adsScriptPath,
                    (object) adssifrefid,
                    (object) rcNumber,
                    (object) region,
                    (object) rcName,
                    (object) rcAddress1,
                    (object) rcCity,
                    (object) rcState,
                    (object) rcZipCode,
                    (object) rcPhone,
                    (object) rcFax,
                    (object) companyName,
                    (object) companyRegion,
                    (object) companyPhone,
                    (object) companyFax,
                    (object) profileType,
                    (object) rcZone,
                    (object) displayName,
                    (object) uDomain,
                    (object) companyPhoneExt,
                    (object) companyCity,
                    (object) companyState,
                    (object) companyZip
                };
                profileRow.ItemArray = objArray;
                Rows.Add((DataRow) profileRow);
                return profileRow;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProfileRow FindByCustIdCustType(string custId, string custType)
            {
                return (ProfileRow) Rows.Find(new object[2]
                {
                    (object) custId,
                    (object) custType
                });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var profileDataTable = (ProfileDataTable) base.Clone();
                profileDataTable.InitVars();
                return (DataTable) profileDataTable;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new ProfileDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnCustId = Columns["CustID"];
                _columnCustType = Columns["CustType"];
                _columnFirstName = Columns["FirstName"];
                _columnLastName = Columns["LastName"];
                _columnTitle = Columns["Title"];
                _columnEMailId = Columns["EMailID"];
                _columnNotes = Columns["Notes"];
                _columnModBy = Columns["ModBy"];
                _columnModDate = Columns["ModDate"];
                _columnModTime = Columns["ModTime"];
                _columnSlaClass = Columns["SLAClass"];
                _columnDtLastMod = Columns["DTLastMod"];
                _columnMiddleName = Columns["MiddleName"];
                _columnNetworkLoginId = Columns["NetworkLoginID"];
                _columnDateTimeAup = Columns["DateTimeAUP"];
                _columnDateTimeMailbox = Columns["DateTimeMailbox"];
                _columnDateTimeLogged = Columns["DateTimeLogged"];
                _columnAuthorizedMailbox = Columns["AuthorizedMailbox"];
                _columnJobCode = Columns["JobCode"];
                _columnJobDescription = Columns["JobDescription"];
                _columnAdsldapPath = Columns["ADSLDAPPath"];
                _columnAdsHomeDirectory = Columns["ADSHomeDirectory"];
                _columnAdsProfilePath = Columns["ADSProfilePath"];
                _columnAdsScriptPath = Columns["ADSScriptPath"];
                _columnAdssifrefid = Columns["ADSSIFREFID"];
                _columnRcNumber = Columns["RCNumber"];
                _columnRegion = Columns["Region"];
                _columnRcName = Columns["RCName"];
                _columnRcAddress1 = Columns["RCAddress1"];
                _columnRcCity = Columns["RCCity"];
                _columnRcState = Columns["RCState"];
                _columnRcZipCode = Columns["RCZipCode"];
                _columnRcPhone = Columns["RCPhone"];
                _columnRcFax = Columns["RCFax"];
                _columnCompanyName = Columns["CompanyName"];
                _columnCompanyRegion = Columns["CompanyRegion"];
                _columnCompanyPhone = Columns["CompanyPhone"];
                _columnCompanyFax = Columns["CompanyFax"];
                _columnProfileType = Columns["ProfileType"];
                _columnRcZone = Columns["RCZone"];
                _columnDisplayName = Columns["DisplayName"];
                _columnuDomain = Columns["uDomain"];
                _columnCompanyPhoneExt = Columns["CompanyPhoneExt"];
                _columnCompanyCity = Columns["CompanyCity"];
                _columnCompanyState = Columns["CompanyState"];
                _columnCompanyZip = Columns["CompanyZip"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnCustId = new DataColumn("CustID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustId);
                _columnCustType = new DataColumn("CustType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustType);
                _columnFirstName = new DataColumn("FirstName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFirstName);
                _columnLastName = new DataColumn("LastName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLastName);
                _columnTitle = new DataColumn("Title", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnTitle);
                _columnEMailId = new DataColumn("EMailID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEMailId);
                _columnNotes = new DataColumn("Notes", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnNotes);
                _columnModBy = new DataColumn("ModBy", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModBy);
                _columnModDate = new DataColumn("ModDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModDate);
                _columnModTime = new DataColumn("ModTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModTime);
                _columnSlaClass = new DataColumn("SLAClass", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSlaClass);
                _columnDtLastMod = new DataColumn("DTLastMod", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnDtLastMod);
                _columnMiddleName = new DataColumn("MiddleName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnMiddleName);
                _columnNetworkLoginId = new DataColumn("NetworkLoginID", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnNetworkLoginId);
                _columnDateTimeAup = new DataColumn("DateTimeAUP", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDateTimeAup);
                _columnDateTimeMailbox = new DataColumn("DateTimeMailbox", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnDateTimeMailbox);
                _columnDateTimeLogged = new DataColumn("DateTimeLogged", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnDateTimeLogged);
                _columnAuthorizedMailbox = new DataColumn("AuthorizedMailbox", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnAuthorizedMailbox);
                _columnJobCode = new DataColumn("JobCode", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnJobCode);
                _columnJobDescription = new DataColumn("JobDescription", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnJobDescription);
                _columnAdsldapPath = new DataColumn("ADSLDAPPath", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAdsldapPath);
                _columnAdsHomeDirectory = new DataColumn("ADSHomeDirectory", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnAdsHomeDirectory);
                _columnAdsProfilePath = new DataColumn("ADSProfilePath", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnAdsProfilePath);
                _columnAdsScriptPath = new DataColumn("ADSScriptPath", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnAdsScriptPath);
                _columnAdssifrefid = new DataColumn("ADSSIFREFID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAdssifrefid);
                _columnRcNumber = new DataColumn("RCNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcNumber);
                _columnRegion = new DataColumn("Region", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRegion);
                _columnRcName = new DataColumn("RCName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcName);
                _columnRcAddress1 = new DataColumn("RCAddress1", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcAddress1);
                _columnRcCity = new DataColumn("RCCity", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcCity);
                _columnRcState = new DataColumn("RCState", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcState);
                _columnRcZipCode = new DataColumn("RCZipCode", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcZipCode);
                _columnRcPhone = new DataColumn("RCPhone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcPhone);
                _columnRcFax = new DataColumn("RCFax", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcFax);
                _columnCompanyName = new DataColumn("CompanyName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCompanyName);
                _columnCompanyRegion = new DataColumn("CompanyRegion", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnCompanyRegion);
                _columnCompanyPhone = new DataColumn("CompanyPhone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCompanyPhone);
                _columnCompanyFax = new DataColumn("CompanyFax", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCompanyFax);
                _columnProfileType = new DataColumn("ProfileType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnProfileType);
                _columnRcZone = new DataColumn("RCZone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcZone);
                _columnDisplayName = new DataColumn("DisplayName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDisplayName);
                _columnuDomain = new DataColumn("uDomain", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnuDomain);
                _columnCompanyPhoneExt = new DataColumn("CompanyPhoneExt", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnCompanyPhoneExt);
                _columnCompanyCity = new DataColumn("CompanyCity", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCompanyCity);
                _columnCompanyState = new DataColumn("CompanyState", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCompanyState);
                _columnCompanyZip = new DataColumn("CompanyZip", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCompanyZip);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
                {
                    _columnCustId,
                    _columnCustType
                }, 1 != 0));
                _columnCustId.AllowDBNull = false;
                _columnCustId.MaxLength = 50;
                _columnCustType.AllowDBNull = false;
                _columnCustType.MaxLength = 50;
                _columnFirstName.MaxLength = 50;
                _columnLastName.MaxLength = 50;
                _columnTitle.MaxLength = 100;
                _columnEMailId.MaxLength = 50;
                _columnNotes.MaxLength = int.MaxValue;
                _columnModBy.MaxLength = 100;
                _columnModDate.MaxLength = 10;
                _columnModTime.MaxLength = 8;
                _columnSlaClass.MaxLength = 15;
                _columnMiddleName.MaxLength = 50;
                _columnNetworkLoginId.MaxLength = 50;
                _columnDateTimeAup.MaxLength = 32;
                _columnDateTimeMailbox.MaxLength = 32;
                _columnDateTimeLogged.MaxLength = 32;
                _columnAuthorizedMailbox.MaxLength = 1;
                _columnJobCode.MaxLength = 10;
                _columnJobDescription.MaxLength = 100;
                _columnAdsldapPath.MaxLength = int.MaxValue;
                _columnAdsHomeDirectory.MaxLength = int.MaxValue;
                _columnAdsProfilePath.MaxLength = int.MaxValue;
                _columnAdsScriptPath.MaxLength = int.MaxValue;
                _columnAdssifrefid.MaxLength = 100;
                _columnRcNumber.MaxLength = 4;
                _columnRegion.MaxLength = 2;
                _columnRcName.MaxLength = 50;
                _columnRcAddress1.MaxLength = 50;
                _columnRcCity.MaxLength = 50;
                _columnRcState.MaxLength = 2;
                _columnRcZipCode.MaxLength = 10;
                _columnRcPhone.MaxLength = 14;
                _columnRcFax.MaxLength = 14;
                _columnCompanyName.MaxLength = 50;
                _columnCompanyRegion.MaxLength = 2;
                _columnCompanyPhone.MaxLength = 14;
                _columnCompanyFax.MaxLength = 14;
                _columnProfileType.MaxLength = 10;
                _columnRcZone.MaxLength = 2;
                _columnDisplayName.MaxLength = 45;
                _columnuDomain.MaxLength = 50;
                _columnCompanyPhoneExt.MaxLength = 5;
                _columnCompanyCity.MaxLength = 20;
                _columnCompanyState.MaxLength = 2;
                _columnCompanyZip.MaxLength = 10;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public ProfileRow NewProfileRow()
            {
                return (ProfileRow) NewRow();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new ProfileRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(ProfileRow);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (ProfileRowChanged == null)
                    return;
                ProfileRowChanged((object) this,
                    new ProfileRowChangeEvent((ProfileRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (ProfileRowChanging == null)
                    return;
                ProfileRowChanging((object) this,
                    new ProfileRowChangeEvent((ProfileRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (ProfileRowDeleted == null)
                    return;
                ProfileRowDeleted((object) this,
                    new ProfileRowChangeEvent((ProfileRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (ProfileRowDeleting == null)
                    return;
                ProfileRowDeleting((object) this,
                    new ProfileRowChangeEvent((ProfileRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveProfileRow(ProfileRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "ProfileDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class SapAssetsDataTable : TypedTableBase<SapAssetsRow>
        {
            private DataColumn _columnAssetNumber;
            private DataColumn _columnSubNumber;
            private DataColumn _columnDescription;
            private DataColumn _columnSubClass;
            private DataColumn _columnSerialNumber;
            private DataColumn _columnLocation;
            private DataColumn _columnBldgRoom;
            private DataColumn _columnCostCenter;
            private DataColumn _columnCapitalizationDate;
            private DataColumn _columnCost;
            private DataColumn _columnInventoryNumber;
            private DataColumn _columnStatus;
            private DataColumn _columnFunctionalArea;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AssetNumberColumn
            {
                get { return _columnAssetNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SubNumberColumn
            {
                get { return _columnSubNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DescriptionColumn
            {
                get { return _columnDescription; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn SubClassColumn
            {
                get { return _columnSubClass; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SerialNumberColumn
            {
                get { return _columnSerialNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn LocationColumn
            {
                get { return _columnLocation; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn BldgRoomColumn
            {
                get { return _columnBldgRoom; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CostCenterColumn
            {
                get { return _columnCostCenter; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CapitalizationDateColumn
            {
                get { return _columnCapitalizationDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn CostColumn
            {
                get { return _columnCost; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn InventoryNumberColumn
            {
                get { return _columnInventoryNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn StatusColumn
            {
                get { return _columnStatus; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FunctionalAreaColumn
            {
                get { return _columnFunctionalArea; }
            }

            [Browsable(false)]
            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get { return Rows.Count; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SapAssetsRow this[int index]
            {
                get { return (SapAssetsRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SapAssetsRowChangeEventHandler SapAssetsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SapAssetsRowChangeEventHandler SapAssetsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SapAssetsRowChangeEventHandler SapAssetsRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SapAssetsRowChangeEventHandler SapAssetsRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SapAssetsDataTable()
            {
                TableName = "SAPAssets";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal SapAssetsDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected SapAssetsDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddSapAssetsRow(SapAssetsRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public SapAssetsRow AddSapAssetsRow(string assetNumber, string subNumber, string description,
                string subClass, string serialNumber, string location, string bldgRoom, string costCenter,
                string capitalizationDate, decimal cost, string inventoryNumber, string status, string functionalArea)
            {
                var sapAssetsRow = (SapAssetsRow) NewRow();
                var objArray = new object[13]
                {
                    (object) assetNumber,
                    (object) subNumber,
                    (object) description,
                    (object) subClass,
                    (object) serialNumber,
                    (object) location,
                    (object) bldgRoom,
                    (object) costCenter,
                    (object) capitalizationDate,
                    (object) cost,
                    (object) inventoryNumber,
                    (object) status,
                    (object) functionalArea
                };
                sapAssetsRow.ItemArray = objArray;
                Rows.Add((DataRow) sapAssetsRow);
                return sapAssetsRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var sapAssetsDataTable = (SapAssetsDataTable) base.Clone();
                sapAssetsDataTable.InitVars();
                return (DataTable) sapAssetsDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new SapAssetsDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnAssetNumber = Columns["AssetNumber"];
                _columnSubNumber = Columns["SubNumber"];
                _columnDescription = Columns["Description"];
                _columnSubClass = Columns["SubClass"];
                _columnSerialNumber = Columns["SerialNumber"];
                _columnLocation = Columns["Location"];
                _columnBldgRoom = Columns["BldgRoom"];
                _columnCostCenter = Columns["CostCenter"];
                _columnCapitalizationDate = Columns["CapitalizationDate"];
                _columnCost = Columns["Cost"];
                _columnInventoryNumber = Columns["InventoryNumber"];
                _columnStatus = Columns["Status"];
                _columnFunctionalArea = Columns["FunctionalArea"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnAssetNumber = new DataColumn("AssetNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssetNumber);
                _columnSubNumber = new DataColumn("SubNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSubNumber);
                _columnDescription = new DataColumn("Description", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDescription);
                _columnSubClass = new DataColumn("SubClass", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSubClass);
                _columnSerialNumber = new DataColumn("SerialNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSerialNumber);
                _columnLocation = new DataColumn("Location", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLocation);
                _columnBldgRoom = new DataColumn("BldgRoom", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnBldgRoom);
                _columnCostCenter = new DataColumn("CostCenter", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCostCenter);
                _columnCapitalizationDate = new DataColumn("CapitalizationDate", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnCapitalizationDate);
                _columnCost = new DataColumn("Cost", typeof(decimal), (string) null, MappingType.Element);
                Columns.Add(_columnCost);
                _columnInventoryNumber = new DataColumn("InventoryNumber", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnInventoryNumber);
                _columnStatus = new DataColumn("Status", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnStatus);
                _columnFunctionalArea = new DataColumn("FunctionalArea", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnFunctionalArea);
                _columnAssetNumber.MaxLength = 12;
                _columnSubNumber.MaxLength = 4;
                _columnDescription.MaxLength = 50;
                _columnSubClass.MaxLength = 8;
                _columnSerialNumber.MaxLength = 18;
                _columnLocation.MaxLength = 4;
                _columnBldgRoom.MaxLength = 8;
                _columnCostCenter.MaxLength = 10;
                _columnCapitalizationDate.MaxLength = 10;
                _columnInventoryNumber.MaxLength = 25;
                _columnStatus.MaxLength = 4;
                _columnFunctionalArea.MaxLength = 15;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public SapAssetsRow NewSapAssetsRow()
            {
                return (SapAssetsRow) NewRow();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new SapAssetsRow(builder);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(SapAssetsRow);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (SapAssetsRowChanged == null)
                    return;
                SapAssetsRowChanged((object) this,
                    new SapAssetsRowChangeEvent((SapAssetsRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (SapAssetsRowChanging == null)
                    return;
                SapAssetsRowChanging((object) this,
                    new SapAssetsRowChangeEvent((SapAssetsRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (SapAssetsRowDeleted == null)
                    return;
                SapAssetsRowDeleted((object) this,
                    new SapAssetsRowChangeEvent((SapAssetsRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (SapAssetsRowDeleting == null)
                    return;
                SapAssetsRowDeleting((object) this,
                    new SapAssetsRowChangeEvent((SapAssetsRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveSapAssetsRow(SapAssetsRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "SAPAssetsDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class SubsetDataTable : TypedTableBase<SubsetRow>
        {
            private DataColumn _columnCustId;
            private DataColumn _columnCallId;
            private DataColumn _columnCustType;
            private DataColumn _columnFirstName;
            private DataColumn _columnLastName;
            private DataColumn _columnEMailId;
            private DataColumn _columnLoginId;
            private DataColumn _columnJobDescription;
            private DataColumn _columnRbCustId;
            private DataColumn _columnRbLoginId;
            private DataColumn _columnRbFirstName;
            private DataColumn _columnRbLastName;
            private DataColumn _columnRbJobDescription;
            private DataColumn _columnRbEmail;
            private DataColumn _columnAssetNum;
            private DataColumn _columnSerialNum;
            private DataColumn _columnPcName;
            private DataColumn _columnBldgNum;
            private DataColumn _columnRoomNum;
            private DataColumn _columnRcNumber;
            private DataColumn _columnRcRegion;
            private DataColumn _columnRcZone;
            private DataColumn _columnRcName;
            private DataColumn _columnRcPhone;
            private DataColumn _columnRcPhoneExt;
            private DataColumn _columnOnSiteTechnician;
            private DataColumn _columnCaller;
            private DataColumn _columnContact;
            private DataColumn _columnDisplayName;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CustIdColumn
            {
                get { return _columnCustId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallIdColumn
            {
                get { return _columnCallId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CustTypeColumn
            {
                get { return _columnCustType; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FirstNameColumn
            {
                get { return _columnFirstName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn LastNameColumn
            {
                get { return _columnLastName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EMailIdColumn
            {
                get { return _columnEMailId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn LoginIdColumn
            {
                get { return _columnLoginId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn JobDescriptionColumn
            {
                get { return _columnJobDescription; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RbCustIdColumn
            {
                get { return _columnRbCustId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RbLoginIdColumn
            {
                get { return _columnRbLoginId; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RbFirstNameColumn
            {
                get { return _columnRbFirstName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RbLastNameColumn
            {
                get { return _columnRbLastName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RbJobDescriptionColumn
            {
                get { return _columnRbJobDescription; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RbEmailColumn
            {
                get { return _columnRbEmail; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn AssetNumColumn
            {
                get { return _columnAssetNum; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SerialNumColumn
            {
                get { return _columnSerialNum; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn PcNameColumn
            {
                get { return _columnPcName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn BldgNumColumn
            {
                get { return _columnBldgNum; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RoomNumColumn
            {
                get { return _columnRoomNum; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcNumberColumn
            {
                get { return _columnRcNumber; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcRegionColumn
            {
                get { return _columnRcRegion; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcZoneColumn
            {
                get { return _columnRcZone; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcNameColumn
            {
                get { return _columnRcName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn RcPhoneColumn
            {
                get { return _columnRcPhone; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn RcPhoneExtColumn
            {
                get { return _columnRcPhoneExt; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn OnSiteTechnicianColumn
            {
                get { return _columnOnSiteTechnician; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CallerColumn
            {
                get { return _columnCaller; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ContactColumn
            {
                get { return _columnContact; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn DisplayNameColumn
            {
                get { return _columnDisplayName; }
            }

            [Browsable(false)]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int Count
            {
                get { return Rows.Count; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SubsetRow this[int index]
            {
                get { return (SubsetRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SubsetRowChangeEventHandler SubsetRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SubsetRowChangeEventHandler SubsetRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SubsetRowChangeEventHandler SubsetRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SubsetRowChangeEventHandler SubsetRowDeleted;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SubsetDataTable()
            {
                TableName = "Subset";
                BeginInit();
                InitClass();
                EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal SubsetDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected SubsetDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddSubsetRow(SubsetRow row)
            {
                Rows.Add((DataRow) row);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SubsetRow AddSubsetRow(string custId, string callId, string custType, string firstName,
                string lastName, string eMailId, string loginId, string jobDescription, string rbCustId,
                string rbLoginId, string rbFirstName, string rbLastName, string rbJobDescription, string rbEmail,
                string assetNum, string serialNum, string pcName, string bldgNum, string roomNum, string rcNumber,
                string rcRegion, string rcZone, string rcName, string rcPhone, string rcPhoneExt,
                string onSiteTechnician, string caller, string contact, string displayName)
            {
                var subsetRow = (SubsetRow) NewRow();
                var objArray = new object[29]
                {
                    (object) custId,
                    (object) callId,
                    (object) custType,
                    (object) firstName,
                    (object) lastName,
                    (object) eMailId,
                    (object) loginId,
                    (object) jobDescription,
                    (object) rbCustId,
                    (object) rbLoginId,
                    (object) rbFirstName,
                    (object) rbLastName,
                    (object) rbJobDescription,
                    (object) rbEmail,
                    (object) assetNum,
                    (object) serialNum,
                    (object) pcName,
                    (object) bldgNum,
                    (object) roomNum,
                    (object) rcNumber,
                    (object) rcRegion,
                    (object) rcZone,
                    (object) rcName,
                    (object) rcPhone,
                    (object) rcPhoneExt,
                    (object) onSiteTechnician,
                    (object) caller,
                    (object) contact,
                    (object) displayName
                };
                subsetRow.ItemArray = objArray;
                Rows.Add((DataRow) subsetRow);
                return subsetRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public SubsetRow FindByCallId(string callId)
            {
                return (SubsetRow) Rows.Find(new object[1]
                {
                    (object) callId
                });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public override DataTable Clone()
            {
                var subsetDataTable = (SubsetDataTable) base.Clone();
                subsetDataTable.InitVars();
                return (DataTable) subsetDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new SubsetDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnCustId = Columns["CustID"];
                _columnCallId = Columns["CallID"];
                _columnCustType = Columns["CustType"];
                _columnFirstName = Columns["FirstName"];
                _columnLastName = Columns["LastName"];
                _columnEMailId = Columns["EMailID"];
                _columnLoginId = Columns["LoginID"];
                _columnJobDescription = Columns["JobDescription"];
                _columnRbCustId = Columns["RBCustID"];
                _columnRbLoginId = Columns["RBLoginID"];
                _columnRbFirstName = Columns["RBFirstName"];
                _columnRbLastName = Columns["RBLastName"];
                _columnRbJobDescription = Columns["RBJobDescription"];
                _columnRbEmail = Columns["RBEmail"];
                _columnAssetNum = Columns["AssetNum"];
                _columnSerialNum = Columns["SerialNum"];
                _columnPcName = Columns["PCName"];
                _columnBldgNum = Columns["BldgNum"];
                _columnRoomNum = Columns["RoomNum"];
                _columnRcNumber = Columns["RCNumber"];
                _columnRcRegion = Columns["RCRegion"];
                _columnRcZone = Columns["RCZone"];
                _columnRcName = Columns["RCName"];
                _columnRcPhone = Columns["RCPhone"];
                _columnRcPhoneExt = Columns["RCPhoneExt"];
                _columnOnSiteTechnician = Columns["OnSiteTechnician"];
                _columnCaller = Columns["Caller"];
                _columnContact = Columns["Contact"];
                _columnDisplayName = Columns["DisplayName"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            private void InitClass()
            {
                _columnCustId = new DataColumn("CustID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustId);
                _columnCallId = new DataColumn("CallID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCallId);
                _columnCustType = new DataColumn("CustType", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCustType);
                _columnFirstName = new DataColumn("FirstName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFirstName);
                _columnLastName = new DataColumn("LastName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLastName);
                _columnEMailId = new DataColumn("EMailID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnEMailId);
                _columnLoginId = new DataColumn("LoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginId);
                _columnJobDescription = new DataColumn("JobDescription", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnJobDescription);
                _columnRbCustId = new DataColumn("RBCustID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRbCustId);
                _columnRbLoginId = new DataColumn("RBLoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRbLoginId);
                _columnRbFirstName = new DataColumn("RBFirstName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRbFirstName);
                _columnRbLastName = new DataColumn("RBLastName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRbLastName);
                _columnRbJobDescription = new DataColumn("RBJobDescription", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnRbJobDescription);
                _columnRbEmail = new DataColumn("RBEmail", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRbEmail);
                _columnAssetNum = new DataColumn("AssetNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnAssetNum);
                _columnSerialNum = new DataColumn("SerialNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSerialNum);
                _columnPcName = new DataColumn("PCName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnPcName);
                _columnBldgNum = new DataColumn("BldgNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnBldgNum);
                _columnRoomNum = new DataColumn("RoomNum", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRoomNum);
                _columnRcNumber = new DataColumn("RCNumber", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcNumber);
                _columnRcRegion = new DataColumn("RCRegion", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcRegion);
                _columnRcZone = new DataColumn("RCZone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcZone);
                _columnRcName = new DataColumn("RCName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcName);
                _columnRcPhone = new DataColumn("RCPhone", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcPhone);
                _columnRcPhoneExt = new DataColumn("RCPhoneExt", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnRcPhoneExt);
                _columnOnSiteTechnician = new DataColumn("OnSiteTechnician", typeof(string), (string) null,
                    MappingType.Element);
                Columns.Add(_columnOnSiteTechnician);
                _columnCaller = new DataColumn("Caller", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnCaller);
                _columnContact = new DataColumn("Contact", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnContact);
                _columnDisplayName = new DataColumn("DisplayName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDisplayName);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
                {
                    _columnCallId
                }, 1 != 0));
                _columnCustId.MaxLength = 50;
                _columnCallId.AllowDBNull = false;
                _columnCallId.Unique = true;
                _columnCallId.MaxLength = 8;
                _columnCustType.MaxLength = 50;
                _columnFirstName.MaxLength = 20;
                _columnLastName.MaxLength = 25;
                _columnEMailId.MaxLength = 50;
                _columnLoginId.MaxLength = 50;
                _columnJobDescription.MaxLength = 75;
                _columnRbCustId.MaxLength = 50;
                _columnRbLoginId.MaxLength = 50;
                _columnRbFirstName.MaxLength = 50;
                _columnRbLastName.MaxLength = 50;
                _columnRbJobDescription.MaxLength = 75;
                _columnRbEmail.MaxLength = 100;
                _columnAssetNum.MaxLength = 20;
                _columnSerialNum.MaxLength = 20;
                _columnPcName.MaxLength = 30;
                _columnBldgNum.MaxLength = 15;
                _columnRoomNum.MaxLength = 15;
                _columnRcNumber.MaxLength = 4;
                _columnRcRegion.MaxLength = 2;
                _columnRcZone.MaxLength = 2;
                _columnRcName.MaxLength = 100;
                _columnRcPhone.MaxLength = 14;
                _columnRcPhoneExt.MaxLength = 10;
                _columnOnSiteTechnician.MaxLength = 50;
                _columnCaller.MaxLength = 100;
                _columnContact.MaxLength = 100;
                _columnDisplayName.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public SubsetRow NewSubsetRow()
            {
                return (SubsetRow) NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new SubsetRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(SubsetRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (SubsetRowChanged == null)
                    return;
                SubsetRowChanged((object) this,
                    new SubsetRowChangeEvent((SubsetRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (SubsetRowChanging == null)
                    return;
                SubsetRowChanging((object) this,
                    new SubsetRowChangeEvent((SubsetRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (SubsetRowDeleted == null)
                    return;
                SubsetRowDeleted((object) this,
                    new SubsetRowChangeEvent((SubsetRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (SubsetRowDeleting == null)
                    return;
                SubsetRowDeleting((object) this,
                    new SubsetRowChangeEvent((SubsetRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void RemoveSubsetRow(SubsetRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "SubsetDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        [XmlSchemaProvider("GetTypedTableSchema")]
        [Serializable]
        public class TrackerDataTable : TypedTableBase<TrackerRow>
        {
            private DataColumn _columnLoginId;
            private DataColumn _columnFullName;
            private DataColumn _columnHeatPass;
            private DataColumn _columnSecGroup;
            private DataColumn _columnManager;
            private DataColumn _columnStatus;
            private DataColumn _columnModPwDate;
            private DataColumn _columnModWho;
            private DataColumn _columnModDate;
            private DataColumn _columnModTime;
            private DataColumn _columnDefTracker;
            private DataColumn _columneMailName;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LoginIdColumn
            {
                get { return _columnLoginId; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn FullNameColumn
            {
                get { return _columnFullName; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn HeatPassColumn
            {
                get { return _columnHeatPass; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SecGroupColumn
            {
                get { return _columnSecGroup; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ManagerColumn
            {
                get { return _columnManager; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn StatusColumn
            {
                get { return _columnStatus; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModPwDateColumn
            {
                get { return _columnModPwDate; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ModWhoColumn
            {
                get { return _columnModWho; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ModDateColumn
            {
                get { return _columnModDate; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn ModTimeColumn
            {
                get { return _columnModTime; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DefTrackerColumn
            {
                get { return _columnDefTracker; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataColumn EMailNameColumn
            {
                get { return _columneMailName; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            [Browsable(false)]
            public int Count
            {
                get { return Rows.Count; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TrackerRow this[int index]
            {
                get { return (TrackerRow) Rows[index]; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TrackerRowChangeEventHandler TrackerRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TrackerRowChangeEventHandler TrackerRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TrackerRowChangeEventHandler TrackerRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TrackerRowChangeEventHandler TrackerRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public TrackerDataTable()
            {
                TableName = "Tracker";
                BeginInit();
                InitClass();
                EndInit();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TrackerDataTable(DataTable table)
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                    CaseSensitive = table.CaseSensitive;
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                    Locale = table.Locale;
                if (table.Namespace != table.DataSet.Namespace)
                    Namespace = table.Namespace;
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected TrackerDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void AddTrackerRow(TrackerRow row)
            {
                Rows.Add((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public TrackerRow AddTrackerRow(string loginId, string fullName, string heatPass,
                string secGroup, string manager, int status, string modPwDate, string modWho, string modDate,
                string modTime, string defTracker, string eMailName)
            {
                var trackerRow = (TrackerRow) NewRow();
                var objArray = new object[12]
                {
                    (object) loginId,
                    (object) fullName,
                    (object) heatPass,
                    (object) secGroup,
                    (object) manager,
                    (object) status,
                    (object) modPwDate,
                    (object) modWho,
                    (object) modDate,
                    (object) modTime,
                    (object) defTracker,
                    (object) eMailName
                };
                trackerRow.ItemArray = objArray;
                Rows.Add((DataRow) trackerRow);
                return trackerRow;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public TrackerRow FindByLoginId(string loginId)
            {
                return (TrackerRow) Rows.Find(new object[1]
                {
                    (object) loginId
                });
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                var trackerDataTable = (TrackerDataTable) base.Clone();
                trackerDataTable.InitVars();
                return (DataTable) trackerDataTable;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return (DataTable) new TrackerDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal void InitVars()
            {
                _columnLoginId = Columns["LoginID"];
                _columnFullName = Columns["FullName"];
                _columnHeatPass = Columns["HEATPass"];
                _columnSecGroup = Columns["SecGroup"];
                _columnManager = Columns["Manager"];
                _columnStatus = Columns["Status"];
                _columnModPwDate = Columns["ModPWDate"];
                _columnModWho = Columns["ModWho"];
                _columnModDate = Columns["ModDate"];
                _columnModTime = Columns["ModTime"];
                _columnDefTracker = Columns["DefTracker"];
                _columneMailName = Columns["eMailName"];
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                _columnLoginId = new DataColumn("LoginID", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnLoginId);
                _columnFullName = new DataColumn("FullName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnFullName);
                _columnHeatPass = new DataColumn("HEATPass", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnHeatPass);
                _columnSecGroup = new DataColumn("SecGroup", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnSecGroup);
                _columnManager = new DataColumn("Manager", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnManager);
                _columnStatus = new DataColumn("Status", typeof(int), (string) null, MappingType.Element);
                Columns.Add(_columnStatus);
                _columnModPwDate = new DataColumn("ModPWDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModPwDate);
                _columnModWho = new DataColumn("ModWho", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModWho);
                _columnModDate = new DataColumn("ModDate", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModDate);
                _columnModTime = new DataColumn("ModTime", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnModTime);
                _columnDefTracker = new DataColumn("DefTracker", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columnDefTracker);
                _columneMailName = new DataColumn("eMailName", typeof(string), (string) null, MappingType.Element);
                Columns.Add(_columneMailName);
                Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
                {
                    _columnLoginId
                }, 1 != 0));
                _columnLoginId.AllowDBNull = false;
                _columnLoginId.Unique = true;
                _columnLoginId.MaxLength = 96;
                _columnFullName.MaxLength = 100;
                _columnHeatPass.MaxLength = 75;
                _columnSecGroup.MaxLength = 30;
                _columnManager.MaxLength = 96;
                _columnModPwDate.MaxLength = 10;
                _columnModWho.MaxLength = 96;
                _columnModDate.MaxLength = 10;
                _columnModTime.MaxLength = 8;
                _columnDefTracker.MaxLength = 96;
                _columneMailName.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public TrackerRow NewTrackerRow()
            {
                return (TrackerRow) NewRow();
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return (DataRow) new TrackerRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(TrackerRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (TrackerRowChanged == null)
                    return;
                TrackerRowChanged((object) this,
                    new TrackerRowChangeEvent((TrackerRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (TrackerRowChanging == null)
                    return;
                TrackerRowChanging((object) this,
                    new TrackerRowChangeEvent((TrackerRow) e.Row, e.Action));
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (TrackerRowDeleted == null)
                    return;
                TrackerRowDeleted((object) this,
                    new TrackerRowChangeEvent((TrackerRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (TrackerRowDeleting == null)
                    return;
                TrackerRowDeleting((object) this,
                    new TrackerRowChangeEvent((TrackerRow) e.Row, e.Action));
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveTrackerRow(TrackerRow row)
            {
                Rows.Remove((DataRow) row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                var schemaComplexType = new XmlSchemaComplexType();
                var xmlSchemaSequence = new XmlSchemaSequence();
                var heaTdbDataSet = new HeaTdbDataSet();
                var xmlSchemaAny1 = new XmlSchemaAny();
                xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
                xmlSchemaAny1.MinOccurs = new decimal(0);
                xmlSchemaAny1.MaxOccurs = new decimal(-1, -1, -1, false, (byte) 0);
                xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
                var xmlSchemaAny2 = new XmlSchemaAny();
                xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                xmlSchemaAny2.MinOccurs = new decimal(1);
                xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
                xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "namespace",
                    FixedValue = heaTdbDataSet.Namespace
                });
                schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
                {
                    Name = "tableTypeName",
                    FixedValue = "TrackerDataTable"
                });
                schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
                var schemaSerializable = heaTdbDataSet.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    var memoryStream1 = new MemoryStream();
                    var memoryStream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write((Stream) memoryStream1);
                        foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
                        {
                            memoryStream2.SetLength(0L);
                            schema.Write((Stream) memoryStream2);
                            if (memoryStream1.Length == memoryStream2.Length)
                            {
                                memoryStream1.Position = 0L;
                                memoryStream2.Position = 0L;
                                do
                                {
                                    ;
                                } while ((memoryStream1.Position != memoryStream1.Length) &&
                                         (memoryStream1.ReadByte() == memoryStream2.ReadByte()));
                                if (memoryStream1.Position == memoryStream1.Length)
                                    return schemaComplexType;
                            }
                        }
                    }
                    finally
                    {
                        if (memoryStream1 != null)
                            memoryStream1.Close();
                        if (memoryStream2 != null)
                            memoryStream2.Close();
                    }
                }
                xs.Add(schemaSerializable);
                return schemaComplexType;
            }
        }

        public class AsgnmntRow : DataRow
        {
            private AsgnmntDataTable _tableAsgnmnt;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AssignedBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.AssignedByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'AssignedBy' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.AssignedByColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DateAssign
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.DateAssignColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DateAssign' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.DateAssignColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string TimeAssign
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.TimeAssignColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TimeAssign' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.TimeAssignColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string GroupName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.GroupNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'GroupName' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.GroupNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Assignee
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.AssigneeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Assignee' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.AssigneeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Phone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.PhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Phone' in table 'Asgnmnt' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.PhoneColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Notes
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.NotesColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Notes' in table 'Asgnmnt' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.NotesColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string DateAcknow
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.DateAcknowColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DateAcknow' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.DateAcknowColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string TimeAcknow
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.TimeAcknowColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TimeAcknow' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.TimeAcknowColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DateResolv
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.DateResolvColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DateResolv' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.DateResolvColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string TimeResolv
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.TimeResolvColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TimeResolv' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.TimeResolvColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Resolution
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.ResolutionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Resolution' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.ResolutionColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CallId
            {
                get { return (string) this[_tableAsgnmnt.CallIdColumn]; }
                set { this[_tableAsgnmnt.CallIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int HeatSeq
            {
                get { return (int) this[_tableAsgnmnt.HeatSeqColumn]; }
                set { this[_tableAsgnmnt.HeatSeqColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string EMail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.EMailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'EMail' in table 'Asgnmnt' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.EMailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Pager
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.PagerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Pager' in table 'Asgnmnt' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.PagerColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int DtLastMod
            {
                get
                {
                    try
                    {
                        return (int) this[_tableAsgnmnt.DtLastModColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTLastMod' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.DtLastModColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string WhoAcknow
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.WhoAcknowColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'WhoAcknow' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.WhoAcknowColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string WhoResolv
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.WhoResolvColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'WhoResolv' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.WhoResolvColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string LoginId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.LoginIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'LoginID' in table 'Asgnmnt' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.LoginIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PhoneExt
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.PhoneExtColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'PhoneExt' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.PhoneExtColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string TargetTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.TargetTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TargetTime' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.TargetTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string TargetDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.TargetDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TargetDate' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.TargetDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public decimal SlaResTime
            {
                get
                {
                    try
                    {
                        return (decimal) this[_tableAsgnmnt.SlaResTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SLAResTime' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.SlaResTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int TotalAsgnmntTime
            {
                get
                {
                    try
                    {
                        return (int) this[_tableAsgnmnt.TotalAsgnmntTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TotalAsgnmntTime' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.TotalAsgnmntTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Availability
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.AvailabilityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Availability' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.AvailabilityColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.CallTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallType' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.CallTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Vacation
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.VacationColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Vacation' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.VacationColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ResolveOrder
            {
                get
                {
                    try
                    {
                        return (int) this[_tableAsgnmnt.ResolveOrderColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ResolveOrder' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.ResolveOrderColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string GrpEmail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.GrpEmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'GrpEmail' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.GrpEmailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string MgrEmail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.MgrEmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'MgrEmail' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.MgrEmailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string WorkDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.WorkDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'WorkDate' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.WorkDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int WorkTime
            {
                get
                {
                    try
                    {
                        return (int) this[_tableAsgnmnt.WorkTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'WorkTime' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.WorkTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string WorkNotes
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.WorkNotesColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'WorkNotes' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.WorkNotesColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CellEmail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAsgnmnt.CellEmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CellEmail' in table 'Asgnmnt' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAsgnmnt.CellEmailColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal AsgnmntRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableAsgnmnt = (AsgnmntDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAssignedByNull()
            {
                return IsNull(_tableAsgnmnt.AssignedByColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAssignedByNull()
            {
                this[_tableAsgnmnt.AssignedByColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateAssignNull()
            {
                return IsNull(_tableAsgnmnt.DateAssignColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDateAssignNull()
            {
                this[_tableAsgnmnt.DateAssignColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTimeAssignNull()
            {
                return IsNull(_tableAsgnmnt.TimeAssignColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTimeAssignNull()
            {
                this[_tableAsgnmnt.TimeAssignColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsGroupNameNull()
            {
                return IsNull(_tableAsgnmnt.GroupNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetGroupNameNull()
            {
                this[_tableAsgnmnt.GroupNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAssigneeNull()
            {
                return IsNull(_tableAsgnmnt.AssigneeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssigneeNull()
            {
                this[_tableAsgnmnt.AssigneeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPhoneNull()
            {
                return IsNull(_tableAsgnmnt.PhoneColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetPhoneNull()
            {
                this[_tableAsgnmnt.PhoneColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNotesNull()
            {
                return IsNull(_tableAsgnmnt.NotesColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNotesNull()
            {
                this[_tableAsgnmnt.NotesColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateAcknowNull()
            {
                return IsNull(_tableAsgnmnt.DateAcknowColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDateAcknowNull()
            {
                this[_tableAsgnmnt.DateAcknowColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTimeAcknowNull()
            {
                return IsNull(_tableAsgnmnt.TimeAcknowColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetTimeAcknowNull()
            {
                this[_tableAsgnmnt.TimeAcknowColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateResolvNull()
            {
                return IsNull(_tableAsgnmnt.DateResolvColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDateResolvNull()
            {
                this[_tableAsgnmnt.DateResolvColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTimeResolvNull()
            {
                return IsNull(_tableAsgnmnt.TimeResolvColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetTimeResolvNull()
            {
                this[_tableAsgnmnt.TimeResolvColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsResolutionNull()
            {
                return IsNull(_tableAsgnmnt.ResolutionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetResolutionNull()
            {
                this[_tableAsgnmnt.ResolutionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEMailNull()
            {
                return IsNull(_tableAsgnmnt.EMailColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEMailNull()
            {
                this[_tableAsgnmnt.EMailColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPagerNull()
            {
                return IsNull(_tableAsgnmnt.PagerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetPagerNull()
            {
                this[_tableAsgnmnt.PagerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDtLastModNull()
            {
                return IsNull(_tableAsgnmnt.DtLastModColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDtLastModNull()
            {
                this[_tableAsgnmnt.DtLastModColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsWhoAcknowNull()
            {
                return IsNull(_tableAsgnmnt.WhoAcknowColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWhoAcknowNull()
            {
                this[_tableAsgnmnt.WhoAcknowColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsWhoResolvNull()
            {
                return IsNull(_tableAsgnmnt.WhoResolvColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWhoResolvNull()
            {
                this[_tableAsgnmnt.WhoResolvColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLoginIdNull()
            {
                return IsNull(_tableAsgnmnt.LoginIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLoginIdNull()
            {
                this[_tableAsgnmnt.LoginIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPhoneExtNull()
            {
                return IsNull(_tableAsgnmnt.PhoneExtColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhoneExtNull()
            {
                this[_tableAsgnmnt.PhoneExtColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsTargetTimeNull()
            {
                return IsNull(_tableAsgnmnt.TargetTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTargetTimeNull()
            {
                this[_tableAsgnmnt.TargetTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsTargetDateNull()
            {
                return IsNull(_tableAsgnmnt.TargetDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTargetDateNull()
            {
                this[_tableAsgnmnt.TargetDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSlaResTimeNull()
            {
                return IsNull(_tableAsgnmnt.SlaResTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSlaResTimeNull()
            {
                this[_tableAsgnmnt.SlaResTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTotalAsgnmntTimeNull()
            {
                return IsNull(_tableAsgnmnt.TotalAsgnmntTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetTotalAsgnmntTimeNull()
            {
                this[_tableAsgnmnt.TotalAsgnmntTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAvailabilityNull()
            {
                return IsNull(_tableAsgnmnt.AvailabilityColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAvailabilityNull()
            {
                this[_tableAsgnmnt.AvailabilityColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallTypeNull()
            {
                return IsNull(_tableAsgnmnt.CallTypeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallTypeNull()
            {
                this[_tableAsgnmnt.CallTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsVacationNull()
            {
                return IsNull(_tableAsgnmnt.VacationColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetVacationNull()
            {
                this[_tableAsgnmnt.VacationColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsResolveOrderNull()
            {
                return IsNull(_tableAsgnmnt.ResolveOrderColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetResolveOrderNull()
            {
                this[_tableAsgnmnt.ResolveOrderColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsGrpEmailNull()
            {
                return IsNull(_tableAsgnmnt.GrpEmailColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetGrpEmailNull()
            {
                this[_tableAsgnmnt.GrpEmailColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsMgrEmailNull()
            {
                return IsNull(_tableAsgnmnt.MgrEmailColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetMgrEmailNull()
            {
                this[_tableAsgnmnt.MgrEmailColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkDateNull()
            {
                return IsNull(_tableAsgnmnt.WorkDateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetWorkDateNull()
            {
                this[_tableAsgnmnt.WorkDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsWorkTimeNull()
            {
                return IsNull(_tableAsgnmnt.WorkTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkTimeNull()
            {
                this[_tableAsgnmnt.WorkTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsWorkNotesNull()
            {
                return IsNull(_tableAsgnmnt.WorkNotesColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetWorkNotesNull()
            {
                this[_tableAsgnmnt.WorkNotesColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCellEmailNull()
            {
                return IsNull(_tableAsgnmnt.CellEmailColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCellEmailNull()
            {
                this[_tableAsgnmnt.CellEmailColumn] = Convert.DBNull;
            }
        }

        public class AssigneeRow : DataRow
        {
            private AssigneeDataTable _tableAssignee;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Assignee
            {
                get { return (string) this[_tableAssignee.AssigneeColumn]; }
                set { this[_tableAssignee.AssigneeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string GroupName
            {
                get { return (string) this[_tableAssignee.GroupNameColumn]; }
                set { this[_tableAssignee.GroupNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.CallTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallType' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.CallTypeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Phone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.PhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Phone' in table 'Assignee' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAssignee.PhoneColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Pager
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.PagerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Pager' in table 'Assignee' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAssignee.PagerColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LoginId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.LoginIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LoginID' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.LoginIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Comments
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.CommentsColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Comments' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.CommentsColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string EMail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.EMailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'EMail' in table 'Assignee' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAssignee.EMailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PhoneExt
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.PhoneExtColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'PhoneExt' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.PhoneExtColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Availability
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.AvailabilityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Availability' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.AvailabilityColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string OutOfOffice
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.OutOfOfficeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'OutOfOffice' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.OutOfOfficeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CellEmail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.CellEmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CellEmail' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.CellEmailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string MgrEmail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.MgrEmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'MgrEmail' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.MgrEmailColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.ModByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModBy' in table 'Assignee' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableAssignee.ModByColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ModDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.ModDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ModDate' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.ModDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.ModTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ModTime' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.ModTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CellPhone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssignee.CellPhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CellPhone' in table 'Assignee' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssignee.CellPhoneColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal AssigneeRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableAssignee = (AssigneeDataTable) Table;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCallTypeNull()
            {
                return IsNull(_tableAssignee.CallTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCallTypeNull()
            {
                this[_tableAssignee.CallTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPhoneNull()
            {
                return IsNull(_tableAssignee.PhoneColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhoneNull()
            {
                this[_tableAssignee.PhoneColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPagerNull()
            {
                return IsNull(_tableAssignee.PagerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetPagerNull()
            {
                this[_tableAssignee.PagerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsLoginIdNull()
            {
                return IsNull(_tableAssignee.LoginIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetLoginIdNull()
            {
                this[_tableAssignee.LoginIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCommentsNull()
            {
                return IsNull(_tableAssignee.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCommentsNull()
            {
                this[_tableAssignee.CommentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEMailNull()
            {
                return IsNull(_tableAssignee.EMailColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEMailNull()
            {
                this[_tableAssignee.EMailColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPhoneExtNull()
            {
                return IsNull(_tableAssignee.PhoneExtColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhoneExtNull()
            {
                this[_tableAssignee.PhoneExtColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAvailabilityNull()
            {
                return IsNull(_tableAssignee.AvailabilityColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAvailabilityNull()
            {
                this[_tableAssignee.AvailabilityColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsOutOfOfficeNull()
            {
                return IsNull(_tableAssignee.OutOfOfficeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetOutOfOfficeNull()
            {
                this[_tableAssignee.OutOfOfficeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCellEmailNull()
            {
                return IsNull(_tableAssignee.CellEmailColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCellEmailNull()
            {
                this[_tableAssignee.CellEmailColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsMgrEmailNull()
            {
                return IsNull(_tableAssignee.MgrEmailColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetMgrEmailNull()
            {
                this[_tableAssignee.MgrEmailColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModByNull()
            {
                return IsNull(_tableAssignee.ModByColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetModByNull()
            {
                this[_tableAssignee.ModByColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModDateNull()
            {
                return IsNull(_tableAssignee.ModDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModDateNull()
            {
                this[_tableAssignee.ModDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModTimeNull()
            {
                return IsNull(_tableAssignee.ModTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetModTimeNull()
            {
                this[_tableAssignee.ModTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCellPhoneNull()
            {
                return IsNull(_tableAssignee.CellPhoneColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCellPhoneNull()
            {
                this[_tableAssignee.CellPhoneColumn] = Convert.DBNull;
            }
        }

        public class AssigneeMasterRow : DataRow
        {
            private AssigneeMasterDataTable _tableAssigneeMaster;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Assignee
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.AssigneeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Assignee' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.AssigneeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string GroupName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.GroupNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'GroupName' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.GroupNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.CallTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallType' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.CallTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Phone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.PhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Phone' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.PhoneColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Pager
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.PagerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Pager' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.PagerColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string LoginId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.LoginIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LoginID' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.LoginIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FirstName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.FirstNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FirstName' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.FirstNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LastName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.LastNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LastName' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.LastNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Email
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.EmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Email' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.EmailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PhoneExt
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.PhoneExtColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'PhoneExt' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.PhoneExtColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CellPhone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableAssigneeMaster.CellPhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CellPhone' in table 'AssigneeMaster' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableAssigneeMaster.CellPhoneColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal AssigneeMasterRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableAssigneeMaster = (AssigneeMasterDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAssigneeNull()
            {
                return IsNull(_tableAssigneeMaster.AssigneeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssigneeNull()
            {
                this[_tableAssigneeMaster.AssigneeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsGroupNameNull()
            {
                return IsNull(_tableAssigneeMaster.GroupNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetGroupNameNull()
            {
                this[_tableAssigneeMaster.GroupNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallTypeNull()
            {
                return IsNull(_tableAssigneeMaster.CallTypeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallTypeNull()
            {
                this[_tableAssigneeMaster.CallTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPhoneNull()
            {
                return IsNull(_tableAssigneeMaster.PhoneColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhoneNull()
            {
                this[_tableAssigneeMaster.PhoneColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPagerNull()
            {
                return IsNull(_tableAssigneeMaster.PagerColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPagerNull()
            {
                this[_tableAssigneeMaster.PagerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsLoginIdNull()
            {
                return IsNull(_tableAssigneeMaster.LoginIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLoginIdNull()
            {
                this[_tableAssigneeMaster.LoginIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFirstNameNull()
            {
                return IsNull(_tableAssigneeMaster.FirstNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstNameNull()
            {
                this[_tableAssigneeMaster.FirstNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsLastNameNull()
            {
                return IsNull(_tableAssigneeMaster.LastNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLastNameNull()
            {
                this[_tableAssigneeMaster.LastNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEmailNull()
            {
                return IsNull(_tableAssigneeMaster.EmailColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetEmailNull()
            {
                this[_tableAssigneeMaster.EmailColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPhoneExtNull()
            {
                return IsNull(_tableAssigneeMaster.PhoneExtColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhoneExtNull()
            {
                this[_tableAssigneeMaster.PhoneExtColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCellPhoneNull()
            {
                return IsNull(_tableAssigneeMaster.CellPhoneColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCellPhoneNull()
            {
                this[_tableAssigneeMaster.CellPhoneColumn] = Convert.DBNull;
            }
        }

        public class CalendarStatsRow : DataRow
        {
            private CalendarStatsDataTable _tableCalendarStats;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Id
            {
                get { return (decimal) this[_tableCalendarStats.IdColumn]; }
                set { this[_tableCalendarStats.IdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCalendarStats.CDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CDate' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DateTime CalDate
            {
                get
                {
                    try
                    {
                        return (DateTime) this[_tableCalendarStats.CalDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalDate' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public short CalYear
            {
                get
                {
                    try
                    {
                        return (short) this[_tableCalendarStats.CalYearColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalYear' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalYearColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CalFy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCalendarStats.CalFyColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalFY' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalFyColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public byte CalQuarter
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalQuarterColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalQuarter' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalQuarterColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CMonth
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCalendarStats.CMonthColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CMonth' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CMonthColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte CalMonth
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalMonthColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalMonth' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalMonthColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte CalFm
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalFmColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalFM' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalFmColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CalYearMonth
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCalendarStats.CalYearMonthColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalYearMonth' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalYearMonthColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CalNameOfMonth
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCalendarStats.CalNameOfMonthColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalNameOfMonth' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalNameOfMonthColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CalShortNameOfMonth
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCalendarStats.CalShortNameOfMonthColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalShortNameOfMonth' in table 'CalendarStats' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalShortNameOfMonthColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public short CalDayOfYear
            {
                get
                {
                    try
                    {
                        return (short) this[_tableCalendarStats.CalDayOfYearColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalDayOfYear' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalDayOfYearColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte CalDay
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalDayColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalDay' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalDayColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte CalWeek
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalWeekColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalWeek' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalWeekColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public byte CalDayOfWeek
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalDayOfWeekColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalDayOfWeek' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalDayOfWeekColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DateTime CalWeekOf
            {
                get
                {
                    try
                    {
                        return (DateTime) this[_tableCalendarStats.CalWeekOfColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalWeekOf' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalWeekOfColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool CalWeekIsOdd
            {
                get
                {
                    try
                    {
                        return (bool) this[_tableCalendarStats.CalWeekIsOddColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalWeekIsOdd' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalWeekIsOddColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte CalDayOfMonth
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalDayOfMonthColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalDayOfMonth' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalDayOfMonthColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte CalTrimester
            {
                get
                {
                    try
                    {
                        return (byte) this[_tableCalendarStats.CalTrimesterColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalTrimester' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalTrimesterColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool CalIsWeekday
            {
                get
                {
                    try
                    {
                        return (bool) this[_tableCalendarStats.CalIsWeekdayColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalIsWeekday' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalIsWeekdayColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool CalIsWorkday
            {
                get
                {
                    try
                    {
                        return (bool) this[_tableCalendarStats.CalIsWorkdayColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CalIsWorkday' in table 'CalendarStats' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCalendarStats.CalIsWorkdayColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal CalendarStatsRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableCalendarStats = (CalendarStatsDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCDateNull()
            {
                return IsNull(_tableCalendarStats.CDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCDateNull()
            {
                this[_tableCalendarStats.CDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalDateNull()
            {
                return IsNull(_tableCalendarStats.CalDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalDateNull()
            {
                this[_tableCalendarStats.CalDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalYearNull()
            {
                return IsNull(_tableCalendarStats.CalYearColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalYearNull()
            {
                this[_tableCalendarStats.CalYearColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalFyNull()
            {
                return IsNull(_tableCalendarStats.CalFyColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalFyNull()
            {
                this[_tableCalendarStats.CalFyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalQuarterNull()
            {
                return IsNull(_tableCalendarStats.CalQuarterColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalQuarterNull()
            {
                this[_tableCalendarStats.CalQuarterColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCMonthNull()
            {
                return IsNull(_tableCalendarStats.CMonthColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCMonthNull()
            {
                this[_tableCalendarStats.CMonthColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalMonthNull()
            {
                return IsNull(_tableCalendarStats.CalMonthColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalMonthNull()
            {
                this[_tableCalendarStats.CalMonthColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCalFmNull()
            {
                return IsNull(_tableCalendarStats.CalFmColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalFmNull()
            {
                this[_tableCalendarStats.CalFmColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalYearMonthNull()
            {
                return IsNull(_tableCalendarStats.CalYearMonthColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalYearMonthNull()
            {
                this[_tableCalendarStats.CalYearMonthColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalNameOfMonthNull()
            {
                return IsNull(_tableCalendarStats.CalNameOfMonthColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalNameOfMonthNull()
            {
                this[_tableCalendarStats.CalNameOfMonthColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalShortNameOfMonthNull()
            {
                return IsNull(_tableCalendarStats.CalShortNameOfMonthColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalShortNameOfMonthNull()
            {
                this[_tableCalendarStats.CalShortNameOfMonthColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCalDayOfYearNull()
            {
                return IsNull(_tableCalendarStats.CalDayOfYearColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalDayOfYearNull()
            {
                this[_tableCalendarStats.CalDayOfYearColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalDayNull()
            {
                return IsNull(_tableCalendarStats.CalDayColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalDayNull()
            {
                this[_tableCalendarStats.CalDayColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCalWeekNull()
            {
                return IsNull(_tableCalendarStats.CalWeekColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalWeekNull()
            {
                this[_tableCalendarStats.CalWeekColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalDayOfWeekNull()
            {
                return IsNull(_tableCalendarStats.CalDayOfWeekColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalDayOfWeekNull()
            {
                this[_tableCalendarStats.CalDayOfWeekColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCalWeekOfNull()
            {
                return IsNull(_tableCalendarStats.CalWeekOfColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalWeekOfNull()
            {
                this[_tableCalendarStats.CalWeekOfColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCalWeekIsOddNull()
            {
                return IsNull(_tableCalendarStats.CalWeekIsOddColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalWeekIsOddNull()
            {
                this[_tableCalendarStats.CalWeekIsOddColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCalDayOfMonthNull()
            {
                return IsNull(_tableCalendarStats.CalDayOfMonthColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalDayOfMonthNull()
            {
                this[_tableCalendarStats.CalDayOfMonthColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalTrimesterNull()
            {
                return IsNull(_tableCalendarStats.CalTrimesterColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalTrimesterNull()
            {
                this[_tableCalendarStats.CalTrimesterColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalIsWeekdayNull()
            {
                return IsNull(_tableCalendarStats.CalIsWeekdayColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCalIsWeekdayNull()
            {
                this[_tableCalendarStats.CalIsWeekdayColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCalIsWorkdayNull()
            {
                return IsNull(_tableCalendarStats.CalIsWorkdayColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCalIsWorkdayNull()
            {
                this[_tableCalendarStats.CalIsWorkdayColumn] = Convert.DBNull;
            }
        }

        public class CallLogRow : DataRow
        {
            private CallLogDataTable _tableCallLog;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CallId
            {
                get { return (string) this[_tableCallLog.CallIdColumn]; }
                set { this[_tableCallLog.CallIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CustId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CustIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'CustID' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CustIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CustType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CustTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CustType' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CustTypeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CallTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallType' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CallTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Tracker
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.TrackerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Tracker' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.TrackerColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallStatus
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CallStatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallStatus' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CallStatusColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Priority
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.PriorityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Priority' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.PriorityColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public decimal CDuration
            {
                get
                {
                    try
                    {
                        return (decimal) this[_tableCallLog.CDurationColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CDuration' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CDurationColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public decimal CallCount
            {
                get
                {
                    try
                    {
                        return (decimal) this[_tableCallLog.CallCountColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallCount' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CallCountColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal StopWatch
            {
                get
                {
                    try
                    {
                        return (decimal) this[_tableCallLog.StopWatchColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'StopWatch' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.StopWatchColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ClosedBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ClosedByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ClosedBy' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ClosedByColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ClosedDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ClosedDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ClosedDate' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ClosedDateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ClosedTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ClosedTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ClosedTime' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ClosedTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Cause
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CauseColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Cause' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CauseColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CallDesc
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CallDescColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallDesc' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CallDescColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CloseDesc
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CloseDescColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CloseDesc' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CloseDescColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RecvdBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.RecvdByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RecvdBy' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.RecvdByColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RecvdDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.RecvdDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RecvdDate' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.RecvdDateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RecvdTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.RecvdTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RecvdTime' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.RecvdTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ModByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModBy' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ModByColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ModDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ModDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModDate' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ModDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ModTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModTime' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ModTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int DtLastMod
            {
                get
                {
                    try
                    {
                        return (int) this[_tableCallLog.DtLastModColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTLastMod' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.DtLastModColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallSource
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CallSourceColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CallSource' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CallSourceColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string QuickCall
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.QuickCallColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'QuickCall' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.QuickCallColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Category
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CategoryColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Category' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CategoryColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CatHeading
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.CatHeadingColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CatHeading' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.CatHeadingColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int TotalTime
            {
                get
                {
                    try
                    {
                        return (int) this[_tableCallLog.TotalTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TotalTime' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.TotalTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlWarnGoal
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlWarnGoalColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Warn_Goal' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlWarnGoalColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlWarnDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlWarnDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Warn_Date' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlWarnDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlWarnTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlWarnTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Warn_Time' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlWarnTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlCompleteGoal
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlCompleteGoalColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Complete_Goal' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlCompleteGoalColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlCompleteDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlCompleteDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Complete_Date' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlCompleteDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlCompleteTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlCompleteTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Complete_Time' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlCompleteTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string SlClockStatus
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlClockStatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Clock_Status' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlClockStatusColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlButtonStatus
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlButtonStatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Button_Status' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlButtonStatusColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FirstResolution
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.FirstResolutionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FirstResolution' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.FirstResolutionColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlCompleteStatus
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.SlCompleteStatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SL_Complete_Status' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.SlCompleteStatusColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ShortDesc
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ShortDescColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ShortDesc' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ShortDescColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string UrgName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.UrgNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Urg_Name' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.UrgNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int UrgValue
            {
                get
                {
                    try
                    {
                        return (int) this[_tableCallLog.UrgValueColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Urg_Value' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.UrgValueColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ImpName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ImpNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Imp_Name' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ImpNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int ImpValue
            {
                get
                {
                    try
                    {
                        return (int) this[_tableCallLog.ImpValueColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Imp_Value' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ImpValueColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int PriorityValue
            {
                get
                {
                    try
                    {
                        return (int) this[_tableCallLog.PriorityValueColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'PriorityValue' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.PriorityValueColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DetailsReq
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.DetailsReqColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DetailsReq' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.DetailsReqColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Vandalism
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.VandalismColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Vandalism' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.VandalismColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string AsgnGrp
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.AsgnGrpColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'AsgnGrp' in table 'CallLog' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableCallLog.AsgnGrpColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Assignee
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.AssigneeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Assignee' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.AssigneeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ManagerId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableCallLog.ManagerIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ManagerID' in table 'CallLog' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableCallLog.ManagerIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CallLogRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableCallLog = (CallLogDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCustIdNull()
            {
                return IsNull(_tableCallLog.CustIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCustIdNull()
            {
                this[_tableCallLog.CustIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCustTypeNull()
            {
                return IsNull(_tableCallLog.CustTypeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCustTypeNull()
            {
                this[_tableCallLog.CustTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallTypeNull()
            {
                return IsNull(_tableCallLog.CallTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCallTypeNull()
            {
                this[_tableCallLog.CallTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsTrackerNull()
            {
                return IsNull(_tableCallLog.TrackerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetTrackerNull()
            {
                this[_tableCallLog.TrackerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCallStatusNull()
            {
                return IsNull(_tableCallLog.CallStatusColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallStatusNull()
            {
                this[_tableCallLog.CallStatusColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPriorityNull()
            {
                return IsNull(_tableCallLog.PriorityColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPriorityNull()
            {
                this[_tableCallLog.PriorityColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCDurationNull()
            {
                return IsNull(_tableCallLog.CDurationColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCDurationNull()
            {
                this[_tableCallLog.CDurationColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallCountNull()
            {
                return IsNull(_tableCallLog.CallCountColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallCountNull()
            {
                this[_tableCallLog.CallCountColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsStopWatchNull()
            {
                return IsNull(_tableCallLog.StopWatchColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStopWatchNull()
            {
                this[_tableCallLog.StopWatchColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsClosedByNull()
            {
                return IsNull(_tableCallLog.ClosedByColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetClosedByNull()
            {
                this[_tableCallLog.ClosedByColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsClosedDateNull()
            {
                return IsNull(_tableCallLog.ClosedDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetClosedDateNull()
            {
                this[_tableCallLog.ClosedDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsClosedTimeNull()
            {
                return IsNull(_tableCallLog.ClosedTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetClosedTimeNull()
            {
                this[_tableCallLog.ClosedTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCauseNull()
            {
                return IsNull(_tableCallLog.CauseColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCauseNull()
            {
                this[_tableCallLog.CauseColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallDescNull()
            {
                return IsNull(_tableCallLog.CallDescColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallDescNull()
            {
                this[_tableCallLog.CallDescColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCloseDescNull()
            {
                return IsNull(_tableCallLog.CloseDescColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCloseDescNull()
            {
                this[_tableCallLog.CloseDescColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRecvdByNull()
            {
                return IsNull(_tableCallLog.RecvdByColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRecvdByNull()
            {
                this[_tableCallLog.RecvdByColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRecvdDateNull()
            {
                return IsNull(_tableCallLog.RecvdDateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRecvdDateNull()
            {
                this[_tableCallLog.RecvdDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRecvdTimeNull()
            {
                return IsNull(_tableCallLog.RecvdTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRecvdTimeNull()
            {
                this[_tableCallLog.RecvdTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModByNull()
            {
                return IsNull(_tableCallLog.ModByColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModByNull()
            {
                this[_tableCallLog.ModByColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModDateNull()
            {
                return IsNull(_tableCallLog.ModDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModDateNull()
            {
                this[_tableCallLog.ModDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModTimeNull()
            {
                return IsNull(_tableCallLog.ModTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModTimeNull()
            {
                this[_tableCallLog.ModTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDtLastModNull()
            {
                return IsNull(_tableCallLog.DtLastModColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDtLastModNull()
            {
                this[_tableCallLog.DtLastModColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallSourceNull()
            {
                return IsNull(_tableCallLog.CallSourceColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallSourceNull()
            {
                this[_tableCallLog.CallSourceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsQuickCallNull()
            {
                return IsNull(_tableCallLog.QuickCallColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetQuickCallNull()
            {
                this[_tableCallLog.QuickCallColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCategoryNull()
            {
                return IsNull(_tableCallLog.CategoryColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCategoryNull()
            {
                this[_tableCallLog.CategoryColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCatHeadingNull()
            {
                return IsNull(_tableCallLog.CatHeadingColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCatHeadingNull()
            {
                this[_tableCallLog.CatHeadingColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTotalTimeNull()
            {
                return IsNull(_tableCallLog.TotalTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTotalTimeNull()
            {
                this[_tableCallLog.TotalTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSL_Warn_GoalNull()
            {
                return IsNull(_tableCallLog.SlWarnGoalColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSL_Warn_GoalNull()
            {
                this[_tableCallLog.SlWarnGoalColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSL_Warn_DateNull()
            {
                return IsNull(_tableCallLog.SlWarnDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSL_Warn_DateNull()
            {
                this[_tableCallLog.SlWarnDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSL_Warn_TimeNull()
            {
                return IsNull(_tableCallLog.SlWarnTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSL_Warn_TimeNull()
            {
                this[_tableCallLog.SlWarnTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSL_Complete_GoalNull()
            {
                return IsNull(_tableCallLog.SlCompleteGoalColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSL_Complete_GoalNull()
            {
                this[_tableCallLog.SlCompleteGoalColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSL_Complete_DateNull()
            {
                return IsNull(_tableCallLog.SlCompleteDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSL_Complete_DateNull()
            {
                this[_tableCallLog.SlCompleteDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSL_Complete_TimeNull()
            {
                return IsNull(_tableCallLog.SlCompleteTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSL_Complete_TimeNull()
            {
                this[_tableCallLog.SlCompleteTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSL_Clock_StatusNull()
            {
                return IsNull(_tableCallLog.SlClockStatusColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSL_Clock_StatusNull()
            {
                this[_tableCallLog.SlClockStatusColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSL_Button_StatusNull()
            {
                return IsNull(_tableCallLog.SlButtonStatusColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSL_Button_StatusNull()
            {
                this[_tableCallLog.SlButtonStatusColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFirstResolutionNull()
            {
                return IsNull(_tableCallLog.FirstResolutionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstResolutionNull()
            {
                this[_tableCallLog.FirstResolutionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSL_Complete_StatusNull()
            {
                return IsNull(_tableCallLog.SlCompleteStatusColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSL_Complete_StatusNull()
            {
                this[_tableCallLog.SlCompleteStatusColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsShortDescNull()
            {
                return IsNull(_tableCallLog.ShortDescColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetShortDescNull()
            {
                this[_tableCallLog.ShortDescColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsUrg_NameNull()
            {
                return IsNull(_tableCallLog.UrgNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetUrg_NameNull()
            {
                this[_tableCallLog.UrgNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsUrg_ValueNull()
            {
                return IsNull(_tableCallLog.UrgValueColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetUrg_ValueNull()
            {
                this[_tableCallLog.UrgValueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsImp_NameNull()
            {
                return IsNull(_tableCallLog.ImpNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetImp_NameNull()
            {
                this[_tableCallLog.ImpNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsImp_ValueNull()
            {
                return IsNull(_tableCallLog.ImpValueColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetImp_ValueNull()
            {
                this[_tableCallLog.ImpValueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPriorityValueNull()
            {
                return IsNull(_tableCallLog.PriorityValueColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetPriorityValueNull()
            {
                this[_tableCallLog.PriorityValueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDetailsReqNull()
            {
                return IsNull(_tableCallLog.DetailsReqColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDetailsReqNull()
            {
                this[_tableCallLog.DetailsReqColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsVandalismNull()
            {
                return IsNull(_tableCallLog.VandalismColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetVandalismNull()
            {
                this[_tableCallLog.VandalismColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAsgnGrpNull()
            {
                return IsNull(_tableCallLog.AsgnGrpColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAsgnGrpNull()
            {
                this[_tableCallLog.AsgnGrpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAssigneeNull()
            {
                return IsNull(_tableCallLog.AssigneeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssigneeNull()
            {
                this[_tableCallLog.AssigneeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsManagerIdNull()
            {
                return IsNull(_tableCallLog.ManagerIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetManagerIdNull()
            {
                this[_tableCallLog.ManagerIdColumn] = Convert.DBNull;
            }
        }

        public class DetailRow : DataRow
        {
            private DetailDataTable _tableDetail;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CallId
            {
                get { return (string) this[_tableDetail.CallIdColumn]; }
                set { this[_tableDetail.CallIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SerialNo
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.SerialNoColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'SerialNo' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.SerialNoColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Product
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ProductColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Product' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.ProductColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Notes
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.NotesColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Notes' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.NotesColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string SubCallType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.SubCallTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SubCallType' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.SubCallTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ProductLine
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ProductLineColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ProductLine' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.ProductLineColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Date1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Date1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Date1' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.Date1Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Date2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Date2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Date2' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.Date2Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Date3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Date3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Date3' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.Date3Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Code2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Code2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Code2' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.Code2Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int DtLastMod
            {
                get
                {
                    try
                    {
                        return (int) this[_tableDetail.DtLastModColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTLastMod' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.DtLastModColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ReturnReason
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ReturnReasonColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ReturnReason' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.ReturnReasonColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string YesNo1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.YesNo1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'YesNo1' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.YesNo1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string YesNo2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.YesNo2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'YesNo2' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.YesNo2Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Document1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Document1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Document1' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Document1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Document2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Document2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Document2' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Document2Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Document3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Document3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Document3' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Document3Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Document4
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Document4Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Document4' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Document4Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Document5
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Document5Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Document5' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Document5Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FilePath1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FilePath1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FilePath1' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FilePath1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FilePath2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FilePath2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FilePath2' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FilePath2Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FilePath3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FilePath3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FilePath3' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FilePath3Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FilePath4
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FilePath4Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FilePath4' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FilePath4Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FilePath5
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FilePath5Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FilePath5' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FilePath5Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Directory1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Directory1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Directory1' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Directory1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Directory2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Directory2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Directory2' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Directory2Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Directory3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Directory3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Directory3' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Directory3Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string AsgGrp1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.AsgGrp1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'AsgGrp1' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.AsgGrp1Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AsgGrp2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.AsgGrp2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'AsgGrp2' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.AsgGrp2Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AsgGrp3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.AsgGrp3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'AsgGrp3' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.AsgGrp3Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string MoveFrom
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.MoveFromColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'MoveFrom' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.MoveFromColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string MoveTo
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.MoveToColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'MoveTo' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.MoveToColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string TimeFrame
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.TimeFrameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TimeFrame' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.TimeFrameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string EquipType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.EquipTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'EquipType' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.EquipTypeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Asset
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.AssetColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Asset' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.AssetColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SerialNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.SerialNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SerialNum' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.SerialNumColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ComputerName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ComputerNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ComputerName' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.ComputerNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Building
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.BuildingColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Building' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.BuildingColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RoomNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.RoomNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RoomNum' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.RoomNumColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FrrcComVote
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FrrcComVoteColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FRRCComVote' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FrrcComVoteColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FrrcFundingStatus
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FrrcFundingStatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FRRCFundingStatus' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FrrcFundingStatusColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FrrcAddOn
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FrrcAddOnColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FRRCAddOn' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FrrcAddOnColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FrrcTimeFrame
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FrrcTimeFrameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FRRCTimeFrame' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FrrcTimeFrameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FrrcMeetingDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FrrcMeetingDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FRRCMeetingDate' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FrrcMeetingDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FrrcResponsibility
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.FrrcResponsibilityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FRRCResponsibility' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.FrrcResponsibilityColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CircuitId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.CircuitIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CircuitID' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.CircuitIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CircuitProvider
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.CircuitProviderColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CircuitProvider' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.CircuitProviderColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ActionType1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ActionType1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ActionType1' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.ActionType1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ActionType2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ActionType2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ActionType2' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.ActionType2Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ActionType3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ActionType3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ActionType3' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.ActionType3Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Assignee1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Assignee1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Assignee1' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Assignee1Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Assignee2
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Assignee2Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Assignee2' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Assignee2Column] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Assignee3
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.Assignee3Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Assignee3' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.Assignee3Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string HwAsset
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.HwAssetColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'HWAsset' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.HwAssetColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string HwSerialNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.HwSerialNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'HWSerialNum' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.HwSerialNumColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string HwComputerName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.HwComputerNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'HWComputerName' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.HwComputerNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Vendor
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.VendorColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Vendor' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.VendorColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string OperatingSystem
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.OperatingSystemColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'OperatingSystem' in table 'Detail' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableDetail.OperatingSystemColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Model
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.ModelColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Model' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.ModelColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string OsType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.OsTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'OSType' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.OsTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Version
            {
                get
                {
                    try
                    {
                        return (string) this[_tableDetail.VersionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Version' in table 'Detail' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableDetail.VersionColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal DetailRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableDetail = (DetailDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSerialNoNull()
            {
                return IsNull(_tableDetail.SerialNoColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSerialNoNull()
            {
                this[_tableDetail.SerialNoColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsProductNull()
            {
                return IsNull(_tableDetail.ProductColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetProductNull()
            {
                this[_tableDetail.ProductColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsNotesNull()
            {
                return IsNull(_tableDetail.NotesColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNotesNull()
            {
                this[_tableDetail.NotesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSubCallTypeNull()
            {
                return IsNull(_tableDetail.SubCallTypeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSubCallTypeNull()
            {
                this[_tableDetail.SubCallTypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsProductLineNull()
            {
                return IsNull(_tableDetail.ProductLineColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProductLineNull()
            {
                this[_tableDetail.ProductLineColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDate1Null()
            {
                return IsNull(_tableDetail.Date1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDate1Null()
            {
                this[_tableDetail.Date1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDate2Null()
            {
                return IsNull(_tableDetail.Date2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDate2Null()
            {
                this[_tableDetail.Date2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDate3Null()
            {
                return IsNull(_tableDetail.Date3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDate3Null()
            {
                this[_tableDetail.Date3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCode2Null()
            {
                return IsNull(_tableDetail.Code2Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCode2Null()
            {
                this[_tableDetail.Code2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDtLastModNull()
            {
                return IsNull(_tableDetail.DtLastModColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDtLastModNull()
            {
                this[_tableDetail.DtLastModColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsReturnReasonNull()
            {
                return IsNull(_tableDetail.ReturnReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetReturnReasonNull()
            {
                this[_tableDetail.ReturnReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsYesNo1Null()
            {
                return IsNull(_tableDetail.YesNo1Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetYesNo1Null()
            {
                this[_tableDetail.YesNo1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsYesNo2Null()
            {
                return IsNull(_tableDetail.YesNo2Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetYesNo2Null()
            {
                this[_tableDetail.YesNo2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDocument1Null()
            {
                return IsNull(_tableDetail.Document1Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDocument1Null()
            {
                this[_tableDetail.Document1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDocument2Null()
            {
                return IsNull(_tableDetail.Document2Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDocument2Null()
            {
                this[_tableDetail.Document2Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDocument3Null()
            {
                return IsNull(_tableDetail.Document3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDocument3Null()
            {
                this[_tableDetail.Document3Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDocument4Null()
            {
                return IsNull(_tableDetail.Document4Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDocument4Null()
            {
                this[_tableDetail.Document4Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDocument5Null()
            {
                return IsNull(_tableDetail.Document5Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDocument5Null()
            {
                this[_tableDetail.Document5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFilePath1Null()
            {
                return IsNull(_tableDetail.FilePath1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFilePath1Null()
            {
                this[_tableDetail.FilePath1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFilePath2Null()
            {
                return IsNull(_tableDetail.FilePath2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFilePath2Null()
            {
                this[_tableDetail.FilePath2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFilePath3Null()
            {
                return IsNull(_tableDetail.FilePath3Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFilePath3Null()
            {
                this[_tableDetail.FilePath3Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFilePath4Null()
            {
                return IsNull(_tableDetail.FilePath4Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFilePath4Null()
            {
                this[_tableDetail.FilePath4Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFilePath5Null()
            {
                return IsNull(_tableDetail.FilePath5Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFilePath5Null()
            {
                this[_tableDetail.FilePath5Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDirectory1Null()
            {
                return IsNull(_tableDetail.Directory1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDirectory1Null()
            {
                this[_tableDetail.Directory1Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDirectory2Null()
            {
                return IsNull(_tableDetail.Directory2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDirectory2Null()
            {
                this[_tableDetail.Directory2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDirectory3Null()
            {
                return IsNull(_tableDetail.Directory3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDirectory3Null()
            {
                this[_tableDetail.Directory3Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAsgGrp1Null()
            {
                return IsNull(_tableDetail.AsgGrp1Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAsgGrp1Null()
            {
                this[_tableDetail.AsgGrp1Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAsgGrp2Null()
            {
                return IsNull(_tableDetail.AsgGrp2Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAsgGrp2Null()
            {
                this[_tableDetail.AsgGrp2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAsgGrp3Null()
            {
                return IsNull(_tableDetail.AsgGrp3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAsgGrp3Null()
            {
                this[_tableDetail.AsgGrp3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsMoveFromNull()
            {
                return IsNull(_tableDetail.MoveFromColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetMoveFromNull()
            {
                this[_tableDetail.MoveFromColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsMoveToNull()
            {
                return IsNull(_tableDetail.MoveToColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetMoveToNull()
            {
                this[_tableDetail.MoveToColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsTimeFrameNull()
            {
                return IsNull(_tableDetail.TimeFrameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTimeFrameNull()
            {
                this[_tableDetail.TimeFrameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsEquipTypeNull()
            {
                return IsNull(_tableDetail.EquipTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetEquipTypeNull()
            {
                this[_tableDetail.EquipTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAssetNull()
            {
                return IsNull(_tableDetail.AssetColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAssetNull()
            {
                this[_tableDetail.AssetColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSerialNumNull()
            {
                return IsNull(_tableDetail.SerialNumColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSerialNumNull()
            {
                this[_tableDetail.SerialNumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsComputerNameNull()
            {
                return IsNull(_tableDetail.ComputerNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetComputerNameNull()
            {
                this[_tableDetail.ComputerNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsBuildingNull()
            {
                return IsNull(_tableDetail.BuildingColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetBuildingNull()
            {
                this[_tableDetail.BuildingColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRoomNumNull()
            {
                return IsNull(_tableDetail.RoomNumColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRoomNumNull()
            {
                this[_tableDetail.RoomNumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFrrcComVoteNull()
            {
                return IsNull(_tableDetail.FrrcComVoteColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFrrcComVoteNull()
            {
                this[_tableDetail.FrrcComVoteColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFrrcFundingStatusNull()
            {
                return IsNull(_tableDetail.FrrcFundingStatusColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFrrcFundingStatusNull()
            {
                this[_tableDetail.FrrcFundingStatusColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFrrcAddOnNull()
            {
                return IsNull(_tableDetail.FrrcAddOnColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFrrcAddOnNull()
            {
                this[_tableDetail.FrrcAddOnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFrrcTimeFrameNull()
            {
                return IsNull(_tableDetail.FrrcTimeFrameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFrrcTimeFrameNull()
            {
                this[_tableDetail.FrrcTimeFrameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFrrcMeetingDateNull()
            {
                return IsNull(_tableDetail.FrrcMeetingDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFrrcMeetingDateNull()
            {
                this[_tableDetail.FrrcMeetingDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFrrcResponsibilityNull()
            {
                return IsNull(_tableDetail.FrrcResponsibilityColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFrrcResponsibilityNull()
            {
                this[_tableDetail.FrrcResponsibilityColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCircuitIdNull()
            {
                return IsNull(_tableDetail.CircuitIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCircuitIdNull()
            {
                this[_tableDetail.CircuitIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCircuitProviderNull()
            {
                return IsNull(_tableDetail.CircuitProviderColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCircuitProviderNull()
            {
                this[_tableDetail.CircuitProviderColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsActionType1Null()
            {
                return IsNull(_tableDetail.ActionType1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetActionType1Null()
            {
                this[_tableDetail.ActionType1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsActionType2Null()
            {
                return IsNull(_tableDetail.ActionType2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetActionType2Null()
            {
                this[_tableDetail.ActionType2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsActionType3Null()
            {
                return IsNull(_tableDetail.ActionType3Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetActionType3Null()
            {
                this[_tableDetail.ActionType3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAssignee1Null()
            {
                return IsNull(_tableDetail.Assignee1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssignee1Null()
            {
                this[_tableDetail.Assignee1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAssignee2Null()
            {
                return IsNull(_tableDetail.Assignee2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssignee2Null()
            {
                this[_tableDetail.Assignee2Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAssignee3Null()
            {
                return IsNull(_tableDetail.Assignee3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssignee3Null()
            {
                this[_tableDetail.Assignee3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsHwAssetNull()
            {
                return IsNull(_tableDetail.HwAssetColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetHwAssetNull()
            {
                this[_tableDetail.HwAssetColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsHwSerialNumNull()
            {
                return IsNull(_tableDetail.HwSerialNumColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetHwSerialNumNull()
            {
                this[_tableDetail.HwSerialNumColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsHwComputerNameNull()
            {
                return IsNull(_tableDetail.HwComputerNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetHwComputerNameNull()
            {
                this[_tableDetail.HwComputerNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsVendorNull()
            {
                return IsNull(_tableDetail.VendorColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetVendorNull()
            {
                this[_tableDetail.VendorColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsOperatingSystemNull()
            {
                return IsNull(_tableDetail.OperatingSystemColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetOperatingSystemNull()
            {
                this[_tableDetail.OperatingSystemColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModelNull()
            {
                return IsNull(_tableDetail.ModelColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModelNull()
            {
                this[_tableDetail.ModelColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsOsTypeNull()
            {
                return IsNull(_tableDetail.OsTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetOsTypeNull()
            {
                this[_tableDetail.OsTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsVersionNull()
            {
                return IsNull(_tableDetail.VersionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetVersionNull()
            {
                this[_tableDetail.VersionColumn] = Convert.DBNull;
            }
        }

        public class FacilitiesRow : DataRow
        {
            private FacilitiesDataTable _tableFacilities;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Address1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.Address1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Address1' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.Address1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ZipCode
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.ZipCodeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ZipCode' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.ZipCodeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string City
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.CityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'City' in table 'Facilities' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableFacilities.CityColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string State
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.StateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'State' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.StateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FacilityName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.FacilityNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FacilityName' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.FacilityNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Rc
            {
                get { return (string) this[_tableFacilities.RcColumn]; }
                set { this[_tableFacilities.RcColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RegionNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.RegionNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RegionNumber' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.RegionNumberColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Phone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.PhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Phone' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.PhoneColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AdsLdapPath
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.AdsLdapPathColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ADsLDAPPath' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.AdsLdapPathColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string OldRegion
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.OldRegionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'OldRegion' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.OldRegionColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ZoneNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.ZoneNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ZoneNumber' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.ZoneNumberColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ClusterNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.ClusterNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ClusterNumber' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.ClusterNumberColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string EseCluster
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.EseClusterColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ESECluster' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.EseClusterColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AreaTech
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.AreaTechColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'AreaTech' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.AreaTechColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Fax
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.FaxColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Fax' in table 'Facilities' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableFacilities.FaxColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FieldTechnician
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.FieldTechnicianColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FieldTechnician' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.FieldTechnicianColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string InfrastructureTechnician
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.InfrastructureTechnicianColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'InfrastructureTechnician' in table 'Facilities' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableFacilities.InfrastructureTechnicianColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string OnSiteTechnician
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.OnSiteTechnicianColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'OnSiteTechnician' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.OnSiteTechnicianColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ServerTechnician
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.ServerTechnicianColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ServerTechnician' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.ServerTechnicianColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string HardwareTechnician
            {
                get
                {
                    try
                    {
                        return (string) this[_tableFacilities.HardwareTechnicianColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'HardwareTechnician' in table 'Facilities' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableFacilities.HardwareTechnicianColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal FacilitiesRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableFacilities = (FacilitiesDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAddress1Null()
            {
                return IsNull(_tableFacilities.Address1Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAddress1Null()
            {
                this[_tableFacilities.Address1Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsZipCodeNull()
            {
                return IsNull(_tableFacilities.ZipCodeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetZipCodeNull()
            {
                this[_tableFacilities.ZipCodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCityNull()
            {
                return IsNull(_tableFacilities.CityColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCityNull()
            {
                this[_tableFacilities.CityColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsStateNull()
            {
                return IsNull(_tableFacilities.StateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetStateNull()
            {
                this[_tableFacilities.StateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFacilityNameNull()
            {
                return IsNull(_tableFacilities.FacilityNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFacilityNameNull()
            {
                this[_tableFacilities.FacilityNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRegionNumberNull()
            {
                return IsNull(_tableFacilities.RegionNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRegionNumberNull()
            {
                this[_tableFacilities.RegionNumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPhoneNull()
            {
                return IsNull(_tableFacilities.PhoneColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetPhoneNull()
            {
                this[_tableFacilities.PhoneColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAdsLdapPathNull()
            {
                return IsNull(_tableFacilities.AdsLdapPathColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAdsLdapPathNull()
            {
                this[_tableFacilities.AdsLdapPathColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsOldRegionNull()
            {
                return IsNull(_tableFacilities.OldRegionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetOldRegionNull()
            {
                this[_tableFacilities.OldRegionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsZoneNumberNull()
            {
                return IsNull(_tableFacilities.ZoneNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetZoneNumberNull()
            {
                this[_tableFacilities.ZoneNumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsClusterNumberNull()
            {
                return IsNull(_tableFacilities.ClusterNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetClusterNumberNull()
            {
                this[_tableFacilities.ClusterNumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsEseClusterNull()
            {
                return IsNull(_tableFacilities.EseClusterColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEseClusterNull()
            {
                this[_tableFacilities.EseClusterColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAreaTechNull()
            {
                return IsNull(_tableFacilities.AreaTechColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAreaTechNull()
            {
                this[_tableFacilities.AreaTechColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFaxNull()
            {
                return IsNull(_tableFacilities.FaxColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFaxNull()
            {
                this[_tableFacilities.FaxColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFieldTechnicianNull()
            {
                return IsNull(_tableFacilities.FieldTechnicianColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFieldTechnicianNull()
            {
                this[_tableFacilities.FieldTechnicianColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsInfrastructureTechnicianNull()
            {
                return IsNull(_tableFacilities.InfrastructureTechnicianColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetInfrastructureTechnicianNull()
            {
                this[_tableFacilities.InfrastructureTechnicianColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsOnSiteTechnicianNull()
            {
                return IsNull(_tableFacilities.OnSiteTechnicianColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetOnSiteTechnicianNull()
            {
                this[_tableFacilities.OnSiteTechnicianColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsServerTechnicianNull()
            {
                return IsNull(_tableFacilities.ServerTechnicianColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetServerTechnicianNull()
            {
                this[_tableFacilities.ServerTechnicianColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsHardwareTechnicianNull()
            {
                return IsNull(_tableFacilities.HardwareTechnicianColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetHardwareTechnicianNull()
            {
                this[_tableFacilities.HardwareTechnicianColumn] = Convert.DBNull;
            }
        }

        public class HeatcaiRow : DataRow
        {
            private HeatcaiDataTable _tableHeatcai;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string LoginId
            {
                get { return (string) this[_tableHeatcai.LoginIdColumn]; }
                set { this[_tableHeatcai.LoginIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CustId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatcai.CustIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'CustID' in table 'HEATCAI' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.CustIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CustType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatcai.CustTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CustType' in table 'HEATCAI' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.CustTypeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Password
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatcai.PasswordColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Password' in table 'HEATCAI' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.PasswordColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SecretQ
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatcai.SecretQColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'SecretQ' in table 'HEATCAI' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.SecretQColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SecretA
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatcai.SecretAColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'SecretA' in table 'HEATCAI' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.SecretAColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Flags
            {
                get
                {
                    try
                    {
                        return (int) this[_tableHeatcai.FlagsColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Flags' in table 'HEATCAI' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.FlagsColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int DtCreated
            {
                get
                {
                    try
                    {
                        return (int) this[_tableHeatcai.DtCreatedColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTCreated' in table 'HEATCAI' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.DtCreatedColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int DtLastMod
            {
                get
                {
                    try
                    {
                        return (int) this[_tableHeatcai.DtLastModColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTLastMod' in table 'HEATCAI' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.DtLastModColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LastModBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatcai.LastModByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LastModBy' in table 'HEATCAI' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatcai.LastModByColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal HeatcaiRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableHeatcai = (HeatcaiDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCustIdNull()
            {
                return IsNull(_tableHeatcai.CustIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCustIdNull()
            {
                this[_tableHeatcai.CustIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCustTypeNull()
            {
                return IsNull(_tableHeatcai.CustTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCustTypeNull()
            {
                this[_tableHeatcai.CustTypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPasswordNull()
            {
                return IsNull(_tableHeatcai.PasswordColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPasswordNull()
            {
                this[_tableHeatcai.PasswordColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSecretQNull()
            {
                return IsNull(_tableHeatcai.SecretQColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSecretQNull()
            {
                this[_tableHeatcai.SecretQColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSecretANull()
            {
                return IsNull(_tableHeatcai.SecretAColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSecretANull()
            {
                this[_tableHeatcai.SecretAColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFlagsNull()
            {
                return IsNull(_tableHeatcai.FlagsColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFlagsNull()
            {
                this[_tableHeatcai.FlagsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDtCreatedNull()
            {
                return IsNull(_tableHeatcai.DtCreatedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDtCreatedNull()
            {
                this[_tableHeatcai.DtCreatedColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDtLastModNull()
            {
                return IsNull(_tableHeatcai.DtLastModColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDtLastModNull()
            {
                this[_tableHeatcai.DtLastModColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLastModByNull()
            {
                return IsNull(_tableHeatcai.LastModByColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLastModByNull()
            {
                this[_tableHeatcai.LastModByColumn] = Convert.DBNull;
            }
        }

        public class HeatLoginStatusRow : DataRow
        {
            private HeatLoginStatusDataTable _tableHeatLoginStatus;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ComputerName
            {
                get { return (string) this[_tableHeatLoginStatus.ComputerNameColumn]; }
                set { this[_tableHeatLoginStatus.ComputerNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ComputerDomain
            {
                get { return (string) this[_tableHeatLoginStatus.ComputerDomainColumn]; }
                set { this[_tableHeatLoginStatus.ComputerDomainColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string UserName
            {
                get { return (string) this[_tableHeatLoginStatus.UserNameColumn]; }
                set { this[_tableHeatLoginStatus.UserNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string UserDomain
            {
                get { return (string) this[_tableHeatLoginStatus.UserDomainColumn]; }
                set { this[_tableHeatLoginStatus.UserDomainColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string AppName
            {
                get { return (string) this[_tableHeatLoginStatus.AppNameColumn]; }
                set { this[_tableHeatLoginStatus.AppNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string HeatLogin
            {
                get { return (string) this[_tableHeatLoginStatus.HeatLoginColumn]; }
                set { this[_tableHeatLoginStatus.HeatLoginColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LoginTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.LoginTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LoginTime' in table 'HEATLoginStatus' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.LoginTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LoginServerTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.LoginServerTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LoginServerTime' in table 'HEATLoginStatus' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.LoginServerTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LoginSuccess
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.LoginSuccessColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LoginSuccess' in table 'HEATLoginStatus' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.LoginSuccessColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LogoutTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.LogoutTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LogoutTime' in table 'HEATLoginStatus' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.LogoutTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string HeatVersion
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.HeatVersionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'HeatVersion' in table 'HEATLoginStatus' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.HeatVersionColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string HeatTimeZoneOffset
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.HeatTimeZoneOffsetColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'HeatTimeZoneOffset' in table 'HEATLoginStatus' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.HeatTimeZoneOffsetColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SystemTimeZoneOffset
            {
                get
                {
                    try
                    {
                        return (string) this[_tableHeatLoginStatus.SystemTimeZoneOffsetColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SystemTimeZoneOffset' in table 'HEATLoginStatus' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableHeatLoginStatus.SystemTimeZoneOffsetColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal HeatLoginStatusRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableHeatLoginStatus = (HeatLoginStatusDataTable) Table;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLoginTimeNull()
            {
                return IsNull(_tableHeatLoginStatus.LoginTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLoginTimeNull()
            {
                this[_tableHeatLoginStatus.LoginTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsLoginServerTimeNull()
            {
                return IsNull(_tableHeatLoginStatus.LoginServerTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLoginServerTimeNull()
            {
                this[_tableHeatLoginStatus.LoginServerTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLoginSuccessNull()
            {
                return IsNull(_tableHeatLoginStatus.LoginSuccessColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetLoginSuccessNull()
            {
                this[_tableHeatLoginStatus.LoginSuccessColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLogoutTimeNull()
            {
                return IsNull(_tableHeatLoginStatus.LogoutTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLogoutTimeNull()
            {
                this[_tableHeatLoginStatus.LogoutTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsHeatVersionNull()
            {
                return IsNull(_tableHeatLoginStatus.HeatVersionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetHeatVersionNull()
            {
                this[_tableHeatLoginStatus.HeatVersionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsHeatTimeZoneOffsetNull()
            {
                return IsNull(_tableHeatLoginStatus.HeatTimeZoneOffsetColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetHeatTimeZoneOffsetNull()
            {
                this[_tableHeatLoginStatus.HeatTimeZoneOffsetColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSystemTimeZoneOffsetNull()
            {
                return IsNull(_tableHeatLoginStatus.SystemTimeZoneOffsetColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSystemTimeZoneOffsetNull()
            {
                this[_tableHeatLoginStatus.SystemTimeZoneOffsetColumn] = Convert.DBNull;
            }
        }

        public class JournalRow : DataRow
        {
            private JournalDataTable _tableJournal;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CallId
            {
                get { return (string) this[_tableJournal.CallIdColumn]; }
                set { this[_tableJournal.CallIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int HeatSeq
            {
                get { return (int) this[_tableJournal.HeatSeqColumn]; }
                set { this[_tableJournal.HeatSeqColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Tracker
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.TrackerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Tracker' in table 'Journal' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableJournal.TrackerColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string EntryDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.EntryDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'EntryDate' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.EntryDateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string EntryTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.EntryTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'EntryTime' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.EntryTimeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string EntryText
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.EntryTextColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'EntryText' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.EntryTextColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string JournalType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.JournalTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'JournalType' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.JournalTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int DtLastMod
            {
                get
                {
                    try
                    {
                        return (int) this[_tableJournal.DtLastModColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTLastMod' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.DtLastModColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string TempField
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.TempFieldColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TempField' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.TempFieldColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public int TotalJournalTime
            {
                get
                {
                    try
                    {
                        return (int) this[_tableJournal.TotalJournalTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'TotalJournalTime' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.TotalJournalTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DisplayHss
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.DisplayHssColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DisplayHSS' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.DisplayHssColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PmoSecurity
            {
                get
                {
                    try
                    {
                        return (string) this[_tableJournal.PmoSecurityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'PMOSecurity' in table 'Journal' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableJournal.PmoSecurityColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal JournalRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableJournal = (JournalDataTable) Table;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTrackerNull()
            {
                return IsNull(_tableJournal.TrackerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetTrackerNull()
            {
                this[_tableJournal.TrackerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsEntryDateNull()
            {
                return IsNull(_tableJournal.EntryDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEntryDateNull()
            {
                this[_tableJournal.EntryDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsEntryTimeNull()
            {
                return IsNull(_tableJournal.EntryTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetEntryTimeNull()
            {
                this[_tableJournal.EntryTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEntryTextNull()
            {
                return IsNull(_tableJournal.EntryTextColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetEntryTextNull()
            {
                this[_tableJournal.EntryTextColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsJournalTypeNull()
            {
                return IsNull(_tableJournal.JournalTypeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetJournalTypeNull()
            {
                this[_tableJournal.JournalTypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDtLastModNull()
            {
                return IsNull(_tableJournal.DtLastModColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDtLastModNull()
            {
                this[_tableJournal.DtLastModColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsTempFieldNull()
            {
                return IsNull(_tableJournal.TempFieldColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTempFieldNull()
            {
                this[_tableJournal.TempFieldColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTotalJournalTimeNull()
            {
                return IsNull(_tableJournal.TotalJournalTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetTotalJournalTimeNull()
            {
                this[_tableJournal.TotalJournalTimeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDisplayHssNull()
            {
                return IsNull(_tableJournal.DisplayHssColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDisplayHssNull()
            {
                this[_tableJournal.DisplayHssColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPmoSecurityNull()
            {
                return IsNull(_tableJournal.PmoSecurityColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetPmoSecurityNull()
            {
                this[_tableJournal.PmoSecurityColumn] = Convert.DBNull;
            }
        }

        public class ProfileRow : DataRow
        {
            private ProfileDataTable _tableProfile;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CustId
            {
                get { return (string) this[_tableProfile.CustIdColumn]; }
                set { this[_tableProfile.CustIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CustType
            {
                get { return (string) this[_tableProfile.CustTypeColumn]; }
                set { this[_tableProfile.CustTypeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FirstName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.FirstNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FirstName' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.FirstNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LastName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.LastNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'LastName' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.LastNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Title
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.TitleColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Title' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.TitleColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string EMailId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.EMailIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'EMailID' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.EMailIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Notes
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.NotesColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Notes' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.NotesColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ModBy
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.ModByColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModBy' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.ModByColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.ModDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModDate' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.ModDateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ModTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.ModTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModTime' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.ModTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SlaClass
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.SlaClassColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SLAClass' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.SlaClassColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int DtLastMod
            {
                get
                {
                    try
                    {
                        return (int) this[_tableProfile.DtLastModColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DTLastMod' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.DtLastModColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string MiddleName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.MiddleNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'MiddleName' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.MiddleNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string NetworkLoginId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.NetworkLoginIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'NetworkLoginID' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.NetworkLoginIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DateTimeAup
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.DateTimeAupColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DateTimeAUP' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.DateTimeAupColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string DateTimeMailbox
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.DateTimeMailboxColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DateTimeMailbox' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.DateTimeMailboxColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DateTimeLogged
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.DateTimeLoggedColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DateTimeLogged' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.DateTimeLoggedColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AuthorizedMailbox
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.AuthorizedMailboxColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'AuthorizedMailbox' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.AuthorizedMailboxColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string JobCode
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.JobCodeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'JobCode' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.JobCodeColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string JobDescription
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.JobDescriptionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'JobDescription' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.JobDescriptionColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AdsldapPath
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.AdsldapPathColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ADSLDAPPath' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.AdsldapPathColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string AdsHomeDirectory
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.AdsHomeDirectoryColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ADSHomeDirectory' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.AdsHomeDirectoryColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AdsProfilePath
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.AdsProfilePathColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ADSProfilePath' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.AdsProfilePathColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string AdsScriptPath
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.AdsScriptPathColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ADSScriptPath' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.AdsScriptPathColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Adssifrefid
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.AdssifrefidColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ADSSIFREFID' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.AdssifrefidColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RCNumber' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcNumberColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Region
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RegionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Region' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RegionColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RcName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCName' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcAddress1
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcAddress1Column];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RCAddress1' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcAddress1Column] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcCity
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcCityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCCity' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcCityColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RcState
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcStateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCState' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcStateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcZipCode
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcZipCodeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RCZipCode' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcZipCodeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcPhone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcPhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCPhone' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcPhoneColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcFax
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcFaxColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCFax' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcFaxColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CompanyName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyName' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CompanyRegion
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyRegionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyRegion' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyRegionColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CompanyPhone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyPhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyPhone' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyPhoneColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CompanyFax
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyFaxColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyFax' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyFaxColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ProfileType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.ProfileTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ProfileType' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.ProfileTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcZone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.RcZoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCZone' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.RcZoneColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string DisplayName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.DisplayNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DisplayName' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.DisplayNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string UDomain
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.UDomainColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'uDomain' in table 'Profile' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableProfile.UDomainColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CompanyPhoneExt
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyPhoneExtColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyPhoneExt' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyPhoneExtColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CompanyCity
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyCityColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyCity' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyCityColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CompanyState
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyStateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyState' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyStateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CompanyZip
            {
                get
                {
                    try
                    {
                        return (string) this[_tableProfile.CompanyZipColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CompanyZip' in table 'Profile' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableProfile.CompanyZipColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ProfileRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableProfile = (ProfileDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFirstNameNull()
            {
                return IsNull(_tableProfile.FirstNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstNameNull()
            {
                this[_tableProfile.FirstNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsLastNameNull()
            {
                return IsNull(_tableProfile.LastNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLastNameNull()
            {
                this[_tableProfile.LastNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTitleNull()
            {
                return IsNull(_tableProfile.TitleColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTitleNull()
            {
                this[_tableProfile.TitleColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEMailIdNull()
            {
                return IsNull(_tableProfile.EMailIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetEMailIdNull()
            {
                this[_tableProfile.EMailIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsNotesNull()
            {
                return IsNull(_tableProfile.NotesColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNotesNull()
            {
                this[_tableProfile.NotesColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModByNull()
            {
                return IsNull(_tableProfile.ModByColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModByNull()
            {
                this[_tableProfile.ModByColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModDateNull()
            {
                return IsNull(_tableProfile.ModDateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModDateNull()
            {
                this[_tableProfile.ModDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModTimeNull()
            {
                return IsNull(_tableProfile.ModTimeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModTimeNull()
            {
                this[_tableProfile.ModTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSlaClassNull()
            {
                return IsNull(_tableProfile.SlaClassColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSlaClassNull()
            {
                this[_tableProfile.SlaClassColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDtLastModNull()
            {
                return IsNull(_tableProfile.DtLastModColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDtLastModNull()
            {
                this[_tableProfile.DtLastModColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsMiddleNameNull()
            {
                return IsNull(_tableProfile.MiddleNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetMiddleNameNull()
            {
                this[_tableProfile.MiddleNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNetworkLoginIdNull()
            {
                return IsNull(_tableProfile.NetworkLoginIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNetworkLoginIdNull()
            {
                this[_tableProfile.NetworkLoginIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDateTimeAupNull()
            {
                return IsNull(_tableProfile.DateTimeAupColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDateTimeAupNull()
            {
                this[_tableProfile.DateTimeAupColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateTimeMailboxNull()
            {
                return IsNull(_tableProfile.DateTimeMailboxColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDateTimeMailboxNull()
            {
                this[_tableProfile.DateTimeMailboxColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateTimeLoggedNull()
            {
                return IsNull(_tableProfile.DateTimeLoggedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetDateTimeLoggedNull()
            {
                this[_tableProfile.DateTimeLoggedColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAuthorizedMailboxNull()
            {
                return IsNull(_tableProfile.AuthorizedMailboxColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAuthorizedMailboxNull()
            {
                this[_tableProfile.AuthorizedMailboxColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsJobCodeNull()
            {
                return IsNull(_tableProfile.JobCodeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetJobCodeNull()
            {
                this[_tableProfile.JobCodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsJobDescriptionNull()
            {
                return IsNull(_tableProfile.JobDescriptionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetJobDescriptionNull()
            {
                this[_tableProfile.JobDescriptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAdsldapPathNull()
            {
                return IsNull(_tableProfile.AdsldapPathColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAdsldapPathNull()
            {
                this[_tableProfile.AdsldapPathColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAdsHomeDirectoryNull()
            {
                return IsNull(_tableProfile.AdsHomeDirectoryColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAdsHomeDirectoryNull()
            {
                this[_tableProfile.AdsHomeDirectoryColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAdsProfilePathNull()
            {
                return IsNull(_tableProfile.AdsProfilePathColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAdsProfilePathNull()
            {
                this[_tableProfile.AdsProfilePathColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAdsScriptPathNull()
            {
                return IsNull(_tableProfile.AdsScriptPathColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAdsScriptPathNull()
            {
                this[_tableProfile.AdsScriptPathColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAdssifrefidNull()
            {
                return IsNull(_tableProfile.AdssifrefidColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAdssifrefidNull()
            {
                this[_tableProfile.AdssifrefidColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRcNumberNull()
            {
                return IsNull(_tableProfile.RcNumberColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcNumberNull()
            {
                this[_tableProfile.RcNumberColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRegionNull()
            {
                return IsNull(_tableProfile.RegionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRegionNull()
            {
                this[_tableProfile.RegionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcNameNull()
            {
                return IsNull(_tableProfile.RcNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRcNameNull()
            {
                this[_tableProfile.RcNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcAddress1Null()
            {
                return IsNull(_tableProfile.RcAddress1Column);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcAddress1Null()
            {
                this[_tableProfile.RcAddress1Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRcCityNull()
            {
                return IsNull(_tableProfile.RcCityColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcCityNull()
            {
                this[_tableProfile.RcCityColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcStateNull()
            {
                return IsNull(_tableProfile.RcStateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRcStateNull()
            {
                this[_tableProfile.RcStateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRcZipCodeNull()
            {
                return IsNull(_tableProfile.RcZipCodeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcZipCodeNull()
            {
                this[_tableProfile.RcZipCodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcPhoneNull()
            {
                return IsNull(_tableProfile.RcPhoneColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcPhoneNull()
            {
                this[_tableProfile.RcPhoneColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRcFaxNull()
            {
                return IsNull(_tableProfile.RcFaxColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcFaxNull()
            {
                this[_tableProfile.RcFaxColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCompanyNameNull()
            {
                return IsNull(_tableProfile.CompanyNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCompanyNameNull()
            {
                this[_tableProfile.CompanyNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCompanyRegionNull()
            {
                return IsNull(_tableProfile.CompanyRegionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCompanyRegionNull()
            {
                this[_tableProfile.CompanyRegionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCompanyPhoneNull()
            {
                return IsNull(_tableProfile.CompanyPhoneColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCompanyPhoneNull()
            {
                this[_tableProfile.CompanyPhoneColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCompanyFaxNull()
            {
                return IsNull(_tableProfile.CompanyFaxColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCompanyFaxNull()
            {
                this[_tableProfile.CompanyFaxColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsProfileTypeNull()
            {
                return IsNull(_tableProfile.ProfileTypeColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProfileTypeNull()
            {
                this[_tableProfile.ProfileTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRcZoneNull()
            {
                return IsNull(_tableProfile.RcZoneColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcZoneNull()
            {
                this[_tableProfile.RcZoneColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDisplayNameNull()
            {
                return IsNull(_tableProfile.DisplayNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDisplayNameNull()
            {
                this[_tableProfile.DisplayNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsuDomainNull()
            {
                return IsNull(_tableProfile.UDomainColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetuDomainNull()
            {
                this[_tableProfile.UDomainColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCompanyPhoneExtNull()
            {
                return IsNull(_tableProfile.CompanyPhoneExtColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCompanyPhoneExtNull()
            {
                this[_tableProfile.CompanyPhoneExtColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCompanyCityNull()
            {
                return IsNull(_tableProfile.CompanyCityColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCompanyCityNull()
            {
                this[_tableProfile.CompanyCityColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCompanyStateNull()
            {
                return IsNull(_tableProfile.CompanyStateColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCompanyStateNull()
            {
                this[_tableProfile.CompanyStateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCompanyZipNull()
            {
                return IsNull(_tableProfile.CompanyZipColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCompanyZipNull()
            {
                this[_tableProfile.CompanyZipColumn] = Convert.DBNull;
            }
        }

        public class SapAssetsRow : DataRow
        {
            private SapAssetsDataTable _tableSapAssets;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string AssetNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.AssetNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'AssetNumber' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.AssetNumberColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string SubNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.SubNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SubNumber' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.SubNumberColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Description
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.DescriptionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Description' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.DescriptionColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SubClass
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.SubClassColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SubClass' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.SubClassColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SerialNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.SerialNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SerialNumber' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.SerialNumberColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Location
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.LocationColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Location' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.LocationColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string BldgRoom
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.BldgRoomColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'BldgRoom' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.BldgRoomColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CostCenter
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.CostCenterColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CostCenter' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.CostCenterColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CapitalizationDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.CapitalizationDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'CapitalizationDate' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.CapitalizationDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public decimal Cost
            {
                get
                {
                    try
                    {
                        return (decimal) this[_tableSapAssets.CostColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Cost' in table 'SAPAssets' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.CostColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string InventoryNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.InventoryNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'InventoryNumber' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.InventoryNumberColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Status
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.StatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'Status' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.StatusColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FunctionalArea
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSapAssets.FunctionalAreaColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FunctionalArea' in table 'SAPAssets' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSapAssets.FunctionalAreaColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SapAssetsRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableSapAssets = (SapAssetsDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsAssetNumberNull()
            {
                return IsNull(_tableSapAssets.AssetNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetAssetNumberNull()
            {
                this[_tableSapAssets.AssetNumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSubNumberNull()
            {
                return IsNull(_tableSapAssets.SubNumberColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSubNumberNull()
            {
                this[_tableSapAssets.SubNumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDescriptionNull()
            {
                return IsNull(_tableSapAssets.DescriptionColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDescriptionNull()
            {
                this[_tableSapAssets.DescriptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSubClassNull()
            {
                return IsNull(_tableSapAssets.SubClassColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSubClassNull()
            {
                this[_tableSapAssets.SubClassColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSerialNumberNull()
            {
                return IsNull(_tableSapAssets.SerialNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSerialNumberNull()
            {
                this[_tableSapAssets.SerialNumberColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLocationNull()
            {
                return IsNull(_tableSapAssets.LocationColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLocationNull()
            {
                this[_tableSapAssets.LocationColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsBldgRoomNull()
            {
                return IsNull(_tableSapAssets.BldgRoomColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetBldgRoomNull()
            {
                this[_tableSapAssets.BldgRoomColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCostCenterNull()
            {
                return IsNull(_tableSapAssets.CostCenterColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCostCenterNull()
            {
                this[_tableSapAssets.CostCenterColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCapitalizationDateNull()
            {
                return IsNull(_tableSapAssets.CapitalizationDateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCapitalizationDateNull()
            {
                this[_tableSapAssets.CapitalizationDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCostNull()
            {
                return IsNull(_tableSapAssets.CostColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCostNull()
            {
                this[_tableSapAssets.CostColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsInventoryNumberNull()
            {
                return IsNull(_tableSapAssets.InventoryNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetInventoryNumberNull()
            {
                this[_tableSapAssets.InventoryNumberColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsStatusNull()
            {
                return IsNull(_tableSapAssets.StatusColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStatusNull()
            {
                this[_tableSapAssets.StatusColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFunctionalAreaNull()
            {
                return IsNull(_tableSapAssets.FunctionalAreaColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFunctionalAreaNull()
            {
                this[_tableSapAssets.FunctionalAreaColumn] = Convert.DBNull;
            }
        }

        public class SubsetRow : DataRow
        {
            private SubsetDataTable _tableSubset;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CustId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.CustIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'CustID' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.CustIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string CallId
            {
                get { return (string) this[_tableSubset.CallIdColumn]; }
                set { this[_tableSubset.CallIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CustType
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.CustTypeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'CustType' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.CustTypeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FirstName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.FirstNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FirstName' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.FirstNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string LastName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.LastNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'LastName' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.LastNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string EMailId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.EMailIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'EMailID' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.EMailIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string LoginId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.LoginIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'LoginID' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.LoginIdColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string JobDescription
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.JobDescriptionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'JobDescription' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.JobDescriptionColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RbCustId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RbCustIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RBCustID' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RbCustIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RbLoginId
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RbLoginIdColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RBLoginID' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.RbLoginIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RbFirstName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RbFirstNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RBFirstName' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.RbFirstNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RbLastName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RbLastNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RBLastName' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.RbLastNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RbJobDescription
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RbJobDescriptionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RBJobDescription' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.RbJobDescriptionColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RbEmail
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RbEmailColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RBEmail' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RbEmailColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AssetNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.AssetNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'AssetNum' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.AssetNumColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SerialNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.SerialNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SerialNum' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.SerialNumColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string PcName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.PcNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'PCName' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.PcNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string BldgNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.BldgNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'BldgNum' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.BldgNumColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RoomNum
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RoomNumColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RoomNum' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RoomNumColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcNumber
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RcNumberColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCNumber' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RcNumberColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RcRegion
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RcRegionColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCRegion' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RcRegionColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RcZone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RcZoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCZone' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RcZoneColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RcNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCName' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RcNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcPhone
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RcPhoneColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'RCPhone' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.RcPhoneColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string RcPhoneExt
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.RcPhoneExtColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'RCPhoneExt' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.RcPhoneExtColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string OnSiteTechnician
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.OnSiteTechnicianColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'OnSiteTechnician' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.OnSiteTechnicianColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Caller
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.CallerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Caller' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.CallerColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Contact
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.ContactColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Contact' in table 'Subset' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableSubset.ContactColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string DisplayName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableSubset.DisplayNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DisplayName' in table 'Subset' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableSubset.DisplayNameColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SubsetRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableSubset = (SubsetDataTable) Table;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCustIdNull()
            {
                return IsNull(_tableSubset.CustIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCustIdNull()
            {
                this[_tableSubset.CustIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCustTypeNull()
            {
                return IsNull(_tableSubset.CustTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetCustTypeNull()
            {
                this[_tableSubset.CustTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFirstNameNull()
            {
                return IsNull(_tableSubset.FirstNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFirstNameNull()
            {
                this[_tableSubset.FirstNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsLastNameNull()
            {
                return IsNull(_tableSubset.LastNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetLastNameNull()
            {
                this[_tableSubset.LastNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEMailIdNull()
            {
                return IsNull(_tableSubset.EMailIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEMailIdNull()
            {
                this[_tableSubset.EMailIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLoginIdNull()
            {
                return IsNull(_tableSubset.LoginIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetLoginIdNull()
            {
                this[_tableSubset.LoginIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsJobDescriptionNull()
            {
                return IsNull(_tableSubset.JobDescriptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetJobDescriptionNull()
            {
                this[_tableSubset.JobDescriptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRbCustIdNull()
            {
                return IsNull(_tableSubset.RbCustIdColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRbCustIdNull()
            {
                this[_tableSubset.RbCustIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRbLoginIdNull()
            {
                return IsNull(_tableSubset.RbLoginIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRbLoginIdNull()
            {
                this[_tableSubset.RbLoginIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRbFirstNameNull()
            {
                return IsNull(_tableSubset.RbFirstNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRbFirstNameNull()
            {
                this[_tableSubset.RbFirstNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRbLastNameNull()
            {
                return IsNull(_tableSubset.RbLastNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRbLastNameNull()
            {
                this[_tableSubset.RbLastNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRbJobDescriptionNull()
            {
                return IsNull(_tableSubset.RbJobDescriptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRbJobDescriptionNull()
            {
                this[_tableSubset.RbJobDescriptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRbEmailNull()
            {
                return IsNull(_tableSubset.RbEmailColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRbEmailNull()
            {
                this[_tableSubset.RbEmailColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAssetNumNull()
            {
                return IsNull(_tableSubset.AssetNumColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAssetNumNull()
            {
                this[_tableSubset.AssetNumColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsSerialNumNull()
            {
                return IsNull(_tableSubset.SerialNumColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetSerialNumNull()
            {
                this[_tableSubset.SerialNumColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsPcNameNull()
            {
                return IsNull(_tableSubset.PcNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPcNameNull()
            {
                this[_tableSubset.PcNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsBldgNumNull()
            {
                return IsNull(_tableSubset.BldgNumColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetBldgNumNull()
            {
                this[_tableSubset.BldgNumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRoomNumNull()
            {
                return IsNull(_tableSubset.RoomNumColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRoomNumNull()
            {
                this[_tableSubset.RoomNumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcNumberNull()
            {
                return IsNull(_tableSubset.RcNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRcNumberNull()
            {
                this[_tableSubset.RcNumberColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcRegionNull()
            {
                return IsNull(_tableSubset.RcRegionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRcRegionNull()
            {
                this[_tableSubset.RcRegionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsRcZoneNull()
            {
                return IsNull(_tableSubset.RcZoneColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRcZoneNull()
            {
                this[_tableSubset.RcZoneColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcNameNull()
            {
                return IsNull(_tableSubset.RcNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetRcNameNull()
            {
                this[_tableSubset.RcNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcPhoneNull()
            {
                return IsNull(_tableSubset.RcPhoneColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcPhoneNull()
            {
                this[_tableSubset.RcPhoneColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRcPhoneExtNull()
            {
                return IsNull(_tableSubset.RcPhoneExtColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRcPhoneExtNull()
            {
                this[_tableSubset.RcPhoneExtColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsOnSiteTechnicianNull()
            {
                return IsNull(_tableSubset.OnSiteTechnicianColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetOnSiteTechnicianNull()
            {
                this[_tableSubset.OnSiteTechnicianColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsCallerNull()
            {
                return IsNull(_tableSubset.CallerColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCallerNull()
            {
                this[_tableSubset.CallerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsContactNull()
            {
                return IsNull(_tableSubset.ContactColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetContactNull()
            {
                this[_tableSubset.ContactColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsDisplayNameNull()
            {
                return IsNull(_tableSubset.DisplayNameColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDisplayNameNull()
            {
                this[_tableSubset.DisplayNameColumn] = Convert.DBNull;
            }
        }

        public class TrackerRow : DataRow
        {
            private TrackerDataTable _tableTracker;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string LoginId
            {
                get { return (string) this[_tableTracker.LoginIdColumn]; }
                set { this[_tableTracker.LoginIdColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string FullName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.FullNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'FullName' in table 'Tracker' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableTracker.FullNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string HeatPass
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.HeatPassColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'HEATPass' in table 'Tracker' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableTracker.HeatPassColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string SecGroup
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.SecGroupColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'SecGroup' in table 'Tracker' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableTracker.SecGroupColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string Manager
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.ManagerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Manager' in table 'Tracker' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableTracker.ManagerColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Status
            {
                get
                {
                    try
                    {
                        return (int) this[_tableTracker.StatusColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'Status' in table 'Tracker' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableTracker.StatusColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModPwDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.ModPwDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'ModPWDate' in table 'Tracker' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableTracker.ModPwDateColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModWho
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.ModWhoColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModWho' in table 'Tracker' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableTracker.ModWhoColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string ModDate
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.ModDateColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModDate' in table 'Tracker' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableTracker.ModDateColumn] = (object) value; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ModTime
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.ModTimeColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException("The value for column 'ModTime' in table 'Tracker' is DBNull.",
                            (Exception) ex);
                    }
                }
                set { this[_tableTracker.ModTimeColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string DefTracker
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.DefTrackerColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'DefTracker' in table 'Tracker' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableTracker.DefTrackerColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public string EMailName
            {
                get
                {
                    try
                    {
                        return (string) this[_tableTracker.EMailNameColumn];
                    }
                    catch (InvalidCastException ex)
                    {
                        throw new StrongTypingException(
                            "The value for column 'eMailName' in table 'Tracker' is DBNull.", (Exception) ex);
                    }
                }
                set { this[_tableTracker.EMailNameColumn] = (object) value; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            internal TrackerRow(DataRowBuilder rb)
                : base(rb)
            {
                _tableTracker = (TrackerDataTable) Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsFullNameNull()
            {
                return IsNull(_tableTracker.FullNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetFullNameNull()
            {
                this[_tableTracker.FullNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsHeatPassNull()
            {
                return IsNull(_tableTracker.HeatPassColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetHeatPassNull()
            {
                this[_tableTracker.HeatPassColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSecGroupNull()
            {
                return IsNull(_tableTracker.SecGroupColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSecGroupNull()
            {
                this[_tableTracker.SecGroupColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsManagerNull()
            {
                return IsNull(_tableTracker.ManagerColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetManagerNull()
            {
                this[_tableTracker.ManagerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsStatusNull()
            {
                return IsNull(_tableTracker.StatusColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStatusNull()
            {
                this[_tableTracker.StatusColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IsModPwDateNull()
            {
                return IsNull(_tableTracker.ModPwDateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetModPwDateNull()
            {
                this[_tableTracker.ModPwDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsModWhoNull()
            {
                return IsNull(_tableTracker.ModWhoColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetModWhoNull()
            {
                this[_tableTracker.ModWhoColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsModDateNull()
            {
                return IsNull(_tableTracker.ModDateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetModDateNull()
            {
                this[_tableTracker.ModDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsModTimeNull()
            {
                return IsNull(_tableTracker.ModTimeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SetModTimeNull()
            {
                this[_tableTracker.ModTimeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDefTrackerNull()
            {
                return IsNull(_tableTracker.DefTrackerColumn);
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDefTrackerNull()
            {
                this[_tableTracker.DefTrackerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public bool IseMailNameNull()
            {
                return IsNull(_tableTracker.EMailNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public void SeteMailNameNull()
            {
                this[_tableTracker.EMailNameColumn] = Convert.DBNull;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class AsgnmntRowChangeEvent : EventArgs
        {
            private AsgnmntRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AsgnmntRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AsgnmntRowChangeEvent(AsgnmntRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class AssigneeRowChangeEvent : EventArgs
        {
            private AssigneeRow _eventRow;
            private DataRowAction _eventAction;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeRowChangeEvent(AssigneeRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class AssigneeMasterRowChangeEvent : EventArgs
        {
            private AssigneeMasterRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public AssigneeMasterRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AssigneeMasterRowChangeEvent(AssigneeMasterRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CalendarStatsRowChangeEvent : EventArgs
        {
            private CalendarStatsRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CalendarStatsRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CalendarStatsRowChangeEvent(CalendarStatsRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CallLogRowChangeEvent : EventArgs
        {
            private CallLogRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public CallLogRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CallLogRowChangeEvent(CallLogRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class DetailRowChangeEvent : EventArgs
        {
            private DetailRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DetailRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DetailRowChangeEvent(DetailRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class FacilitiesRowChangeEvent : EventArgs
        {
            private FacilitiesRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public FacilitiesRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public FacilitiesRowChangeEvent(FacilitiesRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class HeatcaiRowChangeEvent : EventArgs
        {
            private HeatcaiRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatcaiRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatcaiRowChangeEvent(HeatcaiRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class HeatLoginStatusRowChangeEvent : EventArgs
        {
            private HeatLoginStatusRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public HeatLoginStatusRow Row
            {
                get { return _eventRow; }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HeatLoginStatusRowChangeEvent(HeatLoginStatusRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class JournalRowChangeEvent : EventArgs
        {
            private JournalRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public JournalRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public JournalRowChangeEvent(JournalRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class ProfileRowChangeEvent : EventArgs
        {
            private ProfileRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public ProfileRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProfileRowChangeEvent(ProfileRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class SapAssetsRowChangeEvent : EventArgs
        {
            private SapAssetsRow _eventRow;
            private DataRowAction _eventAction;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SapAssetsRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SapAssetsRowChangeEvent(SapAssetsRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class SubsetRowChangeEvent : EventArgs
        {
            private SubsetRow _eventRow;
            private DataRowAction _eventAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [DebuggerNonUserCode]
            public SubsetRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SubsetRowChangeEvent(SubsetRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class TrackerRowChangeEvent : EventArgs
        {
            private TrackerRow _eventRow;
            private DataRowAction _eventAction;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TrackerRow Row
            {
                get { return _eventRow; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get { return _eventAction; }
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TrackerRowChangeEvent(TrackerRow row, DataRowAction action)
            {
                _eventRow = row;
                _eventAction = action;
            }
        }
    }
}