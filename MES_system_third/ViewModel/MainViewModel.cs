using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;

namespace MES_system_third.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {

        #region Implement INotyfyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public MainViewModel()
        {
            AddProcessCommand = new Command(arg => AddProcess());
            DeleteProcessCommand = new Command(arg => DeleteProcess());
            SaveCommand = new Command(arg => SaveListProcesses());
            CommandColorButtonSave = new Command(arg => ChangeColorButtonSave());
            CommandChangeWokerInProcess = new Command(arg => ChangeWokerInProcess());
            AddOrderCommand = new Command(arg => AddOrder());

            ListOfDetailsClass.create();
            ListOfMarks = ListOfMarksClass.create();
            ListOfModels = ListOfModelsClass.create();
            ListOfColors = ListOfColorsClass.create();
            ListOfClients = ListOfClientsClass.create();
            ListOfCars = ListOfCarsClass.create();
            ListOfWorkers = ListOfWorkersClass.create();
            ListOfOperations = ListOfOperationsClass.create();
            ListOfOrders = ListOfOrdersClass.create();
            AllProcesses = ListOfProcessesClass.CreateAllProcesses();
            NewOrder = new order() 
            {
                dateTime = DateTime.Now,
                status = false
            };
            flag_new_car = true;
            flag_new_client = true;
        }

        private order _SelectedOrder; 
        public order _NewOrder;
        private worker _SelectedWorker;
        private List<process> _ListOfProcesses;
        private List<process> _ListOfLoadingWorker;
        private List<Rectangle> _ListOfRectanglesOrder;

        public ICommand AddProcessCommand { get; set; }
        public ICommand DeleteProcessCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CommandColorButtonSave { get; set; }
        public ICommand CommandChangeWokerInProcess { get; set; }
        public ICommand AddOrderCommand { get; set; }

        public List<process> AllProcesses { get; set; }
        public List<Rectangle> ListOfRectanglesOrder
        {
            get { return _ListOfRectanglesOrder; }
            set
            {
                _ListOfRectanglesOrder = value;
                //ColorButtonSave = (Brush)(new BrushConverter()).ConvertFrom("#FF707070");
                OnPropertyChanged("ListOfRectanglesOrder");
            }
        }
        private List<order> _ListOfOrders;
        public List<order> ListOfOrders
        {
            get { return _ListOfOrders; }
            set
            {
                _ListOfOrders = value;
                OnPropertyChanged("ListOfOrders");
            }
        }
        public order SelectedOrder
        {
            get { return _SelectedOrder; }
            set
            {
                if (_SelectedOrder != value)
                {
                    _SelectedOrder = value;
                    ListOfProcesses = ListOfProcessesClass.CreateListProcesses(SelectedOrder);
                    ListOfRectanglesOrder = ListOfRectanglesClass.CreateListRectangle(ListOfProcesses);
                    //ListOfDetailsProcess = ListOfDetailsClass.createListOfDetailsCar(SelectedOrder);
                    //OnPropertyChanged("SelectedOrder");
                }
            }
        }
        public worker SelectedWorker
        {
            get { return _SelectedWorker; }
            set
            {
                if (_SelectedWorker != value)
                {
                    _SelectedWorker = value;
                    ListOfLoadingWorker = ListOfWorkersClass.createListOfLoading(_SelectedWorker, AllProcesses);
                    //OnPropertyChanged("SelectedOrder");
                }
            }
        }
        public List<worker> ListOfWorkers { get; set; }
        public List<process> ListOfProcesses
        {
            get { return _ListOfProcesses; }
            set
            {
                _ListOfProcesses = value;
                //ColorButtonSave = (Brush)(new BrushConverter()).ConvertFrom("#FF707070");
                OnPropertyChanged("ListOfProcesses");
            }
        }
        public process SelectedProcess { get; set; }
        public List<operation> ListOfOperations { get; set; }
        public List<markofcar> ListOfMarks { get; set; }
        public List<modelofcar> ListOfModels { get; set; }
        public List<colorofcar> ListOfColors { get; set; }
        private List<client> _ListOfClients;
        public List<client> ListOfClients
        {
            get { return _ListOfClients; }
            set
            {
                if (_ListOfClients != value)
                {
                    _ListOfClients = value; ;
                    OnPropertyChanged("ListOfClients");
                }
            }
        }
        public List<car> ListOfCars { get; set; }
        //public List<detail> ListOfDetails { get; set; }
        //public List<detail> ListOfDetailsProcess { get; set; }
        public List<process> ListOfLoadingWorker
        {
            get { return _ListOfLoadingWorker; }
            set
            {
                _ListOfLoadingWorker = value;
                OnPropertyChanged("ListOfLoadingWorker");
            }
        }
        public order NewOrder
        {
            get { return _NewOrder; }
            set
            {
                if (_NewOrder != value)
                {
                    _NewOrder = value;
                    OnPropertyChanged("NewOrder");
                }
            }
        }
        private bool _flag_new_car;
        public bool flag_new_car
        {
            get { return _flag_new_car; }
            set
            {
                if (_flag_new_car != value)
                {
                    _flag_new_car = value; ;
                    OnPropertyChanged("flag_new_car");
                    OnPropertyChanged("flag_old_car");
                }
            }
        }
        public bool flag_old_car
        {
            get { return !_flag_new_car; }
        }
        private bool _flag_new_client;
        public bool flag_new_client
        {
            get { return _flag_new_client; }
            set
            {
                if (_flag_new_client != value)
                {
                    _flag_new_client = value; ;
                    OnPropertyChanged("flag_new_client");
                    OnPropertyChanged("flag_old_client");
                }
            }
        }
        public bool flag_old_client
        {
            get { return !_flag_new_client; }
        }

        public Brush _ColorButtonSave = (Brush)(new BrushConverter()).ConvertFrom("#FF707070");
        public Brush ColorButtonSave
        {
            get { return _ColorButtonSave; }
            set
            {
                _ColorButtonSave = value;
                OnPropertyChanged("ColorButtonSave");
            }
        }

        public void AddProcess()
        {
            if (SelectedOrder != null)
            {
                if (SelectedProcess != null)
                {
                    var proc = new process()
                    {
                        idProcess = AllProcesses.Select(p => p.idProcess).ToArray().Max() + 1,
                        dateTimeStart = SelectedProcess.dateTimeStart,
                        dateTimeFinish = SelectedProcess.dateTimeStart.Value.AddHours(1),
                        order = SelectedOrder
                    };
                    proc.ListProcess_has_detail = ListOfProcess_has_detailsClass.createListOfProcess_has_detailsProcess(proc);
                    AllProcesses.Add(proc);
                }
                else
                {
                    var proc = new process()
                    {
                        idProcess = AllProcesses.Select(p => p.idProcess).ToArray().Max() + 1,
                        dateTimeStart = DateTime.Now,
                        dateTimeFinish = DateTime.Now.AddHours(1),
                        order = SelectedOrder
                    };
                    proc.ListProcess_has_detail = ListOfProcess_has_detailsClass.createListOfProcess_has_detailsProcess(proc);
                    AllProcesses.Add(proc);
                }
                ListOfProcesses = ListOfProcessesClass.CreateListProcesses(SelectedOrder);
                ListOfLoadingWorker = ListOfWorkersClass.createListOfLoading(_SelectedWorker, AllProcesses);
            }
        }

        public void DeleteProcess()
        {
            if (SelectedProcess != null)
            {
                AllProcesses.Remove(SelectedProcess);
                ListOfProcesses = ListOfProcessesClass.CreateListProcesses(SelectedOrder);
                ListOfLoadingWorker = ListOfWorkersClass.createListOfLoading(_SelectedWorker, AllProcesses);
            }
        }
        
        public void SaveListProcesses()
        {
            using (var db = new workshopEntities_second())
            {
                var AllProcessesDB = db.process.ToList();
                foreach (process proc in AllProcesses)
                {
                    try
                    {
                        var tmp_proc = AllProcessesDB.Where(p => p.idProcess == proc.idProcess).First();
                        tmp_proc.dateTimeStart = proc.dateTimeStart;
                        tmp_proc.dateTimeFinish = proc.dateTimeFinish;
                        //tmp_proc.Detail_idDetail = proc.detail.idDetail;
                        tmp_proc.Operation_idOperation = proc.operation.idOperation;
                        tmp_proc.Worker_idWorker = proc.worker.idWorker;
                        foreach (process_has_detail phd in proc.ListProcess_has_detail)
                        {
                            if (phd.FlagProcess_has_detail)
                            {
                                try
                                {
                                    var tmp = db.process_has_detail.Where(p => p.Detail_idDetail==phd.detail.idDetail && p.Process_idProcess==phd.Process_idProcess).First();
                                    }
                                catch (InvalidOperationException)
                                {
                                    db.process_has_detail.Add(new process_has_detail() { Detail_idDetail = phd.detail.idDetail, Process_idProcess = phd.Process_idProcess });
                                    
                                }
                            }
                        }
                        foreach (process_has_detail phd in db.process_has_detail.Where(p => p.Process_idProcess == proc.idProcess))
                        {
                            try
                            {
                                var tmp = proc.ListProcess_has_detail.Where(p => p.detail.idDetail == phd.Detail_idDetail && p.Process_idProcess == phd.Process_idProcess).First();
                                if (tmp.FlagProcess_has_detail == false)
                                    db.process_has_detail.Remove(phd);
                            }
                            catch (InvalidOperationException)
                            {
                                //сюда в принципе не должно входить
                                db.process_has_detail.Remove(phd);
                            }
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        db.process.Add(new process()
                        {
                            idProcess = proc.idProcess,
                            dateTimeStart = proc.dateTimeStart,
                            dateTimeFinish = proc.dateTimeFinish,
                            //Detail_idDetail = proc.detail.idDetail,
                            Operation_idOperation = proc.operation.idOperation,
                            Worker_idWorker = proc.worker.idWorker,
                            Order_idOrder = proc.order.idOrder
                        });
                        foreach (process_has_detail phd in proc.ListProcess_has_detail)
                        {
                            if (phd.FlagProcess_has_detail)
                            {
                                db.process_has_detail.Add(new process_has_detail() { Detail_idDetail = phd.detail.idDetail, Process_idProcess = phd.Process_idProcess });
                            }
                        }
                    }
                }
                foreach (process procDB in AllProcessesDB)
                {
                    try
                    {
                        var tmp_proc = AllProcesses.Where(p => p.idProcess == procDB.idProcess).First();
                    }
                    catch (InvalidOperationException)
                    {
                        foreach (process_has_detail phd in db.process_has_detail.Where(p => p.Process_idProcess == procDB.idProcess))
                            db.process_has_detail.Remove(phd);
                        db.process.Remove(procDB);
                    }
                }
                db.SaveChanges();
            }
            ColorButtonSave = (Brush)(new BrushConverter()).ConvertFrom("#FF707070");
        }

        public void ChangeColorButtonSave()
        {
            ColorButtonSave = Brushes.Red;
        }

        public void ChangeWokerInProcess()
        {
            ListOfLoadingWorker = ListOfWorkersClass.createListOfLoading(_SelectedWorker, AllProcesses);
        }

        public void AddOrder()
        {
            using (var db = new workshopEntities_second())
            {
                if (flag_new_car)
                {
                    client Clien;
                    if (flag_new_client)
                    {
                        Clien = new client() 
                        {
                            lastName = NewOrder.car.client.lastName,
                            firstName = NewOrder.car.client.firstName,
                            middleName = NewOrder.car.client.middleName,
                            phone = NewOrder.car.client.phone,
                            email = NewOrder.car.client.email,
                        };
                        //Clien.idClient = db.client.Select(w => w.idClient).ToList().Max() + 1;
                        db.client.Add(Clien);
                        ListOfClients.Add(Clien);
                        ListOfClientsClass.ListOfClients.Add(Clien);
                    }
                    else 
                    {
                        Clien = NewOrder.car.client;
                    }
                    car c = new car() 
                    { 
                        ColorOfCar_idColorOfCar = NewOrder.car.colorofcar.idColorOfCar,
                        vincod = NewOrder.car.vincod,
                        registrNumber = NewOrder.car.registrNumber,
                        ModelOfCar_idModelOfCar = NewOrder.car.modelofcar.idModelOfCar,
                        Client_idClient = Clien.idClient
                    };
                    //c.idCar = db.car.Select(w => w.idCar).ToList().Max() + 1;
                    db.car.Add(c);
                    ListOfCars.Add(c);
                    ListOfCarsClass.ListOfCars.Add(c);
                    db.order.Add(new order()
                    {
                        Car_idCar = c.idCar,
                        dateTime = NewOrder.dateTime,
                        status = NewOrder.status,
                        Worker_idWorker = NewOrder.worker.idWorker
                    });
                }
                else 
                {
                    db.order.Add(new order() 
                    {
                        Car_idCar = NewOrder.car.idCar,
                        dateTime = NewOrder.dateTime,
                        status = NewOrder.status,
                        Worker_idWorker = NewOrder.worker.idWorker
                    });
                }
                db.SaveChanges();
            }
            //может стоит добавлять сначало в список потом в базу, как с списком автомобилей
            ListOfOrders = ListOfOrdersClass.create();
            AllProcesses = ListOfProcessesClass.CreateAllProcesses();
        }
    }
}
