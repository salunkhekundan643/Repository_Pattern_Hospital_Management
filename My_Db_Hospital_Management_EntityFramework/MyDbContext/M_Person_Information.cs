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
    
    public partial class M_Person_Information
    {
        public int PersonId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> GlobalId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string PersonCode { get; set; }
        public Nullable<int> PersonType { get; set; }
        public string PersonName { get; set; }
        public string PersonAddress { get; set; }
        public string PersonEmailId { get; set; }
        public string PersonContactNumber { get; set; }
        public string PersonBussnessName { get; set; }
        public string PersonOfficeNumber { get; set; }
        public string PersonPancard { get; set; }
        public string PersonCity { get; set; }
        public Nullable<int> PersonBankName { get; set; }
        public string PersonAccountNumber { get; set; }
        public string PersonGstNumber { get; set; }
        public Nullable<int> PaymentTerms { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> ActiveFlag { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
        public Nullable<int> Attr4 { get; set; }
        public Nullable<System.DateTime> Attr5 { get; set; }
    }
}