using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fast_Food_Restaurant_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Restaurant_System.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void HumBurger_CheckedChangedTest()
        {
            //arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.HumBurger.Checked = true;
            tmp.HumBurger_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtHumBurger.Enabled);

        }

        [TestMethod()]
        public void BaconBurger_CheckedChangedTest()
        {
            //arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.CheeseBurger.Checked = true;
            tmp.CheeseBurger_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtHumBurger.Enabled);
        }

        [TestMethod()]
        public void Steak_CheckedChangedTest()
        {
            //arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.Steak.Checked = true;
            tmp.Steak_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtSteak.Enabled);
        }

        [TestMethod()]
        public void MeatPie_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.MeatPie.Checked = true;
            tmp.MeatPie_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtMeatPie.Enabled);
        }

        [TestMethod()]
        public void VegeterianSalad_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.VegeterianSalad.Checked = true;
            tmp.VegeterianSalad_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtVegeterianSalad.Enabled);
        }

        [TestMethod()]
        public void MeatSalad_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.MeatSalad.Checked = true;
            tmp.MeatSalad_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtMeatSalad.Enabled);
        }

        [TestMethod()]
        public void Fries_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.Fries.Checked = true;
            tmp.Fries_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtFries.Enabled);
        }

        [TestMethod()]
        public void Nuggets_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.Nuggets.Checked = true;
            tmp.Nuggets_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtNuggets.Enabled);
        }

        [TestMethod()]
        public void HotDog_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.HotDog.Checked = true;
            tmp.HotDog_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtHotDog.Enabled);
        }

        [TestMethod()]
        public void ComboMenu_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.ComboMenu.Checked = true;
            tmp.ComboMenu_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtComboMenu.Enabled);
        }

        [TestMethod()]
        public void KnightMenu_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.KnightMenu.Checked = true;
            tmp.KnightMenu_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtKnightMenu.Enabled);
        }

        [TestMethod()]
        public void WingsFestival_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.WingsFestival.Checked = true;
            tmp.WingsFestival_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtWingsFestival.Enabled);
        }

        [TestMethod()]
        public void ChildrensMenu_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.ChildrensMenu.Checked = true;
            tmp.ChildrensMenu_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtChildrensMenu.Enabled);
        }

        [TestMethod()]
        public void RoyalMenu_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.RoyalMenu.Checked = true;
            tmp.RoyalMenu_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtRoyalMenu.Enabled);
        }

        [TestMethod()]
        public void BottleWater_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.BottleWater.Checked = true;
            tmp.BottleWater_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtBottlewater.Enabled);
        }

        [TestMethod()]
        public void Tea_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.Tea.Checked = true;
            tmp.Tea_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtTea.Enabled);
        }

        [TestMethod()]
        public void AppleJuice_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.AppleJuice.Checked = true;
            tmp.AppleJuice_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtAppleJuice.Enabled);
        }

        [TestMethod()]
        public void Coffee_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.Coffee.Checked = true;
            tmp.Coffee_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtCoffee.Enabled);
        }

        [TestMethod()]
        public void CocaCola_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.CocaCola.Checked = true;
            tmp.CocaCola_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtCocaCola.Enabled);
        }

        [TestMethod()]
        public void IceCream_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.IceCream.Checked = true;
            tmp.IceCream_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtIceCream.Enabled);
        }

        [TestMethod()]
        public void PineappleCake_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.PineappleCake.Checked = true;
            tmp.PineappleCake_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtPineappleCake.Enabled);
        }

        [TestMethod()]
        public void MilkShake_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.MilkShake.Checked = true;
            tmp.MilkShake_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtMilkShake.Enabled);
        }

        [TestMethod()]
        public void ChocolateMuffin_CheckedChangedTest()
        {
            // arrange
            Fast_Food_Restaurant_System.Form1 tmp = new Fast_Food_Restaurant_System.Form1();

            //act
            tmp.ChocolateMuffin.Checked = true;
            tmp.ChocolateMuffin_CheckedChanged(null, null);

            //assert
            Assert.AreEqual(true, tmp.txtChocolateMuffin.Enabled);
        }
    }
}