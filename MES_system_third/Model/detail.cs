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
    
    public partial class detail
    {
        public detail()
        {
            this.process_has_detail = new HashSet<process_has_detail>();
        }
    
        public int idDetail { get; set; }
        public int StandartDetail_idStandartDetail { get; set; }
        public int Car_idCar { get; set; }

        public virtual car car { get; set; }
        public virtual standartdetail standartdetail { get; set; }
        public virtual ICollection<process_has_detail> process_has_detail { get; set; }
    }
}
