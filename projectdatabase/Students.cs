﻿using System;
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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Sdisplay_button1_Click(object sender, EventArgs e)
        {
            Display_students_info Form = new Display_students_info();
            Form.Show();
        }

        private void Smanage_button_Click(object sender, EventArgs e)
        {
            Manage_students Form = new Manage_students();
            Form.Show();
        }
    }
}
