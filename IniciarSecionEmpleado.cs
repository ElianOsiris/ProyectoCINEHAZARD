using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace a
{
    public partial class IniciarSecionEmpleado : Form
    {
        bool Cierre = false;
        public IniciarSecionEmpleado()
        {
            InitializeComponent();
            
        }

        private void IniciarSecionEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperarContraseña rec_contr = new RecuperarContraseña();
            rec_contr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cierre = true;
            this.Hide();
            Form2 form2 = new Form2(Cierre);
            form2.ShowDialog();
            //tabControl1.SelectedIndex = 12;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSeciónAdministrador inic_sec_adm = new IniciarSeciónAdministrador();
            inic_sec_adm.ShowDialog();
        }

        private void jjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cierre = true;
            this.Hide();
            Form2 form2 = new Form2(Cierre);
            form2.ShowDialog();
            //tabControl1.SelectedIndex = 12;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSeciónAdministrador inic_sec_adm = new IniciarSeciónAdministrador();
            inic_sec_adm.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    
        //}
    }
}
