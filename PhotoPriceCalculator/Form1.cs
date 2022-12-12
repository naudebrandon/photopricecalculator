using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoPriceCalculator
{
    public partial class Form1 : Form
    {
        Double CloseSizeSqrMM, ActualSizeSqrMM;
        Double CPrice, PriceSqrMM, APrice;
        //String sPrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            #region Check Inputs
            if (txtCSH.Text.Length < 1 || txtCSW.Text.Length < 1)
            {
                MessageBox.Show("Please enter the CLOSEST SIZE");
                return;
            }

            if (txtASH.Text.Length < 1 || txtASW.Text.Length < 1)
            {
                MessageBox.Show("Please enter the ACTUAL SIZE");
                return;
            }

            if (txtCSP.Text.Length < 1)
            {
                MessageBox.Show("Please enter the PRICE for the CLOSEST SIZE");
                return;
            }
            #endregion

            //Convert the Closest Size Width and Heigth to Square MM
            Double CSW = Double.Parse(txtCSW.Text);
            Double CSH = Double.Parse(txtCSH.Text);

            CloseSizeSqrMM = CSW * CSH;

            //Convert the Actual Size Width and Heigth to Square MM
            Double ASW = Double.Parse(txtASW.Text);
            Double ASH = Double.Parse(txtASH.Text);
            ActualSizeSqrMM = ASW * ASH;

            //Calculate the price per square mm of the closest size
            CPrice = double.Parse(txtCSP.Text);

            PriceSqrMM = (CPrice / CloseSizeSqrMM);

            //Calculate the Price of the actual size
            APrice = ActualSizeSqrMM * PriceSqrMM;

            lblPrintCost.Text = "R " + APrice.ToString("###0.00");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCSW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 048 && e.KeyChar <= 057 || e.KeyChar == 046 || e.KeyChar == 008)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 044)
            {
                e.Handled = true;
                MessageBox.Show("|,| is not a valid Decimal seperator use |.|");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid numerical value");
            }
        }

        private void txtCSH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 048 && e.KeyChar <= 057 || e.KeyChar == 046 || e.KeyChar == 008)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 044)
            {
                e.Handled = true;
                MessageBox.Show("|,| is not a valid Decimal seperator use |.|");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid numerical value");
            }
        }

        private void txtCSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 048 && e.KeyChar <= 057 || e.KeyChar == 046 || e.KeyChar == 008)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 044)
            {
                e.Handled = true;
                MessageBox.Show("|,| is not a valid Decimal seperator use |.|");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid numerical value");
            }
        }

        private void txtASW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 048 && e.KeyChar <= 057 || e.KeyChar == 046 || e.KeyChar == 008)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 044)
            {
                e.Handled = true;
                MessageBox.Show("|,| is not a valid Decimal seperator use |.|");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid numerical value");
            }
        }

        private void txtASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 048 && e.KeyChar <= 057 || e.KeyChar == 046 || e.KeyChar == 008)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 044)
            {
                e.Handled = true;
                MessageBox.Show("|,| is not a valid Decimal seperator use |.|");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid numerical value");
            }
        }
    }
}
