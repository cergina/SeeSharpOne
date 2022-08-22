using System;

namespace SeeSharpOne.Helpers
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
