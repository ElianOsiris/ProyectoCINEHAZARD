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
    public partial class Form3 : Form
    {
        bool Cierre = false;
        bool cierreAd = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) 
            {
                Cierre = true;
                this.Hide();
                Form2Copia form2 = new Form2Copia(Cierre);
                form2.ShowDialog();
            }
            if (radioButton2.Checked == true)
            {
                cierreAd = true;
                this.Hide();
                Form1 form = new Form1(cierreAd);
                form.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                RecuperarContraseña rec_contr = new RecuperarContraseña();
                rec_contr.ShowDialog();
            
            
            
        }
    }
}
