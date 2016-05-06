using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfModelsClass
    {
        public static List<modelofcar> ListOfModels { get; set; }
        public static List<modelofcar> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfModels = db.modelofcar.ToList();
                foreach (modelofcar m in ListOfModels)
                {
                    m.markofcar = ListOfMarksClass.ListOfMarks.Where(w => w.idMarkOfCar == m.MarkOfCar_idMarkOfCar).First();
                }
                return ListOfModels;
            }
        }
    }
}
