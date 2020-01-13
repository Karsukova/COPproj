using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    class EarlyProvider : ProviderDecorator
    {
        public EarlyProvider(Provider p) 
        : base(p.Name + ", опережает сроки", p)
    { }

        public override int GetRating()
        {
            return provider.GetRating() + 5;
        }
    }
}
