using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using MebelDAL.Interface;
using ClassLibraryPluginFrequency;

namespace MebelForm
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public readonly IProvider service;
        public FormMain(IProvider service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProviders>();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMebelProvider>();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProviderAdd>();
            form.ShowDialog();
        }
    }
}
