using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RAIDPlatform.Data.Repositories.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Feature_Map_Modules_ModuleId",
                table: "Application_Feature_Map");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleId",
                table: "Application_Feature_Map",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClientId",
                table: "Users",
                column: "ClientId");


            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_ApplicationId",
                table: "Client_Application_Security_Group",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Feature_Map_Modules_ModuleId",
                table: "Application_Feature_Map",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Application_Security_Group_Applications_ApplicationId",
                table: "Client_Application_Security_Group",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Feature_Map_Modules_ModuleId",
                table: "Application_Feature_Map");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Application_Security_Group_Applications_ApplicationId",
                table: "Client_Application_Security_Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Application_Security_Group_Feature_Map_Client_Features_ClientFeatureId",
                table: "Client_Application_Security_Group_Feature_Map");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clients_ClientId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClientId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Client_Application_Security_Group_Feature_Map_ClientFeatureId",
                table: "Client_Application_Security_Group_Feature_Map");

            migrationBuilder.DropIndex(
                name: "IX_Client_Application_Security_Group_ApplicationId",
                table: "Client_Application_Security_Group");

            migrationBuilder.AddColumn<int>(
                name: "ClientFeatureIDId",
                table: "Client_Application_Security_Group_Feature_Map",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ModuleId",
                table: "Application_Feature_Map",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_Application_Security_Group_Feature_Map_ClientFeatureIDId",
                table: "Client_Application_Security_Group_Feature_Map",
                column: "ClientFeatureIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Feature_Map_Modules_ModuleId",
                table: "Application_Feature_Map",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Application_Security_Group_Feature_Map_Client_Features_ClientFeatureIDId",
                table: "Client_Application_Security_Group_Feature_Map",
                column: "ClientFeatureIDId",
                principalTable: "Client_Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
