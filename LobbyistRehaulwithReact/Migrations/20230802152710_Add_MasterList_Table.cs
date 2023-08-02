using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LobbyistRehaulwithReact.Migrations
{
    public partial class Add_MasterList_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LobbyistID = table.Column<int>(name: "Lobbyist ID", type: "int", nullable: false),
                    Principal_ID = table.Column<int>(type: "int", nullable: false),
                    Withdrawal = table.Column<string>(type: "char", nullable: true),
                    Lobbyist = table.Column<string>(type: "char", nullable: false),
                    LawFirmEmployeer = table.Column<string>(name: "Law Firm/Employeer", type: "char", nullable: true),
                    LobbyistAdd = table.Column<string>(name: "Lobbyist Add", type: "char", nullable: true),
                    LobbyistPhone = table.Column<string>(name: "Lobbyist Phone", type: "char", nullable: true),
                    Principal = table.Column<string>(type: "char", nullable: true),
                    PrincipalAdd = table.Column<string>(name: "Principal Add", type: "char", nullable: true),
                    PrincipalPhone = table.Column<string>(name: "Principal Phone", type: "char", nullable: true),
                    AssociatedProject = table.Column<string>(name: "Associated Project", type: "char", nullable: true),
                    Issue = table.Column<string>(type: "char", nullable: true),
                    AmountPaid = table.Column<decimal>(name: "Amount Paid", type: "money", nullable: true),
                    Year = table.Column<double>(type: "float", nullable: true),
                    Dateofpayment = table.Column<DateTime>(name: "Date of payment", type: "datetime", nullable: true),
                    LinktoApplication = table.Column<string>(name: "Link to Application", type: "char", nullable: true),
                    PrincipalEmail = table.Column<string>(name: "Principal Email", type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterList", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterList");
        }
    }
}
