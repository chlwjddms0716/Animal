//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalShelterManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class LossReport
    {
        public int LossReportId { get; set; }
        public string Place { get; set; }
        public System.DateTime Date { get; set; }
        public string AnimalName { get; set; }
        public int UserId { get; set; }
        public string PictureLink { get; set; }
        public Nullable<int> Species { get; set; }
    
        public virtual User User { get; set; }
    }
}
