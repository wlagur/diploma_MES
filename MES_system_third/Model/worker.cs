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
    
    public partial class worker
    {
        public worker()
        {
            this.order = new HashSet<order>();
            this.process = new HashSet<process>();
            this.workerhasskill = new HashSet<workerhasskill>();
        }
    
        public int idWorker { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }

        public string FullName 
        {
            get { return lastName + " " + firstName + " " + middleName; }
        }
    
        public virtual ICollection<order> order { get; set; }
        public virtual ICollection<process> process { get; set; }
        public virtual ICollection<workerhasskill> workerhasskill { get; set; }
    }
}
