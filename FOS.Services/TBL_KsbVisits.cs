
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace FOS.DataLayer
{

using System;
    using System.Collections.Generic;
    
public partial class TBL_KsbVisits
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TBL_KsbVisits()
    {

        this.AddPurposeOfVisits = new HashSet<AddPurposeOfVisit>();

        this.AddSiteStatus = new HashSet<AddSiteStatu>();

        this.AddStaffLists = new HashSet<AddStaffList>();

        this.MultipleSiteVisits = new HashSet<MultipleSiteVisit>();

        this.AddMultipleComplaintVisits = new HashSet<AddMultipleComplaintVisit>();

    }


    public int ID { get; set; }

    public Nullable<int> SiteID { get; set; }

    public Nullable<int> VisitTypeID { get; set; }

    public string Remarks { get; set; }

    public byte[] Picture1 { get; set; }

    public string Picture2 { get; set; }

    public Nullable<System.DateTime> LaunchDate { get; set; }

    public Nullable<bool> IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public Nullable<int> TimeInHours { get; set; }

    public Nullable<System.DateTime> Datefrom { get; set; }

    public Nullable<System.DateTime> Dateto { get; set; }



    public virtual Retailer Retailer { get; set; }

    public virtual VisitPurpose VisitPurpose { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AddPurposeOfVisit> AddPurposeOfVisits { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AddSiteStatu> AddSiteStatus { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AddStaffList> AddStaffLists { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MultipleSiteVisit> MultipleSiteVisits { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AddMultipleComplaintVisit> AddMultipleComplaintVisits { get; set; }

}

}