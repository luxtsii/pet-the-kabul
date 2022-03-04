using PetTheKabul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetTheKabul
{
    public partial class PetTheKabul : Form
    {
        public static Image kabulIdle;
        public static Image kabulPet;

        public static ContextMenu ctx;
        public static MenuItem exit;


        public PetTheKabul()
        {
            InitializeComponent();

            // Changes form size to be that of the picture. 
            this.Size = new Size(kabulBox.Width, kabulBox.Height);

            // Gets screen area and moves window to appropriate corner.
            Rectangle screenArea = Screen.GetWorkingArea(this);
            this.Location = new Point(screenArea.Right, screenArea.Bottom - Size.Height);

            // Some stuff
            ctx = new ContextMenu();
            exit = new MenuItem();

            // Merge
            ctx.MenuItems.AddRange(new MenuItem[] { exit });

            // Let there be exit button
            exit.Index = 0;
            exit.Text = "Goodbye Kabul";
            exit.Click += new System.EventHandler(this.exit_Click);

            // Merge x2
            kabulTray.ContextMenu = ctx;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Let it begin
            kabulIdle = Resources.idle;
            kabulPet = Resources.petting;

            // Blanched Almond
            this.BackColor = Color.BlanchedAlmond;
            this.TransparencyKey = Color.BlanchedAlmond;

            // Normel
            kabulBox.Image = kabulIdle;
        }

        private void kabulBox_MouseDown(object sender, MouseEventArgs e)
        {
            kabulBox.Image = kabulPet;
        }

        private void kabulBox_MouseUp(object sender, MouseEventArgs e)
        {
            kabulBox.Image = kabulIdle;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
