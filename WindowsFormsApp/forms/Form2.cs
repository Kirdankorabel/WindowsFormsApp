using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.NewFolder1;
using WindowsFormsApp.src;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverManeger.OS = "Windows";
            DriverCreater.CreateDrivers();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
