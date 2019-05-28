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
    }
}
