using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfWorkerHasSkillsClass
    {
        public static List<workerhasskill> ListOfWorkerHasSkills { get; set; }
        public static List<workerhasskill> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfWorkerHasSkills = db.workerhasskill.ToList();
                foreach (workerhasskill skill in ListOfWorkerHasSkills)
                {
                    //skill.operation = ListOfOperationsClass.ListOfOperations.Where(d => d.idOperation == skill.Operation_idOperation).First();
                    skill.worker = ListOfWorkersClass.ListOfEmployees.Where(d => d.idWorker == skill.Worker_idWorker).First();
                }
                return ListOfWorkerHasSkills;
            }
        }
    }
}
