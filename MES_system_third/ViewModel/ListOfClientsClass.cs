using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfClientsClass
    {
        public static List<client> ListOfClients { get; set; }
        public static List<client> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfClients = db.client.ToList();
                return ListOfClients;
            }
        }
    }
}
