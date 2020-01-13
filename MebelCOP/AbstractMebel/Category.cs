using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMebel
{
    public class Category
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public virtual IEnumerable<Provider> Providers { get; set; }

        public Category Copy(string appendix)
        {
            var clone = new Category
            {
                Name = Name + "_" + appendix
            };
            return clone;
        }
    }
}

