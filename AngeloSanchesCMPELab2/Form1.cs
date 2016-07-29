using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GDIDrawer;

namespace AngeloSanchesCMPELab2
{
    public partial class Form1 : Form
    {
        // basic call backs needed for our modeless form
        public delegate void VoidIntCallBack(int input);
        public delegate void VoidVoidCallBack();

        public VoidVoidCallBack FormClosingCallBack;// call back for modeless to tell us that is closing
        public VoidIntCallBack SizeCallBack;// call back for modeless to set size

        CDrawer Box;// our viewbox
        new int Scale;// the scale to draw at
        int wSizeX, wSizeY; // sizes left it out here for maybe modifying
        Random Ran; // our random noumber generator
        /***********************************
        *Author: Angelo M Sanches
        * A struct to contain all the vars for each cell
        * bool if alive
        * Colour for reprodction and drawing
        *************************************/
        public struct Life
        {
            public bool bIsAlive;
            public Color Colour;
            public Life(Color nColour, bool IsAlive = true) // this constructor is for if we want to load in data
            {
                bIsAlive = IsAlive;
                Colour = nColour;
            }
        }

        Life[,] Eco;// an displ. / origin array 
        Life[,] EcoNext;// an array for the next cycle
        Life[,] DrawLife;// an arat to draw from makes life easyer

        Color Colour; // colour to draw with for basic draw
        int Cycles; // our cycle we are on
        SpeedModel SpeedSelector; // a modeless form
        /***********************************
        *Author: Angelo M Sanches
        * inish varables
        *************************************/
        public Form1()
        {
            InitializeComponent();
            // scale and size to specs
            Scale = 10;
            wSizeX = 80;
            wSizeY = 60;
            // set all objects
            SizeCallBack = new VoidIntCallBack(ReturnSpeed);
            FormClosingCallBack = new VoidVoidCallBack(SpeedClosing);
            Ran = new Random();
            Colour = Color.Red;
            colorDialog1.Color = Color.Red;
            SpeedSelector = new SpeedModel(LifeCycle.Interval, SizeCallBack, FormClosingCallBack);
            Cycles = 0;
            // loaded in a basic glider into the drawer so we can draw it easly as a defualt
            /*
            {0,0,0,0,0
             0,1,1,1,0
             0,0,0,1,0
             0,0,1,0,0
             0,0,0,0,0}
            */
            DrawLife = new Life[,] {
                { new Life(), new Life(), new Life(), new Life(), new Life()},
                { new Life(), new Life(Color.Red) , new Life(Color.Red), new Life(Color.Red) , new Life()},
                { new Life(), new Life(), new Life(), new Life(Color.Red), new Life()},
                { new Life(), new Life(), new Life(Color.Red), new Life(), new Life()},
                { new Life(), new Life(), new Life(), new Life(), new Life()}
            };

        }
        /***********************************
        *Author: Angelo M Sanches
        * Load creates viewbox to size
        * and then populates to the desired amount
        *************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

            Box = new CDrawer(wSizeX * Scale, wSizeY * Scale, false);
            Box.Scale = Scale;
            Eco = new Life[wSizeX, wSizeY];
            EcoNext = new Life[wSizeX, wSizeY];
            // populating 
            for (int i = 0; i < 1000; i++)
            {
                int x = Ran.Next(Eco.GetLength(0)), y = Ran.Next(Eco.GetLength(1));
                if (Eco[x, y].bIsAlive)
                    i--;// if cell is already in use try again
                else
                {
                    Eco[x, y].bIsAlive = true;
                    Eco[x, y].Colour = Color.Red;
                }
            }
            Draw();
        }
        /***********************************
        *Author: Angelo M Sanches
        *Sets us up to draw things
        *************************************/
        private void Bu_Draw_Click(object sender, EventArgs e)
        {
            // if  we are using the exteed draw creat a form for it and grab results
            if (Ch_DrawShape.Checked && DrawChecker.Enabled == false)
            {
                DrawModel newDraws = new DrawModel(Scale, DrawLife);
                if (newDraws.ShowDialog() == DialogResult.OK)
                {
                    DrawLife = newDraws.DrawLife;
                }
            }
            // else just grab a colour and go
            else if (DrawChecker.Enabled == false)
            {
                colorDialog1.ShowDialog();
                if (Colour != Color.Black)
                    Colour = colorDialog1.Color;
            }
            // if we want to clear clear
            if (DrawChecker.Enabled == false && !Ch_DoNotDrawClear.Checked)
            {
                Eco = new Life[wSizeX, wSizeY];
                Draw();
            }
            // clear last mouse  click and start tick
            Point dummy;
            Box.GetLastMouseLeftClickScaled(out dummy);
            DrawChecker.Enabled = !DrawChecker.Enabled;
        }
        /***********************************
        *Author: Angelo M Sanches
        *Does the actual drawing
        *************************************/
        private void DrawChecker_Tick(object sender, EventArgs e)
        {
            // get a point of last mouse click scaled
            Point Point;
            if (Box.GetLastMouseLeftClickScaled(out Point))
            {
                // we draw off cursor if using extended draw
                if (Ch_DrawShape.Checked)
                {
                    for (int i = 0; i < DrawLife.GetLength(0); i++)
                    {
                        for (int j = 0; j < DrawLife.GetLength(1); j++)
                        {
                            // for each point draw off of the click
                            Eco[LimWraper(Point.X + i, 0, Eco.GetLength(0)),
                                LimWraper(Point.Y + j, 0, Eco.GetLength(1))].bIsAlive = DrawLife[i,j].bIsAlive;
                            Eco[LimWraper(Point.X + i, 0, Eco.GetLength(0)),
                                LimWraper(Point.Y + j, 0, Eco.GetLength(1))].Colour = DrawLife[i, j].Colour;
                        }
                    }
                    // re-render all
                    Draw();
                }
                // else we just set a single point and render that difference
                else
                {
                    if (!Eco[Point.X, Point.Y].bIsAlive)
                    {
                        Eco[Point.X, Point.Y].bIsAlive = true;
                        Eco[Point.X, Point.Y].Colour = Colour;
                        Box.SetBBScaledPixel(Point.X, Point.Y, Colour);
                    }
                    else
                    {
                        Eco[Point.X, Point.Y].bIsAlive = false;
                        Box.SetBBScaledPixel(Point.X, Point.Y, Color.Black);
                    }
                    Box.Render();
                }
            }
        }
      /***********************************
      *Author: Angelo M Sanches
      * Cycles on a tic real lifting is done in calc and draw
      *************************************/
        private void LifeCycle_Tick(object sender, EventArgs e)
        {
            Calc();
            Draw();
        }
        /***********************************
        *Author: Angelo M Sanches
        * enables and disables things to start and create a smooth ui along with cYcle tictick
        * also opens the modeless dialog
        *************************************/
        private void Bu_Start_Click(object sender, EventArgs e)
        {
            SpeedSelector.Show();
            Bu_Stop.Enabled = true;
            Bu_Start.Enabled = false;
            LifeCycle.Enabled = true;
        }
        /***********************************
        *Author: Angelo M Sanches
        * enables and disables things to start and create a smooth ui along with cYcle tictick
        * also hides the modeless dialog
        *************************************/
        private void Bu_Stop_Click(object sender, EventArgs e)
        {
            SpeedSelector.Hide();
            Bu_Start.Enabled = true;
            Bu_Stop.Enabled = false;
            LifeCycle.Enabled = false;
        }
        /***********************************
        *Author: Angelo M Sanches
        *Cycles onece real lifting is done in calc and draw
        *************************************/
        private void Bu_Cycles_Click(object sender, EventArgs e)
        {
            Calc();
            Draw();
        }
        /***********************************
        *Author: Angelo M Sanches
        *for every cell renders onto view window acording to if alive or dead
        *************************************/
        public void Draw()
        {

            for (int i = 0; i < Eco.GetLength(0); i++)
            {
                for (int j = 0; j < Eco.GetLength(1); j++)
                {
                    if (Eco[i, j].bIsAlive)
                        Box.SetBBScaledPixel(i, j, Eco[i, j].Colour);
                    else
                        Box.SetBBScaledPixel(i, j, Color.Black);
                }
            }
           
            Box.Render();
        }
        /***********************************
        *Author: Angelo M Sanches
        *The HEAVY LIFTER calc calculates every cycle and throws out the old values
        *************************************/
        public void Calc()
        {
            // a list for parents will both cound and store the colour we need
            List<Color> Parents = new List<Color>(9);
            // final x, y left them sepreate for debuging
            int p, m;
            // for each x
            for (int i = 0; i < Eco.GetLength(0); i++)
            {
                // for each y
                for (int j = 0; j < Eco.GetLength(1); j++)
                {
                    // rest parents and their count from last time
                    Parents.Clear();
                    // for loop to get values offset could have done it with a for each tho out of an offset int array
                    // x offset
                    for (int k = -1; k < 2; k++)
                    {
                        // y offset
                        for (int l =-1; l < 2; l++)
                        {
                            // add them and call wrapper to bring back to bounds
                            p = LimWraper(i + k, 0, Eco.GetLength(0));
                            m = LimWraper(j + l, 0, Eco.GetLength(1));

                            // if it is alive and noth the original than count & store it
                            if (Eco[p, m].bIsAlive && (p != i || m != j))
                            {
                                Parents.Add(Eco[p, m].Colour);
                            }
                        }
                    }

                    // if it is alive
                    if (Eco[i, j].bIsAlive)
                    {
                        // kill it unless first two cases then maybe re roll-colour
                        switch(Parents.Count())
                        {
                            case 2:
                                EcoNext[i, j].bIsAlive = true;
                                EcoNext[i, j].Colour = Parents[Ran.Next(0, 2)];
                                break;
                            case 3:
                                EcoNext[i, j].bIsAlive = true;
                                EcoNext[i, j].Colour = Parents[Ran.Next(0, 3)];
                                break;
                            default:
                                EcoNext[i, j].bIsAlive = false;
                                break;
                        }
                    }
                    // if dead with three parents make a baby awe and kinda grose (-_-) =>three parents?)
                    else if ((!Eco[i, j].bIsAlive) && Parents.Count() == 3)
                    {
                        EcoNext[i, j].bIsAlive = true;
                        EcoNext[i, j].Colour = Parents[Ran.Next(0, 3)];
                    }
                }
            }

            // set to forward array throw out the old and count/display cycle
            Eco = EcoNext;
            EcoNext = new Life[wSizeX, wSizeY];
            Cycles++;
            Tb_Cycles.Text = Cycles.ToString();
        }
        /***********************************
        *Author: Angelo M Sanches
        *simple wrap alga. keeps it in bounds set by min / max
        *************************************/
        // move to a lib
        int LimWraper(int input, int Min,int Max)
        {
            // get a range from max and min
            int range = Max - Min;
            // if its nagative aparent in C# the remainder is neg too so use it
            // and add to max not like subtrating from max since neg
            if (input < Min)
                return Max + (input % range);
            // add the remmindre to min
            else
                return Min + (input % range);

        }
        /***********************************
        *Author: Angelo M Sanches
        *simple wrap alga. keeps it in bounds set by min / max
        *************************************/
        // this is a form closing to make sure that the other form closes too since interceped normaly and all;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpeedSelector.CanClose = true;
            SpeedSelector.Close();
            Box.Close();
        }
        /***********************************
        *Author: Angelo M Sanches
        *Repopulates the form note the other form takes on around half the work with the calculations of the numbers to populate with
        *************************************/
        private void Bu_NewPattern_Click(object sender, EventArgs e)
        {
            // make a new dialog and grab results
            PatternModel NewEco = new PatternModel(Eco.Length);
            if (NewEco.ShowDialog() == DialogResult.OK)
            {
                // reset every thing
                Cycles = 0;
                Tb_Cycles.Text = Cycles.ToString();
                Eco = new Life[wSizeX, wSizeY];
                // populate for all colours repeated 3 times for every colour
                for (int i = 0; i < NewEco.RedPercent; i++)
                {
                    int x = Ran.Next(Eco.GetLength(0)), y = Ran.Next(Eco.GetLength(1));
                    if (Eco[x, y].bIsAlive)
                        i--;
                    else
                    {
                        Eco[x, y].bIsAlive = true;
                        Eco[x, y].Colour = Color.Red;
                    }
                }
                for (int i = 0; i < NewEco.BluePercent; i++)
                {
                    int x = Ran.Next(Eco.GetLength(0)), y = Ran.Next(Eco.GetLength(1));
                    if (Eco[x, y].bIsAlive)
                        i--;
                    else
                    {
                        Eco[x, y].bIsAlive = true;
                        Eco[x, y].Colour = Color.Blue;
                    }
                }
                for (int i = 0; i < NewEco.GreenPercent; i++)
                {
                    int x = Ran.Next(Eco.GetLength(0)), y = Ran.Next(Eco.GetLength(1));
                    if (Eco[x, y].bIsAlive)
                        i--;
                    else
                    {
                        Eco[x, y].bIsAlive = true;
                        Eco[x, y].Colour = Color.Green;
                    }
                }
                Draw();
            }
            // if we want to clear thats cool too added functionality
            else if (NewEco.DialogResult == DialogResult.Yes)
            {
                Eco = new Life[wSizeX, wSizeY];
                Draw();
            }
        }

        // delegates all for speed form
        /***********************************
        *Author: Angelo M Sanches
        *Just a callback that return a value
        *************************************/
        void ReturnSpeed(int input)
        {
            LifeCycle.Interval = input;
        }


        /***********************************
        *Author: Angelo M Sanches
        *that lets us know some one was "CLosing" the form
        *************************************/
        void SpeedClosing()
        {
            SpeedSelector.Hide();
            Bu_Start.Enabled = true;
            Bu_Stop.Enabled = false;
            LifeCycle.Enabled = false;
        }

    }
}
