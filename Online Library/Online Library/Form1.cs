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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 5;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                MainForm mainForm2 = new MainForm();
                mainForm2.Show();
                this.Hide();
            }
        }
    }
}
