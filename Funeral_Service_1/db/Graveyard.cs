//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Funeral_Service_1.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Graveyard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Graveyard()
        {
            this.Basket = new HashSet<Basket>();
        }
    
        public int ID_Graveyard { get; set; }
        public string Graveyard_Name { get; set; }
        public string Graveyard_Location { get; set; }
        public Nullable<int> ID_Service { get; set; }
        public Nullable<int> ID_Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }
        public virtual Service Service { get; set; }
        public virtual Role Role { get; set; }
    }
}
