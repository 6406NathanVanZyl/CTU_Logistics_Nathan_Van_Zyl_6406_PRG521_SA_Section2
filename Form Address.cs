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
    public partial class Form_Address : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        SqlDataAdapter ta;
        DataTable dt;
        int i;
        public Form_Address()
        {
            InitializeComponent();
        }
        private void Form_Address_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=PCNATE;Initial Catalog=dboDBCtuLogistics;Integrated Security=True");
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Insert into Address values(@ComplexNumber," +
                                                         "@ComplexName," +
                                                         "@Street," +
                                                         "@Suburb," +
                                                         "@City," +
                                                         "@Province," +
                                                         "@Country," +
                                                         "@PostalCode)";

            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@ComplexNumber", int.Parse(txtComplexNumber.Text));
            cmd.Parameters.AddWithValue("@ComplexName", txtComplexName.Text);
            cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            cmd.Parameters.AddWithValue("Suburb", txtSuburb.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry);
            cmd.Parameters.AddWithValue("@CPostalCode", txtPostalCode);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record was created!");
            cn.Close();
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter ta = new SqlDataAdapter("SELECT * FROM Address", cn);
            DataTable dt = new DataTable();
            ta.Fill(dt);
            dataGridAddress.DataSource = dt;
            cn.Close();
        }

        private void dataGridAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridAddress.Rows[e.RowIndex];
                i = int.Parse(row.Cells["AddressId"].Value.ToString());
                txtComplexNumber.Text = row.Cells["ComplexNumber"].Value.ToString();
                txtComplexName.Text = row.Cells["ComplexName"].Value.ToString();
                txtStreet.Text = row.Cells["Street"].Value.ToString();
                txtSuburb.Text = row.Cells["Suburb"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtProvince.Text = row.Cells["Province"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
                txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Update Address set ComplexNumber = @ComplexNumber," +
                                                  "ComplexName = @ComplexName," +
                                                  "Street = @Street," +
                                                  "Suburb = @Suburb," +
                                                  "City = @City," +
                                                  "Province = @Province," +
                                                  "Country = @Country, PostalCode = @PostalCode where AddressId = @AddressId";

            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@AddressId", i);
            cmd.Parameters.AddWithValue("@ComplexNumber", int.Parse(txtComplexNumber.Text));
            cmd.Parameters.AddWithValue("@ComplexName", txtComplexName.Text);
            cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            cmd.Parameters.AddWithValue("@Suburb", txtSuburb.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@PostalCode", int.Parse(txtPostalCode.Text));

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated!");
            cn.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "Delete form Address where AddressId = @AddressId";
            SqlCommand cmd = new SqlCommand(sqlquery, cn);
            cmd.Parameters.AddWithValue("@AddressId", i);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been deleted!");
            cn.Close();
        }

        //The Exit button will take you back to the HomeScreen menu so that you dont need to re enter the program/application
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
