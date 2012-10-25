namespace FedExHeatMap.Geocoding
{
    public class IpToLatLongConverter
    {
        static LookupService service = new LookupService(@"D:\Craig\AcomFedex\FedExHeatMap\GeoLiteCity.dat", LookupService.GEOIP_STANDARD);

        public static MapData ConvertToLatLong(string ip)
        {
            var loc = service.getLocation(ip);
            return new MapData {Latitude = loc.latitude, Longitude = loc.longitude, Weight = 1};
        }
    }
}