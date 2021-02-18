﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    [Table("Nauczyciel")]
    public partial class Nauczyciel
    {
        public Nauczyciel()
        {
            AktualnyPrzedmiots = new HashSet<AktualnyPrzedmiot>();
            Ocenas = new HashSet<Ocena>();
        }

        [Key]
        [Column("ID_nauczyciel")]
        public long IdNauczyciel { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] Imie { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] Nazwisko { get; set; }
        [Column("Numer_tel", TypeName = "STRING (12)")]
        public byte[] NumerTel { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Email { get; set; }
        [Required]
        [Column("Uczony_przedmiot", TypeName = "STRING")]
        public byte[] UczonyPrzedmiot { get; set; }
        [Required]
        [Column(TypeName = "STRING (20)")]
        public string Login { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR (20)")]
        public string Haslo { get; set; }

        [InverseProperty(nameof(AktualnyPrzedmiot.IdNauczycielNavigation))]
        public virtual ICollection<AktualnyPrzedmiot> AktualnyPrzedmiots { get; set; }
        [InverseProperty(nameof(Ocena.IdNauczycielNavigation))]
        public virtual ICollection<Ocena> Ocenas { get; set; }
    }
}
