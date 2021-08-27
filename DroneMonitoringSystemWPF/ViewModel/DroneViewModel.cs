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
    class DroneViewModel
    {
        private ObservableCollection<DroneModel> clickedDroneStatus;
        public ObservableCollection<DroneModel> ClickedDroneStatus
        {
            get
            {
                return clickedDroneStatus;
            }
            set
            {
                clickedDroneStatus = value;
            }
        }

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
            }
        }
        public DelegateCommand DroneMarkerClickCommand { get; set; }
        public DelegateCommand ConstructDroneImageCommand { get; set; }
        public BitmapImage DroneImage { get; set; }

        public DroneViewModel()
        {
            DroneStatus = new ObservableCollection<DroneModel>();
            ClickedDroneStatus = new ObservableCollection<DroneModel>();

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

            droneModel = new DroneModel(1, 110, 100);
            DroneStatus.Add(droneModel);

            droneModel = new DroneModel(2, 200, 100);
            DroneStatus.Add(droneModel);
        }


        private void DroneMarkerClick(object parameter)
        {            
            //var drone = (parameter as ObservableCollection<DroneModel>).Where(z => z.SysID == 0).FirstOrDefault();
            var drone = parameter as DroneModel;
            if(drone.IsClicked == false)
            {
                if (ClickedDroneStatus.Count == 3) // 최대개수 3개
                {
                    return;
                }
                drone.IsClicked = true;
                ClickedDroneStatus.Add(drone);
            }
            else
            {
                drone.IsClicked = false;
                ClickedDroneStatus.Remove(drone);
            }
        }
        #endregion


        
    }
}
