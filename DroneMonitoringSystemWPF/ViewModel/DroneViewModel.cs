using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using DroneMonitoringSystemWPF.Commands;
using DroneMonitoringSystemWPF.Model;

namespace DroneMonitoringSystemWPF.ViewModel
{
    class DroneViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<DroneModel> droneStatus;
        public ObservableCollection<DroneModel> DroneStatus
        {
            get
            {
                return droneStatus;
            }
            set
            {
                droneStatus = value;
                OnPropertyChanged("droneStatus");
            }
        }
        public DelegateCommand DroneMarkerClickCommand { get; set; }
        public DelegateCommand ConstructDroneImageCommand { get; set; }
        public BitmapImage DroneImage { get; set; }

        public DroneViewModel()
        {
            DroneStatus = new ObservableCollection<DroneModel>();
            DroneMarkerClickCommand = new DelegateCommand(DroneMarkerClick);
            ConstructDroneImageCommand = new DelegateCommand(ConStructDroneImage);
        }

        



        #region Commands
        private void ConStructDroneImage(object parameter)
        {
            //int d = int.Parse(parameter.ToString());
            var droneModel = new DroneModel(0,120,120);
            //DroneImage = new Bitmap("E:\\Drone Projects\\DroneMonitoringSystemWPF\\DroneMonitoringSystemWPF\\Resources\\Hoya.png");
            DroneImage = new BitmapImage(new Uri("E:\\Drone Projects\\DroneMonitoringSystemWPF\\DroneMonitoringSystemWPF\\Resources\\Hoya.png"));
            DroneStatus.Add(droneModel);
        }


        private void DroneMarkerClick(object parameter)
        {
            //var selectedDroneStatus = parameter as ObservableCollection<DroneModel>;
            var drone = (parameter as ObservableCollection<DroneModel>).Where(z => z.SysID == 0).FirstOrDefault();
            if(drone != null)
            {
                Console.WriteLine("Exist!!");
            }
            else
            {
                Console.WriteLine("NOP!!");
            }
        }
        #endregion


        #region PropertyChange
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
