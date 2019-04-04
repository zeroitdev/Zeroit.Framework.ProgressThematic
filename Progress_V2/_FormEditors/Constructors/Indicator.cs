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



        #region Indicator Constructor

        /// <summary>
        /// Constructor for Indeterminate Progress
        /// </summary>
        /// <param name="background_color">Color of the background.</param>
        /// <param name="circles_count">The circles count.</param>
        /// <param name="control_color">Color of the control.</param>
        /// <param name="control_width_height">Height of the control width.</param>
        /// <param name="indicator_angle">The indicator angle.</param>
        /// <param name="indicator_angular_advance">The indicator angular advance.</param>
        /// <param name="indicator_color">Color of the indicator.</param>
        /// <param name="indicator_diameter">The indicator diameter.</param>
        /// <param name="indicator_type">Type of the indicator.</param>
        /// <param name="refresh_rate">The refresh rate.</param>
        /// <param name="indeterminate_Animate">if set to <c>true</c> [indeterminate animate].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color background_color,
            int circles_count,
            Color control_color,
            int control_width_height,
            float indicator_angle,
            float indicator_angular_advance,
            Color indicator_color,
            int indicator_diameter,
            ZeroitThematicProgress.INDICATORTYPES indicator_type,
            int refresh_rate,
            bool indeterminate_Animate

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPIndeterminate,
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
            this.background_color = background_color;
            this.circles_count = circles_count;
            this.control_color = control_color;
            this.control_width_height = control_width_height;
            this.indicator_angle = indicator_angle;
            this.indicator_angular_advance = indicator_angular_advance;
            this.indicator_color = indicator_color;
            this.indicator_diameter = indicator_diameter;
            this.indicator_type = indicator_type;
            this.refresh_rate = refresh_rate;
            this.indeterminate_Animate = indeterminate_Animate;

        }

        /// <summary>
        /// Constructor for Google Progress
        /// </summary>
        /// <param name="GoogleProgress_annulus_color">Color of the google progress annulus.</param>
        /// <param name="GoogleProgress_background_color">Color of the google progress background.</param>
        /// <param name="GoogleProgress_indicator_angle">The google progress indicator angle.</param>
        /// <param name="GoogleProgress_indicator_angular_advance">The google progress indicator angular advance.</param>
        /// <param name="GoogleProgress_indicator_color">Color of the google progress indicator.</param>
        /// <param name="GoogleProgress_indicator_type">Type of the google progress indicator.</param>
        /// <param name="inner_radius">The inner radius.</param>
        /// <param name="outer_radius">The outer radius.</param>
        /// <param name="GoogleProgress_refresh_rate">The google progress refresh rate.</param>
        /// <param name="GoogleProgress_angle">The google progress angle.</param>
        /// <param name="transition_color">Color of the transition.</param>
        /// <param name="color1bigcircle">The color1bigcircle.</param>
        /// <param name="color2bigcircle">The color2bigcircle.</param>
        /// <param name="color1indicator">The color1indicator.</param>
        /// <param name="color2indicator">The color2indicator.</param>
        /// <param name="inner_color">Color of the inner.</param>
        /// <param name="inner_border">The inner border.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color GoogleProgress_annulus_color,
            //int GoogleProgress_annulus_thickness,
            Color GoogleProgress_background_color,
            int GoogleProgress_indicator_angle,
            int GoogleProgress_indicator_angular_advance,
            Color GoogleProgress_indicator_color,
            ZeroitThematicProgress.GoogleProgress_INDICATORTYPES GoogleProgress_indicator_type,
            int inner_radius,
            int outer_radius,
            int GoogleProgress_refresh_rate,
            float GoogleProgress_angle,
            Color transition_color,
            Color color1bigcircle,
            Color color2bigcircle,
            Color color1indicator,
            Color color2indicator,
            Color inner_color,
            int inner_border
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPGoogle,
            //ProgressIndicator.GoogleProgressIndicator,
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
            this.GoogleProgress_annulus_color = GoogleProgress_annulus_color;
            //this.GoogleProgress_annulus_thickness = GoogleProgress_annulus_thickness;
            this.GoogleProgress_background_color = GoogleProgress_background_color;
            this.GoogleProgress_indicator_angle = GoogleProgress_indicator_angle;
            this.GoogleProgress_indicator_angular_advance = GoogleProgress_indicator_angular_advance;
            this.GoogleProgress_indicator_color = GoogleProgress_indicator_color;
            this.GoogleProgress_indicator_type = GoogleProgress_indicator_type;
            this.inner_radius = inner_radius;
            this.outer_radius = outer_radius;
            this.GoogleProgress_refresh_rate = GoogleProgress_refresh_rate;
            this.GoogleProgress_angle = GoogleProgress_angle;
            this.transition_color = transition_color;
            this.color1bigcircle = color1bigcircle;
            this.color2bigcircle = color2bigcircle;
            this.color1indicator = color1indicator;
            this.color2indicator = color2indicator;
            this.inner_color = inner_color;
            this.inner_border = inner_border;


        }


        /// <summary>
        /// Constructor for MacOSX
        /// </summary>
        /// <param name="MacOSX_m_Interval">The mac osx m interval.</param>
        /// <param name="MacOSX_m_InnerRadius">The mac osx m inner radius.</param>
        /// <param name="MacOSX_m_OuterRadius">The mac osx m outer radius.</param>
        /// <param name="MacOSX_m_StartAngle">The mac osx m start angle.</param>
        /// <param name="MacOSX_m_AlphaStartValue">The mac osx m alpha start value.</param>
        /// <param name="MacOSX_m_SpokesCount">The mac osx m spokes count.</param>
        /// <param name="macOSX_Max_Spokes">The mac osx maximum spokes.</param>
        /// <param name="MacOSX_m_AngleIncrement">The mac osx m angle increment.</param>
        /// <param name="MacOSX_m_AlphaDecrement">The mac osx m alpha decrement.</param>
        /// <param name="MacOSX_startCap">The mac osx start cap.</param>
        /// <param name="MacOSX_endCap">The mac osx end cap.</param>
        /// <param name="_automatic">The automatic.</param>
        /// <param name="tick_Color">Color of the tick.</param>
        /// <param name="macOSX_Rotation">The mac osx rotation.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int MacOSX_m_Interval,
            int MacOSX_m_InnerRadius,
            int MacOSX_m_OuterRadius,
            int MacOSX_m_StartAngle,
            int MacOSX_m_AlphaStartValue,
            int MacOSX_m_SpokesCount,
            int macOSX_Max_Spokes,
            int MacOSX_m_AngleIncrement,
            int MacOSX_m_AlphaDecrement,
            LineCap MacOSX_startCap,
            LineCap MacOSX_endCap,
            MacOSX_automatic _automatic,
            Color tick_Color,
            ZeroitThematicProgress.MacOSX_Direction macOSX_Rotation

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPMacOSX,
            //ProgressIndicator.MacOSX,
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
            this.MacOSX_m_Interval = MacOSX_m_Interval;
            this.MacOSX_m_InnerRadius = MacOSX_m_InnerRadius;
            this.MacOSX_m_OuterRadius = MacOSX_m_OuterRadius;
            this.MacOSX_m_StartAngle = MacOSX_m_StartAngle;
            this.MacOSX_m_AlphaStartValue = MacOSX_m_AlphaStartValue;
            this.MacOSX_m_SpokesCount = MacOSX_m_SpokesCount;
            this.macOSX_Max_Spokes = macOSX_Max_Spokes;
            this.MacOSX_m_AngleIncrement = MacOSX_m_AngleIncrement;
            this.MacOSX_m_AlphaDecrement = MacOSX_m_AlphaDecrement;
            this.MacOSX_startCap = MacOSX_startCap;
            this.MacOSX_endCap = MacOSX_endCap;
            this._automatic = _automatic;
            this.tick_Color = tick_Color;
            this.macOSX_Rotation = macOSX_Rotation;

        }

        /// <summary>
        /// Constructor for MacOSX Optimized Progress
        /// </summary>
        /// <param name="MacOSX_Optimized_m_Interval">The mac osx optimized m interval.</param>
        /// <param name="MacOSX_Optimized_m_StartAngle">The mac osx optimized m start angle.</param>
        /// <param name="MacOSX_Optimized_m_AngleIncrement">The mac osx optimized m angle increment.</param>
        /// <param name="MacOSX_Optimized_m_SpokesCount">The mac osx optimized m spokes count.</param>
        /// <param name="macOSX_Max_Spokes">The mac osx maximum spokes.</param>
        /// <param name="MacOSX_Optimized_startCap">The mac osx optimized start cap.</param>
        /// <param name="MacOSX_Optimized_endCap">The mac osx optimized end cap.</param>
        /// <param name="_automatic">The automatic.</param>
        /// <param name="MacOSX_Optimized_m_Rotation">The mac osx optimized m rotation.</param>
        /// <param name="macOSX_Optimized_tick_Color">Color of the mac osx optimized tick.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int MacOSX_Optimized_m_Interval,
            float MacOSX_Optimized_m_StartAngle,
            float MacOSX_Optimized_m_AngleIncrement,
            int MacOSX_Optimized_m_SpokesCount,
            int macOSX_Max_Spokes,
            LineCap MacOSX_Optimized_startCap,
            LineCap MacOSX_Optimized_endCap,
            MacOSX_automatic _automatic,
            ZeroitThematicProgress.MacOSX_Direction MacOSX_Optimized_m_Rotation,
            Color macOSX_Optimized_tick_Color
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPMacOSXOptimized,
            //ProgressIndicator.MacOSXOptimized,
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
            this.MacOSX_Optimized_m_Interval = MacOSX_Optimized_m_Interval;
            this.MacOSX_Optimized_m_StartAngle = MacOSX_Optimized_m_StartAngle;
            this.MacOSX_Optimized_m_AngleIncrement = MacOSX_Optimized_m_AngleIncrement;
            this.MacOSX_Optimized_m_SpokesCount = MacOSX_Optimized_m_SpokesCount;
            this.macOSX_Max_Spokes = macOSX_Max_Spokes;
            this.MacOSX_Optimized_startCap = MacOSX_Optimized_startCap;
            this.MacOSX_Optimized_endCap = MacOSX_Optimized_endCap;
            this._automatic = _automatic;
            this.MacOSX_Optimized_m_Rotation = MacOSX_Optimized_m_Rotation;
            this.macOSX_Optimized_tick_Color = macOSX_Optimized_tick_Color;

        }


        /// <summary>
        /// Constructor for Matrix Progress
        /// </summary>
        /// <param name="MacOSX_Matrix_m_Interval">The mac osx matrix m interval.</param>
        /// <param name="MacOSX_Matrix_m_StartAngle">The mac osx matrix m start angle.</param>
        /// <param name="MacOSX_Matrix_m_SpokesCount">The mac osx matrix m spokes count.</param>
        /// <param name="macOSX_Max_Spokes">The mac osx maximum spokes.</param>
        /// <param name="MacOSX_Matrix_startCap">The mac osx matrix start cap.</param>
        /// <param name="MacOSX_Matrix_endCap">The mac osx matrix end cap.</param>
        /// <param name="_automatic">The automatic.</param>
        /// <param name="MacOSX_Matrix_m_Rotation">The mac osx matrix m rotation.</param>
        /// <param name="matrix_tick_Color">Color of the matrix tick.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int MacOSX_Matrix_m_Interval,
            float MacOSX_Matrix_m_StartAngle,
            int MacOSX_Matrix_m_SpokesCount,
            int macOSX_Max_Spokes,
            LineCap MacOSX_Matrix_startCap,
            LineCap MacOSX_Matrix_endCap,
            MacOSX_automatic _automatic,
            ZeroitThematicProgress.MacOSX_Direction MacOSX_Matrix_m_Rotation,
            Color matrix_tick_Color

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPMatrix,
            //ProgressIndicator.Matrix,
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
            this.MacOSX_Matrix_m_Interval = MacOSX_Matrix_m_Interval;
            this.MacOSX_Matrix_m_StartAngle = MacOSX_Matrix_m_StartAngle;
            this.MacOSX_Matrix_m_SpokesCount = MacOSX_Matrix_m_SpokesCount;
            this.macOSX_Max_Spokes = macOSX_Max_Spokes;
            this.MacOSX_Matrix_startCap = MacOSX_Matrix_startCap;
            this.MacOSX_Matrix_endCap = MacOSX_Matrix_endCap;
            this._automatic = _automatic;
            this.MacOSX_Matrix_m_Rotation = MacOSX_Matrix_m_Rotation;
            this.matrix_tick_Color = matrix_tick_Color;

        }

        /// <summary>
        /// Constructor for IndicatorV1 Progress
        /// </summary>
        /// <param name="baseColor">Color of the base.</param>
        /// <param name="animationColor">Color of the animation.</param>
        /// <param name="_visibleCircles">The visible circles.</param>
        /// <param name="_radian">The radian.</param>
        /// <param name="_circleWidth">Width of the circle.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color baseColor,
            Color animationColor,
            float _visibleCircles,
            double _radian,
            float _circleWidth

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPV1,
            //ProgressIndicator.IndicatorV1,
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
            this.baseColor = baseColor;
            this.animationColor = animationColor;
            this._visibleCircles = _visibleCircles;
            this._radian = _radian;
            this._circleWidth = _circleWidth;

        }

        /// <summary>
        /// Constructor for Unique Progress
        /// </summary>
        /// <param name="Unique_interval">The unique interval.</param>
        /// <param name="Unique_circleColor">Color of the unique circle.</param>
        /// <param name="Unique_circleSize">Size of the unique circle.</param>
        /// <param name="Unique_numberOfCircles">The unique number of circles.</param>
        /// <param name="Unique_numberOfVisibleCircles">The unique number of visible circles.</param>
        /// <param name="Unique_rotation">The unique rotation.</param>
        /// <param name="Unique_percentage">The unique percentage.</param>
        /// <param name="Unique_showPercentage">if set to <c>true</c> [unique show percentage].</param>
        /// <param name="Unique_showText">if set to <c>true</c> [unique show text].</param>
        /// <param name="Unique_textDisplay">The unique text display.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int Unique_interval,
            Color Unique_circleColor,
            float Unique_circleSize,
            int Unique_numberOfCircles,
            int Unique_numberOfVisibleCircles,
            Unique_RotationType Unique_rotation,
            float Unique_percentage,
            bool Unique_showPercentage,
            bool Unique_showText,
            Unique_TextDisplayModes Unique_textDisplay

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPUnique,
            //ProgressIndicator.Unique,
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
            this.Unique_interval = Unique_interval;
            this.Unique_circleColor = Unique_circleColor;
            this.Unique_circleSize = Unique_circleSize;
            this.Unique_numberOfCircles = Unique_numberOfCircles;
            this.Unique_numberOfVisibleCircles = Unique_numberOfVisibleCircles;
            this.Unique_rotation = Unique_rotation;
            this.Unique_percentage = Unique_percentage;
            this.Unique_showPercentage = Unique_showPercentage;
            this.Unique_showText = Unique_showText;
            this.Unique_textDisplay = Unique_textDisplay;

        }

        /// <summary>
        /// Constructor for Vuvuzela Progress
        /// </summary>
        /// <param name="Vuvuzela_angle">The vuvuzela angle.</param>
        /// <param name="Vuvuzela_interval">The vuvuzela interval.</param>
        /// <param name="Vuvuzela_rotatingBorder">if set to <c>true</c> [vuvuzela rotating border].</param>
        /// <param name="Vuvuzela_shape">The vuvuzela shape.</param>
        /// <param name="Vuvuzela_size">Size of the vuvuzela.</param>
        /// <param name="Vuvuzela_fillPie">if set to <c>true</c> [vuvuzela fill pie].</param>
        /// <param name="Vuvuzela_rotatingCircle">The vuvuzela rotating circle.</param>
        /// <param name="Vuvuzela_circle1">The vuvuzela circle1.</param>
        /// <param name="Vuvuzela_circle2">The vuvuzela circle2.</param>
        /// <param name="Vuvuzela_circle3">The vuvuzela circle3.</param>
        /// <param name="Vuvuzela_circle4">The vuvuzela circle4.</param>
        /// <param name="Vuvuzela_circle5">The vuvuzela circle5.</param>
        /// <param name="Vuvuzela_circleSize">Size of the vuvuzela circle.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            float Vuvuzela_angle,
            int Vuvuzela_interval,
            bool Vuvuzela_rotatingBorder,
            ZeroitThematicProgress.Vuvuzela_Shape Vuvuzela_shape,
            int Vuvuzela_size,
            bool Vuvuzela_fillPie,
            Color Vuvuzela_rotatingCircle,
            Color Vuvuzela_circle1,
            Color Vuvuzela_circle2,
            Color Vuvuzela_circle3,
            Color Vuvuzela_circle4,
            Color Vuvuzela_circle5,
            int Vuvuzela_circleSize

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPVuvuzela,
            //ProgressIndicator.Vuvuzela,
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
            this.Vuvuzela_angle = Vuvuzela_angle;
            this.Vuvuzela_interval = Vuvuzela_interval;
            this.Vuvuzela_rotatingBorder = Vuvuzela_rotatingBorder;
            this.Vuvuzela_shape = Vuvuzela_shape;
            this.Vuvuzela_size = Vuvuzela_size;
            this.Vuvuzela_fillPie = Vuvuzela_fillPie;
            this.Vuvuzela_rotatingCircle = Vuvuzela_rotatingCircle;
            this.Vuvuzela_circle1 = Vuvuzela_circle1;
            this.Vuvuzela_circle2 = Vuvuzela_circle2;
            this.Vuvuzela_circle3 = Vuvuzela_circle3;
            this.Vuvuzela_circle4 = Vuvuzela_circle4;
            this.Vuvuzela_circle5 = Vuvuzela_circle5;
            this.Vuvuzela_circleSize = Vuvuzela_circleSize;

        }

        /// <summary>
        /// Constructor for SpinnerCir Progress
        /// </summary>
        /// <param name="Spinner_m_IsTimerActive">if set to <c>true</c> [spinner m is timer active].</param>
        /// <param name="m_NumberOfSpoke">The m number of spoke.</param>
        /// <param name="m_SpokeThickness">The m spoke thickness.</param>
        /// <param name="m_OuterCircleRadius">The m outer circle radius.</param>
        /// <param name="m_InnerCircleRadius">The m inner circle radius.</param>
        /// <param name="m_Color">Color of the m.</param>
        /// <param name="_Timer_Interval">The timer interval.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            bool Spinner_m_IsTimerActive,
            int m_NumberOfSpoke,
            int m_SpokeThickness,
            int m_OuterCircleRadius,
            int m_InnerCircleRadius,
            Color m_Color,
            //ZeroitThematicProgress.StylePresets m_StylePreset,
            int _Timer_Interval

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPSpinnerCircle,
            //ProgressIndicator.SpinnerCircle,
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
            this.Spinner_m_IsTimerActive = Spinner_m_IsTimerActive;
            this.m_NumberOfSpoke = m_NumberOfSpoke;
            this.m_SpokeThickness = m_SpokeThickness;
            this.m_OuterCircleRadius = m_OuterCircleRadius;
            this.m_InnerCircleRadius = m_InnerCircleRadius;
            this.m_Color = m_Color;
            //this.m_StylePreset = m_StylePreset;
            this._Timer_Interval = _Timer_Interval;

        }

        /// <summary>
        /// Constructor for Spinner Divided Progress
        /// </summary>
        /// <param name="m_InactiveColour">The m inactive colour.</param>
        /// <param name="m_ActiveColour">The m active colour.</param>
        /// <param name="m_TransistionColour">The m transistion colour.</param>
        /// <param name="m_AutoIncrement">if set to <c>true</c> [m automatic increment].</param>
        /// <param name="m_IncrementFrequency">The m increment frequency.</param>
        /// <param name="m_BehindIsActive">if set to <c>true</c> [m behind is active].</param>
        /// <param name="m_TransitionSegment">The m transition segment.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color m_InactiveColour,
            Color m_ActiveColour,
            Color m_TransistionColour,
            bool m_AutoIncrement,
            double m_IncrementFrequency,
            bool m_BehindIsActive,
            int m_TransitionSegment

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPSpinnerDivided,
            //ProgressIndicator.SpinnerDivided,
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
            this.m_InactiveColour = m_InactiveColour;
            this.m_ActiveColour = m_ActiveColour;
            this.m_TransistionColour = m_TransistionColour;
            this.m_AutoIncrement = m_AutoIncrement;
            this.m_IncrementFrequency = m_IncrementFrequency;
            this.m_BehindIsActive = m_BehindIsActive;
            this.m_TransitionSegment = m_TransitionSegment;

        }

        /// <summary>
        /// Constructor for Win8Horizontal Progress
        /// </summary>
        /// <param name="control_width">Width of the control.</param>
        /// <param name="WinHR_indicator_color">Color of the win hr indicator.</param>
        /// <param name="WinHR_refresh_rate">The win hr refresh rate.</param>
        /// <param name="timer_interval">The timer interval.</param>
        /// <param name="winHR_Animate">if set to <c>true</c> [win hr animate].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int control_width,
            Color WinHR_indicator_color,
            int WinHR_refresh_rate,
            double timer_interval,
            bool winHR_Animate

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPWin8Horizontal,
            //ProgressIndicator.Win8Horizontal,
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
            this.control_width = control_width;
            this.WinHR_indicator_color = WinHR_indicator_color;
            this.WinHR_refresh_rate = WinHR_refresh_rate;
            this.timer_interval = timer_interval;
            this.winHR_Animate = winHR_Animate;

        }

        /// <summary>
        /// Constructor for Win8Ring Progress
        /// </summary>
        /// <param name="WinRing_control_height">Height of the win ring control.</param>
        /// <param name="WinRing_indicator_color">Color of the win ring indicator.</param>
        /// <param name="WinRing_refresh_rate">The win ring refresh rate.</param>
        /// <param name="winRing_Animate">if set to <c>true</c> [win ring animate].</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            int WinRing_control_height,
            Color WinRing_indicator_color,
            int WinRing_refresh_rate,
            bool winRing_Animate

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.ZeroitProgressBarCircular,
            ProgressBar.IPWin8Ring,
            //ProgressIndicator.Win8Ring,
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
            this.WinRing_control_height = WinRing_control_height;
            this.WinRing_indicator_color = WinRing_indicator_color;
            this.WinRing_refresh_rate = WinRing_refresh_rate;
            this.winRing_Animate = winRing_Animate;

        }

        #endregion

    }
}
