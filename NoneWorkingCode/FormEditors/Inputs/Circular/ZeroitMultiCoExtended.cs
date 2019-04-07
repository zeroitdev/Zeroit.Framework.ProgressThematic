using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zeroit.Framework.ProgressThematic.ThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {


        #region Private Properties

        private bool MCEx_showInnerBorder = true;
        private int MCEx_innerBorder = 2;
        private int MCEx_shift = 15;
        private int MCEx_correctShift = 6;
        private int MCEx_rectShift = 3;
        private Rings MCEx_noOfRings = Rings.One;
        private Color MCEx_innerBorderColor = Color.Gray;
        Color[] MCEx_colors = new Color[]
            {
                Color.Red,
                Color.Yellow,
                Color.Green,
                Color.AliceBlue,
                Color.Brown,
                Color.Chocolate,
                Color.DarkOrange,
                Color.DarkRed,
                Color.DeepPink,
                Color.Indigo,
                Color.Ivory,
                Color.Lavender,
                Color.LightSeaGreen,
                Color.Maroon,
                Color.OrangeRed,
                Color.Orchid,
                Color.PaleGoldenrod,
                Color.PapayaWhip,
                Color.Teal,
                Color.Tomato,
                Color.YellowGreen,
                Color.Thistle,
                Color.Tan,
                Color.SlateGray,
            };
        
        
        #endregion

        #region Public Properties


        [Category("CircularProgress MCEx")]
        public Color MCEx_InnerBorderColor
        {
            get { return MCEx_innerBorderColor; }
            set
            {
                MCEx_innerBorderColor = value;
                
            }
        }

        //public float valConverted
        //{
        //    get
        //    {
        //        return value;
        //    }

        //    set
        //    {
        //        this.value = value;
        //        
        //    }
        //}

        //public int Speed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        speed = value;
        //        
        //    }
        //}

        [Category("CircularProgress MCEx")]
        public Color[] MCEx_Colors
        {
            get { return MCEx_colors; }
            set
            {
                MCEx_colors = value;
                
            }
        }

        //public enum Rings
        //{
        //    Default,
        //    One,
        //    Two,
        //    Four,
        //    Eight,
        //    Twelve,
        //    TwentyFour
        //}

        [Category("CircularProgress MCEx")]
        public Rings MCEx_NoOfRings
        {
            get { return MCEx_noOfRings; }
            set
            {
                MCEx_noOfRings = value;
                
            }
        }

        [Category("CircularProgress MCEx")]
        public bool MCEx_ShowInnerBorder
        {
            get { return MCEx_showInnerBorder; }
            set
            {
                MCEx_showInnerBorder = value;
                
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_InnerBorder
        {
            get { return MCEx_innerBorder; }
            set
            {
                MCEx_innerBorder = value;
                
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_InnerShift
        {
            get { return MCEx_rectShift; }
            set
            {
                MCEx_rectShift = value;
                
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_CorrectShift
        {
            get { return MCEx_correctShift; }
            set
            {
                MCEx_correctShift = value;
                
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_Shift
        {
            get { return MCEx_shift; }
            set
            {
                MCEx_shift = value;
                
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_RectShift
        {
            get { return MCEx_rectShift; }
            set
            {
                MCEx_rectShift = value;
                
            }
        }

        
        #endregion


    }
}
