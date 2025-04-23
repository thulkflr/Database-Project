
namespace projectdatabase
{
    partial class Students
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
            this.Sdisplay_button1 = new System.Windows.Forms.Button();
            this.Smanage_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sdisplay_button1
            // 
            this.Sdisplay_button1.Location = new System.Drawing.Point(139, 55);
            this.Sdisplay_button1.Name = "Sdisplay_button1";
            this.Sdisplay_button1.Size = new System.Drawing.Size(185, 45);
            this.Sdisplay_button1.TabIndex = 1;
            this.Sdisplay_button1.Text = "Display";
            this.Sdisplay_button1.UseVisualStyleBackColor = true;
            this.Sdisplay_button1.Click += new System.EventHandler(this.Sdisplay_button1_Click);
            // 
            // Smanage_button
            // 
            this.Smanage_button.Location = new System.Drawing.Point(139, 168);
            this.Smanage_button.Name = "Smanage_button";
            this.Smanage_button.Size = new System.Drawing.Size(185, 45);
            this.Smanage_button.TabIndex = 2;
            this.Smanage_button.Text = "Manage";
            this.Smanage_button.UseVisualStyleBackColor = true;
            this.Smanage_button.Click += new System.EventHandler(this.Smanage_button_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 314);
            this.Controls.Add(this.Smanage_button);
            this.Controls.Add(this.Sdisplay_button1);
            this.Name = "Students";
            this.Text = "Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sdisplay_button1;
        private System.Windows.Forms.Button Smanage_button;
    }
}