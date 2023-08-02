using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LobbyistRehaulwithReact.Models
{
    public class MasterList
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Lobbyist ID")]
        public int LobbyistID { get; set; }

        [Column("Principal_ID")]
        public int Principal_ID { get; set; }

        [Column("Withdrawal", TypeName = "char")]
        public string? Withdrawal { get; set; }

        [Column("Lobbyist", TypeName = "char")]
        public string Lobbyist { get; set; }

        [Column("Law Firm/Employeer", TypeName = "char")]
        public string? LawFirmEmployeer { get; set; }

        [Column("Lobbyist Add", TypeName = "char")]
        public string? LobbyistAdd { get; set; }

        [Column("Lobbyist Phone", TypeName = "char")]
        public string? LobbyistPhone { get; set; }

        [Column("Principal",TypeName = "char")]
        public string? principal { get; set; }

        [Column("Principal Add", TypeName = "char")]
        public string? PrincipalAdd { get; set; }

        [Column("Principal Phone", TypeName = "char")]
        public string? PrincipalPhone { get; set; }

        [Column("Associated Project", TypeName = "char")]
        public string? AssociatedProject { get; set; }

        [Column("Issue", TypeName = "char")]
        public string? issue { get; set; }

        [Column("Amount Paid", TypeName = "money")]
        public decimal? amountPaid { get; set; }

        [Column("Year", TypeName = "float")]
        public float? year { get; set; }

        [Column("Date of payment", TypeName = "datetime")]
        public DateTime? dateOfPayment { get; set; }

        [Column("Link to Application", TypeName = "char")]
        public string? linkToApplication { get; set; }

        [Column("Principal Email", TypeName = "char")]
        public string? principleEmail { get; set; }

    }
}
