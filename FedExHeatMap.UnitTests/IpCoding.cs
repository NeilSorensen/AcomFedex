using FedExHeatMap.Geocoding;
using NUnit.Framework;

namespace FedExHeatMap.UnitTests
{
    [TestFixture]
    public class IpCoding
    {
        [Test]
        public void BasicIp()
        {
            var location = IpToLatLongConverter.ConvertToLatLong("66.43.16.227");
            Assert.NotNull(location);
        }
    }
}