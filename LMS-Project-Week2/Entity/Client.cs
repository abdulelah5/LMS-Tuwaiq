//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS_Project_Week2.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public Nullable<int> BookId { get; set; }
        public string Status { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
