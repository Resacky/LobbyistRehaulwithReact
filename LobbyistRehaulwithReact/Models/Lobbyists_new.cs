using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LobbyistRehaulwithReact.Models
{
    public class Lobbyists_new
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name", TypeName = "char")]
        public string Name { get; set; }

        [Column("Business_Name", TypeName = "char")]
        public string BuesinessName { get; set; }

        [Column("Telephone_Number", TypeName = "char")]
        public string TelephoneNumber { get; set; }

        [Column("Address", TypeName = "char")]
        public string Address { get; set; }

        [Column("City", TypeName = "char")]
        public string City { get; set; }

        [Column("State", TypeName = "char")]
        public string State { get; set; }

        [Column("Zip_Code", TypeName = "char")]
        public string PostalCode { get; set; }

        [Column("Street_Address", TypeName = "char")]
        public string? StreetAddress { get; set; }

        [Column("Lobbyist ID")]
        public int? LobbyistID { get; set; }
        
    }
}
