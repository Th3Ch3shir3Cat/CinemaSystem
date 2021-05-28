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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Now;
            int numerusDay = System.DateTime.DaysInMonth(todayDate.Year, todayDate.Month);
            for (int i = 0; i < numerusDay; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.Name = "Column" + (i + 1).ToString();
                column.HeaderText = (i + 1).ToString();
                column.Width = 27;
                this.workers.Columns.Add(column);
            }

            this.month.Format = DateTimePickerFormat.Custom;
            month.CustomFormat = "MMMM";

            this.worker.Items.Add("Хаустов Герберт Игоревич");
            this.worker.Items.Add("Торопова Ольга Сергеевна");
        }

        private void workers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workers.CurrentCell.Value = "Я";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.workers.CurrentCell.Value = "О";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workers.CurrentCell.Value = "С";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int indexAdd = workers.Rows.Add();
            this.workers.Rows[indexAdd].Cells[0].Value = this.worker.SelectedItem;
        }
    }
}
