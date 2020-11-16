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
        public List<Student> students_list = new List<Student>();
        public List<Father> fathers_list = new List<Father>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMan_Click(object sender, EventArgs e)
        {
            if (nameMans.Text != "" && surnameMans.Text != "" && middleNameMans.Text != "")
            {
                if (student.Checked == true)
                {
                    Student st = new Student(nameMans.Text, surnameMans.Text, middleNameMans.Text);
                    IMan man = st;
                    students_list.Add(st);
                    studentsList.Items.Add(man.GetParams());
                }
                if (father.Checked == true)
                {
                    Father fath = new Father(nameMans.Text, surnameMans.Text, middleNameMans.Text);
                    IMan man = fath;
                    fathers_list.Add(fath);
                    fathersList.Items.Add(man.GetParams());
                }
                if (student.Checked == false && father.Checked == false) MessageBox.Show("Нужно выбрать статус студента");
            }
            else MessageBox.Show("Введите имя фамилию отчество");
            
            
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
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    Student st = (Student)students_list[studentsList.SelectedIndex].Clone();
                    IMan man = st;
                    studentsList.Items.Add(man.GetParams());
                    students_list.Add(st);
                }
                if (tabControl1.SelectedIndex == 1)
                {
                    Father fath = (Father)fathers_list[fathersList.SelectedIndex].Clone();
                    IMan man = fath;
                    fathersList.Items.Add(man.GetParams());
                    fathers_list.Add(fath);
                }
            }
            catch
            {
                MessageBox.Show("Нужно выбрать элемент из списка");
            }            
        }

        private void DeleteMan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    students_list.RemoveAt(studentsList.SelectedIndex);
                    studentsList.Items.RemoveAt(studentsList.SelectedIndex);                    
                }
                if (tabControl1.SelectedIndex == 1)
                {
                    fathers_list.RemoveAt(fathersList.SelectedIndex);
                    fathersList.Items.RemoveAt(fathersList.SelectedIndex);                    
                }
            }
            catch
            {
                MessageBox.Show("Нужно выбрать элемент из списка");
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                students_list.Clear();
                studentsList.Items.Clear();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                fathers_list.Clear();
                fathersList.Items.Clear();
            }
        }

        private void CompareStudents_Click(object sender, EventArgs e)
        {
            int idStudent = 0;
            int idFather = 0;
            if (tabControl1.SelectedIndex == 0)
            {
                idStudent = studentsList.SelectedIndex;
            }
            if(tabControl1.SelectedIndex == 1)
            {
                idFather = fathersList.SelectedIndex;
            }
            try
            {
                if(students_list[idStudent].CompareTo(fathers_list[idFather]) == 0)
                {
                    MessageBox.Show("Фамилии выбранных студентов совпадают");
                }                

                else MessageBox.Show("Фамилии выбранных студентов не совпадают");
            }
            catch
            {
                MessageBox.Show("Нужно выбрать студентов");
            }
        }
    }
}
