using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {
        #region Converter

        internal class ProgressInputConverter : TypeConverter
        {

            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor) || destinationType == typeof(string))
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                if (value is ProgressInput)
                {
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(ProgressInput)";
                    }

                    else if (destinationType == typeof(InstanceDescriptor))
                    {
                        ProgressInput progressInput = (ProgressInput)value;
                        
                        if (progressInput.ProgressType == ProgressType.Bar)
                        {
                            if (progressInput.SolidProgressBar == ProgressBar.ExtendedProgress)
                            {
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            typeof(ProgressType),
                                            typeof(ProgressBar),
                                            typeof(ProgressFloodStyle),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(ProgressStyle),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color)

                                        });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.barType,
                                                progressInput.extendedBar,
                                                progressInput.m_FloodStyle,
                                                progressInput.m_float_BarFlood,
                                                progressInput.m_int_BarOffset,
                                                progressInput.m_int_DashWidth,
                                                progressInput.m_int_DashSpace,
                                                progressInput.m_Style,
                                                progressInput.m_Color1,
                                                progressInput.m_Color2,
                                                progressInput.m_color_Back


                                            });
                                }

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.ZeroitIndicator)
                            {
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                    typeof(ProgressType),
                                    typeof(ProgressBar),
                                    typeof(float),
                                    typeof(Color),
                                    typeof(Color),


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                        progressInput.barType,
                                        progressInput.indicatorBar,
                                        progressInput._GraphWidth,
                                        progressInput.paintColor,
                                        progressInput.penColor

                                    });

                                }

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.iTunes)
                            {
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            typeof(ProgressType),
                                            typeof(ProgressBar),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                                progressInput.barType,
                                                progressInput.iTunesBar,
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

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.Maze)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            typeof(ProgressType),
                                            typeof(ProgressBar),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                                progressInput.barType,
                                                progressInput.mazeBar,
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

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.ProgressNormal)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                            typeof(ProgressType),
                                            typeof(ProgressBar),
                                            typeof(ThematicProgress.progressNormalType),
                                            typeof(int),
                                            typeof(ThematicProgress.TextColorTypes),
                                            typeof(ThematicProgress.TextAlignmentTypes),
                                            typeof(bool),
                                            typeof(Color),
                                            typeof(ThematicProgress.BorderTypes),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(ThematicProgress.RollingTypes),
                                            typeof(int)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                                progressInput.barType,
                                                progressInput.antonioNormalBar,
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

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.Alter)
                            {
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                        {

                                            typeof(ProgressType),
                                            typeof(ProgressBar),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                                progressInput.barType,
                                                progressInput.alterBar,
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

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.Clear)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                    typeof(ProgressType),
                                    typeof(ProgressBar),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(ThematicProgress.coloringMode)
                                    //typeof(int)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                        progressInput.barType,
                                        progressInput.clearBar,
                                        progressInput.ProgressBarClear_glow,
                                        progressInput.ProgressBarClear_edge,
                                        progressInput.ProgressBarClear_gradient1,
                                        progressInput.ProgressBarClear_gradient2,
                                        progressInput._coloringMode
                                        //progressInput.GlowPosition

                                    });

                                }

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.Perplex)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                            typeof(ProgressType),
                                            typeof(ProgressBar),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(ThematicProgress.perplex_DrawMode)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                                progressInput.barType,
                                                progressInput.perplexBar,
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

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.ProgressRect)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                    typeof(ProgressType),
                                    typeof(ProgressBar),
                                    //typeof(float),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(int)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                        progressInput.barType,
                                        progressInput.rectBar,
                                        //progressInput.ProgressRect_percent,
                                        progressInput.ProgressRect_valueColour,
                                        progressInput.ProgressRect_colorBackground,
                                        progressInput.ProgressRect_colorBorder,
                                        progressInput.ProgressRect_corner

                                    });

                                }

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.Transparent)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                    typeof(ProgressType),
                                    typeof(ProgressBar),
                                    typeof(Boolean),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                        progressInput.barType,
                                        progressInput.transparentBar,
                                        progressInput._ShowText,
                                        progressInput._ProgressBackground,
                                        progressInput.Trns_progressColor1,
                                        progressInput.Trns_progressColor2

                                    });

                                }

                            }

                            else if (progressInput.SolidProgressBar == ProgressBar.Splitter)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {

                                    typeof(ProgressType),
                                    typeof(ProgressBar),
                                    typeof(int),
                                    typeof(int),
                                    typeof(bool),
                                    typeof(bool),
                                    typeof(TProgressBarBorderStyle),
                                    typeof(Color)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[]
                                    {

                                        progressInput.barType,
                                        progressInput.splitterBar,
                                        progressInput.m_ProgressBarBlockWidth,
                                        progressInput.m_ProgressBarBlockSpace,
                                        progressInput.m_ProgressBarPercent,
                                        progressInput.m_ProgressBarMarginOffset,
                                        progressInput.m_ProgressBarBorderStyle,
                                        progressInput.m_ProgressBarFillBrush_Color,


                                    });

                                }


                            }

                        }

                        else if (progressInput.ProgressType == ProgressType.Circular)
                        {
                            if (progressInput.CircularProgressBar == CircularProgress.ZeroitProgressBarCircular)
                            {
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ThematicProgress._ProgressShape),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(Double),
                                            typeof(float),
                                            typeof(bool),
                                            typeof(bool)

                                        });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.circularType,
                                                progressInput.circularProgressBar,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.CircularProgressv2)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(CircularProgress),
                                    typeof(int),
                                    typeof(int),
                                    typeof(int),
                                    typeof(int),
                                    typeof(bool),
                                    typeof(Color),
                                    typeof(Color)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                        progressInput.circularType,
                                        progressInput.circularProgressV2,
                                        progressInput.CPv2_progressWidth,
                                        progressInput.CPv2_shift,
                                        progressInput.CPv2_remainderAngle,
                                        progressInput.CPv2_startAngle,
                                        progressInput.CPv2_showText,
                                        progressInput.CPv2_progressColor,
                                        progressInput.CPv2_progressEmptyColor,


                                    });
                                }

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.CircularProgressv3)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(CircularProgress),
                                    typeof(int),
                                    typeof(int),
                                    typeof(int),
                                    typeof(int),
                                    typeof(bool),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(bool)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                        progressInput.circularType,
                                        progressInput.circularProgressV3,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.CircularProgressv4)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularProgressV4,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.CircularProgressv5)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            //typeof(Size),
                                            typeof(Size),
                                            //typeof(int),
                                            typeof(BarData[]),
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
                                            typeof(bool)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularProgressV5,
                                                //progressInput.minimumSizeAllowed,
                                                progressInput._minimumSize,
                                                //progressInput._barCount,
                                                progressInput._bars,
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
                                                progressInput._imageEnabled,
                                            });
                                }

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.GorgeousProgress)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color[]),
                                            typeof(Color[]),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(ThematicProgress.Gorgeous_rotatingAngle)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularGorgeous,
                                                progressInput.Gorgeous_enableInnerCover,
                                                progressInput.Gorgeous_outerShift,
                                                progressInput.Gorgeous_innerShift,
                                                progressInput.Gorgeous_innerCoverShift,
                                                progressInput.Gorgeous_smallRectShift,
                                                progressInput.Gorgeous_gradientColors,
                                                progressInput.Gorgeous_solidcolors,
                                                progressInput.Gorgeous_border,
                                                progressInput.Gorgeous_showText,
                                                progressInput._rotatingAngle

                                            });
                                }

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.Ignito)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(float),
                                            typeof(float),
                                            typeof(Color[]),
                                            typeof(bool),
                                            typeof(LineCap),
                                            typeof(ThematicProgress.Ignito_innerRotatingAngle),
                                            typeof(ThematicProgress.Ignito_outterRotatingAngle),
                                            typeof(ThematicProgress.Ignito_drawMode),
                                            typeof(DashStyle),
                                            typeof(DashStyle)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularIgnito,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.MulitCo)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(CircularProgress),
                                    typeof(bool),
                                    typeof(int),
                                    typeof(int),
                                    typeof(int),
                                    typeof(int),
                                    typeof(Rings),
                                    typeof(Color[])

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                        progressInput.circularType,
                                        progressInput.circularMultiCo,
                                        progressInput.MC_showInnerBorder,
                                        progressInput.MC_innerBorder,
                                        progressInput.MC_shift,
                                        progressInput.MC_correctShift,
                                        progressInput.MC_rectShift,
                                        progressInput.MC_noOfRings,
                                        progressInput.MC_colors

                                    });
                                }

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.MultiCoExtended)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Rings),
                                            typeof(Color[]),
                                            typeof(Color)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularMultiCoExt,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.MultiCoV1)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularMultiCoExtV1,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.Awesome)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(float),
                                            typeof(string),
                                            typeof(Font),
                                            typeof(string),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(int),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularAwesome,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.Perfect)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularPerfect,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.ProgressPie)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(ThematicProgress.ProgressPie_ProgressShape),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(Double),
                                            typeof(float),
                                            //typeof(float),
                                            typeof(bool),
                                            typeof(float),
                                            typeof(float)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularProgressPie,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.RotatingArc)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(float),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(ThematicProgress.PieArc),
                                            typeof(ThematicProgress.RotatingArc_drawMode),
                                            typeof(ThematicProgress.shape),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularArc,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.RotatingCompass)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(CircularProgress),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(int),
                                    typeof(bool),
                                    typeof(float)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                        progressInput.circularType,
                                        progressInput.circularCompass,
                                        progressInput.pieColor1,
                                        progressInput.pieColor2,
                                        progressInput.lineColor1,
                                        progressInput.lineColor2,
                                        progressInput.size,
                                        progressInput.rotatingBorder,
                                        progressInput.angle

                                    });
                                }

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.SupremeCircle)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(CircularProgress),
                                            typeof(ThematicProgress.Supreme_colorMode),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color),
                                            typeof(Color[]),
                                            typeof(LinearGradientMode),
                                            typeof(float),
                                            typeof(int),
                                            typeof(int)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                                progressInput.circularType,
                                                progressInput.circularSupreme,
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

                            }

                            else if (progressInput.CircularProgressBar == CircularProgress.ZeroitProgressBarCircularDefault)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(CircularProgress),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(ThematicProgress._ProgressShape),


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                        progressInput.circularType,
                                        progressInput.circularProgressBarDefault,
                                        progressInput.CircularDef_ProgressColor1,
                                        progressInput.CircularDef_ProgressColor2,
                                        progressInput.CircularDef_InnerColor1,
                                        progressInput.CircularDef_InnerColor2,
                                        progressInput.CircularDef_ProgressShapeVal

                                    });
                                }

                            }
                            

                        }

                        else if (progressInput.ProgressType == ProgressType.Indicator)
                        {

                            if (progressInput.ProgressIndicator == ProgressIndicator.CircularIndeterminate)
                            {
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                        {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(float),
                                            typeof(float),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(ThematicProgress.INDICATORTYPES),
                                            typeof(int),
                                            typeof(bool)

                                        });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.indeterminate_Ind,
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

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.GoogleProgressIndicator)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
                                            typeof(Color),
                                            //typeof(int),
                                            typeof(Color),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(ThematicProgress.GoogleProgress_INDICATORTYPES),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.google_Ind,
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

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.MacOSX)
                            {
                                
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
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
                                            typeof(ThematicProgress.MacOSX_Direction),


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.macOsX_Ind,
                                                progressInput.MacOSX_m_Interval,
                                                progressInput.MacOSX_m_InnerRadius,
                                                progressInput.MacOSX_m_OuterRadius,
                                                progressInput.MacOSX_m_StartAngle,
                                                progressInput.MacOSX_m_AlphaStartValue,
                                                progressInput.MacOSX_m_SpokesCount,
                                                progressInput.MacOSX_m_AngleIncrement,
                                                progressInput.MacOSX_m_AlphaDecrement,
                                                progressInput.MacOSX_startCap,
                                                progressInput.MacOSX_endCap,
                                                progressInput._automatic,
                                                progressInput.tick_Color,
                                                progressInput.macOSX_Rotation

                                            });
                                }


                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.MacOSXOptimized)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
                                            typeof(int),
                                            typeof(float),
                                            typeof(float),
                                            typeof(int),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(MacOSX_automatic),
                                            typeof(ThematicProgress.MacOSX_Direction),
                                            typeof(Color)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.macOsXOpt_Ind,
                                                progressInput.MacOSX_Optimized_m_Interval,
                                                progressInput.MacOSX_Optimized_m_StartAngle,
                                                progressInput.MacOSX_Optimized_m_AngleIncrement,
                                                progressInput.MacOSX_Optimized_m_SpokesCount,
                                                progressInput.MacOSX_Optimized_startCap,
                                                progressInput.MacOSX_Optimized_endCap,
                                                progressInput._automatic,
                                                progressInput.MacOSX_Optimized_m_Rotation,
                                                progressInput.macOSX_Optimized_tick_Color

                                            });
                                }

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.Matrix)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
                                            typeof(int),
                                            typeof(float),
                                            typeof(int),
                                            typeof(LineCap),
                                            typeof(LineCap),
                                            typeof(MacOSX_automatic),
                                            typeof(ThematicProgress.MacOSX_Direction),
                                            typeof(Color)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.matrix_Ind,
                                                progressInput.MacOSX_Matrix_m_Interval,
                                                progressInput.MacOSX_Matrix_m_StartAngle,
                                                progressInput.MacOSX_Matrix_m_SpokesCount,
                                                progressInput.MacOSX_Matrix_startCap,
                                                progressInput.MacOSX_Matrix_endCap,
                                                progressInput._automatic,
                                                progressInput.MacOSX_Matrix_m_Rotation,
                                                progressInput.matrix_tick_Color


                                            });
                                }

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.IndicatorV1)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(ProgressIndicator),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(float),
                                    typeof(double),
                                    typeof(float)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                        progressInput.indicProgType,
                                        progressInput.indicatorV1_Ind,
                                        progressInput.baseColor,
                                        progressInput.animationColor,
                                        progressInput._visibleCircles,
                                        progressInput._radian,
                                        progressInput._circleWidth


                                    });
                                }

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.Unique)
                            {
                                
                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.unique_Ind,
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
                                
                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.Vuvuzela)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
                                            typeof(float),
                                            typeof(int),
                                            typeof(bool),
                                            typeof(ThematicProgress.Vuvuzela_Shape),
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

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.vuvuzela_Ind,
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

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.SpinnerCircle)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                            typeof(ProgressType),
                                            typeof(ProgressIndicator),
                                            typeof(bool),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(int),
                                            typeof(Color),
                                            typeof(ThematicProgress.StylePresets),
                                            typeof(int)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                                progressInput.indicProgType,
                                                progressInput.spinnerCirc_Ind,
                                                progressInput.Spinner_m_IsTimerActive,
                                                progressInput.m_NumberOfSpoke,
                                                progressInput.m_SpokeThickness,
                                                progressInput.m_OuterCircleRadius,
                                                progressInput.m_InnerCircleRadius,
                                                progressInput.m_Color,
                                                progressInput.m_StylePreset,
                                                progressInput._Timer_Interval


                                            });
                                }

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.SpinnerDivided)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(ProgressIndicator),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(Color),
                                    typeof(bool),
                                    typeof(double),
                                    typeof(bool),
                                    typeof(int)


                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {


                                        progressInput.indicProgType,
                                        progressInput.spinnerDivided_Ind,
                                        progressInput.m_InactiveColour,
                                        progressInput.m_ActiveColour,
                                        progressInput.m_TransistionColour,
                                        progressInput.m_AutoIncrement,
                                        progressInput.m_IncrementFrequency,
                                        progressInput.m_BehindIsActive,
                                        progressInput.m_TransitionSegment

                                    });
                                }

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.Win8Horizontal)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(ProgressIndicator),
                                    typeof(int),
                                    typeof(Color),
                                    typeof(int),
                                    typeof(double),
                                    typeof(bool)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                        progressInput.indicProgType,
                                        progressInput.win8Horiz_Ind,
                                        progressInput.control_width,
                                        progressInput.WinHR_indicator_color,
                                        progressInput.WinHR_refresh_rate,
                                        progressInput.timer_interval,
                                        progressInput.winHR_Animate

                                    });
                                }

                            }

                            else if (progressInput.ProgressIndicator == ProgressIndicator.Win8Ring)
                            {

                                ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(new Type[]
                                {
                                    typeof(ProgressType),
                                    typeof(ProgressIndicator),
                                    typeof(int),
                                    typeof(Color),
                                    typeof(int),
                                    typeof(bool)

                                });

                                if (ctor != null)
                                {
                                    return new InstanceDescriptor(ctor, new object[] {

                                        progressInput.indicProgType,
                                        progressInput.win8Ring_Ind,
                                        progressInput.WinRing_control_height,
                                        progressInput.WinRing_indicator_color,
                                        progressInput.WinRing_refresh_rate,
                                        progressInput.winRing_Animate

                                    });
                                }

                            }
                            

                        }

                        else
                        {
                            ConstructorInfo ctor = typeof(ProgressInput).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }

                        #region Switch Code

                        //switch (progressInput.ProgressType)
                        //{
                        //    case ProgressType.Bar:

                        //        switch (progressInput.SolidProgressBar)
                        //        {
                        //            case ProgressBar.ExtendedProgress:

                        //                ConstructorInfo ctor_bars_Extended = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(ProgressFloodStyle),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(ProgressStyle),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color)

                        //                });
                        //                if (ctor_bars_Extended != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Extended, new object[] {


                        //                        progressInput.barType,
                        //                        progressInput.extendedBar,
                        //                        progressInput.m_FloodStyle,
                        //                        progressInput.m_float_BarFlood,
                        //                        progressInput.m_int_BarOffset,
                        //                        progressInput.m_int_DashWidth,
                        //                        progressInput.m_int_DashSpace,
                        //                        progressInput.m_Style,
                        //                        progressInput.m_Color1,
                        //                        progressInput.m_Color2,
                        //                        progressInput.m_color_Back


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressBar.ZeroitIndicator:

                        //                ConstructorInfo ctor_bars_Indicator = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(float),
                        //                    typeof(Color),
                        //                    typeof(Color),


                        //                });
                        //                if (ctor_bars_Indicator != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Indicator, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.indicatorBar,
                        //                        progressInput._GraphWidth,
                        //                        progressInput.paintColor,
                        //                        progressInput.penColor

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.iTunes:

                        //                ConstructorInfo ctor_bars_iTunes = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(float),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(float),
                        //                    typeof(BarType),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(int),


                        //                });
                        //                if (ctor_bars_iTunes != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_iTunes, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.iTunesBar,
                        //                        progressInput.clrBarBgLight,
                        //                        progressInput.clrBarBgDark,
                        //                        progressInput.clrBarLight,
                        //                        progressInput.clrBarDark,
                        //                        progressInput.clrBorderColor,
                        //                        progressInput.fBorderWidth,
                        //                        progressInput.fMirrorOpacity,
                        //                        progressInput.iNumDividers,
                        //                        progressInput.iStepSize,
                        //                        progressInput.eBarType,
                        //                        progressInput.fNewProcent,
                        //                        progressInput.bAnimUp,
                        //                        progressInput.iTunesInterval,

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.Maze:

                        //                ConstructorInfo ctor_bars_Maze = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(ProgressBarStyle),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(MazeStyleType),
                        //                    typeof(Maze_GradientType),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color)


                        //                });
                        //                if (ctor_bars_Maze != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Maze, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.mazeBar,
                        //                        progressInput.Maze_progressStyle,
                        //                        progressInput.Maze_marqueeAnimationSpeed,
                        //                        progressInput.Maze_rowCount,
                        //                        progressInput.Maze_mazeStyle,
                        //                        progressInput.Maze_gradient,
                        //                        progressInput.Maze_gradientStartColor,
                        //                        progressInput.Maze_gradientEndColor,
                        //                        progressInput.Maze_wallSize,
                        //                        progressInput.Maze_borderSize,
                        //                        progressInput.Maze_borderColor,
                        //                        progressInput.Maze_borderGradient,
                        //                        progressInput.Maze_borderRoundCorners,
                        //                        progressInput.Maze_unusedColor,
                        //                        progressInput.maze_solidColor,
                        //                        progressInput.wallColor

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.ProgressNormal:

                        //                ConstructorInfo ctor_bars_Normal = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(ThematicProgress.progressNormalType),
                        //                    typeof(int),
                        //                    typeof(ThematicProgress.TextColorTypes),
                        //                    typeof(ThematicProgress.TextAlignmentTypes),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress.BorderTypes),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(ThematicProgress.RollingTypes),
                        //                    typeof(int)


                        //                });
                        //                if (ctor_bars_Normal != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Normal, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.antonioNormalBar,
                        //                        progressInput._progressNormalType,
                        //                        progressInput.ProgressBarNormal_step,
                        //                        progressInput._TextColorType,
                        //                        progressInput._TextAlign,
                        //                        progressInput._DisplayProgress,
                        //                        progressInput._ColorProgress,
                        //                        progressInput._BorderType,
                        //                        progressInput.ProgressBarNormal_borderColor,
                        //                        progressInput._RollBlockPercent,
                        //                        progressInput._RollingType,
                        //                        progressInput.antonioInterval

                        //                    });

                        //                }

                        //                break;
                        //            //case ProgressBar.ProgressBoxed:

                        //            //    break;
                        //            //case ProgressBar.ProgressGradient:
                        //            //    break;
                        //            case ProgressBar.Alter:

                        //                ConstructorInfo ctor_bars_Alter = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(Orientation)


                        //                });
                        //                if (ctor_bars_Alter != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Alter, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.alterBar,
                        //                        progressInput.colorBack,
                        //                        progressInput.colorBorder,
                        //                        progressInput.colorText,
                        //                        progressInput.colorInside,
                        //                        progressInput.colorIC,
                        //                        progressInput.color1,
                        //                        progressInput.color2,
                        //                        progressInput.colorAngle,
                        //                        progressInput._ShowValue,
                        //                        progressInput._Orientation

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.Clear:

                        //                ConstructorInfo ctor_bars_Clear = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress.coloringMode)
                        //                    //typeof(int)


                        //                });
                        //                if (ctor_bars_Clear != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Clear, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.clearBar,
                        //                        progressInput.ProgressBarClear_glow,
                        //                        progressInput.ProgressBarClear_edge,
                        //                        progressInput.ProgressBarClear_gradient1,
                        //                        progressInput.ProgressBarClear_gradient2,
                        //                        progressInput._coloringMode
                        //                        //progressInput.GlowPosition

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.ProgressRect:

                        //                ConstructorInfo ctor_bars_Rect = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    //typeof(float),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int)


                        //                });
                        //                if (ctor_bars_Rect != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Rect, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.rectBar,
                        //                        //progressInput.ProgressRect_percent,
                        //                        progressInput.ProgressRect_valueColour,
                        //                        progressInput.ProgressRect_colorBackground,
                        //                        progressInput.ProgressRect_colorBorder,
                        //                        progressInput.ProgressRect_corner

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.Perplex:

                        //                ConstructorInfo ctor_bars_Perplex = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(ThematicProgress.perplex_DrawMode)


                        //                });
                        //                if (ctor_bars_Perplex != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Perplex, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.perplexBar,
                        //                        progressInput.Perplex_colorGradient1,
                        //                        progressInput.Perplex_colorGradient2,
                        //                        progressInput.Perplex_colorGradient3,
                        //                        progressInput.Perplex_colorGradient4,
                        //                        progressInput.colorPen,
                        //                        progressInput.colorGradientAngle,
                        //                        progressInput._ShowPercentage,
                        //                        progressInput._perplex_DrawMode

                        //                    });

                        //                }

                        //                break;
                        //            case ProgressBar.Transparent:

                        //                ConstructorInfo ctor_bars_Transparent = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(Boolean),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color)

                        //                });
                        //                if (ctor_bars_Transparent != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Transparent, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.transparentBar,
                        //                        progressInput._ShowText,
                        //                        progressInput._ProgressBackground,
                        //                        progressInput.Trns_progressColor1,
                        //                        progressInput.Trns_progressColor2

                        //                    });

                        //                }


                        //                break;
                        //            case ProgressBar.Splitter:

                        //                ConstructorInfo ctor_bars_Splitter = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {

                        //                    typeof(ProgressType),
                        //                    typeof(ProgressBar),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(TProgressBarBorderStyle),
                        //                    typeof(Color)

                        //                });
                        //                if (ctor_bars_Splitter != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_bars_Splitter, new object[]
                        //                    {

                        //                        progressInput.barType,
                        //                        progressInput.splitterBar,
                        //                        progressInput.m_ProgressBarBlockWidth,
                        //                        progressInput.m_ProgressBarBlockSpace,
                        //                        progressInput.m_ProgressBarPercent,
                        //                        progressInput.m_ProgressBarMarginOffset,
                        //                        progressInput.m_ProgressBarBorderStyle,
                        //                        progressInput.m_ProgressBarFillBrush_Color,


                        //                    });

                        //                }


                        //                break;
                        //            default:
                        //                throw new ArgumentOutOfRangeException();
                        //        }

                        //        break;
                        //    case ProgressType.Circular:

                        //        switch (progressInput.CircularProgressType)
                        //        {
                        //            case CircularProgress.ZeroitProgressBarCircular:

                        //                ConstructorInfo ctor_circular_Circular = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress._ProgressShape),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(Double),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(bool)

                        //                });
                        //                if (ctor_circular_Circular != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Circular, new object[] {


                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressBar,
                        //                        progressInput._ProgressColor1,
                        //                        progressInput._ProgressColor2,
                        //                        progressInput._FillEllipse1,
                        //                        progressInput._FillEllipse2,
                        //                        progressInput._TextColor,
                        //                        progressInput._ProgressColorInnerBorder,
                        //                        progressInput.ProgressShapeVal,
                        //                        progressInput._Start,
                        //                        progressInput._End,
                        //                        progressInput._ProgressWidth,
                        //                        progressInput._PenWidth,
                        //                        progressInput._showText,
                        //                        progressInput.zeroitProgressBarCircular_transparency


                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.CircularProgressv2:

                        //                ConstructorInfo ctor_circular_ProgressV2 = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(Color)

                        //                });
                        //                if (ctor_circular_ProgressV2 != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_ProgressV2, new object[] {


                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressV2,
                        //                        progressInput.CPv2_progressWidth,
                        //                        progressInput.CPv2_shift,
                        //                        progressInput.CPv2_remainderAngle,
                        //                        progressInput.CPv2_startAngle,
                        //                        progressInput.CPv2_showText,
                        //                        progressInput.CPv2_progressColor,
                        //                        progressInput.CPv2_progressEmptyColor,


                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.CircularProgressv3:

                        //                ConstructorInfo ctor_circular_ProgressV3 = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(bool)

                        //                });
                        //                if (ctor_circular_ProgressV3 != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_ProgressV3, new object[] {


                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressV3,
                        //                        progressInput.CPv3_progressWidth,
                        //                        progressInput.CPv3_shift,
                        //                        progressInput.CPv3_remainderAngle,
                        //                        progressInput.CPv3_startangle,
                        //                        progressInput.CPv3_showText,
                        //                        progressInput.CPv3_progressColor,
                        //                        progressInput.CPv3_progressEmptyColor,
                        //                        progressInput.dummyBool

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.CircularProgressv4:

                        //                ConstructorInfo ctor_circular_ProgressV4 = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(float),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int)

                        //                });
                        //                if (ctor_circular_ProgressV4 != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_ProgressV4, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressV4,
                        //                        progressInput.CPv4_startAngle,
                        //                        progressInput.CPv4_thickness,
                        //                        progressInput.CPv4_gradAngle,
                        //                        progressInput.CPv4_startCap,
                        //                        progressInput.CPv4_endCap,
                        //                        progressInput.CPv4_innerBorder,
                        //                        progressInput.CPv4_outerBorder,
                        //                        progressInput.CPv4_progGrad1,
                        //                        progressInput.CPv4_progGrad2,
                        //                        progressInput.CPv4_progBackGrad1,
                        //                        progressInput.CPv4_progBackGrad2,
                        //                        progressInput.CPv4_speed,

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.CircularProgressv5:

                        //                ConstructorInfo ctor_circular_ProgressV5 = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    //typeof(Size),
                        //                    typeof(Size),
                        //                    //typeof(int),
                        //                    typeof(BarData[]),
                        //                    typeof(bool),
                        //                    //typeof(Image),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(string),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(bool)

                        //                });
                        //                if (ctor_circular_ProgressV5 != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_ProgressV5, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressV5,
                        //                        //progressInput.minimumSizeAllowed,
                        //                        progressInput._minimumSize,
                        //                        //progressInput._barCount,
                        //                        progressInput._bars,
                        //                        progressInput._borderEnabled,
                        //                        //progressInput._image,
                        //                        progressInput._barSeperation,
                        //                        progressInput._barWidth,
                        //                        progressInput._displayPercentage,
                        //                        progressInput._displayTotalPercentage,
                        //                        progressInput._smoothBars,
                        //                        progressInput._info,
                        //                        progressInput._textShadow,
                        //                        progressInput._textShadowColor,
                        //                        progressInput._inactiveColorEnabled,
                        //                        progressInput.CPv5_marqueeAngle,
                        //                        progressInput.CPv5_marquee,
                        //                        progressInput.CPv5_marqueeinterval,
                        //                        progressInput.CPv5_interval,
                        //                        progressInput.otherinterval,
                        //                        progressInput.CPv5_reset,
                        //                        progressInput._imageEnabled,
                        //                    });
                        //                }

                        //                break;
                        //            //case CircularProgress.CircularProgressv5aClock:
                        //            //    break;
                        //            case CircularProgress.GorgeousProgress:

                        //                ConstructorInfo ctor_circular_Gorgeous = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Color[]),
                        //                    typeof(Color[]),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(ThematicProgress.Gorgeous_rotatingAngle)

                        //                });
                        //                if (ctor_circular_Gorgeous != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Gorgeous, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularGorgeous,
                        //                        progressInput.Gorgeous_enableInnerCover,
                        //                        progressInput.Gorgeous_outerShift,
                        //                        progressInput.Gorgeous_innerShift,
                        //                        progressInput.Gorgeous_innerCoverShift,
                        //                        progressInput.Gorgeous_smallRectShift,
                        //                        progressInput.Gorgeous_gradientColors,
                        //                        progressInput.Gorgeous_solidcolors,
                        //                        progressInput.Gorgeous_border,
                        //                        progressInput.Gorgeous_showText,
                        //                        progressInput._rotatingAngle

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.Ignito:

                        //                ConstructorInfo ctor_circular_Ignito = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(float),
                        //                    typeof(float),
                        //                    typeof(Color[]),
                        //                    typeof(bool),
                        //                    typeof(LineCap),
                        //                    typeof(ThematicProgress.Ignito_innerRotatingAngle),
                        //                    typeof(ThematicProgress.Ignito_outterRotatingAngle),
                        //                    typeof(ThematicProgress.Ignito_drawMode),
                        //                    typeof(DashStyle),
                        //                    typeof(DashStyle)

                        //                });
                        //                if (ctor_circular_Ignito != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Ignito, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularIgnito,
                        //                        progressInput.Ignito_outerborder,
                        //                        progressInput.Ignito_innerborder,
                        //                        progressInput.Ignito_colors,
                        //                        progressInput.Ignito_enableHatch,
                        //                        progressInput.Ignito_cap,
                        //                        progressInput.Ignito_innerRotaAngle,
                        //                        progressInput.Ignito_outterRotaAngle,
                        //                        progressInput.ignito_drawMode,
                        //                        progressInput.Ignito_borderStyleouter,
                        //                        progressInput.Ignito_borderStyleInner

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.MulitCo:

                        //                ConstructorInfo ctor_circular_MulitCo = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Rings),
                        //                    typeof(Color[])

                        //                });

                        //                if (ctor_circular_MulitCo != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_MulitCo, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularMultiCo,
                        //                        progressInput.MC_showInnerBorder,
                        //                        progressInput.MC_innerBorder,
                        //                        progressInput.MC_shift,
                        //                        progressInput.MC_correctShift,
                        //                        progressInput.MC_rectShift,
                        //                        progressInput.MC_noOfRings,
                        //                        progressInput.MC_colors

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.MultiCoExtended:

                        //                ConstructorInfo ctor_circular_MulitCoExt = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Rings),
                        //                    typeof(Color[]),
                        //                    typeof(Color)

                        //                });

                        //                if (ctor_circular_MulitCoExt != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_MulitCoExt, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularMultiCoExt,
                        //                        progressInput.MCEx_showInnerBorder,
                        //                        progressInput.MCEx_innerBorder,
                        //                        progressInput.MCEx_shift,
                        //                        progressInput.MCEx_correctShift,
                        //                        progressInput.MCEx_rectShift,
                        //                        progressInput.MCEx_noOfRings,
                        //                        progressInput.MCEx_colors,
                        //                        progressInput.MCEx_innerBorderColor

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.MultiCoV1:

                        //                ConstructorInfo ctor_circular_MulitCoExtV1 = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(DashStyle),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(drawMode),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Rings),
                        //                    typeof(Color),
                        //                    typeof(Color[]),
                        //                    typeof(Color[]),
                        //                    typeof(Color[]),
                        //                    typeof(Color[]),
                        //                    typeof(Color),


                        //                });

                        //                if (ctor_circular_MulitCoExtV1 != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_MulitCoExtV1, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularMultiCoExtV1,
                        //                        progressInput.MCExV2_outerBorderStart,
                        //                        progressInput.MCExV2_outerBorderEnd,
                        //                        progressInput.MCExV2_outerBorderStyle,
                        //                        progressInput.MCExV2_gradientAngle,
                        //                        progressInput.MCExV2_outerborder,
                        //                        progressInput.MCExV2_rotatingborder,
                        //                        progressInput.MCExV2_divisions,
                        //                        progressInput.MCExV2_divisionsWidth,
                        //                        progressInput.MCExV2_drawMode,
                        //                        progressInput.MCExV2_showInnerBorder,
                        //                        progressInput.MCExV2_innerBorder,
                        //                        progressInput.MCExV2_shift,
                        //                        progressInput.MCExV2_correctShift,
                        //                        progressInput.MCExV2_rectShift,
                        //                        progressInput.MCExV2_noOfRings,
                        //                        progressInput.MCExV2_innerHoleColor,
                        //                        progressInput.MCExV2_innerHoleGradColor,
                        //                        progressInput.MCExV2_linColors0,
                        //                        progressInput.MCExV2_linColors1,
                        //                        progressInput.MCExV2_colors,
                        //                        progressInput.MCExV2_innerBorderColor


                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.Awesome:

                        //                ConstructorInfo ctor_circular_Awesome = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(float),
                        //                    typeof(string),
                        //                    typeof(Font),
                        //                    typeof(string),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Padding),
                        //                    typeof(Padding),
                        //                    typeof(Padding),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(ProgressBarStyle)
                        //                    //typeof(AnimationFunctions.Function),
                        //                    //typeof(KnownAnimationFunctions),


                        //                });

                        //                if (ctor_circular_Awesome != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Awesome, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularAwesome,
                        //                        progressInput.ProgressAwesome_marqueeAnimationSpeed,
                        //                        progressInput.ProgressAwesome_superscriptText,
                        //                        progressInput.ProgressAwesome_secondaryFont,
                        //                        progressInput.ProgressAwesome_subscriptText,
                        //                        progressInput.ProgressAwesome_superscriptColor,
                        //                        progressInput.ProgressAwesome_subscriptColor,
                        //                        progressInput.ProgressAwesome_startAngle,
                        //                        progressInput.ProgressAwesome_subscriptMargin,
                        //                        progressInput.ProgressAwesome_superscriptMargin,
                        //                        progressInput.ProgressAwesome_textMargin,
                        //                        progressInput.ProgressAwesome_animationSpeed,
                        //                        progressInput.ProgressAwesome_outerMargin,
                        //                        progressInput.ProgressAwesome_outerWidth,
                        //                        progressInput.ProgressAwesome_outerColor,
                        //                        progressInput.ProgressAwesome_progressWidth,
                        //                        progressInput.ProgressAwesome_progressColor,
                        //                        progressInput.ProgressAwesome_innerMargin,
                        //                        progressInput.ProgressAwesome_innerWidth,
                        //                        progressInput.ProgressAwesome_innerColor,
                        //                        progressInput.ProgressAwesome_style
                        //                        //progressInput.ProgressAwesome_animationFunction,
                        //                        //progressInput.ProgressAwesome_knownAnimationFunction

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.Perfect:

                        //                ConstructorInfo ctor_circular_Perfect = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    //typeof(bool),
                        //                    typeof(float),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(RotationType1),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(TextDisplayModes1)

                        //                });

                        //                if (ctor_circular_Perfect != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Perfect, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularPerfect,
                        //                        progressInput.ProgressPerfect_interval,
                        //                        progressInput.ProgressPerfect_circleColor,
                        //                        //progressInput._stopped,
                        //                        progressInput.ProgressPerfect_circleSize,
                        //                        progressInput._numberOfCircles,
                        //                        progressInput._numberOfVisibleCircles,
                        //                        progressInput.ProgressPerfect_rotation,
                        //                        progressInput.ProgressPerfect_percentage,
                        //                        progressInput.ProgressPerfect_showPercentage,
                        //                        progressInput.ProgressBarPerfect_showText,
                        //                        progressInput.ProgressPerfect_textDisplay
                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.ProgressPie:

                        //                ConstructorInfo ctor_circular_ProgressPie = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress.ProgressPie_ProgressShape),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(Double),
                        //                    typeof(float),
                        //                    //typeof(float),
                        //                    typeof(bool),
                        //                    typeof(float),
                        //                    typeof(float)

                        //                });

                        //                if (ctor_circular_ProgressPie != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_ProgressPie, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressPie,
                        //                        progressInput.ProgressPie_progressColor1,
                        //                        progressInput.ProgressPie_progressColor2,
                        //                        progressInput.ProgressPie_fillEllipse1,
                        //                        progressInput.ProgressPie_fillEllipse2,
                        //                        progressInput.ProgressPie_textColor,
                        //                        progressInput.ProgressPie_progressColorInnerBorder,
                        //                        progressInput.ProgressPie_progressShapeVal,
                        //                        progressInput.ProgressPie_start,
                        //                        progressInput.ProgressPie_end,
                        //                        progressInput.ProgressPie_progressWidth,
                        //                        progressInput.ProgressPie_penWidth,
                        //                        //progressInput.ProgressPie_progressWidthToFloat,
                        //                        progressInput.ProgressPie_showText,
                        //                        progressInput.ProgressPie_position,
                        //                        progressInput.ProgressPie_sweepAngle
                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.RotatingArc:

                        //                ConstructorInfo ctor_circular_RotatingArc = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(ThematicProgress.PieArc),
                        //                    typeof(ThematicProgress.RotatingArc_drawMode),
                        //                    typeof(ThematicProgress.shape),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(bool),


                        //                });

                        //                if (ctor_circular_RotatingArc != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_RotatingArc, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularArc,
                        //                        progressInput.angle,
                        //                        progressInput.interval,
                        //                        progressInput.rotatingBorder,
                        //                        progressInput.pieArc,
                        //                        progressInput.RotatingArc_drawmode,
                        //                        progressInput._shape,
                        //                        progressInput.size,
                        //                        progressInput.customHeartFade,
                        //                        progressInput.pieColor1,
                        //                        progressInput.pieColor2,
                        //                        progressInput.lineColor1,
                        //                        progressInput.lineColor2,
                        //                        progressInput.lineWidthColor,
                        //                        progressInput.fillPie,
                        //                        progressInput.drawLine,
                        //                        progressInput.colorOuterBorder,
                        //                        progressInput.innerCircle1Grad1,
                        //                        progressInput.innerCircle1Grad2,
                        //                        progressInput.innerCircle2Grad1,
                        //                        progressInput.innerCircle2Grad2,
                        //                        progressInput.innerCircle3Grad1,
                        //                        progressInput.innerCircle3Grad2,
                        //                        progressInput.innerCircle4Grad1,
                        //                        progressInput.innerCircle4Grad2,
                        //                        progressInput.innerCircle5Grad1,
                        //                        progressInput.innerCircle5Grad2,
                        //                        progressInput.innerCircle6Grad1,
                        //                        progressInput.innerCircle6Grad2,
                        //                        progressInput.showInnerCircle1,
                        //                        progressInput.showInnerCircle2,
                        //                        progressInput.showInnerCircle3,
                        //                        progressInput.showInnerCircle4,
                        //                        progressInput.showInnerCircle5,
                        //                        progressInput.showInnerCircle6,
                        //                        progressInput.outerBorderWidth,
                        //                        progressInput.innercircleBorder,
                        //                        progressInput.widthReduction,
                        //                        progressInput.heightReduction,
                        //                        progressInput.innercircle2Width,
                        //                        progressInput.innercircle2Height,
                        //                        progressInput.innercircle3Width,
                        //                        progressInput.innercircle3Height,
                        //                        progressInput.innercircle4Width,
                        //                        progressInput.innercircle4Height,
                        //                        progressInput.innercircle5Width,
                        //                        progressInput.innercircle5Height,
                        //                        progressInput.innercircle6Width,
                        //                        progressInput.innercircle6Height,
                        //                        progressInput.heartinterval,
                        //                        progressInput.heartAutoAnimate

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.RotatingCompass:

                        //                ConstructorInfo ctor_circular_Compass = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(float)

                        //                });

                        //                if (ctor_circular_Compass != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Compass, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularCompass,
                        //                        progressInput.pieColor1,
                        //                        progressInput.pieColor2,
                        //                        progressInput.lineColor1,
                        //                        progressInput.lineColor2,
                        //                        progressInput.size,
                        //                        progressInput.rotatingBorder,
                        //                        progressInput.angle

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.SupremeCircle:

                        //                ConstructorInfo ctor_circular_Supreme = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(ThematicProgress.Supreme_colorMode),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color[]),
                        //                    typeof(LinearGradientMode),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(int)

                        //                });

                        //                if (ctor_circular_Supreme != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_Supreme, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularSupreme,
                        //                        progressInput.SP_colorMode,
                        //                        progressInput.progressColor,
                        //                        progressInput.outerColor,
                        //                        progressInput.solidColor,
                        //                        progressInput.gradientColor,
                        //                        progressInput.linMode,
                        //                        progressInput.SP_angle,
                        //                        progressInput.outerborder,
                        //                        progressInput.innerborder

                        //                    });
                        //                }

                        //                break;
                        //            case CircularProgress.ZeroitProgressBarCircularDefault:

                        //                ConstructorInfo ctor_circular_CircularDefault = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(CircularProgress),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress._ProgressShape),


                        //                });

                        //                if (ctor_circular_CircularDefault != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_circular_CircularDefault, new object[] {

                        //                        progressInput.circularType,
                        //                        progressInput.circularProgressBarDefault,
                        //                        progressInput.CircularDef_ProgressColor1,
                        //                        progressInput.CircularDef_ProgressColor2,
                        //                        progressInput.CircularDef_InnerColor1,
                        //                        progressInput.CircularDef_InnerColor2,
                        //                        progressInput.CircularDef_ProgressShapeVal

                        //                    });
                        //                }

                        //                break;
                        //            default:
                        //                throw new ArgumentOutOfRangeException();
                        //        }

                        //        break;
                        //    case ProgressType.Indicator:

                        //        switch (progressInput.ProgressIndicator)
                        //        {
                        //            case ProgressIndicator.CircularIndeterminate:

                        //                ConstructorInfo ctor_indicator_Indeterminate = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(float),
                        //                    typeof(float),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(ThematicProgress.INDICATORTYPES),
                        //                    typeof(int),
                        //                    typeof(bool)

                        //                });
                        //                if (ctor_indicator_Indeterminate != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Indeterminate, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.indeterminate_Ind,
                        //                        progressInput.background_color,
                        //                        progressInput.circles_count,
                        //                        progressInput.control_color,
                        //                        progressInput.control_width_height,
                        //                        progressInput.indicator_angle,
                        //                        progressInput.indicator_angular_advance,
                        //                        progressInput.indicator_color,
                        //                        progressInput.indicator_diameter,
                        //                        progressInput.indicator_type,
                        //                        progressInput.refresh_rate,
                        //                        progressInput.indeterminate_Animate,


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.GoogleProgressIndicator:

                        //                ConstructorInfo ctor_indicator_Google = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(Color),
                        //                    //typeof(int),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress.GoogleProgress_INDICATORTYPES),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(float),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int),

                        //                });

                        //                if (ctor_indicator_Google != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Google, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.google_Ind,
                        //                        progressInput.GoogleProgress_annulus_color,
                        //                        //progressInput.GoogleProgress_annulus_thickness,
                        //                        progressInput.GoogleProgress_background_color,
                        //                        progressInput.GoogleProgress_indicator_angle,
                        //                        progressInput.GoogleProgress_indicator_angular_advance,
                        //                        progressInput.GoogleProgress_indicator_color,
                        //                        progressInput.GoogleProgress_indicator_type,
                        //                        progressInput.inner_radius,
                        //                        progressInput.outer_radius,
                        //                        progressInput.GoogleProgress_refresh_rate,
                        //                        progressInput.GoogleProgress_angle,
                        //                        progressInput.transition_color,
                        //                        progressInput.color1bigcircle,
                        //                        progressInput.color2bigcircle,
                        //                        progressInput.color1indicator,
                        //                        progressInput.color2indicator,
                        //                        progressInput.inner_color,
                        //                        progressInput.inner_border,


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.MacOSX:

                        //                ConstructorInfo ctor_indicator_MacOSX = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(MacOSX_automatic),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress.MacOSX_Direction),


                        //                });

                        //                if (ctor_indicator_MacOSX != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_MacOSX, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.macOsX_Ind,
                        //                        progressInput.MacOSX_m_Interval,
                        //                        progressInput.MacOSX_m_InnerRadius,
                        //                        progressInput.MacOSX_m_OuterRadius,
                        //                        progressInput.MacOSX_m_StartAngle,
                        //                        progressInput.MacOSX_m_AlphaStartValue,
                        //                        progressInput.MacOSX_m_SpokesCount,
                        //                        progressInput.MacOSX_m_AngleIncrement,
                        //                        progressInput.MacOSX_m_AlphaDecrement,
                        //                        progressInput.MacOSX_startCap,
                        //                        progressInput.MacOSX_endCap,
                        //                        progressInput._automatic,
                        //                        progressInput.tick_Color,
                        //                        progressInput.macOSX_Rotation

                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.MacOSXOptimized:

                        //                ConstructorInfo ctor_indicator_MacOSXOptimized = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(int),
                        //                    typeof(float),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(MacOSX_automatic),
                        //                    typeof(ThematicProgress.MacOSX_Direction),
                        //                    typeof(Color)


                        //                });

                        //                if (ctor_indicator_MacOSXOptimized != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_MacOSXOptimized, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.macOsXOpt_Ind,
                        //                        progressInput.MacOSX_Optimized_m_Interval,
                        //                        progressInput.MacOSX_Optimized_m_StartAngle,
                        //                        progressInput.MacOSX_Optimized_m_AngleIncrement,
                        //                        progressInput.MacOSX_Optimized_m_SpokesCount,
                        //                        progressInput.MacOSX_Optimized_startCap,
                        //                        progressInput.MacOSX_Optimized_endCap,
                        //                        progressInput._automatic,
                        //                        progressInput.MacOSX_Optimized_m_Rotation,
                        //                        progressInput.macOSX_Optimized_tick_Color

                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.Matrix:

                        //                ConstructorInfo ctor_indicator_Matrix = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(int),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(LineCap),
                        //                    typeof(LineCap),
                        //                    typeof(MacOSX_automatic),
                        //                    typeof(ThematicProgress.MacOSX_Direction),
                        //                    typeof(Color)


                        //                });

                        //                if (ctor_indicator_Matrix != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Matrix, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.matrix_Ind,
                        //                        progressInput.MacOSX_Matrix_m_Interval,
                        //                        progressInput.MacOSX_Matrix_m_StartAngle,
                        //                        progressInput.MacOSX_Matrix_m_SpokesCount,
                        //                        progressInput.MacOSX_Matrix_startCap,
                        //                        progressInput.MacOSX_Matrix_endCap,
                        //                        progressInput._automatic,
                        //                        progressInput.MacOSX_Matrix_m_Rotation,
                        //                        progressInput.matrix_tick_Color


                        //                    });
                        //                }


                        //                break;
                        //            case ProgressIndicator.IndicatorV1:

                        //                ConstructorInfo ctor_indicator_IndicatorV1 = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(float),
                        //                    typeof(double),
                        //                    typeof(float)


                        //                });

                        //                if (ctor_indicator_IndicatorV1 != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_IndicatorV1, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.indicatorV1_Ind,
                        //                        progressInput.baseColor,
                        //                        progressInput.animationColor,
                        //                        progressInput._visibleCircles,
                        //                        progressInput._radian,
                        //                        progressInput._circleWidth


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.Unique:

                        //                ConstructorInfo ctor_indicator_Unique = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Unique_RotationType),
                        //                    typeof(float),
                        //                    typeof(bool),
                        //                    typeof(bool),
                        //                    typeof(Unique_TextDisplayModes)



                        //                });

                        //                if (ctor_indicator_Unique != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Unique, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.unique_Ind,
                        //                        progressInput.Unique_interval,
                        //                        progressInput.Unique_circleColor,
                        //                        progressInput.Unique_circleSize,
                        //                        progressInput.Unique_numberOfCircles,
                        //                        progressInput.Unique_numberOfVisibleCircles,
                        //                        progressInput.Unique_rotation,
                        //                        progressInput.Unique_percentage,
                        //                        progressInput.Unique_showPercentage,
                        //                        progressInput.Unique_showText,
                        //                        progressInput.Unique_textDisplay,


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.Vuvuzela:

                        //                ConstructorInfo ctor_indicator_Vuvuzela = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(float),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(ThematicProgress.Vuvuzela_Shape),
                        //                    typeof(int),
                        //                    typeof(bool),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(int)




                        //                });

                        //                if (ctor_indicator_Vuvuzela != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Vuvuzela, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.vuvuzela_Ind,
                        //                        progressInput.Vuvuzela_angle,
                        //                        progressInput.Vuvuzela_interval,
                        //                        progressInput.Vuvuzela_rotatingBorder,
                        //                        progressInput.Vuvuzela_shape,
                        //                        progressInput.Vuvuzela_size,
                        //                        progressInput.Vuvuzela_fillPie,
                        //                        progressInput.Vuvuzela_rotatingCircle,
                        //                        progressInput.Vuvuzela_circle1,
                        //                        progressInput.Vuvuzela_circle2,
                        //                        progressInput.Vuvuzela_circle3,
                        //                        progressInput.Vuvuzela_circle4,
                        //                        progressInput.Vuvuzela_circle5,
                        //                        progressInput.Vuvuzela_circleSize


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.SpinnerCircle:

                        //                ConstructorInfo ctor_indicator_SpinnerCirc = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(bool),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(ThematicProgress.StylePresets),
                        //                    typeof(int)


                        //                });

                        //                if (ctor_indicator_SpinnerCirc != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_SpinnerCirc, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.spinnerCirc_Ind,
                        //                        progressInput.Spinner_m_IsTimerActive,
                        //                        progressInput.m_NumberOfSpoke,
                        //                        progressInput.m_SpokeThickness,
                        //                        progressInput.m_OuterCircleRadius,
                        //                        progressInput.m_InnerCircleRadius,
                        //                        progressInput.m_Color,
                        //                        progressInput.m_StylePreset,
                        //                        progressInput._Timer_Interval


                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.SpinnerDivided:

                        //                ConstructorInfo ctor_indicator_SpinnerDiv = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(Color),
                        //                    typeof(bool),
                        //                    typeof(double),
                        //                    typeof(bool),
                        //                    typeof(int)


                        //                });

                        //                if (ctor_indicator_SpinnerDiv != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_SpinnerDiv, new object[] {


                        //                        progressInput.indicProgType,
                        //                        progressInput.spinnerDivided_Ind,
                        //                        progressInput.m_InactiveColour,
                        //                        progressInput.m_ActiveColour,
                        //                        progressInput.m_TransistionColour,
                        //                        progressInput.m_AutoIncrement,
                        //                        progressInput.m_IncrementFrequency,
                        //                        progressInput.m_BehindIsActive,
                        //                        progressInput.m_TransitionSegment

                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.Win8Horizontal:

                        //                ConstructorInfo ctor_indicator_Win8Hori = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(double),
                        //                    typeof(bool)

                        //                });

                        //                if (ctor_indicator_Win8Hori != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Win8Hori, new object[] {

                        //                        progressInput.indicProgType,
                        //                        progressInput.win8Horiz_Ind,
                        //                        progressInput.control_width,
                        //                        progressInput.WinHR_indicator_color,
                        //                        progressInput.WinHR_refresh_rate,
                        //                        progressInput.timer_interval,
                        //                        progressInput.winHR_Animate

                        //                    });
                        //                }

                        //                break;
                        //            case ProgressIndicator.Win8Ring:

                        //                ConstructorInfo ctor_indicator_Win8Ring = typeof(ProgressInput).GetConstructor(new Type[]
                        //                {
                        //                    typeof(ProgressType),
                        //                    typeof(ProgressIndicator),
                        //                    typeof(int),
                        //                    typeof(Color),
                        //                    typeof(int),
                        //                    typeof(bool)

                        //                });

                        //                if (ctor_indicator_Win8Ring != null)
                        //                {
                        //                    return new InstanceDescriptor(ctor_indicator_Win8Ring, new object[] {

                        //                        progressInput.indicProgType,
                        //                        progressInput.win8Ring_Ind,
                        //                        progressInput.WinRing_control_height,
                        //                        progressInput.WinRing_indicator_color,
                        //                        progressInput.WinRing_refresh_rate,
                        //                        progressInput.winRing_Animate

                        //                    });
                        //                }

                        //                break;
                        //            default:
                        //                throw new ArgumentOutOfRangeException();
                        //        }

                        //        break;
                        //    default:
                        //        ConstructorInfo ctorEmpty = typeof(ProgressInput).GetConstructor(Type.EmptyTypes);
                        //        if (ctorEmpty != null)
                        //        {
                        //            return new InstanceDescriptor(ctorEmpty, null);
                        //        }
                        //        break;
                        //}

                        #endregion

                    }
                    
                }

                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion
    }
}
