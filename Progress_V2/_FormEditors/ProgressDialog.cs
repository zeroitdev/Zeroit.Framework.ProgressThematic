// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressDialog.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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

            SetStyle
                (
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.ResizeRedraw | ControlStyles.UserPaint | 
                ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, 
                true
                );

            
            Set_InitialValues(progressInput);

            AddBars();
            AddCircular();
            AddIndicator();
            UserControl_Visibility();
            SelectedBar();

            //if (progressInput.ProgressType == ProgressType.Bar)
            //{
            //    //AddBars();
            //    //AddCircular();
            //    //AddIndicator();
            //    //UserControl_Visibility();
            //    //SelectedBar();
            //    //SelectedCircular();
            //    //SelectedIndicator();
            //}

            #region Initialization

            #region Bars

            Set_ExtendedBar_Initial_Values(progressInput);
            Set_Indicator_Initial_Values(progressInput);
            Set_iTunes_Initial_Values(progressInput);
            Set_Maze_Initial_Values(progressInput);
            Set_Normal_Initial_Values(progressInput);
            Set_Alter_Initial_Values(progressInput);
            Set_Clear_Initial_Values(progressInput);
            Set_Perplex_Initial_Values(progressInput);
            Set_Rect_Initial_Values(progressInput);
            Set_Splitter_Initial_Values(progressInput);
            Set_Transparent_Initial_Values(progressInput);

            #endregion

            #region Circular

            Set_CircularProgressBar_Initial_Values(progressInput);
            Set_CircularProgressBarDefault_Initial_Values(progressInput);
            Set_CircularProgressV2_Initial_Values(progressInput);
            Set_CircularProgressV3_Initial_Values(progressInput);
            Set_CircularProgressV4_Initial_Values(progressInput);
            Set_CircularProgressV5_Initial_Values(progressInput);
            Set_Gorgeous_Initial_Values(progressInput);
            Set_Ignito_Initial_Values(progressInput);
            Set_Awesome_Initial_Values(progressInput);
            Set_Perfect_Initial_Values(progressInput);
            Set_CircularPie_Initial_Values(progressInput);
            Set_RotatingArc_Initial_Values(progressInput);
            Set_RotatingCompass_Initial_Values(progressInput);
            Set_Supreme_Initial_Values(progressInput);
            Set_MultiCo_Initial_Values(progressInput);
            Set_MultiCoExtended_Initial_Values(progressInput);
            Set_MultiCoExtendedV1_Initial_Values(progressInput);
            Set_Dagger_Initial_Values(progressInput);
            Set_DaggerV1_Initial_Values(progressInput);
            Set_DaggerSmooth_Initial_Values(progressInput);
            #endregion

            #region Indicators

            Set_Indeterminate_Initial_Values(progressInput);
            Set_Google_Initial_Values(progressInput);
            Set_MacOSX_Optimized_Initial_Values(progressInput);
            Set_MacOSX_Initial_Values(progressInput);
            Set_Matrix_Initial_Values(progressInput);
            Set_ProgressIndicator_Initial_Values(progressInput);
            Set_ProgressIndicatorUnique_Initial_Values(progressInput);
            Set_SpinnerCircle_Initial_Values(progressInput);
            Set_Vuvuzela_Initial_Values(progressInput);
            Set_Win8Horizontal_Initial_Values(progressInput);
            Set_Win8Ring_Initial_Values(progressInput);

            #endregion

            #endregion

            #region Exceptional

            macOSX_UC.indicator_MacOSX_CircleCount_Numeric.ValueChanged += Indicator_MacOSX_CircleCount_Numeric_ValueChanged;

            #endregion

        }

        private void Indicator_MacOSX_CircleCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            mainControl_Maximum_Numeric.Value = macOSX_UC.indicator_MacOSX_CircleCount_Numeric.Value;
        }


        #endregion

        #region Public Properties

        private ProgressInput progressInput;

        public ProgressInput ProgressInput
        {
            get { return progressInput; }
            set
            {
                progressInput = value;
                
            }
        }

        #endregion

        #region Private Events

        private void PropertyTypeChanged(object sender, EventArgs e)
        {
            //UserControl_AddControls();
            //UserControl_Visibility();
            
            mainControl_BarProgress_ComboBox.Enabled = false;
            mainControl_CircularProgress_ComboBox.Enabled = false;
            mainControl_IndicatorProgress_ComboBox.Enabled = false;

            if (mainControl_ProgressType_ComboBox.SelectedIndex ==
                (int)ProgressType.Bar)
            {
                mainControl_BarProgress_ComboBox.Enabled = true;

                AddBars();
                AddCircular();
                AddIndicator();
                //Remove_Circular();
                //Remove_Indicator();
                SelectedBar();
                
                
                //Remove_Bars();
                //Remove_Indicator();
                //SelectedCircular();
                
            
                
                //Remove_Bars();
                //Remove_Circular();
                //SelectedIndicator();

            }

        }

        private void ProgressBarTypeChanged(object sender, EventArgs e)
        {
            ////AddBars();
            ////Remove_Circular();
            ////Remove_Indicator();

            UserControl_Visibility();
            SelectedBar();
            //SelectedCircular();
            //SelectedIndicator();


        }
        
        private void CircularBarTypeChanged(object sender, EventArgs e)
        {
            //AddCircular();
            //Remove_Bars();
            //Remove_Indicator();

            UserControl_Visibility();

            //SelectedCircular();


        }
        
        private void IndicatorBarTypeChanged(object sender, EventArgs e)
        {
            //AddIndicator();
            //Remove_Bars();
            //Remove_Circular();

            UserControl_Visibility();
            //SelectedIndicator();

            

        }

        private void SelectedBar()
        {
            mainViewer.Visible = true;
            if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                (int)ProgressBar.RPExtendedProgress)
            {
                
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(extended_UC);
                extended_UC.Visible = true;
                //extended_UC.Width = mainViewer.Width;
                //extended_UC.Dock = DockStyle.Fill;
                //extended_UC.Location = new Point(321, 45);
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPIndicator)
            {
                
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(indicator_UC);
                indicator_UC.Visible = true;
                //indicator_UC.Width = mainViewer.Width;
                //indicator_UC.Location = new Point(321, 45);
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPiTunes)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(iTunes_UC);
                iTunes_UC.Visible = true;
                //iTunes_UC.Location = new Point(321, 45);
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPMaze)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(maze_UC);
                maze_UC.Visible = true;
                //maze_UC.Location = new Point(321, 45);
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPProgNormal)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(antonio_Normal_UC);
                antonio_Normal_UC.Visible = true;
                //antonio_Normal_UC.Location = new Point(321, 45);
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPAlter)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(alter_UC);
                alter_UC.Visible = true;
                //alter_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPClear)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(clear_UC);
                clear_UC.Visible = true;
                //clear_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPPerplex)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(perplex_UC);
                perplex_UC.Visible = true;
                //perplex_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPRect)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(rect_UC);
                rect_UC.Visible = true;
                //rect_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPSplitter)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(splitter_UC);
                splitter_UC.Visible = true;
                //splitter_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.RPTransparent)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(transparent_UC);
                transparent_UC.Visible = true;
                //transparent_UC.Location = new Point(321, 45);
            }
        
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                (int)ProgressBar.CPBarCircular)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularProgressBar_UC);
                circularProgressBar_UC.Visible = true;
                //circularProgressBar_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPBarCircularDefault)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularProgressBarDefault_UC);
                circularProgressBarDefault_UC.Visible = true;
                //circularProgressBarDefault_UC.Location = new Point(321, 45);
            }


            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPv2)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularProgressV2_UC);
                circularProgressV2_UC.Visible = true;
                //circularProgressV2_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPv3)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularProgressV3_UC);
                circularProgressV3_UC.Visible = true;
                //circularProgressV3_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPv4)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularProgressV4_UC);
                circularProgressV4_UC.Visible = true;
                //circularProgressV4_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPv5)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularProgressV5_UC);
                circularProgressV5_UC.Visible = true;
                //circularProgressV5_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPGorgeous)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(gorgeous_UC);
                gorgeous_UC.Visible = true;
                //gorgeous_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPIgnito)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(ignito_UC);
                ignito_UC.Visible = true;
                //ignito_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPAwesome)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(progressAwesome_UC);
                progressAwesome_UC.Visible = true;
                //progressAwesome_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPPerfect)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(progressBarPerfect_UC);
                progressBarPerfect_UC.Visible = true;
                //progressBarPerfect_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPProgressPie)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(progressBarPie_UC);
                progressBarPie_UC.Visible = true;
                //progressBarPie_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPRotatingArc)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(rotatingArc_UC);
                rotatingArc_UC.Visible = true;
                //rotatingArc_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPRotatingCompass)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(rotatingCompass_UC);
                rotatingCompass_UC.Visible = true;
                //rotatingCompass_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPSupreme)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(supreme_UC);
                supreme_UC.Visible = true;
                //supreme_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPMulitCo)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(zeroitMultiCo_UC);
                zeroitMultiCo_UC.Visible = true;
                //zeroitMultiCo_UC.Location = new Point(321, 45);
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPMultiCoExtended)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(zeroitMultiCoExtended_UC);
                zeroitMultiCoExtended_UC.Visible = true;
                //zeroitMultiCoExtended_UC.Location = new Point(321, 45);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPMultiCoV1)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(zeroitMultiCoExtendedV1_UC);
                zeroitMultiCoExtendedV1_UC.Visible = true;
                //zeroitMultiCoExtendedV1_UC.Location = new Point(321, 45);
            }
        
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                (int)ProgressBar.IPIndeterminate)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(circularIndeterminate_UC);
                circularIndeterminate_UC.Visible = true;
                //circularIndeterminate_UC.Location = new Point(321, 45);

                circularIndeterminate_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                circularIndeterminate_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPIndeterminate;
                circularIndeterminate_UC.ZeroitThematicProgress1.BackgroundColor = Color.FromArgb(25, 25, 25);
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPGoogle)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(googleProgress_UC);
                googleProgress_UC.Visible = true;
                //googleProgress_UC.Location = new Point(321, 45);

                googleProgress_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                googleProgress_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPGoogle;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPMacOSX)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(macOSX_UC);
                macOSX_UC.Visible = true;
                //macOSX_UC.Location = new Point(321, 45);

                macOSX_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                macOSX_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPMacOSX;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPMacOSXOptimized)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(macOSX_Optimized_UC);
                macOSX_Optimized_UC.Visible = true;
                //macOSX_Optimized_UC.Location = new Point(321, 45);

                macOSX_Optimized_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                macOSX_Optimized_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPMacOSXOptimized;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPMatrix)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(matrix_UC);
                matrix_UC.Visible = true;
                //matrix_UC.Location = new Point(321, 45);

                matrix_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                matrix_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPMatrix;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPV1)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(progressIndicator_UC);
                progressIndicator_UC.Visible = true;
                //progressIndicator_UC.Location = new Point(321, 45);

                progressIndicator_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                progressIndicator_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPV1;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPUnique)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(progressIndicatorUnique_UC);
                progressIndicatorUnique_UC.Visible = true;
                //progressIndicatorUnique_UC.Location = new Point(321, 45);

                progressIndicatorUnique_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                progressIndicatorUnique_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPUnique;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPSpinnerCircle)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(spinnerCircle_UC);
                spinnerCircle_UC.Visible = true;
                //spinnerCircle_UC.Location = new Point(321, 45);

                spinnerCircle_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                spinnerCircle_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPSpinnerCircle;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPSpinnerDivided)
            {
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPVuvuzela)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(vuvuzela_UC);
                vuvuzela_UC.Visible = true;
                //vuvuzela_UC.Location = new Point(321, 45);

                vuvuzela_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                vuvuzela_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPVuvuzela;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPWin8Horizontal)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(winHorizontal_UC);
                winHorizontal_UC.Visible = true;
                //winHorizontal_UC.Location = new Point(321, 45);

                winHorizontal_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                winHorizontal_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPWin8Horizontal;
            }
            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.IPWin8Ring)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(winRing_UC);
                winRing_UC.Visible = true;
                //winRing_UC.Location = new Point(321, 45);

                winRing_UC.ZeroitThematicProgress1.ProgressType = ProgressType.Bar;
                winRing_UC.ZeroitThematicProgress1.SolidProgressBar = ProgressBar.IPWin8Ring;
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPDagger)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(dagger_UC);
                dagger_UC.Visible = true;
                //dagger_UC.Location = new Point(321, 45);
                
            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPDaggerV1)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(daggerV2_UC);
                daggerV2_UC.Visible = true;
                //daggerV2_UC.Location = new Point(321, 45);

            }

            else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                     (int)ProgressBar.CPDaggerSmooth)
            {
                mainViewer.Controls.Clear();
                mainViewer.Controls.Add(daggerSmooth_UC);
                daggerSmooth_UC.Visible = true;
                //daggerSmooth_UC.Location = new Point(321, 45);

            }
        }

        #endregion

        #region Main Events

        private void okBtn_Click(object sender, EventArgs e)
        {
            #region MyRegion

            //if (mainControl_ProgressType_ComboBox.SelectedIndex == (int)ProgressType.Bar)
            //{
            //    if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //    (int)ProgressBar.RPExtendedProgress)
            //    {


            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPExtendedProgress,
            //            ProgressBarEdge.Rounded, Color.FromKnownColor(KnownColor.Gray),
            //            Color.FromKnownColor(KnownColor.LightGray),1, ProgressFloodStyle.Standard,
            //            0.2f,1,5,2,ProgressStyle.Dashed, Color.FromArgb(0, 255, 0), Color.FromKnownColor(KnownColor.White),
            //            Color.FromKnownColor(KnownColor.White),1,true,1,true, Color.FromKnownColor(KnownColor.White),
            //            Color.FromKnownColor(KnownColor.Black), ProgressCaptionMode.Percent,"%",false,false,
            //            ProgressBarDirection.Horizontal,0,100);

            //        Set_ExtendedBar_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPIndicator)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar, 
            //            ProgressBar.RPIndicator,
            //            30f, Color.Blue, Color.Gray);

            //        Set_Indicator_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPiTunes)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPiTunes,
            //            Color.Gray,
            //            Color.LightGray,
            //            Color.Blue,
            //            Color.Yellow,
            //            Color.Brown,
            //            0.2f,
            //            0.5f,
            //            10,
            //            0.5f,
            //            BarType.Animated,
            //            0.2f,
            //            true,
            //            10
            //            );

            //        Set_iTunes_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPMaze)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPMaze,
            //            ProgressBarStyle.Continuous,
            //            0.2f,
            //            10,
            //            MazeStyleType.SingleDown,
            //            Maze_GradientType.Columns,
            //            Color.AliceBlue,
            //            Color.Beige,
            //            10, 10,
            //            Color.Bisque,
            //            false,
            //            false, Color.Green, Color.Red,Color.Brown


            //            );

            //        Set_Maze_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPProgNormal)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPProgNormal,
            //            ZeroitThematicProgress.progressNormalType.Normal,
            //            10,
            //            ZeroitThematicProgress.TextColorTypes.Automatic,
            //            ZeroitThematicProgress.TextAlignmentTypes.Center,
            //            false,
            //            Color.AliceBlue,
            //            ZeroitThematicProgress.BorderTypes.None,
            //            Color.Beige,
            //            10, ZeroitThematicProgress.RollingTypes.EdgeToEdge,
            //            10
            //            );

            //        Set_Normal_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPAlter)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPAlter,
            //            Color.Beige,
            //            Color.Bisque,
            //            Color.Yellow,
            //            Color.Green,
            //            Color.LightBlue,
            //            Color.LightCoral,
            //            Color.Blue,
            //            100f,
            //            true,
            //            Orientation.Horizontal

            //            );
            //        Set_Alter_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPClear)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPClear,
            //            Color.Yellow,
            //            Color.Green,
            //            Color.Violet,
            //            Color.CadetBlue,
            //            ZeroitThematicProgress.coloringMode.Hatch

            //            );
            //        Set_Clear_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPPerplex)
            //    {

            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPPerplex,
            //            Color.Red,
            //            Color.Yellow,
            //            Color.Gainsboro,
            //            Color.Lavender,
            //            Color.LavenderBlush,
            //            10f,
            //            true,
            //            ZeroitThematicProgress.perplex_DrawMode.Gradient


            //            );
            //        Set_Perplex_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPRect)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPRect,
            //            Color.AliceBlue,
            //            Color.Green,
            //            Color.Yellow,
            //            20
            //            );
            //        Set_Rect_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPSplitter)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPSplitter,
            //            10,10,false,false, TProgressBarBorderStyle.Flat,Color.AliceBlue

            //            );

            //        Set_Splitter_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.RPTransparent)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.RPTransparent,
            //            false,
            //            Color.Blue,
            //            Color.Gray,
            //            Color.Orange
            //            );

            //        Set_Transparent_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //    (int)ProgressBar.CPBarCircular)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPBarCircular,
            //            Color.Red,
            //            Color.Yellow,
            //            Color.Green,
            //            Color.Brown,
            //            Color.GreenYellow,
            //            Color.HotPink,
            //            ZeroitThematicProgress._ProgressShape.AnchorMask,
            //            LineCap.AnchorMask,
            //            LineCap.AnchorMask,
            //            20D,
            //            20F,
            //            true,true


            //            );
            //        Set_CircularProgressBar_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPBarCircularDefault)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPBarCircularDefault,
            //            Color.Red,
            //            Color.Yellow,
            //            Color.Green,
            //            Color.Blue,
            //            ZeroitThematicProgress._ProgressShape.AnchorMask

            //            );

            //        Set_CircularProgressBarDefault_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPv2)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPv2,
            //            10,10,10,10,true,Color.Red,Color.Yellow

            //            );
            //        Set_CircularProgressV2_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPv3)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPv3,
            //            10, 10, 10, 10, true, Color.Red, Color.Yellow,false

            //            );
            //        Set_CircularProgressV3_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPv4)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPv4,
            //            10,10,10f,LineCap.AnchorMask,LineCap.AnchorMask,
            //            Color.AliceBlue,Color.Blue,Color.Yellow,Color.Black,Color.Orange, Color.Brown,
            //            10

            //            );
            //        Set_CircularProgressV4_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPv5)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPv5,
            //            true,10,10,true, true, true, 
            //            "", true, Color.Red, true, 10, true,
            //            10,10,10, true, //, true
            //            true, true, true, true, true
            //            );

            //        Set_CircularProgressV5_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPGorgeous)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPGorgeous,
            //            true,10,10,10,10, new Color[] {Color.Red,Color.Blue},
            //            new Color[] {Color.Blue,Color.Black,Color.Red,Color.Brown,Color.Yellow},
            //            10,true, ZeroitThematicProgress.Gorgeous_rotatingAngle.AntiClockwise
            //            );
            //        Set_Gorgeous_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPIgnito)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPIgnito,
            //            20f,20f,new Color[]
            //            {
            //                Color.Red, Color.Blue, Color.AliceBlue, Color.AliceBlue,
            //                Color.Aqua, Color.Aqua, Color.Aquamarine,Color.Azure,
            //                Color.Beige,Color.Black,Color.BlanchedAlmond, Color.BlueViolet
            //            },
            //            true, LineCap.AnchorMask,
            //            ZeroitThematicProgress.Ignito_innerRotatingAngle.AntiClockwise,
            //            ZeroitThematicProgress.Ignito_outterRotatingAngle.AntiClockwise,
            //            ZeroitThematicProgress.Ignito_drawMode.Gradient,
            //            DashStyle.Custom, DashStyle.Custom


            //            );

            //        Set_Ignito_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPAwesome)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPAwesome,
            //            10f,"23", new Font("Segoe UI", 12),"C",
            //            Color.Yellow, Color.Green,10,new Padding(10, -35, 0, 0),
            //            new Padding(10, 35, 0, 0),new Padding(10, 35, 0, 0),10,10,10,
            //            Color.Blue,10,Color.GreenYellow, 10,10, Color.LightBlue, ProgressBarStyle.Continuous
            //            );

            //        Set_Awesome_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPPerfect)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPPerfect,
            //            10,Color.Red,10f,10f,10, RotationType1.Clockwise,10f,
            //            false,false, TextDisplayModes1.Both

            //            );

            //        Set_Perfect_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPProgressPie)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPPerfect,
            //            Color.Red,Color.Yellow,Color.Green, Color.Black, Color.Aqua,Color.DarkBlue,
            //            ZeroitThematicProgress.ProgressPie_ProgressShape.AnchorMask,
            //            LineCap.AnchorMask,LineCap.AnchorMask,20D,20F,true,20F,20F

            //            );

            //        Set_CircularPie_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPRotatingArc)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPRotatingArc,
            //            20f,20,true,
            //            ZeroitThematicProgress.PieArc.Arc, ZeroitThematicProgress.RotatingArc_drawMode.Default,
            //            ZeroitThematicProgress.shape.Arc,10,Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue,
            //            true,true, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue,Color.Blue,
            //            true,true,true,true,true,true,10,10, 10, 10,10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,true

            //            );

            //        Set_RotatingArc_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPRotatingCompass)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPRotatingCompass,
            //            Color.Red,Color.Red,Color.Red,Color.Red,Color.Red,
            //            10, true, 10f
            //            );

            //        Set_RotatingCompass_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPSupreme)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPSupreme,
            //            ZeroitThematicProgress.Supreme_colorMode.Gradient,
            //            Color.Blue,Color.Red,Color.Black,
            //            new Color[] {Color.Orange,
            //                Color.DarkSlateGray},LinearGradientMode.ForwardDiagonal,
            //            30f,10,10
            //            );

            //        Set_Supreme_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPMulitCo)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPMulitCo,
            //            true,10,10,10,10,
            //            Rings.One,
            //            new Color[]
            //            {
            //                Color.Red,
            //                Color.Yellow,
            //                Color.Green,
            //                Color.AliceBlue,
            //                Color.Brown,
            //                Color.Chocolate,
            //                Color.DarkOrange,
            //                Color.DarkRed,
            //                Color.DeepPink,
            //                Color.Indigo,
            //                Color.Ivory,
            //                Color.Lavender,
            //                Color.LightSeaGreen,
            //                Color.Maroon,
            //                Color.OrangeRed,
            //                Color.Orchid,
            //                Color.PaleGoldenrod,
            //                Color.PapayaWhip,
            //                Color.Teal,
            //                Color.Tomato,
            //                Color.YellowGreen,
            //                Color.Thistle,
            //                Color.Tan,
            //                Color.SlateGray,
            //            }
            //            );

            //        Set_MultiCo_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPMultiCoExtended)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPMulitCo,
            //            true, 10, 10, 10, 10,
            //            Rings.One,
            //            new Color[]
            //            {
            //                Color.Red,
            //                Color.Yellow,
            //                Color.Green,
            //                Color.AliceBlue,
            //                Color.Brown,
            //                Color.Chocolate,
            //                Color.DarkOrange,
            //                Color.DarkRed,
            //                Color.DeepPink,
            //                Color.Indigo,
            //                Color.Ivory,
            //                Color.Lavender,
            //                Color.LightSeaGreen,
            //                Color.Maroon,
            //                Color.OrangeRed,
            //                Color.Orchid,
            //                Color.PaleGoldenrod,
            //                Color.PapayaWhip,
            //                Color.Teal,
            //                Color.Tomato,
            //                Color.YellowGreen,
            //                Color.Thistle,
            //                Color.Tan,
            //                Color.SlateGray,
            //            },
            //            Color.Blue

            //            );

            //        Set_MultiCoExtended_Retrieved_Values(progressInput);

            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.CPMultiCoV1)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.CPMultiCoV1,
            //            LineCap.AnchorMask, LineCap.ArrowAnchor, DashStyle.DashDot,
            //            20f,true,true,true,10, drawMode.Solid,true,10,10,10,10,Rings.One,Color.Red,
            //            new Color[] {

            //                Color.Yellow ,
            //                Color.LightGreen,
            //                Color.LightSkyBlue ,
            //                Color.Green ,
            //                Color.DarkGoldenrod ,
            //                Color.DimGray ,
            //                Color.BlanchedAlmond ,
            //                Color.Chartreuse ,
            //                Color.DarkOrchid ,
            //                Color.Honeydew ,
            //                Color.Indigo ,
            //                Color.Maroon ,
            //                Color.Plum ,
            //                Color.Purple ,
            //                Color.Thistle ,
            //                Color.SeaShell ,
            //                Color.Navy,
            //                Color.MidnightBlue ,
            //                Color.LawnGreen ,
            //                Color.HotPink ,
            //                Color.Yellow ,
            //                Color.Crimson ,
            //                Color.CornflowerBlue ,
            //                Color.Cyan

            //            }, 
            //            new Color[] {

            //                Color.Yellow ,
            //                Color.LightGreen,
            //                Color.LightSkyBlue ,
            //                Color.Green ,
            //                Color.DarkGoldenrod ,
            //                Color.DimGray ,
            //                Color.BlanchedAlmond ,
            //                Color.Chartreuse ,
            //                Color.DarkOrchid ,
            //                Color.Honeydew ,
            //                Color.Indigo ,
            //                Color.Maroon ,
            //                Color.Plum ,
            //                Color.Purple ,
            //                Color.Thistle ,
            //                Color.SeaShell ,
            //                Color.Navy,
            //                Color.MidnightBlue ,
            //                Color.LawnGreen ,
            //                Color.HotPink ,
            //                Color.Yellow ,
            //                Color.Crimson ,
            //                Color.CornflowerBlue ,
            //                Color.Cyan

            //            }, 
            //            new Color[] {

            //                Color.Yellow ,
            //                Color.LightGreen,
            //                Color.LightSkyBlue ,
            //                Color.Green ,
            //                Color.DarkGoldenrod ,
            //                Color.DimGray ,
            //                Color.BlanchedAlmond ,
            //                Color.Chartreuse ,
            //                Color.DarkOrchid ,
            //                Color.Honeydew ,
            //                Color.Indigo ,
            //                Color.Maroon ,
            //                Color.Plum ,
            //                Color.Purple ,
            //                Color.Thistle ,
            //                Color.SeaShell ,
            //                Color.Navy,
            //                Color.MidnightBlue ,
            //                Color.LawnGreen ,
            //                Color.HotPink ,
            //                Color.Yellow ,
            //                Color.Crimson ,
            //                Color.CornflowerBlue ,
            //                Color.Cyan

            //            }, 
            //            new Color[] {

            //                Color.Yellow ,
            //                Color.LightGreen,
            //                Color.LightSkyBlue ,
            //                Color.Green ,
            //                Color.DarkGoldenrod ,
            //                Color.DimGray ,
            //                Color.BlanchedAlmond ,
            //                Color.Chartreuse ,
            //                Color.DarkOrchid ,
            //                Color.Honeydew ,
            //                Color.Indigo ,
            //                Color.Maroon ,
            //                Color.Plum ,
            //                Color.Purple ,
            //                Color.Thistle ,
            //                Color.SeaShell ,
            //                Color.Navy,
            //                Color.MidnightBlue ,
            //                Color.LawnGreen ,
            //                Color.HotPink ,
            //                Color.Yellow ,
            //                Color.Crimson ,
            //                Color.CornflowerBlue ,
            //                Color.Cyan

            //            },
            //            Color.Beige
            //            );

            //        Set_MultiCoExtendedV1_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPIndeterminate)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPIndeterminate,
            //            Color.Black,
            //            10,Color.Black,10,10f,10f,Color.Red,10,
            //            ZeroitThematicProgress.INDICATORTYPES.ANIMATED,10,true

            //            );

            //        Set_Indeterminate_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPGoogle)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPGoogle,
            //            Color.AliceBlue,Color.AliceBlue,10,10,Color.Red,
            //            ZeroitThematicProgress.GoogleProgress_INDICATORTYPES.ANIMATED,10,10,10,10f,
            //            Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red,10



            //            );

            //        Set_Google_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPMacOSX)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPMacOSX,
            //            10, 10, 10, 10, 10, 10, 10, 10, 
            //            LineCap.AnchorMask, LineCap.AnchorMask,
            //            MacOSX_automatic.Stop, 
            //            Color.Black, 
            //            ZeroitThematicProgress.MacOSX_Direction.ANTICLOCKWISE

            //            );

            //        Set_MacOSX_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPMacOSXOptimized)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPMacOSXOptimized,
            //            10,10f,10f,10,LineCap.AnchorMask,LineCap.AnchorMask,
            //            MacOSX_automatic.Stop, ZeroitThematicProgress.MacOSX_Direction.ANTICLOCKWISE,Color.AliceBlue

            //            );

            //        Set_MacOSX_Optimized_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPMatrix)
            //    {

            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPMatrix,
            //            10,10f,10, LineCap.AnchorMask, LineCap.AnchorMask,
            //            MacOSX_automatic.Stop, ZeroitThematicProgress.MacOSX_Direction.ANTICLOCKWISE,
            //            Color.Black
            //            );

            //        Set_Matrix_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPV1)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPV1,
            //            Color.Beige,Color.Beige,10F,10D,10F
            //            );

            //        Set_ProgressIndicator_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPUnique)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPUnique,
            //            10,Color.AliceBlue,10f,10,10, Unique_RotationType.Clockwise,10f,false,
            //            false, Unique_TextDisplayModes.Both
            //            );

            //        Set_ProgressIndicatorUnique_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPSpinnerCircle)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPSpinnerCircle,
            //            true,10,10,10,10,Color.AliceBlue,
            //            //ZeroitThematicProgress.StylePresets.Custom,
            //            10
            //            );

            //        Set_SpinnerCircle_Retrieved_Values(progressInput);
            //    }

            //    //else if (mainControl_IndicatorProgress_ComboBox.SelectedIndex ==
            //    //         (int)ProgressBar.IPSpinnerDivided)
            //    //{
            //    //}

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPVuvuzela)
            //    {

            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPVuvuzela,
            //            10f,10,true, ZeroitThematicProgress.Vuvuzela_Shape.Arc,10,true,
            //            Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red,
            //            10

            //            );

            //        Set_Vuvuzela_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPWin8Horizontal)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPWin8Horizontal,
            //            10,Color.Black,
            //            10,10D,true
            //            );

            //        Set_Win8Horizontal_Retrieved_Values(progressInput);
            //    }

            //    else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
            //             (int)ProgressBar.IPWin8Ring)
            //    {
            //        progressInput = new ProgressInput(
            //            //ProgressType.Bar,
            //            ProgressBar.IPWin8Ring,
            //            10,Color.AliceBlue,10,true
            //            );

            //        Set_Win8Ring_Retrieved_Values(progressInput);
            //    }
            //} /**/

            #endregion

            
                if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                    (int)ProgressBar.RPExtendedProgress)
                {
                
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPExtendedProgress,
                        ProgressBarEdge.Rounded, Color.FromKnownColor(KnownColor.Gray),
                        Color.FromKnownColor(KnownColor.LightGray), 1, ProgressFloodStyle.Standard,
                        0.2f, 1, 5, 2, ProgressStyle.Dashed, Color.FromArgb(0, 255, 0),
                        Color.FromKnownColor(KnownColor.White),
                        Color.FromKnownColor(KnownColor.White), 1, true, 1, true,
                        Color.FromKnownColor(KnownColor.White),
                        Color.FromKnownColor(KnownColor.Black), ProgressCaptionMode.Percent, "%", false, false,
                        ProgressBarDirection.Horizontal, 0, 100);

                    Set_ExtendedBar_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPIndicator)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPIndicator,
                        30f, Color.Red, Color.Yellow);

                    Set_Indicator_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPiTunes)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPiTunes,
                        Color.Gray,
                        Color.LightGray,
                        Color.Blue,
                        Color.Yellow,
                        Color.Brown,
                        0.2f,
                        0.5f,
                        10,
                        0.5f,
                        BarType.Animated,
                        0.2f,
                        true,
                        10
                    );

                    Set_iTunes_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPMaze)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPMaze,
                        ProgressBarStyle.Continuous,
                        0.2f,
                        10,
                        MazeStyleType.SingleDown,
                        Maze_GradientType.Columns,
                        Color.AliceBlue,
                        Color.Beige,
                        10, 10,
                        Color.Bisque,
                        false,
                        false, Color.Green, Color.Red, Color.Brown


                    );

                    Set_Maze_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPProgNormal)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPProgNormal,
                        ZeroitThematicProgress.progressNormalType.Normal,
                        10,
                        ZeroitThematicProgress.TextColorTypes.Automatic,
                        ZeroitThematicProgress.TextAlignmentTypes.Center,
                        false,
                        Color.AliceBlue,
                        ZeroitThematicProgress.BorderTypes.None,
                        Color.Beige,
                        10, ZeroitThematicProgress.RollingTypes.EdgeToEdge,
                        10
                    );

                    Set_Normal_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPAlter)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPAlter,
                        Color.Beige,
                        Color.Bisque,
                        Color.Yellow,
                        Color.Green,
                        Color.LightBlue,
                        Color.LightCoral,
                        Color.Blue,
                        100f,
                        true,
                        Orientation.Horizontal

                    );
                    Set_Alter_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPClear)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPClear,
                        Color.Yellow,
                        Color.Green,
                        Color.Violet,
                        Color.CadetBlue,
                        ZeroitThematicProgress.coloringMode.Hatch

                    );
                    Set_Clear_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPPerplex)
                {

                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPPerplex,
                        Color.Red,
                        Color.Yellow,
                        Color.Gainsboro,
                        Color.Lavender,
                        Color.LavenderBlush,
                        10f,
                        true,
                        ZeroitThematicProgress.perplex_DrawMode.Gradient


                    );
                    Set_Perplex_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPRect)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPRect,
                        Color.AliceBlue,
                        Color.Green,
                        Color.Yellow,
                        20
                    );
                    Set_Rect_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPSplitter)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPSplitter,
                        10, 10, false, false, TProgressBarBorderStyle.Flat, Color.AliceBlue

                    );

                    Set_Splitter_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.RPTransparent)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.RPTransparent,
                        false,
                        Color.Blue,
                        Color.Gray,
                        Color.Orange
                    );

                    Set_Transparent_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPBarCircular)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPBarCircular,
                        Color.Red,
                        Color.Yellow,
                        Color.Green,
                        Color.Brown,
                        Color.GreenYellow,
                        Color.HotPink,
                        ZeroitThematicProgress._ProgressShape.AnchorMask,
                        LineCap.AnchorMask,
                        LineCap.AnchorMask,
                        20D,
                        20F,
                        true, true


                    );
                    Set_CircularProgressBar_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPBarCircularDefault)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPBarCircularDefault,
                        Color.Red,
                        Color.Yellow,
                        Color.Green,
                        Color.Blue,
                        ZeroitThematicProgress._ProgressShape.AnchorMask

                    );

                    Set_CircularProgressBarDefault_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPv2)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPv2,
                        10, 10, 10, 10, true, Color.Red, Color.Yellow

                    );
                    Set_CircularProgressV2_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPv3)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPv3,
                        10, 10, 10, 10, true, Color.Red, Color.Yellow, false

                    );
                    Set_CircularProgressV3_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPv4)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPv4,
                        10, 10, 10f, LineCap.AnchorMask, LineCap.AnchorMask,
                        Color.AliceBlue, Color.Blue, Color.Yellow, Color.Black, Color.Orange, Color.Brown,
                        10

                    );
                    Set_CircularProgressV4_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPv5)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPv5,
                        true, 10, 10, true, true, true,
                        "", true, Color.Red, true, 10, true,
                        10, 10, 10, true, //, true
                        true, true, true, true, true
                    );

                    Set_CircularProgressV5_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPGorgeous)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPGorgeous,
                        true, 10, 10, 10, 10, new Color[] {Color.Red, Color.Blue},
                        new Color[] {Color.Blue, Color.Black, Color.Red, Color.Brown, Color.Yellow},
                        10, true, ZeroitThematicProgress.Gorgeous_rotatingAngle.AntiClockwise,ZeroitThematicProgress.Gorgeous_drawMode.Solid
                    );
                    Set_Gorgeous_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPIgnito)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPIgnito,
                        20f, 20f, new Color[]
                        {
                            Color.Red, Color.Blue, Color.AliceBlue, Color.AliceBlue,
                            Color.Aqua, Color.Aqua, Color.Aquamarine, Color.Azure,
                            Color.Beige, Color.Black, Color.BlanchedAlmond, Color.BlueViolet
                        },
                        true, LineCap.AnchorMask,
                        ZeroitThematicProgress.Ignito_innerRotatingAngle.AntiClockwise,
                        ZeroitThematicProgress.Ignito_outterRotatingAngle.AntiClockwise,
                        ZeroitThematicProgress.Ignito_drawMode.Gradient,
                        DashStyle.Custom, DashStyle.Custom


                    );

                    Set_Ignito_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPAwesome)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPAwesome,
                        10f, "23", new Font("Segoe UI", 12), "C",
                        Color.Yellow, Color.Green, 10, new Padding(10, -35, 0, 0),
                        new Padding(10, 35, 0, 0), new Padding(10, 35, 0, 0), 10, 10, 10,
                        Color.Blue, 10, Color.GreenYellow, 10, 10, Color.LightBlue, ProgressBarStyle.Continuous
                    );

                    Set_Awesome_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPPerfect)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPPerfect,
                        10, Color.Red, 10f, 10f, 10, RotationType1.Clockwise, 10f,
                        false, false, TextDisplayModes1.Both

                    );

                    Set_Perfect_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPProgressPie)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPPerfect,
                        Color.Red, Color.Yellow, Color.Green, Color.Black, Color.Aqua, Color.DarkBlue,
                        ZeroitThematicProgress.ProgressPie_ProgressShape.AnchorMask,
                        LineCap.AnchorMask, LineCap.AnchorMask, 20D, 20F, true, 20F, 20F

                    );

                    Set_CircularPie_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPRotatingArc)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPRotatingArc,
                        20f, 20, true,
                        ZeroitThematicProgress.PieArc.Arc, ZeroitThematicProgress.RotatingArc_drawMode.Default,
                        ZeroitThematicProgress.shape.Arc, 10, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue,
                        Color.Blue,
                        true, true, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue,
                        Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue,
                        true, true, true, true, true, true, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                        true

                    );

                    Set_RotatingArc_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPRotatingCompass)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPRotatingCompass,
                        Color.Red, Color.Red, Color.Red, Color.Red, Color.Red,
                        10, true, 10f
                    );

                    Set_RotatingCompass_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPSupreme)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPSupreme,
                        ZeroitThematicProgress.Supreme_colorMode.Gradient,
                        Color.Blue, Color.Red, Color.Black,
                        new Color[]
                        {
                            Color.Orange,
                            Color.DarkSlateGray
                        }, LinearGradientMode.ForwardDiagonal,
                        30f, 10, 10
                    );

                    Set_Supreme_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPMulitCo)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPMulitCo,
                        true, 10, 10, 10, 10,
                        Rings.One,
                        new Color[]
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
                        }
                    );

                    Set_MultiCo_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPMultiCoExtended)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPMulitCo,
                        true, 10, 10, 10, 10,
                        Rings.One,
                        new Color[]
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
                        },
                        Color.Blue

                    );

                    Set_MultiCoExtended_Retrieved_Values(progressInput);

                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.CPMultiCoV1)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.CPMultiCoV1,
                        LineCap.AnchorMask, LineCap.ArrowAnchor, DashStyle.DashDot,
                        20f, true, true, true, 10, drawMode.Solid, true, 10, 10, 10, 10, Rings.One, Color.Red,
                        new Color[]
                        {

                            Color.Yellow,
                            Color.LightGreen,
                            Color.LightSkyBlue,
                            Color.Green,
                            Color.DarkGoldenrod,
                            Color.DimGray,
                            Color.BlanchedAlmond,
                            Color.Chartreuse,
                            Color.DarkOrchid,
                            Color.Honeydew,
                            Color.Indigo,
                            Color.Maroon,
                            Color.Plum,
                            Color.Purple,
                            Color.Thistle,
                            Color.SeaShell,
                            Color.Navy,
                            Color.MidnightBlue,
                            Color.LawnGreen,
                            Color.HotPink,
                            Color.Yellow,
                            Color.Crimson,
                            Color.CornflowerBlue,
                            Color.Cyan

                        },
                        new Color[]
                        {

                            Color.Yellow,
                            Color.LightGreen,
                            Color.LightSkyBlue,
                            Color.Green,
                            Color.DarkGoldenrod,
                            Color.DimGray,
                            Color.BlanchedAlmond,
                            Color.Chartreuse,
                            Color.DarkOrchid,
                            Color.Honeydew,
                            Color.Indigo,
                            Color.Maroon,
                            Color.Plum,
                            Color.Purple,
                            Color.Thistle,
                            Color.SeaShell,
                            Color.Navy,
                            Color.MidnightBlue,
                            Color.LawnGreen,
                            Color.HotPink,
                            Color.Yellow,
                            Color.Crimson,
                            Color.CornflowerBlue,
                            Color.Cyan

                        },
                        new Color[]
                        {

                            Color.Yellow,
                            Color.LightGreen,
                            Color.LightSkyBlue,
                            Color.Green,
                            Color.DarkGoldenrod,
                            Color.DimGray,
                            Color.BlanchedAlmond,
                            Color.Chartreuse,
                            Color.DarkOrchid,
                            Color.Honeydew,
                            Color.Indigo,
                            Color.Maroon,
                            Color.Plum,
                            Color.Purple,
                            Color.Thistle,
                            Color.SeaShell,
                            Color.Navy,
                            Color.MidnightBlue,
                            Color.LawnGreen,
                            Color.HotPink,
                            Color.Yellow,
                            Color.Crimson,
                            Color.CornflowerBlue,
                            Color.Cyan

                        },
                        new Color[]
                        {

                            Color.Yellow,
                            Color.LightGreen,
                            Color.LightSkyBlue,
                            Color.Green,
                            Color.DarkGoldenrod,
                            Color.DimGray,
                            Color.BlanchedAlmond,
                            Color.Chartreuse,
                            Color.DarkOrchid,
                            Color.Honeydew,
                            Color.Indigo,
                            Color.Maroon,
                            Color.Plum,
                            Color.Purple,
                            Color.Thistle,
                            Color.SeaShell,
                            Color.Navy,
                            Color.MidnightBlue,
                            Color.LawnGreen,
                            Color.HotPink,
                            Color.Yellow,
                            Color.Crimson,
                            Color.CornflowerBlue,
                            Color.Cyan

                        },
                        Color.Beige
                    );

                    Set_MultiCoExtendedV1_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int)ProgressBar.CPDagger)
                {
                    progressInput = new ProgressInput(
                        Color.FromArgb(114, 114, 114),
                        Color.FromArgb(60, 220, 210),
                        130, 24, 40, 5, false
                    );

                    Set_Dagger_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int)ProgressBar.CPDaggerV1)
                {
                    progressInput = new ProgressInput(
                        Color.FromArgb(114, 114, 114),
                        Color.FromArgb(60, 220, 210),
                        Color.Orange,
                        Color.FromArgb(20, 20, 20),
                        Color.LightGray,
                        200, 30, 130, 24, 40, 5, 20, false, true, false, true
                    );

                    Set_DaggerV1_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int)ProgressBar.CPDaggerSmooth)
                {
                    progressInput = new ProgressInput(
                        Color.FromArgb(114, 114, 114),
                        Color.FromArgb(60, 220, 210),
                        Color.Orange,
                        200, 30, 130, 24, 40, 5, 360, false, false, false
                    );

                    Set_DaggerSmooth_Retrieved_Values(progressInput);
                }


                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPIndeterminate)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPIndeterminate,
                        Color.Black,
                        10, Color.Black, 10, 10f, 10f, Color.Red, 10,
                        ZeroitThematicProgress.INDICATORTYPES.ANIMATED, 10, true

                    );

                    Set_Indeterminate_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPGoogle)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPGoogle,
                        Color.AliceBlue, Color.AliceBlue, 10, 10, Color.Red,
                        ZeroitThematicProgress.GoogleProgress_INDICATORTYPES.ANIMATED, 10, 10, 10, 10f,
                        Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, 10



                    );

                    Set_Google_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPMacOSX)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPMacOSX,
                        10, 10, 10, 10, 10,10, 10, 10, 10,
                        LineCap.AnchorMask, LineCap.AnchorMask,
                        MacOSX_automatic.Stop,
                        Color.Black,
                        ZeroitThematicProgress.MacOSX_Direction.ANTICLOCKWISE

                    );

                    Set_MacOSX_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPMacOSXOptimized)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPMacOSXOptimized,
                        10, 10f, 10f, 10,10, LineCap.AnchorMask, LineCap.AnchorMask,
                        MacOSX_automatic.Stop, ZeroitThematicProgress.MacOSX_Direction.ANTICLOCKWISE, Color.AliceBlue

                    );

                    Set_MacOSX_Optimized_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPMatrix)
                {

                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPMatrix,
                        10, 10f, 10,10, LineCap.AnchorMask, LineCap.AnchorMask,
                        MacOSX_automatic.Stop, ZeroitThematicProgress.MacOSX_Direction.ANTICLOCKWISE,
                        Color.Black
                    );

                    Set_Matrix_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPV1)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPV1,
                        Color.Beige, Color.Beige, 10F, 10D, 10F
                    );

                    Set_ProgressIndicator_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPUnique)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPUnique,
                        10, Color.AliceBlue, 10f, 10, 10, Unique_RotationType.Clockwise, 10f, false,
                        false, Unique_TextDisplayModes.Both
                    );

                    Set_ProgressIndicatorUnique_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPSpinnerCircle)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPSpinnerCircle,
                        true, 10, 10, 10, 10, Color.AliceBlue,
                        //ZeroitThematicProgress.StylePresets.Custom,
                        10
                    );

                    Set_SpinnerCircle_Retrieved_Values(progressInput);
                }

                //else if (mainControl_IndicatorProgress_ComboBox.SelectedIndex ==
                //         (int)ProgressBar.IPSpinnerDivided)
                //{
                //}

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPVuvuzela)
                {

                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPVuvuzela,
                        10f, 10, true, ZeroitThematicProgress.Vuvuzela_Shape.Arc, 10, true,
                        Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red,
                        10

                    );

                    Set_Vuvuzela_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPWin8Horizontal)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPWin8Horizontal,
                        10, Color.Black,
                        10, 10D, true
                    );

                    Set_Win8Horizontal_Retrieved_Values(progressInput);
                }

                else if (mainControl_BarProgress_ComboBox.SelectedIndex ==
                         (int) ProgressBar.IPWin8Ring)
                {
                    progressInput = new ProgressInput(
                        //ProgressType.Bar,
                        //ProgressBar.IPWin8Ring,
                        10, Color.AliceBlue, 10, true
                    );

                    Set_Win8Ring_Retrieved_Values(progressInput);
                }


                
                DialogResult = DialogResult.OK;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Handles the MouseEnter event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
            closeBtn.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Handles the MouseLeave event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.FlatAppearance.BorderSize = 1;
            closeBtn.BackColor = Color.FromArgb(22, 22, 22);
        }



        #endregion

        private void mainControl_Smoothing_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserControl_Smoothing();
        }

        private void mainControl_TextRendering_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserControl_TextRendering();
        }

        private void mainControl_IncrementEasing_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserControl_EasingType();
        }

        private void mainControl_TransparentEasing_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserControl_TransparentEasing();
        }

        private void mainControl_HatchType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserControl_HatchType();
        }

        private void mainControl_AutoAnimate_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UserControl_AutoAnimate();
        }

        private void mainControl_AutoIncrement_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UserControl_AutoIncrement();
        }

        private void mainControl_AnimateStartAngle_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UserControl_AnimateStartAngle();
        }

        private void mainControl_ShowText_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UserControl_ShowText();
        }

        private void mainControl_FixedSize_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UserControl_FixedSize();
        }

        private void mainControl_PostFix_TextBox_TextChanged(object sender, EventArgs e)
        {
            UserControl_PostFix();
        }

        private void mainControl_Minimum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UserControl_Minimum();
        }

        private void mainControl_Maximum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UserControl_Maximum();
        }

        private void mainControl_AI_Duration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UserControl_Duration();
        }

        private void mainControl_AA_Speed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UserControl_Speed();
        }

        private void mainControl_ASA_Interval_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UserControl_Interval();
        }

        private void mainControl_StartingAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UserControl_StartAngle();
        }

        private void mainControl_HatchColor1_Btn_Click(object sender, EventArgs e)
        {
            UserControl_HatchColor1();
        }

        private void mainControl_HatchColor2_Btn_Click(object sender, EventArgs e)
        {
            UserControl_HatchColor2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainControl_Transparency_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            UserControl_Transparency();
        }

        

        
    }
}
