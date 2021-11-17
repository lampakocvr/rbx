using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;

namespace WindowsFormsApp2
{
    public partial class fckscxt : Form
    {
        bool mouseDown;
        private Point offset;

        Module epic = new Module();
        public fckscxt()
        {
            InitializeComponent();
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            epic.LaunchExploit();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            epic.ExecuteScript(richTextBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            epic.killRoblox();
        }

        private void robloxkill_Click(object sender, EventArgs e)
        {
            epic.killRoblox();
        }

        private void mouseDown_event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void MouseUp_E(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
