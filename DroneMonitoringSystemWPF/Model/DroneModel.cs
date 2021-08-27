using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneMonitoringSystemWPF.Model
{
    class DroneModel : INotifyPropertyChanged
    {
        public DroneModel(int sysid, double latitude, double longitude)
        {
            SysID = sysid;
            Latitude = latitude;
            Longitude = longitude;
        }

        private bool isClicked;
        public bool IsClicked
        {
            get
            {
                return isClicked;
            }
            set
            {
                isClicked = value;
                OnPropertyChanged("isClicked");
            }
        }

        private double latitude;
        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                OnPropertyChanged("latitude");
            }
        }
        private double longitude;
        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
                OnPropertyChanged("longitude");
            }
        }
        public int SysID { get; set; }

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
