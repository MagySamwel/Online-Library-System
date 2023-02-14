using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Online_Library
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDBox1.Text.Trim() == "" || BookBox1.Text.Trim()=="" ||GenBox.Text.Trim()=="" || AuBox.Text.Trim()=="")
                {
                    MessageBox.Show("Please, Enter all data and try again!!!");
                    return;
                }
                StreamReader streamReader1 = new StreamReader("Books.txt");
                string strCheck = streamReader1.ReadToEnd();
                streamReader1.Close();
                if (strCheck.Contains(BookBox1.Text)||strCheck.Contains(IDBox1.Text))
                {
                    MessageBox.Show("ID or BookName is exist, Please Change!!!!");
                    IDBox1.Focus();
                    IDBox1.SelectAll();
                }
                else
                {
                    StreamWriter streamWriter1 = new StreamWriter("Books.txt", true);
                    string BookData = IDBox1.Text + " " + BookBox1.Text + " "+ GenBox.Text + " "+ AuBox.Text ;
                    IDBox1.Clear();
                    BookBox1.Clear();
                    GenBox.Clear();
                    AuBox.Clear();
                    streamWriter1.WriteLine(BookData);
                    streamWriter1.Close();
                    MessageBox.Show("Book is added");
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox)
                            control.Text = "";
                    }
                    BookBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        bool found;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ( BookBox1.Text.Trim() != "")
                {
                    StreamReader st = new StreamReader("Books.txt");
                    string s = "";
                    found = false;
                    do
                    {
                        s = st.ReadLine();
                        if (s != null)
                        {
                            string[] parts = s.Split(' ');
                            if (parts[1] == BookBox1.Text)
                            {
                                IDBox1.Text = parts[0];
                                GenBox.Text = parts[2];
                                AuBox.Text = parts[3];
                                found = true;
                                break;
                            }
                        }

                    } while (s != null);
                    st.Close();
                    if (!found)
                    {
                        MessageBox.Show("Book not found");
                        BookBox1.Focus();
                        BookBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter BookName and Try Again");
                    BookBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookBox1.Text.Trim() != "")
                {
                    StreamReader st = new StreamReader("Books.txt");
                    string s = "";
                    bool found = false;
                    do
                    {
                        s = st.ReadLine();
                        if (s != null)
                        {
                            string[] parts = s.Split(' ');
                            if (parts[1] == BookBox1.Text)
                            {
                                MessageBox.Show("Downloaded successfully 👍👍");
                                found = true;
                                break;
                            }
                        }

                    } while (s != null);
                    st.Close();
                    if (!found)
                    {
                        MessageBox.Show("Book not found");
                        BookBox1.Focus();
                        BookBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter BookName and Try Again");
                    BookBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookBox1.Text.Trim() != "")
                {
                    if (found == true)
                    {
                        StreamReader StreamReader = new StreamReader("Books.txt");
                        StreamWriter streamWriter = new StreamWriter("CopyBooks.txt");
                        string w = "", s = "";
                        do
                        {
                            w = StreamReader.ReadLine();
                            if (w != null)
                            {
                                string[] parts = w.Split(' ');
                                if (parts[1] != BookBox1.Text)
                                {
                                    s = parts[0] + " " + parts[1] + " " + parts[2]
                                 + " " + parts[3];
                                    streamWriter.WriteLine(s);
                                }
                            }
                        } while (w != null);
                        IDBox1.Clear();
                        BookBox1.Clear();
                        GenBox.Clear();
                        AuBox.Clear();
                        streamWriter.Close();
                        StreamReader.Close();
                        File.Delete("Books.txt");
                        File.Copy("CopyBooks.txt", "Books.txt");
                        File.Delete("CopyBooks.txt");
                        MessageBox.Show("Book has been deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Book not found");
                        BookBox1.Focus();
                        BookBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter BookName and Search for it First");
                    BookBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
