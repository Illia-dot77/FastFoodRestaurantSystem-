using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fast_Food_Restaurant_System
{
    /** class Form1
        version 1.0


     
     */
    public partial class Form1 : Form
    {
        /**Zmienna do połączenia do bazy danych SQL*/
        private SQLiteConnection sqlconn;
        /** Zmienna do wykonywania poleceń SQL*/
        private SQLiteCommand sqlCmd;
        /** Zmienna do tworzenia tabeli w bazie danych*/
        private DataTable sqlDT = new DataTable();
        /**Zmienna służąca do przechowywania danych */
        private DataSet DS = new DataSet();
        /**Zmienna służąca do uzupełniania DataSet danymi*/
        private SQLiteDataAdapter DB;
        /** Pole zawierujące wartość obiekta CocaCola*/
        const double Price_CocaCola = 1.99;
        /** Pole zawierujące wartość obiekta Tea*/
        const double Price_Tea = 1.49;
        /** Pole zawierujące wartość obiekta BottleWater*/
        const double Price_BottleWater = 1.99;
        /** Pole zawierujące wartość obiekta AppleJuice*/
        const double Price_AppleJuice = 2.49;
        /** Pole zawierujące wartość obiekta Coffee*/
        const double Price_Coffee = 3.99;
        /** Pole zawierujące wartość obiekta IceCream*/
        const double Price_IceCream = 1.79;
        /** Pole zawierujące wartość obiekta PineappleCake*/
        const double Price_PineappleCake = 4.99;
        /** Pole zawierujące wartość obiekta MilkShake*/
        const double Price_MilkShake = 3.69;
        /** Pole zawierujące wartość obiekta Muffin*/
        const double Price_ChocolateMuffin = 3.49;
        /** Pole zawierujące wartość obiekta ComboMenu*/
        const double Price_ComboMenu = 12.99;
        /** Pole zawierujące wartość obiekta KnightMenu*/
        const double Price_KnightMenu = 13.49;
        /** Pole zawierujące wartość obiekta WingsFestival*/
        const double Price_WingsFestival = 11.99;
        /** Pole zawierujące wartość obiekta ChildrensMenu*/
        const double Price_ChildrensMenu = 9.99;
        /** Pole zawierujące wartość obiekta RoyalMenu*/
        const double Price_RoyalMenu = 15.99;
        /** Pole zawierujące wartość obiekta Humburger*/
        const double Price_Humburger = 2.99;
        /** Pole zawierujące wartość obiekta CheeseBurger*/
        const double Price_CheeseBurger = 3.39;
        /** Pole zawierujące wartość obiekta BaconBurger*/
        const double Price_BaconBurger = 3.99;
        /** Pole zawierujące wartość obiekta Steak*/
        const double Price_Steak = 4.49;
        /** Pole zawierujące wartość obiekta MeatPie*/
        const double Price_MeatPie = 4.99;
        /** Pole zawierujące wartość obiekta VegeterianSalad*/
        const double Price_VegeterianSalad = 3.79;
        /** Pole zawierujące wartość obiekta MeatSalad*/
        const double Price_MeatSalad = 3.89;
        /** Pole zawierujące wartość obiekta Fries*/
        const double Price_Fries = 2.99;
        /** Pole zawierujące wartość obiekta Nuggets*/
        const double Price_Nuggets = 3.99;
        /** Pole zawierujące wartość obiekta HotDog*/
        const double Price_HotDog = 2.89;
        /** Pole zawierujące wartość obiekta Tax*/
        const double Tax_Rate = 2.8;
        /** Pole zawierujące zmienne wykrzystywane w funkcji obliczenia Change, Total, SubTotal oraz Tax*/
        double iTax, iSubTotal, iTotal;




        public Form1()
        {
            InitializeComponent();
        }

        /**
           \brief Główną funkcję aplikacji, która zawiera inne funkcje 
           \version 0.4
           \param object sender
           \param EventArgs e
           \return void

             Funkcja zawiera w sobie funkcji deaktywacji pól tekstowych oraz funkcji zapisywania danych do bazy danych, a także liste metody płatności.
         
           
         */
        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Debit Card");

            EnableTextBoxes();
            LoadData();
        }

        /**
          \brief Funkcja, która łączy bazę danych do aplikacji 
          \version 0.2
          \param "Data Source = Orders.db"
          \return void

            Funkcja opisuje ścieżkę do znalezienia połączonej z programem bazy danych.
        
          
        */
        public void SetConnection()
        {
            sqlconn = new SQLiteConnection("Data Source = Orders.db");
        }

        /**
           \brief Funkcja wykonuje zapytania SQL bezpośrednio w bazie danych 
           \version 0.2
           \param string OrdersIDq
           \return void

             Algorytm mapowania kolumn. Przyjmuje argument typu string pod nazwa OdersIDq
         
           
         */
        public void ExecuteQuery(string OrdersIDq)
        {
            SetConnection();
            sqlconn.Open();
            sqlCmd = sqlconn.CreateCommand();
            sqlCmd.CommandText = OrdersIDq;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            sqlconn.Close();
        }

        /**
           \brief Funkcja wykonuje zapytania SQL bezpośrednio w bazie danych 
           \version 0.2
           \param none
           \return void

            Funkcja wykonuje polecenie SELECT.
         
           
         */
        public void LoadData()
        {
            SetConnection();
            sqlconn.Open();
            sqlCmd = sqlconn.CreateCommand();
            string CommandText = "select * from Orders";
            DB = new SQLiteDataAdapter(CommandText, sqlconn);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            dataGridView1.DataSource = sqlDT;
            sqlconn.Close();
        }

        /**
           \brief Funkcja do  do wyjścia z aplikacji 
           \version 0.2
           \param object sender
           \param EventArgs e
           \return void

             Funkcja wyświetla komunikat wyboru do wyjścia z aplikacji.
         
           
         */
        public void Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to Exit", "Restaurant System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        /**
           \brief Funkcja do analowania pół tekstowych
           \version 0.1
           \param none
           \return void

             Funkcja analuje wszystkie wartości wv polach tekstowych.
         
           
         */
        public void RestTextBoxes()
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

        /**
           \brief Funkcja do analowania zamaskowanych combo boxów 
           \version 0.1
           \param none
           \return void

             Funkcja analuje wszystkie wartości w zamaskowanych combo boxach, które odpowiednio należą różnym danym wyjściowym .
         
           
         */
        public void RestMaskedTextBoxes()
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

        /**
           \brief Funkcja do analowania combo boxów  
           \version 0.1
           \param none
           \return void

             Funkcja analuje wszystkie wartości w combo boxach, które odpowiednio należą różnym metodam płatności.
         
           
         */
        public void RestComboBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).Text = "";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }



        /**
           \brief Funkcja do analowania pół wyboru 
           \version 0.1
           \param none
           \return void

             Funkcja analuje wszystkie wartości w polach tekstowych, które odpowiednio należą różnym daniam.
         
           
         */
        public void RestCheckBoxes()
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

        /**
          \brief Funkcja wywolująca inne funkcji analowania pół tekstowych
          \version 0.1
          \param object sender 
          \param EventArgs e
          \return void

            Funkcja jest związaną z przyciskiem Reset, wywoluje funkcji analowania pół tekstowych, analowania combo boxów, polach wyboru. 
        
         
        */
        public void Reset(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
            RestMaskedTextBoxes();
            RestComboBoxes();
        }

        
        /**
          \brief Funkcja do deaktywacji pól tekstowych
          \version 0.2
          \param None
          \return void

            Funkcja deaktywuje wszystkie wartości w polach tekstowych, które odpowiednio należą różnym daniam.
        
          
        */
        public void EnableTextBoxes()
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




        /**
          \brief Funkcja do aktywacji odpowiedniego pola tekstowego
          \version 0.4
          \param object sender
          \param EventArgs e
          \return void

            Funkcja aktywuje pole tekstowe, zawierające obiekt HamBurger.
        
          
        */
        public void HumBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (HumBurger.Checked == true)

            {
                txtHumBurger.Enabled = true;
                txtHumBurger.Text = "0";
                txtHumBurger.Focus();

            }
            else
            {
                txtHumBurger.Enabled = false;
                txtHumBurger.Text = "0";
            }
        }

        /**
          \brief Funkcja do aktywacji odpowiedniego pola tekstowego
          \version 0.3
          \param object sender
          \param EventArgs e
          \return void

            Funkcja aktywuje pole tekstowe, zawierające obiekt CheesBurger.
        
          
        */
        public void CheeseBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseBurger.Checked == true)

            {
                txtCheeseBurger.Enabled = true;
                txtCheeseBurger.Text = "0";
                txtCheeseBurger.Focus();

            }
            else
            {
                txtCheeseBurger.Enabled = false;
                txtCheeseBurger.Text = "0";
            }
        }

        /**
          \brief Funkcja do aktywacji odpowiedniego pola tekstowego
          \version 0.3
          \param object sender
          \param EventArgs e
          \return void

            Funkcja aktywuje pole tekstowe, zawierające obiekt BaconBurger.
        
          
        */
        public void BaconBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (BaconBurger.Checked == true)

            {
                txtBaconBurger.Enabled = true;
                txtBaconBurger.Text = "0";
                txtBaconBurger.Focus();

            }
            else
            {
                txtBaconBurger.Enabled = false;
                txtBaconBurger.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Steak.
       
         
       */
        public void Steak_CheckedChanged(object sender, EventArgs e)
        {
            if (Steak.Checked == true)

            {
                txtSteak.Enabled = true;
                txtSteak.Text = "0";
                txtSteak.Focus();

            }
            else
            {
                txtSteak.Enabled = false;
                txtSteak.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Meat Pie.
       
         
       */
        public void MeatPie_CheckedChanged(object sender, EventArgs e)
        {
            if (MeatPie.Checked == true)

            {
                txtMeatPie.Enabled = true;
                txtMeatPie.Text = "0";
                txtMeatPie.Focus();

            }
            else
            {
                txtMeatPie.Enabled = false;
                txtMeatPie.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Vegeterian Salad.
       
         
       */
        public void VegeterianSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (VegeterianSalad.Checked == true)

            {
                txtVegeterianSalad.Enabled = true;
                txtVegeterianSalad.Text = "0";
                txtVegeterianSalad.Focus();

            }
            else
            {
                txtVegeterianSalad.Enabled = false;
                txtVegeterianSalad.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Meat Salad.
       
         
       */
        public void MeatSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (MeatSalad.Checked == true)

            {
                txtMeatSalad.Enabled = true;
                txtMeatSalad.Text = "0";
                txtMeatSalad.Focus();

            }
            else
            {
                txtMeatSalad.Enabled = false;
                txtMeatSalad.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Fries.
       
         
       */
        public void Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (Fries.Checked == true)

            {
                txtFries.Enabled = true;
                txtFries.Text = "0";
                txtFries.Focus();

            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Nuggets.
       
         
       */
        public void Nuggets_CheckedChanged(object sender, EventArgs e)
        {
            if (Nuggets.Checked == true)

            {
                txtNuggets.Enabled = true;
                txtNuggets.Text = "0";
                txtNuggets.Focus();

            }
            else
            {
                txtNuggets.Enabled = false;
                txtNuggets.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Hot Dog.
       
         
       */
        public void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDog.Checked == true)

            {
                txtHotDog.Enabled = true;
                txtHotDog.Text = "0";
                txtHotDog.Focus();

            }
            else
            {
                txtHotDog.Enabled = false;
                txtHotDog.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Combo Menu.
       
         
       */
        public void ComboMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboMenu.Checked == true)

            {
                txtComboMenu.Enabled = true;
                txtComboMenu.Text = "0";
                txtComboMenu.Focus();

            }
            else
            {
                txtComboMenu.Enabled = false;
                txtComboMenu.Text = "0";
            }
        }

        /**
         \brief Funkcja do aktywacji odpowiedniego pola tekstowego
         \version 0.3
         \param object sender
         \param EventArgs e
         \return void

           Funkcja aktywuje pole tekstowe, zawierające obiekt Knight Menu.
       
         
       */
        public void KnightMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (KnightMenu.Checked == true)

            {
                txtKnightMenu.Enabled = true;
                txtKnightMenu.Text = "0";
                txtKnightMenu.Focus();

            }
            else
            {
                txtKnightMenu.Enabled = false;
                txtKnightMenu.Text = "0";
            }
        }

        /**
        \brief Funkcja do aktywacji odpowiedniego pola tekstowego
        \version 0.3
        \param object sender
        \param EventArgs e
        \return void

          Funkcja aktywuje pole tekstowe, zawierające obiekt Wings Festival.
      
        
      */
        public void WingsFestival_CheckedChanged(object sender, EventArgs e)
        {
            if (WingsFestival.Checked == true)

            {
                txtWingsFestival.Enabled = true;
                txtWingsFestival.Text = "0";
                txtWingsFestival.Focus();

            }
            else
            {
                txtWingsFestival.Enabled = false;
                txtWingsFestival.Text = "0";
            }
        }

        /**
       \brief Funkcja do aktywacji odpowiedniego pola tekstowego
       \version 0.3
       \param object sender
       \param EventArgs e
       \return void

         Funkcja aktywuje pole tekstowe, zawierające obiekt Childrens Menu.
     
       
     */
        public void ChildrensMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (ChildrensMenu.Checked == true)

            {
                txtChildrensMenu.Enabled = true;
                txtChildrensMenu.Text = "0";
                txtChildrensMenu.Focus();

            }
            else
            {
                txtChildrensMenu.Enabled = false;
                txtChildrensMenu.Text = "0";
            }
        }

        /**
       \brief Funkcja do aktywacji odpowiedniego pola tekstowego
       \version 0.3
       \param object sender
       \param EventArgs e
       \return void

         Funkcja aktywuje pole tekstowe, zawierające obiekt Rojal Menu.
     
       
     */
        public void RoyalMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (RoyalMenu.Checked == true)

            {
                txtRoyalMenu.Enabled = true;
                txtRoyalMenu.Text = "0";
                txtRoyalMenu.Focus();

            }
            else
            {
                txtRoyalMenu.Enabled = false;
                txtRoyalMenu.Text = "0";
            }
        }

        /**
      \brief Funkcja do aktywacji odpowiedniego pola tekstowego
      \version 0.3
      \param object sender
      \param EventArgs e
      \return void

        Funkcja aktywuje pole tekstowe, zawierające obiekt Bottle Water.
    
      
    */
        public void BottleWater_CheckedChanged(object sender, EventArgs e)
        {
            if (BottleWater.Checked == true)

            {
                txtBottlewater.Enabled = true;
                txtBottlewater.Text = "0";
                txtBottlewater.Focus();

            }
            else
            {
                txtBottlewater.Enabled = false;
                txtBottlewater.Text = "0";
            }
        }

        /**
      \brief Funkcja do aktywacji odpowiedniego pola tekstowego
      \version 0.3
      \param object sender
      \param EventArgs e
      \return void

        Funkcja aktywuje pole tekstowe, zawierające obiekt Tea.
    
      
    */
        public void Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea.Checked == true)

            {
                txtTea.Enabled = true;
                txtTea.Text = "0";
                txtTea.Focus();

            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Apple Juice.
   
     
   */
        public void AppleJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (AppleJuice.Checked == true)

            {
                txtAppleJuice.Enabled = true;
                txtAppleJuice.Text = "0";
                txtAppleJuice.Focus();

            }
            else
            {
                txtAppleJuice.Enabled = false;
                txtAppleJuice.Text = "0";
            }
        }

        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Coffee.
   
     
   */
        public void Coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (Coffee.Checked == true)

            {
                txtCoffee.Enabled = true;
                txtCoffee.Text = "0";
                txtCoffee.Focus();

            }
            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Coca Cola.
   
     
   */
        public void CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola.Checked == true)

            {
                txtCocaCola.Enabled = true;
                txtCocaCola.Text = "0";
                txtCocaCola.Focus();

            }
            else
            {
                txtCocaCola.Enabled = false;
                txtCocaCola.Text = "0";
            }
        }

        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Ice Cream.
   
     
   */
        public void IceCream_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCream.Checked == true)

            {
                txtIceCream.Enabled = true;
                txtIceCream.Text = "0";
                txtIceCream.Focus();

            }
            else
            {
                txtIceCream.Enabled = false;
                txtIceCream.Text = "0";
            }
        }

        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Pineapple Cake.
   
     
   */
        public void PineappleCake_CheckedChanged(object sender, EventArgs e)
        {
            if (PineappleCake.Checked == true)

            {
                txtPineappleCake.Enabled = true;
                txtPineappleCake.Text = "0";
                txtPineappleCake.Focus();

            }
            else
            {
                txtPineappleCake.Enabled = false;
                txtPineappleCake.Text = "0";
            }
        }

        /**
     \brief Funkcja do aktywacji pola Cash
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, służące do wprowadzenie kwoty zdeponowanej waluty.
   
     
   */
        public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                txtPaymentType.Enabled = true;
                txtPaymentType.Text = "0";
                txtPaymentType.Focus();
            }
            else
            {
                txtPaymentType.Enabled = false;
                txtPaymentType.Text = "0";
            }
        }

        /**
    \brief Funkcja do obliczenia procesu składania procesu zamówienia 
    \version 0.2
    \param object sender
    \param EventArgs e
    \return void

      Funkcja tworzy tabele w której śa przekazywane obiektu kłasy. Funkcja  funkcja wyszukuje iTax,  iSubTotal,  iTotal 
            i przekazuje dane w foramcie walutowym zgodnie z odpowiednim polem tekstowym w załeżnosci od obranej metody opłacenia .
  
    
  */
        public void Total_Click(object sender, EventArgs e)
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

        /**
   \brief Pusta funkcja
   \version 0.2
   \param object sender
   \param EventArgs e
   \return void

     Brak działania funkcji
           */
        public void txtPaymentType_TextChanged(object sender, EventArgs e)
        {
            
        }

        /**
    \brief Funkcja do zakazu wprowadzania tekstu
    \version 0.2
    \param object sender
    \param KeyPressEventArgs e
    \return void

      Funkcja nie pozwala prowadzić poszczególne symbole oprócz liczb we wszystkich polach tekstowych.
  
    
  */
        public void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if((asciiCode != 8))
            {
                if((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;

                }
            }
        }

        /**
         \brief Funkcja do wypełnienia tabeli
         \version 0.3
         \param object sender
         \param DataGridViewCellEventArgs e
         \return void

           Funkcja tworzy przestrzeń do wypełnienia tabeli DataGrid wartościami z obiektów Patment Type, Total, comboBox1 oraz commboBox2.
       
         
       */
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtPaymentType.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtTotal.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        /**
   \brief Funkcja do aktualizacji bazy danych
   \version 0.3
   \param object sender
   \param EventArgs e
   \return void

     Funkcja, która wstawia wartości zdefiniowane w polach tekstowych PaymentType, Total, comboBox1 i comboBox2 w bazie danych.



*/
        public void Update_Click(object sender, EventArgs e)
        {
            string OrdersIDq = "insert into Orders (Total, Payment, PaymentType, Mod)values('" + txtTotal.Text + "','" 
                + txtPaymentType.Text + "','" + comboBox1.Text + "','"
                + comboBox2.Text + "')";

            ExecuteQuery(OrdersIDq);
            LoadData();

        }

        /**
     \brief Funkcja do usunięcia danych z bazy danych
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja usuwa wszystkie elementy tabeli bazy danych.
   
     
   */
        public void Delete_Click(object sender, EventArgs e)
        {
            string OrdersIDq = "DELETE FROM Orders";
            ExecuteQuery(OrdersIDq);
            LoadData();

        }

        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Milk Shake.
   
     
   */
        public void MilkShake_CheckedChanged(object sender, EventArgs e)
        {
            if (MilkShake.Checked == true)

            {
                txtMilkShake.Enabled = true;
                txtMilkShake.Text = "0";
                txtMilkShake.Focus();

            }
            else
            {
                txtMilkShake.Enabled = false;
                txtMilkShake.Text = "0";
            }
        }


        /**
     \brief Funkcja do aktywacji odpowiedniego pola tekstowego
     \version 0.3
     \param object sender
     \param EventArgs e
     \return void

       Funkcja aktywuje pole tekstowe, zawierające obiekt Chocolate Muffin.
   
     
   */
        public void ChocolateMuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateMuffin.Checked == true)

            {
                txtChocolateMuffin.Enabled = true;
                txtChocolateMuffin.Text = "0";
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
