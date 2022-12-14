
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
    
public partial class Tbl_ComplaintHistory
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tbl_ComplaintHistory()
    {

        this.ComplaintNotifications = new HashSet<ComplaintNotification>();

        this.NotificationSeens = new HashSet<NotificationSeen>();

    }


    public int ID { get; set; }

    public Nullable<int> JobID { get; set; }

    public Nullable<int> JobDetailID { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<bool> IsActive { get; set; }

    public Nullable<int> SiteID { get; set; }

    public string TicketNo { get; set; }

    public Nullable<int> FaultTypeId { get; set; }

    public Nullable<int> PriorityId { get; set; }

    public Nullable<int> ComplaintStatusId { get; set; }

    public Nullable<int> LaunchedById { get; set; }

    public string PersonName { get; set; }

    public Nullable<int> FaultTypeDetailID { get; set; }

    public Nullable<int> ComplainttypeID { get; set; }

    public string Picture1 { get; set; }

    public string Picture2 { get; set; }

    public string Picture3 { get; set; }

    public Nullable<int> ProgressStatusID { get; set; }

    public string FaultTypeDetailRemarks { get; set; }

    public string ProgressStatusRemarks { get; set; }

    public Nullable<int> AssignedToSaleOfficer { get; set; }

    public Nullable<int> IsPublished { get; set; }

    public string UpdateRemarks { get; set; }

    public string InitialRemarks { get; set; }

    public Nullable<int> FirstAssignedSO { get; set; }

    public string Video { get; set; }

    public string Audio { get; set; }

    public Nullable<System.DateTime> VideoDate { get; set; }

    public Nullable<System.DateTime> AudioDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ComplaintNotification> ComplaintNotifications { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<NotificationSeen> NotificationSeens { get; set; }

}

}
