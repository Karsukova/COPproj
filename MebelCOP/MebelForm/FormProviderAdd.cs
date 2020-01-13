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
using MebelDAL.VM;
using MebelDAL.BM;
using MebelForm;
using ClassLibraryPlugin;
using System.IO;

namespace ClassLibraryPluginFrequency
{
    public partial class FormProviderAdd : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        public int providerId { get; set; }
        private PluginManager pluginManager;

        private List<IPlugin> plugins;
        private readonly IProvider service;
        private int? id;
        public FormProviderAdd(IProvider service)
        {
            InitializeComponent();
            this.service = service;
            userControlList1.LoadEnumeration(typeof(MebelTypes));
            chastotaDiapComponent1.LoadEnumerationName(1, 50);
            pluginManager = new PluginManager(System.IO.Path.Combine(
             Directory.GetCurrentDirectory(),
             "Plugins"));
            FormProvider_Load();
        }


        private void FormProvider_Load()
        {

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
            
            userControlList1.LoadEnumeration(typeof(MebelTypes));

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                var provider = service.GetElement(id.Value);
                
                    service.UpdElement(new ProviderBM
                    {
                        Id = id.Value,
                        Name = textBoxFIO.Text,
                        Frequency = chastotaDiapComponent1.number,
                        Type = userControlList1.SelectedText
                    });
               
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
