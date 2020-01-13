namespace ClassLibraryPluginFrequency
{
    partial class FormProviderAdd
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlSelect1 = new Labs.ControlSelect();
            this.userControlList1 = new ControlLibrary.UserControlList();
            this.wordDiagramMaker1 = new ControlLibrary.WordDiagramMaker(this.components);
            this.wordReport1 = new Konponens.WordReport(this.components);
            this.storeData1 = new Komponents.StoreData(this.components);
            this.wordDiagramMaker2 = new ControlLibrary.WordDiagramMaker(this.components);
            this.chastotaDiapComponent1 = new Lab1ComponentDasha.ChastotaDiapComponent();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(553, 450);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 38);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(727, 450);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 36);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(422, 12);
            this.textBoxFIO.Multiline = true;
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(396, 35);
            this.textBoxFIO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип поставляемой продукции";
            // 
            // controlSelect1
            // 
            this.controlSelect1.Location = new System.Drawing.Point(0, 0);
            this.controlSelect1.Name = "controlSelect1";
            this.controlSelect1.SelectedIndex = 0;
            this.controlSelect1.Size = new System.Drawing.Size(398, 331);
            this.controlSelect1.TabIndex = 0;
            // 
            // userControlList1
            // 
            this.userControlList1.Location = new System.Drawing.Point(252, 53);
            this.userControlList1.Name = "userControlList1";
            this.userControlList1.SelectedIndex = 0;
            this.userControlList1.Size = new System.Drawing.Size(498, 182);
            this.userControlList1.TabIndex = 5;
            // 
            // chastotaDiapComponent1
            // 
            this.chastotaDiapComponent1.Location = new System.Drawing.Point(16, 250);
            this.chastotaDiapComponent1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chastotaDiapComponent1.Name = "chastotaDiapComponent1";
            this.chastotaDiapComponent1.number = 0;
            this.chastotaDiapComponent1.NumberFrom = 0;
            this.chastotaDiapComponent1.NumberTo = 0;
            this.chastotaDiapComponent1.Size = new System.Drawing.Size(552, 69);
            this.chastotaDiapComponent1.TabIndex = 6;
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.chastotaDiapComponent1);
            this.Controls.Add(this.userControlList1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormProvider";
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Lab1ComponentDasha.RequestPDFComponent requestPDFComponent1;
        private Labs.ControlSelect controlSelect1;
        private ControlLibrary.WordDiagramMaker wordDiagramMaker1;
        private ControlLibrary.UserControlList userControlList1;
        private Konponens.WordReport wordReport1;
        private Komponents.StoreData storeData1;
        private ControlLibrary.WordDiagramMaker wordDiagramMaker2;
        private Lab1ComponentDasha.ChastotaDiapComponent chastotaDiapComponent1;
    }
}