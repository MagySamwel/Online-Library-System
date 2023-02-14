using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Library
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (IDCat1.Text.Trim() == "" || NameCat1.Text.Trim() == "" || NumCat.Text.Trim() == "")
                {
                    MessageBox.Show("Please, Enter all data and try again!!!");
                    return;
                }
                StreamReader streamReader1 = new StreamReader("Category.txt");
                string strCheck = streamReader1.ReadToEnd();
                streamReader1.Close();
                if (strCheck.Contains("#"+IDCat1.Text)||strCheck.Contains(NameCat1.Text))
                {
                    MessageBox.Show("ID or CategoryName is exist,Please Change!!!!");
                    IDCat1.Focus();
                    IDCat1.SelectAll();
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter("Category.txt", true);
                    string AuthorData ="#"+ IDCat1.Text + " " + NameCat1.Text + " " + NumCat.Text;
                    IDCat1.Clear();
                    NameCat1.Clear();
                    NumCat.Clear();
                    streamWriter.WriteLine(AuthorData);
                    streamWriter.Close();
                    MessageBox.Show("Category is added");
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox)
                            control.Text = "";
                    }
                    IDCat1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        bool found=true;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameCat1.Text.Trim() != "")
                {
                    if (found == true)
                    {
                        StreamReader StreamReader = new StreamReader("Category.txt");
                        StreamWriter streamWriter = new StreamWriter("CopyCategory.txt");
                        string w = "", s = "";
                        do
                        {
                            w = StreamReader.ReadLine();
                            if (w != null)
                            {
                                string[] parts = w.Split(' ');
                                if (parts[0] == "#" + IDCat1.Text)
                                {
                                    s = parts[0] + " " + NameCat1.Text + " " + NumCat.Text;
                                    streamWriter.WriteLine(s);
                                }
                                else { streamWriter.WriteLine(w); }
                            }
                        } while (w != null);
                        IDCat1.Clear();
                        NameCat1.Clear();
                        NumCat.Clear();
                        streamWriter.Close();
                        StreamReader.Close();
                        File.Delete("Category.txt");
                        File.Copy("CopyCategory.txt", "Category.txt");
                        File.Delete("CopyCategory.txt");
                        MessageBox.Show("Data has been updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Category is not found");
                        NameCat1.Focus();
                        NameCat1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter CategoryName");
                    NameCat1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void NameCat1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
