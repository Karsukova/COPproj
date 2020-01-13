namespace MebelForm
{
    partial class FormMain
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
            this.buttonProvider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProvider
            // 
            this.buttonProvider.Location = new System.Drawing.Point(128, 59);
            this.buttonProvider.Name = "buttonProvider";
            this.buttonProvider.Size = new System.Drawing.Size(169, 68);
            this.buttonProvider.TabIndex = 0;
            this.buttonProvider.TabStop = false;
            this.buttonProvider.Text = "Поставщики";
            this.buttonProvider.UseVisualStyleBackColor = true;
            this.buttonProvider.Click += new System.EventHandler(this.buttonProvider_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Decorator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonProvider);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProvider;
        private System.Windows.Forms.Button button1;
    }
}