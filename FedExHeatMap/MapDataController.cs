using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FedExHeatMap
{
    public class MapDataController
    {

        public List<MapData> Get_MapData()
        {
            return new List<MapData>
                       {
                           new MapData {Latitude = 37.42426708029149, Longitude = -122.0840722197085, Weight = 10},
                           new MapData {Latitude = 40.1748, Longitude = -111.4140, Weight = 10},
                           new MapData {Latitude = 20.1748, Longitude = -121.4140, Weight = 50},
                           new MapData {Latitude = -10.1748, Longitude = 11.4140, Weight = 100},
                       };
        }
    }

    public class MapData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Weight { get; set; }
    }
}