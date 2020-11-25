using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompilerServices.Platforms.X86
{
    public class X86AssemblyEmitter
    {
        public static void Emit<T>([Constant] X86OpCodes opCodes, T operand) where T : unmanaged
        {

        }

    }
}
