﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MrpAndSalesFactory.Entity.Models
{
    public partial class Rapor
    {
        public int Id { get; set; }
        public short Bolumid { get; set; }
        public short Tip { get; set; }
        public bool Masterreport { get; set; }
        public string Reportname { get; set; }
        public short? Reporttype { get; set; }
        public byte[] Reportstream { get; set; }
        public bool? Fastreport { get; set; }
    }
}