using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebelDAL.BM;
using MebelDAL.VM;

namespace MebelDAL.Interface
{
    public interface IProvider
    {
        List<ProviderVM> GetList();
        ProviderVM GetElement(int id);
        void AddElement(ProviderBM model);
        void UpdElement(ProviderBM model);
        void DelElement(int id);
    }
}
