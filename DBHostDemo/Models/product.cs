//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBHostDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public Nullable<int> pQuantity { get; set; }
        public Nullable<double> pPrice { get; set; }
        public string pRemarks { get; set; }
    }
}