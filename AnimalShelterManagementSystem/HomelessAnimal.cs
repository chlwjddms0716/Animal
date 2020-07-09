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
    
    public partial class HomelessAnimal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HomelessAnimal()
        {
            this.Adoptions = new HashSet<Adoption>();
            this.FindingReportRecords = new HashSet<FindingReportRecord>();
            this.FoundAnimalRecords = new HashSet<FoundAnimalRecord>();
        }
    
        public int HomelessAnimalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Feature { get; set; }
        public System.DateTime LatestFindingReport { get; set; }
        public string PictureLink { get; set; }
        public int PhysicalCondition { get; set; }
        public int Species { get; set; }
        public int AdoptionStatus { get; set; }
        public int AnimalShelterId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adoption> Adoptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FindingReportRecord> FindingReportRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoundAnimalRecord> FoundAnimalRecords { get; set; }
    }
}
