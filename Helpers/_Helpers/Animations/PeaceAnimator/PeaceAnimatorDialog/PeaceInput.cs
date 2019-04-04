﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="PeaceInput.cs" company="Zeroit Dev Technologies">
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
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation;



namespace Zeroit.Framework.ProgressThematic.AnimationHelpers.AnimationEditors
{
    /// <summary>
    /// 	Class representing Peace Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator Values.
    /// </summary>
    /// <summary>
    /// Class PeaceInput.
    /// </summary>
    [TypeConverter(typeof(PeaceInputConverter))]
    [EditorAttribute(typeof(PeaceInputEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public partial class PeaceInput
    {

        #region Private Fields

        /// <summary>
        /// The animation mode
        /// </summary>
        public animationMode _animationMode = animationMode.OneD;

        //private readonly animationMode oneD_Mode = animationMode.OneD;
        //private readonly animationMode twoD_Mode = animationMode.TwoD;
        //private readonly animationMode threeD_Mode = animationMode.ThreeD;
        //private readonly animationMode default_Mode = animationMode.Default;


        /// <summary>
        /// The alpha
        /// </summary>
        public int alpha = 10;
        /// <summary>
        /// The repeat
        /// </summary>
        public bool repeat = false;
        /// <summary>
        /// The reverse
        /// </summary>
        public bool reverse = false;

        /// <summary>
        /// The path1 start
        /// </summary>
        public float path1_start = 0;
        /// <summary>
        /// The path1 end
        /// </summary>
        public float path1_end = 100;
        /// <summary>
        /// The path1 duration
        /// </summary>
        public ulong path1_duration = 5000;
        /// <summary>
        /// The path1 delay
        /// </summary>
        public ulong path1_delay = 0;
        /// <summary>
        /// The path2 d start 1
        /// </summary>
        public float path2D_start_1 = 70;
        /// <summary>
        /// The path2 d end 1
        /// </summary>
        public float path2D_end_1 = 320;
        /// <summary>
        /// The path2 d duration 1
        /// </summary>
        public ulong path2D_duration_1 = 2000;
        /// <summary>
        /// The path2 d delay 1
        /// </summary>
        public ulong path2D_delay_1 = 0;

        /// <summary>
        /// The path2 d start 2
        /// </summary>
        public float path2D_start_2 = 5;
        /// <summary>
        /// The path2 d end 2
        /// </summary>
        public float path2D_end_2 = 100;
        /// <summary>
        /// The path2 d duration 2
        /// </summary>
        public ulong path2D_duration_2 = 2000;
        /// <summary>
        /// The path2 d delay 2
        /// </summary>
        public ulong path2D_delay_2 = 0;

        /// <summary>
        /// The continued path2 d start 1
        /// </summary>
        public float continued_path2D_start_1 = 320;
        /// <summary>
        /// The continued path2 d end 1
        /// </summary>
        public float continued_path2D_end_1 = 70;
        /// <summary>
        /// The continued path2 d duration 1
        /// </summary>
        public ulong continued_path2D_duration_1 = 2000;
        /// <summary>
        /// The continued path2 d delay 1
        /// </summary>
        public ulong continued_path2D_delay_1 = 300;

        /// <summary>
        /// The continued path2 d start 2
        /// </summary>
        public float continued_path2D_start_2 = 100;
        /// <summary>
        /// The continued path2 d end 2
        /// </summary>
        public float continued_path2D_end_2 = 5;
        /// <summary>
        /// The continued path2 d duration 2
        /// </summary>
        public ulong continued_path2D_duration_2 = 1700;
        /// <summary>
        /// The continued path2 d delay 2
        /// </summary>
        public ulong continued_path2D_delay_2 = 600;

        /// <summary>
        /// The path3 d start 1
        /// </summary>
        public float path3D_start_1 = 70;
        /// <summary>
        /// The path3 d end 1
        /// </summary>
        public float path3D_end_1 = 320;
        /// <summary>
        /// The path3 duration
        /// </summary>
        public ulong path3_duration = 3000;
        /// <summary>
        /// The path3 delay
        /// </summary>
        public ulong path3_delay = 0;



        //private Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator _animator /*= new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator()*/;
        //private Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D _animator2D = new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D();
        //private Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D _animator3D = new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D();


        /// <summary>
        /// The one d property
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties oneDProperty = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value;
        /// <summary>
        /// The two d property
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties twoDProperty = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties.Location;
        /// <summary>
        /// The three d property
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties threeDProperty = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties.BackColor;

        /// <summary>
        /// The one d path easing function
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions oneD_path_easingFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;

        /// <summary>
        /// The three d path easing function
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions threeD_path_easingFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;

        /// <summary>
        /// The path easing function
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions path_easingFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
        //private Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions path2_easingFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseOut;

        /// <summary>
        /// The continued path easing function
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions continued_path_easingFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
        //private Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions continued_path2_easingFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.Liner;

        /// <summary>
        /// The one d continue
        /// </summary>
        public bool oneDContinue = true;
        /// <summary>
        /// The two d continue
        /// </summary>
        public bool twoDContinue = true;
        /// <summary>
        /// The three d continue
        /// </summary>
        public bool threeDContinue = true;



        /// <summary>
        /// The start color
        /// </summary>
        public Color startColor = Color.DarkSlateGray;
        /// <summary>
        /// The end color
        /// </summary>
        public Color endColor = Color.Orange;

        /// <summary>
        /// The property name
        /// </summary>
        public string propertyName = "Value";
        /// <summary>
        /// The color property name
        /// </summary>
        public string colorPropertyName = "BackColor";
        #endregion

        #region Public Properties

        #region 1D Public Properties

        /// <summary>
        /// Gets or sets the start value.
        /// </summary>
        /// <value>The start value.</value>
        public float StartValue
        {
            get { return path1_start; }
            set
            {
                path1_start = value;
                control.Invalidate();

            }
        }


        /// <summary>
        /// Gets or sets the end value.
        /// </summary>
        /// <value>The end value.</value>
        public float EndValue
        {
            get { return path1_end; }
            set
            {
                path1_end = value;
                control.Invalidate();

            }
        }


        /// <summary>
        /// Gets or sets the duration value.
        /// </summary>
        /// <value>The duration value.</value>
        public ulong DurationValue
        {
            get { return path1_duration; }
            set
            {
                path1_duration = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the delay value.
        /// </summary>
        /// <value>The delay value.</value>
        public ulong DelayValue
        {
            get { return path1_delay; }
            set
            {
                path1_delay = value;
                control.Invalidate();

            }
        }


        /// <summary>
        /// Gets or sets the one d path easing.
        /// </summary>
        /// <value>The one d path easing.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions OneD_Path_Easing
        {
            get { return oneD_path_easingFunction; }
            set
            {
                oneD_path_easingFunction = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName
        {
            get { return propertyName; }
            set
            {
                propertyName = value;
                control.Invalidate();

            }
        }


        /// <summary>
        /// Gets or sets the one d property.
        /// </summary>
        /// <value>The one d property.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties OneDProperty
        {
            get { return oneDProperty; }
            set
            {
                oneDProperty = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [one d continue].
        /// </summary>
        /// <value><c>true</c> if [one d continue]; otherwise, <c>false</c>.</value>
        public bool OneD_Continue
        {
            get { return oneDContinue; }
            set
            {
                oneDContinue = value;
                control.Invalidate();
            }
        }
        #endregion


        #region 2D Public Properties

        /// <summary>
        /// Gets or sets the path2 d start 1.
        /// </summary>
        /// <value>The path2 d start 1.</value>
        public float Path2D_start_1
        {
            get { return path2D_start_1; }
            set
            {
                path2D_start_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path2 d end 1.
        /// </summary>
        /// <value>The path2 d end 1.</value>
        public float Path2D_end_1
        {
            get { return path2D_end_1; }
            set
            {
                path2D_end_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path2 d duration 1.
        /// </summary>
        /// <value>The path2 d duration 1.</value>
        public ulong Path2D_duration_1
        {
            get { return path2D_duration_1; }
            set
            {
                path2D_duration_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path2 d delay 1.
        /// </summary>
        /// <value>The path2 d delay 1.</value>
        public ulong Path2D_delay_1
        {
            get { return path2D_delay_1; }
            set
            {
                path2D_delay_1 = value;
                control.Invalidate();
            }
        }



        /// <summary>
        /// Gets or sets the path2 d start 2.
        /// </summary>
        /// <value>The path2 d start 2.</value>
        public float Path2D_start_2
        {
            get { return path2D_start_2; }
            set
            {
                path2D_start_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path2 d end 2.
        /// </summary>
        /// <value>The path2 d end 2.</value>
        public float Path2D_end_2
        {
            get { return path2D_end_2; }
            set
            {
                path2D_end_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path2 d duration 2.
        /// </summary>
        /// <value>The path2 d duration 2.</value>
        public ulong Path2D_duration_2
        {
            get { return path2D_duration_2; }
            set
            {
                path2D_duration_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path2 d delay 2.
        /// </summary>
        /// <value>The path2 d delay 2.</value>
        public ulong Path2D_delay_2
        {
            get { return path2D_delay_2; }
            set
            {
                path2D_delay_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d start 1.
        /// </summary>
        /// <value>The continued path2 d start 1.</value>
        public float Continued_path2D_start_1
        {
            get { return continued_path2D_start_1; }
            set
            {
                continued_path2D_start_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d end 1.
        /// </summary>
        /// <value>The continued path2 d end 1.</value>
        public float Continued_path2D_end_1
        {
            get { return continued_path2D_end_1; }
            set
            {
                continued_path2D_end_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d duration 1.
        /// </summary>
        /// <value>The continued path2 d duration 1.</value>
        public ulong Continued_path2D_duration_1
        {
            get { return continued_path2D_duration_1; }
            set
            {
                continued_path2D_duration_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d delay 1.
        /// </summary>
        /// <value>The continued path2 d delay 1.</value>
        public ulong Continued_path2D_delay_1
        {
            get { return continued_path2D_delay_1; }
            set
            {
                continued_path2D_delay_1 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d start 2.
        /// </summary>
        /// <value>The continued path2 d start 2.</value>
        public float Continued_path2D_start_2
        {
            get { return continued_path2D_start_2; }
            set
            {
                continued_path2D_start_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d end 2.
        /// </summary>
        /// <value>The continued path2 d end 2.</value>
        public float Continued_path2D_end_2
        {
            get { return continued_path2D_end_2; }
            set
            {
                continued_path2D_end_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d duration 2.
        /// </summary>
        /// <value>The continued path2 d duration 2.</value>
        public ulong Continued_path2D_duration_2
        {
            get { return continued_path2D_duration_2; }
            set
            {
                continued_path2D_duration_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the continued path2 d delay 2.
        /// </summary>
        /// <value>The continued path2 d delay 2.</value>
        public ulong Continued_path2D_delay_2
        {
            get { return continued_path2D_delay_2; }
            set
            {
                continued_path2D_delay_2 = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path easing.
        /// </summary>
        /// <value>The path easing.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions Path_Easing
        {
            get { return path_easingFunction; }
            set
            {
                path_easingFunction = value;
                control.Invalidate();
            }
        }


        //public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions Path2_Easing
        //{
        //    get { return path2_easingFunction; }
        //    set
        //    {
        //        path2_easingFunction = value;
        //    }
        //}


        /// <summary>
        /// Gets or sets the continued path easing.
        /// </summary>
        /// <value>The continued path easing.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions Continued_Path_Easing
        {
            get { return continued_path_easingFunction; }
            set
            {
                continued_path_easingFunction = value;
                control.Invalidate();
            }
        }

        //public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions Continued_Path2_Easing
        //{
        //    get { return continued_path2_easingFunction; }
        //    set
        //    {
        //        continued_path2_easingFunction = value;
        //    }
        //}


        /// <summary>
        /// Gets or sets the two d property.
        /// </summary>
        /// <value>The two d property.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties TwoDProperty
        {
            get { return twoDProperty; }
            set
            {
                twoDProperty = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [two d continue].
        /// </summary>
        /// <value><c>true</c> if [two d continue]; otherwise, <c>false</c>.</value>
        public bool TwoDContinue
        {
            get { return twoDContinue; }
            set
            {
                twoDContinue = value;
                control.Invalidate();
            }
        }

        #endregion


        #region 3D Public Properties

        /// <summary>
        /// Gets or sets the start color.
        /// </summary>
        /// <value>The start color.</value>
        public Color StartColor
        {
            get { return startColor; }
            set
            {
                startColor = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the end color.
        /// </summary>
        /// <value>The end color.</value>
        public Color EndColor
        {
            get { return endColor; }
            set
            {
                endColor = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the three d property.
        /// </summary>
        /// <value>The three d property.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties ThreeDProperty
        {
            get { return threeDProperty; }
            set
            {
                threeDProperty = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [three d continue].
        /// </summary>
        /// <value><c>true</c> if [three d continue]; otherwise, <c>false</c>.</value>
        public bool ThreeDContinue
        {
            get { return threeDContinue; }
            set
            {
                threeDContinue = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the duration of the path3.
        /// </summary>
        /// <value>The duration of the path3.</value>
        public ulong Path3_Duration
        {
            get { return path3_duration; }
            set
            {
                path3_duration = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path3 delay.
        /// </summary>
        /// <value>The path3 delay.</value>
        public ulong Path3_Delay
        {
            get { return path3_delay; }
            set
            {
                path3_delay = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the path3 easing.
        /// </summary>
        /// <value>The path3 easing.</value>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions Path3_Easing
        {
            get { return threeD_path_easingFunction; }
            set
            {
                threeD_path_easingFunction = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the name of the color property.
        /// </summary>
        /// <value>The name of the color property.</value>
        public string ColorPropertyName
        {
            get { return colorPropertyName; }
            set
            {
                colorPropertyName = value;
                control.Invalidate();
            }
        }

        #endregion


        #region General Animation

        /// <summary>
        /// Gets 1D Animation Mode.
        /// </summary>
        /// <value>animationMode color in a solid fill.</value>

        //public animationMode Default_Mode
        //{
        //    get { return default_Mode; }
        //}

        public animationMode AnimationMode
        {
            get { return _animationMode; }
            set
            {
                _animationMode = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PeaceInput"/> is repeat.
        /// </summary>
        /// <value><c>true</c> if repeat; otherwise, <c>false</c>.</value>
        public bool Repeat
        {
            get { return repeat; }
            set
            {
                if (value == true)
                {
                    _animator.Repeat = true;
                    _animator2D.Repeat = true;
                    _animator3D.Repeat = true;
                }
                else
                {
                    _animator.Repeat = false;
                    _animator2D.Repeat = false;
                    _animator3D.Repeat = false;

                }
                repeat = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PeaceInput"/> is reverse.
        /// </summary>
        /// <value><c>true</c> if reverse; otherwise, <c>false</c>.</value>
        public bool Reverse
        {
            get { return reverse; }
            set
            {

                if (value == true)
                {
                    _animator.ReverseRepeat = true;
                    _animator2D.ReverseRepeat = true;
                    _animator3D.ReverseRepeat = true;
                }
                else
                {
                    _animator.ReverseRepeat = false;
                    _animator2D.ReverseRepeat = false;
                    _animator3D.ReverseRepeat = false;
                }

                reverse = value;
                control.Invalidate();
            }
            
        }

        /// <summary>
        /// The control
        /// </summary>
        public Control  control = new Control();

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return control; }
            set
            {

                control = value;
                control.Invalidate();
            }
        }

        #endregion

        /// <summary>
        /// The animator
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator _animator;
        /// <summary>
        /// The animator2 d
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D _animator2D = new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D();
        /// <summary>
        /// The animator3 d
        /// </summary>
        public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D _animator3D = new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D();

        //[Browsable(false)]
        //public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator _Animator
        //{
        //    get { return _animator; }
        //    set
        //    {
        //        _animator = value;
        //    }
        //}

        //[Browsable(false)]
        //public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D _Animator2D
        //{
        //    get { return _animator2D; }
        //    set
        //    {
        //        _animator2D = value;
        //    }
        //}

        //[Browsable(false)]
        //public Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D _Animator3D
        //{
        //    get { return _animator3D; }
        //    set
        //    {
        //        _animator3D = value;
        //    }
        //}


        #endregion

        #region Constructor

        // Internal constructor 
        /// <summary>
        /// Initializes a new instance of the <see cref="PeaceInput"/> class.
        /// </summary>
        /// <param name="_animationMode">The animation mode.</param>
        /// <param name="alpha">The alpha.</param>
        /// <param name="repeat">if set to <c>true</c> [repeat].</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="path1_start">The path1 start.</param>
        /// <param name="path1_end">The path1 end.</param>
        /// <param name="path1_duration">Duration of the path1.</param>
        /// <param name="path1_delay">The path1 delay.</param>
        /// <param name="path2D_start_1">The path2 d start 1.</param>
        /// <param name="path2D_end_1">The path2 d end 1.</param>
        /// <param name="path2D_duration_1">The path2 d duration 1.</param>
        /// <param name="path2D_delay_1">The path2 d delay 1.</param>
        /// <param name="path2D_start_2">The path2 d start 2.</param>
        /// <param name="path2D_end_2">The path2 d end 2.</param>
        /// <param name="path2D_duration_2">The path2 d duration 2.</param>
        /// <param name="path2D_delay_2">The path2 d delay 2.</param>
        /// <param name="continued_path2D_start_1">The continued path2 d start 1.</param>
        /// <param name="continued_path2D_end_1">The continued path2 d end 1.</param>
        /// <param name="continued_path2D_duration_1">The continued path2 d duration 1.</param>
        /// <param name="continued_path2D_delay_1">The continued path2 d delay 1.</param>
        /// <param name="continued_path2D_start_2">The continued path2 d start 2.</param>
        /// <param name="continued_path2D_end_2">The continued path2 d end 2.</param>
        /// <param name="continued_path2D_duration_2">The continued path2 d duration 2.</param>
        /// <param name="continued_path2D_delay_2">The continued path2 d delay 2.</param>
        /// <param name="path3D_start_1">The path3 d start 1.</param>
        /// <param name="path3D_end_1">The path3 d end 1.</param>
        /// <param name="path3_duration">Duration of the path3.</param>
        /// <param name="path3_delay">The path3 delay.</param>
        /// <param name="oneDProperty">The one d property.</param>
        /// <param name="twoDProperty">The two d property.</param>
        /// <param name="threeDProperty">The three d property.</param>
        /// <param name="oneD_path_easingFunction">The one d path easing function.</param>
        /// <param name="threeD_path_easingFunction">The three d path easing function.</param>
        /// <param name="path_easingFunction">The path easing function.</param>
        /// <param name="continued_path_easingFunction">The continued path easing function.</param>
        /// <param name="oneDContinue">if set to <c>true</c> [one d continue].</param>
        /// <param name="twoDContinue">if set to <c>true</c> [two d continue].</param>
        /// <param name="threeDContinue">if set to <c>true</c> [three d continue].</param>
        /// <param name="startColor">The start color.</param>
        /// <param name="endColor">The end color.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="colorPropertyName">Name of the color property.</param>
        /// <param name="_animator">The animator.</param>
        /// <param name="_animator2D">The animator2 d.</param>
        /// <param name="_animator3D">The animator3 d.</param>
        private PeaceInput(
            animationMode _animationMode,
            int alpha,
            bool repeat,
            bool reverse,
            float path1_start,
            float path1_end,
            ulong path1_duration,
            ulong path1_delay,

            float path2D_start_1,
            float path2D_end_1,
            ulong path2D_duration_1,
            ulong path2D_delay_1,

            float path2D_start_2,
            float path2D_end_2,
            ulong path2D_duration_2,
            ulong path2D_delay_2,

            float continued_path2D_start_1,
            float continued_path2D_end_1,
            ulong continued_path2D_duration_1,
            ulong continued_path2D_delay_1,

            float continued_path2D_start_2,
            float continued_path2D_end_2,
            ulong continued_path2D_duration_2,
            ulong continued_path2D_delay_2,

            float path3D_start_1,
            float path3D_end_1,
            ulong path3_duration,
            ulong path3_delay,
            
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties oneDProperty,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties twoDProperty,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties threeDProperty,

            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions oneD_path_easingFunction,

            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions threeD_path_easingFunction,

            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions path_easingFunction,
        
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions continued_path_easingFunction,
        
            bool oneDContinue,
            bool twoDContinue,
            bool threeDContinue,

            Color startColor,
            Color endColor,

            string propertyName,
            string colorPropertyName,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator _animator,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D _animator2D,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D _animator3D
            //Control control
            
            )
        {
            this._animationMode = _animationMode;
            this.alpha = alpha;
            this.repeat = repeat;
            this.reverse = reverse;
            this.path1_start = path1_start;
            this.path1_end = path1_end;
            this.path1_duration = path1_duration;
            this.path1_delay = path1_delay;

            this.path2D_start_1 = path2D_start_1;
            this.path2D_end_1 = path2D_end_1;
            this.path2D_duration_1 = path2D_duration_1;
            this.path2D_delay_1 = path2D_delay_1;

            this.path2D_start_2 = path2D_start_2;
            this.path2D_end_2 = path2D_end_2;
            this.path2D_duration_2 = path2D_duration_2;
            this.path2D_delay_2 = path2D_delay_2;

            this.continued_path2D_start_1 = continued_path2D_start_1;
            this.continued_path2D_end_1 = continued_path2D_end_1;
            this.continued_path2D_duration_1 = continued_path2D_duration_1;
            this.continued_path2D_delay_1 = continued_path2D_delay_1;

            this.continued_path2D_start_2 = continued_path2D_start_2;
            this.continued_path2D_end_2 = continued_path2D_end_2;
            this.continued_path2D_duration_2 = continued_path2D_duration_2;
            this.continued_path2D_delay_2 = continued_path2D_delay_2;

            this.path3D_start_1 = path3D_start_1;
            this.path3D_end_1 = path3D_end_1;
            this.path3_duration = path3_duration;
            this.path3_delay = path3_delay;

            //this._animator = _animator;
            //this._animator2D = _animator2D;
            //this._animator3D = _animator3D;


            this.oneDProperty = oneDProperty;
            this.twoDProperty = twoDProperty;
            this.threeDProperty = threeDProperty;

            this.oneD_path_easingFunction = oneD_path_easingFunction;

            this.threeD_path_easingFunction = threeD_path_easingFunction;

            this.path_easingFunction = path_easingFunction;
            
            this.continued_path_easingFunction = continued_path_easingFunction;


            this.oneDContinue = oneDContinue;
            this.twoDContinue = twoDContinue;
            this.threeDContinue = threeDContinue;

            this.startColor = startColor;
            this.endColor = endColor;

            this.propertyName = propertyName;
            this.colorPropertyName = colorPropertyName;
            
            this._animator = _animator;
            this._animator2D = _animator2D;
            this._animator3D = _animator3D;
            //PeaceInput.control = control;
            
            this._animator = new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator(new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Path(this.path1_start, this.path1_end, this.path1_duration, this.path1_delay));


        }

        /// <summary>
        /// Constructor for no Input.
        /// </summary>
        public PeaceInput() : this(
            animationMode.OneD,
            10,
            false,
            false,
            0,
            100,
            5000,
            0,
            70,
            320,
            2000,
            0,
            5,
            100,
            2000,
            0,
            320,
            70,
            2000,
            300,
            100,
            5,
            1700,
            600,
            70,
            320,
            3000,
            0,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties.Location,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties.BackColor,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut,
            true,
            true,
            true,
            Color.DarkSlateGray,
            Color.Orange,
            "Value",
            "BackColor",
            //new Control(),
            new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator(new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Path(0, 100, 5000, 0)),
            new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D(),
            new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D()
            //control

            ) /* gradientColors */
        {

            
        }

        // <summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="PeaceInput"/> class.
        /// </summary>
        /// <param name="Default">The default.</param>
        /// <param name="control">The control.</param>
        public PeaceInput(
            animationMode Default,
            Control control
            ) :
            this(
                animationMode.Default,
                10,
                false,
                false,
                0,
                100,
                5000,
                0,
                70,
                320,
                2000,
                0,
                5,
                100,
                2000,
                0,
                320,
                70,
                2000,
                300,
                100,
                5,
                1700,
                600,
                70,
                320,
                3000,
                0,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties.Location,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties.BackColor,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut,
                true,
                true,
                true,
                Color.DarkSlateGray,
                Color.Orange,
                "Value",
                "BackColor",
                //new Control(),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator(new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Path(0, 100, 5000, 0)),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D(),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D()
                //control
            ) /* gradientColors */
        {
            this._animationMode = Default;
            this.control = control;
        }

        // <summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="PeaceInput"/> class.
        /// </summary>
        /// <param name="OneD">The one d.</param>
        /// <param name="repeat">if set to <c>true</c> [repeat].</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="path1_start">The path1 start.</param>
        /// <param name="path1_end">The path1 end.</param>
        /// <param name="path1_duration">Duration of the path1.</param>
        /// <param name="path1_delay">The path1 delay.</param>
        /// <param name="oneD_path_easingFunction">The one d path easing function.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="oneDProperty">The one d property.</param>
        /// <param name="oneDContinue">if set to <c>true</c> [one d continue].</param>
        /// <param name="_animator">The animator.</param>
        /// <param name="control">The control.</param>
        public PeaceInput(
            animationMode OneD, 
            bool repeat,
            bool reverse,
            float path1_start,
            float path1_end,
            ulong path1_duration,
            ulong path1_delay,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions oneD_path_easingFunction,
            string propertyName,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties oneDProperty,
            bool oneDContinue,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator _animator,
            Control control
            ) : 
            this(
            animationMode.OneD,
            10,
            false,
            false,
            0,
            100,
            5000,
            0,
            70,
            320,
            2000,
            0,
            5,
            100,
            2000,
            0,
            320,
            70,
            2000,
            300,
            100,
            5,
            1700,
            600,
            70,
            320,
            3000,
            0,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties.Location,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties.BackColor,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut,
            true,
            true,
            true,
            Color.DarkSlateGray,
            Color.Orange,
            "Value",
            "BackColor",
            //new Control(),
            new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator(new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Path(0, 100, 5000, 0)),
            new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D(),
            new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D()
            //control
        ) /* gradientColors */
        {
            

            this.repeat = repeat;
            this.reverse = reverse;
            this.path1_start = path1_start;
            this.path1_end = path1_end;
            this.path1_duration = path1_duration;
            this.path1_delay = path1_delay;
            this.oneDProperty = oneDProperty;
            this.oneD_path_easingFunction = oneD_path_easingFunction;
            this.oneDContinue = oneDContinue;
            this.propertyName = propertyName;
            this._animator = _animator;
            this._animationMode = OneD;
            this.control = control;

        }

        // <summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="PeaceInput"/> class.
        /// </summary>
        /// <param name="twoD">The two d.</param>
        /// <param name="repeat">if set to <c>true</c> [repeat].</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="path2D_start_1">The path2 d start 1.</param>
        /// <param name="path2D_end_1">The path2 d end 1.</param>
        /// <param name="path2D_duration_1">The path2 d duration 1.</param>
        /// <param name="path2D_delay_1">The path2 d delay 1.</param>
        /// <param name="path2D_start_2">The path2 d start 2.</param>
        /// <param name="path2D_end_2">The path2 d end 2.</param>
        /// <param name="path2D_duration_2">The path2 d duration 2.</param>
        /// <param name="path2D_delay_2">The path2 d delay 2.</param>
        /// <param name="continued_path2D_start_1">The continued path2 d start 1.</param>
        /// <param name="continued_path2D_end_1">The continued path2 d end 1.</param>
        /// <param name="continued_path2D_duration_1">The continued path2 d duration 1.</param>
        /// <param name="continued_path2D_delay_1">The continued path2 d delay 1.</param>
        /// <param name="continued_path2D_start_2">The continued path2 d start 2.</param>
        /// <param name="continued_path2D_end_2">The continued path2 d end 2.</param>
        /// <param name="continued_path2D_duration_2">The continued path2 d duration 2.</param>
        /// <param name="continued_path2D_delay_2">The continued path2 d delay 2.</param>
        /// <param name="twoDProperty">The two d property.</param>
        /// <param name="path_easingFunction">The path easing function.</param>
        /// <param name="continued_path_easingFunction">The continued path easing function.</param>
        /// <param name="twoDContinue">if set to <c>true</c> [two d continue].</param>
        /// <param name="_animator2D">The animator2 d.</param>
        /// <param name="control">The control.</param>
        public PeaceInput(
            animationMode twoD,
            bool repeat,
            bool reverse,
            float path2D_start_1,
            float path2D_end_1,
            ulong path2D_duration_1,
            ulong path2D_delay_1,
            float path2D_start_2,
            float path2D_end_2,
            ulong path2D_duration_2,
            ulong path2D_delay_2,
            float continued_path2D_start_1,
            float continued_path2D_end_1,
            ulong continued_path2D_duration_1,
            ulong continued_path2D_delay_1,
            float continued_path2D_start_2,
            float continued_path2D_end_2,
            ulong continued_path2D_duration_2,
            ulong continued_path2D_delay_2,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties twoDProperty,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions path_easingFunction,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions continued_path_easingFunction,
            bool twoDContinue,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D _animator2D,
            Control control
            ) :
            this(
                animationMode.TwoD,
                10,
                false,
                false,
                0,
                100,
                5000,
                0,
                70,
                320,
                2000,
                0,
                5,
                100,
                2000,
                0,
                320,
                70,
                2000,
                300,
                100,
                5,
                1700,
                600,
                70,
                320,
                3000,
                0,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties.Location,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties.BackColor,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut,
                true,
                true,
                true,
                Color.DarkSlateGray,
                Color.Orange,
                "Value",
                "BackColor",
                //new Control(),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator(new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Path(0, 100, 5000, 0)),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D(),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D()
                //control
            ) /* gradientColors */
        {
            
            this.repeat = repeat;
            this.reverse = reverse;
            this.path2D_start_1 = path2D_start_1;
            this.path2D_end_1 = path2D_end_1;
            this.path2D_duration_1 = path2D_duration_1;
            this.path2D_delay_1 = path2D_delay_1;
            this.path2D_start_2 = path2D_start_2;
            this.path2D_end_2 = path2D_end_2;
            this.path2D_duration_2 = path2D_duration_2;
            this.path2D_delay_2 = path2D_delay_2;
            this.continued_path2D_start_1 = continued_path2D_start_1;
            this.continued_path2D_end_1 = continued_path2D_end_1;
            this.continued_path2D_duration_1 = continued_path2D_duration_1;
            this.continued_path2D_delay_1 = continued_path2D_delay_1;
            this.continued_path2D_start_2 = continued_path2D_start_2;
            this.continued_path2D_end_2 = continued_path2D_end_2;
            this.continued_path2D_duration_2 = continued_path2D_duration_2;
            this.continued_path2D_delay_2 = continued_path2D_delay_2;
            this.twoDProperty = twoDProperty;
            this.path_easingFunction = path_easingFunction;
            this.continued_path_easingFunction = continued_path_easingFunction;
            this.twoDContinue = twoDContinue;
            this._animator2D = _animator2D;

            this._animationMode = twoD;
            this.control = control;

        }

        // <summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="PeaceInput"/> class.
        /// </summary>
        /// <param name="threeD">The three d.</param>
        /// <param name="repeat">if set to <c>true</c> [repeat].</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="path3_duration">Duration of the path3.</param>
        /// <param name="path3_delay">The path3 delay.</param>
        /// <param name="threeDProperty">The three d property.</param>
        /// <param name="threeD_path_easingFunction">The three d path easing function.</param>
        /// <param name="startColor">The start color.</param>
        /// <param name="endColor">The end color.</param>
        /// <param name="colorPropertyName">Name of the color property.</param>
        /// <param name="twoDContinue">if set to <c>true</c> [two d continue].</param>
        /// <param name="_animator3D">The animator3 d.</param>
        /// <param name="control">The control.</param>
        public PeaceInput(
            animationMode threeD,
            bool repeat,
            bool reverse,
            ulong path3_duration,
            ulong path3_delay,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties threeDProperty,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions threeD_path_easingFunction,
            Color startColor,
            Color endColor,
            string colorPropertyName,
            bool twoDContinue,
            Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D _animator3D,
            Control control
            ) :
            
            this(
                animationMode.ThreeD,
                10,
                false,
                false,
                0,
                100,
                5000,
                0,
                70,
                320,
                2000,
                0,
                5,
                100,
                2000,
                0,
                320,
                70,
                2000,
                300,
                100,
                5,
                1700,
                600,
                70,
                320,
                3000,
                0,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties.Location,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties.BackColor,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn,
                Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut,
                true,
                true,
                true,
                Color.DarkSlateGray,
                Color.Orange,
                "Value",
                "BackColor",
                //new Control(),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator(new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Path(0, 100, 5000, 0)),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D(),
                new Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D()
                //control
            ) /* gradientColors */
        {
            
            this.repeat = repeat;
            this.reverse = reverse;
            this.path3_duration = path3_duration;
            this.path3_delay = path3_delay;
            this.threeDProperty = threeDProperty;
            this.threeD_path_easingFunction = threeD_path_easingFunction;
            this.twoDContinue = twoDContinue;
            this.startColor = startColor;
            this.endColor = endColor;
            this.colorPropertyName = colorPropertyName;
            this._animator3D = _animator3D;
            this._animationMode = threeD;
            this.control = control;

        }


        #endregion

        #region Public Methods


        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>PeaceInput.</returns>
        public PeaceInput Clone()
        {
            return new PeaceInput(
                _animationMode,
            alpha,
            repeat,
            reverse,
             path1_start,
             path1_end,
             path1_duration,
             path1_delay,

             path2D_start_1,
             path2D_end_1,
             path2D_duration_1,
             path2D_delay_1,

             path2D_start_2,
             path2D_end_2,
             path2D_duration_2,
             path2D_delay_2,

             continued_path2D_start_1,
             continued_path2D_end_1,
             continued_path2D_duration_1,
             continued_path2D_delay_1,

             continued_path2D_start_2,
             continued_path2D_end_2,
             continued_path2D_duration_2,
             continued_path2D_delay_2,
             path3D_start_1,
             path3D_end_1,
             path3_duration,
             path3_delay,
             oneDProperty,
             twoDProperty,
             threeDProperty,
             oneD_path_easingFunction,
             threeD_path_easingFunction,
             path_easingFunction,
             continued_path_easingFunction,
             oneDContinue,
             twoDContinue,
             threeDContinue,
             startColor,
             endColor,
             propertyName,
             colorPropertyName,
             _animator,
             _animator2D,
             _animator3D
             //control
             );
        }


        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>PeaceInput.</returns>
        public static PeaceInput Empty()
        {
            return new PeaceInput();
        }
        

        #endregion
        

        #region Converter

        
        #endregion

    }


    /// <summary>
    /// Class PeaceInputConverter.
    /// </summary>
    /// <seealso cref="System.ComponentModel.TypeConverter" />
    class PeaceInputConverter : TypeConverter
    {

        /// <summary>
        /// Returns whether this converter can convert the object to the specified type, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
        /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(InstanceDescriptor) || destinationType == typeof(string))
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
        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture,
            object value,
            Type destinationType)
        {
            if (value is PeaceInput)
            {
                if (destinationType == typeof(string))
                {
                    // Display string in designer
                    return "(PeaceInput)";
                }
                else if (destinationType == typeof(InstanceDescriptor))
                {
                    PeaceInput peaceInput = (PeaceInput)value;

                    if (peaceInput._animationMode == animationMode.OneD)
                    {
                        ConstructorInfo ctor = typeof(PeaceInput).GetConstructor(new Type[]
                        {

                            typeof(animationMode),
                            typeof(bool),
                            typeof(bool),
                            typeof(float),
                            typeof(float),
                            typeof(ulong),
                            typeof(ulong),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions),
                            typeof(string),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator.KnownProperties),
                            typeof(bool),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator),
                            typeof(Control)


                        });
                        if (ctor != null)
                        {
                            return new InstanceDescriptor(ctor, new object[] {
                                peaceInput._animationMode,
                                peaceInput.repeat,
                                peaceInput.reverse,
                                peaceInput.path1_start,
                                peaceInput.path1_end,
                                peaceInput.path1_duration,
                                peaceInput.path1_delay,
                                peaceInput.oneD_path_easingFunction,
                                peaceInput.propertyName,
                                peaceInput.oneDProperty,
                                peaceInput.oneDContinue,
                                peaceInput._animator,
                                peaceInput.control
                                
                            });
                        }
                    }

                    else if (peaceInput._animationMode == animationMode.TwoD)
                    {
                        ConstructorInfo ctor = typeof(PeaceInput).GetConstructor(new Type[] {
                            typeof(animationMode),
                            typeof(bool),
                            typeof(bool),
                            typeof(float),
                            typeof(float),
                            typeof(ulong),
                            typeof(ulong),
                            typeof(float),
                            typeof(float),
                            typeof(ulong),
                            typeof(ulong),
                            typeof(float),
                            typeof(float),
                            typeof(ulong),
                            typeof(ulong),
                            typeof(float),
                            typeof(float),
                            typeof(ulong),
                            typeof(ulong),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D.KnownProperties),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions),
                            typeof(bool),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator2D),
                            typeof(Control)
                            
                        });
                        if (ctor != null)
                        {
                            return new InstanceDescriptor(ctor, new object[] {

                                peaceInput._animationMode,
                                peaceInput.repeat,
                                peaceInput.reverse,
                                peaceInput.path2D_start_1,
                                peaceInput.path2D_end_1,
                                peaceInput.path2D_duration_1,
                                peaceInput.path2D_delay_1,
                                peaceInput.path2D_start_2,
                                peaceInput.path2D_end_2,
                                peaceInput.path2D_duration_2,
                                peaceInput.path2D_delay_2,
                                peaceInput.continued_path2D_start_1,
                                peaceInput.continued_path2D_end_1,
                                peaceInput.continued_path2D_duration_1,
                                peaceInput.continued_path2D_delay_1,
                                peaceInput.continued_path2D_start_2,
                                peaceInput.continued_path2D_end_2,
                                peaceInput.continued_path2D_duration_2,
                                peaceInput.continued_path2D_delay_2,
                                peaceInput.twoDProperty,
                                peaceInput.path_easingFunction,
                                peaceInput.continued_path_easingFunction,
                                peaceInput.twoDContinue,
                                peaceInput._animator2D,
                                peaceInput.control

                            });
                        }
                    }
                    else if (peaceInput._animationMode == animationMode.ThreeD)
                    {
                        ConstructorInfo ctor = typeof(PeaceInput).GetConstructor(new Type[] {
                            
                            typeof(animationMode),
                            typeof(bool),
                            typeof(bool),
                            typeof(ulong),
                            typeof(ulong),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D.KnownProperties),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions),
                            typeof(Color),
                            typeof(Color),
                            typeof(string),
                            typeof(bool),
                            typeof(Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.Animator3D),
                            typeof(Control)

                        });
                        if (ctor != null)
                        {
                            return new InstanceDescriptor(ctor, new object[] {

                                peaceInput._animationMode,
                                peaceInput.repeat,
                                peaceInput.reverse,
                                peaceInput.path3_duration,
                                peaceInput.path3_delay,
                                peaceInput.threeDProperty,
                                peaceInput.threeD_path_easingFunction,
                                peaceInput.startColor,
                                peaceInput.endColor,
                                peaceInput.colorPropertyName,
                                peaceInput.threeDContinue,
                                peaceInput._animator3D,
                                peaceInput.control

                            });
                        }
                    }


                    else if (peaceInput._animationMode == animationMode.Default)
                    {
                        ConstructorInfo ctor = typeof(PeaceInput).GetConstructor(new Type[] {
                            typeof(animationMode),
                            //typeof(Control)

                        });
                        if (ctor != null)
                        {
                            return new InstanceDescriptor(ctor, new object[] {
                                peaceInput._animationMode,
                                peaceInput.control

                            });
                        }
                    }


                    else
                    {
                        ConstructorInfo ctor = typeof(PeaceInput).GetConstructor(Type.EmptyTypes);
                        if (ctor != null)
                        {
                            return new InstanceDescriptor(ctor, null);
                        }
                    }
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }


}
