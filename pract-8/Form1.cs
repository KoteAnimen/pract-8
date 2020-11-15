using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManStudents;

namespace pract_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMan_Click(object sender, EventArgs e)
        {
            if(student.Checked == true && nameMans.Text != "" && surnameMans.Text != "" && middleNameMans.Text != "")
            {
                Student st = new Student(nameMans.Text, surnameMans.Text, middleNameMans.Text);
                IMan man = st;
                studentsList.Items.Add(man.GetParams());
            }
            if (father.Checked == true && nameMans.Text != "" && surnameMans.Text != "" && middleNameMans.Text != "")
            {
                Father fath = new Father(nameMans.Text, surnameMans.Text, middleNameMans.Text);
                IMan man = fath;
                studentsList.Items.Add(man.GetParams());
            }
            
        }

        private void student_CheckedChanged(object sender, EventArgs e)
        {
            if (student.Checked == true) father.Checked = false;
        }

        private void father_CheckedChanged(object sender, EventArgs e)
        {
            if (father.Checked == true) student.Checked = false;
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, Вариант 1.  Создать интерфейс - человек. Создать классы – студент и студент-отец семейства. Классы должны включать конструкторы, функцию для формирования строки информации о студенте. Сравнение производить по фамилии.");
        }

        private void CloneStudent_Click(object sender, EventArgs e)
        {

            
        }
    }
}
