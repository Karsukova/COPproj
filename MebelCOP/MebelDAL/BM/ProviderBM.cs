using AbstractMebel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelDAL.BM
{
    public class ProviderBM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Frequency { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
