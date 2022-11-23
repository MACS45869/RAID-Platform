using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RAIDPlatform.Data.Repositories.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Application_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Application_Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Application_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Landline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Cell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Primary_Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Primary_Contact_Landline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary_Contact_Cell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Contact_Landline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary_Contact_Cell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Status_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Data_Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Permission_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Permission_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Permission_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataPermissionTypeId = table.Column<int>(type: "int", nullable: true),
                    Data_Permission_Type_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Header = table.Column<bool>(type: "bit", nullable: false),
                    Sequence_Number = table.Column<int>(type: "int", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feature_Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature_Permission_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature_Permission_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature_Permission_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Header = table.Column<bool>(type: "bit", nullable: false),
                    Sequence_Number = table.Column<int>(type: "int", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modules_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modules_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modules_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Navigations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navigation_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Navigation_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Navigation_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Navigation_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Header = table.Column<bool>(type: "bit", nullable: false),
                    Is_Menu = table.Column<bool>(type: "bit", nullable: false),
                    Sequence_Number = table.Column<int>(type: "int", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parameter_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    User_Type_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_AD_User = table.Column<bool>(type: "bit", nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    Designation_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingToId = table.Column<int>(type: "int", nullable: true),
                    Reporting_To_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgHierarchyId = table.Column<int>(type: "int", nullable: false),
                    Org_Hierarchy_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_OTP = table.Column<bool>(type: "bit", nullable: false),
                    User_OTP_Expiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    User_OTP_Expired = table.Column<bool>(type: "bit", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Status_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Application_Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Application_Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Application_Category_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Application_Category_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Status_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Application_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Application_Category_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Application_Security_Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    Client_Application_Security_Group_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Application_Security_Group_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Application_Security_Group_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Status_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: true),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Application_Security_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Application_Security_Group_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Navigations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavigationId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Client_Navigation_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Navigation_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Navigation_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Navigation_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Menu = table.Column<bool>(type: "bit", nullable: false),
                    Is_Header = table.Column<bool>(type: "bit", nullable: false),
                    Sequence_Number = table.Column<int>(type: "int", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Navigations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Navigations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParameterId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Client_Parameter_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Parameter_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Parameter_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Parameter_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Parameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Parameters_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application_Data_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    DataPermissionId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Data_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Data_Map_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Data_Map_Data_Permissions_DataPermissionId",
                        column: x => x.DataPermissionId,
                        principalTable: "Data_Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Data_Map_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application_Feature_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    FeaturePermissionId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Feature_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Feature_Map_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Feature_Map_Feature_Permissions_FeaturePermissionId",
                        column: x => x.FeaturePermissionId,
                        principalTable: "Feature_Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Feature_Map_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application_Module_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Module_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Module_Map_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Module_Map_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Module_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Module_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Module_Map_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Module_Map_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application_Navigation_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    NavigationId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Navigation_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Navigation_Map_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Navigation_Map_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Navigation_Map_Navigations_NavigationId",
                        column: x => x.NavigationId,
                        principalTable: "Navigations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Navigation_Feature_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavigationId = table.Column<int>(type: "int", nullable: false),
                    FeaturePermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigation_Feature_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Navigation_Feature_Map_Feature_Permissions_FeaturePermissionId",
                        column: x => x.FeaturePermissionId,
                        principalTable: "Feature_Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Navigation_Feature_Map_Navigations_NavigationId",
                        column: x => x.NavigationId,
                        principalTable: "Navigations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application_Parameter_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    ParameterId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Parameter_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Parameter_Map_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Parameter_Map_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Parameter_Map_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parameter_Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parameter_Value_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter_Value_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter_Value_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Header = table.Column<bool>(type: "bit", nullable: false),
                    Parameter_Value_Type = table.Column<int>(type: "int", nullable: false),
                    Parameter_Value_Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter_Value_Numeric = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Parameter_Value_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Parameter_Value_Boolean = table.Column<bool>(type: "bit", nullable: false),
                    Parameter_Value_Image = table.Column<byte>(type: "tinyint", nullable: false),
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameter_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parameter_Values_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Application_Security_Group_Category_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientApplicationSecurityGroupId = table.Column<int>(type: "int", nullable: false),
                    ClientApplicationCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Application_Security_Group_Category_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Application_Security_Group_Category_Map_Client_Application_Category_ClientApplicationCategoryId",
                        column: x => x.ClientApplicationCategoryId,
                        principalTable: "Client_Application_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Application_Security_Group_Category_Map_Client_Application_Security_Group_ClientApplicationSecurityGroupId",
                        column: x => x.ClientApplicationSecurityGroupId,
                        principalTable: "Client_Application_Security_Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "User_Security_Group_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClientApplicationSecurityGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Security_Group_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Security_Group_Map_Client_Application_Security_Group_ClientApplicationSecurityGroupId",
                        column: x => x.ClientApplicationSecurityGroupId,
                        principalTable: "Client_Application_Security_Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Security_Group_Map_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Parameter_Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientParameterId = table.Column<int>(type: "int", nullable: false),
                    Client_Parameter_Value_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Parameter_Value_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Parameter_Value_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Header = table.Column<bool>(type: "bit", nullable: false),
                    Client_Parameter_Value_Type = table.Column<int>(type: "int", nullable: false),
                    Client_Parameter_Value_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Parameter_Value_Numeric = table.Column<float>(type: "real", nullable: true),
                    Client_Parameter_Value_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Client_Parameter_Value_Boolean = table.Column<bool>(type: "bit", nullable: true),
                    Client_Parameter_Value_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Status_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_By_ID = table.Column<int>(type: "int", nullable: false),
                    Updated_By_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Parameter_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Parameter_Values_Client_Parameters_ClientParameterId",
                        column: x => x.ClientParameterId,
                        principalTable: "Client_Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationDataMapId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Data_Application_Data_Map_ApplicationDataMapId",
                        column: x => x.ApplicationDataMapId,
                        principalTable: "Application_Data_Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Data_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationFeatureMapId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Features_Application_Feature_Map_ApplicationFeatureMapId",
                        column: x => x.ApplicationFeatureMapId,
                        principalTable: "Application_Feature_Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Features_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Category_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClientApplicationCategoryId = table.Column<int>(type: "int", nullable: false),
                    UserSecurityGroupMapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Category_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Category_Map_Client_Application_Category_ClientApplicationCategoryId",
                        column: x => x.ClientApplicationCategoryId,
                        principalTable: "Client_Application_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Category_Map_User_Security_Group_Map_UserSecurityGroupMapId",
                        column: x => x.UserSecurityGroupMapId,
                        principalTable: "User_Security_Group_Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_User_Category_Map_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client_Application_Category_Data_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientApplicationCategoryId = table.Column<int>(type: "int", nullable: false),
                    ClientDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Application_Category_Data_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Application_Category_Data_Map_Client_Application_Category_ClientApplicationCategoryId",
                        column: x => x.ClientApplicationCategoryId,
                        principalTable: "Client_Application_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Application_Category_Data_Map_Client_Data_ClientDataId",
                        column: x => x.ClientDataId,
                        principalTable: "Client_Data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Client_Application_Security_Group_Feature_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientApplicationSecurityGroupId = table.Column<int>(type: "int", nullable: false),
                    ClientFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Application_Security_Group_Feature_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Application_Security_Group_Feature_Map_Client_Application_Security_Group_ClientApplicationSecurityGroupId",
                        column: x => x.ClientApplicationSecurityGroupId,
                        principalTable: "Client_Application_Security_Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Application_Security_Group_Feature_Map_Client_Features_ClientFeatureIDId",
                        column: x => x.ClientFeatureId,
                        principalTable: "Client_Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Client_Navigation_Feature_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientNavigationId = table.Column<int>(type: "int", nullable: false),
                    ClientFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Navigation_Feature_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Navigation_Feature_Map_Client_Features_ClientFeatureId",
                        column: x => x.ClientFeatureId,
                        principalTable: "Client_Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Navigation_Feature_Map_Client_Navigations_ClientNavigationId",
                        column: x => x.ClientNavigationId,
                        principalTable: "Client_Navigations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Client_Application_Category_Data_Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientApplicationCategoryDataMapId = table.Column<int>(type: "int", nullable: false),
                    Client_Application_Data_Value_ID = table.Column<int>(type: "int", nullable: false),
                    Client_Application_Data_Value_Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Application_Data_Value_Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Application_Category_Data_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Application_Category_Data_Values_Client_Application_Category_Data_Map_ClientApplicationCategoryDataMapId",
                        column: x => x.ClientApplicationCategoryDataMapId,
                        principalTable: "Client_Application_Category_Data_Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_Data_Map_ApplicationId",
                table: "Application_Data_Map",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Data_Map_DataPermissionId",
                table: "Application_Data_Map",
                column: "DataPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Data_Map_ModuleId",
                table: "Application_Data_Map",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Feature_Map_ApplicationId",
                table: "Application_Feature_Map",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Feature_Map_FeaturePermissionId",
                table: "Application_Feature_Map",
                column: "FeaturePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Feature_Map_ModuleId",
                table: "Application_Feature_Map",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Module_Map_ApplicationId",
                table: "Application_Module_Map",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Module_Map_ModuleId",
                table: "Application_Module_Map",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Navigation_Map_ApplicationId",
                table: "Application_Navigation_Map",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Navigation_Map_ModuleId",
                table: "Application_Navigation_Map",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Navigation_Map_NavigationId",
                table: "Application_Navigation_Map",
                column: "NavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Parameter_Map_ApplicationId",
                table: "Application_Parameter_Map",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Parameter_Map_ModuleId",
                table: "Application_Parameter_Map",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_Parameter_Map_ParameterId",
                table: "Application_Parameter_Map",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Category_ClientId",
                table: "Client_Application_Category",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Category_Data_Map_ClientApplicationCategoryId",
                table: "Client_Application_Category_Data_Map",
                column: "ClientApplicationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Category_Data_Map_ClientDataId",
                table: "Client_Application_Category_Data_Map",
                column: "ClientDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Category_Data_Values_ClientApplicationCategoryDataMapId",
                table: "Client_Application_Category_Data_Values",
                column: "ClientApplicationCategoryDataMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_ClientId",
                table: "Client_Application_Security_Group",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_Category_Map_ClientApplicationCategoryId",
                table: "Client_Application_Security_Group_Category_Map",
                column: "ClientApplicationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_Category_Map_ClientApplicationSecurityGroupId",
                table: "Client_Application_Security_Group_Category_Map",
                column: "ClientApplicationSecurityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_Feature_Map_ClientApplicationSecurityGroupId",
                table: "Client_Application_Security_Group_Feature_Map",
                column: "ClientApplicationSecurityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_Feature_Map_ClientFeatureId",
                table: "Client_Application_Security_Group_Feature_Map",
                column: "ClientFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Data_ApplicationDataMapId",
                table: "Client_Data",
                column: "ApplicationDataMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Data_ClientId",
                table: "Client_Data",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Features_ApplicationFeatureMapId",
                table: "Client_Features",
                column: "ApplicationFeatureMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Features_ClientId",
                table: "Client_Features",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Module_Map_ClientId",
                table: "Client_Module_Map",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Module_Map_ModuleId",
                table: "Client_Module_Map",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Navigation_Feature_Map_ClientFeatureId",
                table: "Client_Navigation_Feature_Map",
                column: "ClientFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Navigation_Feature_Map_ClientNavigationId",
                table: "Client_Navigation_Feature_Map",
                column: "ClientNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Navigations_ClientId",
                table: "Client_Navigations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Parameter_Values_ClientParameterId",
                table: "Client_Parameter_Values",
                column: "ClientParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Parameters_ClientId",
                table: "Client_Parameters",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Navigation_Feature_Map_FeaturePermissionId",
                table: "Navigation_Feature_Map",
                column: "FeaturePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Navigation_Feature_Map_NavigationId",
                table: "Navigation_Feature_Map",
                column: "NavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Parameter_Values_ParameterId",
                table: "Parameter_Values",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Category_Map_ClientApplicationCategoryId",
                table: "User_Category_Map",
                column: "ClientApplicationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Category_Map_UserId",
                table: "User_Category_Map",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Category_Map_UserSecurityGroupMapId",
                table: "User_Category_Map",
                column: "UserSecurityGroupMapId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Security_Group_Map_ClientApplicationSecurityGroupId",
                table: "User_Security_Group_Map",
                column: "ClientApplicationSecurityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Security_Group_Map_UserId",
                table: "User_Security_Group_Map",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application_Module_Map");

            migrationBuilder.DropTable(
                name: "Application_Navigation_Map");

            migrationBuilder.DropTable(
                name: "Application_Parameter_Map");

            migrationBuilder.DropTable(
                name: "Client_Application_Category_Data_Values");

            migrationBuilder.DropTable(
                name: "Client_Application_Security_Group_Category_Map");

            migrationBuilder.DropTable(
                name: "Client_Application_Security_Group_Feature_Map");

            migrationBuilder.DropTable(
                name: "Client_Module_Map");

            migrationBuilder.DropTable(
                name: "Client_Navigation_Feature_Map");

            migrationBuilder.DropTable(
                name: "Client_Parameter_Values");

            migrationBuilder.DropTable(
                name: "Navigation_Feature_Map");

            migrationBuilder.DropTable(
                name: "Parameter_Values");

            migrationBuilder.DropTable(
                name: "User_Category_Map");

            migrationBuilder.DropTable(
                name: "Client_Application_Category_Data_Map");

            migrationBuilder.DropTable(
                name: "Client_Features");

            migrationBuilder.DropTable(
                name: "Client_Navigations");

            migrationBuilder.DropTable(
                name: "Client_Parameters");

            migrationBuilder.DropTable(
                name: "Navigations");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "User_Security_Group_Map");

            migrationBuilder.DropTable(
                name: "Client_Application_Category");

            migrationBuilder.DropTable(
                name: "Client_Data");

            migrationBuilder.DropTable(
                name: "Application_Feature_Map");

            migrationBuilder.DropTable(
                name: "Client_Application_Security_Group");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Application_Data_Map");

            migrationBuilder.DropTable(
                name: "Feature_Permissions");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Data_Permissions");

            migrationBuilder.DropTable(
                name: "Modules");
        }
    }
}
