using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
   public class GoodProvider:ProviderDecorator
    {
        public GoodProvider(Provider p) 
        : base(p.Name + ", поставляет качественную продукцию", p)
    { }

        public override int GetRating()
        {
            return provider.GetRating() + 10;
        }
       
    }
}
