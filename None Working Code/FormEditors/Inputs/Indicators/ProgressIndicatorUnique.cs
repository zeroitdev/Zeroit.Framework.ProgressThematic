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


        #region Private Fields

        private int Unique_interval = 100;
        private Color Unique_circleColor = Color.FromArgb(20, 20, 20);
        private float Unique_circleSize = 1.0F;
        private int Unique_numberOfCircles = 8;
        private int Unique_numberOfVisibleCircles = 8;
        private Unique_RotationType Unique_rotation = Unique_RotationType.Clockwise;
        private float Unique_percentage = 0;
        private bool Unique_showPercentage = false;
        private bool Unique_showText = false;
        private Unique_TextDisplayModes Unique_textDisplay = Unique_TextDisplayModes.None;

        #endregion

        #region Public Properties

        public Color Unique_CircleColor
        {
            get { return Unique_circleColor; }
            set
            {
                Unique_circleColor = value;
                
            }
        }
        
        public float Unique_CircleSize
        {
            get { return Unique_circleSize; }
            set { Unique_circleSize = value; }
        }

        public int Unique_AnimationSpeed
        {
            get { return Unique_interval; }
            set { Unique_interval = value; }
        }
        
        public float Unique_NumberOfCircles
        {
            get { return Maximum; }
            set
            {
                
                Maximum = value;
                
            }
        }
        
        public int Unique_NumberOfVisibleCircles
        {
            get { return Unique_numberOfVisibleCircles; }
            set
            {
                
                Unique_numberOfVisibleCircles = value;
                
            }
        }
        
        public Unique_RotationType Unique_Rotation
        {
            get { return Unique_rotation; }
            set
            {
                Unique_rotation = value;
            }
        }
        
        public float Unique_Percentage
        {
            get { return Unique_percentage; }
            set
            {
                
                Unique_percentage = value;
            }
        }
        
        public bool Unique_ShowPercentage
        {
            get { return Unique_showPercentage; }
            set
            {
                Unique_showPercentage = value;
                
            }
        }
        
        public bool Unique_ShowText
        {
            get { return Unique_showText; }
            set
            {
                Unique_showText = value;

                
            }
        }
        
        public Unique_TextDisplayModes Unique_TextDisplay
        {
            get { return Unique_textDisplay; }
            set
            {
                Unique_textDisplay = value;
                
            }
        }

        #endregion

    }
}
