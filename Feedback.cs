//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string CustomerEmail { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> FeedbackDate { get; set; }
        public int CustomerID { get; set; }
    
        public virtual CustomerR CustomerR { get; set; }
    }
}
