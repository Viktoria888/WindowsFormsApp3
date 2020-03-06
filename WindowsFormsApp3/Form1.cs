using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shedule_bdDataSet);

        }

        private void stationBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.stationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shedule_bdDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shedule_bdDataSet.trains". При необходимости она может быть перемещена или удалена.
            this.trainsTableAdapter.Fill(this.shedule_bdDataSet.trains);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shedule_bdDataSet.trains". При необходимости она может быть перемещена или удалена.
            this.trainsTableAdapter.Fill(this.shedule_bdDataSet.trains);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shedule_bdDataSet.timetable". При необходимости она может быть перемещена или удалена.
            this.timetableTableAdapter.Fill(this.shedule_bdDataSet.timetable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shedule_bdDataSet.station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.shedule_bdDataSet.station);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stationBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stationBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stationBindingSource.AddNew(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stationBindingSource.EndEdit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stationBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timetableBindingSource.AddNew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             timetableBindingSource.EndEdit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timetableBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timetableBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timetableBindingSource.MovePrevious();
        }

        private void price_ticketTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            trainsBindingSource.EndEdit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            trainsBindingSource.RemoveCurrent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            trainsBindingSource.AddNew();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            trainsBindingSource.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            trainsBindingSource.MovePrevious();
        }
    }
}
