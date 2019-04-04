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



        #region Bars Constructor

        /// <summary>
        /// Constructor for Extended Bar
        /// </summary>
        /// <param name="m_Edge">The m edge.</param>
        /// <param name="m_EdgeColor">Color of the m edge.</param>
        /// <param name="m_EdgeLightColor">Color of the m edge light.</param>
        /// <param name="m_EdgeWidth">Width of the m edge.</param>
        /// <param name="m_FloodStyle">The m flood style.</param>
        /// <param name="m_float_BarFlood">The m float bar flood.</param>
        /// <param name="m_int_BarOffset">The m int bar offset.</param>
        /// <param name="m_int_DashWidth">Width of the m int dash.</param>
        /// <param name="m_int_DashSpace">The m int dash space.</param>
        /// <param name="m_Style">The m style.</param>
        /// <param name="m_Color1">The m color1.</param>
        /// <param name="m_Color2">The m color2.</param>
        /// <param name="m_color_Back">The m color back.</param>
        /// <param name="m_int_Step">The m int step.</param>
        /// <param name="m_bool_Shadow">if set to <c>true</c> [m bool shadow].</param>
        /// <param name="m_int_ShadowOffset">The m int shadow offset.</param>
        /// <param name="m_bool_Antialias">if set to <c>true</c> [m bool antialias].</param>
        /// <param name="m_color_Shadow">The m color shadow.</param>
        /// <param name="m_color_Caption">The m color caption.</param>
        /// <param name="m_CaptionMode">The m caption mode.</param>
        /// <param name="m_str_Caption">The m string caption.</param>
        /// <param name="m_bool_ChangeByMouse">if set to <c>true</c> [m bool change by mouse].</param>
        /// <param name="m_bool_Invert">if set to <c>true</c> [m bool invert].</param>
        /// <param name="m_Direction">The m direction.</param>
        /// <param name="m_int_Minimum">The m int minimum.</param>
        /// <param name="ExtendedProgress_interval">The extended progress interval.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            ProgressBarEdge m_Edge,
            Color m_EdgeColor,
            Color m_EdgeLightColor,
            int m_EdgeWidth,
            ProgressFloodStyle m_FloodStyle,
            float m_float_BarFlood,
            int m_int_BarOffset,
            int m_int_DashWidth,
            int m_int_DashSpace,
            ProgressStyle m_Style,
            Color m_Color1,
            Color m_Color2,
            Color m_color_Back,
            int m_int_Step,
            bool m_bool_Shadow,
            int m_int_ShadowOffset,
            bool m_bool_Antialias,
            Color m_color_Shadow,
            Color m_color_Caption,
            ProgressCaptionMode m_CaptionMode,
            String m_str_Caption,
            bool m_bool_ChangeByMouse,
            bool m_bool_Invert,
            ProgressBarDirection m_Direction,
            int m_int_Minimum,
            int ExtendedProgress_interval
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPExtendedProgress,
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
            this.m_Edge = m_Edge;
            this.m_EdgeColor = m_EdgeColor;
            this.m_EdgeLightColor = m_EdgeLightColor;
            this.m_EdgeWidth = m_EdgeWidth;
            this.m_FloodStyle = m_FloodStyle;
            this.m_float_BarFlood = m_float_BarFlood;
            this.m_int_BarOffset = m_int_BarOffset;
            this.m_int_DashWidth = m_int_DashWidth;
            this.m_int_DashSpace = m_int_DashSpace;
            this.m_Style = m_Style;
            this.m_Color1 = m_Color1;
            this.m_Color2 = m_Color2;
            this.m_color_Back = m_color_Back;
            this.m_int_Step = m_int_Step;
            this.m_bool_Shadow = m_bool_Shadow;
            this.m_int_ShadowOffset = m_int_ShadowOffset;
            this.m_bool_Antialias = m_bool_Antialias;
            this.m_color_Shadow = m_color_Shadow;
            this.m_color_Caption = m_color_Caption;
            this.m_CaptionMode = m_CaptionMode;
            this.m_str_Caption = m_str_Caption;
            this.m_bool_ChangeByMouse = m_bool_ChangeByMouse;
            this.m_bool_Invert = m_bool_Invert;
            this.m_Direction = m_Direction;
            this.m_int_Minimum = m_int_Minimum;
            this.ExtendedProgress_interval = ExtendedProgress_interval;


        }

        /// <summary>
        /// Constructor for RPIndicator
        /// </summary>
        /// <param name="_GraphWidth">Width of the graph.</param>
        /// <param name="paintColor">Color of the paint.</param>
        /// <param name="penColor">Color of the pen.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            float _GraphWidth,
            Color paintColor,
            Color penColor) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPIndicator,
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
            this._GraphWidth = _GraphWidth;
            this.paintColor = paintColor;
            this.penColor = penColor;
        }

        /// <summary>
        /// Constructor for RPiTunes
        /// </summary>
        /// <param name="clrBarBgLight">The color bar bg light.</param>
        /// <param name="clrBarBgDark">The color bar bg dark.</param>
        /// <param name="clrBarLight">The color bar light.</param>
        /// <param name="clrBarDark">The color bar dark.</param>
        /// <param name="clrBorderColor">Color of the color border.</param>
        /// <param name="fBorderWidth">Width of the f border.</param>
        /// <param name="fMirrorOpacity">The f mirror opacity.</param>
        /// <param name="iNumDividers">The i number dividers.</param>
        /// <param name="iStepSize">Size of the i step.</param>
        /// <param name="eBarType">Type of the e bar.</param>
        /// <param name="fNewProcent">The f new procent.</param>
        /// <param name="bAnimUp">if set to <c>true</c> [b anim up].</param>
        /// <param name="iTunesInterval">The i tunes interval.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color clrBarBgLight,
            Color clrBarBgDark,
            Color clrBarLight,
            Color clrBarDark,
            Color clrBorderColor,
            float fBorderWidth,
            float fMirrorOpacity,
            int iNumDividers,
            float iStepSize,
            BarType eBarType,
            float fNewProcent,
            bool bAnimUp,
            int iTunesInterval

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPiTunes,
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
            this.clrBarBgLight = clrBarBgLight;
            this.clrBarBgDark = clrBarBgDark;
            this.clrBarLight = clrBarLight;
            this.clrBarDark = clrBarDark;
            this.clrBorderColor = clrBorderColor;
            this.fBorderWidth = fBorderWidth;
            this.fMirrorOpacity = fMirrorOpacity;
            this.iNumDividers = iNumDividers;
            this.iStepSize = iStepSize;
            this.eBarType = eBarType;
            this.fNewProcent = fNewProcent;
            this.bAnimUp = bAnimUp;
            this.iTunesInterval = iTunesInterval;
        }

        /// <summary>
        /// Constructor for MazeProgress
        /// </summary>
        /// <param name="Maze_progressStyle">The maze progress style.</param>
        /// <param name="Maze_marqueeAnimationSpeed">The maze marquee animation speed.</param>
        /// <param name="Maze_rowCount">The maze row count.</param>
        /// <param name="Maze_mazeStyle">The maze maze style.</param>
        /// <param name="Maze_gradient">The maze gradient.</param>
        /// <param name="Maze_gradientStartColor">Start color of the maze gradient.</param>
        /// <param name="Maze_gradientEndColor">End color of the maze gradient.</param>
        /// <param name="Maze_wallSize">Size of the maze wall.</param>
        /// <param name="Maze_borderSize">Size of the maze border.</param>
        /// <param name="Maze_borderColor">Color of the maze border.</param>
        /// <param name="Maze_borderGradient">if set to <c>true</c> [maze border gradient].</param>
        /// <param name="Maze_borderRoundCorners">if set to <c>true</c> [maze border round corners].</param>
        /// <param name="Maze_unusedColor">Color of the maze unused.</param>
        /// <param name="maze_solidColor">Color of the maze solid.</param>
        /// <param name="wallColor">Color of the wall.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            ProgressBarStyle Maze_progressStyle,
            float Maze_marqueeAnimationSpeed,
            int Maze_rowCount,
            MazeStyleType Maze_mazeStyle,
            Maze_GradientType Maze_gradient,
            Color Maze_gradientStartColor,
            Color Maze_gradientEndColor,
            int Maze_wallSize,
            int Maze_borderSize,
            Color Maze_borderColor,
            bool Maze_borderGradient,
            bool Maze_borderRoundCorners,
            Color Maze_unusedColor,
            Color maze_solidColor,
            Color wallColor
            //ZeroitThematicProgress.RPMaze maze,
            //int Maze_marqueePosition,
            //int Maze_marqueeLength,
            //Color[] Maze_gradientColors,
            //Color[] Maze_borderColors,
            //int Maze_rowPixels,
            //int Maze_unusedRowPixels,
            //int Maze_unusedTopPixels,
            //int Maze_unusedBottomPixels,
            //int Maze_colPixels,
            //int Maze_unusedColPixels,
            //int Maze_unusedLeftPixels,
            //int Maze_unusedRightPixels,
            //int Maze_innerWidth,
            //int Maze_innerHeight,

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPMaze,
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
            this.Maze_progressStyle = Maze_progressStyle;
            this.Maze_marqueeAnimationSpeed = Maze_marqueeAnimationSpeed;
            this.Maze_rowCount = Maze_rowCount;
            this.Maze_mazeStyle = Maze_mazeStyle;
            this.Maze_gradient = Maze_gradient;
            this.Maze_gradientStartColor = Maze_gradientStartColor;
            this.Maze_gradientEndColor = Maze_gradientEndColor;
            this.Maze_wallSize = Maze_wallSize;
            this.Maze_borderSize = Maze_borderSize;
            this.Maze_borderColor = Maze_borderColor;
            this.Maze_borderGradient = Maze_borderGradient;
            this.Maze_borderRoundCorners = Maze_borderRoundCorners;
            this.Maze_unusedColor = Maze_unusedColor;
            this.maze_solidColor = maze_solidColor;
            this.wallColor = wallColor;
            //this.maze = maze;
            //this.Maze_marqueePosition = Maze_marqueePosition;
            //this.Maze_marqueeLength = Maze_marqueeLength;
            //this.Maze_gradientColors = Maze_gradientColors;
            //this.Maze_borderColors = Maze_borderColors;
            //this.Maze_rowPixels = Maze_rowPixels;
            //this.Maze_unusedRowPixels = Maze_unusedRowPixels;
            //this.Maze_unusedTopPixels = Maze_unusedTopPixels;
            //this.Maze_unusedBottomPixels = Maze_unusedBottomPixels;
            //this.Maze_colPixels = Maze_colPixels;
            //this.Maze_unusedColPixels = Maze_unusedColPixels;
            //this.Maze_unusedLeftPixels = Maze_unusedLeftPixels;
            //this.Maze_unusedRightPixels = Maze_unusedRightPixels;
            //this.Maze_innerWidth = Maze_innerWidth;
            //this.Maze_innerHeight = Maze_innerHeight;


        }

        /// <summary>
        /// Constructor for Antonio - Normal
        /// </summary>
        /// <param name="_progressNormalType">Type of the progress normal.</param>
        /// <param name="ProgressBarNormal_step">The progress bar normal step.</param>
        /// <param name="_TextColorType">Type of the text color.</param>
        /// <param name="_TextAlign">The text align.</param>
        /// <param name="_DisplayProgress">if set to <c>true</c> [display progress].</param>
        /// <param name="_ColorProgress">The color progress.</param>
        /// <param name="_BorderType">Type of the border.</param>
        /// <param name="ProgressBarNormal_borderColor">Color of the progress bar normal border.</param>
        /// <param name="_RollBlockPercent">The roll block percent.</param>
        /// <param name="_RollingType">Type of the rolling.</param>
        /// <param name="antonioInterval">The antonio interval.</param>
        public ProgressInput(

            //ProgressType progressType,
            //ProgressBar solidBars,
            ZeroitThematicProgress.progressNormalType _progressNormalType,
            int ProgressBarNormal_step,
            ZeroitThematicProgress.TextColorTypes _TextColorType,
            ZeroitThematicProgress.TextAlignmentTypes _TextAlign,
            bool _DisplayProgress,
            Color _ColorProgress,
            ZeroitThematicProgress.BorderTypes _BorderType,
            Color ProgressBarNormal_borderColor,
            int _RollBlockPercent,
            ZeroitThematicProgress.RollingTypes _RollingType,
            int antonioInterval
            //bool _TurnOffInvalidation,
            //int _iPercent,
            //float _fPercent,

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPProgNormal,
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
            this._progressNormalType = _progressNormalType;
            this.ProgressBarNormal_step = ProgressBarNormal_step;
            //this._TurnOffInvalidation = _TurnOffInvalidation;
            //this._iPercent = _iPercent;
            //this._fPercent = _fPercent;
            this._TextColorType = _TextColorType;
            this._TextAlign = _TextAlign;
            this._DisplayProgress = _DisplayProgress;
            this._ColorProgress = _ColorProgress;
            this._BorderType = _BorderType;
            this.ProgressBarNormal_borderColor = ProgressBarNormal_borderColor;
            this._RollBlockPercent = _RollBlockPercent;
            this._RollingType = _RollingType;
            this.antonioInterval = antonioInterval;
        }

        /// <summary>
        /// Constructor for RPAlter Progress
        /// </summary>
        /// <param name="colorBack">The color back.</param>
        /// <param name="colorBorder">The color border.</param>
        /// <param name="colorText">The color text.</param>
        /// <param name="colorInside">The color inside.</param>
        /// <param name="colorIC">The color ic.</param>
        /// <param name="color1">The color1.</param>
        /// <param name="color2">The color2.</param>
        /// <param name="colorAngle">The color angle.</param>
        /// <param name="_ShowValue">if set to <c>true</c> [show value].</param>
        /// <param name="_Orientation">The orientation.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color colorBack,
            Color colorBorder,
            Color colorText,
            Color colorInside,
            Color colorIC,
            Color color1,
            Color color2,
            float colorAngle,
            bool _ShowValue,
            Orientation _Orientation

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPAlter,
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
            this.colorBack = colorBack;
            this.colorBorder = colorBorder;
            this.colorText = colorText;
            this.colorInside = colorInside;
            this.colorIC = colorIC;
            this.color1 = color1;
            this.color2 = color2;
            this.colorAngle = colorAngle;
            this._ShowValue = _ShowValue;
            this._Orientation = _Orientation;
        }

        /// <summary>
        /// Constructor for RPClear Progress
        /// </summary>
        /// <param name="ProgressBarClear_glow">The progress bar clear glow.</param>
        /// <param name="ProgressBarClear_edge">The progress bar clear edge.</param>
        /// <param name="ProgressBarClear_gradient1">The progress bar clear gradient1.</param>
        /// <param name="ProgressBarClear_gradient2">The progress bar clear gradient2.</param>
        /// <param name="_coloringMode">The coloring mode.</param>
        public ProgressInput(

            //ProgressType progressType,
            //ProgressBar solidBars,
            Color ProgressBarClear_glow,
            Color ProgressBarClear_edge,
            Color ProgressBarClear_gradient1,
            Color ProgressBarClear_gradient2,
            ZeroitThematicProgress.coloringMode _coloringMode
            //int GlowPosition

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPClear,
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
            this.ProgressBarClear_glow = ProgressBarClear_glow;
            this.ProgressBarClear_edge = ProgressBarClear_edge;
            this.ProgressBarClear_gradient1 = ProgressBarClear_gradient1;
            this.ProgressBarClear_gradient2 = ProgressBarClear_gradient2;
            this._coloringMode = _coloringMode;
            //this.GlowPosition = GlowPosition;
        }

        /// <summary>
        /// Constructor for RPPerplex Progressbar
        /// </summary>
        /// <param name="Perplex_colorGradient1">The perplex color gradient1.</param>
        /// <param name="Perplex_colorGradient2">The perplex color gradient2.</param>
        /// <param name="Perplex_colorGradient3">The perplex color gradient3.</param>
        /// <param name="Perplex_colorGradient4">The perplex color gradient4.</param>
        /// <param name="colorPen">The color pen.</param>
        /// <param name="colorGradientAngle">The color gradient angle.</param>
        /// <param name="_ShowPercentage">if set to <c>true</c> [show percentage].</param>
        /// <param name="_perplex_DrawMode">The perplex draw mode.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Color Perplex_colorGradient1,
            Color Perplex_colorGradient2,
            Color Perplex_colorGradient3,
            Color Perplex_colorGradient4,
            Color colorPen,
            float colorGradientAngle,
            bool _ShowPercentage,
            ZeroitThematicProgress.perplex_DrawMode _perplex_DrawMode

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPPerplex,
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
            this.Perplex_colorGradient1 = Perplex_colorGradient1;
            this.Perplex_colorGradient2 = Perplex_colorGradient2;
            this.Perplex_colorGradient3 = Perplex_colorGradient3;
            this.Perplex_colorGradient4 = Perplex_colorGradient4;
            this.colorPen = colorPen;
            this.colorGradientAngle = colorGradientAngle;
            this._ShowPercentage = _ShowPercentage;
            this._perplex_DrawMode = _perplex_DrawMode;

        }

        /// <summary>
        /// Constructor for RectBar
        /// </summary>
        /// <param name="ProgressRect_valueColour">The progress rect value colour.</param>
        /// <param name="ProgressRect_colorBackground">The progress rect color background.</param>
        /// <param name="ProgressRect_colorBorder">The progress rect color border.</param>
        /// <param name="ProgressRect_corner">The progress rect corner.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            //float ProgressRect_percent,
            Color ProgressRect_valueColour,
            Color ProgressRect_colorBackground,
            Color ProgressRect_colorBorder,
            int ProgressRect_corner

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPRect,
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
            //this.ProgressRect_percent = ProgressRect_percent;
            this.ProgressRect_valueColour = ProgressRect_valueColour;
            this.ProgressRect_colorBackground = ProgressRect_colorBackground;
            this.ProgressRect_colorBorder = ProgressRect_colorBorder;
            this.ProgressRect_corner = ProgressRect_corner;
        }

        /// <summary>
        /// Constructor for RPTransparent ProgressBar
        /// </summary>
        /// <param name="_ShowText">The show text.</param>
        /// <param name="_ProgressBackground">The progress background.</param>
        /// <param name="Trns_progressColor1">The TRNS progress color1.</param>
        /// <param name="Trns_progressColor2">The TRNS progress color2.</param>
        public ProgressInput(
            //ProgressType progressType,
            //ProgressBar solidBars,
            Boolean _ShowText,
            Color _ProgressBackground,
            Color Trns_progressColor1,
            Color Trns_progressColor2

            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPTransparent,
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
            this._ShowText = _ShowText;
            this._ProgressBackground = _ProgressBackground;
            this.Trns_progressColor1 = Trns_progressColor1;
            this.Trns_progressColor2 = Trns_progressColor2;
        }

        /// <summary>
        /// Constructor for RPSplitter Progressbar
        /// </summary>
        /// <param name="m_ProgressBarBlockWidth">Width of the m progress bar block.</param>
        /// <param name="m_ProgressBarBlockSpace">The m progress bar block space.</param>
        /// <param name="m_ProgressBarPercent">if set to <c>true</c> [m progress bar percent].</param>
        /// <param name="m_ProgressBarMarginOffset">if set to <c>true</c> [m progress bar margin offset].</param>
        /// <param name="m_ProgressBarBorderStyle">The m progress bar border style.</param>
        /// <param name="m_ProgressBarFillBrush_Color">Color of the m progress bar fill brush.</param>
        public ProgressInput(

            //ProgressType progressType,
            //ProgressBar solidBars,
            int m_ProgressBarBlockWidth,
            int m_ProgressBarBlockSpace,
            bool m_ProgressBarPercent,
            bool m_ProgressBarMarginOffset,
            TProgressBarBorderStyle m_ProgressBarBorderStyle,
            Color m_ProgressBarFillBrush_Color
            ) : this(
            //ProgressType.Bar,
            //CircularProgress.SupremeCircle,
            ProgressBar.RPSplitter,
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
            this.m_ProgressBarBlockWidth = m_ProgressBarBlockWidth;
            this.m_ProgressBarBlockSpace = m_ProgressBarBlockSpace;
            this.m_ProgressBarPercent = m_ProgressBarPercent;
            this.m_ProgressBarMarginOffset = m_ProgressBarMarginOffset;
            this.m_ProgressBarBorderStyle = m_ProgressBarBorderStyle;
            this.m_ProgressBarFillBrush_Color = m_ProgressBarFillBrush_Color;

        }

        #endregion

    }
}
