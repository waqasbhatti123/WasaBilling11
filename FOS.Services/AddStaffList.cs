
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
    
public partial class AddStaffList
{

    public int ID { get; set; }

    public Nullable<int> KSBVisitID { get; set; }

    public Nullable<int> SiteID { get; set; }

    public Nullable<int> StaffID { get; set; }

    public Nullable<System.DateTime> LAunchedAt { get; set; }



    public virtual Retailer Retailer { get; set; }

    public virtual StaffList StaffList { get; set; }

    public virtual TBL_KsbVisits TBL_KsbVisits { get; set; }

}

}
