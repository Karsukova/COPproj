using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebelDAL.Interface;

namespace ClassLibraryPlugin
{
    public interface IPlugin
    {
        string Name { get; }

        void Run(int id);
        bool Exec(IProvider pServic);
    }
}
