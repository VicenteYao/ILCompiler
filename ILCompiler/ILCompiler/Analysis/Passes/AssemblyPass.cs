using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ILCompiler.Analysis.Passes
{
    public abstract class AssemblyPass : Pass
    {
        public abstract AssemblyDefinition RunOnAssembly(AssemblyDefinition assemblyDefinition);
    }
}
