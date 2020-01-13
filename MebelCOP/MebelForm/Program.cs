using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using DB;
using DB.Impl;
using Unity;
using MebelDAL.Interface;
using Unity.Lifetime;

namespace MebelForm
{
   static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, AbstractDbContext>(new
  HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProvider, ProviderDB>(new
           HierarchicalLifetimeManager());
          
            return currentContainer;
        }
    }
}
