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
    public partial class Mange_teachers : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlDataReader myreader;
        SqlConnectionStringBuilder s = new SqlConnectionStringBuilder("Data Source = DESKTOP-MBUBFHE\\SQLEXPRESS; Initial Catalog = school; Integrated Security = True; Pooling=False");
        public Mange_teachers()
        {
            InitializeComponent();
        }

        private void Tinsert_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string insert = " insert into TEACHER values (" + Int32.Parse(T_id_textBox1.Text) + " ," + " '" + T_fname_textBox2.Text + " '" + " ," + " '" + T_lname_textBox3.Text + "' " + " ," + " '" + T_gender_textBox4.Text + " '" + " ," + "' " + T_email_textBox5.Text + " '" + " ," + float.Parse(T_salary_textBox6.Text) + ")" ;

            SqlCommand cmd = new SqlCommand(insert, cnn);
            cmd.ExecuteNonQuery();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();

        }

        private void Tupdate_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
            string update = "update TEACHER set " + "FNAME= '" + T_fname_textBox2.Text + "'," + "LNAME='" + T_lname_textBox3.Text + "'," + "GENDER='" + T_gender_textBox4.Text + "'," + "EMAIL='" + T_email_textBox5.Text + "'," + "SALARY='" + T_salary_textBox6.Text +  " 'WHERE ID=' " + T_id_textBox1.Text + "';";
            DialogResult res = MessageBox.Show("Are you sure you want to update this teacher   information ? ", "update conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void Tdelet_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
            string delete = "delete From TEACHER where ID=' " + T_id_textBox1.Text + "';";
            DialogResult res = MessageBox.Show("Are you sure you want to delet this teacher   information ? ", "delet conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlCommand cmd = new SqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

        }

        private void Tclear_button5_Click(object sender, EventArgs e)
        {
            T_id_textBox1.Text = "";
            T_fname_textBox2.Text = "";
            T_lname_textBox3.Text = "";
            T_salary_textBox6.Text = "";
            T_gender_textBox4.Text = "";
            T_email_textBox5.Text = "";
        }

        private void Tsearch_button_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = s.ConnectionString;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string searsh = "select * from TEACHER where ID =" + T_id_textBox1.Text;
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

                T_id_textBox1.Text = myreader["ID"].ToString();
                T_fname_textBox2.Text = myreader["FNAME"].ToString();
                T_lname_textBox3.Text = myreader["LNAME"].ToString();
                T_gender_textBox4.Text = myreader["GENDER"].ToString();

                T_email_textBox5.Text = myreader["EMAIL"].ToString();

                T_salary_textBox6.Text = myreader["SALARY"].ToString();
            }
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}
