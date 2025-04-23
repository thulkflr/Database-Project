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
    public partial class Manage_students : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlDataReader myreader;
        SqlConnectionStringBuilder s = new SqlConnectionStringBuilder("Data Source = DESKTOP-MBUBFHE\\SQLEXPRESS; Initial Catalog = school; Integrated Security = True; Pooling=False");
        public Manage_students()
        {
            InitializeComponent();
        }

        private void Manage_students_Load(object sender, EventArgs e)
        {

        }

        private void Sinsert_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string insert = "insert into student values(" + Int32.Parse(s_id_textBox1.Text) + " , " + " ' " + s_fname_textBox2.Text + " ' " + " , " + " ' " + s_lname_textBox3.Text + " ' " + " , " + " ' " + s_gender_textBox4.Text + " ' " + " , " + " ' " + s_birthdate_textBox5.Text + " ' " + " , " + float.Parse(s_gpa_textBox6.Text) + ")";

            SqlCommand cmd = new SqlCommand(insert, cnn);
            cmd.ExecuteNonQuery();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            
        }

        private void Sclear_button5_Click(object sender, EventArgs e)
        {
            s_id_textBox1.Text = "";
            s_fname_textBox2.Text = "";
            s_lname_textBox3.Text = "";
            s_gender_textBox4.Text = "";
            s_gpa_textBox6.Text = "";
            s_birthdate_textBox5.Text = "";
        }

        private void Supdate_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
           
            string update = " update student set " + "FNAME=' " + s_fname_textBox2.Text + " ' ," + "LNAME='" + s_lname_textBox3.Text + " '," + "GENDER=' " + s_gender_textBox4.Text + "'," + " BRITH_DATE=' " + s_birthdate_textBox5.Text + "'," + "GPA=' " + s_gpa_textBox6.Text + "'WHERE ID='" + s_id_textBox1.Text + "';";


            DialogResult res = MessageBox.Show("Are you sure you want to update this student  information ? ", "update conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlCommand cmd = new SqlCommand(update, cnn);
                cmd.ExecuteNonQuery();
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

        }

        private void Sdelet_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
            string delete = "delete from student where ID='" + s_id_textBox1.Text + "';";

            DialogResult rs = MessageBox.Show("Are you sure you want to delete this student information ? ", "delete conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlCommand cmd = new SqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        private void Ssearch_button_Click(object sender, EventArgs e)
        {

            cnn.ConnectionString = s.ConnectionString;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string searsh = "select * from student where ID =" + s_id_textBox1.Text;
            SqlCommand cmd = new SqlCommand(searsh, cnn);
            object result = cmd.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("There is no student with this id ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myreader = cmd.ExecuteReader();
                myreader.Read();

                s_id_textBox1.Text = myreader["ID"].ToString();
                s_fname_textBox2.Text = myreader["FNAME"].ToString();
                s_lname_textBox3.Text = myreader["LNAME"].ToString();
                s_gender_textBox4.Text = myreader["GENDER"].ToString();
                s_birthdate_textBox5.Text = myreader["BRITH_DATE"].ToString();
                s_birthdate_textBox5.Text = s_birthdate_textBox5.Text.Substring(0, s_birthdate_textBox5.Text.IndexOf(' ') + 1);
                
                s_gpa_textBox6.Text = myreader["GPA"].ToString();
            }
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}
