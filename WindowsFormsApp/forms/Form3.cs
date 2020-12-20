using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.src;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UpdateTypePanel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DriverCreater.Types;
            string name = Convert.ToString(textBox1.Text);// сделать кнопку недоступной пока не введено имя
            string type = Convert.ToString(listBox1.SelectedItem);
            if (string.IsNullOrWhiteSpace(name) == false) // добавить поверку на допустимость типа устройства
            {
                Device device = new Device(name, type);
                DriverManeger.devices.Add(device);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
        public void UpdateTypePanel()
        {
            foreach (string type in DriverCreater.Types)
            {
                listBox1.Items.Add(type);
            }
        }
    }
}
