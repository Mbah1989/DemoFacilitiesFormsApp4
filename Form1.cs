using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoFacilitiesFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-EJ5EOTT\MSSQLSERVER01;Initial Catalog=TrainingDtabase;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;

            

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string query = $"insert into DemoFacilities  values('{txtFacility_No.Text.ToString()}','{txtHotel_No.Text.ToString()}','{txtTypes.Text}','{txtOpeningTime.Text.ToString()}', '{txtClosingTime.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();

        }
        private void cleardata()
        {
            txtFacility_No.Clear();
            txtHotel_No.Clear();
            txtTypes.Clear();
            txtOpeningTime.Clear();
            txtClosingTime.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            conn.Open();
            




            cmd.Parameters.Clear();

            // Update 'Types' if not empty
            if (!string.IsNullOrEmpty(txtTypes.Text))
            {
                cmd.CommandText = "UPDATE DemoFacilities SET Types = @Types WHERE Facility_No = @Facility_No AND Hotel_No = @Hotel_No";
                cmd.Parameters.AddWithValue("@Types", txtTypes.Text);
                cmd.Parameters.AddWithValue("@Facility_No", txtFacility_No.Text);
                cmd.Parameters.AddWithValue("@Hotel_No", txtHotel_No.Text);
                cmd.ExecuteNonQuery();
            }

            // Update 'OpenTime' if not empty
            if (!string.IsNullOrEmpty(txtOpeningTime.Text))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE DemoFacilities SET OpenTime = @OpenTime WHERE Facility_No = @Facility_No AND Hotel_No = @Hotel_No";
                cmd.Parameters.AddWithValue("@OpenTime", txtOpeningTime.Text);
                cmd.Parameters.AddWithValue("@Facility_No", txtFacility_No.Text);
                cmd.Parameters.AddWithValue("@Hotel_No", txtHotel_No.Text);
                cmd.ExecuteNonQuery();
            }

            // Update 'CloseTime' if not empty
            if (!string.IsNullOrEmpty(txtClosingTime.Text))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE DemoFacilities SET CloseTime = @CloseTime WHERE Facility_No = @Facility_No AND Hotel_No = @Hotel_No";
                cmd.Parameters.AddWithValue("@CloseTime", txtClosingTime.Text);
                cmd.Parameters.AddWithValue("@Facility_No", txtFacility_No.Text);
                cmd.Parameters.AddWithValue("@Hotel_No", txtHotel_No.Text);
                cmd.ExecuteNonQuery();
            }

            // Add more update statements for additional attributes

            conn.Close();
            displaydata();
            cleardata();

        }

        private void View_Click(object sender, EventArgs e)
        {
            displaydata();

        }

            private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DemoFacilities";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = $"delete DemoFacilities where Facility_No='{txtFacility_No.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
    SqlCommand cmd = conn.CreateCommand();
    cmd.CommandType = CommandType.Text;
    cmd.CommandText = "select * from DemoFacilities where Facility_No='" + txtSearch.Text + "'";
    cmd.ExecuteNonQuery();
    DataTable dt = new DataTable();
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(dt);
    txtHotel_No.Text = dt.ToString();
    txtTypes.Text = dt.ToString();
    txtOpeningTime.Text = dt.ToString();
    txtClosingTime.Text = dt.ToString();
    dataGridView1.DataSource = dt;
    conn.Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
