﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MrpAndSalesFactory.Entity.Models
{
    public partial class ErpUrunAgaciKombini
    {
        public int Id { get; set; }
        public int KombiniUrunid { get; set; }
        public int UrunAgaciid { get; set; }
        public int Detayid { get; set; }
        public int Stokid { get; set; }
        public decimal Miktar { get; set; }
        public int Boyut01id { get; set; }
        public int Boyut02id { get; set; }
        public int Boyut03id { get; set; }
    }
}