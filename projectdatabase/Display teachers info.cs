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
namespace projectdatabase
{
    public partial class Display_teachers_info : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlDataReader myreader;
        SqlConnectionStringBuilder s = new SqlConnectionStringBuilder("Data Source = DESKTOP-MBUBFHE\\SQLEXPRESS; Initial Catalog = school; Integrated Security = True; Pooling=False");

        public Display_teachers_info()
        {
            InitializeComponent();
        }

        private void display_all_teachers_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cnn.ConnectionString = s.ConnectionString;
            cnn.Open();
            string select = "select * from TEACHER";
            SqlCommand cmd = new SqlCommand(select, cnn);
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                dataGridView1.Rows.Add(myreader["id"].ToString(),
                    myreader["fname"].ToString(),
                    myreader["lname"].ToString(),
                    myreader["email"].ToString(),
                    myreader["gender"].ToString(),
                    myreader["salary"].ToString());

            }
            cnn.Close();
        }

        private void Display_teachers_info_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("fname", "First Name");
            dataGridView1.Columns.Add("Lname", "Last Name");
            dataGridView1.Columns.Add("gender", "GENDER");
            dataGridView1.Columns.Add("email", "EMAIL");
            dataGridView1.Columns.Add("salary", "SALARY");
        }
    }
}
