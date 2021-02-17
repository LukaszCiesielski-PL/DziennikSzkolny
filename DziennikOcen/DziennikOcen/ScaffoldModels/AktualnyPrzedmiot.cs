using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    [Table("Aktualny_przedmiot")]
    public partial class AktualnyPrzedmiot
    {
        [Key]
        [Column("ID_akt_przed")]
        public long IdAktPrzed { get; set; }
        [Column("ID_nauczyciel")]
        public long IdNauczyciel { get; set; }
        [Column("ID_klasa")]
        public long IdKlasa { get; set; }
        [Column("ID_przedmiot")]
        public long IdPrzedmiot { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Dzien { get; set; }

        [ForeignKey(nameof(IdKlasa))]
        [InverseProperty(nameof(Klasa.AktualnyPrzedmiots))]
        public virtual Klasa IdKlasaNavigation { get; set; }
        [ForeignKey(nameof(IdNauczyciel))]
        [InverseProperty(nameof(Nauczyciel.AktualnyPrzedmiots))]
        public virtual Nauczyciel IdNauczycielNavigation { get; set; }
        [ForeignKey(nameof(IdPrzedmiot))]
        [InverseProperty(nameof(Przedmiot.AktualnyPrzedmiots))]
        public virtual Przedmiot IdPrzedmiotNavigation { get; set; }
    }
}
