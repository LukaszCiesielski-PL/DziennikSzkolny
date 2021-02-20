using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Dziennik
{
    [Table("Ocena")]
    public partial class Ocena
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_ocena")]
        public int IdOcena { get; set; }

        [Column("ID_uczen")]
        public long IdUczen { get; set; }
        [Required]
        [Column("Ocena", TypeName = "STRING (2)")]
        public string Ocena1 { get; set; }
        [Column(TypeName = "STRING")]
        public string Opis { get; set; }
        [Column("ID_nauczyciel")]
        public long IdNauczyciel { get; set; }
        [Column("ID_przedmiot")]
        public long IdPrzedmiot { get; set; }
        [Required]
        [Column(TypeName = "DATE (10)")]
        public string Data { get; set; }

        [ForeignKey(nameof(IdNauczyciel))]
        [InverseProperty(nameof(Nauczyciel.Ocenas))]
        public virtual Nauczyciel IdNauczycielNavigation { get; set; }
        [ForeignKey(nameof(IdPrzedmiot))]
        [InverseProperty(nameof(Przedmiot.Ocenas))]
        public virtual Przedmiot IdPrzedmiotNavigation { get; set; }
        [ForeignKey(nameof(IdUczen))]
        [InverseProperty(nameof(Uczen.Ocenas))]
        public virtual Uczen IdUczenNavigation { get; set; }
    }
}
