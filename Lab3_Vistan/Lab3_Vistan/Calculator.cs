using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Vistan
{

    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(EnterBox.Text);
            EnterBox.Clear();

            DeclareVariable.btnPlus = true;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMultiply = false;
            DeclareVariable.btnDivide = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (DeclareVariable.btnPlus == true)
            {
                EnterBox.Text = (DeclareVariable.total1 = DeclareVariable.total1 + double.Parse(EnterBox.Text)).ToString();
            }
            else if (DeclareVariable.btnMinus == true)
            {
                EnterBox.Text = (DeclareVariable.total1 = DeclareVariable.total1 - double.Parse(EnterBox.Text)).ToString();
            }
            else if (DeclareVariable.btnMultiply == true)
            {
                EnterBox.Text = (DeclareVariable.total1 = DeclareVariable.total1 * double.Parse(EnterBox.Text)).ToString();
            }
            else if (DeclareVariable.btnDivide == true)
            {
                EnterBox.Text = (DeclareVariable.total1 = DeclareVariable.total1 / double.Parse(EnterBox.Text)).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EnterBox.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(EnterBox.Text);
            EnterBox.Clear();

            DeclareVariable.btnPlus = false;
            DeclareVariable.btnMinus = true;
            DeclareVariable.btnMultiply = false;
            DeclareVariable.btnDivide = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(EnterBox.Text);
            EnterBox.Clear();

            DeclareVariable.btnPlus = false;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMultiply = true;
            DeclareVariable.btnDivide = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            DeclareVariable.total1 = Convert.ToDouble(EnterBox.Text);
            EnterBox.Clear();

            DeclareVariable.btnPlus = false;
            DeclareVariable.btnMinus = false;
            DeclareVariable.btnMultiply = false;
            DeclareVariable.btnDivide = true;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            EnterBox.Text = EnterBox.Text + ".";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void EnterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {

        }

    }
}
