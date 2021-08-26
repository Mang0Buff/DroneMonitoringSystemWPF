using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneMonitoringSystemWPF.Model
{
    class DroneModel
    {
        public DroneModel(int sysid, double latitude, double longitude)
        {
            SysID = sysid;
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int SysID { get; set; }
    }
}
