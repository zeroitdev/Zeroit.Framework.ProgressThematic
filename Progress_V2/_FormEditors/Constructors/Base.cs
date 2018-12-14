// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressInput.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        /// <summary>
        /// Main Constructor
        /// </summary>
        /// <param name="solidBars">The solid bars.</param>
        /// <param name="smoothing">The smoothing.</param>
        /// <param name="textrendering">The textrendering.</param>
        /// <param name="easingType">Type of the easing.</param>
        /// <param name="transparencyEasingType">Type of the transparency easing.</param>
        /// <param name="hatchBrushType">Type of the hatch brush.</param>
        /// <param name="autoAnimate">if set to <c>true</c> [automatic animate].</param>
        /// <param name="autoIncrement">if set to <c>true</c> [automatic increment].</param>
        /// <param name="autoAnimateStatingAngle">if set to <c>true</c> [automatic animate stating angle].</param>
        /// <param name="showText">if set to <c>true</c> [show text].</param>
        /// <param name="fixedSize">if set to <c>true</c> [fixed size].</param>
        /// <param name="postFix">The post fix.</param>
        /// <param name="hatchBrushgradient1">The hatch brushgradient1.</param>
        /// <param name="hatchBrushgradient2">The hatch brushgradient2.</param>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="speed2">The speed2.</param>
        /// <param name="speed0">The speed0.</param>
        /// <param name="speed1">The speed1.</param>
        /// <param name="startingAngle">The starting angle.</param>
        public ProgressInput(
            //ProgressType progressType,
            ProgressBar solidBars,
            //ProgressBar solidBars,
            ////ProgressBar solidBars,
            SmoothingMode smoothing,
            TextRenderingHint textrendering,
            PeaceAnimatorEasing easingType,
            transparencyEasingType transparencyEasingType,
            ZeroitThematicProgress.HatchBrushType hatchBrushType,
            bool autoAnimate,
            bool autoIncrement,
            bool autoAnimateStatingAngle,
            bool showText,
            bool fixedSize,
            string postFix,
            Color hatchBrushgradient1,
            Color hatchBrushgradient2,
            float minimum,
            float maximum,
            int speed2,
            int speed0,
            int speed1,
            float startingAngle

            )
        {
            //this.progressType = progressType;
            this.solidBars = solidBars;
            //this.solidBars = solidBars;
            ////this.solidBars = solidBars;
            this.smoothing = smoothing;
            this.textrendering = textrendering;
            this.easingType = easingType;
            this.transparencyEasingType = transparencyEasingType;
            this.hatchBrushType = hatchBrushType;
            this.autoAnimate = autoAnimate;
            this.autoIncrement = autoIncrement;
            this.autoAnimateStatingAngle = autoAnimateStatingAngle;
            this.showText = showText;
            this.fixedSize = fixedSize;
            this.postFix = postFix;
            this.hatchBrushgradient1 = hatchBrushgradient1;
            this.hatchBrushgradient2 = hatchBrushgradient2;
            this.minimum = minimum;
            this.maximum = maximum;
            this.speed[2] = speed2;
            this.speed[0] = speed0;
            this.speed[1] = speed1;
            this.startingAngle = startingAngle;

        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public ProgressInput() : this(
            //ProgressType.Bar,
            //CircularProgress.Ignito,
            ProgressBar.RPExtendedProgress,
            ////ProgressIndicator.CircularIndeterminate,
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
            
        }

        

        #endregion
        
    }
}
