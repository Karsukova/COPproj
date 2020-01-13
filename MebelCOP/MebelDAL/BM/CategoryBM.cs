using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MebelDAL.BM
{
    [DataContract]
    public class CategoryBM
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        public CategoryBM() { }

        public CategoryBM(string name)
        {
            this.Name = name;
        }
    }
}
