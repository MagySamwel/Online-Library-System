namespace Online_Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 325);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 55);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.DarkRed;
            this.button5.Location = new System.Drawing.Point(642, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Categories";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(530, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Author";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(427, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(325, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "LogIn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(209, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(697, -4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 45);
            this.button6.TabIndex = 2;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}