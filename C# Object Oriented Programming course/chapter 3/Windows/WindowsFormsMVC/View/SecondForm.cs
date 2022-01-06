using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMVC.View
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }
        public UserInfo userInfo { get; set; }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            userInfo.firstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            userInfo.lastName = txtLastName.Text;
        }

        private void txtEmailAdress_TextChanged(object sender, EventArgs e)
        {
            userInfo.emailAdress = txtEmailAdress.Text;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = userInfo.firstName;
            txtLastName.Text = userInfo.lastName;
            txtEmailAdress.Text = userInfo.emailAdress;
        }
    }
}
