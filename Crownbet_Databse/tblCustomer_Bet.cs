//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crownbet_Databse
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer_Bet
    {
        public long Id { get; set; }
        public long RaceId { get; set; }
        public long HorseId { get; set; }
        public long CustomerId { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblHorse tblHorse { get; set; }
        public virtual tblRace tblRace { get; set; }
    }
}
