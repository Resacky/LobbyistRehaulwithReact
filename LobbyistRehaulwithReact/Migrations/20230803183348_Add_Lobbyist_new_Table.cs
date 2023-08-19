using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LobbyistRehaulwithReact.Migrations
{
    public partial class Add_Lobbyist_new_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issues2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Principal_ID = table.Column<string>(type: "char", nullable: false),
                    Board = table.Column<string>(type: "char", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Memo_Field = table.Column<string>(type: "char", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    AssociatedProject = table.Column<string>(name: "Associated Project", type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues2", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues2");
        }
    }
}
