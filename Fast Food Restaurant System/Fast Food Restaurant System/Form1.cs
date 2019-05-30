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
