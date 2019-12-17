using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace VstudioTest
{
    public partial class Form1 : Form
    {
        ExploitAPI api = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            api.DoBTools();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string lua = fastColoredTextBox1.Text;
            api.SendLimitedLuaScript(lua);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.DoKill();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; 
        }
    }
}
