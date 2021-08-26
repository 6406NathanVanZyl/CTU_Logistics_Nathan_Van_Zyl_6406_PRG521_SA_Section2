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
    public partial class Freight_Management : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter ta;
        DataTable dt;
        int i;

        public Freight_Management()
        {
            InitializeComponent();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Insert into Freight values(@CustomerId," +
                "@Height, @Weights, @Length, @DestinationId, @OriginId, @StatusId, @Date)";

            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(txtCustomerNumber.Text));
            cmd.Parameters.AddWithValue("@Height", Convert.ToDecimal(txtHeight.Text));
            cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeight.Text));
            cmd.Parameters.AddWithValue("@Length", Convert.ToDecimal(txtLength.Text));
            cmd.Parameters.AddWithValue("@DestinationId", txtDestination.Text);
            cmd.Parameters.AddWithValue("@OriginId", txtoriginAddress.Text);
            cmd.Parameters.AddWithValue("@Statusid", txtStatus.Text);
            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(picktheDate.Value));

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been created!");
            cn.Close();
        }

        private void dataGridFreight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridFreight.Rows[e.RowIndex];

                i = int.Parse(row.Cells["CustomerId"].Value.ToString());
                txtCustomerNumber.Text = row.Cells["CustomerId"].Value.ToString();
                txtHeight.Text = row.Cells["Height"].Value.ToString();
                txtWeight.Text = row.Cells["Weight"].Value.ToString();
                txtLength.Text = row.Cells["Length"].Value.ToString();
                txtDestination.Text = row.Cells["DestiantionId"].Value.ToString();
                txtoriginAddress.Text = row.Cells["OriginId"].Value.ToString();
                picktheDate.Value = Convert.ToDateTime(row.Cells["Date"].Value.ToString());
            }
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter ta = new SqlDataAdapter("SELECT * FROM Freight", cn);
            DataTable dt = new DataTable();
            ta.Fill(dt);
            dataGridFreight.DataSource = dt;
            cn.Close();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Update Freight set CustomerId = @CustomerId," +
                "Height = @Height, Weight = @Weights, Length = @Length," +
                "DestinationId = @DestinationId, OriginId = @OriginId," +
                "StatusId = @StatusId, Date = @Date where FreightId = @FreightId)";

            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(txtCustomerNumber.Text));
            cmd.Parameters.AddWithValue("@Height", Convert.ToDecimal(txtHeight.Text));
            cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeight.Text));
            cmd.Parameters.AddWithValue("@Length", Convert.ToDecimal(txtLength.Text));
            cmd.Parameters.AddWithValue("@DestinationId", txtDestination.Text);
            cmd.Parameters.AddWithValue("@OriginId", txtoriginAddress.Text);
            cmd.Parameters.AddWithValue("@Statusid", txtStatus.Text);
            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(picktheDate.Value));

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been created!");
            cn.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Delete from Freight where FreightId = @FreightId";
            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@FreightId", i);
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
