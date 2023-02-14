using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm2 = new SignUpForm();
            signUpForm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Categories CatForm = new Categories();
            CatForm.Show();
            this.Hide();
        }
    }
}
