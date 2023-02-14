namespace Online_Library
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookBox1 = new System.Windows.Forms.TextBox();
            this.GenBox = new System.Windows.Forms.TextBox();
            this.AuBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 85);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(778, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(340, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(168, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Managment System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(450, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 418);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 57);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "BookName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(18, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(18, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Author";
            // 
            // BookBox1
            // 
            this.BookBox1.Location = new System.Drawing.Point(199, 165);
            this.BookBox1.Name = "BookBox1";
            this.BookBox1.Size = new System.Drawing.Size(203, 24);
            this.BookBox1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BookBox1, "Enter Name Book");
            // 
            // GenBox
            // 
            this.GenBox.Location = new System.Drawing.Point(197, 227);
            this.GenBox.Name = "GenBox";
            this.GenBox.Size = new System.Drawing.Size(203, 24);
            this.GenBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.GenBox, "Enter Genre");
            // 
            // AuBox
            // 
            this.AuBox.Location = new System.Drawing.Point(197, 281);
            this.AuBox.Name = "AuBox";
            this.AuBox.Size = new System.Drawing.Size(203, 24);
            this.AuBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.AuBox, "Enter AuthorName");
            this.AuBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(24, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.toolTip1.SetToolTip(this.button2, "Add New Book");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(159, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Search";
            this.toolTip1.SetToolTip(this.button3, "Sreach About Book");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Firebrick;
            this.button4.Location = new System.Drawing.Point(305, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.toolTip1.SetToolTip(this.button4, "Delete Book");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PeachPuff;
            this.button5.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Firebrick;
            this.button5.Location = new System.Drawing.Point(76, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 49);
            this.button5.TabIndex = 10;
            this.button5.Text = "Home";
            this.toolTip1.SetToolTip(this.button5, "Back to MainForm");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PeachPuff;
            this.button6.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Firebrick;
            this.button6.Location = new System.Drawing.Point(262, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 53);
            this.button6.TabIndex = 11;
            this.button6.Text = "Download";
            this.toolTip1.SetToolTip(this.button6, "Download Book");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(19, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(198, 117);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(204, 24);
            this.IDBox1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.IDBox1, "Enter ID");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(836, 572);
            this.Controls.Add(this.IDBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AuBox);
            this.Controls.Add(this.GenBox);
            this.Controls.Add(this.BookBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookBox1;
        private System.Windows.Forms.TextBox GenBox;
        private System.Windows.Forms.TextBox AuBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}