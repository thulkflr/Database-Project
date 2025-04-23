
namespace projectdatabase
{
    partial class Form1
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
            this.teacher_button1 = new System.Windows.Forms.Button();
            this.students_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacher_button1
            // 
            this.teacher_button1.Location = new System.Drawing.Point(100, 59);
            this.teacher_button1.Name = "teacher_button1";
            this.teacher_button1.Size = new System.Drawing.Size(158, 43);
            this.teacher_button1.TabIndex = 0;
            this.teacher_button1.Text = "Teachers";
            this.teacher_button1.UseVisualStyleBackColor = true;
            this.teacher_button1.Click += new System.EventHandler(this.teacher_button1_Click);
            // 
            // students_button2
            // 
            this.students_button2.Location = new System.Drawing.Point(100, 151);
            this.students_button2.Name = "students_button2";
            this.students_button2.Size = new System.Drawing.Size(158, 43);
            this.students_button2.TabIndex = 1;
            this.students_button2.Text = "Students";
            this.students_button2.UseVisualStyleBackColor = true;
            this.students_button2.Click += new System.EventHandler(this.students_button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 280);
            this.Controls.Add(this.students_button2);
            this.Controls.Add(this.teacher_button1);
            this.Name = "Form1";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacher_button1;
        private System.Windows.Forms.Button students_button2;
    }
}

