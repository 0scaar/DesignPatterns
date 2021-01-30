using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class AuthorForShallowCopy : ICloneable
    {
        public string Name { get; set; }
        public string TwitterAccount { get; set; }
        public string WebSite { get; set; }
        public Address HomeAddress { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
