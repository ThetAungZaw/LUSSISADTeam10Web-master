//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LUSSISADTeam10API.Models.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class disbursementlocker
    {
        public int disid { get; set; }
        public int reqid { get; set; }
        public int lockerid { get; set; }
        public System.DateTime delivereddate { get; set; }
        public Nullable<System.DateTime> collecteddate { get; set; }
        public byte status { get; set; }
        public int deptid { get; set; }
    
        public virtual department department { get; set; }
        public virtual disbursement disbursement { get; set; }
        public virtual lockercollectionpoint lockercollectionpoint { get; set; }
        public virtual requisition requisition { get; set; }
    }
}
