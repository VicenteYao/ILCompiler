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

        public static ErrorCode Create(PlatformString* fileName, File** ppFile)
        {
            ppFile = null;
            return default(ErrorCode);
        }

        public static ErrorCode Open(PlatformString* fileName, FileMode fileMode, File** ppFile)
        {
            ppFile = null;
            return default(ErrorCode);
        }

        public static ErrorCode Close(File* pFile)
        {
            return default(ErrorCode);
        }

        public static ErrorCode Delete(File* pFile)
        {
            return default(ErrorCode);
        }

        public static ErrorCode Write(File* pFile, byte* value)
        {
            return default(ErrorCode);
        }
    }
}
