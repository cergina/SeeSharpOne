using System;

namespace SeeSharpOne.Helpers
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class ReceiverAttribute : Attribute
    {
        public string Name { get; }

        public ReceiverAttribute(string name)
        {
            this.Name = name;
        }
    }
}
