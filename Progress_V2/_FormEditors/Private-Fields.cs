// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Private-Fields.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ProgressDialog
    {

        #region UserControls

        #region Bars

        private Extended_UC extended_UC = new Extended_UC();
        private Indicator_UC indicator_UC = new Indicator_UC();
        private iTunes_UC iTunes_UC = new iTunes_UC();
        private Maze_UC maze_UC = new Maze_UC();
        private Prog_Antonio_Normal_UC antonio_Normal_UC = new Prog_Antonio_Normal_UC();
        private ProgBar_Alter_UC alter_UC = new ProgBar_Alter_UC();
        private ProgBar_Clear_UC clear_UC = new ProgBar_Clear_UC();
        private ProgBar_Perplex_UC perplex_UC = new ProgBar_Perplex_UC();
        private ProgBar_Rect_UC rect_UC = new ProgBar_Rect_UC();
        private ProgBar_Splitter_UC splitter_UC = new ProgBar_Splitter_UC();
        private ProgBar_Transparent_UC transparent_UC = new ProgBar_Transparent_UC();

        #endregion

        #region Circular

        private CircularProgressBar_UC circularProgressBar_UC = new CircularProgressBar_UC();
        private CircularProgressBarDefault_UC circularProgressBarDefault_UC = new CircularProgressBarDefault_UC();
        private CircularProgressV2_UC circularProgressV2_UC = new CircularProgressV2_UC();
        private CircularProgressV3_UC circularProgressV3_UC = new CircularProgressV3_UC();
        private CircularProgressV4_UC circularProgressV4_UC = new CircularProgressV4_UC();
        private CircularProgressV5_UC circularProgressV5_UC = new CircularProgressV5_UC();
        private Gorgeous_UC gorgeous_UC = new Gorgeous_UC();
        private Ignito_UC ignito_UC = new Ignito_UC();
        private ProgressAwesome_UC progressAwesome_UC = new ProgressAwesome_UC();
        private ProgressBarPerfect_UC progressBarPerfect_UC = new ProgressBarPerfect_UC();
        private ProgressBarPie_UC progressBarPie_UC = new ProgressBarPie_UC();
        private RotatingArc_UC rotatingArc_UC = new RotatingArc_UC();
        private RotatingCompass_UC rotatingCompass_UC = new RotatingCompass_UC();
        private Supreme_UC supreme_UC = new Supreme_UC();
        private ZeroitMultiCo_UC zeroitMultiCo_UC = new ZeroitMultiCo_UC();
        private ZeroitMultiCoExtended_UC zeroitMultiCoExtended_UC = new ZeroitMultiCoExtended_UC();
        private ZeroitMultiCoExtendedV1_UC zeroitMultiCoExtendedV1_UC = new ZeroitMultiCoExtendedV1_UC();

        private Dagger_UC dagger_UC = new Dagger_UC();
        private DaggerV2_UC daggerV2_UC = new DaggerV2_UC();
        private DaggerSmooth_UC daggerSmooth_UC = new DaggerSmooth_UC();

        #endregion

        #region Indicator

        private CircularIndeterminate_UC circularIndeterminate_UC = new CircularIndeterminate_UC();
        private GoogleProgress_UC googleProgress_UC = new GoogleProgress_UC();
        private MacOSX_UC macOSX_UC = new MacOSX_UC();
        private MacOSX_Optimized_UC macOSX_Optimized_UC = new MacOSX_Optimized_UC();
        private Matrix_UC matrix_UC = new Matrix_UC();
        private ProgressIndicator_UC progressIndicator_UC = new ProgressIndicator_UC();
        private ProgressIndicatorUnique_UC progressIndicatorUnique_UC = new ProgressIndicatorUnique_UC();
        private SpinnerCircle_UC spinnerCircle_UC = new SpinnerCircle_UC();
        private SpinnerProgress_UC spinnerProgress_UC = new SpinnerProgress_UC();
        private Vuvuzela_UC vuvuzela_UC = new Vuvuzela_UC();
        private WinHorizontal_UC winHorizontal_UC = new WinHorizontal_UC();
        private WinRing_UC winRing_UC = new WinRing_UC();


        #endregion

        #endregion

        private bool animationRunnig = false;

        private void UserControl_Visibility()
        {
            
            #region Bars

            extended_UC.Visible = false;
            indicator_UC.Visible = false;
            iTunes_UC.Visible = false;
            maze_UC.Visible = false;
            antonio_Normal_UC.Visible = false;
            alter_UC.Visible = false;
            clear_UC.Visible = false;
            perplex_UC.Visible = false;
            rect_UC.Visible = false;
            splitter_UC.Visible = false;
            transparent_UC.Visible = false;

            #endregion

            #region Circular

            circularProgressBar_UC.Visible = false;
            circularProgressBarDefault_UC.Visible = false;
            circularProgressV2_UC.Visible = false;
            circularProgressV3_UC.Visible = false;
            circularProgressV4_UC.Visible = false;
            circularProgressV5_UC.Visible = false;
            gorgeous_UC.Visible = false;
            ignito_UC.Visible = false;
            progressAwesome_UC.Visible = false;
            progressBarPerfect_UC.Visible = false;
            progressBarPie_UC.Visible = false;
            rotatingArc_UC.Visible = false;
            rotatingCompass_UC.Visible = false;
            supreme_UC.Visible = false;
            zeroitMultiCo_UC.Visible = false;
            zeroitMultiCoExtended_UC.Visible = false;
            zeroitMultiCoExtendedV1_UC.Visible = false;
            dagger_UC.Visible = false;
            daggerV2_UC.Visible = false;
            daggerSmooth_UC.Visible = false;

            #endregion

            #region Indicator

            circularIndeterminate_UC.Visible = false;
            googleProgress_UC.Visible = false;
            macOSX_UC.Visible = false;
            macOSX_Optimized_UC.Visible = false;
            matrix_UC.Visible = false;
            progressIndicator_UC.Visible = false;
            progressIndicatorUnique_UC.Visible = false;
            spinnerCircle_UC.Visible = false;
            spinnerProgress_UC.Visible = false;
            vuvuzela_UC.Visible = false;
            winHorizontal_UC.Visible = false;
            winRing_UC.Visible = false;

            #endregion
            
        }

        private void UserControl_Smoothing()
        {


            #region Bars
            extended_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            indicator_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            iTunes_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            maze_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            antonio_Normal_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            alter_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            clear_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            perplex_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            rect_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            splitter_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            transparent_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());
            #endregion

            #region Circular

            
            circularProgressBar_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            circularProgressBarDefault_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            circularProgressV2_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            circularProgressV3_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            circularProgressV4_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            circularProgressV5_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            gorgeous_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            ignito_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            progressAwesome_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            progressBarPerfect_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            progressBarPie_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            rotatingArc_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            rotatingCompass_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            supreme_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            zeroitMultiCo_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            dagger_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            daggerV2_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            daggerSmooth_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            googleProgress_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            macOSX_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            macOSX_Optimized_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            matrix_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            progressIndicator_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            spinnerCircle_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            //spinnerProgress_UC.ZeroitThematicProgress1.Smoothing =
            //    (SmoothingMode)Enum.Parse
            //    (typeof(SmoothingMode),
            //        mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            vuvuzela_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            winHorizontal_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            winRing_UC.ZeroitThematicProgress1.Smoothing =
                (SmoothingMode)Enum.Parse
                (typeof(SmoothingMode),
                    mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            #endregion
        }

        private void UserControl_TextRendering()
        {


            #region Bars
            extended_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            indicator_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            iTunes_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            maze_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            antonio_Normal_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            alter_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            clear_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            perplex_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            rect_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            splitter_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            transparent_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());
            #endregion

            #region Circular


            circularProgressBar_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            circularProgressBarDefault_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            circularProgressV2_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            circularProgressV3_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            circularProgressV4_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            circularProgressV5_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            gorgeous_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            ignito_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            progressAwesome_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            progressBarPerfect_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            progressBarPie_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            rotatingArc_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            rotatingCompass_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            supreme_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            zeroitMultiCo_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            dagger_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            daggerV2_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            daggerSmooth_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            googleProgress_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            macOSX_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            macOSX_Optimized_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            matrix_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            progressIndicator_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            progressIndicatorUnique_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            spinnerCircle_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            //spinnerProgress_UC.ZeroitThematicProgress1.TextRendering =
            //    (TextRenderingHint)Enum.Parse
            //    (typeof(TextRenderingHint),
            //        mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            vuvuzela_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            winHorizontal_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            winRing_UC.ZeroitThematicProgress1.TextRendering =
                (TextRenderingHint)Enum.Parse
                (typeof(TextRenderingHint),
                    mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            #endregion
        }

        private void UserControl_EasingType()
        {


            #region Bars
            extended_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            indicator_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            iTunes_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            maze_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            antonio_Normal_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            alter_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            clear_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            perplex_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            rect_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            splitter_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            transparent_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());
            #endregion

            #region Circular


            circularProgressBar_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            circularProgressBarDefault_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            circularProgressV2_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            circularProgressV3_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            circularProgressV4_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            circularProgressV5_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            gorgeous_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            ignito_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            progressAwesome_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            progressBarPerfect_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            progressBarPie_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            rotatingArc_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            rotatingCompass_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            supreme_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            zeroitMultiCo_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            googleProgress_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            macOSX_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            macOSX_Optimized_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            matrix_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            progressIndicator_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            progressIndicatorUnique_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            spinnerCircle_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            //spinnerProgress_UC.ZeroitThematicProgress1.EasingType =
            //    (PeaceAnimatorEasing)Enum.Parse
            //    (typeof(PeaceAnimatorEasing),
            //        mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            vuvuzela_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            winHorizontal_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            winRing_UC.ZeroitThematicProgress1.EasingType =
                (PeaceAnimatorEasing)Enum.Parse
                (typeof(PeaceAnimatorEasing),
                    mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            #endregion
        }

        private void UserControl_TransparentEasing()
        {


            #region Bars
            extended_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            indicator_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            iTunes_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            maze_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            antonio_Normal_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            alter_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            clear_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            perplex_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            rect_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            splitter_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            transparent_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());
            #endregion

            #region Circular


            circularProgressBar_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            circularProgressBarDefault_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            circularProgressV2_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            circularProgressV3_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            circularProgressV4_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            circularProgressV5_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            gorgeous_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            ignito_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            progressAwesome_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            progressBarPerfect_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            progressBarPie_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            rotatingArc_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            rotatingCompass_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            supreme_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            zeroitMultiCo_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            dagger_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            daggerV2_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            daggerSmooth_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            googleProgress_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            macOSX_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            macOSX_Optimized_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            matrix_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            progressIndicator_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            progressIndicatorUnique_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            spinnerCircle_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            //spinnerProgress_UC.ZeroitThematicProgress1.TransparentEasing =
            //    (transparencyEasingType)Enum.Parse
            //    (typeof(transparencyEasingType),
            //        mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            vuvuzela_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            winHorizontal_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            winRing_UC.ZeroitThematicProgress1.TransparentEasing =
                (transparencyEasingType)Enum.Parse
                (typeof(transparencyEasingType),
                    mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            #endregion
        }
        
        private void UserControl_HatchType()
        {


            #region Bars
            extended_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            indicator_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            iTunes_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            maze_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            antonio_Normal_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            alter_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            clear_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            perplex_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            rect_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            splitter_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            transparent_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());
            #endregion

            #region Circular


            circularProgressBar_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            circularProgressBarDefault_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            circularProgressV2_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            circularProgressV3_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            circularProgressV4_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            circularProgressV5_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            gorgeous_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            ignito_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            progressAwesome_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            progressBarPerfect_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            progressBarPie_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            rotatingArc_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            rotatingCompass_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            supreme_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            zeroitMultiCo_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            dagger_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            daggerV2_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            daggerSmooth_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            googleProgress_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            macOSX_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            macOSX_Optimized_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            matrix_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            progressIndicator_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            progressIndicatorUnique_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            spinnerCircle_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            //spinnerProgress_UC.ZeroitThematicProgress1.HatchBrush =
            //    (ZeroitThematicProgress.HatchBrushType)Enum.Parse
            //    (typeof(ZeroitThematicProgress.HatchBrushType),
            //        mainControl_HatchType_ComboBox.SelectedItem.ToString());

            vuvuzela_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            winHorizontal_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            winRing_UC.ZeroitThematicProgress1.HatchBrush =
                (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                (typeof(ZeroitThematicProgress.HatchBrushType),
                    mainControl_HatchType_ComboBox.SelectedItem.ToString());

            #endregion
        }

        private void UserControl_AutoAnimate()
        {

            
            #region Bars
            
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                extended_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                indicator_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                iTunes_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                alter_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                alter_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                clear_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                clear_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                perplex_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                rect_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                rect_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                splitter_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                transparent_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                transparent_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }


            #endregion

            #region Circular

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                gorgeous_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                ignito_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressAwesome_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressBarPie_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                rotatingArc_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                supreme_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                dagger_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                daggerV2_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            #endregion

            #region Indicator

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                googleProgress_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                macOSX_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                macOSX_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                matrix_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressIndicator_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                progressIndicator_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            //if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AutoAnimate = true;
            //}
            //else
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AutoAnimate = false;
            //}

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                vuvuzela_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                winHorizontal_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                winRing_UC.ZeroitThematicProgress1.AutoAnimate = true;
            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            #endregion

        }

        private void UserControl_AutoIncrement()
        {
            
            #region Bars


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                extended_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                indicator_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                iTunes_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }



            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                alter_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                alter_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                clear_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                clear_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                perplex_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                rect_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                rect_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                splitter_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                transparent_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                transparent_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }


            #endregion

            #region Circular

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                gorgeous_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                ignito_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                progressAwesome_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                progressBarPie_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                rotatingArc_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                supreme_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                dagger_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                daggerV2_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            #endregion

            #region Indicator

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                googleProgress_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                macOSX_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                macOSX_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                matrix_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                progressIndicator_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                progressIndicator_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            //if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AutoIncrement = true;
            //}
            //else
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AutoIncrement = false;
            //}

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                vuvuzela_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                winHorizontal_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                winRing_UC.ZeroitThematicProgress1.AutoIncrement = true;
            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

            #endregion

        }
        
        private void UserControl_AnimateStartAngle()
        {


            #region Bars


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                extended_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                indicator_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                iTunes_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }



            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                alter_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                alter_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                clear_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                clear_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                perplex_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                rect_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                rect_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                splitter_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                transparent_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                transparent_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }


            #endregion

            #region Circular

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                gorgeous_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                ignito_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                progressAwesome_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                progressBarPie_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                rotatingArc_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                supreme_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                dagger_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                daggerV2_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            #endregion

            #region Indicator

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                googleProgress_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                macOSX_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                macOSX_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                matrix_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                progressIndicator_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                progressIndicator_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            //if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            //}
            //else
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            //}

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                vuvuzela_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                winHorizontal_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                winRing_UC.ZeroitThematicProgress1.AnimateStartAngle = true;
            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.AnimateStartAngle = false;
            }

            #endregion

        }

        private void UserControl_ShowText()
        {


            #region Bars


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                extended_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                indicator_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                iTunes_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.ShowText = false;
            }



            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                alter_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                alter_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                clear_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                clear_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                perplex_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                rect_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                rect_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                splitter_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.ShowText = false;
            }


            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                transparent_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                transparent_UC.ZeroitThematicProgress1.ShowText = false;
            }


            #endregion

            #region Circular

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularProgressBar_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularProgressV2_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularProgressV3_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularProgressV4_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularProgressV5_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                gorgeous_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                ignito_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressAwesome_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressBarPie_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                rotatingArc_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                rotatingCompass_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                supreme_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                dagger_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                daggerV2_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                daggerSmooth_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.ShowText = false;
            }

            #endregion

            #region Indicator

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                googleProgress_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                macOSX_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                macOSX_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                matrix_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressIndicator_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                progressIndicator_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                spinnerCircle_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.ShowText = false;
            }

            //if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.ShowText = true;
            //}
            //else
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.ShowText = false;
            //}

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                vuvuzela_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                winHorizontal_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.ShowText = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                winRing_UC.ZeroitThematicProgress1.ShowText = true;
            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.ShowText = false;
            }

            #endregion

        }

        private void UserControl_FixedSize()
        {


            #region Bars


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                extended_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                indicator_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                iTunes_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.FixedSize = false;
            }



            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                alter_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                alter_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                clear_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                clear_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                perplex_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                rect_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                rect_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                splitter_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                transparent_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                transparent_UC.ZeroitThematicProgress1.FixedSize = false;
            }


            #endregion

            #region Circular

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularProgressBar_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularProgressV2_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularProgressV3_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularProgressV4_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularProgressV5_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                gorgeous_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                ignito_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                progressAwesome_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                progressBarPie_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                rotatingArc_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                rotatingCompass_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                supreme_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                dagger_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                daggerV2_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                daggerSmooth_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            #endregion

            #region Indicator

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                googleProgress_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                macOSX_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                macOSX_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                matrix_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                progressIndicator_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                progressIndicator_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                spinnerCircle_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            //if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.FixedSize = true;
            //}
            //else
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.FixedSize = false;
            //}

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                vuvuzela_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                winHorizontal_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                winRing_UC.ZeroitThematicProgress1.FixedSize = true;
            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.FixedSize = false;
            }

            #endregion

        }

        private void UserControl_PostFix()
        {
            
            #region Bars

            extended_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            indicator_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            iTunes_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            maze_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            antonio_Normal_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            alter_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            clear_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            perplex_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            rect_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            splitter_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            transparent_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            circularProgressV2_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            circularProgressV3_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            circularProgressV4_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            circularProgressV5_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            gorgeous_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            ignito_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            progressAwesome_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            progressBarPerfect_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            progressBarPie_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            rotatingArc_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            rotatingCompass_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            supreme_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            zeroitMultiCo_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            dagger_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            daggerV2_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;
            daggerSmooth_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            googleProgress_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            macOSX_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            macOSX_Optimized_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            matrix_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            progressIndicator_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            spinnerCircle_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            //spinnerProgress_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            vuvuzela_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            winHorizontal_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;

            winRing_UC.ZeroitThematicProgress1.PostFix = mainControl_PostFix_TextBox.Text;


            #endregion


        }

        private void UserControl_Minimum()
        {

            #region Bars

            extended_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            indicator_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            iTunes_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            maze_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            antonio_Normal_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            alter_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            clear_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            perplex_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            rect_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            splitter_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            transparent_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            circularProgressV2_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            circularProgressV3_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            circularProgressV4_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            circularProgressV5_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            gorgeous_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            ignito_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            progressAwesome_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            progressBarPerfect_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            progressBarPie_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            rotatingArc_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            rotatingCompass_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            supreme_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            zeroitMultiCo_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            dagger_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            daggerV2_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;
            daggerSmooth_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            googleProgress_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            macOSX_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            macOSX_Optimized_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            matrix_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            progressIndicator_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            spinnerCircle_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            //spinnerProgress_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            vuvuzela_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            winHorizontal_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;

            winRing_UC.ZeroitThematicProgress1.Minimum = (float)mainControl_Minimum_Numeric.Value;


            #endregion


        }

        private void UserControl_Maximum()
        {

            #region Bars

            extended_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            indicator_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            iTunes_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            maze_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            antonio_Normal_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            alter_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            clear_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            perplex_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            rect_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            splitter_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            transparent_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            circularProgressV2_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            circularProgressV3_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            circularProgressV4_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            circularProgressV5_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            gorgeous_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            ignito_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            progressAwesome_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            progressBarPerfect_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            progressBarPie_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            rotatingArc_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            rotatingCompass_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            supreme_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            zeroitMultiCo_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            dagger_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            daggerV2_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;
            daggerSmooth_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;


            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            googleProgress_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            macOSX_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            macOSX_Optimized_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            matrix_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            progressIndicator_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            spinnerCircle_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            //spinnerProgress_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            vuvuzela_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            winHorizontal_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;

            winRing_UC.ZeroitThematicProgress1.Maximum = (float)mainControl_Maximum_Numeric.Value;


            #endregion


        }

        private void UserControl_Duration()
        {

            #region Bars

            extended_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            indicator_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            iTunes_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            maze_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            antonio_Normal_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            alter_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            clear_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            perplex_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            rect_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            splitter_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            transparent_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            circularProgressV2_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            circularProgressV3_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            circularProgressV4_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            circularProgressV5_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            gorgeous_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            ignito_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            progressAwesome_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            progressBarPerfect_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            progressBarPie_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            rotatingArc_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            rotatingCompass_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            supreme_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            zeroitMultiCo_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            dagger_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            daggerV2_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            daggerSmooth_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            googleProgress_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            macOSX_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            macOSX_Optimized_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            matrix_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            progressIndicator_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            spinnerCircle_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            //spinnerProgress_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            vuvuzela_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            winHorizontal_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;

            winRing_UC.ZeroitThematicProgress1.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;


            #endregion


        }

        private void UserControl_Speed()
        {

            #region Bars

            extended_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            indicator_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            iTunes_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            maze_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            antonio_Normal_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            alter_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            clear_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            perplex_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            rect_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            splitter_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            transparent_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            circularProgressV2_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            circularProgressV3_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            circularProgressV4_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            circularProgressV5_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            gorgeous_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            ignito_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            progressAwesome_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            progressBarPerfect_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            progressBarPie_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            rotatingArc_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            rotatingCompass_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            supreme_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            zeroitMultiCo_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            dagger_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            daggerV2_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            daggerSmooth_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            
            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            googleProgress_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            macOSX_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            macOSX_Optimized_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            matrix_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            progressIndicator_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            spinnerCircle_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            //spinnerProgress_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            vuvuzela_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            winHorizontal_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;

            winRing_UC.ZeroitThematicProgress1.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;


            #endregion


        }

        private void UserControl_Interval()
        {

            #region Bars

            extended_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            indicator_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            iTunes_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            maze_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            antonio_Normal_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            alter_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            clear_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            perplex_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            rect_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            splitter_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            transparent_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            circularProgressV2_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            circularProgressV3_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            circularProgressV4_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            circularProgressV5_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            gorgeous_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            ignito_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            progressAwesome_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            progressBarPerfect_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            progressBarPie_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            rotatingArc_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            rotatingCompass_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            supreme_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            zeroitMultiCo_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            dagger_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            daggerV2_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            daggerSmooth_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            googleProgress_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            macOSX_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            macOSX_Optimized_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            matrix_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            progressIndicator_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            spinnerCircle_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            //spinnerProgress_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            vuvuzela_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            winHorizontal_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;

            winRing_UC.ZeroitThematicProgress1.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;


            #endregion


        }

        private void UserControl_StartAngle()
        {

            #region Bars

            extended_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            indicator_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            iTunes_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            maze_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            antonio_Normal_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            alter_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            clear_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            perplex_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            rect_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            splitter_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            transparent_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            #endregion

            #region Circular

            circularProgressBar_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            circularProgressBarDefault_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            circularProgressV2_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            circularProgressV3_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            circularProgressV4_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            circularProgressV5_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            gorgeous_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            ignito_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            progressAwesome_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            progressBarPerfect_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            progressBarPie_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            rotatingArc_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            rotatingCompass_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            supreme_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            zeroitMultiCo_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            dagger_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            daggerV2_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;
            daggerSmooth_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;


            #endregion

            #region Indicator

            circularIndeterminate_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            googleProgress_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            macOSX_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            macOSX_Optimized_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            matrix_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            progressIndicator_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            spinnerCircle_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            //spinnerProgress_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            vuvuzela_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            winHorizontal_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;

            winRing_UC.ZeroitThematicProgress1.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;


            #endregion


        }

        private void UserControl_HatchColor1()
        {

            if (colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Bar Progress
                extended_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                indicator_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                antonio_Normal_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                alter_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                clear_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                perplex_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                rect_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                splitter_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                transparent_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;

                //Circular Progress
                circularProgressBar_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                circularProgressBarDefault_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                circularProgressV2_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                circularProgressV3_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                circularProgressV4_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                circularProgressV5_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                gorgeous_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                ignito_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                progressAwesome_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                progressBarPerfect_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                progressBarPie_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                rotatingArc_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                rotatingCompass_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                supreme_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                zeroitMultiCo_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;

                dagger_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                daggerV2_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                daggerSmooth_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;


                //Indicator Progress
                circularIndeterminate_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                googleProgress_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                macOSX_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                macOSX_Optimized_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                matrix_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                progressIndicator_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                progressIndicatorUnique_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                spinnerCircle_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                //spinnerProgress_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                vuvuzela_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                winHorizontal_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;
                winRing_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = colorSelector.Color;


                mainControl_HatchColor1_Btn.BackColor = colorSelector.Color;
            }
            
        }

        private void UserControl_HatchColor2()
        {

            if (colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Bar Progress
                extended_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                indicator_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                antonio_Normal_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                alter_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                clear_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                perplex_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                rect_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                splitter_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                transparent_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;

                //Circular Progress
                circularProgressBar_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                circularProgressBarDefault_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                circularProgressV2_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                circularProgressV3_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                circularProgressV4_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                circularProgressV5_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                gorgeous_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                ignito_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                progressAwesome_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                progressBarPerfect_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                progressBarPie_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                rotatingArc_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                rotatingCompass_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                supreme_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                zeroitMultiCo_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;

                dagger_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                daggerV2_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                daggerSmooth_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;

                //Indicator Progress
                circularIndeterminate_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                googleProgress_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                macOSX_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                macOSX_Optimized_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                matrix_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                progressIndicator_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                progressIndicatorUnique_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                spinnerCircle_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                //spinnerProgress_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                vuvuzela_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                winHorizontal_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;
                winRing_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = colorSelector.Color;


                mainControl_HatchColor2_Btn.BackColor = colorSelector.Color;
            }

        }

        private void UserControl_Transparency()
        {


            #region Bars


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                extended_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                indicator_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                iTunes_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }



            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                alter_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                alter_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                clear_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                clear_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                perplex_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                rect_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                rect_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                splitter_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                transparent_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                transparent_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }


            #endregion

            #region Circular

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                gorgeous_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                ignito_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressAwesome_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressBarPie_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                rotatingArc_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                supreme_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                dagger_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                daggerV2_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            #endregion

            #region Indicator

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                googleProgress_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                macOSX_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                macOSX_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                macOSX_Optimized_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                matrix_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressIndicator_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                progressIndicator_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            //if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AutoAnimate = true;
            //}
            //else
            //{
            //    spinnerProgress_UC.ZeroitThematicProgress1.AutoAnimate = false;
            //}

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                vuvuzela_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                winHorizontal_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                winRing_UC.ZeroitThematicProgress1.AllowTransparency = true;
            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.AllowTransparency = false;
            }

            #endregion

        }



        private void UserControl_Location()
        {

            #region Bars

            extended_UC.Location = new System.Drawing.Point(321,45);
            indicator_UC.Location = new System.Drawing.Point(321,45);
            iTunes_UC.Location = new System.Drawing.Point(321,45);
            maze_UC.Location = new System.Drawing.Point(321,45);
            antonio_Normal_UC.Location = new System.Drawing.Point(321,45);
            alter_UC.Location = new System.Drawing.Point(321,45);
            clear_UC.Location = new System.Drawing.Point(321,45);
            perplex_UC.Location = new System.Drawing.Point(321,45);
            rect_UC.Location = new System.Drawing.Point(321,45);
            splitter_UC.Location = new System.Drawing.Point(321,45);
            transparent_UC.Location = new System.Drawing.Point(321, 61);

            #endregion
            
            #region Circular

            circularProgressBar_UC.Location = new System.Drawing.Point(321,45);
            circularProgressBarDefault_UC.Location = new System.Drawing.Point(321,45);
            circularProgressV2_UC.Location = new System.Drawing.Point(321,45);
            circularProgressV3_UC.Location = new System.Drawing.Point(321,45);
            circularProgressV4_UC.Location = new System.Drawing.Point(321,45);
            circularProgressV5_UC.Location = new System.Drawing.Point(321,45);
            gorgeous_UC.Location = new System.Drawing.Point(321,45);
            ignito_UC.Location = new System.Drawing.Point(321,45);
            progressAwesome_UC.Location = new System.Drawing.Point(321,45);
            progressBarPerfect_UC.Location = new System.Drawing.Point(321,45);
            progressBarPie_UC.Location = new System.Drawing.Point(321,45);
            rotatingArc_UC.Location = new System.Drawing.Point(321,45);
            rotatingCompass_UC.Location = new System.Drawing.Point(321,45);
            supreme_UC.Location = new System.Drawing.Point(321,45);
            zeroitMultiCo_UC.Location = new System.Drawing.Point(321,45);
            zeroitMultiCoExtended_UC.Location = new System.Drawing.Point(321,45);
            zeroitMultiCoExtendedV1_UC.Location = new System.Drawing.Point(321,45);

            dagger_UC.Location = new System.Drawing.Point(321, 45);
            daggerV2_UC.Location = new System.Drawing.Point(321, 45);
            daggerSmooth_UC.Location = new System.Drawing.Point(321, 45);


            #endregion

            #region Indicator

            circularIndeterminate_UC.Location = new System.Drawing.Point(321,45);
            googleProgress_UC.Location = new System.Drawing.Point(321,45);
            macOSX_UC.Location = new System.Drawing.Point(321,45);
            macOSX_Optimized_UC.Location = new System.Drawing.Point(321,45);
            matrix_UC.Location = new System.Drawing.Point(321,45);
            progressIndicator_UC.Location = new System.Drawing.Point(321,45);
            progressIndicatorUnique_UC.Location = new System.Drawing.Point(321,45);
            spinnerCircle_UC.Location = new System.Drawing.Point(321,45);
            spinnerProgress_UC.Location = new System.Drawing.Point(321,45);
            vuvuzela_UC.Location = new System.Drawing.Point(321,45);
            winHorizontal_UC.Location = new System.Drawing.Point(321,45);
            winRing_UC.Location = new System.Drawing.Point(321, 61);

            #endregion

        }

        private void UserControl_AddControls()
        {

            AddIndicator();
            AddCircular();
            AddBars();
        }

        private void AddIndicator()
        {
            #region Indicator

            thematic1501.Controls.Add(circularIndeterminate_UC);
            thematic1501.Controls.Add(googleProgress_UC);
            thematic1501.Controls.Add(macOSX_UC);
            thematic1501.Controls.Add(macOSX_Optimized_UC);
            thematic1501.Controls.Add(matrix_UC);
            thematic1501.Controls.Add(progressIndicator_UC);
            thematic1501.Controls.Add(progressIndicatorUnique_UC);
            thematic1501.Controls.Add(spinnerCircle_UC);
            thematic1501.Controls.Add(spinnerProgress_UC);
            thematic1501.Controls.Add(vuvuzela_UC);
            thematic1501.Controls.Add(winHorizontal_UC);
            thematic1501.Controls.Add(winRing_UC);

            #endregion
        }

        private void Remove_Indicator()
        {
            #region Indicator

            thematic1501.Controls.Remove(circularIndeterminate_UC);
            thematic1501.Controls.Remove(googleProgress_UC);
            thematic1501.Controls.Remove(macOSX_UC);
            thematic1501.Controls.Remove(macOSX_Optimized_UC);
            thematic1501.Controls.Remove(matrix_UC);
            thematic1501.Controls.Remove(progressIndicator_UC);
            thematic1501.Controls.Remove(progressIndicatorUnique_UC);
            thematic1501.Controls.Remove(spinnerCircle_UC);
            thematic1501.Controls.Remove(spinnerProgress_UC);
            thematic1501.Controls.Remove(vuvuzela_UC);
            thematic1501.Controls.Remove(winHorizontal_UC);
            thematic1501.Controls.Remove(winRing_UC);

            #endregion
        }

        private void AddCircular()
        {
            #region Circular

            thematic1501.Controls.Add(circularProgressBar_UC);
            thematic1501.Controls.Add(circularProgressBarDefault_UC);
            thematic1501.Controls.Add(circularProgressV2_UC);
            thematic1501.Controls.Add(circularProgressV3_UC);
            thematic1501.Controls.Add(circularProgressV4_UC);
            thematic1501.Controls.Add(circularProgressV5_UC);
            thematic1501.Controls.Add(gorgeous_UC);
            thematic1501.Controls.Add(ignito_UC);
            thematic1501.Controls.Add(progressAwesome_UC);
            thematic1501.Controls.Add(progressBarPerfect_UC);
            thematic1501.Controls.Add(progressBarPie_UC);
            thematic1501.Controls.Add(rotatingArc_UC);
            thematic1501.Controls.Add(rotatingCompass_UC);
            thematic1501.Controls.Add(supreme_UC);
            thematic1501.Controls.Add(zeroitMultiCo_UC);
            thematic1501.Controls.Add(zeroitMultiCoExtended_UC);
            thematic1501.Controls.Add(zeroitMultiCoExtendedV1_UC);
            thematic1501.Controls.Add(dagger_UC);
            thematic1501.Controls.Add(daggerV2_UC);
            thematic1501.Controls.Add(daggerSmooth_UC);

            #endregion
        }

        private void Remove_Circular()
        {
            #region Circular

            thematic1501.Controls.Remove(circularProgressBar_UC);
            thematic1501.Controls.Remove(circularProgressBarDefault_UC);
            thematic1501.Controls.Remove(circularProgressV2_UC);
            thematic1501.Controls.Remove(circularProgressV3_UC);
            thematic1501.Controls.Remove(circularProgressV4_UC);
            thematic1501.Controls.Remove(circularProgressV5_UC);
            thematic1501.Controls.Remove(gorgeous_UC);
            thematic1501.Controls.Remove(ignito_UC);
            thematic1501.Controls.Remove(progressAwesome_UC);
            thematic1501.Controls.Remove(progressBarPerfect_UC);
            thematic1501.Controls.Remove(progressBarPie_UC);
            thematic1501.Controls.Remove(rotatingArc_UC);
            thematic1501.Controls.Remove(rotatingCompass_UC);
            thematic1501.Controls.Remove(supreme_UC);
            thematic1501.Controls.Remove(zeroitMultiCo_UC);
            thematic1501.Controls.Remove(zeroitMultiCoExtended_UC);
            thematic1501.Controls.Remove(zeroitMultiCoExtendedV1_UC);
            thematic1501.Controls.Remove(dagger_UC);
            thematic1501.Controls.Remove(daggerV2_UC);
            thematic1501.Controls.Remove(daggerSmooth_UC);

            #endregion
        }

        private void AddBars()
        {
            #region Bars

            thematic1501.Controls.Add(extended_UC);
            thematic1501.Controls.Add(indicator_UC);
            thematic1501.Controls.Add(iTunes_UC);
            thematic1501.Controls.Add(maze_UC);
            thematic1501.Controls.Add(antonio_Normal_UC);
            thematic1501.Controls.Add(alter_UC);
            thematic1501.Controls.Add(clear_UC);
            thematic1501.Controls.Add(perplex_UC);
            thematic1501.Controls.Add(rect_UC);
            thematic1501.Controls.Add(splitter_UC);
            thematic1501.Controls.Add(transparent_UC);

            #endregion
        }

        private void Remove_Bars()
        {
            #region Bars

            thematic1501.Controls.Remove(extended_UC);
            thematic1501.Controls.Remove(indicator_UC);
            thematic1501.Controls.Remove(iTunes_UC);
            thematic1501.Controls.Remove(maze_UC);
            thematic1501.Controls.Remove(antonio_Normal_UC);
            thematic1501.Controls.Remove(alter_UC);
            thematic1501.Controls.Remove(clear_UC);
            thematic1501.Controls.Remove(perplex_UC);
            thematic1501.Controls.Remove(rect_UC);
            thematic1501.Controls.Remove(splitter_UC);
            thematic1501.Controls.Remove(transparent_UC);

            #endregion
        }



    }
}
