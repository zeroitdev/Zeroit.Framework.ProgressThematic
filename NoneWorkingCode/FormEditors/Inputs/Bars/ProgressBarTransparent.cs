using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        private Boolean _ShowText = true;
        private Color _ProgressBackground = Color.Blue;
        private Color Trns_progressColor1 = Color.Red;
        private Color Trns_progressColor2 = Color.Gray;

        #endregion

        #region Public Properties

        [Category("RectangularProgress Transparent")]
        public Boolean Trans_ShowText
        {
            get { return _ShowText; }
            set
            {
                _ShowText = value;
                
            }
        }

        [Category("RectangularProgress Transparent")]
        public Color Trans_Background
        {
            get
            {
                return this._ProgressBackground;
            }

            set
            {
                this._ProgressBackground = value;
                
            }

        }

        [Category("RectangularProgress Transparent")]
        public Color Trans_ProgressColor1
        {
            get
            {
                return this.Trns_progressColor1;
            }

            set
            {
                this.Trns_progressColor1 = value;
                
            }

        }

        [Category("RectangularProgress Transparent")]
        public Color Trans_ProgressColor2
        {
            get
            {
                return this.Trns_progressColor2;
            }

            set
            {
                this.Trns_progressColor2 = value;
                
            }

        }



        #endregion

    }
}
