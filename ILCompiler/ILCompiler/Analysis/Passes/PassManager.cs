
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCompiler.Analysis.Passes
{
    public class PassManager
    {
        public PassManager()
        {

        }

        public static PassManager Default { get; private set; }


        public void Register<T>(T pass) where T : Pass, new()
        {

        }

        public void Unregister<T>(T pass) where T : Pass, new()
        {

        }
    }
}
