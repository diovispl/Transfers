//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransfersLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rate_Vehicle
    {
        public long ID_Rate { get; set; }
        public long ID_Vehicle { get; set; }
        public decimal Margin { get; set; }
        public int ID_MarginType { get; set; }
        public decimal Price_Supplier { get; set; }
        public Nullable<int> Extra_Suitcase { get; set; }
        public Nullable<int> Extra_Hand_Bags { get; set; }
        public Nullable<int> Extra_Cycles { get; set; }
        public Nullable<int> Extra_Golf_Bags { get; set; }
        public Nullable<int> Extra_Child_Safety { get; set; }
        public Nullable<int> Extra_Child_Booster { get; set; }
        public Nullable<decimal> Price_Suitcase { get; set; }
        public Nullable<decimal> Price_Hand_Bags { get; set; }
        public Nullable<decimal> Price_Cycles { get; set; }
        public Nullable<decimal> Price_Golf_Bags { get; set; }
        public Nullable<decimal> Price_Child_Safety { get; set; }
        public Nullable<decimal> Price_Child_Booster { get; set; }
        public bool IS_RQ { get; set; }
    }
}
