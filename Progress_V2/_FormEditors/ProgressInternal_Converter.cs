// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressInternal_Converter.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {
        #region Converter

        /// <summary>
        /// Class ProgressInputConverter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class ProgressInputConverter : TypeConverter
        {

            /// <summary>
            /// Returns whether this converter can convert the object to the specified type, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
            /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
            /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
            /// <exception cref="ArgumentOutOfRangeException"></exception>
            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                   if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(Customize)";
                    }

                    else if (destinationType == typeof(InstanceDescriptor) && value is ProgressInput)
                    {
                        ProgressInput progressInput = (ProgressInput)value;

                        #region Switch Code

                        switch (progressInput.ProgressType)
                        {
                            case ProgressType.Bar:

                                switch (progressInput.SolidProgressBar)
                                {

                                    #region Bar

                                    case ProgressBar.RPAlter:

                                        ConstructorInfo ctor_Alter = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(Orientation)


                                        });

                                        if (ctor_Alter != null)
                                        {
                                            return new InstanceDescriptor(ctor_Alter, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.alterBar,
                                                progressInput.colorBack,
                                                progressInput.colorBorder,
                                                progressInput.colorText,
                                                progressInput.colorInside,
                                                progressInput.colorIC,
                                                progressInput.color1,
                                                progressInput.color2,
                                                progressInput.colorAngle,
                                                progressInput._ShowValue,
                                                progressInput._Orientation

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPClear:

                                        ConstructorInfo ctor_Clear = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress.coloringMode)
                                            //typeof(int)


                                        });

                                        if (ctor_Clear != null)
                                        {
                                            return new InstanceDescriptor(ctor_Clear, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.clearBar,
                                                progressInput.ProgressBarClear_glow,
                                                progressInput.ProgressBarClear_edge,
                                                progressInput.ProgressBarClear_gradient1,
                                                progressInput.ProgressBarClear_gradient2,
                                                progressInput._coloringMode
                                                //progressInput.GlowPosition

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPExtendedProgress:

                                        ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                                    {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(ProgressBarEdge),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(ProgressFloodStyle),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(ProgressStyle),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ProgressCaptionMode),
                                            typeof(String),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(ProgressBarDirection),
                                            typeof(int),
                                            typeof(int)


                                                    });

                                        if (ctor != null)
                                        {
                                            return new InstanceDescriptor(ctor, new object[] {


                                                //progressInput.barType,
                                                //progressInput.extendedBar,
                                                progressInput.m_Edge,
                                                progressInput.m_EdgeColor,
                                                progressInput.m_EdgeLightColor,
                                                progressInput.m_EdgeWidth,
                                                progressInput.m_FloodStyle,
                                                progressInput.m_float_BarFlood,
                                                progressInput.m_int_BarOffset,
                                                progressInput.m_int_DashWidth,
                                                progressInput.m_int_DashSpace,
                                                progressInput.m_Style,
                                                progressInput.m_Color1,
                                                progressInput.m_Color2,
                                                progressInput.m_color_Back,
                                                progressInput.m_int_Step,
                                                progressInput.m_bool_Shadow,
                                                progressInput.m_int_ShadowOffset,
                                                progressInput.m_bool_Antialias,
                                                progressInput.m_color_Shadow,
                                                progressInput.m_color_Caption,
                                                progressInput.m_CaptionMode,
                                                progressInput.m_str_Caption,
                                                progressInput.m_bool_ChangeByMouse,
                                                progressInput.m_bool_Invert,
                                                progressInput.m_Direction,
                                                progressInput.m_int_Minimum,
                                                progressInput.ExtendedProgress_interval

                                            });
                                        }

                                        break;
                                    case ProgressBar.RPiTunes:

                                        ConstructorInfo ctor_iTunes = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(float),
                                            typeof(float),
                                            typeof(int),
                                            typeof(float),
                                            typeof(BarType),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(int),


                                        });

                                        if (ctor_iTunes != null)
                                        {
                                            return new InstanceDescriptor(ctor_iTunes, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.iTunesBar,
                                                progressInput.clrBarBgLight,
                                                progressInput.clrBarBgDark,
                                                progressInput.clrBarLight,
                                                progressInput.clrBarDark,
                                                progressInput.clrBorderColor,
                                                progressInput.fBorderWidth,
                                                progressInput.fMirrorOpacity,
                                                progressInput.iNumDividers,
                                                progressInput.iStepSize,
                                                progressInput.eBarType,
                                                progressInput.fNewProcent,
                                                progressInput.bAnimUp,
                                                progressInput.iTunesInterval,

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPMaze:

                                        ConstructorInfo ctor_Maze = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(ProgressBarStyle),
                                            typeof(float),
                                            typeof(int),
                                            typeof(MazeStyleType),
                                            typeof(Maze_GradientType),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color)


                                        });

                                        if (ctor_Maze != null)
                                        {
                                            return new InstanceDescriptor(ctor_Maze, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.mazeBar,
                                                progressInput.Maze_progressStyle,
                                                progressInput.Maze_marqueeAnimationSpeed,
                                                progressInput.Maze_rowCount,
                                                progressInput.Maze_mazeStyle,
                                                progressInput.Maze_gradient,
                                                progressInput.Maze_gradientStartColor,
                                                progressInput.Maze_gradientEndColor,
                                                progressInput.Maze_wallSize,
                                                progressInput.Maze_borderSize,
                                                progressInput.Maze_borderColor,
                                                progressInput.Maze_borderGradient,
                                                progressInput.Maze_borderRoundCorners,
                                                progressInput.Maze_unusedColor,
                                                progressInput.maze_solidColor,
                                                progressInput.wallColor

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPPerplex:

                                        ConstructorInfo ctor_Perplex = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(ZeroitThematicProgress.perplex_DrawMode)


                                        });

                                        if (ctor_Perplex != null)
                                        {
                                            return new InstanceDescriptor(ctor_Perplex, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.perplexBar,
                                                progressInput.Perplex_colorGradient1,
                                                progressInput.Perplex_colorGradient2,
                                                progressInput.Perplex_colorGradient3,
                                                progressInput.Perplex_colorGradient4,
                                                progressInput.colorPen,
                                                progressInput.colorGradientAngle,
                                                progressInput._ShowPercentage,
                                                progressInput._perplex_DrawMode

                                            });

                                        }

                                        break;
                                    //case ProgressBar.RPProgBoxed:
                                    //    break;
                                    //case ProgressBar.RPProgGradient:
                                    //    break;
                                    case ProgressBar.RPProgNormal:

                                        ConstructorInfo ctor_ProgressNormal = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(ZeroitThematicProgress.progressNormalType),
                                            typeof(int),
                                            typeof(ZeroitThematicProgress.TextColorTypes),
                                            typeof(ZeroitThematicProgress.TextAlignmentTypes),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress.BorderTypes),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(ZeroitThematicProgress.RollingTypes),
                                            typeof(int)


                                });

                                        if (ctor_ProgressNormal != null)
                                        {
                                            return new InstanceDescriptor(ctor_ProgressNormal, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.antonioNormalBar,
                                                progressInput._progressNormalType,
                                                progressInput.ProgressBarNormal_step,
                                                progressInput._TextColorType,
                                                progressInput._TextAlign,
                                                progressInput._DisplayProgress,
                                                progressInput._ColorProgress,
                                                progressInput._BorderType,
                                                progressInput.ProgressBarNormal_borderColor,
                                                progressInput._RollBlockPercent,
                                                progressInput._RollingType,
                                                progressInput.antonioInterval

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPRect:

                                        ConstructorInfo ctor_ProgressRect = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            //typeof(float),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int)


                                        });

                                        if (ctor_ProgressRect != null)
                                        {
                                            return new InstanceDescriptor(ctor_ProgressRect, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.rectBar,
                                                //progressInput.ProgressRect_percent,
                                                progressInput.ProgressRect_valueColour,
                                                progressInput.ProgressRect_colorBackground,
                                                progressInput.ProgressRect_colorBorder,
                                                progressInput.ProgressRect_corner

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPSplitter:

                                        ConstructorInfo ctor_Splitter = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(TProgressBarBorderStyle),
                                            typeof(Color)

                                        });

                                        if (ctor_Splitter != null)
                                        {
                                            return new InstanceDescriptor(ctor_Splitter, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.splitterBar,
                                                progressInput.m_ProgressBarBlockWidth,
                                                progressInput.m_ProgressBarBlockSpace,
                                                progressInput.m_ProgressBarPercent,
                                                progressInput.m_ProgressBarMarginOffset,
                                                progressInput.m_ProgressBarBorderStyle,
                                                progressInput.m_ProgressBarFillBrush_Color,


                                            });

                                        }

                                        break;
                                    case ProgressBar.RPTransparent:

                                        ConstructorInfo ctor_Transparent = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(Boolean),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color)

                                        });

                                        if (ctor_Transparent != null)
                                        {
                                            return new InstanceDescriptor(ctor_Transparent, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.transparentBar,
                                                progressInput._ShowText,
                                                progressInput._ProgressBackground,
                                                progressInput.Trns_progressColor1,
                                                progressInput.Trns_progressColor2

                                            });

                                        }

                                        break;
                                    case ProgressBar.RPIndicator:

                                        ConstructorInfo ctor_ZeroitIndicator = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            //typeof(ProgressType),
                                            ////typeof(ProgressBar),
                                            typeof(float),
                                            typeof(Color),
                                            typeof(Color),


                                        });

                                        if (ctor_ZeroitIndicator != null)
                                        {
                                            return new InstanceDescriptor(ctor_ZeroitIndicator, new object[]
                                            {

                                                //progressInput.barType,
                                                //progressInput.indicatorBar,
                                                progressInput._GraphWidth,
                                                progressInput.paintColor,
                                                progressInput.penColor

                                            });

                                        }

                                        break;
                                    #endregion

                                    #region Circular

                                    case ProgressBar.CPDagger:

                                        ConstructorInfo ctor_Dagger = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool)


                                        });

                                        if (ctor_Dagger != null)
                                        {
                                            return new InstanceDescriptor(ctor_Dagger, new object[]
                                            {

                                                progressInput.Dag_unFilledColor,
                                                progressInput.Dag_filledColor,
                                                progressInput.Dag_filledColorAlpha,
                                                progressInput.Dag_unfilledThickness,
                                                progressInput.Dag_filledThickness,
                                                progressInput.Dag_animationSpeed,
                                                progressInput.Dag_isAnimated,
                                            });

                                        }

                                        break;

                                    case ProgressBar.CPDaggerV1:

                                        ConstructorInfo ctor_DaggerV1 = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool)


                                        });

                                        if (ctor_DaggerV1 != null)
                                        {
                                            return new InstanceDescriptor(ctor_DaggerV1, new object[]
                                            {

                                                progressInput.DagUp_unFilledColor,
                                                progressInput.DagUp_filledColor,
                                                progressInput.DagUp_innerColor,
                                                progressInput.Dag_innercircleColor,
                                                progressInput.Dag_innercircleBorder,
                                                progressInput.DagUp_innerfilledAlpha,
                                                progressInput.DagUp_innerfilledThickness,
                                                progressInput.DagUp_filledColorAlpha,
                                                progressInput.DagUp_unfilledThickness,
                                                progressInput.DagUp_filledThickness,
                                                progressInput.DagUp_animationSpeed,
                                                progressInput.Dag_penWidth,
                                                progressInput.dagStyled,
                                                progressInput.drawInnerCircle,
                                                progressInput.DagUp_isAnimated,
                                                progressInput.DagUpinnerBorder
                                            });

                                        }

                                        break;

                                    case ProgressBar.CPDaggerSmooth:

                                        ConstructorInfo ctor_DaggerSmooth = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool)


                                        });

                                        if (ctor_DaggerSmooth != null)
                                        {
                                            return new InstanceDescriptor(ctor_DaggerSmooth, new object[]
                                            {

                                                progressInput.DagSmooth_unFilledColor,
                                                progressInput.DagSmooth_filledColor,
                                                progressInput.DagSmooth_innerColor,
                                                progressInput.DagSmooth_innerfilledAlpha,
                                                progressInput.DagSmooth_innerfilledThickness,
                                                progressInput.DagSmooth_filledColorAlpha,
                                                progressInput.DagSmooth_unfilledThickness,
                                                progressInput.DagSmooth_filledThickness,
                                                progressInput.DagSmooth_animationSpeed,
                                                progressInput.DagSmooth_endPoint,
                                                progressInput.DagAnimendAngle,
                                                progressInput.DagSmooth_isAnimated,
                                                progressInput.Dag_Rotate

                                            });

                                        }

                                        break;

                                    case ProgressBar.CPAwesome:

                                        ConstructorInfo ctor_Awesome = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(float),
                                            typeof(string),
                                            typeof(Font),
                                            typeof(string),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(Padding),
                                            typeof(Padding),
                                            typeof(Padding),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(ProgressBarStyle)
                                    //typeof(AnimationFunctions.Function),
                                    //typeof(KnownAnimationFunctions),


                                });

                                        if (ctor_Awesome != null)
                                        {
                                            return new InstanceDescriptor(ctor_Awesome, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularAwesome,
                                                progressInput.ProgressAwesome_marqueeAnimationSpeed,
                                                progressInput.ProgressAwesome_superscriptText,
                                                progressInput.ProgressAwesome_secondaryFont,
                                                progressInput.ProgressAwesome_subscriptText,
                                                progressInput.ProgressAwesome_superscriptColor,
                                                progressInput.ProgressAwesome_subscriptColor,
                                                progressInput.ProgressAwesome_startAngle,
                                                progressInput.ProgressAwesome_subscriptMargin,
                                                progressInput.ProgressAwesome_superscriptMargin,
                                                progressInput.ProgressAwesome_textMargin,
                                                progressInput.ProgressAwesome_animationSpeed,
                                                progressInput.ProgressAwesome_outerMargin,
                                                progressInput.ProgressAwesome_outerWidth,
                                                progressInput.ProgressAwesome_outerColor,
                                                progressInput.ProgressAwesome_progressWidth,
                                                progressInput.ProgressAwesome_progressColor,
                                                progressInput.ProgressAwesome_innerMargin,
                                                progressInput.ProgressAwesome_innerWidth,
                                                progressInput.ProgressAwesome_innerColor,
                                                progressInput.ProgressAwesome_style
                                                //progressInput.ProgressAwesome_animationFunction,
                                                //progressInput.ProgressAwesome_knownAnimationFunction

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPv2:

                                        ConstructorInfo ctor_V2 = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(Color)

                                        });

                                        if (ctor_V2 != null)
                                        {
                                            return new InstanceDescriptor(ctor_V2, new object[] {


                                                //progressInput.circularType,
                                                //progressInput.circularProgressV2,
                                                progressInput.CPv2_progressWidth,
                                                progressInput.CPv2_shift,
                                                progressInput.CPv2_remainderAngle,
                                                progressInput.CPv2_startAngle,
                                                progressInput.CPv2_showText,
                                                progressInput.CPv2_progressColor,
                                                progressInput.CPv2_progressEmptyColor,


                                            });
                                        }

                                        break;
                                    case ProgressBar.CPv3:

                                        ConstructorInfo ctor_V3 = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(bool)

                                        });

                                        if (ctor_V3 != null)
                                        {
                                            return new InstanceDescriptor(ctor_V3, new object[] {


                                                //progressInput.circularType,
                                                //progressInput.circularProgressV3,
                                                progressInput.CPv3_progressWidth,
                                                progressInput.CPv3_shift,
                                                progressInput.CPv3_remainderAngle,
                                                progressInput.CPv3_startangle,
                                                progressInput.CPv3_showText,
                                                progressInput.CPv3_progressColor,
                                                progressInput.CPv3_progressEmptyColor,
                                                progressInput.dummyBool

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPv4:

                                        ConstructorInfo ctor_V4 = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(int),
                                            typeof(float),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int)

                                });

                                        if (ctor_V4 != null)
                                        {
                                            return new InstanceDescriptor(ctor_V4, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularProgressV4,
                                                progressInput.CPv4_startAngle,
                                                progressInput.CPv4_thickness,
                                                progressInput.CPv4_gradAngle,
                                                progressInput.CPv4_startCap,
                                                progressInput.CPv4_endCap,
                                                progressInput.CPv4_innerBorder,
                                                progressInput.CPv4_outerBorder,
                                                progressInput.CPv4_progGrad1,
                                                progressInput.CPv4_progGrad2,
                                                progressInput.CPv4_progBackGrad1,
                                                progressInput.CPv4_progBackGrad2,
                                                progressInput.CPv4_speed,

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPv5:

                                        ConstructorInfo ctor_V5 = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            //typeof(Size),
                                            //typeof(Size),
                                            //typeof(int),
                                            //typeof(BarData[]),
                                            typeof(bool),
                                            //typeof(Image),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(string),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),
                                            //typeof(bool)
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool)

                                });

                                        if (ctor_V5 != null)
                                        {
                                            return new InstanceDescriptor(ctor_V5, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularProgressV5,
                                                //progressInput.minimumSizeAllowed,
                                                //progressInput._minimumSize,
                                                //progressInput._barCount,
                                                //progressInput._bars,
                                                progressInput._borderEnabled,
                                                //progressInput._image,
                                                progressInput._barSeperation,
                                                progressInput._barWidth,
                                                progressInput._displayPercentage,
                                                progressInput._displayTotalPercentage,
                                                progressInput._smoothBars,
                                                progressInput._info,
                                                progressInput._textShadow,
                                                progressInput._textShadowColor,
                                                progressInput._inactiveColorEnabled,
                                                progressInput.CPv5_marqueeAngle,
                                                progressInput.CPv5_marquee,
                                                progressInput.CPv5_marqueeinterval,
                                                progressInput.CPv5_interval,
                                                progressInput.otherinterval,
                                                progressInput.CPv5_reset,
                                                //progressInput._imageEnabled,
                                                progressInput.bar1_Enabling,
                                                progressInput.bar2_Enabling,
                                                progressInput.bar3_Enabling,
                                                progressInput.bar4_Enabling,
                                                progressInput.bar5_Enabling,
                                            });
                                        }


                                        break;
                                    //case ProgressBar.CircularProgressv5aClock:
                                    //    break;
                                    case ProgressBar.CPGorgeous:

                                        ConstructorInfo ctor_Gorgeous = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color[]),
                                            typeof(Color[]),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(ZeroitThematicProgress.Gorgeous_rotatingAngle),
                                            typeof(ZeroitThematicProgress.Gorgeous_drawMode)
                                });

                                        if (ctor_Gorgeous != null)
                                        {
                                            return new InstanceDescriptor(ctor_Gorgeous, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularGorgeous,
                                                progressInput.Gorgeous_enableInnerCover,
                                                progressInput.Gorgeous_outerShift,
                                                progressInput.Gorgeous_innerShift,
                                                progressInput.Gorgeous_innerCoverShift,
                                                progressInput.Gorgeous_smallRectShift,
                                                progressInput.Gorgeous_gradientColors,
                                                progressInput.Gorgeous_solidcolors,
                                                progressInput.Gorgeous_border,
                                                progressInput.Gorgeous_showText,
                                                progressInput._rotatingAngle,
                                                progressInput.gorgeous_DrawMode

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPIgnito:

                                        ConstructorInfo ctor_Ignito = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(float),
                                            typeof(float),
                                            typeof(Color[]),
                                            typeof(bool),
                                            typeof(LineCap),
                                            typeof(ZeroitThematicProgress.Ignito_innerRotatingAngle),
                                            typeof(ZeroitThematicProgress.Ignito_outterRotatingAngle),
                                            typeof(ZeroitThematicProgress.Ignito_drawMode),
                                            typeof(DashStyle),
                                            typeof(DashStyle)

                                });

                                        if (ctor_Ignito != null)
                                        {
                                            return new InstanceDescriptor(ctor_Ignito, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularIgnito,
                                                progressInput.Ignito_outerborder,
                                                progressInput.Ignito_innerborder,
                                                progressInput.Ignito_colors,
                                                progressInput.Ignito_enableHatch,
                                                progressInput.Ignito_cap,
                                                progressInput.Ignito_innerRotaAngle,
                                                progressInput.Ignito_outterRotaAngle,
                                                progressInput.ignito_drawMode,
                                                progressInput.Ignito_borderStyleouter,
                                                progressInput.Ignito_borderStyleInner

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPMulitCo:

                                        ConstructorInfo ctor_MultiCo = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Rings),
                                            typeof(Color[])

                                        });

                                        if (ctor_MultiCo != null)
                                        {
                                            return new InstanceDescriptor(ctor_MultiCo, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularMultiCo,
                                                progressInput.MC_showInnerBorder,
                                                progressInput.MC_innerBorder,
                                                progressInput.MC_shift_Width,
                                                progressInput.MC_correctShift_Width,
                                                progressInput.MC_rectShift_Width,
                                                progressInput.MC_noOfRings,
                                                progressInput.MC_colors

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPMultiCoExtended:

                                        ConstructorInfo ctor_MulticoExtended = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Rings),
                                            typeof(Color[]),
                                            typeof(Color)

                                        });

                                        if (ctor_MulticoExtended != null)
                                        {
                                            return new InstanceDescriptor(ctor_MulticoExtended, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularMultiCoExt,
                                                progressInput.MCEx_showInnerBorder,
                                                progressInput.MCEx_innerBorder,
                                                progressInput.MCEx_shift,
                                                progressInput.MCEx_correctShift,
                                                progressInput.MCEx_rectShift,
                                                progressInput.MCEx_noOfRings,
                                                progressInput.MCEx_colors,
                                                progressInput.MCEx_innerBorderColor

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPMultiCoV1:

                                        ConstructorInfo ctor_MultiCoV1 = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(DashStyle),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(drawMode),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Rings),
                                            typeof(Color),
                                            typeof(Color[]),
                                            typeof(Color[]),
                                            typeof(Color[]),
                                            typeof(Color[]),
                                            typeof(Color),


                                });

                                        if (ctor_MultiCoV1 != null)
                                        {
                                            return new InstanceDescriptor(ctor_MultiCoV1, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularMultiCoExtV1,
                                                progressInput.MCExV2_outerBorderStart,
                                                progressInput.MCExV2_outerBorderEnd,
                                                progressInput.MCExV2_outerBorderStyle,
                                                progressInput.MCExV2_gradientAngle,
                                                progressInput.MCExV2_outerborder,
                                                progressInput.MCExV2_rotatingborder,
                                                progressInput.MCExV2_divisions,
                                                progressInput.MCExV2_divisionsWidth,
                                                progressInput.MCExV2_drawMode,
                                                progressInput.MCExV2_showInnerBorder,
                                                progressInput.MCExV2_innerBorder,
                                                progressInput.MCExV2_shift,
                                                progressInput.MCExV2_correctShift,
                                                progressInput.MCExV2_rectShift,
                                                progressInput.MCExV2_noOfRings,
                                                progressInput.MCExV2_innerHoleColor,
                                                progressInput.MCExV2_innerHoleGradColor,
                                                progressInput.MCExV2_linColors0,
                                                progressInput.MCExV2_linColors1,
                                                progressInput.MCExV2_colors,
                                                progressInput.MCExV2_innerBorderColor


                                            });
                                        }

                                        break;
                                    case ProgressBar.CPPerfect:

                                        ConstructorInfo ctor_Perfect = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(Color),
                                            //typeof(bool),
                                            typeof(float),
                                            typeof(float),
                                            typeof(int),
                                            typeof(RotationType1),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(TextDisplayModes1)

                                });

                                        if (ctor_Perfect != null)
                                        {
                                            return new InstanceDescriptor(ctor_Perfect, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularPerfect,
                                                progressInput.ProgressPerfect_interval,
                                                progressInput.ProgressPerfect_circleColor,
                                                //progressInput._stopped,
                                                progressInput.ProgressPerfect_circleSize,
                                                progressInput._numberOfCircles,
                                                progressInput._numberOfVisibleCircles,
                                                progressInput.ProgressPerfect_rotation,
                                                progressInput.ProgressPerfect_percentage,
                                                progressInput.ProgressPerfect_showPercentage,
                                                progressInput.ProgressBarPerfect_showText,
                                                progressInput.ProgressPerfect_textDisplay
                                            });
                                        }

                                        break;
                                    case ProgressBar.CPProgressPie:

                                        ConstructorInfo ctor_ProgressPie = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress.ProgressPie_ProgressShape),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(Double),
                                            typeof(float),
                                            //typeof(float),
                                            typeof(bool),
                                            typeof(float),
                                            typeof(float)

                                });

                                        if (ctor_ProgressPie != null)
                                        {
                                            return new InstanceDescriptor(ctor_ProgressPie, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularProgressPie,
                                                progressInput.ProgressPie_progressColor1,
                                                progressInput.ProgressPie_progressColor2,
                                                progressInput.ProgressPie_fillEllipse1,
                                                progressInput.ProgressPie_fillEllipse2,
                                                progressInput.ProgressPie_textColor,
                                                progressInput.ProgressPie_progressColorInnerBorder,
                                                progressInput.ProgressPie_progressShapeVal,
                                                progressInput.ProgressPie_start,
                                                progressInput.ProgressPie_end,
                                                progressInput.ProgressPie_progressWidth,
                                                progressInput.ProgressPie_penWidth,
                                                //progressInput.ProgressPie_progressWidthToFloat,
                                                progressInput.ProgressPie_showText,
                                                progressInput.ProgressPie_position,
                                                progressInput.ProgressPie_sweepAngle
                                            });
                                        }


                                        break;
                                    case ProgressBar.CPRotatingArc:

                                        ConstructorInfo ctor_RotatingArc = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(float),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(ZeroitThematicProgress.PieArc),
                                            typeof(ZeroitThematicProgress.RotatingArc_drawMode),
                                            typeof(ZeroitThematicProgress.shape),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(bool),


                                });

                                        if (ctor_RotatingArc != null)
                                        {
                                            return new InstanceDescriptor(ctor_RotatingArc, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularArc,
                                                progressInput.angle,
                                                progressInput.interval,
                                                progressInput.rotatingBorder,
                                                progressInput.pieArc,
                                                progressInput.RotatingArc_drawmode,
                                                progressInput._shape,
                                                progressInput.size,
                                                progressInput.customHeartFade,
                                                progressInput.pieColor1,
                                                progressInput.pieColor2,
                                                progressInput.lineColor1,
                                                progressInput.lineColor2,
                                                progressInput.lineWidthColor,
                                                progressInput.fillPie,
                                                progressInput.drawLine,
                                                progressInput.colorOuterBorder,
                                                progressInput.innerCircle1Grad1,
                                                progressInput.innerCircle1Grad2,
                                                progressInput.innerCircle2Grad1,
                                                progressInput.innerCircle2Grad2,
                                                progressInput.innerCircle3Grad1,
                                                progressInput.innerCircle3Grad2,
                                                progressInput.innerCircle4Grad1,
                                                progressInput.innerCircle4Grad2,
                                                progressInput.innerCircle5Grad1,
                                                progressInput.innerCircle5Grad2,
                                                progressInput.innerCircle6Grad1,
                                                progressInput.innerCircle6Grad2,
                                                progressInput.showInnerCircle1,
                                                progressInput.showInnerCircle2,
                                                progressInput.showInnerCircle3,
                                                progressInput.showInnerCircle4,
                                                progressInput.showInnerCircle5,
                                                progressInput.showInnerCircle6,
                                                progressInput.outerBorderWidth,
                                                progressInput.innercircleBorder,
                                                progressInput.widthReduction,
                                                progressInput.heightReduction,
                                                progressInput.innercircle2Width,
                                                progressInput.innercircle2Height,
                                                progressInput.innercircle3Width,
                                                progressInput.innercircle3Height,
                                                progressInput.innercircle4Width,
                                                progressInput.innercircle4Height,
                                                progressInput.innercircle5Width,
                                                progressInput.innercircle5Height,
                                                progressInput.innercircle6Width,
                                                progressInput.innercircle6Height,
                                                progressInput.heartinterval,
                                                progressInput.heartAutoAnimate

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPRotatingCompass:

                                        ConstructorInfo ctor_RotatingCompass = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(float)

                                        });

                                        if (ctor_RotatingCompass != null)
                                        {
                                            return new InstanceDescriptor(ctor_RotatingCompass, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularCompass,
                                                progressInput.pieColor1,
                                                progressInput.pieColor2,
                                                progressInput.lineColor1,
                                                progressInput.lineColor2,
                                                progressInput.lineWidthColor,
                                                progressInput.size,
                                                progressInput.rotatingBorder,
                                                progressInput.angle

                                            });
                                        }


                                        break;
                                    case ProgressBar.CPSupreme:

                                        ConstructorInfo ctor_SupremeCircle = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(ZeroitThematicProgress.Supreme_colorMode),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color[]),
                                            typeof(LinearGradientMode),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int)

                                        });

                                        if (ctor_SupremeCircle != null)
                                        {
                                            return new InstanceDescriptor(ctor_SupremeCircle, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularSupreme,
                                                progressInput.SP_colorMode,
                                                progressInput.progressColor,
                                                progressInput.outerColor,
                                                progressInput.solidColor,
                                                progressInput.gradientColor,
                                                progressInput.linMode,
                                                progressInput.SP_angle,
                                                progressInput.outerborder,
                                                progressInput.innerborder

                                            });
                                        }

                                        break;
                                    case ProgressBar.CPBarCircular:

                                        ConstructorInfo ctor_ZeroitProgressBarCircular = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress._ProgressShape),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(Double),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(bool)

                                        });

                                        if (ctor_ZeroitProgressBarCircular != null)
                                        {
                                            return new InstanceDescriptor(ctor_ZeroitProgressBarCircular, new object[] {


                                                //progressInput.circularType,
                                                //progressInput.circularProgressBar,
                                                progressInput._ProgressColor1,
                                                progressInput._ProgressColor2,
                                                progressInput._FillEllipse1,
                                                progressInput._FillEllipse2,
                                                progressInput._TextColor,
                                                progressInput._ProgressColorInnerBorder,
                                                progressInput.ProgressShapeVal,
                                                progressInput._Start,
                                                progressInput._End,
                                                progressInput._ProgressWidth,
                                                progressInput._PenWidth,
                                                progressInput._showText,
                                                progressInput.zeroitProgressBarCircular_transparency


                                            });
                                        }

                                        break;
                                    case ProgressBar.CPBarCircularDefault:

                                        ConstructorInfo ctor_CircularDefault = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress._ProgressShape)


                                        });

                                        if (ctor_CircularDefault != null)
                                        {
                                            return new InstanceDescriptor(ctor_CircularDefault, new object[] {

                                                //progressInput.circularType,
                                                //progressInput.circularProgressBarDefault,
                                                progressInput.CircularDef_ProgressColor1,
                                                progressInput.CircularDef_ProgressColor2,
                                                progressInput.CircularDef_InnerColor1,
                                                progressInput.CircularDef_InnerColor2,
                                                progressInput.CircularDef_ProgressShapeVal

                                            });
                                        }

                                        break;
                                    #endregion

                                    #region Indicator

                                    case ProgressBar.IPIndeterminate:

                                        ConstructorInfo ctor_CircularIndeterminate = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(float),
                                            typeof(float),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(ZeroitThematicProgress.INDICATORTYPES),
                                            typeof(int),
                                            typeof(bool)

                                        });

                                        if (ctor_CircularIndeterminate != null)
                                        {
                                            return new InstanceDescriptor(ctor_CircularIndeterminate, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.indeterminate_Ind,
                                                progressInput.background_color,
                                                progressInput.circles_count,
                                                progressInput.control_color,
                                                progressInput.control_width_height,
                                                progressInput.indicator_angle,
                                                progressInput.indicator_angular_advance,
                                                progressInput.indicator_color,
                                                progressInput.indicator_diameter,
                                                progressInput.indicator_type,
                                                progressInput.refresh_rate,
                                                progressInput.indeterminate_Animate,


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPGoogle:

                                        ConstructorInfo ctor_GoogleProgIndicator = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            //typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress.GoogleProgress_INDICATORTYPES),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(float),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),

                                });

                                        if (ctor_GoogleProgIndicator != null)
                                        {
                                            return new InstanceDescriptor(ctor_GoogleProgIndicator, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.google_Ind,
                                                progressInput.GoogleProgress_annulus_color,
                                                //progressInput.GoogleProgress_annulus_thickness,
                                                progressInput.GoogleProgress_background_color,
                                                progressInput.GoogleProgress_indicator_angle,
                                                progressInput.GoogleProgress_indicator_angular_advance,
                                                progressInput.GoogleProgress_indicator_color,
                                                progressInput.GoogleProgress_indicator_type,
                                                progressInput.inner_radius,
                                                progressInput.outer_radius,
                                                progressInput.GoogleProgress_refresh_rate,
                                                progressInput.GoogleProgress_angle,
                                                progressInput.transition_color,
                                                progressInput.color1bigcircle,
                                                progressInput.color2bigcircle,
                                                progressInput.color1indicator,
                                                progressInput.color2indicator,
                                                progressInput.inner_color,
                                                progressInput.inner_border,


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPV1:

                                        ConstructorInfo ctor_IndicatorV1 = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(float),
                                            typeof(double),
                                            typeof(float)


                                        });

                                        if (ctor_IndicatorV1 != null)
                                        {
                                            return new InstanceDescriptor(ctor_IndicatorV1, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.indicatorV1_Ind,
                                                progressInput.baseColor,
                                                progressInput.animationColor,
                                                progressInput._visibleCircles,
                                                progressInput._radian,
                                                progressInput._circleWidth


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPMacOSX:

                                        ConstructorInfo ctor_MacOSX = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(MacOSX_automatic),
                                            typeof(Color),
                                            typeof(ZeroitThematicProgress.MacOSX_Direction),


                                });

                                        if (ctor_MacOSX != null)
                                        {
                                            return new InstanceDescriptor(ctor_MacOSX, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.macOsX_Ind,
                                                progressInput.MacOSX_m_Interval,
                                                progressInput.MacOSX_m_InnerRadius,
                                                progressInput.MacOSX_m_OuterRadius,
                                                progressInput.MacOSX_m_StartAngle,
                                                progressInput.MacOSX_m_AlphaStartValue,
                                                progressInput.MacOSX_m_SpokesCount,
                                                progressInput.macOSX_Max_Spokes,
                                                progressInput.MacOSX_m_AngleIncrement,
                                                progressInput.MacOSX_m_AlphaDecrement,
                                                progressInput.MacOSX_startCap,
                                                progressInput.MacOSX_endCap,
                                                progressInput._automatic,
                                                progressInput.tick_Color,
                                                progressInput.macOSX_Rotation

                                            });
                                        }

                                        break;
                                    case ProgressBar.IPMacOSXOptimized:

                                        ConstructorInfo ctor_MacOSXOptimized = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(float),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(MacOSX_automatic),
                                            typeof(ZeroitThematicProgress.MacOSX_Direction),
                                            typeof(Color)


                                });

                                        if (ctor_MacOSXOptimized != null)
                                        {
                                            return new InstanceDescriptor(ctor_MacOSXOptimized, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.macOsXOpt_Ind,
                                                progressInput.MacOSX_Optimized_m_Interval,
                                                progressInput.MacOSX_Optimized_m_StartAngle,
                                                progressInput.MacOSX_Optimized_m_AngleIncrement,
                                                progressInput.MacOSX_Optimized_m_SpokesCount,
                                                progressInput.macOSX_Max_Spokes,
                                                progressInput.MacOSX_Optimized_startCap,
                                                progressInput.MacOSX_Optimized_endCap,
                                                progressInput._automatic,
                                                progressInput.MacOSX_Optimized_m_Rotation,
                                                progressInput.macOSX_Optimized_tick_Color

                                            });
                                        }

                                        break;
                                    case ProgressBar.IPMatrix:

                                        ConstructorInfo ctor_Matrix = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(MacOSX_automatic),
                                            typeof(ZeroitThematicProgress.MacOSX_Direction),
                                            typeof(Color)


                                        });

                                        if (ctor_Matrix != null)
                                        {
                                            return new InstanceDescriptor(ctor_Matrix, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.matrix_Ind,
                                                progressInput.MacOSX_Matrix_m_Interval,
                                                progressInput.MacOSX_Matrix_m_StartAngle,
                                                progressInput.MacOSX_Matrix_m_SpokesCount,
                                                progressInput.macOSX_Max_Spokes,
                                                progressInput.MacOSX_Matrix_startCap,
                                                progressInput.MacOSX_Matrix_endCap,
                                                progressInput._automatic,
                                                progressInput.MacOSX_Matrix_m_Rotation,
                                                progressInput.matrix_tick_Color


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPSpinnerCircle:

                                        ConstructorInfo ctor_SpinnerCircle = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            //typeof(ZeroitThematicProgress.StylePresets),
                                            typeof(int)


                                        });

                                        if (ctor_SpinnerCircle != null)
                                        {
                                            return new InstanceDescriptor(ctor_SpinnerCircle, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.spinnerCirc_Ind,
                                                progressInput.Spinner_m_IsTimerActive,
                                                progressInput.m_NumberOfSpoke,
                                                progressInput.m_SpokeThickness,
                                                progressInput.m_OuterCircleRadius,
                                                progressInput.m_InnerCircleRadius,
                                                progressInput.m_Color,
                                                //progressInput.m_StylePreset,
                                                progressInput._Timer_Interval


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPSpinnerDivided:

                                        ConstructorInfo ctor_SpinnerDivided = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(bool),
                                            typeof(double),
                                            typeof(bool),
                                            typeof(int)


                                        });

                                        if (ctor_SpinnerDivided != null)
                                        {
                                            return new InstanceDescriptor(ctor_SpinnerDivided, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.spinnerDivided_Ind,
                                                progressInput.m_InactiveColour,
                                                progressInput.m_ActiveColour,
                                                progressInput.m_TransistionColour,
                                                progressInput.m_AutoIncrement,
                                                progressInput.m_IncrementFrequency,
                                                progressInput.m_BehindIsActive,
                                                progressInput.m_TransitionSegment

                                            });
                                        }

                                        break;
                                    case ProgressBar.IPUnique:

                                        ConstructorInfo ctor_Unique = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Unique_RotationType),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(bool),
                                            typeof(Unique_TextDisplayModes)



                                });

                                        if (ctor_Unique != null)
                                        {
                                            return new InstanceDescriptor(ctor_Unique, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.unique_Ind,
                                                progressInput.Unique_interval,
                                                progressInput.Unique_circleColor,
                                                progressInput.Unique_circleSize,
                                                progressInput.Unique_numberOfCircles,
                                                progressInput.Unique_numberOfVisibleCircles,
                                                progressInput.Unique_rotation,
                                                progressInput.Unique_percentage,
                                                progressInput.Unique_showPercentage,
                                                progressInput.Unique_showText,
                                                progressInput.Unique_textDisplay,


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPVuvuzela:

                                        ConstructorInfo ctor_Vuvuzela = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(float),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(ZeroitThematicProgress.Vuvuzela_Shape),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int)


                                });

                                        if (ctor_Vuvuzela != null)
                                        {
                                            return new InstanceDescriptor(ctor_Vuvuzela, new object[] {


                                                //progressInput.indicProgType,
                                                //progressInput.vuvuzela_Ind,
                                                progressInput.Vuvuzela_angle,
                                                progressInput.Vuvuzela_interval,
                                                progressInput.Vuvuzela_rotatingBorder,
                                                progressInput.Vuvuzela_shape,
                                                progressInput.Vuvuzela_size,
                                                progressInput.Vuvuzela_fillPie,
                                                progressInput.Vuvuzela_rotatingCircle,
                                                progressInput.Vuvuzela_circle1,
                                                progressInput.Vuvuzela_circle2,
                                                progressInput.Vuvuzela_circle3,
                                                progressInput.Vuvuzela_circle4,
                                                progressInput.Vuvuzela_circle5,
                                                progressInput.Vuvuzela_circleSize


                                            });
                                        }

                                        break;
                                    case ProgressBar.IPWin8Horizontal:

                                        ConstructorInfo ctor_WinHoriz = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(double),
                                            typeof(bool)

                                        });

                                        if (ctor_WinHoriz != null)
                                        {
                                            return new InstanceDescriptor(ctor_WinHoriz, new object[] {

                                                //progressInput.indicProgType,
                                                //progressInput.win8Horiz_Ind,
                                                progressInput.control_width,
                                                progressInput.WinHR_indicator_color,
                                                progressInput.WinHR_refresh_rate,
                                                progressInput.timer_interval,
                                                progressInput.winHR_Animate

                                            });
                                        }

                                        break;
                                    case ProgressBar.IPWin8Ring:

                                        ConstructorInfo ctor_WinRing = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            //typeof(ProgressType),
                                            //typeof(ProgressBar),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(bool)

                                        });

                                        if (ctor_WinRing != null)
                                        {
                                            return new InstanceDescriptor(ctor_WinRing, new object[] {

                                                //progressInput.indicProgType,
                                                //progressInput.win8Ring_Ind,
                                                progressInput.WinRing_control_height,
                                                progressInput.WinRing_indicator_color,
                                                progressInput.WinRing_refresh_rate,
                                                progressInput.winRing_Animate

                                            });
                                        }


                                        break; 
                                    #endregion

                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                                break;

                            default:

                                ConstructorInfo ctor_Empty = typeof(ProgressInput).GetConstructor(Type.EmptyTypes);
                                if (ctor_Empty != null)
                                {
                                    return new InstanceDescriptor(ctor_Empty, null);
                                }

                                break;

                        }

                        #endregion

                        

                    }

                   
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion
    }
}
