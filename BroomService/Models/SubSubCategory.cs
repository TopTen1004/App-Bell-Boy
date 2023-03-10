//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BroomService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubSubCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubSubCategory()
        {
            this.UserSubCategories = new HashSet<UserSubCategory>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> SubCatId { get; set; }
        public Nullable<decimal> ClientPrice { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Picture { get; set; }
        public string Icon { get; set; }
        public string Name_Russian { get; set; }
        public string Name_French { get; set; }
        public string Name_Hebrew { get; set; }
        public string Description_French { get; set; }
        public string Description_Russian { get; set; }
        public string Description_Hebrew { get; set; }
        public string Description { get; set; }
    
        public virtual SubCategory SubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSubCategory> UserSubCategories { get; set; }
    }
}
