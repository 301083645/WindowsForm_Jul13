using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Jul13
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void ClickMeBtn_Click(object sender, EventArgs e)
        {
            if (WelcomeLabel.Text == "Hello, World!")
            {
                WelcomeLabel.Text = "Clicked!";
            }
            else
            {

                WelcomeLabel.Text = "Hello, World!";

            }
            
        }
    }
}
