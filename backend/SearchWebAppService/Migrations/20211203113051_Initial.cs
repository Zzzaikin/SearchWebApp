using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchWebAppService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ITN = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PilotTestingPhases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilotTestingPhases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PilotProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    InitializationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProjectStageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PilotTestingPhaseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubordinateOrganization = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilotProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PilotProjects_PilotTestingPhases_PilotTestingPhaseId",
                        column: x => x.PilotTestingPhaseId,
                        principalTable: "PilotTestingPhases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PilotProjects_ProjectStages_ProjectStageId",
                        column: x => x.ProjectStageId,
                        principalTable: "ProjectStages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Post = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PilotProjectId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_PilotProjects_PilotProjectId",
                        column: x => x.PilotProjectId,
                        principalTable: "PilotProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Startups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ImageSrc = table.Column<string>(type: "TEXT", nullable: false),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false),
                    ReadyStage = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ProductUsageStage = table.Column<string>(type: "TEXT", nullable: false),
                    ProductBenefit = table.Column<string>(type: "TEXT", nullable: false),
                    MoscowTransportOrganosation = table.Column<string>(type: "TEXT", nullable: false),
                    RequestAccelerator = table.Column<string>(type: "TEXT", nullable: false),
                    IsNeedSertification = table.Column<bool>(type: "INTEGER", nullable: false),
                    PilotProjectExists = table.Column<bool>(type: "INTEGER", nullable: false),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Site = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Startups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Startups_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Startups_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PilotProjectId",
                table: "Contacts",
                column: "PilotProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PilotProjects_PilotTestingPhaseId",
                table: "PilotProjects",
                column: "PilotTestingPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PilotProjects_ProjectStageId",
                table: "PilotProjects",
                column: "ProjectStageId");

            migrationBuilder.CreateIndex(
                name: "IX_Startups_AccountId",
                table: "Startups",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Startups_ContactId",
                table: "Startups",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Startups");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "PilotProjects");

            migrationBuilder.DropTable(
                name: "PilotTestingPhases");

            migrationBuilder.DropTable(
                name: "ProjectStages");
        }
    }
}
