using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectWithForms
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }


        public string ToppingsSummary()
        {

            string Toppings = "";

            if (chbExtraChees.Checked)
            {
                Toppings += "Extra Chees, ";
            }

            if (chbMushrooms.Checked)
            {
                Toppings += "Mushrooms, ";
            }

            if (chbTomatoes.Checked)
            {
                Toppings += "Tomatoes, ";
            }

            if (chbOnion.Checked)
            {
                Toppings += "Onion, ";
            }

            if (chbOlives.Checked)
            {
                Toppings += "Olives, ";
            }

            if (chbGreenPeppers.Checked)
            {
                Toppings += "GreenPeppers, ";
            }



            return Toppings;
        }

        public Double TotalPrice()
        {
            Double TotalPrice = 0;

            if (chbExtraChees.Checked)
            {
                TotalPrice += Convert.ToSingle(chbExtraChees.Tag);
            }

            if (chbMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chbMushrooms.Tag);
            }

            if (chbTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chbTomatoes.Tag);
            }

            if (chbOnion.Checked)
            {
                TotalPrice += 5;
            }

            if (chbOlives.Checked)
            {
                TotalPrice += 5;
            }

            if (chbGreenPeppers.Checked)
            {
                TotalPrice += 5;
            }

            if (rdbSmall.Checked)
            {
                TotalPrice += 30;
            }

            if (rdbMedium.Checked)
            {
                TotalPrice += 50;
            }

            if (rdbLarg.Checked)
            {
                TotalPrice += 60;
            }
            if (rdbThinkCrust.Checked)
            {
                TotalPrice += 10;
            }
            

            return TotalPrice;
        }

        public string Size()
        {
            string Size = "";

            if (rdbSmall.Checked)
            {
                Size = "Small";
            }

            if (rdbMedium.Checked)
            {
                Size = "Medium";
            }

            if (rdbLarg.Checked)
            {
                Size = "Larg";
            }


            return Size;
        }

        public string ThinOrThink() {

            string Thin = "";

            if (rdbThinCrust.Checked)
            {
                Thin = "Thin Crust";
            }

            if (rdbThinkCrust.Checked)
            {
                Thin = "Think Crust";
            }

            return Thin;
        }

        public void ResetOrder()
        {
            chbExtraChees.Checked = false;
            chbMushrooms.Checked = false;
            chbTomatoes.Checked = false;
            chbOlives.Checked = false;
            chbOnion.Checked = false;
            chbGreenPeppers.Checked = false;
            rdbSmall.Checked = true;
            rdbThinCrust.Checked = true;
            rdbTakeOut.Checked = true;
        }

       public void Toppings(bool b)
        {
            if (b)
            {
                txtTopping.Text = ToppingsSummary();
                lblTotalPrice.Text = TotalPrice().ToString();
            }
            else
            {
                txtTopping.Text = ToppingsSummary();
                lblTotalPrice.Text = TotalPrice().ToString();
            }
        }

        public void PizzaSize(bool b)
        {
            if (b)
            {
                txtSize.Text = Size();
                lblTotalPrice.Text = TotalPrice().ToString();
            }
            else
            {
                txtSize.Text = Size();
                lblTotalPrice.Text = TotalPrice().ToString();
            }
        }

        public void ThinCrust(bool b)
        {
            if (b)
            {
                txtCrustType.Text = ThinOrThink();
                lblTotalPrice.Text = TotalPrice().ToString();
            }
            else
            {
                txtCrustType.Text = ThinOrThink();
                lblTotalPrice.Text = TotalPrice().ToString();
            }
        }

        public void WhereToEat(bool b)
        {
            if (rdbEatin.Checked)
            {
                txtToEat.Text = "Eat In";
            }
            else if(rdbTakeOut.Checked) 
            {
                txtToEat.Text = "Take Out";
            }
        }






        private void frmPizza_Load(object sender, EventArgs e)
        {
            ResetOrder();
        }


        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            Toppings(chbExtraChees.Checked);
        }

        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            Toppings(chbMushrooms.Checked);
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Toppings(chbTomatoes.Checked);
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            Toppings(chbOnion.Checked);
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            Toppings(chbOlives.Checked);
        }

        private void chbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            Toppings(chbGreenPeppers.Checked);
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            PizzaSize(rdbSmall.Checked);
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            PizzaSize(rdbMedium.Checked);
        }

        private void rdbLarg_CheckedChanged(object sender, EventArgs e)
        {
            PizzaSize(rdbLarg.Checked);
        }

        private void rdbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            ThinCrust(rdbThinCrust.Checked);
        }

        private void rdbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            ThinCrust(rdbThinkCrust.Checked);
        }

        private void rdbEatin_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat(rdbEatin.Checked);
        }

        private void rdbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat(rdbTakeOut.Checked);
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetOrder();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure", "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show(TotalPrice().ToString(), "Total");
                ResetOrder();
            }
        }
    }
}
