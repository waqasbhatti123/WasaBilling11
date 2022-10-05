
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
    
public partial class Job
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Job()
    {

        this.JobsHistories = new HashSet<JobsHistory>();

        this.SalesOfficerJobs = new HashSet<SalesOfficerJob>();

        this.TblReminders = new HashSet<TblReminder>();

        this.JobItems = new HashSet<JobItem>();

        this.JobsDetails = new HashSet<JobsDetail>();

        this.ComplaintNotifications = new HashSet<ComplaintNotification>();

        this.ChatBoxes = new HashSet<ChatBox>();

        this.NotificationSeens = new HashSet<NotificationSeen>();

    }


    public int TID { get; set; }

    public int ID { get; set; }

    public string JobTitle { get; set; }

    public Nullable<int> RegionalHeadType { get; set; }

    public Nullable<int> RegionalHeadID { get; set; }

    public string VisitType { get; set; }

    public string RetailerType { get; set; }

    public Nullable<int> SaleOfficerID { get; set; }

    public Nullable<int> CityID { get; set; }

    public string Areas { get; set; }

    public bool Status { get; set; }

    public Nullable<int> VisitPlanType { get; set; }

    public string VisitPlanDays { get; set; }

    public string JobType { get; set; }

    public Nullable<System.DateTime> DateOfAssign { get; set; }

    public Nullable<System.DateTime> DateOfCompletion { get; set; }

    public Nullable<System.DateTime> StartingDate { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<System.DateTime> LastUpdated { get; set; }

    public Nullable<bool> IsActive { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public Nullable<System.DateTime> LastProcessed { get; set; }

    public Nullable<int> RegionID { get; set; }

    public Nullable<int> ZoneID { get; set; }

    public Nullable<int> SiteID { get; set; }

    public string TicketNo { get; set; }

    public Nullable<int> FaultTypeId { get; set; }

    public Nullable<int> PriorityId { get; set; }

    public Nullable<int> ComplaintStatusId { get; set; }

    public Nullable<int> LaunchedById { get; set; }

    public string PersonName { get; set; }

    public Nullable<int> FaultTypeDetailID { get; set; }

    public Nullable<int> SubDivisionID { get; set; }

    public Nullable<int> ComplainttypeID { get; set; }

    public string InitialRemarks { get; set; }

    public Nullable<System.DateTime> ResolvedAt { get; set; }

    public Nullable<int> ResolvedHours { get; set; }



    public virtual RegionalHead RegionalHead { get; set; }

    public virtual VisitPlan VisitPlan { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<JobsHistory> JobsHistories { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SalesOfficerJob> SalesOfficerJobs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TblReminder> TblReminders { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<JobItem> JobItems { get; set; }

    public virtual ComplaintType ComplaintType { get; set; }

    public virtual Job Jobs1 { get; set; }

    public virtual Job Job1 { get; set; }

    public virtual SaleOfficer SaleOfficer { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<JobsDetail> JobsDetails { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ComplaintNotification> ComplaintNotifications { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ChatBox> ChatBoxes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<NotificationSeen> NotificationSeens { get; set; }

}

}
