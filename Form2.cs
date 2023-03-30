using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    public partial class Form2 : Form
    {
        bool Cierre2;
        public Form2(bool Cierre2)
        {
            InitializeComponent();
            this.Cierre2= Cierre2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 3;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 4;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 4;
        }
    }
}
