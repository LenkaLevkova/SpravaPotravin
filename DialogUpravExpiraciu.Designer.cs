namespace SpravaPotravin
{
    partial class DialogUpravExpiraciu
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
            this.buttonUlozitNovuExpiraciu = new System.Windows.Forms.Button();
            this.labelNovaExpiracia = new System.Windows.Forms.Label();
            this.panelUpravitExpiraciu = new System.Windows.Forms.Panel();
            this.dateTimePickerNovaExpiracia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonUlozitNovuExpiraciu
            // 
            this.buttonUlozitNovuExpiraciu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonUlozitNovuExpiraciu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUlozitNovuExpiraciu.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozitNovuExpiraciu.Location = new System.Drawing.Point(69, 299);
            this.buttonUlozitNovuExpiraciu.Name = "buttonUlozitNovuExpiraciu";
            this.buttonUlozitNovuExpiraciu.Size = new System.Drawing.Size(229, 55);
            this.buttonUlozitNovuExpiraciu.TabIndex = 14;
            this.buttonUlozitNovuExpiraciu.Text = "Uložiť";
            this.buttonUlozitNovuExpiraciu.UseVisualStyleBackColor = false;
            // 
            // labelNovaExpiracia
            // 
            this.labelNovaExpiracia.AutoSize = true;
            this.labelNovaExpiracia.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNovaExpiracia.Location = new System.Drawing.Point(44, 144);
            this.labelNovaExpiracia.Name = "labelNovaExpiracia";
            this.labelNovaExpiracia.Size = new System.Drawing.Size(284, 56);
            this.labelNovaExpiracia.TabIndex = 12;
            this.labelNovaExpiracia.Text = "Aktualizovaná expirácia\r\n     vybranej položky:";
            // 
            // panelUpravitExpiraciu
            // 
            this.panelUpravitExpiraciu.BackgroundImage = global::SpravaPotravin.Properties.Resources.expiracia;
            this.panelUpravitExpiraciu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUpravitExpiraciu.Location = new System.Drawing.Point(-2, 0);
            this.panelUpravitExpiraciu.Name = "panelUpravitExpiraciu";
            this.panelUpravitExpiraciu.Size = new System.Drawing.Size(374, 97);
            this.panelUpravitExpiraciu.TabIndex = 1;
            // 
            // dateTimePickerNovaExpiracia
            // 
            this.dateTimePickerNovaExpiracia.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerNovaExpiracia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNovaExpiracia.Location = new System.Drawing.Point(80, 232);
            this.dateTimePickerNovaExpiracia.Name = "dateTimePickerNovaExpiracia";
            this.dateTimePickerNovaExpiracia.Size = new System.Drawing.Size(218, 35);
            this.dateTimePickerNovaExpiracia.TabIndex = 15;
            this.dateTimePickerNovaExpiracia.Value = new System.DateTime(2021, 4, 23, 14, 53, 5, 0);
            // 
            // DialogUpravExpiraciu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(371, 370);
            this.Controls.Add(this.dateTimePickerNovaExpiracia);
            this.Controls.Add(this.buttonUlozitNovuExpiraciu);
            this.Controls.Add(this.labelNovaExpiracia);
            this.Controls.Add(this.panelUpravitExpiraciu);
            this.Name = "DialogUpravExpiraciu";
            this.Text = "DialogUpravExpiraciu";
            this.Load += new System.EventHandler(this.DialogUpravExpiraciu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUpravitExpiraciu;
        internal System.Windows.Forms.Button buttonUlozitNovuExpiraciu;
        private System.Windows.Forms.Label labelNovaExpiracia;
        internal System.Windows.Forms.DateTimePicker dateTimePickerNovaExpiracia;
    }
}