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
    public partial class Form2 : Form
    {
        public Form2()
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
            string priority = radioLow.Checked ? "Отдых" : (radioMedum.Checked ? "Учеба" : "Работа");
            string status = checkBoxCompleted.Checked ? @"Дело выполнено" : "В процессе(";
            string startDate = dateTimePicker1.Value.ToShortDateString();
            string dateline = monthCalendar.SelectionStart.ToShortDateString();
            string name = textBoxName.Text;

            string task = $"Задача:{name}: {status} | Категория: {priority} | {startDate} => {dateline}";
            listBoxTasks.Items.Add(task);
        }

        private void labelDedline_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioLow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите задачу для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
