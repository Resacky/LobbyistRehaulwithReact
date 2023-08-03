using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LobbyistRehaulwithReact.Migrations
{
    public partial class Add_Expenditure_Report_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lobbyists_new",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "char", nullable: false),
                    Business_Name = table.Column<string>(type: "char", nullable: false),
                    Telephone_Number = table.Column<string>(type: "char", nullable: false),
                    Address = table.Column<string>(type: "char", nullable: false),
                    City = table.Column<string>(type: "char", nullable: false),
                    State = table.Column<string>(type: "char", nullable: false),
                    Zip_Code = table.Column<string>(type: "char", nullable: false),
                    Street_Address = table.Column<string>(type: "char", nullable: true),
                    LobbyistID = table.Column<int>(name: "Lobbyist ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lobbyists_new", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lobbyists_new");
        }
    }
}
