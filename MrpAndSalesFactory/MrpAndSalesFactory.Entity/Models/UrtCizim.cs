﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MrpAndSalesFactory.Entity.Models
{
    public partial class UrtCizim
    {
        public UrtCizim()
        {
            Siparis = new HashSet<Siparis>();
        }

        public int Id { get; set; }
        public string Dosyaadi { get; set; }
        public float? Kuponagirligi { get; set; }
        public byte[] DesenResim { get; set; }
        public decimal? Desenvurus { get; set; }
        public bool? Varmi { get; set; }

        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}