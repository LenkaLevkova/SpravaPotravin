namespace SpravaPotravin
{
    partial class DialogUpravMnozstvo
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
            this.panelUpravitMnozstvo = new System.Windows.Forms.Panel();
            this.labelNoveMnozstvo = new System.Windows.Forms.Label();
            this.textBoxNoveMnozstvo = new System.Windows.Forms.TextBox();
            this.buttonUlozitNoveMnozstvo = new System.Windows.Forms.Button();
            this.labelPovodneMnozstvoCislo = new System.Windows.Forms.Label();
            this.labelPovodneMnozstvo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelUpravitMnozstvo
            // 
            this.panelUpravitMnozstvo.BackgroundImage = global::SpravaPotravin.Properties.Resources.upravit;
            this.panelUpravitMnozstvo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUpravitMnozstvo.Location = new System.Drawing.Point(0, -2);
            this.panelUpravitMnozstvo.Name = "panelUpravitMnozstvo";
            this.panelUpravitMnozstvo.Size = new System.Drawing.Size(374, 95);
            this.panelUpravitMnozstvo.TabIndex = 0;
            // 
            // labelNoveMnozstvo
            // 
            this.labelNoveMnozstvo.AutoSize = true;
            this.labelNoveMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNoveMnozstvo.Location = new System.Drawing.Point(12, 193);
            this.labelNoveMnozstvo.Name = "labelNoveMnozstvo";
            this.labelNoveMnozstvo.Size = new System.Drawing.Size(188, 28);
            this.labelNoveMnozstvo.TabIndex = 1;
            this.labelNoveMnozstvo.Text = "Nové množstvo:";
            // 
            // textBoxNoveMnozstvo
            // 
            this.textBoxNoveMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoveMnozstvo.Location = new System.Drawing.Point(228, 186);
            this.textBoxNoveMnozstvo.Name = "textBoxNoveMnozstvo";
            this.textBoxNoveMnozstvo.Size = new System.Drawing.Size(121, 35);
            this.textBoxNoveMnozstvo.TabIndex = 10;
            this.textBoxNoveMnozstvo.TextChanged += new System.EventHandler(this.textBoxNoveMnozstvo_TextChanged);
            // 
            // buttonUlozitNoveMnozstvo
            // 
            this.buttonUlozitNoveMnozstvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUlozitNoveMnozstvo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUlozitNoveMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozitNoveMnozstvo.Location = new System.Drawing.Point(69, 254);
            this.buttonUlozitNoveMnozstvo.Name = "buttonUlozitNoveMnozstvo";
            this.buttonUlozitNoveMnozstvo.Size = new System.Drawing.Size(229, 55);
            this.buttonUlozitNoveMnozstvo.TabIndex = 11;
            this.buttonUlozitNoveMnozstvo.Text = "Uložiť";
            this.buttonUlozitNoveMnozstvo.UseVisualStyleBackColor = false;
            // 
            // labelPovodneMnozstvoCislo
            // 
            this.labelPovodneMnozstvoCislo.AutoSize = true;
            this.labelPovodneMnozstvoCislo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPovodneMnozstvoCislo.Location = new System.Drawing.Point(270, 131);
            this.labelPovodneMnozstvoCislo.Name = "labelPovodneMnozstvoCislo";
            this.labelPovodneMnozstvoCislo.Size = new System.Drawing.Size(79, 28);
            this.labelPovodneMnozstvoCislo.TabIndex = 12;
            this.labelPovodneMnozstvoCislo.Text = "label1";
            // 
            // labelPovodneMnozstvo
            // 
            this.labelPovodneMnozstvo.AutoSize = true;
            this.labelPovodneMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPovodneMnozstvo.Location = new System.Drawing.Point(12, 131);
            this.labelPovodneMnozstvo.Name = "labelPovodneMnozstvo";
            this.labelPovodneMnozstvo.Size = new System.Drawing.Size(225, 28);
            this.labelPovodneMnozstvo.TabIndex = 13;
            this.labelPovodneMnozstvo.Text = "Pôvodné množstvo:";
            // 
            // DialogUpravMnozstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(371, 328);
            this.Controls.Add(this.labelPovodneMnozstvo);
            this.Controls.Add(this.labelPovodneMnozstvoCislo);
            this.Controls.Add(this.buttonUlozitNoveMnozstvo);
            this.Controls.Add(this.textBoxNoveMnozstvo);
            this.Controls.Add(this.labelNoveMnozstvo);
            this.Controls.Add(this.panelUpravitMnozstvo);
            this.Name = "DialogUpravMnozstvo";
            this.Text = "Upraviť množstvo";
            this.Load += new System.EventHandler(this.DialogUpravMnozstvo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUpravitMnozstvo;
        private System.Windows.Forms.Label labelNoveMnozstvo;
        internal System.Windows.Forms.TextBox textBoxNoveMnozstvo;
        internal System.Windows.Forms.Button buttonUlozitNoveMnozstvo;
        public System.Windows.Forms.Label labelPovodneMnozstvoCislo;
        private System.Windows.Forms.Label labelPovodneMnozstvo;
    }
}