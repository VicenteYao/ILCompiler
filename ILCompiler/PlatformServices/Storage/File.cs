using PlatformServices.IO;
using PlatformServices.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices.Storage
{
    [AddressSpace(AddressSpaceFlags.Physical)]
    public unsafe struct File
    {
        public DispatcherHeader Header;

        public static PlatformCode Create(PlatformString* fileName, File** ppFile)
        {
            ppFile = null;
            return default(PlatformCode);
        }

        public static PlatformCode Open(PlatformString* fileName, FileMode fileMode, File** ppFile)
        {
            ppFile = null;
            return default(PlatformCode);
        }

        public static PlatformCode Close(File* pFile)
        {
            return default(PlatformCode);
        }

        public static PlatformCode Delete(File* pFile)
        {
            return default(PlatformCode);
        }

        public static PlatformCode Write(File* pFile, byte* value)
        {
            return default(PlatformCode);
        }
    }
}
