using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices.Text
{
    [AddressSpace(AddressSpaceFlags.Physical)]
    public unsafe struct PlatformString
    {
        public uint Length;
        public byte* Text;

        public static PlatformString* Alloc([Constant] string text)
        {
            return null;
        }

        public static PlatformString* Alloc(byte* text)
        {
            return null;
        }

        public static ErrorCode Free(PlatformString* pString)
        {
            return default(ErrorCode);
        }

    }
}
