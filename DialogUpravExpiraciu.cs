using System;
using System.Windows.Forms;

namespace SpravaPotravin
{
    public partial class DialogUpravExpiraciu : Form
    {
        DialogPridaniePotravin dialogPridat;
        Jedlo jedlo;
        public DialogUpravExpiraciu()
        {
            InitializeComponent();
            dialogPridat = new DialogPridaniePotravin();
            jedlo = dialogPridat.VratJedlo();
        }
        private void DialogUpravExpiraciu_Load(object sender, EventArgs e)
        {
            dateTimePickerNovaExpiracia.MinDate = DateTime.Now;
        }
    }
}
