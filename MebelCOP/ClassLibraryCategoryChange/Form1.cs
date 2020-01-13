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
using MebelDAL.VM;
using MebelDAL.BM;

namespace ClassLibraryCategoryChange
{
    public partial class Form1 : Form
    {
        
            IProvider pService;
            ICategory cService;

            public Form1(IProvider pService, ICategory cService)
            {
                InitializeComponent();
                this.pService = pService;
                this.cService = cService;
            }

            private void BApply_Click(object sender, EventArgs e)
            {
                var pr = (ProviderVM)cbProvider.SelectedItem;
                var cat = (CategoryVM)cbCategory.SelectedItem;
                pService.UpdElement(new ProviderBM
                {
                    Id = pr.Id,
                    Name = pr.Name,
                    CategoryId = cat.Id,
                    Frequency = pr.Frequency,
                    Type = pr.Type
                });
                DialogResult = DialogResult.OK;
                Close();

            }

            private void Form1_Load(object sender, EventArgs e)
            {
                cbProvider.Items.AddRange(pService.GetList().ToArray());
                cbCategory.Items.AddRange(cService.GetList().ToArray());
            }

            private void bCancel_Click(object sender, EventArgs e)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
}
