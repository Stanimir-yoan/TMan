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
    
    public partial class TMTask
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public string Description { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> Estimation { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateLastModified { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual TMTask TMTasks1 { get; set; }
        public virtual TMTask TMTask1 { get; set; }
    }
}