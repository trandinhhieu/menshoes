//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MenShoe.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public long OrderID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> CustomerID { get; set; }
        public string ShipName { get; set; }
        public string ShipMobile { get; set; }
        public string ShipAdress { get; set; }
        public string ShipEmail { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
