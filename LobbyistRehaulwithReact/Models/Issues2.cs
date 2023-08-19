using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LobbyistRehaulwithReact.Models
{
    public class Issues2
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Principal_ID", TypeName = "char")]
        public string Principal_ID { get; set; }

        [Column("Board", TypeName = "char")]
        public string? Board { get; set; }

        [Column("Date", TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column("Memo_Field", TypeName = "char")]
        public string? Memo_Field { get; set; }

        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }

        [Column("Associated Project", TypeName = "char")]
        public string? AssociatedProject { get; set; }
    }
}
