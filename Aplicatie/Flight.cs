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

    public partial class Flight
    {
        [Key]
        public int IDFlight { get; set; }
        public string Name { get; set; }
        public string TakeOffDate { get; set; }
        public string TakeOffAirport { get; set; }
        public string LandingDate { get; set; }
        public string LandingAirport { get; set; }
        public string EmargencyAirport { get; set; }
    }
}
