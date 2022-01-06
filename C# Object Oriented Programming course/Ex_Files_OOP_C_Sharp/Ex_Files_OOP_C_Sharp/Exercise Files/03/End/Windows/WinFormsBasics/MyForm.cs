using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBasics
{
    class MyForm : Form
    {
        public MyForm()
        {
            var btn = new Button();
            btn.Text = "Click Me!";
            btn.Top = 10;
            btn.Click += (s, e) => this.Close();

            this.Controls.Add(btn);
        }
    }
}
