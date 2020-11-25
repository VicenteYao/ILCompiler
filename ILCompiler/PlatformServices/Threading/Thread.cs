using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices.Threading
{
    [AddressSpace(AddressSpaceFlags.Physical)]
    public unsafe struct Thread
    {
        public DispatcherHeader Header;
    }
}
