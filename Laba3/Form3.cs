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
        }

        private void workers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
