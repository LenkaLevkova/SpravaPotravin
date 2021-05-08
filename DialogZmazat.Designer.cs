namespace SpravaPotravin
{
    partial class DialogZmazat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVybranaPolozka = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SpravaPotravin.Properties.Resources.zmazanie;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 97);
            this.panel1.TabIndex = 2;
            // 
            // labelVybranaPolozka
            // 
            this.labelVybranaPolozka.AutoSize = true;
            this.labelVybranaPolozka.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVybranaPolozka.Location = new System.Drawing.Point(12, 126);
            this.labelVybranaPolozka.Name = "labelVybranaPolozka";
            this.labelVybranaPolozka.Size = new System.Drawing.Size(373, 28);
            this.labelVybranaPolozka.TabIndex = 3;
            this.labelVybranaPolozka.Text = "Vybraná položka bude zmazaná.";
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.BackColor = System.Drawing.Color.Linen;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = System.Drawing.Color.Black;
            this.buttonOK.Location = new System.Drawing.Point(108, 179);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(175, 53);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // DialogZmazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelVybranaPolozka);
            this.Controls.Add(this.panel1);
            this.Name = "DialogZmazat";
            this.Text = "Zmazať vybranú položku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVybranaPolozka;
        private System.Windows.Forms.Button buttonOK;
    }
}