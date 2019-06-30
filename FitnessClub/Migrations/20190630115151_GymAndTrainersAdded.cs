using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FitnessClub.Migrations
{
    public partial class GymAndTrainersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdGym",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gyms",
                columns: table => new
                {
                    IdGym = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 240, nullable: false),
                    City = table.Column<string>(maxLength: 240, nullable: false),
                    Address = table.Column<string>(maxLength: 480, nullable: false),
                    WorkingHours = table.Column<string>(maxLength: 240, nullable: false),
                    Contact = table.Column<string>(maxLength: 480, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.IdGym);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    IdTrainer = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(maxLength: 120, nullable: false),
                    LastName = table.Column<string>(maxLength: 120, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Qualifications = table.Column<string>(maxLength: 960, nullable: false),
                    Achievements = table.Column<string>(maxLength: 960, nullable: false),
                    IdGym = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.IdTrainer);
                    table.ForeignKey(
                        name: "FK_Trainers_Gyms_IdGym",
                        column: x => x.IdGym,
                        principalTable: "Gyms",
                        principalColumn: "IdGym",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdGym",
                table: "Customers",
                column: "IdGym");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_IdGym",
                table: "Trainers",
                column: "IdGym");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Gyms_IdGym",
                table: "Customers",
                column: "IdGym",
                principalTable: "Gyms",
                principalColumn: "IdGym",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Gyms_IdGym",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdGym",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdGym",
                table: "Customers");
        }
    }
}
