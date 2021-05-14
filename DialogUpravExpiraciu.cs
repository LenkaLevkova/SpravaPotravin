using System;
using System.Windows.Forms;

namespace SpravaPotravin
{
    public partial class DialogUpravExpiraciu : Form
    {
        public DateTime Expiracia;
        public DialogUpravExpiraciu(DateTime expiracia)
        {
            InitializeComponent();
            Expiracia = expiracia;
        }
        private void DialogUpravExpiraciu_Load(object sender, EventArgs e)
        {
            dateTimePickerNovaExpiracia.Value = Expiracia;
            dateTimePickerNovaExpiracia.MinDate = DateTime.Now.Date;
        }
        private void dateTimePickerNovaExpiracia_ValueChanged(object sender, EventArgs e)
        {
            Expiracia = dateTimePickerNovaExpiracia.Value.Date;
        }
    }
}
