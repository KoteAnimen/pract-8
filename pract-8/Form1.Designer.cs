﻿namespace pract_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fathersList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.student = new System.Windows.Forms.CheckBox();
            this.father = new System.Windows.Forms.CheckBox();
            this.nameMans = new System.Windows.Forms.TextBox();
            this.CreateMan = new System.Windows.Forms.Button();
            this.surnameMans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.middleNameMans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CompareStudents = new System.Windows.Forms.ToolStripButton();
            this.CloneStudent = new System.Windows.Forms.ToolStripButton();
            this.DeleteMan = new System.Windows.Forms.ToolStripButton();
            this.ClearList = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(234, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentsList);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенты";
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(6, 19);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(209, 316);
            this.studentsList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(234, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Студенты-отцы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fathersList);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Студенты-отцы";
            // 
            // fathersList
            // 
            this.fathersList.FormattingEnabled = true;
            this.fathersList.Location = new System.Drawing.Point(6, 19);
            this.fathersList.Name = "fathersList";
            this.fathersList.Size = new System.Drawing.Size(209, 316);
            this.fathersList.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(234, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.nameMans);
            this.groupBox4.Controls.Add(this.CreateMan);
            this.groupBox4.Controls.Add(this.surnameMans);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.middleNameMans);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(3, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 278);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Человек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.student);
            this.groupBox3.Controls.Add(this.father);
            this.groupBox3.Location = new System.Drawing.Point(6, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статус человека";
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Checked = true;
            this.student.CheckState = System.Windows.Forms.CheckState.Checked;
            this.student.Location = new System.Drawing.Point(6, 19);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(66, 17);
            this.student.TabIndex = 4;
            this.student.Text = "Студент";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_CheckedChanged);
            // 
            // father
            // 
            this.father.AutoSize = true;
            this.father.Location = new System.Drawing.Point(6, 42);
            this.father.Name = "father";
            this.father.Size = new System.Drawing.Size(150, 17);
            this.father.TabIndex = 5;
            this.father.Text = "Студент-отец семейства";
            this.father.UseVisualStyleBackColor = true;
            this.father.Click += new System.EventHandler(this.father_CheckedChanged);
            // 
            // nameMans
            // 
            this.nameMans.Location = new System.Drawing.Point(6, 48);
            this.nameMans.Name = "nameMans";
            this.nameMans.Size = new System.Drawing.Size(202, 20);
            this.nameMans.TabIndex = 0;
            // 
            // CreateMan
            // 
            this.CreateMan.Location = new System.Drawing.Point(6, 238);
            this.CreateMan.Name = "CreateMan";
            this.CreateMan.Size = new System.Drawing.Size(202, 23);
            this.CreateMan.TabIndex = 9;
            this.CreateMan.Text = "Создать";
            this.CreateMan.UseVisualStyleBackColor = true;
            this.CreateMan.Click += new System.EventHandler(this.CreateMan_Click);
            // 
            // surnameMans
            // 
            this.surnameMans.Location = new System.Drawing.Point(6, 90);
            this.surnameMans.Name = "surnameMans";
            this.surnameMans.Size = new System.Drawing.Size(202, 20);
            this.surnameMans.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Отчество";
            // 
            // middleNameMans
            // 
            this.middleNameMans.Location = new System.Drawing.Point(6, 135);
            this.middleNameMans.Name = "middleNameMans";
            this.middleNameMans.Size = new System.Drawing.Size(202, 20);
            this.middleNameMans.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Фамилия";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareStudents,
            this.CloneStudent,
            this.DeleteMan,
            this.ClearList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CompareStudents
            // 
            this.CompareStudents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CompareStudents.Image = ((System.Drawing.Image)(resources.GetObject("CompareStudents.Image")));
            this.CompareStudents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompareStudents.Name = "CompareStudents";
            this.CompareStudents.Size = new System.Drawing.Size(23, 22);
            this.CompareStudents.Text = "Сравнить людей";
            this.CompareStudents.Click += new System.EventHandler(this.CompareStudents_Click);
            // 
            // CloneStudent
            // 
            this.CloneStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloneStudent.Image = ((System.Drawing.Image)(resources.GetObject("CloneStudent.Image")));
            this.CloneStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloneStudent.Name = "CloneStudent";
            this.CloneStudent.Size = new System.Drawing.Size(23, 22);
            this.CloneStudent.Text = "Клонировать студента";
            this.CloneStudent.Click += new System.EventHandler(this.CloneStudent_Click);
            // 
            // DeleteMan
            // 
            this.DeleteMan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteMan.Image = ((System.Drawing.Image)(resources.GetObject("DeleteMan.Image")));
            this.DeleteMan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteMan.Name = "DeleteMan";
            this.DeleteMan.Size = new System.Drawing.Size(23, 22);
            this.DeleteMan.Text = "Удалить из списка";
            this.DeleteMan.Click += new System.EventHandler(this.DeleteMan_Click);
            // 
            // ClearList
            // 
            this.ClearList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearList.Image = ((System.Drawing.Image)(resources.GetObject("ClearList.Image")));
            this.ClearList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(23, 22);
            this.ClearList.Text = "Очистить список";
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(94, 20);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 447);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №8";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CompareStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripButton CloneStudent;
        private System.Windows.Forms.ToolStripButton DeleteMan;
        private System.Windows.Forms.ToolStripButton ClearList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox student;
        private System.Windows.Forms.CheckBox father;
        private System.Windows.Forms.TextBox nameMans;
        private System.Windows.Forms.Button CreateMan;
        private System.Windows.Forms.TextBox surnameMans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox middleNameMans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox fathersList;
    }
}

