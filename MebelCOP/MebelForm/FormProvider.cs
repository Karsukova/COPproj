using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MebelDAL.Interface;
using MebelDAL.BM;
using MebelDAL.VM;
using Unity;
using ClassLibraryPlugin;
using System.IO;

namespace MebelForm
{
    public partial class FormProvider : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private PluginManager pluginManager;

        private List<IPlugin> plugins;
        private readonly IProvider service;
        private int? id;
        public FormProvider(IProvider service)
        {
            InitializeComponent();
            this.service = service;
            userControlList1.LoadEnumeration(typeof(MebelTypes));
            chastotaDiapComponent1.LoadEnumerationName(1, 50);
            pluginManager = new PluginManager(System.IO.Path.Combine(
              Directory.GetCurrentDirectory(),
              "Plugins"));
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {

            if (id.HasValue)
            {
                plugins = pluginManager.GetPlugins();

                foreach (var plugin in plugins)
                {
                    var menuItem = new ToolStripMenuItem(plugin.Name);
                    menuItem.Click += (a, b) =>
                    {
                        plugin.Run(id.Value);
                    };
                }
                try
                {
                    ProviderVM view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxFIO.Text = view.Name;
                        chastotaDiapComponent1.number = view.Frequency;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            userControlList1.LoadEnumeration(typeof(MebelTypes));
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new ProviderBM
                    {
                        Id = id.Value,
                        Name = textBoxFIO.Text,
                        Frequency = chastotaDiapComponent1.number,
                        Type = userControlList1.SelectedText
                    });
                }
                else
                {
                    service.AddElement(new ProviderBM
                    {
                        Name = textBoxFIO.Text,
                        Frequency = chastotaDiapComponent1.number,
                        Type = userControlList1.SelectedText
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
           
        }

        
    }
}
