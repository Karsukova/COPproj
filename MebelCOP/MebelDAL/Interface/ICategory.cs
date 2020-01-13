using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebelDAL.VM;
using MebelDAL.BM;

namespace MebelDAL.Interface
{
    public interface ICategory
    {
        void Add(CategoryBM model);

        CategoryVM Get(int id);

        List<CategoryVM> GetList();

        void Update(CategoryBM model);

        void Delete(int id);

        void Copy(int id);
    }
}
