using Microsoft.EntityFrameworkCore;
using LobbyistRehaulwithReact.Models;

namespace LobbyistRehaulwithReact.Data
{
    public class LobbyistDbContext : DbContext
    {
        public LobbyistDbContext(DbContextOptions<LobbyistDbContext> options) : base(options)
        {
        }

        //below are the tables/models used for the DbContext...
        public DbSet<LobbyistRehaulwithReact.Models.MasterList>? MasterList { get; set; }
        public DbSet<LobbyistRehaulwithReact.Models.Issues2>? Issues2 { get; set; }
        public DbSet<LobbyistRehaulwithReact.Models.Lobbyists_new>? Lobbyists_new { get; set; }
        public DbSet<LobbyistRehaulwithReact.Models.Expenditure_Report>? Expenditure_Report { get; set; }

    }
}
