using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices.Devices
{
    [AddressSpace(AddressSpaceFlags.Physical)]
    public struct Device
    {
        public DispatcherHeader Header;
        public DeviceParseStringCallback Parse;
    }
}
