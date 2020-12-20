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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "not ready for work";
        }

        private void callForm2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                updateDriverPanel();
            }
            
        }

        private void callForm3(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                updateDriverPanel();
            }
        }

        public void updateDriverPanel()
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<int, string> keyValue in DriverManeger.drivers)
            {
                listBox1.Items.Add(keyValue);
            }
            CheckedReadyToWork();
        }

        private void Drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CallForm3(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                updateDevicePanel();
            }
        }

        public void updateDevicePanel()
        {
            listBox2.Items.Clear();
            foreach (Device device in DriverManeger.devices)
            {
                listBox2.Items.Add(device);
            }
            CheckedReadyToWork();
        }

        private void UnInstallDriver_Click(object sender, EventArgs e)
        {
            Device device = (Device)listBox2.SelectedItem;
            DriverManeger.DeleteDriver(device);
            device.ReadyToWork = false;
        }

        private void InstallDriver_Click(object sender, EventArgs e) 
        {
            // добавить сообщение что драйвер удален
            Driver driver = (Driver)listBox1.SelectedItem;
            Device device = (Device)listBox2.SelectedItem;
            DriverManeger.InstallDriver(driver, device);
            device.ReadyToWork = true;
        }

        private void Devices_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DeleteDriver_Click(object sender, EventArgs e)
        {
            DriverManeger.drivers.Remove(listBox1.SelectedIndex); // не удаляет
            updateDriverPanel();
        }

        private void DeleteDevice_Click(object sender, EventArgs e)
        {
            DriverManeger.devices.RemoveAt(listBox2.SelectedIndex);
            updateDevicePanel();
        }

        private void CheckedReadyToWork()
        {
            label3.Text = "";
            if (DriverManeger.CheckedReadyToWork() == true)
            {
                label3.Text = "Ready to work";
            }
            else
            {
                label3.Text = "not ready for work";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
