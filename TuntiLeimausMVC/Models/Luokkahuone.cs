
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
    
public partial class Luokkahuone
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Luokkahuone()
    {

        this.Leimaus = new HashSet<Leimaus>();

    }


    public int LuokkahuoneID { get; set; }

    public string Etunimi { get; set; }

    public string Sukunimi { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Leimaus> Leimaus { get; set; }

}

}
