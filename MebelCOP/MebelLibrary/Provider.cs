using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public abstract class Provider
    {
        public Provider(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetRating();
    }
}
