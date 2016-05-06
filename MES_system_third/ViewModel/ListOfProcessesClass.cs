using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    class ListOfProcessesClass
    {
        public static List<process> ListOfProcesses { get; set; }
        public static List<process> AllProcesses { get; set; }

        public static List<process> CreateListProcesses(order sel_order)
        {
            if (AllProcesses == null)
                CreateAllProcesses();
            var proc = from p in AllProcesses
                       where p.order == sel_order
                       orderby p.dateTimeStart
                       select p;
            ListOfProcesses = proc.ToList();
            return ListOfProcesses;
        }

        public static List<process> CreateAllProcesses()
        {
            using (var db = new workshopEntities_second())
            {
                AllProcesses = db.process.ToList();
                foreach (process process in AllProcesses)
                {
                    process.worker = ListOfWorkersClass.ListOfEmployees.Where(w => w.idWorker == process.Worker_idWorker).First();
                    process.operation = ListOfOperationsClass.ListOfOperations.Where(o => o.idOperation == process.Operation_idOperation).First();
                    //process.standartDetail = ListOfStandartDetailsClass.ListOfStandartDetails.Where(d => d.idStandartDetail == process.StandartDetail.idStandartDetail).First();
                    //process.detail = ListOfDetailsClass.ListOfDetails.Where(d => d.idDetail == process.Detail_idDetail).First();
                    process.order = ListOfOrdersClass.ListOfOrders.Where(o => o.idOrder == process.Order_idOrder).First();
                    process.ListProcess_has_detail = ListOfProcess_has_detailsClass.createListOfProcess_has_detailsProcess(process);
                    //foreach (detail d in process.ListProcess_has_detail)
                    //{
                    //    d.FlagProcess_has_detail = true;
                    //}
                }
                return AllProcesses;
            }
        }
    }
}
