using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelDAL.VM
{
   public class OrderVM
    {
        public int Id { get; set; }
        public string NameProvider { get; set; }
        public string Type { get; set; }
        public string DateCreate { get; set; }
    }
}
