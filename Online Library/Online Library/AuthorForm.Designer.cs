namespace Online_Library
{
    partial class AuthorForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AuID = new System.Windows.Forms.Label();
            this.AuName = new System.Windows.Forms.Label();
            this.AuPhone = new System.Windows.Forms.Label();
            this.AuMail = new System.Windows.Forms.Label();
            this.AuType = new System.Windows.Forms.Label();
            this.AuNum = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 91);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(781, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 91);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(310, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 44);
            this.label8.TabIndex = 1;
            this.label8.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(160, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(555, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "Library Managment System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 37);
            this.panel3.TabIndex = 0;
            // 
            // AuID
            // 
            this.AuID.AutoSize = true;
            this.AuID.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuID.ForeColor = System.Drawing.Color.DarkRed;
            this.AuID.Location = new System.Drawing.Point(1, 104);
            this.AuID.Name = "AuID";
            this.AuID.Size = new System.Drawing.Size(40, 27);
            this.AuID.TabIndex = 1;
            this.AuID.Text = "ID";
            // 
            // AuName
            // 
            this.AuName.AutoSize = true;
            this.AuName.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuName.ForeColor = System.Drawing.Color.DarkRed;
            this.AuName.Location = new System.Drawing.Point(1, 147);
            this.AuName.Name = "AuName";
            this.AuName.Size = new System.Drawing.Size(172, 27);
            this.AuName.TabIndex = 2;
            this.AuName.Text = "AuthorName";
            // 
            // AuPhone
            // 
            this.AuPhone.AutoSize = true;
            this.AuPhone.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuPhone.ForeColor = System.Drawing.Color.DarkRed;
            this.AuPhone.Location = new System.Drawing.Point(1, 194);
            this.AuPhone.Name = "AuPhone";
            this.AuPhone.Size = new System.Drawing.Size(87, 27);
            this.AuPhone.TabIndex = 3;
            this.AuPhone.Text = "Phone";
            // 
            // AuMail
            // 
            this.AuMail.AutoSize = true;
            this.AuMail.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuMail.ForeColor = System.Drawing.Color.DarkRed;
            this.AuMail.Location = new System.Drawing.Point(1, 245);
            this.AuMail.Name = "AuMail";
            this.AuMail.Size = new System.Drawing.Size(65, 27);
            this.AuMail.TabIndex = 4;
            this.AuMail.Text = "Mail";
            // 
            // AuType
            // 
            this.AuType.AutoSize = true;
            this.AuType.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuType.ForeColor = System.Drawing.Color.DarkRed;
            this.AuType.Location = new System.Drawing.Point(1, 290);
            this.AuType.Name = "AuType";
            this.AuType.Size = new System.Drawing.Size(147, 27);
            this.AuType.TabIndex = 5;
            this.AuType.Text = "BooksType";
            // 
            // AuNum
            // 
            this.AuNum.AutoSize = true;
            this.AuNum.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuNum.ForeColor = System.Drawing.Color.DarkRed;
            this.AuNum.Location = new System.Drawing.Point(1, 338);
            this.AuNum.Name = "AuNum";
            this.AuNum.Size = new System.Drawing.Size(174, 27);
            this.AuNum.TabIndex = 6;
            this.AuNum.Text = "NumOfBooks";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(181, 107);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(175, 24);
            this.IDBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.IDBox, "Enter Your ID");
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(181, 150);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(175, 24);
            this.NameBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.NameBox, "Enter Your Name");
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(181, 197);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(175, 24);
            this.PhoneBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.PhoneBox, "Enter Your Phone");
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(181, 248);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(175, 24);
            this.MailBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.MailBox, "Enter Your e-mail");
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(181, 293);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(175, 24);
            this.TypeBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.TypeBox, "Enter Your Type");
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(181, 341);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(175, 24);
            this.NumBox.TabIndex = 12;
            this.toolTip1.SetToolTip(this.NumBox, "Enter Your NumOfBooks");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(23, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.toolTip1.SetToolTip(this.button2, "Add New Author");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(140, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Edit";
            this.toolTip1.SetToolTip(this.button3, "Update Information\'s Author");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Firebrick;
            this.button4.Location = new System.Drawing.Point(262, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 44);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.toolTip1.SetToolTip(this.button4, "Delete Author");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PeachPuff;
            this.button5.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Firebrick;
            this.button5.Location = new System.Drawing.Point(60, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 41);
            this.button5.TabIndex = 16;
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
            this.button6.Location = new System.Drawing.Point(235, 465);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 41);
            this.button6.TabIndex = 17;
            this.button6.Text = "Search";
            this.toolTip1.SetToolTip(this.button6, "Search About Author");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(449, 431);
            this.dataGridView1.TabIndex = 18;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(836, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.AuNum);
            this.Controls.Add(this.AuType);
            this.Controls.Add(this.AuMail);
            this.Controls.Add(this.AuPhone);
            this.Controls.Add(this.AuName);
            this.Controls.Add(this.AuID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AuID;
        private System.Windows.Forms.Label AuName;
        private System.Windows.Forms.Label AuPhone;
        private System.Windows.Forms.Label AuMail;
        private System.Windows.Forms.Label AuType;
        private System.Windows.Forms.Label AuNum;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}