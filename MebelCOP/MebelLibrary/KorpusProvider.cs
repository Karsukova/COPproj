using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public class KorpusProvider : Provider
    {
        public KorpusProvider() : base("Поставщик корпусной мебели")
        { }
        public override int GetRating()
        {
            return 10;
        }
    }
}
