using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KGySoft.ComponentModel;
using Newtonsoft.Json;
using System.IO;

namespace SpravaPotravin
{
    public partial class FormSpravaPotravin : Form
    {
        BindingSource source = new BindingSource();
        Zoznam zoznam;
        ListSortDirection smer;
        public FormSpravaPotravin()
        {
            InitializeComponent();
            zoznam = new Zoznam();
            zoznam.Potraviny = new SortableBindingList<Jedlo>();
            source.DataSource = zoznam.Potraviny;
            dataGridViewJedlo.DataSource = source;
            smer = ListSortDirection.Ascending;
        }
        private void buttonPridatPotraviny_Click(object sender, EventArgs e)
        {
            DialogPridaniePotravin dialogPridat = new DialogPridaniePotravin();
            DialogResult dialogPridaniePotravinResult = dialogPridat.ShowDialog();
            if (dialogPridaniePotravinResult == DialogResult.OK)
            {
                if(!(Jedlo.JeMnozstvoCislo(dialogPridat.textBoxMnozstvo.Text)))
                {
                    MessageBox.Show("Zadané množstvo musí byť v číselnej forme.");
                    return;
                }

                zoznam.PridajJedlo(dialogPridat.jedlo);
            }
        }

        private void buttonZmazatCelyZaznam_Click(object sender, EventArgs e)
        {
            if ((!zoznam.JeVybranyRiadok(dataGridViewJedlo.SelectedRows.Count))) 
            {
                MessageBox.Show("Je nutné vybrať položku k zmazaniu.");
                return;
            }

            else 
            {
                DialogZmazat dialogZmazat = new DialogZmazat();
                DialogResult dialogZmazatVybranuPolozkuResult = dialogZmazat.ShowDialog();
                if (dialogZmazatVybranuPolozkuResult == DialogResult.OK)
                {
                    zoznam.ZmazJedlo((Jedlo)dataGridViewJedlo.CurrentRow.DataBoundItem);
                }
            }
        }
        private void buttonUpravitMnozstvo_Click(object sender, EventArgs e)
        {
            if ((!zoznam.JeVybranyRiadok(dataGridViewJedlo.SelectedRows.Count)))
            {
                MessageBox.Show("Je nutné vybrať položku k úprave.");
                return;
            }

            else
            {
                DialogUpravMnozstvo dialogUpravMnozstvo = new DialogUpravMnozstvo(dataGridViewJedlo.CurrentRow.Cells[zoznam.sloupecMnozstvo].Value.ToString());
                DialogResult dialogUpravMnozstvoResult = dialogUpravMnozstvo.ShowDialog();
                if (dialogUpravMnozstvoResult == DialogResult.OK)
                {
                    if (!(Jedlo.JeMnozstvoCislo(dialogUpravMnozstvo.textBoxNoveMnozstvo.Text)))
                    {
                        MessageBox.Show("Zadané množstvo musí byť v číselnej forme.");
                        dialogUpravMnozstvo.textBoxNoveMnozstvo.Clear();
                        return;
                    }

                    else
                    {
                        Jedlo.UpravMnozstvo(double.Parse(dialogUpravMnozstvo.Mnozstvo));
                        dataGridViewJedlo.CurrentRow.Cells[zoznam.sloupecMnozstvo].Value = dialogUpravMnozstvo.Mnozstvo;
                        dataGridViewJedlo.UpdateCellValue(zoznam.sloupecMnozstvo, dataGridViewJedlo.CurrentCell.RowIndex);
                        dialogUpravMnozstvo.textBoxNoveMnozstvo.Clear();
                    }                 
                }
            }
        }
        private void buttonUpravitExpiraciu_Click(object sender, EventArgs e)
        {
            if ((!zoznam.JeVybranyRiadok(dataGridViewJedlo.SelectedRows.Count)))
            {
                MessageBox.Show("Je nutné vybrať položku k úprave.");
                return;
            }

            else
            {
                DialogUpravExpiraciu dialogUpravExpiraciu = new DialogUpravExpiraciu((DateTime)dataGridViewJedlo.CurrentRow.Cells[zoznam.sloupecExpiracia].Value);
                DialogResult dialogUpravExpiraciuResult = dialogUpravExpiraciu.ShowDialog();
                if (dialogUpravExpiraciuResult == DialogResult.OK)
                {
                    Jedlo.UpravExpiraciu(dialogUpravExpiraciu.Expiracia);
                    dataGridViewJedlo.CurrentRow.Cells[zoznam.sloupecExpiracia].Value = dialogUpravExpiraciu.Expiracia;
                    dataGridViewJedlo.UpdateCellValue(zoznam.sloupecExpiracia, dataGridViewJedlo.CurrentCell.RowIndex);
                }             
            }
        }
        private void dataGridViewJedlo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int stlpecKUsporiadaniu = e.ColumnIndex;

            if (dataGridViewJedlo.Columns[stlpecKUsporiadaniu].SortMode != DataGridViewColumnSortMode.NotSortable)
            {
                if (smer == ListSortDirection.Ascending)
                {
                    smer = ListSortDirection.Descending;
                }

                else
                {
                    smer = ListSortDirection.Ascending;
                }

                dataGridViewJedlo.Sort(dataGridViewJedlo.Columns[stlpecKUsporiadaniu], smer); 
            }
        }
        private void dataGridViewJedlo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Jedlo jedlo = this.dataGridViewJedlo.Rows[e.RowIndex].DataBoundItem as Jedlo;

            if (!(jedlo.JeExpiraciaKriticka(jedlo.Expiracia)))
            {
                dataGridViewJedlo[zoznam.sloupecExpiracia, e.RowIndex].Style.ForeColor = Color.Black;
            }

            else
            {
                dataGridViewJedlo[zoznam.sloupecExpiracia, e.RowIndex].Style.ForeColor = Color.Red;
            }
        }
        private void dataGridViewJedlo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewJedlo.ClearSelection();
        }
        private void FormSpravaPotravin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((Jedlo.BolaVykonanaZmena) || (zoznam.BolaVykonanaZmena))
            {
                DialogUkoncitProgram dialogUkoncitProgram = new DialogUkoncitProgram();
                DialogResult dialogUkoncitProgramResult = dialogUkoncitProgram.ShowDialog();
                if (dialogUkoncitProgramResult == DialogResult.Yes)
                {
                    Repositar.UlozData(zoznam.Potraviny);
                }
            }
        }
        private void FormSpravaPotravin_Load(object sender, EventArgs e) 
        {
            zoznam.Potraviny = Repositar.NacitajData();
            dataGridViewJedlo.DataSource = zoznam.Potraviny;
        }
    }   
}
