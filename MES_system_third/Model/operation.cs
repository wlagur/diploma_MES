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
    using System.Windows.Media;
    
    public partial class operation
    {
        public operation()
        {
            this.process = new HashSet<process>();
            this.workerhasskill = new HashSet<workerhasskill>();
        }
    
        public int idOperation { get; set; }
        public string nameOperation { get; set; }
        public Nullable<System.TimeSpan> duration { get; set; }
        public string Color { get; set; }


        public Brush ColorBrush
        {
            get { return (Brush)(new BrushConverter()).ConvertFrom(Color); }
        }
    
        public virtual ICollection<process> process { get; set; }
        public virtual ICollection<workerhasskill> workerhasskill { get; set; }
    }
}