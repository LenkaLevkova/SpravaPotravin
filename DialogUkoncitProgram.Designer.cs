namespace SpravaPotravin
{
    partial class DialogUkoncitProgram
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
            this.labelUkoncit = new System.Windows.Forms.Label();
            this.buttonUkoncit = new System.Windows.Forms.Button();
            this.panelUkoncit = new System.Windows.Forms.Panel();
            this.buttonNie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUkoncit
            // 
            this.labelUkoncit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUkoncit.AutoSize = true;
            this.labelUkoncit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUkoncit.Location = new System.Drawing.Point(57, 163);
            this.labelUkoncit.Name = "labelUkoncit";
            this.labelUkoncit.Size = new System.Drawing.Size(263, 56);
            this.labelUkoncit.TabIndex = 0;
            this.labelUkoncit.Text = "  Uložiť zmeny pred \r\nukončením programu?";
            // 
            // buttonUkoncit
            // 
            this.buttonUkoncit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUkoncit.BackColor = System.Drawing.Color.LightGreen;
            this.buttonUkoncit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonUkoncit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUkoncit.Location = new System.Drawing.Point(26, 260);
            this.buttonUkoncit.Name = "buttonUkoncit";
            this.buttonUkoncit.Size = new System.Drawing.Size(157, 48);
            this.buttonUkoncit.TabIndex = 1;
            this.buttonUkoncit.Text = "ÁNO";
            this.buttonUkoncit.UseVisualStyleBackColor = false;
            // 
            // panelUkoncit
            // 
            this.panelUkoncit.BackgroundImage = global::SpravaPotravin.Properties.Resources.ukoncit;
            this.panelUkoncit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUkoncit.Location = new System.Drawing.Point(1, 0);
            this.panelUkoncit.Name = "panelUkoncit";
            this.panelUkoncit.Size = new System.Drawing.Size(465, 118);
            this.panelUkoncit.TabIndex = 2;
            // 
            // buttonNie
            // 
            this.buttonNie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNie.BackColor = System.Drawing.Color.LightGreen;
            this.buttonNie.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNie.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNie.Location = new System.Drawing.Point(189, 260);
            this.buttonNie.Name = "buttonNie";
            this.buttonNie.Size = new System.Drawing.Size(157, 48);
            this.buttonNie.TabIndex = 3;
            this.buttonNie.Text = "NIE";
            this.buttonNie.UseVisualStyleBackColor = false;
            // 
            // DialogUkoncitProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(374, 341);
            this.Controls.Add(this.buttonNie);
            this.Controls.Add(this.panelUkoncit);
            this.Controls.Add(this.buttonUkoncit);
            this.Controls.Add(this.labelUkoncit);
            this.Name = "DialogUkoncitProgram";
            this.Text = "Ukončiť program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUkoncit;
        private System.Windows.Forms.Button buttonUkoncit;
        private System.Windows.Forms.Panel panelUkoncit;
        private System.Windows.Forms.Button buttonNie;
    }
}