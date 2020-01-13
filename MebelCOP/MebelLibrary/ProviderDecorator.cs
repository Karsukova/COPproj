using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public abstract class ProviderDecorator : Provider
    {
        protected Provider provider;
        public ProviderDecorator(string n, Provider provider) : base(n)
    {
            this.provider = provider;
        }
    }
}
