using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter
{
    public partial class Form1 : Form
    {
        Core.MainScreen mainscreen = new Core.MainScreen();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            mainscreen.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            mainscreen.KeyDown(e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            mainscreen.KeyUp(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainscreen.currentScreen = new Street_Fighter.Screen.SelectScreen(new SizeF(pictureBox1.Width, pictureBox1.Height), 20, mainscreen);
        }
    }
}
