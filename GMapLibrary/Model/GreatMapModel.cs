using System.Windows.Media;
using GMap.NET.WindowsPresentation;
using System.Globalization;
using System.Windows;
using System;
using System.ComponentModel;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.IO;

namespace GreatMaps.Model
{
    class GreatMapModel : INotifyPropertyChanged
    {
        private GMapControl gMapControl;
        public GMapControl GMapControl
        {
            get
            {
                return gMapControl;
            }
            set
            {
                gMapControl = value;
                OnPropertyChanged();
            }
        }
        public GreatMapModel()
        {
            GMapControl = new GMapControl();
            GMapControl.CacheLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + @"\GMapLibrary\Resources\";
            GMapControl.BoundsOfMap = RectLatLng.FromLTRB(126.397361, 37.496243, 126.485939, 37.429751);
            GMapControl.Manager.Mode = AccessMode.CacheOnly;
            GMapControl.MapProvider = GMapProviders.GoogleSatelliteMap;
            GMapControl.Position = new PointLatLng(37.4625, 126.439167); // 인천공항 좌표 37.4625, 126.439167
            GMapControl.MinZoom = 14;
            GMapControl.MaxZoom = 17;
            GMapControl.Zoom = 14;
            GMapControl.ShowCenter = false;
            GMapControl.DragButton = MouseButton.Left;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
