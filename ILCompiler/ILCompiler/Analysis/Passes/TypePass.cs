using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCompiler.Analysis.Passes
{
    public abstract class TypePass : Pass
    {
        public abstract TypeDefinition RunOnType(TypeDefinition typeDefinition);

    }
}
