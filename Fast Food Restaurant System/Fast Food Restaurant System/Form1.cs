using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Restaurant_System
{
    public partial class Form1 : Form
    {

        const double Price_CocaCola = 1.99;
        const double Price_Tea = 1.49;
        const double Price_BottleWater = 1.99;
        const double Price_AppleJuice = 2.49;
        const double Price_Coffee = 3.99;
        const double Price_IceCream = 1.79;
        const double Price_PineappleCake = 4.99;
        const double Price_MilkShake = 3.69;
        const double Price_ChocolateMuffin = 3.49;
        const double Price_ComboMenu = 12.99;
        const double Price_KnightMenu = 13.49;
        const double Price_WingsFestival = 11.99;
        const double Price_ChildrensMenu = 9.99;
        const double Price_RoyalMenu = 15.99;
        const double Price_Humburger = 2.99;
        const double Price_CheeseBurger = 3.39;
        const double Price_BaconBurger = 3.99;
        const double Price_Steak = 4.49;
        const double Price_MeatPie = 4.99;
        const double Price_VegeterianSalad = 3.79;
        const double Price_MeatSalad = 3.89;
        const double Price_Fries = 2.99;
        const double Price_Nuggets = 3.99;
        const double Price_HotDog = 2.89;
        const double Tax_Rate = 1;

        double iTax, iSubTotal, iTotal;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" ");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Debit Card");

            EnableTextBoxes();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit the program", "Royal Buffet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        //-------------------------------------------------RestTextBoxes()-------------------------------------------------------------------------\\
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void RestMaskedTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                        (control as MaskedTextBox).Text = " ";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }



        //-------------------------------------------------RestCheckBoxes()-------------------------------------------------------------------------\\
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void Reset(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
            RestMaskedTextBoxes();
        }


        //------------------------------------------------EnableTextBoxes()-------------------------------------------------------------------------\\
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //------------------------------------------------CheckedChanged-------------------------------------------------------------------------\\

        private void HumBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (HumBurger.Checked == true)

            {
                txtHumBurger.Enabled = true;
                txtHumBurger.Text = " ";
                txtHumBurger.Focus();

            }
            else
            {
                txtHumBurger.Enabled = false;
                txtHumBurger.Text = "0";
            }
        }

        private void CheeseBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseBurger.Checked == true)

            {
                txtCheeseBurger.Enabled = true;
                txtCheeseBurger.Text = " ";
                txtCheeseBurger.Focus();

            }
            else
            {
                txtCheeseBurger.Enabled = false;
                txtCheeseBurger.Text = "0";
            }
        }

        private void BaconBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (BaconBurger.Checked == true)

            {
                txtBaconBurger.Enabled = true;
                txtBaconBurger.Text = " ";
                txtBaconBurger.Focus();

            }
            else
            {
                txtBaconBurger.Enabled = false;
                txtBaconBurger.Text = "0";
            }
        }

        private void Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (Steak.Checked == true)

            {
                txtSteak.Enabled = true;
                txtSteak.Text = " ";
                txtSteak.Focus();

            }
            else
            {
                txtSteak.Enabled = false;
                txtSteak.Text = "0";
            }
        }

        private void MeatPie_CheckedChanged(object sender, EventArgs e)
        {
            if (MeatPie.Checked == true)

            {
                txtMeatPie.Enabled = true;
                txtMeatPie.Text = " ";
                txtMeatPie.Focus();

            }
            else
            {
                txtMeatPie.Enabled = false;
                txtMeatPie.Text = "0";
            }
        }

        private void VegeterianSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (VegeterianSalad.Checked == true)

            {
                txtVegeterianSalad.Enabled = true;
                txtVegeterianSalad.Text = " ";
                txtVegeterianSalad.Focus();

            }
            else
            {
                txtVegeterianSalad.Enabled = false;
                txtVegeterianSalad.Text = "0";
            }
        }

        private void MeatSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (MeatSalad.Checked == true)

            {
                txtMeatSalad.Enabled = true;
                txtMeatSalad.Text = " ";
                txtMeatSalad.Focus();

            }
            else
            {
                txtMeatSalad.Enabled = false;
                txtMeatSalad.Text = "0";
            }
        }

        private void Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (Fries.Checked == true)

            {
                txtFries.Enabled = true;
                txtFries.Text = " ";
                txtFries.Focus();

            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void Nuggets_CheckedChanged(object sender, EventArgs e)
        {
            if (Nuggets.Checked == true)

            {
                txtNuggets.Enabled = true;
                txtNuggets.Text = " ";
                txtNuggets.Focus();

            }
            else
            {
                txtNuggets.Enabled = false;
                txtNuggets.Text = "0";
            }
        }

        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDog.Checked == true)

            {
                txtHotDog.Enabled = true;
                txtHotDog.Text = " ";
                txtHotDog.Focus();

            }
            else
            {
                txtHotDog.Enabled = false;
                txtHotDog.Text = "0";
            }
        }

        private void ComboMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboMenu.Checked == true)

            {
                txtComboMenu.Enabled = true;
                txtComboMenu.Text = " ";
                txtComboMenu.Focus();

            }
            else
            {
                txtComboMenu.Enabled = false;
                txtComboMenu.Text = "0";
            }
        }

        private void KnightMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (KnightMenu.Checked == true)

            {
                txtKnightMenu.Enabled = true;
                txtKnightMenu.Text = " ";
                txtKnightMenu.Focus();

            }
            else
            {
                txtKnightMenu.Enabled = false;
                txtKnightMenu.Text = "0";
            }
        }

        private void WingsFestival_CheckedChanged(object sender, EventArgs e)
        {
            if (WingsFestival.Checked == true)

            {
                txtWingsFestival.Enabled = true;
                txtWingsFestival.Text = " ";
                txtWingsFestival.Focus();

            }
            else
            {
                txtWingsFestival.Enabled = false;
                txtWingsFestival.Text = "0";
            }
        }

        private void ChildrensMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (ChildrensMenu.Checked == true)

            {
                txtChildrensMenu.Enabled = true;
                txtChildrensMenu.Text = " ";
                txtChildrensMenu.Focus();

            }
            else
            {
                txtChildrensMenu.Enabled = false;
                txtChildrensMenu.Text = "0";
            }
        }

        private void RoyalMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (RoyalMenu.Checked == true)

            {
                txtRoyalMenu.Enabled = true;
                txtRoyalMenu.Text = " ";
                txtRoyalMenu.Focus();

            }
            else
            {
                txtRoyalMenu.Enabled = false;
                txtRoyalMenu.Text = "0";
            }
        }

        private void BottleWater_CheckedChanged(object sender, EventArgs e)
        {
            if (BottleWater.Checked == true)

            {
                txtBottlewater.Enabled = true;
                txtBottlewater.Text = " ";
                txtBottlewater.Focus();

            }
            else
            {
                txtBottlewater.Enabled = false;
                txtBottlewater.Text = "0";
            }
        }

        private void Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea.Checked == true)

            {
                txtTea.Enabled = true;
                txtTea.Text = " ";
                txtTea.Focus();

            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void AppleJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (AppleJuice.Checked == true)

            {
                txtAppleJuice.Enabled = true;
                txtAppleJuice.Text = " ";
                txtAppleJuice.Focus();

            }
            else
            {
                txtAppleJuice.Enabled = false;
                txtAppleJuice.Text = "0";
            }
        }

        private void Coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (Coffee.Checked == true)

            {
                txtCoffee.Enabled = true;
                txtCoffee.Text = " ";
                txtCoffee.Focus();

            }
            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola.Checked == true)

            {
                txtCocaCola.Enabled = true;
                txtCocaCola.Text = " ";
                txtCocaCola.Focus();

            }
            else
            {
                txtCocaCola.Enabled = false;
                txtCocaCola.Text = "0";
            }
        }

        private void IceCream_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCream.Checked == true)

            {
                txtIceCream.Enabled = true;
                txtIceCream.Text = " ";
                txtIceCream.Focus();

            }
            else
            {
                txtIceCream.Enabled = false;
                txtIceCream.Text = "0";
            }
        }

        private void PineappleCake_CheckedChanged(object sender, EventArgs e)
        {
            if (PineappleCake.Checked == true)

            {
                txtPineappleCake.Enabled = true;
                txtPineappleCake.Text = " ";
                txtPineappleCake.Focus();

            }
            else
            {
                txtPineappleCake.Enabled = false;
                txtPineappleCake.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                txtPaymentType.Enabled = true;
                txtPaymentType.Text = "";
                txtPaymentType.Focus();
            }
            else
            {
                txtPaymentType.Enabled = false;
                txtPaymentType.Text = "0";
            }
        }

        private void Total_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[24];
            itemcost[0] = Convert.ToDouble(txtHumBurger.Text) * Price_Humburger;
            itemcost[1] = Convert.ToDouble(txtCheeseBurger.Text) * Price_CheeseBurger;
            itemcost[2] = Convert.ToDouble(txtBaconBurger.Text) * Price_BaconBurger;
            itemcost[3] = Convert.ToDouble(txtSteak.Text) * Price_Steak;
            itemcost[4] = Convert.ToDouble(txtMeatPie.Text) * Price_MeatPie;
            itemcost[5] = Convert.ToDouble(txtVegeterianSalad.Text) * Price_VegeterianSalad;
            itemcost[6] = Convert.ToDouble(txtMeatSalad.Text) * Price_MeatSalad;
            itemcost[7] = Convert.ToDouble(txtFries.Text) * Price_Fries;
            itemcost[8] = Convert.ToDouble(txtNuggets.Text) * Price_Nuggets;
            itemcost[9] = Convert.ToDouble(txtHotDog.Text) * Price_HotDog;
            itemcost[10] = Convert.ToDouble(txtComboMenu.Text) * Price_ComboMenu;
            itemcost[11] = Convert.ToDouble(txtKnightMenu.Text) * Price_KnightMenu;
            itemcost[12] = Convert.ToDouble(txtWingsFestival.Text) * Price_WingsFestival;
            itemcost[13] = Convert.ToDouble(txtChildrensMenu.Text) * Price_ChildrensMenu;
            itemcost[14] = Convert.ToDouble(txtRoyalMenu.Text) * Price_RoyalMenu;
            itemcost[15] = Convert.ToDouble(txtBottlewater.Text) * Price_BottleWater;
            itemcost[16] = Convert.ToDouble(txtTea.Text) * Price_Tea;
            itemcost[17] = Convert.ToDouble(txtAppleJuice.Text) * Price_AppleJuice;
            itemcost[18] = Convert.ToDouble(txtCoffee.Text) * Price_Coffee;
            itemcost[19] = Convert.ToDouble(txtCocaCola.Text) * Price_CocaCola;
            itemcost[20] = Convert.ToDouble(txtIceCream.Text) * Price_IceCream;
            itemcost[21] = Convert.ToDouble(txtPineappleCake.Text) * Price_PineappleCake;
            itemcost[22] = Convert.ToDouble(txtMilkShake.Text) * Price_MilkShake;
            itemcost[23] = Convert.ToDouble(txtChocolateMuffin.Text) * Price_ChocolateMuffin;

            double cost, ichange;

            if (comboBox1.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5]
                    + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11]
                    + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17]
                    + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21] + itemcost[22] + itemcost[23];

                txtSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                txtTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);

                ichange = Convert.ToDouble(txtPaymentType.Text);
                cost = ichange - (iTax + iTotal);
                txtChange.Text = Convert.ToString(cost);

                txtChange.Text = string.Format("{0:C}", cost);
                txtTax.Text = string.Format("{0:C}", iTax);
                txtSubTotal.Text = string.Format("{0:C}", iSubTotal);
                txtTotal.Text = string.Format("{0:C}", iTotal);

            }

            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5]
                   + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11]
                   + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17]
                   + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21] + itemcost[22] + itemcost[23];

                txtSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                txtTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);




                txtTax.Text = string.Format("{0:C}", iTax);
                txtSubTotal.Text = string.Format("{0:C}", iSubTotal);
                txtTotal.Text = string.Format("{0:C}", iTotal);
            }


        }

        private void txtPaymentType_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MilkShake_CheckedChanged(object sender, EventArgs e)
        {
            if (MilkShake.Checked == true)

            {
                txtMilkShake.Enabled = true;
                txtMilkShake.Text = " ";
                txtMilkShake.Focus();

            }
            else
            {
                txtMilkShake.Enabled = false;
                txtMilkShake.Text = "0";
            }
        }

        

        private void ChocolateMuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateMuffin.Checked == true)

            {
                txtChocolateMuffin.Enabled = true;
                txtChocolateMuffin.Text = " ";
                txtChocolateMuffin.Focus();

            }
            else
            {
                txtChocolateMuffin.Enabled = false;
                txtChocolateMuffin.Text = "0";
            }
        }
    }


    
}
