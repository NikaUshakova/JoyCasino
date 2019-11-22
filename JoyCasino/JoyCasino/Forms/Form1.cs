using JoyCasino.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyCasino
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            this.Hide();
            var menu = new MenuForm();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
