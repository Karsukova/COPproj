using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MebelDAL.BM;
using MebelDAL.VM;

namespace MebelDAL.Interface
{
    public interface IOrder
    {
        List<OrderVM> GetList();
        OrderVM GetElement(int id);
        void AddElement(OrderBM model);
        void UpdElement(OrderBM model);
        void DelElement(int id);
    }
}
