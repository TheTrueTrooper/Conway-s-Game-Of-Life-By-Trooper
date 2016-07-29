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
    public partial class PatternModel : Form
    {
        /***********************************
      *Author: Angelo M Sanches
      * filltypes to return for 
      *************************************/
        public enum FillTypes
        {
            Value,
            Percent
        }
        /***********************************
      *Author: Angelo M Sanches
      * colour types to return for
      *************************************/
        public enum ColourTypes
        {
            red,
            blue,
            green,
            custom
        }
        // fill style return state
        FillTypes Fill;
        // colour style return state
        ColourTypes Colours;
        // a dummy var for retuning blue calc are done in side
        public int BluePercent
        {
            get
            {
                switch (Fill)
                {
                    // case fill easy to handle just return the precent * number for all colours
                    case FillTypes.Value:
                        switch (Colours)
                        {
                            case ColourTypes.blue:
                                return TrBa_Value.Value;
                            case ColourTypes.custom:
                                return (int)(TrBa_Value.Value * (double)TrBa_BluePercent.Value / 100);
                            default:
                                return 0;
                        }
                    case FillTypes.Percent:
                        switch (Colours)
                        {
                            case ColourTypes.blue:
                                return (int)(Sizez * TrBa_Percent.Value / 100);
                            case ColourTypes.custom:
                                return (int)(Sizez * TrBa_Percent.Value / 100 * (double)TrBa_BluePercent.Value / 100);
                            default:
                                return 0;
                        }
                    default: // case is only to make the compiler happy :)
                        return 0;
                }
            }
        }
        // a dummy var for retuning blue calc are done in side
        public int GreenPercent
        {
            // clone but for green of blue ref blue for more
            get
            {
                switch (Fill)
                {
                    case FillTypes.Value:
                        switch (Colours)
                        {
                            case ColourTypes.green:
                                return TrBa_Value.Value;
                            case ColourTypes.custom:
                                return (int)(TrBa_Value.Value * (double)TrBa_GreenPercent.Value / 100);
                            default:
                                return 0;
                        }
                    case FillTypes.Percent:
                        switch (Colours)
                        {
                            case ColourTypes.green:
                                return (int)(Sizez * TrBa_Percent.Value / 100);
                            case ColourTypes.custom:
                                return (int)(Sizez * TrBa_Percent.Value / 100 * (double)TrBa_GreenPercent.Value / 100);
                            default:
                                return 0;
                        }
                    default:
                        return 0;
                }
            }
        }
        // a dummy var for retuning blue calc are done in side
        public int RedPercent {
            get {
                // clone but for red of blue ref blue for more
                switch (Fill)
                {
                    case FillTypes.Value:
                        switch(Colours)
                        {
                            case ColourTypes.red:
                                return TrBa_Value.Value;
                            case ColourTypes.custom:
                                return (int)(TrBa_Value.Value * (double)TrBa_RedPercent.Value/100);
                            default:
                                return 0;
                        }
                    case FillTypes.Percent:
                        switch (Colours)
                        {
                            case ColourTypes.red:
                                return (int)(Sizez * TrBa_Percent.Value / 100);
                            case ColourTypes.custom:
                                return (int)(Sizez * TrBa_Percent.Value / 100 * (double)TrBa_RedPercent.Value / 100);
                            default:
                                return 0;
                        }
                    default:
                        return 0;
                }
            } }
        
        int Sizez;// the overall size of the Viewbox for precent calcs
        /***********************************
      *Author: Angelo M Sanches
      * inish the form
      *************************************/
        public PatternModel(int nSize)
        {
            InitializeComponent();
            Fill = FillTypes.Value;
            Colours = ColourTypes.red;
            Sizez = nSize;

        }
        /***********************************
      *Author: Angelo M Sanches
      * does a pecent calc to set all the scroll wheels in sync
      * note the small decimal is required to prevent lock ups and the total must have them added up
      *************************************/
        private void TrBa_RedPercent_Scroll(object sender, EventArgs e)
        {
            double Total = TrBa_RedPercent.Value + TrBa_BluePercent.Value + TrBa_GreenPercent.Value + 0.0000000000003;
            if (Total != 100)
            {
                TrBa_BluePercent.Value = (int)(100 * (TrBa_BluePercent.Value + 0.0000000000001) / Total);
                TrBa_RedPercent.Value = (int)(100 * (TrBa_RedPercent.Value + 0.0000000000001) / Total);
                TrBa_GreenPercent.Value = (int)(100 * (TrBa_GreenPercent.Value + 0.0000000000001) / Total);
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * does a pecent calc to set all the scroll wheels in sync
      * note the small decimal is required to prevent lock ups and the total must have them added up
      *************************************/
        private void TrBa_GreenPercent_Scroll(object sender, EventArgs e)
        {
            double Total = TrBa_RedPercent.Value + TrBa_BluePercent.Value + TrBa_GreenPercent.Value + 0.0000000000003;
            if (Total != 100)
            {
                TrBa_BluePercent.Value = (int)(100 * (TrBa_BluePercent.Value + 0.0000000000001) / Total);
                TrBa_RedPercent.Value = (int)(100 * (TrBa_RedPercent.Value + 0.0000000000001) / Total);
                TrBa_GreenPercent.Value = (int)(100 * (TrBa_GreenPercent.Value + 0.0000000000001) / Total);
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * does a pecent calc to set all the scroll wheels in sync
      * note the small decimal is required to prevent lock ups and the total must have them added up
      *************************************/
        private void TrBa_BluePercent_Scroll(object sender, EventArgs e)
        {
            double Total = TrBa_RedPercent.Value + TrBa_BluePercent.Value + TrBa_GreenPercent.Value + 0.0000000000003;
            if (Total != 100)
            {
                TrBa_BluePercent.Value = (int)(100 * (TrBa_BluePercent.Value + 0.0000000000001) / Total);
                TrBa_RedPercent.Value = (int)(100 * (TrBa_RedPercent.Value + 0.0000000000001) / Total);
                TrBa_GreenPercent.Value = (int)(100 * (TrBa_GreenPercent.Value + 0.0000000000001) / Total);
            }
            
        }
        /***********************************
      *Author: Angelo M Sanches
      * enables ui for percents and sets the colour return state
      *************************************/
        private void RaBu_Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (RaBu_Custom.Checked)
            {
                TrBa_BluePercent.Enabled = true;
                TrBa_RedPercent.Enabled = true;
                TrBa_GreenPercent.Enabled = true;
                Colours = ColourTypes.custom;
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * switchs the ui for overall percent/Value and sets the fill return state
      *************************************/
        private void RaBu_Value_CheckedChanged(object sender, EventArgs e)
        {
            if (RaBu_Value.Checked)
            {
                TrBa_Percent.Enabled = false;
                TrBa_Value.Enabled = true;
                Fill = FillTypes.Value;
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * switchs the ui for overall percent/Value and sets the fill return state
      *************************************/
        private void RaBu_Percent_CheckedChanged(object sender, EventArgs e)
        {
            if (RaBu_Percent.Checked)
            {
                TrBa_Percent.Enabled = true;
                TrBa_Value.Enabled = false;
                Fill = FillTypes.Percent;
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * disables ui for percents and sets the colour return state
      *************************************/
        private void RaBu_Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (RaBu_Blue.Checked)
            {
                TrBa_BluePercent.Enabled = false;
                TrBa_RedPercent.Enabled = false;
                TrBa_GreenPercent.Enabled = false;
                Colours = ColourTypes.blue;
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * disables ui for percents and sets the colour return state
      *************************************/
        private void RaBu_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (RaBu_Green.Checked)
            {
                TrBa_BluePercent.Enabled = false;
                TrBa_RedPercent.Enabled = false;
                TrBa_GreenPercent.Enabled = false;
                Colours = ColourTypes.green;
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * disables ui for percents and sets the colour return state
      *************************************/
        private void RaBu_Red_CheckedChanged(object sender, EventArgs e)
        {
            if (RaBu_Red.Checked)
            {
                TrBa_BluePercent.Enabled = false;
                TrBa_RedPercent.Enabled = false;
                TrBa_GreenPercent.Enabled = false;
                Colours = ColourTypes.red;
            }
        }
        /***********************************
      *Author: Angelo M Sanches
      * sets dialog result
      *************************************/
        private void Bu_Clear_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
        /***********************************
      *Author: Angelo M Sanches
      * sets dialog result
      *************************************/
        private void Bu_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        /***********************************
      *Author: Angelo M Sanches
      * sets dialog result
      *************************************/
        private void Bu_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
