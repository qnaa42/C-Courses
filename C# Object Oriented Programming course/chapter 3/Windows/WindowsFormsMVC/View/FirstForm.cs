using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMVC
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        public UserInfo UserInfo { get; set; }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = UserInfo.firstName;
            txtLastName.Text = UserInfo.lastName;
            txtEmailAdress.Text = UserInfo.emailAdress;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            UserInfo.firstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            UserInfo.lastName = txtLastName.Text;
        }

        private void txtEmailAdress_TextChanged(object sender, EventArgs e)
        {
            UserInfo.emailAdress = txtEmailAdress.Text;
        }
    }
}
