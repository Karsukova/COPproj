using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public class BadProvider : ProviderDecorator
    {
        public BadProvider(Provider p) 
        : base(p.Name + ", допускает брак", p)
    { }

        public override int GetRating()
        {
            return provider.GetRating() - 5;
        }
    }
}
