//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_Db_Hospital_Management_EntityFramework.MyDbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Purchase_Hedar
    {
        public int PurchaseHedarId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> GlobalId { get; set; }
        public string PurchaseDocumentNo { get; set; }
        public Nullable<int> PurchaseStatus { get; set; }
        public Nullable<int> PurchaseApprovBy { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<decimal> PurchaseTotalAmount { get; set; }
        public Nullable<int> PurchaseType { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> PayTerms { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<decimal> Commision { get; set; }
        public Nullable<decimal> CommisionAmount { get; set; }
        public Nullable<decimal> TotalPurchaseAmountHedar { get; set; }
        public string Remark { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
        public string Attr4 { get; set; }
        public string Attr5 { get; set; }
        public Nullable<decimal> Attr6 { get; set; }
        public Nullable<decimal> Attr7 { get; set; }
        public Nullable<int> Attr8 { get; set; }
    }
}