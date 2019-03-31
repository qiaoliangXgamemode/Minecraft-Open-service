using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Minecraft_Open_service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);



        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (File.Exists(Application.StartupPath + @"\jar.ini"))
                           {
                               
                           }
                        else
                            {
                string[] lines = {textBox1.Text};
                System.IO.File.WriteAllLines(Application.StartupPath + @"\jar.ini", lines, Encoding.Default);
            }
            string str = File.ReadAllText(Application.StartupPath + @"\jar.ini", Encoding.Default);
            textBox5.Text = str;
            textBox1.Lines = new string[] { textBox5.Lines[0] };
            textBox2.Lines = new string[] { textBox5.Lines[1] };
            textBox3.Lines = new string[] { textBox5.Lines[2] };
            textBox4.Lines = new string[] { textBox5.Lines[3] };
            System.IO.Directory.CreateDirectory(Application.StartupPath + @"\start\");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form2 form2 = new Form2();
            form2.Show();
            timer1.Enabled = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = Control.MousePosition.X;
            int y = Control.MousePosition.Y;
            Form2 form2 = new Form2();
            form2.Show();
            form2.Location = new Point(x + 18,y - 16);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
    

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X; //鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y; //鼠标的y坐标为当前窗体左上角y坐标
            }
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "java(java.exe)|java.exe";
            this.openFileDialog1.FileName = "请选择java.exe，如果不懂java或者不知道在哪请百度.";
            openFileDialog1.InitialDirectory = @"C:\Program Files\Java\";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            string[] lines = { textBox1.Text +"\r\n"+textBox2.Text + "\r\n" + textBox3.Text + "\r\n" + textBox4.Text };
            System.IO.File.WriteAllLines(Application.StartupPath + @"\jar.ini", lines, Encoding.Default);
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "java(java.exe)|java.exe";
            this.openFileDialog1.FileName = "请选择java.exe，如果不懂java或者不知道在哪请百度.";
            openFileDialog1.InitialDirectory = @"C:\Program Files\Java\";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            string[] lines = { textBox1.Text + "\r\n" + textBox2.Text + "\r\n" + textBox3.Text + "\r\n" + textBox4.Text };
            System.IO.File.WriteAllLines(Application.StartupPath + @"\jar.ini", lines, Encoding.Default);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char result = e.KeyChar;
            if (char.IsDigit(result) || result == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "java(*.jar)|*.jar";
            this.openFileDialog1.FileName = "请找到开服的jar";
            openFileDialog1.InitialDirectory = Application.StartupPath+ @"\";
            openFileDialog1.ShowDialog();
            textBox4.Text = openFileDialog1.FileName;
            string[] lines = { textBox1.Text + "\r\n" + textBox2.Text + "\r\n" + textBox3.Text + "\r\n" + textBox4.Text };
            System.IO.File.WriteAllLines(Application.StartupPath + @"\jar.ini", lines, Encoding.Default);
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "java(*.jar)|*.jar";
            this.openFileDialog1.FileName = "请找到开服的jar";
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\";
            openFileDialog1.ShowDialog();
            textBox4.Text = openFileDialog1.FileName;
            string[] lines = { textBox1.Text + "\r\n" + textBox2.Text + "\r\n" + textBox3.Text + "\r\n" + textBox4.Text };
            System.IO.File.WriteAllLines(Application.StartupPath + @"\jar.ini", lines, Encoding.Default);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            string[] lines = { "@ECHO OFF \r\n"+ "\"" + textBox1.Text+"\"" +"\0"+ "-Xms" + textBox2.Text+"M"+"\0"+ "-Xmx"+textBox3.Text+"M" +"\0"+"-jar\0" +textBox4.Text+ "\r\nPAUSE" };
            System.IO.File.WriteAllLines(Application.StartupPath+@"\start\start.bat",lines, Encoding.Default);
            System.Threading.Thread.Sleep(500);
            System.Diagnostics.Process.Start(Application.StartupPath + @"\start\start.bat");
            textBox3.SelectedText = textBox1.SelectedText;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            string[] lines = {"@ECHO OFF \r\n" + "\"" + textBox1.Text + "\"" + "\0" + "-Xms" + textBox2.Text + "M" + "\0" + "-Xmx" + textBox3.Text + "M" + "\0" + "-jar\0" + textBox4.Text + "\r\nPAUSE"};
            System.IO.File.WriteAllLines(Application.StartupPath + @"\start\start.bat",lines,Encoding.Default);
            System.Threading.Thread.Sleep(500);
            System.Diagnostics.Process.Start(Application.StartupPath + @"\start\start.bat");
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
    }
    }
}
