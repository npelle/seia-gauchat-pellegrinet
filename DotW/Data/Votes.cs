//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Votes
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public bool Good { get; set; }
        public bool Bad { get; set; }
        public int IdPost { get; set; }
    
        public virtual Posts Posts { get; set; }
        public virtual Users Users { get; set; }
    }
}
