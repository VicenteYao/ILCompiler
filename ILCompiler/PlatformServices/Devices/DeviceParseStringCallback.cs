using PlatformServices.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices.Devices
{
    public unsafe delegate void* DeviceParseStringCallback(PlatformString* pText);
}
