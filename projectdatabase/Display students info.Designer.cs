
namespace projectdatabase
{
    partial class Display_students_info
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
            this.display_all_teachers_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // display_all_teachers_button
            // 
            this.display_all_teachers_button.Location = new System.Drawing.Point(223, 48);
            this.display_all_teachers_button.Name = "display_all_teachers_button";
            this.display_all_teachers_button.Size = new System.Drawing.Size(407, 40);
            this.display_all_teachers_button.TabIndex = 1;
            this.display_all_teachers_button.Text = "Display All Students Info";
            this.display_all_teachers_button.UseVisualStyleBackColor = true;
            this.display_all_teachers_button.Click += new System.EventHandler(this.display_all_teachers_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 353);
            this.dataGridView1.TabIndex = 2;
            // 
            // Display_students_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.display_all_teachers_button);
            this.Name = "Display_students_info";
            this.Text = "Display_students_info";
            this.Load += new System.EventHandler(this.Display_students_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button display_all_teachers_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}