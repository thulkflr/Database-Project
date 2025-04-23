
namespace projectdatabase
{
    partial class Manage_students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.s_id_textBox1 = new System.Windows.Forms.TextBox();
            this.s_fname_textBox2 = new System.Windows.Forms.TextBox();
            this.s_lname_textBox3 = new System.Windows.Forms.TextBox();
            this.s_gender_textBox4 = new System.Windows.Forms.TextBox();
            this.s_birthdate_textBox5 = new System.Windows.Forms.TextBox();
            this.s_gpa_textBox6 = new System.Windows.Forms.TextBox();
            this.Sinsert_button = new System.Windows.Forms.Button();
            this.Supdate_button = new System.Windows.Forms.Button();
            this.Sdelet_button = new System.Windows.Forms.Button();
            this.Ssearch_button = new System.Windows.Forms.Button();
            this.Sclear_button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Brith date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "GPA";
            // 
            // s_id_textBox1
            // 
            this.s_id_textBox1.Location = new System.Drawing.Point(269, 38);
            this.s_id_textBox1.Name = "s_id_textBox1";
            this.s_id_textBox1.Size = new System.Drawing.Size(159, 22);
            this.s_id_textBox1.TabIndex = 7;
            // 
            // s_fname_textBox2
            // 
            this.s_fname_textBox2.Location = new System.Drawing.Point(269, 111);
            this.s_fname_textBox2.Name = "s_fname_textBox2";
            this.s_fname_textBox2.Size = new System.Drawing.Size(159, 22);
            this.s_fname_textBox2.TabIndex = 8;
            // 
            // s_lname_textBox3
            // 
            this.s_lname_textBox3.Location = new System.Drawing.Point(269, 186);
            this.s_lname_textBox3.Name = "s_lname_textBox3";
            this.s_lname_textBox3.Size = new System.Drawing.Size(159, 22);
            this.s_lname_textBox3.TabIndex = 9;
            // 
            // s_gender_textBox4
            // 
            this.s_gender_textBox4.Location = new System.Drawing.Point(269, 259);
            this.s_gender_textBox4.Name = "s_gender_textBox4";
            this.s_gender_textBox4.Size = new System.Drawing.Size(159, 22);
            this.s_gender_textBox4.TabIndex = 10;
            // 
            // s_birthdate_textBox5
            // 
            this.s_birthdate_textBox5.Location = new System.Drawing.Point(269, 339);
            this.s_birthdate_textBox5.Name = "s_birthdate_textBox5";
            this.s_birthdate_textBox5.Size = new System.Drawing.Size(159, 22);
            this.s_birthdate_textBox5.TabIndex = 11;
            // 
            // s_gpa_textBox6
            // 
            this.s_gpa_textBox6.Location = new System.Drawing.Point(269, 413);
            this.s_gpa_textBox6.Name = "s_gpa_textBox6";
            this.s_gpa_textBox6.Size = new System.Drawing.Size(159, 22);
            this.s_gpa_textBox6.TabIndex = 12;
            // 
            // Sinsert_button
            // 
            this.Sinsert_button.Location = new System.Drawing.Point(561, 34);
            this.Sinsert_button.Name = "Sinsert_button";
            this.Sinsert_button.Size = new System.Drawing.Size(113, 24);
            this.Sinsert_button.TabIndex = 13;
            this.Sinsert_button.Text = "Insert";
            this.Sinsert_button.UseVisualStyleBackColor = true;
            this.Sinsert_button.Click += new System.EventHandler(this.Sinsert_button_Click);
            // 
            // Supdate_button
            // 
            this.Supdate_button.Location = new System.Drawing.Point(561, 127);
            this.Supdate_button.Name = "Supdate_button";
            this.Supdate_button.Size = new System.Drawing.Size(113, 24);
            this.Supdate_button.TabIndex = 14;
            this.Supdate_button.Text = "Update";
            this.Supdate_button.UseVisualStyleBackColor = true;
            this.Supdate_button.Click += new System.EventHandler(this.Supdate_button_Click);
            // 
            // Sdelet_button
            // 
            this.Sdelet_button.Location = new System.Drawing.Point(561, 226);
            this.Sdelet_button.Name = "Sdelet_button";
            this.Sdelet_button.Size = new System.Drawing.Size(113, 24);
            this.Sdelet_button.TabIndex = 15;
            this.Sdelet_button.Text = "Delete";
            this.Sdelet_button.UseVisualStyleBackColor = true;
            this.Sdelet_button.Click += new System.EventHandler(this.Sdelet_button_Click);
            // 
            // Ssearch_button
            // 
            this.Ssearch_button.Location = new System.Drawing.Point(561, 316);
            this.Ssearch_button.Name = "Ssearch_button";
            this.Ssearch_button.Size = new System.Drawing.Size(113, 24);
            this.Ssearch_button.TabIndex = 16;
            this.Ssearch_button.Text = "Search";
            this.Ssearch_button.UseVisualStyleBackColor = true;
            this.Ssearch_button.Click += new System.EventHandler(this.Ssearch_button_Click);
            // 
            // Sclear_button5
            // 
            this.Sclear_button5.Location = new System.Drawing.Point(561, 406);
            this.Sclear_button5.Name = "Sclear_button5";
            this.Sclear_button5.Size = new System.Drawing.Size(113, 24);
            this.Sclear_button5.TabIndex = 17;
            this.Sclear_button5.Text = "Clear";
            this.Sclear_button5.UseVisualStyleBackColor = true;
            this.Sclear_button5.Click += new System.EventHandler(this.Sclear_button5_Click);
            // 
            // Manage_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.Sclear_button5);
            this.Controls.Add(this.Ssearch_button);
            this.Controls.Add(this.Sdelet_button);
            this.Controls.Add(this.Supdate_button);
            this.Controls.Add(this.Sinsert_button);
            this.Controls.Add(this.s_gpa_textBox6);
            this.Controls.Add(this.s_birthdate_textBox5);
            this.Controls.Add(this.s_gender_textBox4);
            this.Controls.Add(this.s_lname_textBox3);
            this.Controls.Add(this.s_fname_textBox2);
            this.Controls.Add(this.s_id_textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manage_students";
            this.Text = "Manage_students";
            this.Load += new System.EventHandler(this.Manage_students_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s_id_textBox1;
        private System.Windows.Forms.TextBox s_fname_textBox2;
        private System.Windows.Forms.TextBox s_lname_textBox3;
        private System.Windows.Forms.TextBox s_gender_textBox4;
        private System.Windows.Forms.TextBox s_birthdate_textBox5;
        private System.Windows.Forms.TextBox s_gpa_textBox6;
        private System.Windows.Forms.Button Sinsert_button;
        private System.Windows.Forms.Button Supdate_button;
        private System.Windows.Forms.Button Sdelet_button;
        private System.Windows.Forms.Button Ssearch_button;
        private System.Windows.Forms.Button Sclear_button5;
    }
}