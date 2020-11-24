using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompilerServices
{
    public unsafe static class Memory
    {
        public static T* Alloc<T>([Constant] uint size) where T : unmanaged
        {
            return null;
        }

        public static void Free<T>(T* ptr) where T : unmanaged
        {

        }

        public static T* Reset<T>(T* ptr, [Constant] byte value, ulong count) where T : unmanaged
        {
            return ptr;
        }

        public static T*  Copy<T>(T* dest, T* src, ulong num) where T : unmanaged
        {
            return dest;
        }

        public static T* Move<T>(T* dest, T* src, ulong num) where T : unmanaged
        {
            return dest;
        }

        public static int Compare<T>(T* ptr1, T* ptr2, ulong num) where T : unmanaged
        {
            return 0;
        }

    }
}
