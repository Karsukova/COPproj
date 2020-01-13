namespace WindowsFormsAppCOP
{
    partial class FormCOP
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlListBoxSelected = new ControlLibrary.UserControlList();
            this.SuspendLayout();
            // 
            // controlListBoxSelected
            // 
            this.controlListBoxSelected.Location = new System.Drawing.Point(12, -4);
            this.controlListBoxSelected.Name = "controlListBoxSelected";
            this.controlListBoxSelected.SelectedIndex = 0;
            this.controlListBoxSelected.Size = new System.Drawing.Size(658, 211);
            this.controlListBoxSelected.TabIndex = 0;
            this.controlListBoxSelected.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // FormCOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 369);
            this.Controls.Add(this.controlListBoxSelected);
            this.Name = "FormCOP";
            this.Text = "FormCOP";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.UserControlList controlListBoxSelected;
    }
}

