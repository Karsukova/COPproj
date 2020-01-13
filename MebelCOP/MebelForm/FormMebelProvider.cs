using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MebelLibrary;

namespace MebelForm
{
    public partial class FormMebelProvider : Form
    {
        public FormMebelProvider()
        {
            InitializeComponent();
        }

        private void FormMebelProvider_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Provider alltypeprovider = new AllTypeProvider();
                Provider softprovide = new SoftProvider();
                Provider korpusprovide = new KorpusProvider();
               alltypeprovider = componentDecorator1.GetProviderDecorator(Event.BADQUALITY, alltypeprovider);
                alltypeprovider = componentDecorator1.GetProviderDecorator(Event.EARLY, alltypeprovider);
                softprovide = componentDecorator1.GetProviderDecorator(Event.EARLY, softprovide);
                korpusprovide = componentDecorator1.GetProviderDecorator(Event.GOODQUALITY, korpusprovide);
                textBox1.Text = "Инфо:" + alltypeprovider.Name + " , рейтинг" + alltypeprovider.GetRating() 
                    + Environment.NewLine;
                textBox1.Text += "Инфо: " + softprovide.Name + " , рейтинг" + softprovide.GetRating()
                     +Environment.NewLine;
                textBox1.Text += "Инфо: " + korpusprovide.Name + " , рейтинг" + korpusprovide.GetRating() 
                     +Environment.NewLine;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
