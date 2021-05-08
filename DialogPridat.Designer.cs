namespace SpravaPotravin
{
    partial class DialogPridaniePotravin
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
            this.labelJedlo = new System.Windows.Forms.Label();
            this.textBoxJedlo = new System.Windows.Forms.TextBox();
            this.labelMiesto = new System.Windows.Forms.Label();
            this.labelMnozstvo = new System.Windows.Forms.Label();
            this.labelExpiracia = new System.Windows.Forms.Label();
            this.comboBoxMiesto = new System.Windows.Forms.ComboBox();
            this.comboBoxJednotky = new System.Windows.Forms.ComboBox();
            this.dateTimePickerExpiracia = new System.Windows.Forms.DateTimePicker();
            this.textBoxMnozstvo = new System.Windows.Forms.TextBox();
            this.buttonUlozitJedlo = new System.Windows.Forms.Button();
            this.panelPridaniePotravin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelJedlo
            // 
            this.labelJedlo.AutoSize = true;
            this.labelJedlo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJedlo.Location = new System.Drawing.Point(22, 162);
            this.labelJedlo.Name = "labelJedlo";
            this.labelJedlo.Size = new System.Drawing.Size(85, 28);
            this.labelJedlo.TabIndex = 0;
            this.labelJedlo.Text = "Jedlo :";
            // 
            // textBoxJedlo
            // 
            this.textBoxJedlo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJedlo.Location = new System.Drawing.Point(162, 155);
            this.textBoxJedlo.Name = "textBoxJedlo";
            this.textBoxJedlo.Size = new System.Drawing.Size(564, 35);
            this.textBoxJedlo.TabIndex = 1;
            this.textBoxJedlo.TextChanged += new System.EventHandler(this.textBoxJedlo_TextChanged);
            // 
            // labelMiesto
            // 
            this.labelMiesto.AutoSize = true;
            this.labelMiesto.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiesto.Location = new System.Drawing.Point(22, 231);
            this.labelMiesto.Name = "labelMiesto";
            this.labelMiesto.Size = new System.Drawing.Size(101, 28);
            this.labelMiesto.TabIndex = 2;
            this.labelMiesto.Text = "Miesto :";
            // 
            // labelMnozstvo
            // 
            this.labelMnozstvo.AutoSize = true;
            this.labelMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMnozstvo.Location = new System.Drawing.Point(22, 295);
            this.labelMnozstvo.Name = "labelMnozstvo";
            this.labelMnozstvo.Size = new System.Drawing.Size(133, 28);
            this.labelMnozstvo.TabIndex = 3;
            this.labelMnozstvo.Text = "Množstvo :";
            // 
            // labelExpiracia
            // 
            this.labelExpiracia.AutoSize = true;
            this.labelExpiracia.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExpiracia.Location = new System.Drawing.Point(22, 364);
            this.labelExpiracia.Name = "labelExpiracia";
            this.labelExpiracia.Size = new System.Drawing.Size(134, 28);
            this.labelExpiracia.TabIndex = 4;
            this.labelExpiracia.Text = "Expirácia :";
            // 
            // comboBoxMiesto
            // 
            this.comboBoxMiesto.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMiesto.FormattingEnabled = true;
            this.comboBoxMiesto.Items.AddRange(new object[] {
            "Chladnička",
            "Mraznička",
            "Špajza"});
            this.comboBoxMiesto.Location = new System.Drawing.Point(160, 223);
            this.comboBoxMiesto.Name = "comboBoxMiesto";
            this.comboBoxMiesto.Size = new System.Drawing.Size(220, 36);
            this.comboBoxMiesto.TabIndex = 5;
            this.comboBoxMiesto.SelectedIndexChanged += new System.EventHandler(this.comboBoxMiesto_SelectedIndexChanged);
            // 
            // comboBoxJednotky
            // 
            this.comboBoxJednotky.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxJednotky.FormattingEnabled = true;
            this.comboBoxJednotky.Items.AddRange(new object[] {
            "ks",
            "g",
            "ml"});
            this.comboBoxJednotky.Location = new System.Drawing.Point(291, 287);
            this.comboBoxJednotky.Name = "comboBoxJednotky";
            this.comboBoxJednotky.Size = new System.Drawing.Size(89, 36);
            this.comboBoxJednotky.TabIndex = 7;
            this.comboBoxJednotky.SelectedIndexChanged += new System.EventHandler(this.comboBoxJednotky_SelectedIndexChanged);
            // 
            // dateTimePickerExpiracia
            // 
            this.dateTimePickerExpiracia.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerExpiracia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpiracia.Location = new System.Drawing.Point(162, 359);
            this.dateTimePickerExpiracia.Name = "dateTimePickerExpiracia";
            this.dateTimePickerExpiracia.Size = new System.Drawing.Size(218, 35);
            this.dateTimePickerExpiracia.TabIndex = 8;
            this.dateTimePickerExpiracia.Value = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            this.dateTimePickerExpiracia.ValueChanged += new System.EventHandler(this.dateTimePickerExpiracia_ValueChanged);
            // 
            // textBoxMnozstvo
            // 
            this.textBoxMnozstvo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMnozstvo.Location = new System.Drawing.Point(160, 288);
            this.textBoxMnozstvo.Name = "textBoxMnozstvo";
            this.textBoxMnozstvo.Size = new System.Drawing.Size(109, 35);
            this.textBoxMnozstvo.TabIndex = 9;
            this.textBoxMnozstvo.TextChanged += new System.EventHandler(this.textBoxMnozstvo_TextChanged);
            // 
            // buttonUlozitJedlo
            // 
            this.buttonUlozitJedlo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUlozitJedlo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUlozitJedlo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozitJedlo.Location = new System.Drawing.Point(213, 429);
            this.buttonUlozitJedlo.Name = "buttonUlozitJedlo";
            this.buttonUlozitJedlo.Size = new System.Drawing.Size(306, 55);
            this.buttonUlozitJedlo.TabIndex = 10;
            this.buttonUlozitJedlo.Text = "Uložiť";
            this.buttonUlozitJedlo.UseVisualStyleBackColor = false;
            this.buttonUlozitJedlo.Click += new System.EventHandler(this.buttonUlozitJedlo_Click);
            // 
            // panelPridaniePotravin
            // 
            this.panelPridaniePotravin.BackgroundImage = global::SpravaPotravin.Properties.Resources.pridat;
            this.panelPridaniePotravin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPridaniePotravin.Location = new System.Drawing.Point(0, -2);
            this.panelPridaniePotravin.Name = "panelPridaniePotravin";
            this.panelPridaniePotravin.Size = new System.Drawing.Size(761, 138);
            this.panelPridaniePotravin.TabIndex = 11;
            // 
            // DialogPridaniePotravin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(756, 510);
            this.Controls.Add(this.panelPridaniePotravin);
            this.Controls.Add(this.buttonUlozitJedlo);
            this.Controls.Add(this.textBoxMnozstvo);
            this.Controls.Add(this.dateTimePickerExpiracia);
            this.Controls.Add(this.comboBoxJednotky);
            this.Controls.Add(this.comboBoxMiesto);
            this.Controls.Add(this.labelExpiracia);
            this.Controls.Add(this.labelMnozstvo);
            this.Controls.Add(this.labelMiesto);
            this.Controls.Add(this.textBoxJedlo);
            this.Controls.Add(this.labelJedlo);
            this.Name = "DialogPridaniePotravin";
            this.Text = "Pridať potraviny";
            this.Load += new System.EventHandler(this.DialogPridaniePotravin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJedlo;
        private System.Windows.Forms.Label labelMiesto;
        private System.Windows.Forms.Label labelMnozstvo;
        private System.Windows.Forms.Label labelExpiracia;
        private System.Windows.Forms.Panel panelPridaniePotravin;
        internal System.Windows.Forms.TextBox textBoxJedlo;
        internal System.Windows.Forms.ComboBox comboBoxMiesto;
        internal System.Windows.Forms.ComboBox comboBoxJednotky;
        internal System.Windows.Forms.DateTimePicker dateTimePickerExpiracia;
        internal System.Windows.Forms.TextBox textBoxMnozstvo;
        internal System.Windows.Forms.Button buttonUlozitJedlo;
    }
}