using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfWorkersClass
    {
        public static List<worker> ListOfEmployees { get; set; }
        public static List<worker> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfEmployees = db.worker.ToList();
                return ListOfEmployees;
            }
        }
        public static List<process> createListOfLoading(worker w, List<process> ListOfAllProcesses)
        {
            return ListOfAllProcesses.Where(t => t.worker == w).OrderBy(t => t.dateTimeStart).ToList();
        }
    }
}
