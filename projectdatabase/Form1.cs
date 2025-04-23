using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectdatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void teacher_button1_Click(object sender, EventArgs e)
        {
            Teachers Form = new Teachers();
            Form.Show();
        }

        private void students_button2_Click(object sender, EventArgs e)
        {
            Students Form = new Students();
            Form.Show();
        }
    }
}
