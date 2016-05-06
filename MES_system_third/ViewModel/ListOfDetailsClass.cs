using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfDetailsClass
    {
        public static List<standartdetail> ListOfStandartDetails { get; set; }
        public static List<detail> ListOfDetails { get; set; }
        public static List<detail> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfStandartDetails = db.standartdetail.ToList();
                ListOfDetails = db.detail.ToList();
                foreach (detail det in ListOfDetails)
                    det.standartdetail = ListOfStandartDetails.Where(d => d.idStandartDetail == det.StandartDetail_idStandartDetail).First();
                return ListOfDetails;
            }
        }
        public static List<detail> createListOfDetailsCar(order ord)
        {
            if (ListOfDetails == null)
                create();
            return ListOfDetails.Where(d => d.Car_idCar == ord.Car_idCar).ToList();
        }
    }
}
