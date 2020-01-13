using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebelDAL.Interface;
using MebelDAL.BM;
using MebelDAL.VM;
using AbstractMebel;

namespace DB.Impl
{
    public class ProviderDB : IProvider
    {
        private AbstractDbContext context;
        public ProviderDB(AbstractDbContext context)
        {
            this.context = context;
        }
        public List<ProviderVM> GetList()
        {
            List<ProviderVM> result = context.Providers.Select(rec => new
           ProviderVM
            {
                Id = rec.Id,
                Name = rec.Name,
                Type = rec.Type,
                Frequency = rec.Frequency
            })
            .ToList();
            return result;
        }
        public ProviderVM GetElement(int id)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ProviderVM
                {
                    Id = element.Id,
                    Name = element.Name,
                    Type = element.Type,
                    Frequency = element.Frequency
                };

            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(ProviderBM model)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.Name ==
           model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Providers.Add(new Provider
            {
                Name = model.Name,
                Type = model.Type,
                Frequency = model.Frequency
            });
            context.SaveChanges();
        }
        public void UpdElement(ProviderBM model)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.Name ==
           model.Name && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            element = context.Providers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Name = model.Name;
            element.Type = model.Type;
            element.Frequency = model.Frequency;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Providers.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
