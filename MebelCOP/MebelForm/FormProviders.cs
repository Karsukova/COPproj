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
using System.util;
using System.Threading.Tasks;
using iTextSharp.text;

using System.Reflection;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using ClassLibraryPluginFrequency;
using ClassLibraryPlugin;

namespace MebelForm
{
    public partial class FormProviders : Form
    {
        string[] fields = { "id", "Name", "Type", "Freguency" };
        object[] provider_list = new object[100];
        private PluginManager pluginManager;

        private List<IPlugin> plugins;
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProvider service;
       
        public FormProviders(IProvider service)
        {
            InitializeComponent();
            this.service = service;
            pluginManager = new PluginManager(System.IO.Path.Combine(
             Directory.GetCurrentDirectory(),
             "Plugins"));
           
        }
        private void FormAdmins_Load(object sender, EventArgs e)
        {
            LoadData();
            

        }

        private void LoadData()
        {
            try
            {
                List<ProviderVM> list = service.GetList();
                object[] somelist = new object[2];
                int i = 0;
                foreach(var t in list)
                {
                    somelist[i] = t;
                    i++;
                }
                serializationComponent2.SaveData(list, "C:\\Users\\Дарья\\Music\\serial.json");
                listBoxView.Items.Clear();
                
                listBoxView.Pattern = " {Id} {Name}  {Type} {Frequency}";
                listBoxView.AddRange(list);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
                
            


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProvider>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void buttonUpd_Click(object sender, EventArgs e)
        {

            
            if (dataGridView.SelectedRows.Count == 1)
            {

                var form = Container.Resolve<FormProviderAdd>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        service.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProviderVM> list = service.GetList();
            int s = list.Count;
            int[] mas = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            
            Dictionary<string, int> somelist = new Dictionary<string,int>();
            foreach (int x in list.Select(x => x.Id))
            {
                var f = service.GetElement(x);
                int freq = f.Frequency;
                mas[freq]++;
            }
            for (int i = 0; i < 7; i++)
            {
                somelist.Add(i.ToString(), mas[i]);
            }
            histogram1.createPDF("C:\\Users\\Дарья\\Music\\test.pdf", "test", somelist);
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            List<ProviderVM> list = service.GetList();
            List<object> tests = new List<object>();
            List<string> fields = new List<string>{ "Name", "Type"};
            List<string> title = new List<string>();
            title.Add("Otchet");
            title.Add("Mebel");
            title.Add("Type");
            foreach (int x in list.Select(x => x.Id))
            {
                var f = service.GetElement(x);
                tests.Add(f);
            }
            requestPDFComponent1.SavePDF("C:\\Users\\Дарья\\Music\\otchet.pdf", tests, fields, title, "Строка");
        }

        private void plugin_Click(object sender, EventArgs e)
        {
            plugins = pluginManager.GetPlugins();

            foreach (var plugin in plugins)
            {
                
                    plugin.Run(Convert.ToInt32(textBox1.Text));
               
            }

        }
    }
}

