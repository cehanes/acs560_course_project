//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR_Query.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int Request_ID { get; set; }
        public string Requestor_Name { get; set; }
        public bool Request_Status { get; set; }
        public int Employee_ID { get; set; }
        public int Request_Type_Index { get; set; }
    
        public virtual Request_Type Request_Type { get; set; }
    }
}