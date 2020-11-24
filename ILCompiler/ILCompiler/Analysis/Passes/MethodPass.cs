using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;

namespace ILCompiler.Analysis.Passes
{
    public abstract class MethodPass : Pass
    {
        protected abstract MethodDefinition RunOnMethod(MethodDefinition methodDefinition);
    }
}
