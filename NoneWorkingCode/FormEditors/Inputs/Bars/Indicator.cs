using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {

        #region Private Fields

        public float _GraphWidth = 33;
        private Color paintColor = Color.Black;
        private Color penColor = Color.Black;

        #endregion

        #region Public Properties


        public float GraphWidth
        {
            get
            {
                return _GraphWidth;
            }
            set
            {
                _GraphWidth = value;
                
            }
        }

        public Color Color
        {
            get { return paintColor; }
            set
            {
                paintColor = value;
                
            }
        }

        public Color BorderColor
        {
            get { return penColor; }
            set
            {
                penColor = value;
                
            }
        }

        #endregion

    }
}
