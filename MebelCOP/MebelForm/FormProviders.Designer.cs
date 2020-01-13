namespace MebelForm
{
    partial class FormProviders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.requestPDFComponent1 = new Lab1ComponentDasha.RequestPDFComponent(this.components);
            this.wordReport1 = new Konponens.WordReport(this.components);
            this.histogram1 = new Konponens.Histogram(this.components);
            this.wordReport2 = new Konponens.WordReport(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.storeData1 = new Komponents.StoreData(this.components);
            this.fioManager1 = new Komponents.FIOManager();
            this.storeData2 = new Komponents.StoreData(this.components);
            this.listBoxView = new ControlLibrary.ListBoxView();
            this.serializationComponent1 = new ControlLibrary.SerializationComponent(this.components);
            this.myExcelReport1 = new ControlLibrary.MyExcelReport(this.components);
            this.serializationComponent2 = new ControlLibrary.SerializationComponent(this.components);
            this.plugin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(457, 576);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(517, 31);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 39);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(517, 103);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(176, 39);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(519, 174);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 42);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(732, 31);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(171, 41);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Формировать диаграмму PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Формировать отчет PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fioManager1
            // 
            this.fioManager1.Location = new System.Drawing.Point(1068, 190);
            this.fioManager1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fioManager1.Name = "fioManager1";
            this.fioManager1.SelectedIndexFIO = -1;
            this.fioManager1.Size = new System.Drawing.Size(8, 8);
            this.fioManager1.TabIndex = 8;
            // 
            // listBoxView
            // 
            this.listBoxView.Location = new System.Drawing.Point(515, 245);
            this.listBoxView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxView.Name = "listBoxView";
            this.listBoxView.Pattern = null;
            this.listBoxView.Size = new System.Drawing.Size(739, 445);
            this.listBoxView.TabIndex = 10;
            // 
            // myExcelReport1
            // 
            this.myExcelReport1.FieldType = null;
            // 
            // plugin
            // 
            this.plugin.Location = new System.Drawing.Point(973, 31);
            this.plugin.Name = "plugin";
            this.plugin.Size = new System.Drawing.Size(122, 39);
            this.plugin.TabIndex = 11;
            this.plugin.Text = "plugin";
            this.plugin.UseVisualStyleBackColor = true;
            this.plugin.Click += new System.EventHandler(this.plugin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(973, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 12;
            // 
            // FormProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 816);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plugin);
            this.Controls.Add(this.listBoxView);
            this.Controls.Add(this.fioManager1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormProviders";
            this.Text = "Администраторы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button1;
        private Lab1ComponentDasha.RequestPDFComponent requestPDFComponent1;
        private Konponens.WordReport wordReport1;
        private Konponens.Histogram histogram1;
        private Konponens.WordReport wordReport2;
        private System.Windows.Forms.Button button2;
        private ControlLibrary.SerializationComponent serializationComponent1;
        private ControlLibrary.MyExcelReport myExcelReport1;
        private Komponents.StoreData storeData1;
        private Komponents.FIOManager fioManager1;
        private Komponents.StoreData storeData2;
        private ControlLibrary.ListBoxView listBoxView;
        private ControlLibrary.SerializationComponent serializationComponent2;
        private System.Windows.Forms.Button plugin;
        private System.Windows.Forms.TextBox textBox1;
    }
}