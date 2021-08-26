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
    public partial class Status_Management : Form
    {
        public Status_Management()
        {
            InitializeComponent();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            StreamWriter txt = new StreamWriter("C:\\Users\\Nathan Van Zyl\\Desktop\\txtStatus.txt");
            txt.Write(txtDriverId.Text + "\n");
            txt.Write(txtStatusId.Text + "\n");
            txt.Write(pickPickUp.Value + "\n");
            txt.Write(pickDelivered.Value + "\n")
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            string readingfiles = FileDialog.ReadAllText(fd.FileName);
            dataGridStatus.Text = readingfiles;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
