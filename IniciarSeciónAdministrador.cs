using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace a
{
    public partial class IniciarSeciónAdministrador : Form
    {
        bool cierreAd = false;
        public IniciarSeciónAdministrador()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperarContraseña rec_contr_Adm = new RecuperarContraseña();
            rec_contr_Adm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSecionEmpleado iniciarsecionemp = new IniciarSecionEmpleado();
            iniciarsecionemp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cierreAd = true;
            this.Hide();
            Form1 form= new Form1(cierreAd);
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cierreAd = true;
            this.Hide();
            Form1 form = new Form1(cierreAd);
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cierreAd = true;
            this.Hide();
            Form1 form = new Form1(cierreAd);
            form.ShowDialog();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    IniciarSecionEmpleado iniciarsecionemp = new IniciarSecionEmpleado();
        //    iniciarsecionemp.ShowDialog();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    cierreAd = true;
        //    this.Hide();
        //    Form1 form = new Form1(cierreAd);
        //    form.ShowDialog();
        //}
    }
}
