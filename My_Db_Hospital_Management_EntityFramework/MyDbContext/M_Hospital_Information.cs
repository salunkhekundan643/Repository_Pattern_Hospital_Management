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
    
    public partial class M_Hospital_Information
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
        public string HospitalEmailAddress { get; set; }
        public string Logo { get; set; }
        public string HospitalCity { get; set; }
        public string HospitalPan { get; set; }
        public string HospitalContactNumber { get; set; }
        public string HospitalContactNumber1 { get; set; }
        public string Hospitalwedsite { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}