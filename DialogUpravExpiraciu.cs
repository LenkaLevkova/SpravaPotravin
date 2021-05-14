using System;
using System.Windows.Forms;

namespace SpravaPotravin
{
    public partial class DialogUpravExpiraciu : Form
    {
        public DialogUpravExpiraciu()
        {
            InitializeComponent();
        }
        private void DialogUpravExpiraciu_Load(object sender, EventArgs e)
        {
            dateTimePickerNovaExpiracia.MinDate = DateTime.Now;
        }
    }
}
