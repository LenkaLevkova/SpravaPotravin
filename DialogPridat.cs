﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpravaPotravin
{
    public partial class DialogPridaniePotravin : Form
    {
        public Jedlo jedlo;
        public DialogPridaniePotravin()
        {
            InitializeComponent();
        }
        private void DialogPridaniePotravin_Load(object sender, EventArgs e)
        {
            dateTimePickerExpiracia.MinDate = DateTime.Now;
            buttonUlozitJedlo.Enabled = jeVsetkoVyplnene(this.Controls);
        }
        private void buttonUlozitJedlo_Click(object sender, EventArgs e)
        {
            VratJedlo();
            jedlo.Nazov = textBoxJedlo.Text;
            jedlo.Mnozstvo = double.Parse(textBoxMnozstvo.Text);
            jedlo.Jednotka = (Jednotky)Enum.Parse(typeof(Jednotky), comboBoxJednotky.Text);
            jedlo.Miesto = (Miesta)Enum.Parse(typeof(Miesta), comboBoxMiesto.Text);
            jedlo.Expiracia = dateTimePickerExpiracia.Value.Date;
        }
        public Jedlo VratJedlo()
        {
            jedlo = new Jedlo();
            return jedlo;
        }

        private bool jeVsetkoVyplnene(Control.ControlCollection kontroly)
        {
            foreach (Control c in kontroly)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        return false;
                    }
                }

                else if (c is ComboBox)
                {
                    if (String.IsNullOrEmpty(((ComboBox)c).Text))
                    {
                        return false;
                    }
                }

                else if (c is DateTimePicker)
                {
                    if (String.IsNullOrEmpty(((DateTimePicker)c).ToString()))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void textBoxJedlo_TextChanged(object sender, EventArgs e)
        {
            buttonUlozitJedlo.Enabled = jeVsetkoVyplnene(this.Controls);
        }

        private void comboBoxMiesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUlozitJedlo.Enabled = jeVsetkoVyplnene(this.Controls);
        }

        private void textBoxMnozstvo_TextChanged(object sender, EventArgs e)
        {
            buttonUlozitJedlo.Enabled = jeVsetkoVyplnene(this.Controls);
        }

        private void comboBoxJednotky_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUlozitJedlo.Enabled = jeVsetkoVyplnene(this.Controls);
        }

        private void dateTimePickerExpiracia_ValueChanged(object sender, EventArgs e)
        {
            buttonUlozitJedlo.Enabled = jeVsetkoVyplnene(this.Controls);
        }
    }
}