using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LobbyistRehaulwithReact.Models
{
    public class Expenditure_Report
    {
        [Key]
        public int Id { get; set; }

        [Column("Lobbyist_ID")]
        public int LobbyistID { get; set; }

        [Column("Principal_ID")]
        public int PrincipalID { get; set; }

        [Column("Principal", TypeName = "char")]
        public string Principal { get; set; }

        [Column("Food_Beverage", TypeName = "numeric")]
        public decimal? FoodBeverage { get; set; }

        [Column("Entertainment", TypeName = "numeric")]
        public decimal? Entertainment { get; set; }

        [Column("Research", TypeName = "numeric")]
        public decimal? Research { get; set; }

        [Column("Communications", TypeName = "numeric")]
        public decimal? Communications { get; set; }

        [Column("Media_Advertising", TypeName = "numeric")]
        public decimal? MediaAdvertising { get; set; }

        [Column("Publications", TypeName = "numeric")]
        public decimal? Publications { get; set; }

        [Column("Travel", TypeName = "numeric")]
        public decimal? Travel { get; set; }

        [Column("Lodging", TypeName = "numeric")]
        public decimal? Lodging { get; set; }

        [Column("Special_Events", TypeName = "numeric")]
        public decimal? SpecialEvents { get; set; }

        [Column("Other", TypeName = "numeric")]
        public decimal? Other { get; set; }

        [Column("Total", TypeName = "numeric")]
        public decimal? Total { get; set; }

        [Column("Date", TypeName = "date")]
        public DateTime Date { get; set; }

        [Column("Year", TypeName = "char")]
        public string? Year { get; set; }

    }
}
