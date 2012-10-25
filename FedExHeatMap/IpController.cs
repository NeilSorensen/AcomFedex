using System;
using FedExHeatMap.Geocoding;

namespace FedExHeatMap
{
    public class IpController
    {
        public MapData Get_Ip()
        {
            try
            {
                return IpToLatLongConverter.ConvertToLatLong("4.18.201.0");
            }catch(Exception)
            {
                return null;
            }
        }
    }
}