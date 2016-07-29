using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace AngeloSanchesCMPELab2
{
    /***********************************
      *Author: Angelo M Sanches
      * Extended func. to the program
      *************************************/
    public partial class DrawModel : Form
    {
        CDrawer Drawer; // a canvas to draw to
        new int Scale; // scale of the main form
        public Form1.Life[,] DrawLife; // an storage for the main container
        Color DrawColour;// our draw colour
        /***********************************
      *Author: Angelo M Sanches
      * insih all needed values
      *************************************/
        public DrawModel(int nScale, Form1.Life[,] Colours)
        {
            InitializeComponent();
            Scale = nScale;
            trackBar1.Value = Colours.GetLength(1);
            DrawColour = Color.Red;
            Drawer = new CDrawer(Scale * trackBar1.Value, Scale * trackBar1.Value, false);
            Drawer.Scale = Scale;
            DrawLife = Colours;
            DrawCheck.Enabled = true;
            // draws the last thing we had
            for (int i = 0; i < DrawLife.GetLength(0); i++)
            {
                for (int j = 0; j < DrawLife.GetLength(1); j++)
                {
                    if (DrawLife[i, j].bIsAlive)
                        Drawer.SetBBScaledPixel(i, j, DrawLife[i, j].Colour);
                }
            }
            // renders it
            Drawer.Render();
        }
        /***********************************
      *Author: Angelo M Sanches
      * makes a new resized canvas to draw to
      *************************************/
        private void Bu_ReSize_Click(object sender, EventArgs e)
        {
            DrawCheck.Enabled = false;
            Drawer.Close();
            Drawer = new CDrawer(Scale * trackBar1.Value, Scale * trackBar1.Value, false);
            Drawer.Scale = Scale;
            DrawLife = new Form1.Life[trackBar1.Value,trackBar1.Value];
            DrawCheck.Enabled = true;
        }
        /***********************************
      *Author: Angelo M Sanches
      * gets a draw colour
      *************************************/
        private void Bu_Colour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.Color != Color.Black)
                DrawColour = colorDialog1.Color;
        }
        /***********************************
      *Author: Angelo M Sanches
      * draws every time we click or eraces if need be
      *************************************/
        private void DrawCheck_Tick(object sender, EventArgs e)
        {
            Point Get;
            if (Drawer.GetLastMouseLeftClickScaled(out Get))
            {
                if (!DrawLife[Get.X, Get.Y].bIsAlive)
                {
                    DrawLife[Get.X, Get.Y].bIsAlive = true;
                    DrawLife[Get.X, Get.Y].Colour = DrawColour;
                    Drawer.SetBBScaledPixel(Get.X, Get.Y, DrawColour);
                }
                else
                {
                    DrawLife[Get.X, Get.Y].bIsAlive = false;
                    Drawer.SetBBScaledPixel(Get.X, Get.Y, Color.Black);
                }
                Drawer.Render();
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * safely closes the drawer and sets result
      *************************************/
        private void Bu_Ok_Click(object sender, EventArgs e)
        {
            DrawCheck.Enabled = false;
            Drawer.Close();
            DialogResult = DialogResult.OK;
        }
        /***********************************
      *Author: Angelo M Sanches
      * safely closes the drawer and sets result
      *************************************/
        private void Bu_Cancel_Click(object sender, EventArgs e)
        {
            DrawCheck.Enabled = false;
            Drawer.Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
