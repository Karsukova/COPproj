using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelLibrary
{
    public class AllTypeProvider : Provider
    {
        public AllTypeProvider() : base("Поставщик всех типов мебели")
        { }
        public override int GetRating()
        {
            return 20;
        }
    }
}
