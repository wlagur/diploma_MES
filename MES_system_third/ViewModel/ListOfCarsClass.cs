using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfCarsClass
    {
        public static List<car> ListOfCars { get; set; }
        public static List<car> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfCars = db.car.ToList();
                foreach (car c in ListOfCars)
                {
                    c.modelofcar = ListOfModelsClass.ListOfModels.Where(w => w.idModelOfCar == c.ModelOfCar_idModelOfCar).First();
                    c.colorofcar = ListOfColorsClass.ListOfColors.Where(w => w.idColorOfCar == c.ColorOfCar_idColorOfCar).First();
                    c.client = ListOfClientsClass.ListOfClients.Where(w => w.idClient == c.Client_idClient).First();
                }
                return ListOfCars;
            }
        }
    }
}
