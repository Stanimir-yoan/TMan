//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMan
{
    using System;
    using System.Collections.Generic;
    
    public partial class TasksReport
    {
        public int ReportId { get; set; }
        public Nullable<int> ToTask { get; set; }
        public Nullable<int> ByUser { get; set; }
        public Nullable<int> NumberOfHours { get; set; }
        public Nullable<System.DateTime> DateOfReport { get; set; }
    
        public virtual TMTask TMTask { get; set; }
        public virtual TMUser TMUser { get; set; }
    }
}
