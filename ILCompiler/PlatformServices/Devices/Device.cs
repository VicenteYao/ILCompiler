using PlatformServices.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices.Devices
{
    [AddressSpace(AddressSpaceFlags.Physical)]
    public unsafe struct Device
    {
        public DispatcherHeader Header;
        public PlatformString* DeviceName;

        public delegate* unmanaged[Stdcall]<void*, void*> Parse;
        public delegate* unmanaged[Stdcall]<void*, void*> Open;
        public delegate* unmanaged[Stdcall]<void*, PlatformCode> Close;
        public delegate* unmanaged[Stdcall]<void*, PlatformCode> Delete;
    }
}
