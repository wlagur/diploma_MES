using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfColorsClass
    {
        public static List<colorofcar> ListOfColors { get; set; }
        public static List<colorofcar> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfColors = db.colorofcar.ToList();
                return ListOfColors;
            }
        }
    }
}
