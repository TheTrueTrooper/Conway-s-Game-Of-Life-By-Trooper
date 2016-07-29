using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngeloSanchesCMPELab2
{
    public partial class SpeedModel : Form
    {
        public bool CanClose;// lets us close
        // call back types from main form
        Form1.VoidIntCallBack CallBack;
        Form1.VoidVoidCallBack CallBack2;
        /***********************************
      *Author: Angelo M Sanches
      * Inishes the values and sets call backs
      *************************************/
        public SpeedModel(int Speed, Form1.VoidIntCallBack nCallBack, Form1.VoidVoidCallBack nCallBack2)
        {
            InitializeComponent();
            trackBar1.Value = Speed;
            CallBack = nCallBack;
            CallBack2 = nCallBack2;
        }
        /***********************************
      *Author: Angelo M Sanches
      * call back to the main with a return val
      *************************************/
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CallBack.Invoke(trackBar1.Value);
        }
        /***********************************
      *Author: Angelo M Sanches
      * sims closing by hiding calls back to the form that we are hiden and halts closing
      *************************************/
        private void SpeedModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanClose)// this is to let it close with no problems if needed
            {
                Hide();
                CallBack2.Invoke();
                e.Cancel = true;
            }
        }
    }
}
