//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppServiceCenter.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Cluent = new HashSet<Cluent>();
            this.MasterOrdersMaster = new HashSet<MasterOrdersMaster>();
        }
    
        public int id { get; set; }
        public string NameTechnic { get; set; }
        public string Malfunctions { get; set; }
        public string DateOrders { get; set; }
        public Nullable<int> idMaster { get; set; }
        public Nullable<int> idMasterOrders { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cluent> Cluent { get; set; }
        public virtual Master Master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterOrdersMaster> MasterOrdersMaster { get; set; }
        public virtual MasterOrdersMaster MasterOrdersMaster1 { get; set; }
        public virtual MasterOrdersMaster MasterOrdersMaster2 { get; set; }
        public virtual MasterOrdersMaster MasterOrdersMaster3 { get; set; }
    }
}
