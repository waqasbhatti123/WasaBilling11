
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
    
public partial class SubCtegoryA
{

    public int SubCategIDA { get; set; }

    public Nullable<int> MainCategID { get; set; }

    public Nullable<int> SubCategID { get; set; }

    public string SubCategADesc { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public Nullable<System.DateTime> CreatedOn { get; set; }

    public Nullable<int> CreatedBy { get; set; }

    public Nullable<System.DateTime> UpdatedOn { get; set; }

    public Nullable<int> UpdatedBy { get; set; }



    public virtual MainCategory MainCategory { get; set; }

    public virtual SubCategory SubCategory { get; set; }

}

}
