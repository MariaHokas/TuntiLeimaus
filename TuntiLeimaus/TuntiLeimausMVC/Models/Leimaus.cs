//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TuntiLeimausMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leimaus
    {
        public int LeimausID { get; set; }
        public Nullable<int> OpiskelijaID { get; set; }
        public Nullable<int> LuokkahuoneID { get; set; }
        public Nullable<System.DateTime> Sisään { get; set; }
        public Nullable<System.DateTime> Ulos { get; set; }
    
        public virtual Luokkahuone Luokkahuone { get; set; }
        public virtual Opiskelijat Opiskelijat { get; set; }
    }
}
