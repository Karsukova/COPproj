using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    class LateProvider : ProviderDecorator
    {
        public LateProvider(Provider p) 
        : base(p.Name + ", нарушает сроки", p)
    { }

        public override int GetRating()
        {
            return provider.GetRating() - 7;
        }
    }
}
