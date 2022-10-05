
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
    
public partial class SaleOfficer
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SaleOfficer()
    {

        this.AccessLogs = new HashSet<AccessLog>();

        this.CompititorInfoes = new HashSet<CompititorInfo>();

        this.Complaints = new HashSet<Complaint>();

        this.Dealers = new HashSet<Dealer>();

        this.Jobs = new HashSet<Job>();

        this.QrSODetails = new HashSet<QrSODetail>();

        this.Retailers = new HashSet<Retailer>();

        this.SMSLogs = new HashSet<SMSLog>();

        this.Tbl_Access = new HashSet<Tbl_Access>();

        this.Tbl_MasterStock = new HashSet<Tbl_MasterStock>();

        this.Tbl_SchoolException = new HashSet<Tbl_SchoolException>();

        this.TblReminders = new HashSet<TblReminder>();

        this.Areas = new HashSet<Area>();

        this.OneSignalUsers = new HashSet<OneSignalUser>();

        this.TBL_RouteSelection = new HashSet<TBL_RouteSelection>();

    }


    public int TID { get; set; }

    public int ID { get; set; }

    public string Name { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<int> RegionalHeadID { get; set; }

    public string Phone1 { get; set; }

    public string Phone2 { get; set; }

    public Nullable<int> CityID { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public System.DateTime LastUpdate { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Nullable<int> RegionID { get; set; }

    public Nullable<int> RoleID { get; set; }

    public string IMEI { get; set; }

    public Nullable<int> AppUserWasaOrKSB { get; set; }

    public string Type { get; set; }

    public Nullable<bool> FieldOfficer { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AccessLog> AccessLogs { get; set; }

    public virtual City City { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CompititorInfo> CompititorInfoes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Complaint> Complaints { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Dealer> Dealers { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Job> Jobs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<QrSODetail> QrSODetails { get; set; }

    public virtual RegionalHead RegionalHead { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Retailer> Retailers { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SMSLog> SMSLogs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tbl_Access> Tbl_Access { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tbl_MasterStock> Tbl_MasterStock { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tbl_SchoolException> Tbl_SchoolException { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TblReminder> TblReminders { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Area> Areas { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<OneSignalUser> OneSignalUsers { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TBL_RouteSelection> TBL_RouteSelection { get; set; }

}

}