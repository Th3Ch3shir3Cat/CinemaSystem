using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowNumber = seans.Rows.Add();
            seans.Rows[rowNumber].Cells["Id"].Value = rowNumber + 1;
            seans.Rows[rowNumber].Cells[1].Value = nameFilm.Text;
            seans.Rows[rowNumber].Cells[2].Value = monthFilm.SelectionStart.Day + "." + monthFilm.SelectionStart.Month + "." + monthFilm.SelectionStart.Year;
            seans.Rows[rowNumber].Cells[3].Value = timeFilm.Text;
            seans.Rows[rowNumber].Cells[4].Value = numberCinemaHall.SelectedItem;
            seans.Rows[rowNumber].Cells[5].Value = formatFilm.SelectedItem;
            seans.Rows[rowNumber].Cells[6].Value = sizeFilm.Text;
            seans.Rows[rowNumber].Cells[7].Value = "В продаже";
            seans.Rows[rowNumber].Cells[8].Value = ageRestriction.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.numberCinemaHall.Items.Add("1");
            this.numberCinemaHall.Items.Add("2");
            this.numberCinemaHall.Items.Add("3");
            this.numberCinemaHall.Items.Add("4");
            this.formatFilm.Items.Add("2D");
            this.formatFilm.Items.Add("3D");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.seans.SelectedCells[0].RowIndex;
            this.seans.Rows.RemoveAt(selectedIndex);
        }
    }
}
