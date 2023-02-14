namespace Online_Library
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(119, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "LogIn";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(10, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 24);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 24);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(36, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(203, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 63);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(357, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 453);
            this.panel1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(254, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 45);
            this.button6.TabIndex = 3;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
    }
}