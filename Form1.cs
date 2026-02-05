using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmMain : Form
    {

        int TotalPrice = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        float CalcSizePrice()
        {
            
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else { 
                return Convert.ToSingle(rbLarge.Tag);
            }
        }

        float CalcCrustPrice() {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else { 
                return Convert.ToSingle(rbThinkCrust.Tag);
            }
        }

        float ClacToppingsPrice() {
            float sum = 0;
            if (chkExtraChees.Checked)
            {
                sum += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkMashrooms.Checked)
            {
                sum += Convert.ToSingle(chkMashrooms.Tag);
            }
            if (chkTomiatos.Checked)
            {
                sum += Convert.ToSingle(chkTomiatos.Tag);
            }
            if (chkOnion.Checked)
            {
                sum += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkOlives.Checked)
            {
                sum += Convert.ToSingle(chkOlives.Tag);
            }
            if(chkGreenPeppers.Checked) {
                sum += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return sum;
        }

        float CalcWherePrice() {
            if (rbEatIn.Checked)
            {
                return Convert.ToSingle(rbEatIn.Tag);
            }
            else { 
                return Convert.ToSingle(rbTakeOut.Tag);
            }
        }

        float CalcTotal() { 
            return CalcSizePrice() + CalcCrustPrice() + ClacToppingsPrice() + 
                CalcWherePrice();
        }
        void UpdateTotalPrice() {
            float x;
            float.TryParse(numericUpDown1.Value.ToString(), out x);
            lbPrice.Text = "$" + (CalcTotal()*x).ToString() ;
        }

        void UpdateSize() {

            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lbSize.Text = rbSmall.Text;
                return;
            }
            else if (rbMedium.Checked)
            {
                lbSize.Text = rbMedium.Text;
                return;
            }
            else {
                lbSize.Text = rbLarge.Text;
                return;
            }
        }

        void RemoveToppings() {
            if (!chkExtraChees.Checked)
            {
                lbExtraChees.Visible = chkExtraChees.Checked;
            }
            if (!chkMashrooms.Checked)
            {
                lbMashrooms.Visible = chkMashrooms.Checked;
            }
            if (!chkTomiatos.Checked)
            {
                lbTomatos.Visible = chkTomiatos.Checked;
            }
            if (!chkOnion.Checked)
            {
                lbOnion.Visible = chkOnion.Checked;
            }
            if (!chkOlives.Checked)
            {
                lbOlives.Visible = chkOlives.Checked;
            }
            if (!chkGreenPeppers.Checked)
            {
                lbGreenPeppers.Visible = chkGreenPeppers.Checked;
            }
        }
        void UpdateToppings() { 
            UpdateTotalPrice();
            if (chkExtraChees.Checked)
            {
                lbExtraChees.Visible = chkExtraChees.Checked;
            }
            if (chkMashrooms.Checked)
            {
                lbMashrooms.Visible = chkMashrooms.Checked;
            }
            if (chkTomiatos.Checked)
            {
                lbTomatos.Visible = chkTomiatos.Checked;
            }
            if (chkOnion.Checked)
            {
                lbOnion.Visible = chkOnion.Checked;
            }
            if (chkOlives.Checked)
            {
                lbOlives.Visible = chkOlives.Checked;
            }
            if (chkGreenPeppers.Checked){ 
                lbGreenPeppers.Visible = chkGreenPeppers.Checked;
            }
        }

        void UpdateCrust()
        {

            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lbCrustType.Text = rbThinCrust.Text;
                return;
            }
            else if (rbThinkCrust.Checked)
            {
                lbCrustType.Text = rbThinkCrust.Text;
                return;
            }
            
        }

        void UpdateWhere()
        {

            UpdateTotalPrice();
            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text = rbEatIn.Text;
                return;
            }
            else 
            {
                lbWhereToEat.Text = rbTakeOut.Text;
                return;
            }

        }

        void UpdateSummary() {
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;
        }
        


        //private void TotalPriceChange(bool flag,int sum) {
        //    if (flag)
        //    {
        //        TotalPrice += sum;
        //        lbPrice.Text = TotalPrice.ToString();

        //    }
        //    else {
        //        TotalPrice -= sum;
        //        lbPrice.Text = TotalPrice.ToString();

        //    }
        //}

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            
          //  TotalPriceChange(rbLarge.Checked, 40);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            
           // TotalPriceChange(rbMedium.Checked, 30);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateToppings();
            RemoveToppings();
            // TotalPriceChange(chkMashrooms.Checked, 5);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateToppings();
            RemoveToppings();
           // TotalPriceChange(chkExtraChees.Checked, 6);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            RemoveToppings();
            // TotalPriceChange(chkTomiatos.Checked, 4);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            RemoveToppings();
            // TotalPriceChange(chkGreenPeppers.Checked, 1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhere();
            // TotalPriceChange(rbTakeOut.Checked, 5);
        }

        private void btnOrderPizza_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "Confirm", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                ResetB();
                MessageBox.Show("Your Order Have been confirmed", "Done");
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        void ResetB() {
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            chkExtraChees.Checked = false;
            chkMashrooms.Checked = false;
            chkTomiatos.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;
            rbEatIn.Checked = true;
            numericUpDown1.Value = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetB();
        }

        private void btnOrderPizza_MouseEnter_1(object sender, EventArgs e)
        {
            btnOrderPizza.Size = new System.Drawing.Size(120, 58);
        }

        private void btnOrderPizza_MouseLeave(object sender, EventArgs e)
        {
            btnOrderPizza.Size = new System.Drawing.Size(110, 48);
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.Size = new System.Drawing.Size(120, 58);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.Size = new System.Drawing.Size(110, 48);
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
           // TotalPriceChange(rbSmall.Checked, 20);
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
           // TotalPriceChange(rbThinCrust.Checked, 5);
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            // TotalPriceChange(rbThinkCrust.Checked, 10);
        }

        private void lbExtraChees_Click(object sender, EventArgs e)
        {

        }

        private void lbMashrooms_Click(object sender, EventArgs e)
        {

        }

        private void lbOnion_Click(object sender, EventArgs e)
        {

        }

        private void lbOlives_Click(object sender, EventArgs e)
        {

        }

        private void lbGreenPeppers_Click(object sender, EventArgs e)
        {

        }

        private void lbSize_Click(object sender, EventArgs e)
        {

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            RemoveToppings();
            // TotalPriceChange(chkOnion.Checked, 3);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            RemoveToppings();
            //  TotalPriceChange(chkOlives.Checked, 2);
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhere();
           // TotalPriceChange(rbEatIn.Checked, 0);
        }

        private void lbSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
