using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azmera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel6.Visible = false;
            panel7.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(comboBox3.Text == "Shopkeeper")
            {
                shopKeepersCatalogue1.BringToFront();
                panel6.Visible = false;
            }
        }
    }
}
