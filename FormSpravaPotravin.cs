using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using KGySoft.CoreLibraries;
using KGySoft.ComponentModel;
using Newtonsoft.Json;
using System.IO;
using System.Data.EntityClient;
using System.Data.Objects.DataClasses;

namespace SpravaPotravin
{
    public partial class FormSpravaPotravin : Form
    {
        DialogPridaniePotravin dialogPridat;
        BindingSource source = new BindingSource();
        Jedlo jedlo;
        Zoznam zoznam;
        public FormSpravaPotravin()
        {
            InitializeComponent();
            dialogPridat = new DialogPridaniePotravin();
            jedlo = dialogPridat.VratJedlo();
            zoznam = new Zoznam();
            zoznam.Potraviny = new SortableBindingList<Jedlo>();
            source.DataSource = zoznam.Potraviny;
            dataGridViewJedlo.DataSource = source;
        }
        private void buttonPridatPotraviny_Click(object sender, EventArgs e)
        {
            DialogResult dialogPridaniePotravinResult = dialogPridat.ShowDialog();
            if (dialogPridaniePotravinResult == DialogResult.OK)
            {
                if(!(jedlo.JeMnozstvoCislo(dialogPridat.textBoxMnozstvo.Text)))
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
                DialogUpravMnozstvo dialogUpravMnozstvo = new DialogUpravMnozstvo();
                DialogResult dialogUpravMnozstvoResult = dialogUpravMnozstvo.ShowDialog();
                if (dialogUpravMnozstvoResult == DialogResult.OK)
                {
                    if (!(jedlo.JeMnozstvoCislo(dialogUpravMnozstvo.textBoxNoveMnozstvo.Text)))
                    {
                        MessageBox.Show("Zadané množstvo musí byť v číselnej forme.");
                        dialogUpravMnozstvo.textBoxNoveMnozstvo.Clear();
                        return;
                    }

                    else
                    {
                        jedlo.UpravMnozstvo(double.Parse(dialogUpravMnozstvo.textBoxNoveMnozstvo.Text));
                        dataGridViewJedlo.CurrentRow.Cells[zoznam.sloupecMnozstvo].Value = dialogUpravMnozstvo.textBoxNoveMnozstvo.Text;
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
                DialogUpravExpiraciu dialogUpravExpiraciu = new DialogUpravExpiraciu();
                DialogResult dialogUpravExpiraciuResult = dialogUpravExpiraciu.ShowDialog();
                if (dialogUpravExpiraciuResult == DialogResult.OK)
                {
                    jedlo.UpravExpiraciu(dialogUpravExpiraciu.dateTimePickerNovaExpiracia.Value.Date);
                    dataGridViewJedlo.CurrentRow.Cells[zoznam.sloupecExpiracia].Value = dialogUpravExpiraciu.dateTimePickerNovaExpiracia.Value.Date;
                    dataGridViewJedlo.UpdateCellValue(zoznam.sloupecExpiracia, dataGridViewJedlo.CurrentCell.RowIndex);
                }             
            }
        }
        private void dataGridViewJedlo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int stlpecKUsporiadaniu = e.ColumnIndex;
            ListSortDirection smer = ListSortDirection.Ascending;

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
            if((jedlo.BolaVykonanaZmena) || (zoznam.BolaVykonanaZmena))
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
            if(File.Exists(Repositar.Cesta))
            {
                Repositar.NacitajData();
                zoznam.Potraviny = JsonConvert.DeserializeObject<SortableBindingList<Jedlo>>(Repositar.Json);
            }

            dataGridViewJedlo.DataSource = zoznam.Potraviny;
        }
    }   
}
