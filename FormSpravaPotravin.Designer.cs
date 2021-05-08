namespace SpravaPotravin
{
    partial class FormSpravaPotravin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPridatPotraviny = new System.Windows.Forms.Button();
            this.buttonUpravitMnozstvo = new System.Windows.Forms.Button();
            this.buttonUpravitExpiraciu = new System.Windows.Forms.Button();
            this.buttonVymazatVybrane = new System.Windows.Forms.Button();
            this.panelRozcestnik = new System.Windows.Forms.Panel();
            this.labelRozcestnik = new System.Windows.Forms.Label();
            this.dataGridViewJedlo = new System.Windows.Forms.DataGridView();
            this.panelRozcestnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJedlo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPridatPotraviny
            // 
            this.buttonPridatPotraviny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonPridatPotraviny.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPridatPotraviny.BackColor = System.Drawing.Color.Beige;
            this.buttonPridatPotraviny.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridatPotraviny.ForeColor = System.Drawing.Color.Black;
            this.buttonPridatPotraviny.Location = new System.Drawing.Point(13, 154);
            this.buttonPridatPotraviny.Name = "buttonPridatPotraviny";
            this.buttonPridatPotraviny.Size = new System.Drawing.Size(235, 57);
            this.buttonPridatPotraviny.TabIndex = 1;
            this.buttonPridatPotraviny.Text = "Pridať potraviny";
            this.buttonPridatPotraviny.UseVisualStyleBackColor = false;
            this.buttonPridatPotraviny.Click += new System.EventHandler(this.buttonPridatPotraviny_Click);
            // 
            // buttonUpravitMnozstvo
            // 
            this.buttonUpravitMnozstvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonUpravitMnozstvo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpravitMnozstvo.BackColor = System.Drawing.Color.Beige;
            this.buttonUpravitMnozstvo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpravitMnozstvo.ForeColor = System.Drawing.Color.Black;
            this.buttonUpravitMnozstvo.Location = new System.Drawing.Point(254, 154);
            this.buttonUpravitMnozstvo.Name = "buttonUpravitMnozstvo";
            this.buttonUpravitMnozstvo.Size = new System.Drawing.Size(239, 57);
            this.buttonUpravitMnozstvo.TabIndex = 2;
            this.buttonUpravitMnozstvo.Text = "Upraviť množstvo vybranej položky";
            this.buttonUpravitMnozstvo.UseVisualStyleBackColor = false;
            this.buttonUpravitMnozstvo.Click += new System.EventHandler(this.buttonUpravitMnozstvo_Click);
            // 
            // buttonUpravitExpiraciu
            // 
            this.buttonUpravitExpiraciu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonUpravitExpiraciu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpravitExpiraciu.BackColor = System.Drawing.Color.Beige;
            this.buttonUpravitExpiraciu.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpravitExpiraciu.ForeColor = System.Drawing.Color.Black;
            this.buttonUpravitExpiraciu.Location = new System.Drawing.Point(499, 154);
            this.buttonUpravitExpiraciu.Name = "buttonUpravitExpiraciu";
            this.buttonUpravitExpiraciu.Size = new System.Drawing.Size(239, 57);
            this.buttonUpravitExpiraciu.TabIndex = 3;
            this.buttonUpravitExpiraciu.Text = "Upraviť expiráciu\r\nvybranej položky";
            this.buttonUpravitExpiraciu.UseVisualStyleBackColor = false;
            this.buttonUpravitExpiraciu.Click += new System.EventHandler(this.buttonUpravitExpiraciu_Click);
            // 
            // buttonVymazatVybrane
            // 
            this.buttonVymazatVybrane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonVymazatVybrane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonVymazatVybrane.BackColor = System.Drawing.Color.Beige;
            this.buttonVymazatVybrane.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVymazatVybrane.ForeColor = System.Drawing.Color.Black;
            this.buttonVymazatVybrane.Location = new System.Drawing.Point(744, 154);
            this.buttonVymazatVybrane.Name = "buttonVymazatVybrane";
            this.buttonVymazatVybrane.Size = new System.Drawing.Size(239, 57);
            this.buttonVymazatVybrane.TabIndex = 5;
            this.buttonVymazatVybrane.Text = "Vymazať vybranú položku";
            this.buttonVymazatVybrane.UseVisualStyleBackColor = false;
            this.buttonVymazatVybrane.Click += new System.EventHandler(this.buttonZmazatCelyZaznam_Click);
            // 
            // panelRozcestnik
            // 
            this.panelRozcestnik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRozcestnik.BackgroundImage = global::SpravaPotravin.Properties.Resources.Sprava;
            this.panelRozcestnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRozcestnik.Controls.Add(this.labelRozcestnik);
            this.panelRozcestnik.Location = new System.Drawing.Point(-3, -4);
            this.panelRozcestnik.Name = "panelRozcestnik";
            this.panelRozcestnik.Size = new System.Drawing.Size(999, 143);
            this.panelRozcestnik.TabIndex = 0;
            // 
            // labelRozcestnik
            // 
            this.labelRozcestnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelRozcestnik.AutoSize = true;
            this.labelRozcestnik.BackColor = System.Drawing.Color.Transparent;
            this.labelRozcestnik.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozcestnik.Location = new System.Drawing.Point(414, 38);
            this.labelRozcestnik.Name = "labelRozcestnik";
            this.labelRozcestnik.Size = new System.Drawing.Size(227, 88);
            this.labelRozcestnik.TabIndex = 0;
            this.labelRozcestnik.Text = "  SPRÁVA \r\nPOTRAVÍN";
            // 
            // dataGridViewJedlo
            // 
            this.dataGridViewJedlo.AllowUserToAddRows = false;
            this.dataGridViewJedlo.AllowUserToDeleteRows = false;
            this.dataGridViewJedlo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJedlo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJedlo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJedlo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJedlo.ColumnHeadersHeight = 29;
            this.dataGridViewJedlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJedlo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewJedlo.Location = new System.Drawing.Point(13, 228);
            this.dataGridViewJedlo.Name = "dataGridViewJedlo";
            this.dataGridViewJedlo.ReadOnly = true;
            this.dataGridViewJedlo.RowHeadersWidth = 20;
            this.dataGridViewJedlo.RowTemplate.Height = 24;
            this.dataGridViewJedlo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJedlo.Size = new System.Drawing.Size(970, 498);
            this.dataGridViewJedlo.TabIndex = 6;
            this.dataGridViewJedlo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewJedlo_ColumnHeaderMouseClick);
            this.dataGridViewJedlo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewJedlo_DataBindingComplete);
            this.dataGridViewJedlo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewJedlo_RowPrePaint);
            // 
            // FormSpravaPotravin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(995, 738);
            this.Controls.Add(this.dataGridViewJedlo);
            this.Controls.Add(this.buttonVymazatVybrane);
            this.Controls.Add(this.buttonUpravitExpiraciu);
            this.Controls.Add(this.buttonUpravitMnozstvo);
            this.Controls.Add(this.buttonPridatPotraviny);
            this.Controls.Add(this.panelRozcestnik);
            this.Name = "FormSpravaPotravin";
            this.Text = "Správa potravín";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSpravaPotravin_FormClosing);
            this.Load += new System.EventHandler(this.FormSpravaPotravin_Load);
            this.panelRozcestnik.ResumeLayout(false);
            this.panelRozcestnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJedlo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRozcestnik;
        private System.Windows.Forms.Panel panelRozcestnik;
        private System.Windows.Forms.Button buttonPridatPotraviny;
        private System.Windows.Forms.Button buttonUpravitMnozstvo;
        private System.Windows.Forms.Button buttonUpravitExpiraciu;
        private System.Windows.Forms.Button buttonVymazatVybrane;
        internal System.Windows.Forms.DataGridView dataGridViewJedlo;
    }
}

