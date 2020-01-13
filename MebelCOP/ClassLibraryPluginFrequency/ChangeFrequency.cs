using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPlugin;
using Unity;
using MebelDAL.Interface;
using DB.Impl;
using Unity.Lifetime;

namespace ClassLibraryPluginFrequency
{
    public class ChangeProducts : IPlugin
    {
        public string Name => "Изменение частоты поставки";

        public void Run(int id)
        {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormProviderAdd>();
            form.providerId = id;
            form.Show();
        }
        public bool Exec(IProvider pService, ICategory cService)
        {
            return false;
        }
        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IProvider, ProviderDB>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
