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
    
    public partial class T_Purchase_Line
    {
        public int PurchaseLineId { get; set; }
        public Nullable<int> PurchaseHedar { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> GlobalId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> ItemQty { get; set; }
        public Nullable<decimal> ItemTotalStripQty { get; set; }
        public Nullable<decimal> ItemStripQty { get; set; }
        public Nullable<decimal> ItemPerUnitRate { get; set; }
        public Nullable<int> ItemUnit { get; set; }
        public Nullable<decimal> ItemRate { get; set; }
        public Nullable<int> ItemPacking { get; set; }
        public Nullable<int> TaxId { get; set; }
        public Nullable<int> GodownId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<System.DateTime> DevileryDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> TaxType { get; set; }
        public Nullable<decimal> BasicAmount { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public string QualityCheck { get; set; }
        public string BatchNO { get; set; }
        public Nullable<System.DateTime> BatchDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<decimal> ItemMrp { get; set; }
        public Nullable<decimal> ItemDiscount { get; set; }
        public Nullable<decimal> ItemMediRate { get; set; }
        public Nullable<decimal> MediQty { get; set; }
        public Nullable<decimal> GstVat { get; set; }
        public Nullable<decimal> Sgst { get; set; }
        public Nullable<decimal> Igst { get; set; }
        public Nullable<decimal> MediTotalAmount { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public Nullable<decimal> Attr3 { get; set; }
        public Nullable<decimal> Attr4 { get; set; }
        public Nullable<decimal> Attr5 { get; set; }
        public Nullable<int> Attr6 { get; set; }
        public Nullable<int> Attr7 { get; set; }
        public string HsnCode { get; set; }
        public Nullable<decimal> SachDiscount { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> FreeQty { get; set; }
        public Nullable<int> PackingId { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
    }
}
