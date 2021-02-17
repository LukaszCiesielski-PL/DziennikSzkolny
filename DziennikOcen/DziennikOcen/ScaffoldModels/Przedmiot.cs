using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    [Table("Przedmiot")]
    public partial class Przedmiot
    {
        public Przedmiot()
        {
            AktualnyPrzedmiots = new HashSet<AktualnyPrzedmiot>();
            Ocenas = new HashSet<Ocena>();
        }

        [Key]
        [Column("ID_przedmiot")]
        public long IdPrzedmiot { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] Nazwa { get; set; }

        [InverseProperty(nameof(AktualnyPrzedmiot.IdPrzedmiotNavigation))]
        public virtual ICollection<AktualnyPrzedmiot> AktualnyPrzedmiots { get; set; }
        [InverseProperty(nameof(Ocena.IdPrzedmiotNavigation))]
        public virtual ICollection<Ocena> Ocenas { get; set; }
    }
}
