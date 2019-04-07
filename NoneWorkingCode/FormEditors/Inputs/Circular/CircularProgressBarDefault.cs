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

        #region Variables



        private Color CircularDef_ProgressColor1 = Color.FromArgb(92, 92, 92);
        private Color CircularDef_ProgressColor2 = Color.FromArgb(92, 92, 92);

        private Color CircularDef_InnerColor1 = Color.FromArgb(0x34, 0x34, 0x34);
        private Color CircularDef_InnerColor2 = Color.FromArgb(0x34, 0x34, 0x34);


        private _ProgressShape CircularDef_ProgressShapeVal = _ProgressShape.Round;

        #endregion

        #region Public Properties

        
        public Color ProgressColor1_Default
        {
            get { return CircularDef_ProgressColor1; }
            set
            {
                CircularDef_ProgressColor1 = value;
                
            }
        }

        
        public Color ProgressColor2_Default
        {
            get { return CircularDef_ProgressColor2; }
            set
            {
                CircularDef_ProgressColor2 = value;
                
            }
        }
        
        public Color ProgressInnerColor1_Default
        {
            get { return CircularDef_InnerColor1; }
            set
            {
                CircularDef_InnerColor1 = value;
                
            }
        }

        
        public Color ProgressInnerColor2_Default
        {
            get { return CircularDef_InnerColor2; }
            set
            {
                CircularDef_InnerColor2 = value;
                
            }
        }

        
        public _ProgressShape ProgressShape_Default
        {
            get { return CircularDef_ProgressShapeVal; }
            set
            {
                CircularDef_ProgressShapeVal = value;
                
            }
        }



        #endregion

    }
}
