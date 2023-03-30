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
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperarContraseña_Continuacion rec_contr_cont = new RecuperarContraseña_Continuacion();
            rec_contr_cont.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSecionEmpleado inicSecEmp = new IniciarSecionEmpleado();
            inicSecEmp.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RecuperarContraseña_Continuacion rec_contr_cont = new RecuperarContraseña_Continuacion();
            rec_contr_cont.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    RecuperarContraseña_Continuacion rec_contr_cont = new RecuperarContraseña_Continuacion();
        //    rec_contr_cont.ShowDialog();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    IniciarSecionEmpleado inicSecEmp = new IniciarSecionEmpleado();
        //    inicSecEmp.ShowDialog();
        //}
    }
}
