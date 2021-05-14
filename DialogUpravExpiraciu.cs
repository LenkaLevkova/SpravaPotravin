using System;
using System.Windows.Forms;

namespace SpravaPotravin
{
    public partial class DialogUpravExpiraciu : Form
    {
        DateTime Expiracia;
        public DialogUpravExpiraciu(DateTime expiracia)
        {
            InitializeComponent();
            Expiracia = expiracia;
        }
        private void DialogUpravExpiraciu_Load(object sender, EventArgs e)
        {
            dateTimePickerNovaExpiracia.MinDate = DateTime.Now.Date;
            dateTimePickerNovaExpiracia.Value = Expiracia;
        }
    }
}
