using System;
using System.Windows.Forms;

namespace SpravaPotravin
{
    public partial class DialogUpravMnozstvo : Form
    {
        public string Mnozstvo;
        public DialogUpravMnozstvo(string mnozstvo)
        {
            InitializeComponent();
            Mnozstvo = mnozstvo;
        }
        private void DialogUpravMnozstvo_Load(object sender, EventArgs e)
        {
            labelPovodneMnozstvoCislo.Text = Mnozstvo;   
        }
        private void textBoxNoveMnozstvo_TextChanged(object sender, EventArgs e)
        {
            Mnozstvo = textBoxNoveMnozstvo.Text;
        }
    }
}
