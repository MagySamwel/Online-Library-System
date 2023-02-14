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
    public partial class AuthorForm : Form
    {
        DataTable table = new DataTable("table");
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                if (IDBox.Text.Trim() == "" || NameBox.Text.Trim() == "" || PhoneBox.Text.Trim() == "" ||
             MailBox.Text.Trim() == "" || TypeBox.Text.Trim() == "" || NumBox.Text.Trim() == "")
                {
                    MessageBox.Show("Please, Enter all data and try again!!!");
                    return;
                }
                StreamReader streamReader = new StreamReader("Author.txt");
                string strCheck = streamReader.ReadToEnd();
                streamReader.Close();
                if (strCheck.Contains("#" + IDBox.Text)||strCheck.Contains(NameBox.Text))
                {
                    MessageBox.Show("ID or AuthorNamer is exist, Please Change!!!!");
                    IDBox.Focus();
                    IDBox.SelectAll();
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter("Author.txt", true);
                    string AuthorData = "#" + IDBox.Text + " " + NameBox.Text + " " + PhoneBox.Text
                        + " " + MailBox.Text + " " + TypeBox.Text + " " + NumBox.Text;
                    IDBox.Clear();
                    NameBox.Clear();
                    PhoneBox.Clear();
                    MailBox.Clear();
                    TypeBox.Clear();
                    NumBox.Clear();
                    streamWriter.WriteLine(AuthorData);
                    streamWriter.Close();
                    MessageBox.Show("Author is added");
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox)
                            control.Text = "";
                    }
                    IDBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("AuthorName", Type.GetType("System.String"));
            table.Columns.Add("Phone", Type.GetType("System.String"));
            table.Columns.Add("Mail", Type.GetType("System.String"));
            table.Columns.Add("BooksType", Type.GetType("System.String"));
            table.Columns.Add("NumOfBooks", Type.GetType("System.Int32"));
            dataGridView1.DataSource = table;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        bool found;
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text.Trim() != "")
                {
                    StreamReader st = new StreamReader("Author.txt");
                    string s = "";
                    found = false;
                    do
                    {
                        s = st.ReadLine();
                        if (s != null)
                        {
                            string[] parts = s.Split(' ');
                            if (parts[1] == NameBox.Text)
                            {
                                string x = "";
                                for (int i = 0; i < s.Length; i++)
                                {
                                    if (s[i] == ' ') { break; }
                                    if (s[i] != '#') { x = x + s[i]; }
                                }
                                IDBox.Text = x;
                                PhoneBox.Text = parts[2];
                                MailBox.Text = parts[3];
                                TypeBox.Text = parts[4];
                                NumBox.Text = parts[5];
                                found = true;
                                break;
                            }
                        }

                    } while (s != null);
                    st.Close();
                    if (!found)
                    {
                        MessageBox.Show("Author is not found");
                        NameBox.Focus();
                        NameBox.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter AuthorName and Try Again");
                    NameBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text.Trim() != "")
                {
                    if (found == true)
                    {
                        StreamReader StreamReader = new StreamReader("Author.txt");
                        StreamWriter streamWriter = new StreamWriter("CopyAuthor.txt");
                        string w = "", s = "";
                        do
                        {
                            w = StreamReader.ReadLine();
                            if (w != null)
                            {
                                string[] parts = w.Split(' ');
                                if (parts[0] == "#"+ IDBox.Text)
                                {
                                    s = parts[0] + " " + NameBox.Text + " " + PhoneBox.Text
                                 + " " + MailBox.Text + " " + TypeBox.Text + " " + NumBox.Text;
                                    streamWriter.WriteLine(s);
                                }
                                else { streamWriter.WriteLine(w); }
                            }
                        } while (w != null);
                        IDBox.Clear();
                        NameBox.Clear();
                        PhoneBox.Clear();
                        MailBox.Clear();
                        TypeBox.Clear();
                        NumBox.Clear();
                        streamWriter.Close();
                        StreamReader.Close();
                        File.Delete("Author.txt");
                        File.Copy("CopyAuthor.txt", "Author.txt");
                        File.Delete("CopyAuthor.txt");
                        MessageBox.Show("Data has been updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Author is not found");
                        NameBox.Focus();
                        NameBox.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter AuthorName and Search for it First");
                    NameBox.Focus();
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
                if (NameBox.Text.Trim() != "")
                {
                    if (found == true)
                    {
                        StreamReader StreamReader = new StreamReader("Author.txt");
                        StreamWriter streamWriter = new StreamWriter("CopyAuthor.txt");
                        string w = "", s = "";
                        do
                        {
                            w = StreamReader.ReadLine();
                            if (w != null)
                            {
                                string[] parts = w.Split(' ');
                                if (parts[1] != NameBox.Text)
                                {
                                    s = parts[0] + " " + parts[1] + " " + parts[2]
                                 + " " + parts[3] + " " + parts[4] + " " + parts[5];
                                    streamWriter.WriteLine(s);
                                }
                            }
                        } while (w != null);
                        IDBox.Clear();
                        NameBox.Clear();
                        PhoneBox.Clear();
                        MailBox.Clear();
                        TypeBox.Clear();
                        NumBox.Clear();
                        streamWriter.Close();
                        StreamReader.Close();
                        File.Delete("Author.txt");
                        File.Copy("CopyAuthor.txt", "Author.txt");
                        File.Delete("CopyAuthor.txt");
                        MessageBox.Show("Author has been deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Author is not found");
                        NameBox.Focus();
                        NameBox.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter AuthorName and Search for it First");
                    NameBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
