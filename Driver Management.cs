using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CTU_Logistics_Nathan_Van_Zyl_6406_PRG521_SA_Section2
{
    public partial class Driver_Management : Form
    {
        enum LicenseType { Code8, Code10, Code12, Code14 }

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter ta;
        DataTable dt;
        string owner;
        int i;

        public Driver_Management()
        {
            InitializeComponent();

            Array arrayvalue = Enum.GetValues(typeof(LicenseType));
            foreach (LicenseType type in arrayvalue)
            {
                pickDriverLicense.Items.Add(type);
            }
        }

        private void pickDriverLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            LicenseType type = (LicenseType)pickDriverLicense.SelectedItem;
        }

        private void dataGridDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridDriver.Rows[e.RowIndex];

                i = int.Parse(row.Cells["DriverId"].Value.ToString());
                txtDriverName.Text = row.Cells["FullName"].Value.ToString();
                pickDriverLicense.Text = row.Cells["LicenseType"].Value.ToString();
                
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            if(Yesbtn.Checked == true)
            {
                owner = "Yes";
            }
            else if(Nobtn.Checked == true)
            {
                owner = "No";
            }

            string sqlquery = "Insert into Driver Values(@FullName, @Licensetype, @Owner)";
            SqlCommand cmd = new SqlCommand(sqlquery, cn);

            cmd.Parameters.AddWithValue("@DriverId", i);
            cmd.Parameters.AddWithValue("@FullName", txtDriverName.Text);
            cmd.Parameters.AddWithValue("@LicenseType", pickDriverLicense.Text);
            cmd.Parameters.AddWithValue("@Owner", owner);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been created!");
            cn.Close();
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter ta = new SqlDataAdapter("SELECT * FROM Driver", cn);
            DataTable dt = new DataTable();
            ta.Fill(dt);
            dataGridDriver.DataSource = dt;
            cn.Close();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (Yesbtn.Checked == true)
            {
                owner = "Yes";
            }
            else if (Nobtn.Checked == true)
            {
                owner = "No";
            }

            string sqlquery = "Update Driver set Fullname = @FullName, Licesnsetype = @Licensetype, Owner = @Owner where DriverId = @DriverId)";
            SqlCommand cmd = new SqlCommand(sqlquery, cn);

            cmd.Parameters.AddWithValue("@DriverId", i);
            cmd.Parameters.AddWithValue("@FullName", txtDriverName.Text);
            cmd.Parameters.AddWithValue("@LicenseType", pickDriverLicense.Text);
            cmd.Parameters.AddWithValue("@Owner", owner);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been created!");
            cn.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Delete from Driver where DriverId = @DriverId";
            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@DriverId", i);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been deleted!");
            cn.Close();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
