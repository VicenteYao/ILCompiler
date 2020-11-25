using System;

namespace CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class AddressSpaceAttribute : Attribute
    {
        public AddressSpaceAttribute(AddressSpaceFlags addressSpaceFlags)
        {
            this.Flags = addressSpaceFlags;
        }

        public AddressSpaceFlags Flags { get; private set; }
    }
}
