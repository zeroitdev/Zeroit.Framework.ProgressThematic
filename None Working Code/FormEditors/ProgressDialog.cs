using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressDialog : System.Windows.Forms.Form
    {

        #region Constructor

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// 	at the default window position.
        /// </summary>
        public ProgressDialog() : this(ProgressInput.Empty())
        {
        }

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        ///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ProgressDialog(Control c) : this(ProgressInput.Empty(), c)
        {
        }

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        ///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="filler">Existing <c>Filler</c> object.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">
        ///		Thrown if <paramref name="filler" /> is null.
        ///	</exception>
        public ProgressDialog(ProgressInput progressInput, Control c) : this(progressInput)
        {
            Zeroit.Framework.ProgressThematic.FormEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// 	Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// 	at the default window position.
        /// </summary>
        /// <param name="peaceInput">Existing <c>Filler</c> object.</param>
        /// <exception cref="System.ArgumentNullException">
        ///		Thrown if <paramref name="peaceInput" /> is null.
        ///	</exception>
        public ProgressDialog(ProgressInput progressInput)
        {
            if (progressInput == null)
            {
                throw new ArgumentNullException("progressInput");
            }


            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            

            //AdjustDialogSize();
            //SetInitial_Values(pizaroAnimatorInput);

        }


        #endregion

        #region Public Properties

        private ProgressInput progressInput;

        public ProgressInput ProgressInput
        {
            get { return progressInput; }
        }

        #endregion

        private void okBtn_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }
    }
}
