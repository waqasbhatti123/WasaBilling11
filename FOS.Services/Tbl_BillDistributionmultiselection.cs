
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
    
public partial class Tbl_BillDistributionmultiselection
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tbl_BillDistributionmultiselection()
    {

        this.BillDisMultiSelects = new HashSet<BillDisMultiSelect>();

        this.BillDispatchMultiSelectListOfConsumers = new HashSet<BillDispatchMultiSelectListOfConsumer>();

    }


    public int ID { get; set; }

    public string Name { get; set; }

    public Nullable<bool> IsActive { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BillDisMultiSelect> BillDisMultiSelects { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BillDispatchMultiSelectListOfConsumer> BillDispatchMultiSelectListOfConsumers { get; set; }

}

}
