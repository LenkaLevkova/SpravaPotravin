using System;
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
        }
        public Jedlo VratJedlo()
        {
            jedlo = new Jedlo();
            jedlo.Nazov = textBoxJedlo.Text;
            jedlo.Mnozstvo = double.Parse(textBoxMnozstvo.Text);
            jedlo.Jednotka = (Jednotky)Enum.Parse(typeof(Jednotky), comboBoxJednotky.Text);
            jedlo.Miesto = (Miesta)Enum.Parse(typeof(Miesta), comboBoxMiesto.Text);
            jedlo.Expiracia = dateTimePickerExpiracia.Value.Date;
            return jedlo;
        }

        private bool jeVsetkoVyplnene(Control.ControlCollection kontroly)
        {
            foreach (Control c in kontroly)
            {
                if (c is TextBox box)
                {
                    if (String.IsNullOrEmpty(box.Text))
                    {
                        return false;
                    }
                }

                else if (c is ComboBox combobox)
                {
                    if (String.IsNullOrEmpty(combobox.Text))
                    {
                        return false;
                    }
                }

                else if (c is DateTimePicker datetimepicker)
                {
                    if (String.IsNullOrEmpty(datetimepicker.ToString()))
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
