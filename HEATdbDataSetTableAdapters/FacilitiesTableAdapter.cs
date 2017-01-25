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
    [Designer(
         "Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
     )]
    [DesignerCategory("code")]
    [DataObject(true)]
    [ToolboxItem(true)]
    public class FacilitiesTableAdapter : Component
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

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get { return _clearBeforeFill; }
            set { _clearBeforeFill = value; }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FacilitiesTableAdapter()
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
                DataSetTable = "Facilities",
                ColumnMappings =
                {
                    {
                        "Address1",
                        "Address1"
                    },
                    {
                        "ZipCode",
                        "ZipCode"
                    },
                    {
                        "City",
                        "City"
                    },
                    {
                        "State",
                        "State"
                    },
                    {
                        "FacilityName",
                        "FacilityName"
                    },
                    {
                        "RC",
                        "RC"
                    },
                    {
                        "RegionNumber",
                        "RegionNumber"
                    },
                    {
                        "Phone",
                        "Phone"
                    },
                    {
                        "ADsLDAPPath",
                        "ADsLDAPPath"
                    },
                    {
                        "OldRegion",
                        "OldRegion"
                    },
                    {
                        "ZoneNumber",
                        "ZoneNumber"
                    },
                    {
                        "ClusterNumber",
                        "ClusterNumber"
                    },
                    {
                        "ESECluster",
                        "ESECluster"
                    },
                    {
                        "AreaTech",
                        "AreaTech"
                    },
                    {
                        "Fax",
                        "Fax"
                    },
                    {
                        "FieldTechnician",
                        "FieldTechnician"
                    },
                    {
                        "InfrastructureTechnician",
                        "InfrastructureTechnician"
                    },
                    {
                        "OnSiteTechnician",
                        "OnSiteTechnician"
                    },
                    {
                        "ServerTechnician",
                        "ServerTechnician"
                    },
                    {
                        "HardwareTechnician",
                        "HardwareTechnician"
                    }
                }
            });
            _adapter.DeleteCommand = new SqlCommand();
            _adapter.DeleteCommand.Connection = Connection;
            _adapter.DeleteCommand.CommandText =
                "DELETE FROM [dbo].[Facilities] WHERE (((@IsNull_Address1 = 1 AND [Address1] IS NULL) OR ([Address1] = @Original_Address1)) AND ((@IsNull_ZipCode = 1 AND [ZipCode] IS NULL) OR ([ZipCode] = @Original_ZipCode)) AND ((@IsNull_City = 1 AND [City] IS NULL) OR ([City] = @Original_City)) AND ((@IsNull_State = 1 AND [State] IS NULL) OR ([State] = @Original_State)) AND ((@IsNull_FacilityName = 1 AND [FacilityName] IS NULL) OR ([FacilityName] = @Original_FacilityName)) AND ([RC] = @Original_RC) AND ((@IsNull_RegionNumber = 1 AND [RegionNumber] IS NULL) OR ([RegionNumber] = @Original_RegionNumber)) AND ((@IsNull_Phone = 1 AND [Phone] IS NULL) OR ([Phone] = @Original_Phone)) AND ((@IsNull_ADsLDAPPath = 1 AND [ADsLDAPPath] IS NULL) OR ([ADsLDAPPath] = @Original_ADsLDAPPath)) AND ((@IsNull_OldRegion = 1 AND [OldRegion] IS NULL) OR ([OldRegion] = @Original_OldRegion)) AND ((@IsNull_ZoneNumber = 1 AND [ZoneNumber] IS NULL) OR ([ZoneNumber] = @Original_ZoneNumber)) AND ((@IsNull_ClusterNumber = 1 AND [ClusterNumber] IS NULL) OR ([ClusterNumber] = @Original_ClusterNumber)) AND ((@IsNull_ESECluster = 1 AND [ESECluster] IS NULL) OR ([ESECluster] = @Original_ESECluster)) AND ((@IsNull_AreaTech = 1 AND [AreaTech] IS NULL) OR ([AreaTech] = @Original_AreaTech)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_FieldTechnician = 1 AND [FieldTechnician] IS NULL) OR ([FieldTechnician] = @Original_FieldTechnician)) AND ((@IsNull_InfrastructureTechnician = 1 AND [InfrastructureTechnician] IS NULL) OR ([InfrastructureTechnician] = @Original_InfrastructureTechnician)) AND ((@IsNull_OnSiteTechnician = 1 AND [OnSiteTechnician] IS NULL) OR ([OnSiteTechnician] = @Original_OnSiteTechnician)) AND ((@IsNull_ServerTechnician = 1 AND [ServerTechnician] IS NULL) OR ([ServerTechnician] = @Original_ServerTechnician)) AND ((@IsNull_HardwareTechnician = 1 AND [HardwareTechnician] IS NULL) OR ([HardwareTechnician] = @Original_HardwareTechnician)))";
            _adapter.DeleteCommand.CommandType = CommandType.Text;
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Address1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_City", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_City", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_State", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_State", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FacilityName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FacilityName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FacilityName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FacilityName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RC", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RC", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RegionNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RegionNumber", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RegionNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RegionNumber", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ADsLDAPPath", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADsLDAPPath", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ADsLDAPPath", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADsLDAPPath", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OldRegion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OldRegion", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OldRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OldRegion", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ZoneNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZoneNumber", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ZoneNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZoneNumber", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ClusterNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClusterNumber", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ClusterNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClusterNumber", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ESECluster", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ESECluster", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ESECluster", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ESECluster", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_AreaTech", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AreaTech", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_AreaTech", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AreaTech", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Fax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_FieldTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FieldTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_FieldTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FieldTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_InfrastructureTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "InfrastructureTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_InfrastructureTechnician",
                SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "InfrastructureTechnician",
                DataRowVersion.Original, false, (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_OnSiteTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ServerTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ServerTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ServerTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ServerTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_HardwareTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HardwareTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_HardwareTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HardwareTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand = new SqlCommand();
            _adapter.InsertCommand.Connection = Connection;
            _adapter.InsertCommand.CommandText =
                "INSERT INTO [dbo].[Facilities] ([Address1], [ZipCode], [City], [State], [FacilityName], [RC], [RegionNumber], [Phone], [ADsLDAPPath], [OldRegion], [ZoneNumber], [ClusterNumber], [ESECluster], [AreaTech], [Fax], [FieldTechnician], [InfrastructureTechnician], [OnSiteTechnician], [ServerTechnician], [HardwareTechnician]) VALUES (@Address1, @ZipCode, @City, @State, @FacilityName, @RC, @RegionNumber, @Phone, @ADsLDAPPath, @OldRegion, @ZoneNumber, @ClusterNumber, @ESECluster, @AreaTech, @Fax, @FieldTechnician, @InfrastructureTechnician, @OnSiteTechnician, @ServerTechnician, @HardwareTechnician);\r\nSELECT Address1, ZipCode, City, State, FacilityName, RC, RegionNumber, Phone, ADsLDAPPath, OldRegion, ZoneNumber, ClusterNumber, ESECluster, AreaTech, Fax, FieldTechnician, InfrastructureTechnician, OnSiteTechnician, ServerTechnician, HardwareTechnician FROM Facilities WHERE (RC = @RC)";
            _adapter.InsertCommand.CommandType = CommandType.Text;
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Address1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@State", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FacilityName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FacilityName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.VarChar, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "RC", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@RegionNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RegionNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ADsLDAPPath", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADsLDAPPath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@OldRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OldRegion", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ZoneNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZoneNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ClusterNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClusterNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ESECluster", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ESECluster", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@AreaTech", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AreaTech", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@FieldTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FieldTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@InfrastructureTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "InfrastructureTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@ServerTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ServerTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.InsertCommand.Parameters.Add(new SqlParameter("@HardwareTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HardwareTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand = new SqlCommand();
            _adapter.UpdateCommand.Connection = Connection;
            _adapter.UpdateCommand.CommandText =
                "UPDATE [dbo].[Facilities] SET [Address1] = @Address1, [ZipCode] = @ZipCode, [City] = @City, [State] = @State, [FacilityName] = @FacilityName, [RC] = @RC, [RegionNumber] = @RegionNumber, [Phone] = @Phone, [ADsLDAPPath] = @ADsLDAPPath, [OldRegion] = @OldRegion, [ZoneNumber] = @ZoneNumber, [ClusterNumber] = @ClusterNumber, [ESECluster] = @ESECluster, [AreaTech] = @AreaTech, [Fax] = @Fax, [FieldTechnician] = @FieldTechnician, [InfrastructureTechnician] = @InfrastructureTechnician, [OnSiteTechnician] = @OnSiteTechnician, [ServerTechnician] = @ServerTechnician, [HardwareTechnician] = @HardwareTechnician WHERE (((@IsNull_Address1 = 1 AND [Address1] IS NULL) OR ([Address1] = @Original_Address1)) AND ((@IsNull_ZipCode = 1 AND [ZipCode] IS NULL) OR ([ZipCode] = @Original_ZipCode)) AND ((@IsNull_City = 1 AND [City] IS NULL) OR ([City] = @Original_City)) AND ((@IsNull_State = 1 AND [State] IS NULL) OR ([State] = @Original_State)) AND ((@IsNull_FacilityName = 1 AND [FacilityName] IS NULL) OR ([FacilityName] = @Original_FacilityName)) AND ([RC] = @Original_RC) AND ((@IsNull_RegionNumber = 1 AND [RegionNumber] IS NULL) OR ([RegionNumber] = @Original_RegionNumber)) AND ((@IsNull_Phone = 1 AND [Phone] IS NULL) OR ([Phone] = @Original_Phone)) AND ((@IsNull_ADsLDAPPath = 1 AND [ADsLDAPPath] IS NULL) OR ([ADsLDAPPath] = @Original_ADsLDAPPath)) AND ((@IsNull_OldRegion = 1 AND [OldRegion] IS NULL) OR ([OldRegion] = @Original_OldRegion)) AND ((@IsNull_ZoneNumber = 1 AND [ZoneNumber] IS NULL) OR ([ZoneNumber] = @Original_ZoneNumber)) AND ((@IsNull_ClusterNumber = 1 AND [ClusterNumber] IS NULL) OR ([ClusterNumber] = @Original_ClusterNumber)) AND ((@IsNull_ESECluster = 1 AND [ESECluster] IS NULL) OR ([ESECluster] = @Original_ESECluster)) AND ((@IsNull_AreaTech = 1 AND [AreaTech] IS NULL) OR ([AreaTech] = @Original_AreaTech)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_FieldTechnician = 1 AND [FieldTechnician] IS NULL) OR ([FieldTechnician] = @Original_FieldTechnician)) AND ((@IsNull_InfrastructureTechnician = 1 AND [InfrastructureTechnician] IS NULL) OR ([InfrastructureTechnician] = @Original_InfrastructureTechnician)) AND ((@IsNull_OnSiteTechnician = 1 AND [OnSiteTechnician] IS NULL) OR ([OnSiteTechnician] = @Original_OnSiteTechnician)) AND ((@IsNull_ServerTechnician = 1 AND [ServerTechnician] IS NULL) OR ([ServerTechnician] = @Original_ServerTechnician)) AND ((@IsNull_HardwareTechnician = 1 AND [HardwareTechnician] IS NULL) OR ([HardwareTechnician] = @Original_HardwareTechnician)));\r\nSELECT Address1, ZipCode, City, State, FacilityName, RC, RegionNumber, Phone, ADsLDAPPath, OldRegion, ZoneNumber, ClusterNumber, ESECluster, AreaTech, Fax, FieldTechnician, InfrastructureTechnician, OnSiteTechnician, ServerTechnician, HardwareTechnician FROM Facilities WHERE (RC = @RC)";
            _adapter.UpdateCommand.CommandType = CommandType.Text;
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Address1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@State", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FacilityName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FacilityName", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.VarChar, 0, ParameterDirection.Input,
                (byte) 0, (byte) 0, "RC", DataRowVersion.Current, false, (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RegionNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RegionNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ADsLDAPPath", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADsLDAPPath", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OldRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OldRegion", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ZoneNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZoneNumber", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ClusterNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClusterNumber", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ESECluster", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ESECluster", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@AreaTech", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AreaTech", DataRowVersion.Current, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Current, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FieldTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FieldTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@InfrastructureTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "InfrastructureTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ServerTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ServerTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HardwareTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HardwareTechnician", DataRowVersion.Current, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Address1", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_City", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_City", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_State", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_State", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FacilityName", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FacilityName", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FacilityName", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FacilityName", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RC", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RC", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RegionNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RegionNumber", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RegionNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "RegionNumber", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Phone", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ADsLDAPPath", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADsLDAPPath", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ADsLDAPPath", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ADsLDAPPath", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OldRegion", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OldRegion", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OldRegion", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OldRegion", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ZoneNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZoneNumber", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ZoneNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ZoneNumber", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ClusterNumber", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClusterNumber", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ClusterNumber", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ClusterNumber", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ESECluster", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ESECluster", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ESECluster", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ESECluster", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_AreaTech", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AreaTech", DataRowVersion.Original, true, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_AreaTech", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "AreaTech", DataRowVersion.Original, false, (object) null,
                "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Fax", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, false, (object) null, "",
                "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_FieldTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FieldTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_FieldTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "FieldTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_InfrastructureTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "InfrastructureTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_InfrastructureTechnician",
                SqlDbType.VarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "InfrastructureTechnician",
                DataRowVersion.Original, false, (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_OnSiteTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_OnSiteTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "OnSiteTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ServerTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ServerTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ServerTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "ServerTechnician", DataRowVersion.Original, false,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_HardwareTechnician", SqlDbType.Int, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HardwareTechnician", DataRowVersion.Original, true,
                (object) null, "", "", ""));
            _adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_HardwareTechnician", SqlDbType.VarChar, 0,
                ParameterDirection.Input, (byte) 0, (byte) 0, "HardwareTechnician", DataRowVersion.Original, false,
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
                "SELECT Address1, ZipCode, City, State, FacilityName, RC, RegionNumber, Phone, ADsLDAPPath, OldRegion, ZoneNumber, ClusterNumber, ESECluster, AreaTech, Fax, FieldTechnician, InfrastructureTechnician, OnSiteTechnician, ServerTechnician, HardwareTechnician FROM dbo.Facilities";
            _commandCollection[0].CommandType = CommandType.Text;
        }

        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Fill, true)]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        public virtual int Fill(HeaTdbDataSet.FacilitiesDataTable dataTable)
        {
            Adapter.SelectCommand = CommandCollection[0];
            if (ClearBeforeFill)
                dataTable.Clear();
            return Adapter.Fill((DataTable) dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DebuggerNonUserCode]
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual HeaTdbDataSet.FacilitiesDataTable GetData()
        {
            Adapter.SelectCommand = CommandCollection[0];
            HeaTdbDataSet.FacilitiesDataTable facilitiesDataTable = new HeaTdbDataSet.FacilitiesDataTable();
            Adapter.Fill((DataTable) facilitiesDataTable);
            return facilitiesDataTable;
        }

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(HeaTdbDataSet.FacilitiesDataTable dataTable)
        {
            return Adapter.Update((DataTable) dataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        public virtual int Update(HeaTdbDataSet dataSet)
        {
            return Adapter.Update((DataSet) dataSet, "Facilities");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [HelpKeyword("vs.data.TableAdapter")]
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

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Delete(string originalAddress1, string originalZipCode, string originalCity,
            string originalState, string originalFacilityName, string originalRc, string originalRegionNumber,
            string originalPhone, string originalAdsLdapPath, string originalOldRegion, string originalZoneNumber,
            string originalClusterNumber, string originalEseCluster, string originalAreaTech, string originalFax,
            string originalFieldTechnician, string originalInfrastructureTechnician, string originalOnSiteTechnician,
            string originalServerTechnician, string originalHardwareTechnician)
        {
            if (originalAddress1 == null)
            {
                Adapter.DeleteCommand.Parameters[0].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[1].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[0].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[1].Value = (object) originalAddress1;
            }
            if (originalZipCode == null)
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[3].Value = (object) originalZipCode;
            }
            if (originalCity == null)
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[5].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[4].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[5].Value = (object) originalCity;
            }
            if (originalState == null)
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[7].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[6].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[7].Value = (object) originalState;
            }
            if (originalFacilityName == null)
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[9].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[8].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[9].Value = (object) originalFacilityName;
            }
            if (originalRc == null)
                throw new ArgumentNullException("originalRc");
            Adapter.DeleteCommand.Parameters[10].Value = (object) originalRc;
            if (originalRegionNumber == null)
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[12].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[11].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[12].Value = (object) originalRegionNumber;
            }
            if (originalPhone == null)
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[14].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[13].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[14].Value = (object) originalPhone;
            }
            if (originalAdsLdapPath == null)
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[16].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[15].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[16].Value = (object) originalAdsLdapPath;
            }
            if (originalOldRegion == null)
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[18].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[17].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[18].Value = (object) originalOldRegion;
            }
            if (originalZoneNumber == null)
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[20].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[19].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[20].Value = (object) originalZoneNumber;
            }
            if (originalClusterNumber == null)
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[22].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[21].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[22].Value = (object) originalClusterNumber;
            }
            if (originalEseCluster == null)
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[24].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[23].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[24].Value = (object) originalEseCluster;
            }
            if (originalAreaTech == null)
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[26].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[25].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[26].Value = (object) originalAreaTech;
            }
            if (originalFax == null)
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[28].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[27].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[28].Value = (object) originalFax;
            }
            if (originalFieldTechnician == null)
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[30].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[29].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[30].Value = (object) originalFieldTechnician;
            }
            if (originalInfrastructureTechnician == null)
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[31].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[32].Value = (object) originalInfrastructureTechnician;
            }
            if (originalOnSiteTechnician == null)
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[34].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[33].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[34].Value = (object) originalOnSiteTechnician;
            }
            if (originalServerTechnician == null)
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[36].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[35].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[36].Value = (object) originalServerTechnician;
            }
            if (originalHardwareTechnician == null)
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 1;
                Adapter.DeleteCommand.Parameters[38].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.DeleteCommand.Parameters[37].Value = (object) 0;
                Adapter.DeleteCommand.Parameters[38].Value = (object) originalHardwareTechnician;
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
        public virtual int Insert(string address1, string zipCode, string city, string State, string facilityName,
            string rc, string regionNumber, string phone, string adsLdapPath, string oldRegion, string zoneNumber,
            string clusterNumber, string eseCluster, string areaTech, string fax, string fieldTechnician,
            string infrastructureTechnician, string onSiteTechnician, string serverTechnician, string hardwareTechnician)
        {
            if (address1 == null)
                Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[0].Value = (object) address1;
            if (zipCode == null)
                Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[1].Value = (object) zipCode;
            if (city == null)
                Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[2].Value = (object) city;
            if (State == null)
                Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[3].Value = (object) State;
            if (facilityName == null)
                Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[4].Value = (object) facilityName;
            if (rc == null)
                throw new ArgumentNullException("rc");
            Adapter.InsertCommand.Parameters[5].Value = (object) rc;
            if (regionNumber == null)
                Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[6].Value = (object) regionNumber;
            if (phone == null)
                Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[7].Value = (object) phone;
            if (adsLdapPath == null)
                Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[8].Value = (object) adsLdapPath;
            if (oldRegion == null)
                Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[9].Value = (object) oldRegion;
            if (zoneNumber == null)
                Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[10].Value = (object) zoneNumber;
            if (clusterNumber == null)
                Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[11].Value = (object) clusterNumber;
            if (eseCluster == null)
                Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[12].Value = (object) eseCluster;
            if (areaTech == null)
                Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[13].Value = (object) areaTech;
            if (fax == null)
                Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[14].Value = (object) fax;
            if (fieldTechnician == null)
                Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[15].Value = (object) fieldTechnician;
            if (infrastructureTechnician == null)
                Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[16].Value = (object) infrastructureTechnician;
            if (onSiteTechnician == null)
                Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[17].Value = (object) onSiteTechnician;
            if (serverTechnician == null)
                Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[18].Value = (object) serverTechnician;
            if (hardwareTechnician == null)
                Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.InsertCommand.Parameters[19].Value = (object) hardwareTechnician;
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
        public virtual int Update(string address1, string zipCode, string city, string State, string facilityName,
            string rc, string regionNumber, string phone, string adsLdapPath, string oldRegion, string zoneNumber,
            string clusterNumber, string eseCluster, string areaTech, string fax, string fieldTechnician,
            string infrastructureTechnician, string onSiteTechnician, string serverTechnician, string hardwareTechnician,
            string originalAddress1, string originalZipCode, string originalCity, string originalState,
            string originalFacilityName, string originalRc, string originalRegionNumber, string originalPhone,
            string originalAdsLdapPath, string originalOldRegion, string originalZoneNumber,
            string originalClusterNumber, string originalEseCluster, string originalAreaTech, string originalFax,
            string originalFieldTechnician, string originalInfrastructureTechnician, string originalOnSiteTechnician,
            string originalServerTechnician, string originalHardwareTechnician)
        {
            if (address1 == null)
                Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[0].Value = (object) address1;
            if (zipCode == null)
                Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[1].Value = (object) zipCode;
            if (city == null)
                Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[2].Value = (object) city;
            if (State == null)
                Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[3].Value = (object) State;
            if (facilityName == null)
                Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[4].Value = (object) facilityName;
            if (rc == null)
                throw new ArgumentNullException("rc");
            Adapter.UpdateCommand.Parameters[5].Value = (object) rc;
            if (regionNumber == null)
                Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[6].Value = (object) regionNumber;
            if (phone == null)
                Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[7].Value = (object) phone;
            if (adsLdapPath == null)
                Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[8].Value = (object) adsLdapPath;
            if (oldRegion == null)
                Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[9].Value = (object) oldRegion;
            if (zoneNumber == null)
                Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[10].Value = (object) zoneNumber;
            if (clusterNumber == null)
                Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[11].Value = (object) clusterNumber;
            if (eseCluster == null)
                Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[12].Value = (object) eseCluster;
            if (areaTech == null)
                Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[13].Value = (object) areaTech;
            if (fax == null)
                Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[14].Value = (object) fax;
            if (fieldTechnician == null)
                Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[15].Value = (object) fieldTechnician;
            if (infrastructureTechnician == null)
                Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[16].Value = (object) infrastructureTechnician;
            if (onSiteTechnician == null)
                Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[17].Value = (object) onSiteTechnician;
            if (serverTechnician == null)
                Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[18].Value = (object) serverTechnician;
            if (hardwareTechnician == null)
                Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
            else
                Adapter.UpdateCommand.Parameters[19].Value = (object) hardwareTechnician;
            if (originalAddress1 == null)
            {
                Adapter.UpdateCommand.Parameters[20].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[20].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[21].Value = (object) originalAddress1;
            }
            if (originalZipCode == null)
            {
                Adapter.UpdateCommand.Parameters[22].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[22].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[23].Value = (object) originalZipCode;
            }
            if (originalCity == null)
            {
                Adapter.UpdateCommand.Parameters[24].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[24].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[25].Value = (object) originalCity;
            }
            if (originalState == null)
            {
                Adapter.UpdateCommand.Parameters[26].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[27].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[26].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[27].Value = (object) originalState;
            }
            if (originalFacilityName == null)
            {
                Adapter.UpdateCommand.Parameters[28].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[29].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[28].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[29].Value = (object) originalFacilityName;
            }
            if (originalRc == null)
                throw new ArgumentNullException("originalRc");
            Adapter.UpdateCommand.Parameters[30].Value = (object) originalRc;
            if (originalRegionNumber == null)
            {
                Adapter.UpdateCommand.Parameters[31].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[32].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[31].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[32].Value = (object) originalRegionNumber;
            }
            if (originalPhone == null)
            {
                Adapter.UpdateCommand.Parameters[33].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[34].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[33].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[34].Value = (object) originalPhone;
            }
            if (originalAdsLdapPath == null)
            {
                Adapter.UpdateCommand.Parameters[35].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[36].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[35].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[36].Value = (object) originalAdsLdapPath;
            }
            if (originalOldRegion == null)
            {
                Adapter.UpdateCommand.Parameters[37].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[38].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[37].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[38].Value = (object) originalOldRegion;
            }
            if (originalZoneNumber == null)
            {
                Adapter.UpdateCommand.Parameters[39].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[40].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[39].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[40].Value = (object) originalZoneNumber;
            }
            if (originalClusterNumber == null)
            {
                Adapter.UpdateCommand.Parameters[41].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[42].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[41].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[42].Value = (object) originalClusterNumber;
            }
            if (originalEseCluster == null)
            {
                Adapter.UpdateCommand.Parameters[43].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[44].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[43].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[44].Value = (object) originalEseCluster;
            }
            if (originalAreaTech == null)
            {
                Adapter.UpdateCommand.Parameters[45].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[46].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[45].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[46].Value = (object) originalAreaTech;
            }
            if (originalFax == null)
            {
                Adapter.UpdateCommand.Parameters[47].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[48].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[47].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[48].Value = (object) originalFax;
            }
            if (originalFieldTechnician == null)
            {
                Adapter.UpdateCommand.Parameters[49].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[50].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[49].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[50].Value = (object) originalFieldTechnician;
            }
            if (originalInfrastructureTechnician == null)
            {
                Adapter.UpdateCommand.Parameters[51].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[52].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[51].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[52].Value = (object) originalInfrastructureTechnician;
            }
            if (originalOnSiteTechnician == null)
            {
                Adapter.UpdateCommand.Parameters[53].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[54].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[53].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[54].Value = (object) originalOnSiteTechnician;
            }
            if (originalServerTechnician == null)
            {
                Adapter.UpdateCommand.Parameters[55].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[56].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[55].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[56].Value = (object) originalServerTechnician;
            }
            if (originalHardwareTechnician == null)
            {
                Adapter.UpdateCommand.Parameters[57].Value = (object) 1;
                Adapter.UpdateCommand.Parameters[58].Value = (object) DBNull.Value;
            }
            else
            {
                Adapter.UpdateCommand.Parameters[57].Value = (object) 0;
                Adapter.UpdateCommand.Parameters[58].Value = (object) originalHardwareTechnician;
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

        [HelpKeyword("vs.data.TableAdapter")]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public virtual int Update(string address1, string zipCode, string city, string state, string facilityName,
            string regionNumber, string phone, string adsLdapPath, string oldRegion, string zoneNumber,
            string clusterNumber, string eseCluster, string areaTech, string fax, string fieldTechnician,
            string infrastructureTechnician, string onSiteTechnician, string serverTechnician, string hardwareTechnician,
            string originalAddress1, string originalZipCode, string originalCity, string originalState,
            string originalFacilityName, string originalRc, string originalRegionNumber, string originalPhone,
            string originalAdsLdapPath, string originalOldRegion, string originalZoneNumber,
            string originalClusterNumber, string originalEseCluster, string originalAreaTech, string originalFax,
            string originalFieldTechnician, string originalInfrastructureTechnician, string originalOnSiteTechnician,
            string originalServerTechnician, string originalHardwareTechnician)
        {
            return Update(address1, zipCode, city, state, facilityName, originalRc, regionNumber, phone, adsLdapPath,
                oldRegion, zoneNumber, clusterNumber, eseCluster, areaTech, fax, fieldTechnician,
                infrastructureTechnician, onSiteTechnician, serverTechnician, hardwareTechnician, originalAddress1,
                originalZipCode, originalCity, originalState, originalFacilityName, originalRc, originalRegionNumber,
                originalPhone, originalAdsLdapPath, originalOldRegion, originalZoneNumber, originalClusterNumber,
                originalEseCluster, originalAreaTech, originalFax, originalFieldTechnician,
                originalInfrastructureTechnician, originalOnSiteTechnician, originalServerTechnician,
                originalHardwareTechnician);
        }
    }
}