using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebelDAL.Interface;
using ClassLibraryPlugin;
using System.Windows.Forms;

namespace ClassLibraryCategoryChange
{
    public class Plugin : IPlugin
    {
        public string Name => "CategoryChange";

        public void Run(int id)
        {
        }
            public bool Exec(IProvider pService)
        {
            var form = new Form1(pService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
