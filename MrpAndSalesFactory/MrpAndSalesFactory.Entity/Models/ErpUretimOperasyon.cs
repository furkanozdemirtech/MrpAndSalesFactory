﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MrpAndSalesFactory.Entity.Models
{
    public partial class ErpUretimOperasyon
    {
        public int Id { get; set; }
        public int UretimFisid { get; set; }
        public int UretimDetayid { get; set; }
        public int Tezgahid { get; set; }
        public int Operatorid { get; set; }
        public int Operasyonid { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BaslamaSaati { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public DateTime? BitisSaati { get; set; }
        public decimal Miktar { get; set; }
    }
}