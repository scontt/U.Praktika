using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            LoadMarkers();
        }
        private void InitializeMap()
        {
            // Установка провайдера карт (Google Maps)
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;

            // Установка центра карты в г. Красноярск
            gMapControl1.Position = new PointLatLng(56.0153, 92.8932);
            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 11; // какой используется зум при открытииg
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
            gMapControl1.CanDragMap = true;
            gMapControl1.MouseWheelZoomEnabled = true;
        }
        private void AddMapMarkers()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            // Создание маркера 1
            GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(58.379325, 97.440690), GMarkerGoogleType.red);
            marker1.ToolTipText = "Филиал №1:улица Перенсона-3"; // Текст всплывающей подсказки
            markersOverlay.Markers.Add(marker1);

            // Создание маркера 2
            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(56.011369, 92.867798), GMarkerGoogleType.blue);
            marker2.ToolTipText = "Филиал №2: улица Мира-67"; // Текст всплывающей подсказки
            markersOverlay.Markers.Add(marker2);

            // Создание маркера 2
            GMapMarker marker3 = new GMarkerGoogle(new PointLatLng(56.011675, 92.971054), GMarkerGoogleType.orange);
            marker3.ToolTipText = "Филиал №3:  улица проспект имени Газеты Красноярский Рабочий-35"; // Текст всплывающей подсказки
            markersOverlay.Markers.Add(marker3);

            // Добавление коллекции маркеров на карту
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void LoadMarkers()
        {
            InitializeMap();

            GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(58.376525, 97.440690), GMarkerGoogleType.green);
            marker1.ToolTipText = "Филиал №1: улица Перенсона-3"; // Текст всплывающей подсказки
            //добавление маркера на карту
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker1);
            gMapControl1.Overlays.Add(markers);

            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(56.011469, 92.867798), GMarkerGoogleType.green);
            marker2.ToolTipText = "Филиал №2: улица Мира-67";
            markers.Markers.Add(marker2);
            gMapControl1.Overlays.Add(markers);

            GMapMarker marker3 = new GMarkerGoogle(new PointLatLng(56.011671, 92.971033), GMarkerGoogleType.green);
            marker3.ToolTipText = "Филиал №3: улица проспект имени Газеты Красноярский Рабочий-35";
            markers.Markers.Add(marker3);
            gMapControl1.Overlays.Add(markers);

            GMapMarker marker4 = new GMarkerGoogle(new PointLatLng(56.011072, 92.878686), GMarkerGoogleType.green);
            marker4.ToolTipText = "Филиал №4: Карла Маркса-44";
            markers.Markers.Add(marker4);
            gMapControl1.Overlays.Add(markers);
        }
    }
}
