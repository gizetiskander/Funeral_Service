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
    
    public partial class PaymentType
    {
        public int ID_PaymentType { get; set; }
        public string Name_PaymentType { get; set; }
        public Nullable<int> ID_Role { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
