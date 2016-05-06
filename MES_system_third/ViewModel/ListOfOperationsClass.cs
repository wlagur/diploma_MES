using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfOperationsClass
    {
        public static List<operation> ListOfOperations { get; set; }
        public static List<operation> create()
        {
            ListOfWorkerHasSkillsClass.create();
            using (var db = new workshopEntities_second())
            {
                ListOfOperations = db.operation.ToList();
                foreach (operation o in ListOfOperations)
                    o.ListWorkers = ListOfWorkerHasSkillsClass.ListOfWorkerHasSkills.Where(e => e.Operation_idOperation == o.idOperation).ToList();
                return ListOfOperations;
            }
        }
    }
}
