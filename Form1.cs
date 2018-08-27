using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrixFinale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrixInitial_Click(object sender, EventArgs e)
        {

        }

        private void InputPrix_TextChanged(object sender, EventArgs e)
        {
            float prixInitiale = float.Parse(InputPrix.Text);
            // calculer TPS
            float TPS = prixInitiale * 5f / 100;
            label1.Text = TPS.ToString();
            label1.Visible = true;
            // calculer TVQ
            float TVQ = TPS + (prixInitiale * 9.975f / 100);
            label2.Text = TVQ.ToString();
            label2.Visible = true;
        }

        private void TPS_Click(object sender, EventArgs e)
        {

        }

        private void TVQ_Click(object sender, EventArgs e)
        {

        }

        private void PrixFinale_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float prixInitiale = float.Parse(InputPrix.Text);
            float TPS = prixInitiale * 5f / 100;
            float TVQ = TPS + (prixInitiale * 9.975f / 100);
            float prix = prixInitiale + TPS + TVQ;
            //utiliser cet option si le produit quebecois
            
            if (ProduitQuebecois.Checked == true)
            {
                prix = prix - TVQ;
            }
            label3.Text = prix.ToString();
            label3.Visible = true;

            //MessageBox for continue or for exit the calc
            DialogResult dialog = MessageBox.Show(
             "Voulez vous continuez ou quittez le calcul. Pour quiter click Yes, pour continuer - No",
             "Calcul",
               MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:Form1.ActiveForm.Close();
                    break;
                case DialogResult.No: 
                    break;
            }

        }

        private void ProduitQuebecois_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
