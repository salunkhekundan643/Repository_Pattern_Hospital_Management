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
    
    public partial class A_M_Lookup_Hedar
    {
        public int LookupId { get; set; }
        public int ClientId { get; set; }
        public Nullable<int> GlobalId { get; set; }
        public string LookupName { get; set; }
        public string LookupDescription { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string ActiveFlag { get; set; }
    }
}