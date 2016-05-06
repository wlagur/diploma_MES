using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MES_system_third.ViewModel
{
    static class ListOfOrdersClass
    {
        public static List<order> ListOfOrders { get; set; }
        public static List<order> create()
        {
            using (var db = new workshopEntities_second())
            {
                ListOfOrders = db.order.ToList();
                foreach (order o in ListOfOrders)
                {
                    o.Name = o.dateTime.Value.ToLongDateString() + " " + o.car.modelofcar.markofcar.nameMarkOfCar + " " + o.car.modelofcar.nameModelOfCar;
                    o.car = ListOfCarsClass.ListOfCars.Where(w => w.idCar == o.Car_idCar).First();
                    o.car.ListDetail = ListOfDetailsClass.createListOfDetailsCar(o);
                    o.worker = ListOfWorkersClass.ListOfEmployees.Where(w => w.idWorker == o.Worker_idWorker).First();
                }
                return ListOfOrders;
            }
        }
    }
}
