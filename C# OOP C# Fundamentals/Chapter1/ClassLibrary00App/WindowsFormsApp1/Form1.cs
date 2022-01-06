using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary00;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogic_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.name = textName.Text;
            testSchool.adress = textAdress.Text;
            testSchool.city = textCity.Text;
            testSchool.schoolZip = textZip.Text;
            testSchool.phoneNumber = textPhoneNumber.Text;
            try
            {
                testSchool.twitterAddress = textTwitter.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());

            var teacher = new Teacher();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAvarage();
            MessageBox.Show("the grade avarage is " + gp);
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAvarage();
            MessageBox.Show("the grade avarage is " + gp);
        }
    }
}
