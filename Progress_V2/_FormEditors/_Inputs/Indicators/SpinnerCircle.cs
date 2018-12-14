// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SpinnerCircle.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region Private Fields

        // Attributes ========================================================
        /// <summary>
        /// The spinner m is timer active
        /// </summary>
        private bool Spinner_m_IsTimerActive = false;
        /// <summary>
        /// The m number of spoke
        /// </summary>
        private int m_NumberOfSpoke = 250;
        /// <summary>
        /// The m spoke thickness
        /// </summary>
        private int m_SpokeThickness = 4;
        /// <summary>
        /// The m outer circle radius
        /// </summary>
        private int m_OuterCircleRadius = 10;
        /// <summary>
        /// The m inner circle radius
        /// </summary>
        private int m_InnerCircleRadius = 8;
        /// <summary>
        /// The m color
        /// </summary>
        private Color m_Color = Color.DarkGray;
        /// <summary>
        /// The m style preset
        /// </summary>
        private StylePresets m_StylePreset = StylePresets.Custom;
        /// <summary>
        /// The timer interval
        /// </summary>
        private int _Timer_Interval = 100;

        /// <summary>
        /// The spinner start cap
        /// </summary>
        private LineCap Spinner_startCap = LineCap.Round;
        /// <summary>
        /// The spinner end cap
        /// </summary>
        private LineCap Spinner_endCap = LineCap.Round;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the spinner start cap.
        /// </summary>
        /// <value>The spinner start cap.</value>
        public LineCap Spinner_StartCap
        {
            get { return Spinner_startCap; }
            set
            {
                Spinner_startCap = value;
            }
        }

        /// <summary>
        /// Gets or sets the spinner end cap.
        /// </summary>
        /// <value>The spinner end cap.</value>
        public LineCap Spinner_EndCap
        {
            get { return Spinner_endCap; }
            set
            {
                Spinner_endCap = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the spoke.
        /// </summary>
        /// <value>The color of the spoke.</value>
        public Color SpokeColor
        {
            get
            {
                return m_Color;
            }
            set
            {
                m_Color = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the outer circle radius.
        /// </summary>
        /// <value>The outer circle radius.</value>
        public int OuterCircleRadius
        {
            get
            {
                
                return m_OuterCircleRadius;
            }
            set
            {
                m_OuterCircleRadius = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the inner circle radius.
        /// </summary>
        /// <value>The inner circle radius.</value>
        public int InnerCircleRadius
        {
            get
            {
                
                return m_InnerCircleRadius;
            }
            set
            {
                m_InnerCircleRadius = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the number spoke.
        /// </summary>
        /// <value>The number spoke.</value>
        public int NumberSpoke
        {
            get
            {
                
                return m_NumberOfSpoke;
            }
            set
            {
                m_NumberOfSpoke = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [spinner active].
        /// </summary>
        /// <value><c>true</c> if [spinner active]; otherwise, <c>false</c>.</value>
        public bool Spinner_Active
        {
            get
            {
                return Spinner_m_IsTimerActive;
            }
            set
            {
                Spinner_m_IsTimerActive = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the spoke thickness.
        /// </summary>
        /// <value>The spoke thickness.</value>
        public int SpokeThickness
        {
            get
            {
                
                return m_SpokeThickness;
            }
            set
            {
                m_SpokeThickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the rotation speed.
        /// </summary>
        /// <value>The rotation speed.</value>
        public int RotationSpeed
        {
            get
            {
                return _Timer_Interval;
            }
            set
            {

                _Timer_Interval = value;
            }
        }

        /// <summary>
        /// Gets or sets the timer interval.
        /// </summary>
        /// <value>The timer interval.</value>
        public int Timer_Interval
        {
            get
            {
                return _Timer_Interval;
            }
            set
            {
                _Timer_Interval = value;

            }
        }

        /// <summary>
        /// Gets or sets the style preset.
        /// </summary>
        /// <value>The style preset.</value>
        public StylePresets StylePreset
        {
            get { return m_StylePreset; }
            set
            {
                m_StylePreset = value;

                
            }
        }

        #endregion

    }
}
