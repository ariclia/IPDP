//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicatie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pilot
    {
        [Key]
        public int IDPilot { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NrLicense { get; set; }
        public string Locality { get; set; }
    }
}
