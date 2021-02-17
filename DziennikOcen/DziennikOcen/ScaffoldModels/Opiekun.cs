﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    [Table("Opiekun")]
    public partial class Opiekun
    {
        public Opiekun()
        {
            Uczens = new HashSet<Uczen>();
        }

        [Key]
        [Column("ID_opiekun")]
        public long IdOpiekun { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Imie { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Nazwisko { get; set; }
        [Column("Numer_tel", TypeName = "STRING (12)")]
        public byte[] NumerTel { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Email { get; set; }
        [Column("Miasto_zam", TypeName = "STRING")]
        public byte[] MiastoZam { get; set; }
        [Column("Ulica_zam", TypeName = "STRING")]
        public byte[] UlicaZam { get; set; }
        [Column("Numer_ul", TypeName = "VARCHAR (8)")]
        public string NumerUl { get; set; }

        [InverseProperty(nameof(Uczen.IdOpiekunNavigation))]
        public virtual ICollection<Uczen> Uczens { get; set; }
    }
}
