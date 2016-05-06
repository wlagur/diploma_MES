using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfMarksClass
    {
        public static List<markofcar> ListOfMarks { get; set; }
        public static List<markofcar> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfMarks = db.markofcar.ToList();
                return ListOfMarks;
            }
        }
    }
}
