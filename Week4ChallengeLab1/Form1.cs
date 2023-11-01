using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4ChallengeLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double NetCalculator(int x)
        {
            double num;
            double num1;
            if (x <=199)
            {
                num= x * 1.20;
                if(num > 400)
                {
                    num1 = 0.15 * num;
                    num = num + num1;
                    return num;
                }
                return num;
            }
            if (x>=200 && x <= 399)
            {
                num = x * 1.50;
                if (num > 400)
                {
                    num1=  0.15 *num;
                    num = num + num1;
                    return num;
                }
                return num;
            }
            if (x >= 400 && x <= 599)
            {
                num = x * 1.80;
                if (num > 400)
                {
                    num1 = 0.15 * num;
                    num = num + num1;
                    return num;
                }
                return num;
            }
            if (x >= 600)
            {
                num = x * 2.00;
                if (num > 400)
                {
                    num1 = 0.15* num;
                    num = num +num1;
                    return num;

                }
                else
                {
                    return num;
                }
                
            }
            else
                return 0;
        }
        public static double SurchargeCalculator(double x)
        {
            double num;
            if (x >200 &&  x <= 399)
            {
                num = 1.50* x;
                if (num > 400)
                {
                    num = 0.15 * num;
                    return num;
                }
                else
                    return 0;
            }
            if (x >= 400 && x <= 599)
            {
                num = x * 1.80;
                if (num > 400)
                {
                    num = 0.15 * num;
                }
                return num;
            }
            if (x >= 600)
            {
                num = x * 2.00;
                if (num > 400)
                {
                    num = 0.15 * num;
                    
                    return num;

                }
                else
                {
                    return num;
                }

            }
            else
                return 0;
        }
        public static double AmountCalculator(double x)
        {
            double num;
            double num1;
            if (x <= 199)
            {
                num = x * 1.20;
                return num;
            }
            if (x >= 200 && x <= 399)
            {
                num = x * 1.50;
                return num;
            }
            if (x >= 400 && x <= 599)
            {
                num = x * 1.80;
                return num;
            }
            if (x >= 600)
            {
                num = x * 2.00;
                return num;

            }
            else
                return 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRedo.Visible = false;
            pb1.Visible = false;
            retxtSur.Visible = false;
            groupBox1.Visible = false;
            lblNoSur.Visible = false;
            lblexit.Visible = false;
            btnexit.Visible = false;
            label4.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int.Parse(txtUnits.Text);
            double x = NetCalculator(int.Parse(txtUnits.Text));
            retxtNet.Text = x.ToString();
            double y = SurchargeCalculator(int.Parse(txtUnits.Text));
            retxtSur.Text = y.ToString();
            double z = AmountCalculator(int.Parse(txtUnits.Text));
            retxtAmt.Text = z.ToString();
            if (int.Parse(retxtSur.Text) == 0)
            {
                retxtAmt.Visible = false;
                lblAmt2.Visible = false;
                retxtSur.Visible = false;
                lblNoSur.Visible = true;
                lblSur.Visible = false;
            }
            
            else 
            { 
                retxtAmt.Visible = true;
                lblAmt2.Visible = true;
                lblSur.Visible = true;
                retxtSur.Visible = true;
                lblNoSur.Visible = false;
            }
            pb1.Visible = true;
            label2.Visible = false;
            txtUnits.Visible = false;
            groupBox1.Visible = true;
            btnCalc.Visible = false;
            btnRedo.Visible = true;
            lblexit.Visible = true;
            btnexit.Visible = true;
            label4.Visible = true;
        }

        #region MyRegion
        private void txtUnits_TextChanged(object sender, EventArgs e)
        {

        }

        private void retxtSur_Validating(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retxtNet_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtUnits_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtUnits.Text, out int value))
            {
                MessageBox.Show("ENTER ONLY NUMBERS!");
                e.Cancel = true;
                txtUnits.Clear();

            }
        }

        private void lblNoSur_Click(object sender, EventArgs e)
        {

        }

        private void retxtSur_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSur_Click(object sender, EventArgs e)
        {

        }

        private void lblNet_Click(object sender, EventArgs e)
        {

        }

        private void retxtAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtUnits.Clear();
            pb1.Visible = false;
            groupBox1.Visible = false;
            txtUnits.Visible = true;
            btnCalc.Visible = true;
            label2.Visible = true;
            btnexit.Visible = false;
            lblexit.Visible = false;
            label4.Visible = false;
            btnRedo.Visible = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
