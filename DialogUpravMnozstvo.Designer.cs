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
            this.labelNoveMnozstvo.Location = new System.Drawing.Point(40, 113);
            this.labelNoveMnozstvo.Name = "labelNoveMnozstvo";
            this.labelNoveMnozstvo.Size = new System.Drawing.Size(285, 56);
            this.labelNoveMnozstvo.TabIndex = 1;
            this.labelNoveMnozstvo.Text = "Aktualizované množstvo\r\n     vybranej položky:";
            // 
            // textBoxNoveMnozstvo
            // 
            this.textBoxNoveMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoveMnozstvo.Location = new System.Drawing.Point(116, 195);
            this.textBoxNoveMnozstvo.Name = "textBoxNoveMnozstvo";
            this.textBoxNoveMnozstvo.Size = new System.Drawing.Size(140, 35);
            this.textBoxNoveMnozstvo.TabIndex = 10;
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
            // DialogUpravMnozstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(371, 328);
            this.Controls.Add(this.buttonUlozitNoveMnozstvo);
            this.Controls.Add(this.textBoxNoveMnozstvo);
            this.Controls.Add(this.labelNoveMnozstvo);
            this.Controls.Add(this.panelUpravitMnozstvo);
            this.Name = "DialogUpravMnozstvo";
            this.Text = "Upraviť množstvo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUpravitMnozstvo;
        private System.Windows.Forms.Label labelNoveMnozstvo;
        internal System.Windows.Forms.TextBox textBoxNoveMnozstvo;
        internal System.Windows.Forms.Button buttonUlozitNoveMnozstvo;
    }
}