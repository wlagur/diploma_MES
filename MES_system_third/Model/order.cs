//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES_system_third.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public order()
        {
            this.photo = new HashSet<photo>();
            this.process = new HashSet<process>();
        }
    
        public int idOrder { get; set; }
        public Nullable<System.DateTime> dateTime { get; set; }
        public Nullable<bool> status { get; set; }
        public int Worker_idWorker { get; set; }
        public int Car_idCar { get; set; }

        public string Name { get; set; }
    
        public virtual car car { get; set; }
        public virtual worker worker { get; set; }
        public virtual ICollection<photo> photo { get; set; }
        public virtual ICollection<process> process { get; set; }
    }
}
