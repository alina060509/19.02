using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelCompleted_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioHight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LabelPriority_Click(object sender, EventArgs e)
        {

        }

        private void labelStartDate_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string priority = radioLow.Checked ? "Низкий" : (radioMedum.Checked ? "Средний" : "Высокий");
            string status = checkBoxCompleted.Checked ? @"[\/] Выполнено" : "В процессе!";
            string startDate = dateTimePicker1.Value.ToShortDateString();
            string dateline = monthCalendar.SelectionStart.ToShortDateString();
            string name = textBoxName.Text;

            string task = $"Задача:{name}: {status} | Приоритет: {priority} | {startDate} => {dateline}";
            listBoxTasks.Items.Add(task);
        }

        private void labelDedline_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
