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
    
    public partial class markofcar
    {
        public markofcar()
        {
            this.modelofcar = new HashSet<modelofcar>();
        }
    
        public int idMarkOfCar { get; set; }
        public string nameMarkOfCar { get; set; }
    
        public virtual ICollection<modelofcar> modelofcar { get; set; }
    }
}
