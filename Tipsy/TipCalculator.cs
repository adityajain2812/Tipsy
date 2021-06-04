using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipsy
{
    public partial class TIPSY : Form
    {
        //initializing variables 
        float Bill_Amt = 0;
        int Tip_Prcnt = 0;
        int Nbr_Pers = 1;
        float AmtPPers = 0;
        float Total_Amt = 0;
        float TipPPers = 0;
        float Total_Tip = 0;
        int Tip_Add;
        int Tip_Sub;
        int Pers_Add;
        int Pers_Sub;

        public TIPSY()
        {
            InitializeComponent();
            TipPP_label.Text = "0";
            TotalPP_Lbl.Text = "0";
            txt_peeps.Text = "1";
            txt_tip.Text = "0";
            txt_bill.Text = "0.00";
        }
        
        //This Method is use to fetch the Amount of Bill.
        private void Txt_Bill_TextChanged(object sender, EventArgs e)
        {
         
            try
            {
                Bill_Amt = float.Parse(txt_bill.Text);
            }
            catch(Exception)
            {
                Bill_Amt = 0;
            }
            Tip_Calculation();
        }

        //This Method is use to fetch the Tip Percentage.
        private void Txt_Tip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Tip_Prcnt = int.Parse(txt_tip.Text);
            }
            catch(Exception)
            {
                Tip_Prcnt = 0;
            }
            Tip_Calculation();
        }

        //This Method is use to fetch the number of persons.
        private void Txt_Peeps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Nbr_Pers = int.Parse(txt_peeps.Text);
            }
            catch (Exception)
            {
                Nbr_Pers = 1;
            }
            Tip_Calculation();

        }

        //This Method is use to Calculate the Tips per person and Total amount per person.
        public void Tip_Calculation()
        {
            if (Bill_Amt > 0 && Tip_Prcnt >= 0 && Nbr_Pers > 0)
            {
                Total_Tip = (Tip_Prcnt * Bill_Amt) / 100;
                TipPPers = Total_Tip / Nbr_Pers;
                TipPP_label.Text = Convert.ToString(TipPPers);

                Total_Amt = Bill_Amt + Total_Tip;
                AmtPPers = Total_Amt / Nbr_Pers;
                TotalPP_Lbl.Text = Convert.ToString(AmtPPers);
            }
            else
            {
                TipPP_label.Text = "0";
                TotalPP_Lbl.Text = "0";
            }
        }

        //This Method is use to add the percentage of tip.
        private void Tip_Addbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_tip.Text) < 100)
            {
                Tip_Add = int.Parse(txt_tip.Text) + 1;
                txt_tip.Text = Convert.ToString(Tip_Add);
            }
            else
                txt_tip.Text = "100";
        }

        //This Method is use to Substract the Tip percentage.
        private void Tip_Minusbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_tip.Text) > 0 )
            {
                Tip_Sub = int.Parse(txt_tip.Text) - 1;
                txt_tip.Text = Convert.ToString(Tip_Sub);
            }
            else
                txt_tip.Text = "0";
        }

        //This Method is use to add the number of persons.
        private void Pers_Addbtn_Click(object sender, EventArgs e)
        {
            Pers_Add = int.Parse(txt_peeps.Text) + 1;
            txt_peeps.Text = Convert.ToString(Pers_Add);
        }

        //This Method is use to Substact the number of persons.
        private void Pers_minusbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_peeps.Text) > 1)
            {
                Pers_Sub = int.Parse(txt_peeps.Text) - 1;
                txt_peeps.Text = Convert.ToString(Pers_Sub);
            }
            else
                txt_peeps.Text = "1";
        }
    }

}
