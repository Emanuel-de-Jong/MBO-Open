//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBO_Open.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aanmeldingen
    {
        public int ID { get; set; }
        public int SpelerID { get; set; }
        public int ToernooiID { get; set; }
    
        public virtual Speler Speler { get; set; }
        public virtual Toernooien Toernooien { get; set; }
    }
}
