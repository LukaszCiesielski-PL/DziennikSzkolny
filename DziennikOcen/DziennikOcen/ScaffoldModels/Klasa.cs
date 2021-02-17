using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    [Table("Klasa")]
    public partial class Klasa
    {
        public Klasa()
        {
            AktualnyPrzedmiots = new HashSet<AktualnyPrzedmiot>();
            Uczens = new HashSet<Uczen>();
        }

        [Key]
        [Column("ID_klasa")]
        public long IdKlasa { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR (3)")]
        public string Nazwa { get; set; }

        [InverseProperty(nameof(AktualnyPrzedmiot.IdKlasaNavigation))]
        public virtual ICollection<AktualnyPrzedmiot> AktualnyPrzedmiots { get; set; }
        [InverseProperty(nameof(Uczen.IdKlasaNavigation))]
        public virtual ICollection<Uczen> Uczens { get; set; }
    }
}
