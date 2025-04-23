
namespace projectdatabase
{
    partial class Teachers
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
            this.display_button1 = new System.Windows.Forms.Button();
            this.manage_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display_button1
            // 
            this.display_button1.Location = new System.Drawing.Point(121, 62);
            this.display_button1.Name = "display_button1";
            this.display_button1.Size = new System.Drawing.Size(185, 45);
            this.display_button1.TabIndex = 0;
            this.display_button1.Text = "Display";
            this.display_button1.UseVisualStyleBackColor = true;
            this.display_button1.Click += new System.EventHandler(this.display_button1_Click);
            // 
            // manage_button
            // 
            this.manage_button.Location = new System.Drawing.Point(121, 180);
            this.manage_button.Name = "manage_button";
            this.manage_button.Size = new System.Drawing.Size(185, 45);
            this.manage_button.TabIndex = 1;
            this.manage_button.Text = "Manage";
            this.manage_button.UseVisualStyleBackColor = true;
            this.manage_button.Click += new System.EventHandler(this.manage_button_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 337);
            this.Controls.Add(this.manage_button);
            this.Controls.Add(this.display_button1);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button display_button1;
        private System.Windows.Forms.Button manage_button;
    }
}