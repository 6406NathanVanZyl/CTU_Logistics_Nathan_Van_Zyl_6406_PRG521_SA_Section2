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
    public partial class Customer_Management : Form
    {
        SqlCommand cmd; 
        SqlConnection cn; 
        SqlDataAdapter ta; 
        DataTable dt; 
        int i;
        public Customer_Management()
        {
            InitializeComponent();
        }


        private void Customer_Management_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=PCNATE;Initial Catalog=dboDBCtuLogistics;Integrated Security=True");
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Insert into Customer values(@FullName, @ContactNumber, @Email, @AddressId)";

            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been inserted!");
            cn.Close();
        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridCustomer.Rows[e.RowIndex];

                i = int.Parse(row.Cells["CustomerId"].Value.ToString());
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter ta = new SqlDataAdapter("SELECT * FROM Customer", cn);
            DataTable dt = new DataTable();
            ta.Fill(dt);
            dataGridCustomer.DataSource = dt;
            cn.Close();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Uapdate Customer set AddressId = AddressId," +
                "ContactNumber = @ContactNumber, Email = @Email, FullName = @FullName where CustomerId = @CustomerId";

            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@CustomerId", i);
            cmd.Parameters.AddWithValue("@ContactNumber", int.Parse(txtContactNumber.Text));
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@FullNames", txtFullName.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Delete from Customer where CustomerId = @CustomerId";
            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@CustomerId", i);
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
