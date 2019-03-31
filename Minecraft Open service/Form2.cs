using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Open_service
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
     
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Enabled = false;
            this.TopMost = true;
            form1.TopMost = true;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.TopMost = true;
            form1.TopMost = true;
            this.Hide();
            form1.Enabled = true;
            form1.TopMost = false;
            this.TopMost = false;
        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\windows\Private.BlurClear.exe");
        }
    }
}
