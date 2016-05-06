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

            ListOfDetailsClass.create();
            ListOfOrders = ListOfOrdersClass.create();
            ListOfWorkers = ListOfWorkersClass.create();
            ListOfOperations = ListOfOperationsClass.create();
            AllProcesses = ListOfProcessesClass.CreateAllProcesses();
            NewOrder = new order() 
            { 
                car = new car()
            };
            flag = true;
        }

        private order _SelectedOrder;
        private worker _SelectedWorker;
        private List<process> _ListOfProcesses;
        private List<process> _ListOfLoadingWorker;
        private List<Rectangle> _ListOfRectanglesOrder;

        public ICommand AddProcessCommand { get; set; }
        public ICommand DeleteProcessCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CommandColorButtonSave { get; set; }
        public ICommand CommandChangeWokerInProcess { get; set; }

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
        public List<order> ListOfOrders { get; set; }
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
        public order NewOrder { get; set; }
        private bool _flag;
        public bool flag
        {
            get { return _flag; }
            set
            {
                if (_flag != value)
                {
                    _flag = value;;
                    OnPropertyChanged("flag");
                }
            }
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
                //var _ListProcessesDB = from p in db.process
                //                       where p.Order_idOrder == SelectedOrder.idOrder
                //                       select p;
                //var ListProcessesDB = _ListProcessesDB.ToList();
                //foreach (process processDB in ListProcessesDB)
                //{
                //    try
                //    {
                //        var pi = ListOfProcesses.Where(p => p.IdProcess == processDB.idProcess).First();
                //        processDB.dateTimeStart = pi.DateTimeStart;
                //        processDB.dateTimeFinish = pi.DateTimeFinish;
                //        processDB.Operation_idOperation = pi.Operation.idOperation;
                //        processDB.Worker_idWorker = pi.Worker.idWorker;

                //        var c = SelectedOrder.car.idCar;
                //        try
                //        {
                //            processDB.detail = db.detail.Where(s => s.Car_idCar == c && s.standartdetail.idStandartDetail == pi.StandartDetail.idStandartDetail).First();
                //        }
                //        catch (InvalidOperationException)
                //        {
                //            var newDetail = new detail() { Car_idCar = c, StandartDetail_idStandartDetail = pi.StandartDetail.idStandartDetail };
                //            db.detail.Add(newDetail);
                //            processDB.detail = newDetail;
                //        }
                //    }
                //    catch (InvalidOperationException)
                //    {
                //        db.process.Remove(processDB);
                //    }
                //}
                //foreach (ProcessInfo proc in ListOfProcesses)
                //{
                //    if (proc.IdProcess < 0)
                //    {
                //        var p = new process();
                //        p.dateTimeStart = proc.DateTimeStart;
                //        p.dateTimeFinish = proc.DateTimeFinish;
                //        p.Operation_idOperation = proc.Operation.idOperation;
                //        p.Worker_idWorker = proc.Worker.idWorker;
                //        p.Order_idOrder = SelectedOrder.idOrder;

                //        var c = SelectedOrder.car.idCar;
                //        try
                //        {
                //            p.detail = db.detail.Where(s => s.Car_idCar == c && s.standartdetail.idStandartDetail == proc.StandartDetail.idStandartDetail).First();
                //        }
                //        catch (InvalidOperationException)
                //        {
                //            var newDetail = new detail() { Car_idCar = c, StandartDetail_idStandartDetail = proc.StandartDetail.idStandartDetail };
                //            db.detail.Add(newDetail);
                //            p.detail = newDetail;
                //        }
                //        db.process.Add(p);
                //    }
                //}
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
                                    var tmp = db.process_has_detail.Where(p => p.Detail_idDetail==phd.detail.idDetail && p.Process_idProcess==phd.process.idProcess).First();
                                }
                                catch (InvalidOperationException)
                                {
                                    db.process_has_detail.Add(new process_has_detail() { Detail_idDetail = phd.detail.idDetail, Process_idProcess = phd.process.idProcess });
                                }
                            }
                        }
                        foreach (process_has_detail phd in db.process_has_detail.Where(p => p.Process_idProcess == proc.idProcess))
                        {
                            try
                            {
                                var tmp = proc.ListProcess_has_detail.Where(p => p.detail.idDetail == phd.Detail_idDetail && p.process.idProcess == phd.Process_idProcess).First();
                                if (tmp.FlagProcess_has_detail == false)
                                    db.process_has_detail.Remove(phd);
                            }
                            catch (InvalidOperationException)
                            {
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
                                db.process_has_detail.Add(new process_has_detail() { Detail_idDetail = phd.detail.idDetail, Process_idProcess = phd.process.idProcess });
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
    }
}
