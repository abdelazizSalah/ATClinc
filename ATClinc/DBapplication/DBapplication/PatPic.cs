//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBapplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatPic
    {
        public int ID { get; set; }
        public byte[] img { get; set; }
        public string FileName { get; set; }
        public string phoneNumber { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
