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
    
    public partial class Payment
    {
        public int ID_Payment { get; set; }
        public Nullable<System.DateTime> Date_Payment { get; set; }
        public string Card { get; set; }
        public string Name_Payment { get; set; }
        public string PaymentType_Name { get; set; }
        public Nullable<int> ID_User { get; set; }
        public Nullable<bool> Paid { get; set; }
    
        public virtual C_User C_User { get; set; }
    }
}
