﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MrpAndSalesFactory.Entity.Models
{
    public partial class Depo
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Adi { get; set; }
        public bool Durum { get; set; }
        public int? Ozelgrup1 { get; set; }
        public int? Ozelgrup2 { get; set; }
        public string Ozelalan1 { get; set; }
        public string Ozelalan2 { get; set; }
        public string Notlar { get; set; }
        public int Subeid { get; set; }
        public int? Yetkikodid { get; set; }
    }
}