using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public class SoftProvider : Provider
    {
        public SoftProvider() : base("Поставщик мягкой мебели")
        { }
        public override int GetRating()
        {
            return 10;
        }
    }
}
