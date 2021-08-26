using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //As you can see all my buttons from the "Home"form is linked to their coresponding forms.

        private void LinkToAddresses_Click(object sender, EventArgs e)
        {
            Form_Address adresfrm = new Form_Address();
            this.Hide();
            adresfrm.ShowDialog();
        }

        private void LinkToCustomers_Click(object sender, EventArgs e)
        {
            Customer_Management custfrm = new Customer_Management();
            this.Hide();
            custfrm.ShowDialog();
        }

        private void LinkToFreight_Click(object sender, EventArgs e)
        {
            Freight_Management freightfrm = new Freight_Management();
            this.Hide();
            freightfrm.ShowDialog();
        }

        private void LinkToDrivers_Click(object sender, EventArgs e)
        {
            Driver_Management driverfrm = new Driver_Management();
            this.Hide();
            driverfrm.ShowDialog();
        }

        private void LinkToStatus_Click(object sender, EventArgs e)
        {
            Status_Management statusfrm = new Status_Management();
            this.Hide();
            statusfrm.ShowDialog();
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
