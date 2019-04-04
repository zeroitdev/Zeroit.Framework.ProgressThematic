// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressInput.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {

        

        #region Constructor

        
        #region Circular Constructor

        /// <summary>
        /// Constructor for CircularProgressBar
        /// </summary>
        /// <param name="_ProgressColor1">The progress color1.</param>
        /// <param name="_ProgressColor2">The progress color2.</param>
        /// <param name="_FillEllipse1">The fill ellipse1.</param>
        /// <param name="_FillEllipse2">The fill ellipse2.</param>
        /// <param name="_TextColor">Color of the text.</param>
        /// <param name="_ProgressColorInnerBorder">The progress color inner border.</param>
        /// <param name="ProgressShapeVal">The progress shape value.</param>
        /// <param name="_Start">The start.</param>
        /// <param name="_End">The end.</param>
        /// <param name="_ProgressWidth">Width of the progress.</param>
        /// <param name="_PenWidth">Width of the pen.</param>
        /// <param name="_showText">if set to <c>true</c> [show text].</param>
        /// <param name="zeroitProgressBarCircular_transparency">if set to <c>true</c> [zeroit progress bar circular transparency].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color _ProgressColor1,
            Color _ProgressColor2,
            Color _FillEllipse1,
            Color _FillEllipse2,
            Color _TextColor,
            Color _ProgressColorInnerBorder,
            ZeroitThematicProgress._ProgressShape ProgressShapeVal,
            LineCap _Start,
            LineCap _End,
            Double _ProgressWidth,
            float _PenWidth,
            bool _showText,
            bool zeroitProgressBarCircular_transparency
            //float _ProgressWidthToFloat,

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.CPBarCircular,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270)
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this._ProgressColor1 = _ProgressColor1;
            this._ProgressColor2 = _ProgressColor2;
            this._FillEllipse1 = _FillEllipse1;
            this._FillEllipse2 = _FillEllipse2;
            this._TextColor = _TextColor;
            this._ProgressColorInnerBorder = _ProgressColorInnerBorder;
            this.ProgressShapeVal = ProgressShapeVal;
            this._Start = _Start;
            this._End = _End;
            this._ProgressWidth = _ProgressWidth;
            this._PenWidth = _PenWidth;
            //this._ProgressWidthToFloat = _ProgressWidthToFloat;
            this._showText = _showText;
            this.zeroitProgressBarCircular_transparency = zeroitProgressBarCircular_transparency;

        }

        /// <summary>
        /// Constructor for CircularProgress Default
        /// </summary>
        /// <param name="CircularDef_ProgressColor1">The circular definition progress color1.</param>
        /// <param name="CircularDef_ProgressColor2">The circular definition progress color2.</param>
        /// <param name="CircularDef_InnerColor1">The circular definition inner color1.</param>
        /// <param name="CircularDef_InnerColor2">The circular definition inner color2.</param>
        /// <param name="CircularDef_ProgressShapeVal">The circular definition progress shape value.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color CircularDef_ProgressColor1,
            Color CircularDef_ProgressColor2,
            Color CircularDef_InnerColor1,
            Color CircularDef_InnerColor2,
            ZeroitThematicProgress._ProgressShape CircularDef_ProgressShapeVal
            
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircularDefault,
            ProgressBar.CPBarCircularDefault,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270
                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.CircularDef_ProgressColor1 = CircularDef_ProgressColor1;
            this.CircularDef_ProgressColor2 = CircularDef_ProgressColor2;
            this.CircularDef_InnerColor1 = CircularDef_InnerColor1;
            this.CircularDef_InnerColor2 = CircularDef_InnerColor2;
            this.CircularDef_ProgressShapeVal = CircularDef_ProgressShapeVal;

        }

        /// <summary>
        /// Constructor for Circular Progress V2
        /// </summary>
        /// <param name="CPv2_progressWidth">Width of the c PV2 progress.</param>
        /// <param name="CPv2_shift">The c PV2 shift.</param>
        /// <param name="CPv2_remainderAngle">The c PV2 remainder angle.</param>
        /// <param name="CPv2_startAngle">The c PV2 start angle.</param>
        /// <param name="CPv2_showText">if set to <c>true</c> [c PV2 show text].</param>
        /// <param name="CPv2_progressColor">Color of the c PV2 progress.</param>
        /// <param name="CPv2_progressEmptyColor">Empty color of the c PV2 progress.</param>
        public ProgressInput(

            //ProgressType progressType,
            //ProgressBar solidBars,
            int CPv2_progressWidth,
            int CPv2_shift,
            int CPv2_remainderAngle,
            int CPv2_startAngle,
            bool CPv2_showText,
            Color CPv2_progressColor,
            Color CPv2_progressEmptyColor
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.CircularProgressv2,
            ProgressBar.CPv2,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.CPv2_progressWidth = CPv2_progressWidth;
            this.CPv2_shift = CPv2_shift;
            this.CPv2_remainderAngle = CPv2_remainderAngle;
            this.CPv2_startAngle = CPv2_startAngle;
            this.CPv2_showText = CPv2_showText;
            this.CPv2_progressColor = CPv2_progressColor;
            this.CPv2_progressEmptyColor = CPv2_progressEmptyColor;

        }

        /// <summary>
        /// Constructor for Circular Progress V3
        /// </summary>
        /// <param name="CPv3_progressWidth">Width of the c PV3 progress.</param>
        /// <param name="CPv3_shift">The c PV3 shift.</param>
        /// <param name="CPv3_remainderAngle">The c PV3 remainder angle.</param>
        /// <param name="CPv3_startangle">The c PV3 startangle.</param>
        /// <param name="CPv3_showText">if set to <c>true</c> [c PV3 show text].</param>
        /// <param name="CPv3_progressColor">Color of the c PV3 progress.</param>
        /// <param name="CPv3_progressEmptyColor">Empty color of the c PV3 progress.</param>
        /// <param name="dummy">if set to <c>true</c> [dummy].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int CPv3_progressWidth,
            int CPv3_shift,
            int CPv3_remainderAngle,
            int CPv3_startangle,
            bool CPv3_showText,
            Color CPv3_progressColor,
            Color CPv3_progressEmptyColor,
            bool dummy
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.CircularProgressv3,
            ProgressBar.CPv3,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.CPv3_progressWidth = CPv3_progressWidth;
            this.CPv3_shift = CPv3_shift;
            this.CPv3_remainderAngle = CPv3_remainderAngle;
            this.CPv3_startangle = CPv3_startangle;
            this.CPv3_showText = CPv3_showText;
            this.CPv3_progressColor = CPv3_progressColor;
            this.CPv3_progressEmptyColor = CPv3_progressEmptyColor;
            this.dummyBool = dummy;
        }

        /// <summary>
        /// Constructor for Circular Progress V4
        /// </summary>
        /// <param name="CPv4_startAngle">The c PV4 start angle.</param>
        /// <param name="CPv4_thickness">The c PV4 thickness.</param>
        /// <param name="CPv4_gradAngle">The c PV4 grad angle.</param>
        /// <param name="CPv4_startCap">The c PV4 start cap.</param>
        /// <param name="CPv4_endCap">The c PV4 end cap.</param>
        /// <param name="CPv4_innerBorder">The c PV4 inner border.</param>
        /// <param name="CPv4_outerBorder">The c PV4 outer border.</param>
        /// <param name="CPv4_progGrad1">The c PV4 prog grad1.</param>
        /// <param name="CPv4_progGrad2">The c PV4 prog grad2.</param>
        /// <param name="CPv4_progBackGrad1">The c PV4 prog back grad1.</param>
        /// <param name="CPv4_progBackGrad2">The c PV4 prog back grad2.</param>
        /// <param name="CPv4_speed">The c PV4 speed.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int CPv4_startAngle,
            int CPv4_thickness,
            float CPv4_gradAngle,
            LineCap CPv4_startCap,
            LineCap CPv4_endCap,
            Color CPv4_innerBorder,
            Color CPv4_outerBorder,
            Color CPv4_progGrad1,
            Color CPv4_progGrad2,
            Color CPv4_progBackGrad1,
            Color CPv4_progBackGrad2,
            int CPv4_speed
            
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.CircularProgressv4,
            ProgressBar.CPv4,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.CPv4_startAngle = CPv4_startAngle;
            this.CPv4_thickness = CPv4_thickness;
            this.CPv4_gradAngle = CPv4_gradAngle;
            this.CPv4_startCap = CPv4_startCap;
            this.CPv4_endCap = CPv4_endCap;
            this.CPv4_innerBorder = CPv4_innerBorder;
            this.CPv4_outerBorder = CPv4_outerBorder;
            this.CPv4_progGrad1 = CPv4_progGrad1;
            this.CPv4_progGrad2 = CPv4_progGrad2;
            this.CPv4_progBackGrad1 = CPv4_progBackGrad1;
            this.CPv4_progBackGrad2 = CPv4_progBackGrad2;
            this.CPv4_speed = CPv4_speed;
        }

        /// <summary>
        /// Constructor for Circular Progress V5
        /// </summary>
        /// <param name="_borderEnabled">if set to <c>true</c> [border enabled].</param>
        /// <param name="_barSeperation">The bar seperation.</param>
        /// <param name="_barWidth">Width of the bar.</param>
        /// <param name="_displayPercentage">if set to <c>true</c> [display percentage].</param>
        /// <param name="_displayTotalPercentage">if set to <c>true</c> [display total percentage].</param>
        /// <param name="_smoothBars">if set to <c>true</c> [smooth bars].</param>
        /// <param name="_info">The information.</param>
        /// <param name="_textShadow">if set to <c>true</c> [text shadow].</param>
        /// <param name="_textShadowColor">Color of the text shadow.</param>
        /// <param name="_inactiveColorEnabled">if set to <c>true</c> [inactive color enabled].</param>
        /// <param name="CPv5_marqueeAngle">The c PV5 marquee angle.</param>
        /// <param name="CPv5_marquee">if set to <c>true</c> [c PV5 marquee].</param>
        /// <param name="CPv5_marqueeinterval">The c PV5 marqueeinterval.</param>
        /// <param name="CPv5_interval">The c PV5 interval.</param>
        /// <param name="otherinterval">The otherinterval.</param>
        /// <param name="CPv5_reset">if set to <c>true</c> [c PV5 reset].</param>
        /// <param name="bar1_Enabling">if set to <c>true</c> [bar1 enabling].</param>
        /// <param name="bar2_Enabling">if set to <c>true</c> [bar2 enabling].</param>
        /// <param name="bar3_Enabling">if set to <c>true</c> [bar3 enabling].</param>
        /// <param name="bar4_Enabling">if set to <c>true</c> [bar4 enabling].</param>
        /// <param name="bar5_Enabling">if set to <c>true</c> [bar5 enabling].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            //Size minimumSizeAllowed,
            //Size _minimumSize,
            //int _barCount,
            //BarData[] _bars,
            bool _borderEnabled,
            //Image _image,
            int _barSeperation,
            int _barWidth,
            bool _displayPercentage,
            bool _displayTotalPercentage,
            bool _smoothBars,
            string _info,
            bool _textShadow,
            Color _textShadowColor,
            bool _inactiveColorEnabled,
            int CPv5_marqueeAngle,
            bool CPv5_marquee,
            int CPv5_marqueeinterval,
            int CPv5_interval,
            int otherinterval,
            bool CPv5_reset,
            //bool _imageEnabled,
            bool bar1_Enabling,
            bool bar2_Enabling,
            bool bar3_Enabling,
            bool bar4_Enabling,
            bool bar5_Enabling

            ) : this(

            //ProgressType.Bar,
            //CircularProgress.CircularProgressv5,
            ProgressBar.CPv5,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            //this.minimumSizeAllowed = minimumSizeAllowed;
            //this._minimumSize = _minimumSize;
            //this._barCount = _barCount;
            //this._bars = _bars;
            this._borderEnabled = _borderEnabled;
            //this._image = _image;
            this._barSeperation = _barSeperation;
            this._barWidth = _barWidth;
            this._displayPercentage = _displayPercentage;
            this._displayTotalPercentage = _displayTotalPercentage;
            this._smoothBars = _smoothBars;
            this._info = _info;
            this._textShadow = _textShadow;
            this._textShadowColor = _textShadowColor;
            this._inactiveColorEnabled = _inactiveColorEnabled;
            this.CPv5_marqueeAngle = CPv5_marqueeAngle;
            this.CPv5_marquee = CPv5_marquee;
            this.CPv5_marqueeinterval = CPv5_marqueeinterval;
            this.CPv5_interval = CPv5_interval;
            this.otherinterval = otherinterval;
            this.CPv5_reset = CPv5_reset;
            //this._imageEnabled = _imageEnabled;

            this.bar1_Enabling = bar1_Enabling;
            this.bar2_Enabling = bar2_Enabling;
            this.bar3_Enabling = bar3_Enabling;
            this.bar4_Enabling = bar4_Enabling;
            this.bar5_Enabling = bar5_Enabling;

        }


        /// <summary>
        /// Constructor for Gorgeous Progress
        /// </summary>
        /// <param name="Gorgeous_enableInnerCover">if set to <c>true</c> [gorgeous enable inner cover].</param>
        /// <param name="Gorgeous_outerShift">The gorgeous outer shift.</param>
        /// <param name="Gorgeous_innerShift">The gorgeous inner shift.</param>
        /// <param name="Gorgeous_innerCoverShift">The gorgeous inner cover shift.</param>
        /// <param name="Gorgeous_smallRectShift">The gorgeous small rect shift.</param>
        /// <param name="Gorgeous_gradientColors">The gorgeous gradient colors.</param>
        /// <param name="Gorgeous_solidcolors">The gorgeous solidcolors.</param>
        /// <param name="Gorgeous_border">The gorgeous border.</param>
        /// <param name="Gorgeous_showText">if set to <c>true</c> [gorgeous show text].</param>
        /// <param name="_rotatingAngle">The rotating angle.</param>
        /// <param name="gorgeous_DrawMode">The gorgeous draw mode.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            bool Gorgeous_enableInnerCover,
            int Gorgeous_outerShift,
            int Gorgeous_innerShift,
            int Gorgeous_innerCoverShift,
            int Gorgeous_smallRectShift,
            Color[] Gorgeous_gradientColors,
            Color[] Gorgeous_solidcolors,
            int Gorgeous_border,
            bool Gorgeous_showText,
            ZeroitThematicProgress.Gorgeous_rotatingAngle _rotatingAngle,
            ZeroitThematicProgress.Gorgeous_drawMode gorgeous_DrawMode
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.GorgeousProgress,
            ProgressBar.CPGorgeous,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.Gorgeous_enableInnerCover = Gorgeous_enableInnerCover;
            this.Gorgeous_outerShift = Gorgeous_outerShift;
            this.Gorgeous_innerShift = Gorgeous_innerShift;
            this.Gorgeous_innerCoverShift = Gorgeous_innerCoverShift;
            this.Gorgeous_smallRectShift = Gorgeous_smallRectShift;
            this.Gorgeous_gradientColors = Gorgeous_gradientColors;
            this.Gorgeous_solidcolors = Gorgeous_solidcolors;
            this.Gorgeous_border = Gorgeous_border;
            this.Gorgeous_showText = Gorgeous_showText;
            this._rotatingAngle = _rotatingAngle;
            this.gorgeous_DrawMode = gorgeous_DrawMode;
        }

        /// <summary>
        /// Constructor for Ignito Progress
        /// </summary>
        /// <param name="Ignito_outerborder">The ignito outerborder.</param>
        /// <param name="Ignito_innerborder">The ignito innerborder.</param>
        /// <param name="Ignito_colors">The ignito colors.</param>
        /// <param name="Ignito_enableHatch">if set to <c>true</c> [ignito enable hatch].</param>
        /// <param name="Ignito_cap">The ignito cap.</param>
        /// <param name="Ignito_innerRotaAngle">The ignito inner rota angle.</param>
        /// <param name="Ignito_outterRotaAngle">The ignito outter rota angle.</param>
        /// <param name="ignito_drawMode">The ignito draw mode.</param>
        /// <param name="Ignito_borderStyleouter">The ignito border styleouter.</param>
        /// <param name="Ignito_borderStyleInner">The ignito border style inner.</param>
        public ProgressInput(

            //ProgressType progressType,
            //ProgressBar solidBars,
            float Ignito_outerborder,
            float Ignito_innerborder,
            Color[] Ignito_colors,
            bool Ignito_enableHatch,
            LineCap Ignito_cap,
            ZeroitThematicProgress.Ignito_innerRotatingAngle Ignito_innerRotaAngle,
            ZeroitThematicProgress.Ignito_outterRotatingAngle Ignito_outterRotaAngle,
            ZeroitThematicProgress.Ignito_drawMode ignito_drawMode,
            DashStyle Ignito_borderStyleouter,
            DashStyle Ignito_borderStyleInner
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.Ignito,
            ProgressBar.CPIgnito,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.Ignito_outerborder = Ignito_outerborder;
            this.Ignito_innerborder = Ignito_innerborder;
            this.Ignito_colors = Ignito_colors;
            this.Ignito_enableHatch = Ignito_enableHatch;
            this.Ignito_cap = Ignito_cap;
            this.Ignito_innerRotaAngle = Ignito_innerRotaAngle;
            this.Ignito_outterRotaAngle = Ignito_outterRotaAngle;
            this.ignito_drawMode = ignito_drawMode;
            this.Ignito_borderStyleouter = Ignito_borderStyleouter;
            this.Ignito_borderStyleInner = Ignito_borderStyleInner;
        }

        /// <summary>
        /// Constructor for Awesome
        /// </summary>
        /// <param name="ProgressAwesome_marqueeAnimationSpeed">The progress awesome marquee animation speed.</param>
        /// <param name="ProgressAwesome_superscriptText">The progress awesome superscript text.</param>
        /// <param name="ProgressAwesome_secondaryFont">The progress awesome secondary font.</param>
        /// <param name="ProgressAwesome_subscriptText">The progress awesome subscript text.</param>
        /// <param name="ProgressAwesome_superscriptColor">Color of the progress awesome superscript.</param>
        /// <param name="ProgressAwesome_subscriptColor">Color of the progress awesome subscript.</param>
        /// <param name="ProgressAwesome_startAngle">The progress awesome start angle.</param>
        /// <param name="ProgressAwesome_subscriptMargin">The progress awesome subscript margin.</param>
        /// <param name="ProgressAwesome_superscriptMargin">The progress awesome superscript margin.</param>
        /// <param name="ProgressAwesome_textMargin">The progress awesome text margin.</param>
        /// <param name="ProgressAwesome_animationSpeed">The progress awesome animation speed.</param>
        /// <param name="ProgressAwesome_outerMargin">The progress awesome outer margin.</param>
        /// <param name="ProgressAwesome_outerWidth">Width of the progress awesome outer.</param>
        /// <param name="ProgressAwesome_outerColor">Color of the progress awesome outer.</param>
        /// <param name="ProgressAwesome_progressWidth">Width of the progress awesome progress.</param>
        /// <param name="ProgressAwesome_progressColor">Color of the progress awesome progress.</param>
        /// <param name="ProgressAwesome_innerMargin">The progress awesome inner margin.</param>
        /// <param name="ProgressAwesome_innerWidth">Width of the progress awesome inner.</param>
        /// <param name="ProgressAwesome_innerColor">Color of the progress awesome inner.</param>
        /// <param name="ProgressAwesome_style">The progress awesome style.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            float ProgressAwesome_marqueeAnimationSpeed,
            string ProgressAwesome_superscriptText,
            Font ProgressAwesome_secondaryFont,
            string ProgressAwesome_subscriptText,
            Color ProgressAwesome_superscriptColor,
            Color ProgressAwesome_subscriptColor,
            int ProgressAwesome_startAngle,
            Padding ProgressAwesome_subscriptMargin,
            Padding ProgressAwesome_superscriptMargin,
            Padding ProgressAwesome_textMargin,
            int ProgressAwesome_animationSpeed,
            int ProgressAwesome_outerMargin,
            int ProgressAwesome_outerWidth,
            Color ProgressAwesome_outerColor,
            int ProgressAwesome_progressWidth,
            Color ProgressAwesome_progressColor,
            int ProgressAwesome_innerMargin,
            int ProgressAwesome_innerWidth,
            Color ProgressAwesome_innerColor,
            ProgressBarStyle ProgressAwesome_style
            //AnimationFunctions.Function ProgressAwesome_animationFunction,
            //KnownAnimationFunctions ProgressAwesome_knownAnimationFunction
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.Awesome,
            ProgressBar.CPAwesome,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.ProgressAwesome_marqueeAnimationSpeed = ProgressAwesome_marqueeAnimationSpeed;
            this.ProgressAwesome_superscriptText = ProgressAwesome_superscriptText;
            this.ProgressAwesome_secondaryFont = ProgressAwesome_secondaryFont;
            this.ProgressAwesome_subscriptText = ProgressAwesome_subscriptText;
            this.ProgressAwesome_superscriptColor = ProgressAwesome_superscriptColor;
            this.ProgressAwesome_subscriptColor = ProgressAwesome_subscriptColor;
            this.ProgressAwesome_startAngle = ProgressAwesome_startAngle;
            this.ProgressAwesome_subscriptMargin = ProgressAwesome_subscriptMargin;
            this.ProgressAwesome_superscriptMargin = ProgressAwesome_superscriptMargin;
            this.ProgressAwesome_textMargin = ProgressAwesome_textMargin;
            this.ProgressAwesome_animationSpeed = ProgressAwesome_animationSpeed;
            this.ProgressAwesome_outerMargin = ProgressAwesome_outerMargin;
            this.ProgressAwesome_outerWidth = ProgressAwesome_outerWidth;
            this.ProgressAwesome_outerColor = ProgressAwesome_outerColor;
            this.ProgressAwesome_progressWidth = ProgressAwesome_progressWidth;
            this.ProgressAwesome_progressColor = ProgressAwesome_progressColor;
            this.ProgressAwesome_innerMargin = ProgressAwesome_innerMargin;
            this.ProgressAwesome_innerWidth = ProgressAwesome_innerWidth;
            this.ProgressAwesome_innerColor = ProgressAwesome_innerColor;
            this.ProgressAwesome_style = ProgressAwesome_style;
            //this.ProgressAwesome_animationFunction = ProgressAwesome_animationFunction;
            //this.ProgressAwesome_knownAnimationFunction = ProgressAwesome_knownAnimationFunction;
        }

        /// <summary>
        /// Constructor for Perfect
        /// </summary>
        /// <param name="ProgressPerfect_interval">The progress perfect interval.</param>
        /// <param name="ProgressPerfect_circleColor">Color of the progress perfect circle.</param>
        /// <param name="ProgressPerfect_circleSize">Size of the progress perfect circle.</param>
        /// <param name="_numberOfCircles">The number of circles.</param>
        /// <param name="_numberOfVisibleCircles">The number of visible circles.</param>
        /// <param name="ProgressPerfect_rotation">The progress perfect rotation.</param>
        /// <param name="ProgressPerfect_percentage">The progress perfect percentage.</param>
        /// <param name="ProgressPerfect_showPercentage">if set to <c>true</c> [progress perfect show percentage].</param>
        /// <param name="ProgressBarPerfect_showText">if set to <c>true</c> [progress bar perfect show text].</param>
        /// <param name="ProgressPerfect_textDisplay">The progress perfect text display.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int ProgressPerfect_interval,
            Color ProgressPerfect_circleColor,
            //bool _stopped,
            float ProgressPerfect_circleSize,
            float _numberOfCircles,
            int _numberOfVisibleCircles,
            RotationType1 ProgressPerfect_rotation,
            float ProgressPerfect_percentage,
            bool ProgressPerfect_showPercentage,
            bool ProgressBarPerfect_showText,
            TextDisplayModes1 ProgressPerfect_textDisplay
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.Perfect,
            ProgressBar.CPPerfect,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.ProgressPerfect_interval = ProgressPerfect_interval;
            this.ProgressPerfect_circleColor = ProgressPerfect_circleColor;
            //this._stopped = _stopped;
            this.ProgressPerfect_circleSize = ProgressPerfect_circleSize;
            this._numberOfCircles = _numberOfCircles;
            this._numberOfVisibleCircles = _numberOfVisibleCircles;
            this.ProgressPerfect_rotation = ProgressPerfect_rotation;
            this.ProgressPerfect_percentage = ProgressPerfect_percentage;
            this.ProgressPerfect_showPercentage = ProgressPerfect_showPercentage;
            this.ProgressBarPerfect_showText = ProgressBarPerfect_showText;
            this.ProgressPerfect_textDisplay = ProgressPerfect_textDisplay;
        }

        /// <summary>
        /// Constructor for Circular Progress Pie
        /// </summary>
        /// <param name="ProgressPie_progressColor1">The progress pie progress color1.</param>
        /// <param name="ProgressPie_progressColor2">The progress pie progress color2.</param>
        /// <param name="ProgressPie_fillEllipse1">The progress pie fill ellipse1.</param>
        /// <param name="ProgressPie_fillEllipse2">The progress pie fill ellipse2.</param>
        /// <param name="ProgressPie_textColor">Color of the progress pie text.</param>
        /// <param name="ProgressPie_progressColorInnerBorder">The progress pie progress color inner border.</param>
        /// <param name="ProgressPie_progressShapeVal">The progress pie progress shape value.</param>
        /// <param name="ProgressPie_start">The progress pie start.</param>
        /// <param name="ProgressPie_end">The progress pie end.</param>
        /// <param name="ProgressPie_progressWidth">Width of the progress pie progress.</param>
        /// <param name="ProgressPie_penWidth">Width of the progress pie pen.</param>
        /// <param name="ProgressPie_showText">if set to <c>true</c> [progress pie show text].</param>
        /// <param name="ProgressPie_position">The progress pie position.</param>
        /// <param name="ProgressPie_sweepAngle">The progress pie sweep angle.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color ProgressPie_progressColor1,
            Color ProgressPie_progressColor2,
            Color ProgressPie_fillEllipse1,
            Color ProgressPie_fillEllipse2,
            Color ProgressPie_textColor,
            Color ProgressPie_progressColorInnerBorder,
            ZeroitThematicProgress.ProgressPie_ProgressShape ProgressPie_progressShapeVal,
            LineCap ProgressPie_start,
            LineCap ProgressPie_end,
            Double ProgressPie_progressWidth,
            float ProgressPie_penWidth,
            //float ProgressPie_progressWidthToFloat,
            bool ProgressPie_showText,
            float ProgressPie_position,
            float ProgressPie_sweepAngle
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ProgressPie,
            ProgressBar.CPProgressPie,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.ProgressPie_progressColor1 = ProgressPie_progressColor1;
            this.ProgressPie_progressColor2 = ProgressPie_progressColor2;
            this.ProgressPie_fillEllipse1 = ProgressPie_fillEllipse1;
            this.ProgressPie_fillEllipse2 = ProgressPie_fillEllipse2;
            this.ProgressPie_textColor = ProgressPie_textColor;
            this.ProgressPie_progressColorInnerBorder = ProgressPie_progressColorInnerBorder;
            this.ProgressPie_progressShapeVal = ProgressPie_progressShapeVal;
            this.ProgressPie_start = ProgressPie_start;
            this.ProgressPie_end = ProgressPie_end;
            this.ProgressPie_progressWidth = ProgressPie_progressWidth;
            this.ProgressPie_penWidth = ProgressPie_penWidth;
            //this.ProgressPie_progressWidthToFloat = ProgressPie_progressWidthToFloat;
            this.ProgressPie_showText = ProgressPie_showText;
            this.ProgressPie_position = ProgressPie_position;
            this.ProgressPie_sweepAngle = ProgressPie_sweepAngle;
        }

        /// <summary>
        /// Constructor for Rotating Arc
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="rotatingBorder">if set to <c>true</c> [rotating border].</param>
        /// <param name="pieArc">The pie arc.</param>
        /// <param name="RotatingArc_drawmode">The rotating arc drawmode.</param>
        /// <param name="_shape">The shape.</param>
        /// <param name="size">The size.</param>
        /// <param name="customHeartFade">The custom heart fade.</param>
        /// <param name="pieColor1">The pie color1.</param>
        /// <param name="pieColor2">The pie color2.</param>
        /// <param name="lineColor1">The line color1.</param>
        /// <param name="lineColor2">The line color2.</param>
        /// <param name="lineWidthColor">Color of the line width.</param>
        /// <param name="fillPie">if set to <c>true</c> [fill pie].</param>
        /// <param name="drawLine">if set to <c>true</c> [draw line].</param>
        /// <param name="colorOuterBorder">The color outer border.</param>
        /// <param name="innerCircle1Grad1">The inner circle1 grad1.</param>
        /// <param name="innerCircle1Grad2">The inner circle1 grad2.</param>
        /// <param name="innerCircle2Grad1">The inner circle2 grad1.</param>
        /// <param name="innerCircle2Grad2">The inner circle2 grad2.</param>
        /// <param name="innerCircle3Grad1">The inner circle3 grad1.</param>
        /// <param name="innerCircle3Grad2">The inner circle3 grad2.</param>
        /// <param name="innerCircle4Grad1">The inner circle4 grad1.</param>
        /// <param name="innerCircle4Grad2">The inner circle4 grad2.</param>
        /// <param name="innerCircle5Grad1">The inner circle5 grad1.</param>
        /// <param name="innerCircle5Grad2">The inner circle5 grad2.</param>
        /// <param name="innerCircle6Grad1">The inner circle6 grad1.</param>
        /// <param name="innerCircle6Grad2">The inner circle6 grad2.</param>
        /// <param name="showInnerCircle1">if set to <c>true</c> [show inner circle1].</param>
        /// <param name="showInnerCircle2">if set to <c>true</c> [show inner circle2].</param>
        /// <param name="showInnerCircle3">if set to <c>true</c> [show inner circle3].</param>
        /// <param name="showInnerCircle4">if set to <c>true</c> [show inner circle4].</param>
        /// <param name="showInnerCircle5">if set to <c>true</c> [show inner circle5].</param>
        /// <param name="showInnerCircle6">if set to <c>true</c> [show inner circle6].</param>
        /// <param name="outerBorderWidth">Width of the outer border.</param>
        /// <param name="innercircleBorder">The innercircle border.</param>
        /// <param name="widthReduction">The width reduction.</param>
        /// <param name="heightReduction">The height reduction.</param>
        /// <param name="innercircle2Width">Width of the innercircle2.</param>
        /// <param name="innercircle2Height">Height of the innercircle2.</param>
        /// <param name="innercircle3Width">Width of the innercircle3.</param>
        /// <param name="innercircle3Height">Height of the innercircle3.</param>
        /// <param name="innercircle4Width">Width of the innercircle4.</param>
        /// <param name="innercircle4Height">Height of the innercircle4.</param>
        /// <param name="innercircle5Width">Width of the innercircle5.</param>
        /// <param name="innercircle5Height">Height of the innercircle5.</param>
        /// <param name="innercircle6Width">Width of the innercircle6.</param>
        /// <param name="innercircle6Height">Height of the innercircle6.</param>
        /// <param name="heartinterval">The heartinterval.</param>
        /// <param name="heartAutoAnimate">if set to <c>true</c> [heart automatic animate].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            float angle,
            int interval,
            bool rotatingBorder,
            ZeroitThematicProgress.PieArc pieArc,
            ZeroitThematicProgress.RotatingArc_drawMode RotatingArc_drawmode,
            ZeroitThematicProgress.shape _shape,
            int size,
            Color customHeartFade,
            Color pieColor1,
            Color pieColor2,
            Color lineColor1,
            Color lineColor2,
            Color lineWidthColor,
            bool fillPie,
            bool drawLine,
            Color colorOuterBorder,
            Color innerCircle1Grad1,
            Color innerCircle1Grad2,
            Color innerCircle2Grad1,
            Color innerCircle2Grad2,
            Color innerCircle3Grad1,
            Color innerCircle3Grad2,
            Color innerCircle4Grad1,
            Color innerCircle4Grad2,
            Color innerCircle5Grad1,
            Color innerCircle5Grad2,
            Color innerCircle6Grad1,
            Color innerCircle6Grad2,
            bool showInnerCircle1,
            bool showInnerCircle2,
            bool showInnerCircle3,
            bool showInnerCircle4,
            bool showInnerCircle5,
            bool showInnerCircle6,
            int outerBorderWidth,
            int innercircleBorder,
            int widthReduction,
            int heightReduction,
            int innercircle2Width,
            int innercircle2Height,
            int innercircle3Width,
            int innercircle3Height,
            int innercircle4Width,
            int innercircle4Height,
            int innercircle5Width,
            int innercircle5Height,
            int innercircle6Width,
            int innercircle6Height,
            int heartinterval,
            bool heartAutoAnimate
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.RotatingArc,
            ProgressBar.CPRotatingArc,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.angle = angle;
            this.interval = interval;
            this.rotatingBorder = rotatingBorder;
            this.pieArc = pieArc;
            this.RotatingArc_drawmode = RotatingArc_drawmode;
            this._shape = _shape;
            this.size = size;
            this.customHeartFade = customHeartFade;
            this.pieColor1 = pieColor1;
            this.pieColor2 = pieColor2;
            this.lineColor1 = lineColor1;
            this.lineColor2 = lineColor2;
            this.lineWidthColor = lineWidthColor;
            this.fillPie = fillPie;
            this.drawLine = drawLine;
            this.colorOuterBorder = colorOuterBorder;
            this.innerCircle1Grad1 = innerCircle1Grad1;
            this.innerCircle1Grad2 = innerCircle1Grad2;
            this.innerCircle2Grad1 = innerCircle2Grad1;
            this.innerCircle2Grad2 = innerCircle2Grad2;
            this.innerCircle3Grad1 = innerCircle3Grad1;
            this.innerCircle3Grad2 = innerCircle3Grad2;
            this.innerCircle4Grad1 = innerCircle4Grad1;
            this.innerCircle4Grad2 = innerCircle4Grad2;
            this.innerCircle5Grad1 = innerCircle5Grad1;
            this.innerCircle5Grad2 = innerCircle5Grad2;
            this.innerCircle6Grad1 = innerCircle6Grad1;
            this.innerCircle6Grad2 = innerCircle6Grad2;
            this.showInnerCircle1 = showInnerCircle1;
            this.showInnerCircle2 = showInnerCircle2;
            this.showInnerCircle3 = showInnerCircle3;
            this.showInnerCircle4 = showInnerCircle4;
            this.showInnerCircle5 = showInnerCircle5;
            this.showInnerCircle6 = showInnerCircle6;
            this.outerBorderWidth = outerBorderWidth;
            this.innercircleBorder = innercircleBorder;
            this.widthReduction = widthReduction;
            this.heightReduction = heightReduction;
            this.innercircle2Width = innercircle2Width;
            this.innercircle2Height = innercircle2Height;
            this.innercircle3Width = innercircle3Width;
            this.innercircle3Height = innercircle3Height;
            this.innercircle4Width = innercircle4Width;
            this.innercircle4Height = innercircle4Height;
            this.innercircle5Width = innercircle5Width;
            this.innercircle5Height = innercircle5Height;
            this.innercircle6Width = innercircle6Width;
            this.innercircle6Height = innercircle6Height;
            this.heartinterval = heartinterval;
            this.heartAutoAnimate = heartAutoAnimate;

        }

        /// <summary>
        /// Constructor for Rotating Compass
        /// </summary>
        /// <param name="pieColor1">The pie color1.</param>
        /// <param name="pieColor2">The pie color2.</param>
        /// <param name="lineColor1">The line color1.</param>
        /// <param name="lineColor2">The line color2.</param>
        /// <param name="lineWidthColor">Color of the line width.</param>
        /// <param name="size">The size.</param>
        /// <param name="rotatingBorder">if set to <c>true</c> [rotating border].</param>
        /// <param name="angle">The angle.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color pieColor1,
            Color pieColor2,
            Color lineColor1,
            Color lineColor2,
            Color lineWidthColor,
            int size,
            bool rotatingBorder,
            float angle
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.RotatingCompass,
            ProgressBar.CPRotatingCompass,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.pieColor1 = pieColor1;
            this.pieColor2 = pieColor2;
            this.lineColor1 = lineColor1;
            this.lineColor2 = lineColor2;
            this.lineWidthColor = lineWidthColor;
            this.size = size;
            this.rotatingBorder = rotatingBorder;
            this.angle = angle;
        }

        /// <summary>
        /// Constructor for Supreme Progress
        /// </summary>
        /// <param name="SP_colorMode">The sp color mode.</param>
        /// <param name="progressColor">Color of the progress.</param>
        /// <param name="outerColor">Color of the outer.</param>
        /// <param name="solidColor">Color of the solid.</param>
        /// <param name="gradientColor">Color of the gradient.</param>
        /// <param name="linMode">The lin mode.</param>
        /// <param name="SP_angle">The sp angle.</param>
        /// <param name="outerborder">The outerborder.</param>
        /// <param name="innerborder">The innerborder.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            ZeroitThematicProgress.Supreme_colorMode SP_colorMode,
            Color progressColor,
            Color outerColor,
            Color solidColor,
            Color[] gradientColor,
            LinearGradientMode linMode,
            float SP_angle,
            int outerborder,
            int innerborder
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.CPSupreme,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270

                )
        {
            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.SP_colorMode = SP_colorMode;
            this.progressColor = progressColor;
            this.outerColor = outerColor;
            this.solidColor = solidColor;
            this.gradientColor = gradientColor;
            this.linMode = linMode;
            this.SP_angle = SP_angle;
            this.outerborder = outerborder;
            this.innerborder = innerborder;

        }

        /// <summary>
        /// Constructor for MultiCo
        /// </summary>
        /// <param name="MC_showInnerBorder">if set to <c>true</c> [mc show inner border].</param>
        /// <param name="MC_innerBorder">The mc inner border.</param>
        /// <param name="MC_shift">The mc shift.</param>
        /// <param name="MC_correctShift">The mc correct shift.</param>
        /// <param name="MC_rectShift">The mc rect shift.</param>
        /// <param name="MC_noOfRings">The mc no of rings.</param>
        /// <param name="MC_colors">The mc colors.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            bool MC_showInnerBorder,
            int MC_innerBorder,
            int MC_shift,
            int MC_correctShift,
            int MC_rectShift,
            Rings MC_noOfRings,
            Color[] MC_colors
            
            ) : this(

            //ProgressType.Bar,
            //CircularProgress.MulitCo,
            ProgressBar.CPMulitCo,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270
                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.MC_showInnerBorder = MC_showInnerBorder;
            this.MC_innerBorder = MC_innerBorder;
            this.MC_shift_Width = MC_shift;
            this.MC_correctShift_Width = MC_correctShift;
            this.MC_rectShift_Width = MC_rectShift;
            this.MC_noOfRings = MC_noOfRings;
            this.MC_colors = MC_colors;

        }

        /// <summary>
        /// Constructor for MultiCo Extended
        /// </summary>
        /// <param name="MCEx_showInnerBorder">if set to <c>true</c> [mc ex show inner border].</param>
        /// <param name="MCEx_innerBorder">The mc ex inner border.</param>
        /// <param name="MCEx_shift">The mc ex shift.</param>
        /// <param name="MCEx_correctShift">The mc ex correct shift.</param>
        /// <param name="MCEx_rectShift">The mc ex rect shift.</param>
        /// <param name="MCEx_noOfRings">The mc ex no of rings.</param>
        /// <param name="MCEx_colors">The mc ex colors.</param>
        /// <param name="MCEx_innerBorderColor">Color of the mc ex inner border.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            bool MCEx_showInnerBorder,
            int MCEx_innerBorder,
            int MCEx_shift,
            int MCEx_correctShift,
            int MCEx_rectShift,
            Rings MCEx_noOfRings,
            Color[] MCEx_colors,
            Color MCEx_innerBorderColor
            
            ) : this(

            //ProgressType.Bar,
            //CircularProgress.MultiCoExtended,
            ProgressBar.CPMultiCoExtended,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270
                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.MCEx_showInnerBorder = MCEx_showInnerBorder;
            this.MCEx_innerBorder = MCEx_innerBorder;
            this.MCEx_shift = MCEx_shift;
            this.MCEx_correctShift = MCEx_correctShift;
            this.MCEx_rectShift = MCEx_rectShift;
            this.MCEx_noOfRings = MCEx_noOfRings;
            this.MCEx_innerBorderColor = MCEx_innerBorderColor;
            this.MCEx_colors = MCEx_colors;

        }


        /// <summary>
        /// Constructor for MultiCo V1
        /// </summary>
        /// <param name="MCExV2_outerBorderStart">The mc ex v2 outer border start.</param>
        /// <param name="MCExV2_outerBorderEnd">The mc ex v2 outer border end.</param>
        /// <param name="MCExV2_outerBorderStyle">The mc ex v2 outer border style.</param>
        /// <param name="MCExV2_gradientAngle">The mc ex v2 gradient angle.</param>
        /// <param name="MCExV2_outerborder">if set to <c>true</c> [mc ex v2 outerborder].</param>
        /// <param name="MCExV2_rotatingborder">if set to <c>true</c> [mc ex v2 rotatingborder].</param>
        /// <param name="MCExV2_divisions">if set to <c>true</c> [mc ex v2 divisions].</param>
        /// <param name="MCExV2_divisionsWidth">Width of the mc ex v2 divisions.</param>
        /// <param name="MCExV2_drawMode">The mc ex v2 draw mode.</param>
        /// <param name="MCExV2_showInnerBorder">if set to <c>true</c> [mc ex v2 show inner border].</param>
        /// <param name="MCExV2_innerBorder">The mc ex v2 inner border.</param>
        /// <param name="MCExV2_shift">The mc ex v2 shift.</param>
        /// <param name="MCExV2_correctShift">The mc ex v2 correct shift.</param>
        /// <param name="MCExV2_rectShift">The mc ex v2 rect shift.</param>
        /// <param name="MCExV2_noOfRings">The mc ex v2 no of rings.</param>
        /// <param name="MCExV2_innerHoleColor">Color of the mc ex v2 inner hole.</param>
        /// <param name="MCExV2_innerHoleGradColor">Color of the mc ex v2 inner hole grad.</param>
        /// <param name="MCExV2_linColors0">The mc ex v2 lin colors0.</param>
        /// <param name="MCExV2_linColors1">The mc ex v2 lin colors1.</param>
        /// <param name="MCExV2_colors">The mc ex v2 colors.</param>
        /// <param name="MCExV2_innerBorderColor">Color of the mc ex v2 inner border.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            LineCap MCExV2_outerBorderStart,
            LineCap MCExV2_outerBorderEnd,
            DashStyle MCExV2_outerBorderStyle,
            float MCExV2_gradientAngle,
            bool MCExV2_outerborder,
            bool MCExV2_rotatingborder,
            bool MCExV2_divisions,
            int MCExV2_divisionsWidth,
            drawMode MCExV2_drawMode,
            bool MCExV2_showInnerBorder,
            int MCExV2_innerBorder,
            int MCExV2_shift,
            int MCExV2_correctShift,
            int MCExV2_rectShift,
            Rings MCExV2_noOfRings,
            Color MCExV2_innerHoleColor,
            Color[] MCExV2_innerHoleGradColor,
            Color[] MCExV2_linColors0,
            Color[] MCExV2_linColors1,
            Color[] MCExV2_colors,
            Color MCExV2_innerBorderColor
            ) : this(

            //ProgressType.Bar,
            //CircularProgress.MultiCoV1,
            ProgressBar.CPMultiCoV1,
            //ProgressIndicator.CircularIndeterminate,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270
                )
        {

            //this.progressType = progressType;
            //this.solidBars = solidBars;
            this.MCExV2_outerBorderStart = MCExV2_outerBorderStart;
            this.MCExV2_outerBorderEnd = MCExV2_outerBorderEnd;
            this.MCExV2_outerBorderStyle = MCExV2_outerBorderStyle;
            this.MCExV2_gradientAngle = MCExV2_gradientAngle;
            this.MCExV2_outerborder = MCExV2_outerborder;
            this.MCExV2_rotatingborder = MCExV2_rotatingborder;
            this.MCExV2_divisions = MCExV2_divisions;
            this.MCExV2_divisionsWidth = MCExV2_divisionsWidth;
            this.MCExV2_drawMode = MCExV2_drawMode;
            this.MCExV2_showInnerBorder = MCExV2_showInnerBorder;
            this.MCExV2_innerBorder = MCExV2_innerBorder;
            this.MCExV2_shift = MCExV2_shift;
            this.MCExV2_correctShift = MCExV2_correctShift;
            this.MCExV2_rectShift = MCExV2_rectShift;
            this.MCExV2_noOfRings = MCExV2_noOfRings;
            this.MCExV2_innerHoleColor = MCExV2_innerHoleColor;
            this.MCExV2_innerHoleGradColor = MCExV2_innerHoleGradColor;
            this.MCExV2_innerBorderColor = MCExV2_innerBorderColor;
            this.MCExV2_linColors0 = MCExV2_linColors0;
            this.MCExV2_linColors1 = MCExV2_linColors1;
            this.MCExV2_colors = MCExV2_colors;


        }

        #endregion
        
        #region Circular Added

        /// <summary>
        /// Constructor for Dagger Circular Progress
        /// </summary>
        /// <param name="Dag_unFilledColor">Color of the dag un filled.</param>
        /// <param name="Dag_filledColor">Color of the dag filled.</param>
        /// <param name="Dag_filledColorAlpha">The dag filled color alpha.</param>
        /// <param name="Dag_unfilledThickness">The dag unfilled thickness.</param>
        /// <param name="Dag_filledThickness">The dag filled thickness.</param>
        /// <param name="Dag_animationSpeed">The dag animation speed.</param>
        /// <param name="Dag_isAnimated">if set to <c>true</c> [dag is animated].</param>
        public ProgressInput(
            Color Dag_unFilledColor,
            Color Dag_filledColor,
            int Dag_filledColorAlpha,
            int Dag_unfilledThickness,
            int Dag_filledThickness,
            int Dag_animationSpeed,
            bool Dag_isAnimated

        ) : this(
            ProgressBar.CPDagger,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270)
        {
            this.Dag_unFilledColor = Dag_unFilledColor;
            this.Dag_filledColor = Dag_filledColor;
            this.Dag_filledColorAlpha = Dag_filledColorAlpha;
            this.Dag_unfilledThickness = Dag_unfilledThickness;
            this.Dag_filledThickness = Dag_filledThickness;
            this.Dag_animationSpeed = Dag_animationSpeed;
            this.Dag_isAnimated = Dag_isAnimated;

        }

        /// <summary>
        /// Constructor for DaggerV1 Circular Progress
        /// </summary>
        /// <param name="DagUp_unFilledColor">Color of the dag up un filled.</param>
        /// <param name="DagUp_filledColor">Color of the dag up filled.</param>
        /// <param name="DagUp_innerColor">Color of the dag up inner.</param>
        /// <param name="Dag_innercircleColor">Color of the dag innercircle.</param>
        /// <param name="Dag_innercircleBorder">The dag innercircle border.</param>
        /// <param name="DagUp_innerfilledAlpha">The dag up innerfilled alpha.</param>
        /// <param name="DagUp_innerfilledThickness">The dag up innerfilled thickness.</param>
        /// <param name="DagUp_filledColorAlpha">The dag up filled color alpha.</param>
        /// <param name="DagUp_unfilledThickness">The dag up unfilled thickness.</param>
        /// <param name="DagUp_filledThickness">The dag up filled thickness.</param>
        /// <param name="DagUp_animationSpeed">The dag up animation speed.</param>
        /// <param name="Dag_penWidth">Width of the dag pen.</param>
        /// <param name="dagStyled">if set to <c>true</c> [dag styled].</param>
        /// <param name="drawInnerCircle">if set to <c>true</c> [draw inner circle].</param>
        /// <param name="DagUp_isAnimated">if set to <c>true</c> [dag up is animated].</param>
        /// <param name="DagUpinnerBorder">if set to <c>true</c> [dag upinner border].</param>
        public ProgressInput(
            Color DagUp_unFilledColor,
            Color DagUp_filledColor,
            Color DagUp_innerColor,
            Color Dag_innercircleColor,
            Color Dag_innercircleBorder,
            int DagUp_innerfilledAlpha,
            int DagUp_innerfilledThickness,
            int DagUp_filledColorAlpha,
            int DagUp_unfilledThickness,
            int DagUp_filledThickness,
            int DagUp_animationSpeed,
            int Dag_penWidth,
            bool dagStyled,
            bool drawInnerCircle,
            bool DagUp_isAnimated,
            bool DagUpinnerBorder

            ) : this(
            ProgressBar.CPDaggerV1,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270)
        {

            this.DagUp_unFilledColor = DagUp_unFilledColor;
            this.DagUp_filledColor = DagUp_filledColor;
            this.DagUp_innerColor = DagUp_innerColor;
            this.Dag_innercircleColor = Dag_innercircleColor;
            this.Dag_innercircleBorder = Dag_innercircleBorder;
            this.DagUp_innerfilledAlpha = DagUp_innerfilledAlpha;
            this.DagUp_innerfilledThickness = DagUp_innerfilledThickness;
            this.DagUp_filledColorAlpha = DagUp_filledColorAlpha;
            this.DagUp_unfilledThickness = DagUp_unfilledThickness;
            this.DagUp_filledThickness = DagUp_filledThickness;
            this.DagUp_animationSpeed = DagUp_animationSpeed;
            this.Dag_penWidth = Dag_penWidth;
            this.dagStyled = dagStyled;
            this.drawInnerCircle = drawInnerCircle;
            this.DagUp_isAnimated = DagUp_isAnimated;
            this.DagUpinnerBorder = DagUpinnerBorder;
        }


        /// <summary>
        /// Constructor for DaggerSmooth Circular Progress
        /// </summary>
        /// <param name="DagSmooth_unFilledColor">Color of the dag smooth un filled.</param>
        /// <param name="DagSmooth_filledColor">Color of the dag smooth filled.</param>
        /// <param name="DagSmooth_innerColor">Color of the dag smooth inner.</param>
        /// <param name="DagSmooth_innerfilledAlpha">The dag smooth innerfilled alpha.</param>
        /// <param name="DagSmooth_innerfilledThickness">The dag smooth innerfilled thickness.</param>
        /// <param name="DagSmooth_filledColorAlpha">The dag smooth filled color alpha.</param>
        /// <param name="DagSmooth_unfilledThickness">The dag smooth unfilled thickness.</param>
        /// <param name="DagSmooth_filledThickness">The dag smooth filled thickness.</param>
        /// <param name="DagSmooth_animationSpeed">The dag smooth animation speed.</param>
        /// <param name="DagSmooth_endPoint">The dag smooth end point.</param>
        /// <param name="DagAnimendAngle">if set to <c>true</c> [dag animend angle].</param>
        /// <param name="DagSmooth_isAnimated">if set to <c>true</c> [dag smooth is animated].</param>
        /// <param name="Dag_Rotate">if set to <c>true</c> [dag rotate].</param>
        public ProgressInput(
            Color DagSmooth_unFilledColor,
            Color DagSmooth_filledColor,
            Color DagSmooth_innerColor,
            int DagSmooth_innerfilledAlpha,
            int DagSmooth_innerfilledThickness,
            int DagSmooth_filledColorAlpha,
            int DagSmooth_unfilledThickness,
            int DagSmooth_filledThickness,
            int DagSmooth_animationSpeed,
            int DagSmooth_endPoint,
            bool DagAnimendAngle,
            bool DagSmooth_isAnimated,
            bool Dag_Rotate
            ) : this(
            ProgressBar.CPDaggerSmooth,
            SmoothingMode.HighQuality,
            TextRenderingHint.AntiAlias,
            PeaceAnimatorEasing.BounceEaseIn,
            transparencyEasingType.BounceEaseIn,
            ZeroitThematicProgress.HatchBrushType.ForwardDiagonal,
            false,
            false,
            false,
            false,
            false,
            "%",
            Color.FromArgb(254, 84, 84),
            Color.DeepPink,
            0,
            100,
            5000,
            10,
            10,
            270)
        {
            this.DagSmooth_unFilledColor = DagSmooth_unFilledColor;
            this.DagSmooth_filledColor = DagSmooth_filledColor;
            this.DagSmooth_innerColor = DagSmooth_innerColor;
            this.DagSmooth_innerfilledAlpha = DagSmooth_innerfilledAlpha;
            this.DagSmooth_innerfilledThickness = DagSmooth_innerfilledThickness;
            this.DagSmooth_filledColorAlpha = DagSmooth_filledColorAlpha;
            this.DagSmooth_unfilledThickness = DagSmooth_unfilledThickness;
            this.DagSmooth_filledThickness = DagSmooth_filledThickness;
            this.DagSmooth_animationSpeed = DagSmooth_animationSpeed;
            this.DagSmooth_endPoint = DagSmooth_endPoint;
            this.DagAnimendAngle = DagAnimendAngle;
            this.DagSmooth_isAnimated = DagSmooth_isAnimated;
            this.Dag_Rotate = Dag_Rotate;
        }


        #endregion

        #endregion
        
    }
}
