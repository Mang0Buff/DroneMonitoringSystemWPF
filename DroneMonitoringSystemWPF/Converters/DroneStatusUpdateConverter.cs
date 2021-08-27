using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using DroneMonitoringSystemWPF.Model;

namespace DroneMonitoringSystemWPF.Converters
{
    class DroneStatusUpdateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var droneStatue = value as DroneModel;
            if (droneStatue == null)
            {
                return null;
            }
            
            if (droneStatue.IsClicked == true)
            {
                droneStatue.IsClicked = false;
                return droneStatue.Latitude;
            }


            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
