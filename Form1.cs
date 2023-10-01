using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckboxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbNarudzba_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSakrij.Checked == false) {

                tbNarudzba.Visible = true;
            }
            if (cbSakrij.Checked == true)
            {

                tbNarudzba.Visible = false;
            }

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            tbNarudzba.Text = "Odabrali ste:";

            if (cbDorucak.Checked == true)
            {
                tbNarudzba.Text = tbNarudzba.Text + Environment.NewLine + cbDorucak.Text;
            }

            if (cbRucak.Checked == true)
            {
                tbNarudzba.Text = tbNarudzba.Text + Environment.NewLine + cbRucak.Text;
            }
            

            if (cbVecera.Checked == true)
            {
                tbNarudzba.Text = tbNarudzba.Text + Environment.NewLine + cbVecera.Text;
            }
            
        }

        private void cbDorucak_CheckedChanged(object sender, EventArgs e)
        {
            
                

        }

        private void cbRucak_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
