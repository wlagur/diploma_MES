using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfProcess_has_detailsClass
    {
        public static List<process_has_detail> ListOfProcess_has_details { get; set; }
        public static List<process_has_detail> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfProcess_has_details = db.process_has_detail.ToList();
                foreach (process_has_detail det in ListOfProcess_has_details)
                {
                    det.detail = ListOfDetailsClass.ListOfDetails.Where(d => d.idDetail == det.Detail_idDetail).First();
                    //det.process = ListOfProcessesClass.ListOfProcesses.Where(d => d.idProcess == det.Process_idProcess).First();
                    det.FlagProcess_has_detail = true;
                }
                return ListOfProcess_has_details;
            }
        }
        public static List<process_has_detail> createListOfProcess_has_detailsProcess(process pr)
        {
            if (ListOfProcess_has_details == null)
                create();
            List<process_has_detail> ListOfProcess_has_detailsProcess = ListOfProcess_has_details.Where(d => d.Process_idProcess == pr.idProcess).ToList();
            foreach (detail d in pr.order.car.ListDetail)
            {
                if (!ListOfProcess_has_detailsProcess.Select(det => det.detail).Contains(d))
                    ListOfProcess_has_detailsProcess.Add(new process_has_detail() 
                    { 
                        detail = d,
                        //process = pr,
                        Process_idProcess = pr.idProcess,
                        FlagProcess_has_detail = false
                    });
            }
            return ListOfProcess_has_detailsProcess;
        }
    }
}
