﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MrpAndSalesFactory.Entity.Models
{
    public partial class ErpStokMaliyet
    {
        public int Id { get; set; }
        public int Kartid { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public decimal BirimMaliyet { get; set; }
        public int Dovizid { get; set; }
        public decimal DovizKuru { get; set; }
    }
}