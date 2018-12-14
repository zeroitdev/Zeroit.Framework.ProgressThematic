#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms.Design;
using System.Reflection;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Data;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using Microsoft.Win32;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
//using System.Windows.Forms.VisualStyles;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;
using Zeroit.Framework.Functions;
using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematicV2
{
    #region Winform Animation

    #region AnimationFunction
    /// <summary>
    ///     The functions gallery for animation
    /// </summary>
    public static class AnimationFunctions
    {
        /// <summary>
        ///     The base delegate for defining new animation functions.
        /// </summary>
        /// <param name="time">
        ///     The time of the animation.
        /// </param>
        /// <param name="beginningValue">
        ///     The starting value.
        /// </param>
        /// <param name="changeInValue">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="duration">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public delegate float Function(float time, float beginningValue, float changeInValue, float duration);

        /// <summary>
        ///     Returns a function delegate based on the the passed known animation function
        /// </summary>
        /// <param name="knownFunction">The animation function</param>
        /// <returns>Animation fucntion delegate</returns>
        public static Function FromKnown(KnownAnimationFunctions knownFunction)
        {
            switch (knownFunction)
            {
                case KnownAnimationFunctions.CubicEaseIn:
                    return CubicEaseIn;
                case KnownAnimationFunctions.CubicEaseInOut:
                    return CubicEaseInOut;
                case KnownAnimationFunctions.CubicEaseOut:
                    return CubicEaseOut;
                case KnownAnimationFunctions.Liner:
                    return Liner;
                case KnownAnimationFunctions.CircularEaseInOut:
                    return CircularEaseInOut;
                case KnownAnimationFunctions.CircularEaseIn:
                    return CircularEaseIn;
                case KnownAnimationFunctions.CircularEaseOut:
                    return CircularEaseOut;
                case KnownAnimationFunctions.QuadraticEaseIn:
                    return QuadraticEaseIn;
                case KnownAnimationFunctions.QuadraticEaseOut:
                    return QuadraticEaseOut;
                case KnownAnimationFunctions.QuadraticEaseInOut:
                    return QuadraticEaseInOut;
                case KnownAnimationFunctions.QuarticEaseIn:
                    return QuarticEaseIn;
                case KnownAnimationFunctions.QuarticEaseOut:
                    return QuarticEaseOut;
                case KnownAnimationFunctions.QuarticEaseInOut:
                    return QuarticEaseInOut;
                case KnownAnimationFunctions.QuinticEaseInOut:
                    return QuinticEaseInOut;
                case KnownAnimationFunctions.QuinticEaseIn:
                    return QuinticEaseIn;
                case KnownAnimationFunctions.QuinticEaseOut:
                    return QuinticEaseOut;
                case KnownAnimationFunctions.SinusoidalEaseIn:
                    return SinusoidalEaseIn;
                case KnownAnimationFunctions.SinusoidalEaseOut:
                    return SinusoidalEaseOut;
                case KnownAnimationFunctions.SinusoidalEaseInOut:
                    return SinusoidalEaseInOut;
                case KnownAnimationFunctions.ExponentialEaseIn:
                    return ExponentialEaseIn;
                case KnownAnimationFunctions.ExponentialEaseOut:
                    return ExponentialEaseOut;
                case KnownAnimationFunctions.ExponentialEaseInOut:
                    return ExponentialEaseInOut;
                default:
                    throw new ArgumentOutOfRangeException("The passed animation function is unknown.");
            }
        }


        /// <summary>
        ///     The cubic ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float CubicEaseIn(float t, float b, float c, float d)
        {
            t /= d;
            return c * t * t * t + b;
        }

        /// <summary>
        ///     The cubic ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float CubicEaseInOut(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1)
                return c / 2 * t * t * t + b;

            t -= 2;
            return c / 2 * (t * t * t + 2) + b;
        }

        /// <summary>
        ///     The cubic ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float CubicEaseOut(float t, float b, float c, float d)
        {
            t /= d;
            t--;
            return c * (t * t * t + 1) + b;
        }

        /// <summary>
        ///     The liner animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float Liner(float t, float b, float c, float d)
        {
            return c * t / d + b;
        }

        /// <summary>
        ///     The circular ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float CircularEaseInOut(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1)
                return (float)(-c / 2 * (Math.Sqrt(1 - t * t) - 1) + b);
            t -= 2;
            return (float)(c / 2 * (Math.Sqrt(1 - t * t) + 1) + b);
        }


        /// <summary>
        ///     The circular ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float CircularEaseIn(float t, float b, float c, float d)
        {
            t /= d;
            return (float)(-c * (Math.Sqrt(1 - t * t) - 1) + b);
        }


        /// <summary>
        ///     The circular ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float CircularEaseOut(float t, float b, float c, float d)
        {
            t /= d;
            t--;
            return (float)(c * Math.Sqrt(1 - t * t) + b);
        }


        /// <summary>
        ///     The quadratic ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuadraticEaseIn(float t, float b, float c, float d)
        {
            t /= d;
            return c * t * t + b;
        }


        /// <summary>
        ///     The quadratic ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuadraticEaseOut(float t, float b, float c, float d)
        {
            t /= d;
            return -c * t * (t - 2) + b;
        }


        /// <summary>
        ///     The quadratic ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuadraticEaseInOut(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t + b;
            t--;
            return -c / 2 * (t * (t - 2) - 1) + b;
        }

        /// <summary>
        ///     The quartic ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuarticEaseIn(float t, float b, float c, float d)
        {
            t /= d;
            return c * t * t * t * t + b;
        }

        /// <summary>
        ///     The quartic ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuarticEaseOut(float t, float b, float c, float d)
        {
            t /= d;
            t--;
            return -c * (t * t * t * t - 1) + b;
        }

        /// <summary>
        ///     The quartic ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuarticEaseInOut(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t + b;
            t -= 2;
            return -c / 2 * (t * t * t * t - 2) + b;
        }

        /// <summary>
        ///     The quintic ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuinticEaseInOut(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t * t * t + 2) + b;
        }

        /// <summary>
        ///     The quintic ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuinticEaseIn(float t, float b, float c, float d)
        {
            t /= d;
            return c * t * t * t * t * t + b;
        }

        /// <summary>
        ///     The quintic ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float QuinticEaseOut(float t, float b, float c, float d)
        {
            t /= d;
            t--;
            return c * (t * t * t * t * t + 1) + b;
        }

        /// <summary>
        ///     The sinusoidal ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float SinusoidalEaseIn(float t, float b, float c, float d)
        {
            return (float)(-c * Math.Cos(t / d * (Math.PI / 2)) + c + b);
        }

        /// <summary>
        ///     The sinusoidal ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float SinusoidalEaseOut(float t, float b, float c, float d)
        {
            return (float)(c * Math.Sin(t / d * (Math.PI / 2)) + b);
        }

        /// <summary>
        ///     The sinusoidal ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float SinusoidalEaseInOut(float t, float b, float c, float d)
        {
            return (float)(-c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b);
        }

        /// <summary>
        ///     The exponential ease-in animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float ExponentialEaseIn(float t, float b, float c, float d)
        {
            return (float)(c * Math.Pow(2, 10 * (t / d - 1)) + b);
        }

        /// <summary>
        ///     The exponential ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float ExponentialEaseOut(float t, float b, float c, float d)
        {
            return (float)(c * (-Math.Pow(2, -10 * t / d) + 1) + b);
        }


        /// <summary>
        ///     The exponential ease-in and ease-out animation function.
        /// </summary>
        /// <param name="t">
        ///     The time of the animation.
        /// </param>
        /// <param name="b">
        ///     The starting value.
        /// </param>
        /// <param name="c">
        ///     The different between starting and ending value.
        /// </param>
        /// <param name="d">
        ///     The duration of the animations.
        /// </param>
        /// <returns>
        ///     The calculated current value of the animation
        /// </returns>
        public static float ExponentialEaseInOut(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1)
                return (float)(c / 2 * Math.Pow(2, 10 * (t - 1)) + b);
            t--;
            return (float)(c / 2 * (-Math.Pow(2, -10 * t) + 2) + b);
        }
    }

    #endregion
    #region Animator
    /// <summary>
    ///     The one dimensional animator class, useful for animating raw values
    /// </summary>
    public class Animator : IAnimator
    {
        /// <summary>
        ///     The known one dimensional properties of WinForm controls
        /// </summary>
        public enum KnownProperties
        {
            /// <summary>
            ///     The property named 'Value' of the object
            /// </summary>
            Value,

            /// <summary>
            ///     The property named 'Text' of the object
            /// </summary>
            Text,

            /// <summary>
            ///     The property named 'Caption' of the object
            /// </summary>
            Caption,

            /// <summary>
            ///     The property named 'BackColor' of the object
            /// </summary>
            BackColor,

            /// <summary>
            ///     The property named 'ForeColor' of the object
            /// </summary>
            ForeColor,

            /// <summary>
            ///     The property named 'Opacity' of the object
            /// </summary>
            Opacity
        }

        private readonly List<Path> _paths = new List<Path>();

        private readonly List<Path> _tempPaths = new List<Path>();

        private readonly Timer _timer;

        private bool _tempReverseRepeat;

        /// <summary>
        ///     The callback to get invoked at the end of the animation
        /// </summary>
        protected SafeInvoker EndCallback;

        /// <summary>
        ///     The callback to get invoked at each frame
        /// </summary>
        protected SafeInvoker<float> FrameCallback;

        /// <summary>
        ///     The target object to change the property of
        /// </summary>
        protected object TargetObject;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator" /> class.
        /// </summary>
        public Animator()
            : this(new Path[] { })
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator" /> class.
        /// </summary>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator(FPSLimiterKnownValues fpsLimiter)
            : this(new Path[] { }, fpsLimiter)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator" /> class.
        /// </summary>
        /// <param name="path">
        ///     The path of the animation
        /// </param>
        public Animator(Path path)
            : this(new[] { path })
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator" /> class.
        /// </summary>
        /// <param name="path">
        ///     The path of the animation
        /// </param>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator(Path path, FPSLimiterKnownValues fpsLimiter)
            : this(new[] { path }, fpsLimiter)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator" /> class.
        /// </summary>
        /// <param name="paths">
        ///     An array containing the list of paths of the animation
        /// </param>
        public Animator(Path[] paths)
            : this(paths, FPSLimiterKnownValues.LimitThirty)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator" /> class.
        /// </summary>
        /// <param name="paths">
        ///     An array containing the list of paths of the animation
        /// </param>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator(Path[] paths, FPSLimiterKnownValues fpsLimiter)
        {
            CurrentStatus = AnimatorStatus.Stopped;
            _timer = new Timer(Elapsed, fpsLimiter);
            Paths = paths;
        }

        /// <summary>
        ///     Gets or sets an array containing the list of paths of the animation
        /// </summary>
        /// <exception cref="InvalidOperationException">Animation is running</exception>
        public Path[] Paths
        {
            get { return _paths.ToArray(); }
            set
            {
                if (CurrentStatus == AnimatorStatus.Stopped)
                {
                    _paths.Clear();
                    _paths.AddRange(value);
                }
                else
                {
                    throw new InvalidOperationException("Animation is running.");
                }
            }
        }

        /// <summary>
        ///     Gets the currently active path.
        /// </summary>
        public Path ActivePath { get; private set; }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation after its ending
        /// </summary>
        public virtual bool Repeat { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation in reverse after its ending.
        /// </summary>
        public virtual bool ReverseRepeat { get; set; }

        /// <summary>
        ///     Gets the current status of the animation
        /// </summary>
        public virtual AnimatorStatus CurrentStatus { get; private set; }

        /// <summary>
        ///     Pause the animation
        /// </summary>
        public virtual void Pause()
        {
            if (CurrentStatus != AnimatorStatus.OnHold && CurrentStatus != AnimatorStatus.Playing)
                return;
            _timer.Stop();
            CurrentStatus = AnimatorStatus.Paused;
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        public virtual void Play(object targetObject, string propertyName)
        {
            Play(targetObject, propertyName, null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public virtual void Play(object targetObject, string propertyName, SafeInvoker endCallback)
        {
            TargetObject = targetObject;
            var prop = TargetObject.GetType()
                .GetProperty(
                    propertyName,
                    BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance |
                    BindingFlags.SetProperty);
            if (prop == null) return;
            Play(
                new SafeInvoker<float>(
                    value => prop.SetValue(TargetObject, Convert.ChangeType(value, prop.PropertyType), null),
                    TargetObject),
                endCallback);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        public virtual void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter)
        {
            Play(targetObject, propertySetter, null);
        }


        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        public virtual void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter, SafeInvoker endCallback)
        {
            if (propertySetter == null)
                return;
            TargetObject = targetObject;

            var property =
                ((propertySetter.Body as MemberExpression) ??
                 (((UnaryExpression)propertySetter.Body).Operand as MemberExpression)).Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException();
            }

            Play(
                new SafeInvoker<float>(
                    value => property.SetValue(TargetObject, Convert.ChangeType(value, property.PropertyType), null),
                    TargetObject),
                endCallback);
        }

        /// <summary>
        ///     Resume the animation from where it paused
        /// </summary>
        public virtual void Resume()
        {
            if (CurrentStatus == AnimatorStatus.Paused)
            {
                _timer.Resume();
            }
        }

        /// <summary>
        ///     Stops the animation and resets its status, resume is no longer possible
        /// </summary>
        public virtual void Stop()
        {
            _timer.Stop();
            lock (_tempPaths)
            {
                _tempPaths.Clear();
            }
            ActivePath = null;
            CurrentStatus = AnimatorStatus.Stopped;
            _tempReverseRepeat = false;
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="property">
        ///     The property to change
        /// </param>
        public virtual void Play(object targetObject, KnownProperties property)
        {
            Play(targetObject, property, null);
        }


        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="property">
        ///     The property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public virtual void Play(object targetObject, KnownProperties property, SafeInvoker endCallback)
        {
            Play(targetObject, property.ToString(), endCallback);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="frameCallback">
        ///     The callback to get invoked at each frame
        /// </param>
        public virtual void Play(SafeInvoker<float> frameCallback)
        {
            Play(frameCallback, (SafeInvoker<float>)null);
        }


        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="frameCallback">
        ///     The callback to get invoked at each frame
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public virtual void Play(SafeInvoker<float> frameCallback, SafeInvoker endCallback)
        {
            Stop();
            FrameCallback = frameCallback;
            EndCallback = endCallback;
            _timer.ResetClock();
            lock (_tempPaths)
            {
                _tempPaths.AddRange(_paths);
            }
            _timer.Start();
        }

        private void Elapsed(ulong millSinceBeginning = 0)
        {
            while (true)
            {
                lock (_tempPaths)
                {
                    if (_tempPaths != null && ActivePath == null && _tempPaths.Count > 0)
                    {
                        while (ActivePath == null)
                        {
                            if (_tempReverseRepeat)
                            {
                                ActivePath = _tempPaths.LastOrDefault();
                                _tempPaths.RemoveAt(_tempPaths.Count - 1);
                            }
                            else
                            {
                                ActivePath = _tempPaths.FirstOrDefault();
                                _tempPaths.RemoveAt(0);
                            }
                            _timer.ResetClock();
                            millSinceBeginning = 0;
                        }
                    }
                    var ended = ActivePath == null;
                    if (ActivePath != null)
                    {
                        if (!_tempReverseRepeat && millSinceBeginning < ActivePath.Delay)
                        {
                            CurrentStatus = AnimatorStatus.OnHold;
                            return;
                        }
                        if (millSinceBeginning - (!_tempReverseRepeat ? ActivePath.Delay : 0) <= ActivePath.Duration)
                        {
                            if (CurrentStatus != AnimatorStatus.Playing)
                            {
                                CurrentStatus = AnimatorStatus.Playing;
                            }
                            var value = ActivePath.Function(_tempReverseRepeat ? ActivePath.Duration - millSinceBeginning : millSinceBeginning - ActivePath.Delay, ActivePath.Start, ActivePath.Change, ActivePath.Duration);
                            FrameCallback.Invoke(value);
                            return;
                        }
                        if (CurrentStatus == AnimatorStatus.Playing)
                        {
                            if (_tempPaths.Count == 0)
                            {
                                // For the last path, we make sure that control is in end point
                                FrameCallback.Invoke(_tempReverseRepeat ? ActivePath.Start : ActivePath.End);
                                ended = true;
                            }
                            else
                            {
                                if ((_tempReverseRepeat && ActivePath.Delay > 0) || !_tempReverseRepeat && _tempPaths.FirstOrDefault().Delay > 0)
                                {
                                    // Or if the next path or this one in revese order has a delay
                                    FrameCallback.Invoke(_tempReverseRepeat ? ActivePath.Start : ActivePath.End);
                                }
                            }
                        }
                        if (_tempReverseRepeat && (millSinceBeginning - ActivePath.Duration) < ActivePath.Delay)
                        {
                            CurrentStatus = AnimatorStatus.OnHold;
                            return;
                        }
                        ActivePath = null;
                    }
                    if (!ended)
                    {
                        return;
                    }
                }
                if (Repeat)
                {
                    lock (_tempPaths)
                    {
                        _tempPaths.AddRange(_paths);
                        _tempReverseRepeat = ReverseRepeat && !_tempReverseRepeat;
                    }
                    millSinceBeginning = 0;
                    continue;
                }
                Stop();
                EndCallback.Invoke();
                break;
            }
        }
    }
    #endregion
    #region Animator2D
    /// <summary>
    ///     The two dimensional animator class, useful for animating values
    ///     created from two underlying values
    /// </summary>
    public class Animator2D : IAnimator
    {
        /// <summary>
        ///     The known two dimensional properties of WinForm controls
        /// </summary>
        public enum KnownProperties
        {
            /// <summary>
            ///     The property named 'Size' of the object
            /// </summary>
            Size,

            /// <summary>
            ///     The property named 'Location' of the object
            /// </summary>
            Location
        }

        private readonly List<Path2D> _paths = new List<Path2D>();


        /// <summary>
        ///     The callback to get invoked at the end of the animation
        /// </summary>
        protected SafeInvoker EndCallback;

        /// <summary>
        ///     The callback to get invoked at each frame
        /// </summary>
        protected SafeInvoker<Float2D> FrameCallback;

        /// <summary>
        ///     A boolean value indicating if the EndInvoker already invoked
        /// </summary>
        protected bool IsEnded;

        /// <summary>
        ///     The target object to change the property of
        /// </summary>
        protected object TargetObject;

        /// <summary>
        ///     The latest horizontal value
        /// </summary>
        protected float? XValue;

        /// <summary>
        ///     The latest vertical value
        /// </summary>
        protected float? YValue;


        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator2D" /> class.
        /// </summary>
        public Animator2D()
            : this(new Path2D[] { })
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator2D" /> class.
        /// </summary>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator2D(FPSLimiterKnownValues fpsLimiter)
            : this(new Path2D[] { }, fpsLimiter)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator2D" /> class.
        /// </summary>
        /// <param name="path">
        ///     The path of the animation
        /// </param>
        public Animator2D(Path2D path)
            : this(new[] { path })
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator2D" /> class.
        /// </summary>
        /// <param name="path">
        ///     The path of the animation
        /// </param>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator2D(Path2D path, FPSLimiterKnownValues fpsLimiter)
            : this(new[] { path }, fpsLimiter)
        {
        }


        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator2D" /> class.
        /// </summary>
        /// <param name="paths">
        ///     An array containing the list of paths of the animation
        /// </param>
        public Animator2D(Path2D[] paths)
            : this(paths, FPSLimiterKnownValues.LimitThirty)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator2D" /> class.
        /// </summary>
        /// <param name="paths">
        ///     An array containing the list of paths of the animation
        /// </param>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator2D(Path2D[] paths, FPSLimiterKnownValues fpsLimiter)
        {
            HorizontalAnimator = new Animator(fpsLimiter);
            VerticalAnimator = new Animator(fpsLimiter);
            Paths = paths;
        }

        /// <summary>
        ///     Gets the currently active path.
        /// </summary>
        Path2D ActivePath = new Path2D(HorizontalAnimator.ActivePath, VerticalAnimator.ActivePath);

        /// <summary>
        ///     Gets the horizontal animator.
        /// </summary>
        public static Animator HorizontalAnimator { get; set; }

        /// <summary>
        ///     Gets the vertical animator.
        /// </summary>
        public static Animator VerticalAnimator { get; protected set; }

        /// <summary>
        ///     Gets or sets an array containing the list of paths of the animation
        /// </summary>
        /// <exception cref="InvalidOperationException">Animation is running</exception>
        public Path2D[] Paths
        {
            get { return _paths.ToArray(); }
            set
            {
                if (CurrentStatus == AnimatorStatus.Stopped)
                {
                    _paths.Clear();
                    _paths.AddRange(value);
                    var pathsH = new List<Path>();
                    var pathsV = new List<Path>();
                    foreach (var p in value)
                    {
                        pathsH.Add(p.HorizontalPath);
                        pathsV.Add(p.VerticalPath);
                    }
                    HorizontalAnimator.Paths = pathsH.ToArray();
                    VerticalAnimator.Paths = pathsV.ToArray();
                }
                else
                {
                    throw new InvalidOperationException("Animation is running.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation after its ending
        /// </summary>
        public virtual bool Repeat
        {
            get { return HorizontalAnimator.Repeat && VerticalAnimator.Repeat; }

            set { HorizontalAnimator.Repeat = VerticalAnimator.Repeat = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation in reverse after its ending.
        /// </summary>
        public virtual bool ReverseRepeat
        {
            get { return HorizontalAnimator.ReverseRepeat && VerticalAnimator.ReverseRepeat; }

            set { HorizontalAnimator.ReverseRepeat = VerticalAnimator.ReverseRepeat = value; }
        }

        /// <summary>
        ///     Gets the current status of the animation
        /// </summary>
        public virtual AnimatorStatus CurrentStatus
        {
            get
            {
                if (HorizontalAnimator.CurrentStatus == AnimatorStatus.Stopped
                    && VerticalAnimator.CurrentStatus == AnimatorStatus.Stopped)
                {
                    return AnimatorStatus.Stopped;
                }

                if (HorizontalAnimator.CurrentStatus == AnimatorStatus.Paused
                    && VerticalAnimator.CurrentStatus == AnimatorStatus.Paused)
                {
                    return AnimatorStatus.Paused;
                }

                if (HorizontalAnimator.CurrentStatus == AnimatorStatus.OnHold
                    && VerticalAnimator.CurrentStatus == AnimatorStatus.OnHold)
                {
                    return AnimatorStatus.OnHold;
                }

                return AnimatorStatus.Playing;
            }
        }

        /// <summary>
        ///     Pause the animation
        /// </summary>
        public virtual void Pause()
        {
            if (CurrentStatus == AnimatorStatus.OnHold || CurrentStatus == AnimatorStatus.Playing)
            {
                HorizontalAnimator.Pause();
                VerticalAnimator.Pause();
            }
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        public virtual void Play(object targetObject, string propertyName)
        {
            Play(targetObject, propertyName, null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public virtual void Play(object targetObject, string propertyName, SafeInvoker endCallback)
        {
            TargetObject = targetObject;
            var prop = TargetObject.GetType()
                .GetProperty(
                    propertyName,
                    BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance |
                    BindingFlags.SetProperty);
            if (prop == null) return;

            Play(
                new SafeInvoker<Float2D>(
                    value =>
                        prop.SetValue(TargetObject, Convert.ChangeType(value, prop.PropertyType), null),
                    TargetObject),
                endCallback);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        public virtual void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter)
        {
            Play(targetObject, propertySetter, null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        public virtual void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter, SafeInvoker endCallback)
        {
            if (propertySetter == null)
                return;
            TargetObject = targetObject;

            var property =
                ((propertySetter.Body as MemberExpression) ??
                 (((UnaryExpression)propertySetter.Body).Operand as MemberExpression)).Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException();
            }

            Play(
                new SafeInvoker<Float2D>(
                    value =>
                        property.SetValue(TargetObject, Convert.ChangeType(value, property.PropertyType), null),
                    TargetObject),
                endCallback);
        }

        /// <summary>
        ///     Resume the animation from where it paused
        /// </summary>
        public virtual void Resume()
        {
            if (CurrentStatus == AnimatorStatus.Paused)
            {
                HorizontalAnimator.Resume();
                VerticalAnimator.Resume();
            }
        }

        /// <summary>
        ///     Stops the animation and resets its status, resume is no longer possible
        /// </summary>
        public virtual void Stop()
        {
            HorizontalAnimator.Stop();
            VerticalAnimator.Stop();
            XValue = YValue = null;
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="property">
        ///     The property to change
        /// </param>
        public void Play(object targetObject, KnownProperties property)
        {
            Play(targetObject, property, null);
        }


        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="property">
        ///     The property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public void Play(object targetObject, KnownProperties property, SafeInvoker endCallback)
        {
            Play(targetObject, property.ToString(), endCallback);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="frameCallback">
        ///     The callback to get invoked at each frame
        /// </param>
        public void Play(SafeInvoker<Float2D> frameCallback)
        {
            Play(frameCallback, (SafeInvoker)null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="frameCallback">
        ///     The callback to get invoked at each frame
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public void Play(SafeInvoker<Float2D> frameCallback, SafeInvoker endCallback)
        {
            Stop();
            FrameCallback = frameCallback;
            EndCallback = endCallback;
            HorizontalAnimator.Play(
                new SafeInvoker<float>(
                    value =>
                    {
                        XValue = value;
                        InvokeSetter();
                    }),
                new SafeInvoker(InvokeFinisher));
            VerticalAnimator.Play(
                new SafeInvoker<float>(
                    value =>
                    {
                        YValue = value;
                        InvokeSetter();
                    }),
                new SafeInvoker(InvokeFinisher));
        }

        private void InvokeFinisher()
        {
            if (EndCallback != null && !IsEnded)
            {
                lock (EndCallback)
                {
                    if (CurrentStatus == AnimatorStatus.Stopped)
                    {
                        IsEnded = true;
                        EndCallback.Invoke();
                    }
                }
            }
        }

        private void InvokeSetter()
        {
            if (XValue != null && YValue != null)
            {
                FrameCallback.Invoke(new Float2D(XValue.Value, YValue.Value));
            }
        }
    }
    #endregion
    #region Animator3D
    /// <summary>
    ///     The three dimensional animator class, useful for animating values
    ///     created from three underlying values
    /// </summary>
    public class Animator3D : IAnimator
    {
        /// <summary>
        ///     The known three dimensional properties of WinForm controls
        /// </summary>
        public enum KnownProperties
        {
            /// <summary>
            ///     The property named 'BackColor' of the object
            /// </summary>
            BackColor,

            /// <summary>
            ///     The property named 'ForeColor' of the object
            /// </summary>
            ForeColor
        }

        private readonly List<Path3D> _paths = new List<Path3D>();

        /// <summary>
        ///     The callback to get invoked at the end of the animation
        /// </summary>
        protected SafeInvoker EndCallback;

        /// <summary>
        ///     The callback to get invoked at each frame
        /// </summary>
        protected SafeInvoker<Float3D> FrameCallback;

        /// <summary>
        ///     A boolean value indicating if the EndInvoker already invoked
        /// </summary>
        protected bool IsEnded;

        /// <summary>
        ///     The target object to change the property of
        /// </summary>
        protected object TargetObject;

        /// <summary>
        ///     The latest horizontal value
        /// </summary>
        protected float? XValue;

        /// <summary>
        ///     The latest vertical value
        /// </summary>
        protected float? YValue;

        /// <summary>
        ///     The latest depth value
        /// </summary>
        protected float? ZValue;


        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator3D" /> class.
        /// </summary>
        public Animator3D()
            : this(new Path3D[] { })
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator3D" /> class.
        /// </summary>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator3D(FPSLimiterKnownValues fpsLimiter)
            : this(new Path3D[] { }, fpsLimiter)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator3D" /> class.
        /// </summary>
        /// <param name="path">
        ///     The path of the animation
        /// </param>
        public Animator3D(Path3D path)
            : this(new[] { path })
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator3D" /> class.
        /// </summary>
        /// <param name="path">
        ///     The path of the animation
        /// </param>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator3D(Path3D path, FPSLimiterKnownValues fpsLimiter)
            : this(new[] { path }, fpsLimiter)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator3D" /> class.
        /// </summary>
        /// <param name="paths">
        ///     An array containing the list of paths of the animation
        /// </param>
        public Animator3D(Path3D[] paths)
            : this(paths, FPSLimiterKnownValues.LimitThirty)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Animator3D" /> class.
        /// </summary>
        /// <param name="paths">
        ///     An array containing the list of paths of the animation
        /// </param>
        /// <param name="fpsLimiter">
        ///     Limits the maximum frames per seconds
        /// </param>
        public Animator3D(Path3D[] paths, FPSLimiterKnownValues fpsLimiter)
        {
            HorizontalAnimator = new Animator(fpsLimiter);
            VerticalAnimator = new Animator(fpsLimiter);
            DepthAnimator = new Animator(fpsLimiter);
            Paths = paths;
        }

        /// <summary>
        ///     Gets the currently active path.
        /// </summary>
        public Path3D ActivePath = new Path3D(
            HorizontalAnimator.ActivePath,
            VerticalAnimator.ActivePath,
            DepthAnimator.ActivePath);

        /// <summary>
        ///     Gets the horizontal animator.
        /// </summary>
        public static Animator HorizontalAnimator { get; set; }

        /// <summary>
        ///     Gets the vertical animator.
        /// </summary>
        public static Animator VerticalAnimator { get; set; }

        /// <summary>
        ///     Gets the depth animator.
        /// </summary>
        public static Animator DepthAnimator { get; set; }


        /// <summary>
        ///     Gets or sets an array containing the list of paths of the animation
        /// </summary>
        /// <exception cref="InvalidOperationException">Animation is running</exception>
        public Path3D[] Paths
        {
            get { return _paths.ToArray(); }
            set
            {
                if (CurrentStatus == AnimatorStatus.Stopped)
                {
                    _paths.Clear();
                    _paths.AddRange(value);
                    var pathsX = new List<Path>();
                    var pathsY = new List<Path>();
                    var pathsZ = new List<Path>();
                    foreach (var p in value)
                    {
                        pathsX.Add(p.HorizontalPath);
                        pathsY.Add(p.VerticalPath);
                        pathsZ.Add(p.DepthPath);
                    }

                    HorizontalAnimator.Paths = pathsX.ToArray();
                    VerticalAnimator.Paths = pathsY.ToArray();
                    DepthAnimator.Paths = pathsZ.ToArray();
                }
                else
                {
                    throw new NotSupportedException("Animation is running.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation after its ending
        /// </summary>
        public virtual bool Repeat
        {
            get { return HorizontalAnimator.Repeat && VerticalAnimator.Repeat && DepthAnimator.Repeat; }

            set { HorizontalAnimator.Repeat = VerticalAnimator.Repeat = DepthAnimator.Repeat = value; }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation in reverse after its ending.
        /// </summary>
        public virtual bool ReverseRepeat
        {
            get
            {
                return HorizontalAnimator.ReverseRepeat && VerticalAnimator.ReverseRepeat
                       && DepthAnimator.ReverseRepeat;
            }

            set
            {
                HorizontalAnimator.ReverseRepeat =
                    VerticalAnimator.ReverseRepeat = DepthAnimator.ReverseRepeat = value;
            }
        }

        /// <summary>
        ///     Gets the current status of the animation
        /// </summary>
        public virtual AnimatorStatus CurrentStatus
        {
            get
            {
                if (HorizontalAnimator.CurrentStatus == AnimatorStatus.Stopped
                    && VerticalAnimator.CurrentStatus == AnimatorStatus.Stopped
                    && DepthAnimator.CurrentStatus == AnimatorStatus.Stopped)
                {
                    return AnimatorStatus.Stopped;
                }

                if (HorizontalAnimator.CurrentStatus == AnimatorStatus.Paused
                    && VerticalAnimator.CurrentStatus == AnimatorStatus.Paused
                    && DepthAnimator.CurrentStatus == AnimatorStatus.Paused)
                {
                    return AnimatorStatus.Paused;
                }

                if (HorizontalAnimator.CurrentStatus == AnimatorStatus.OnHold
                    && VerticalAnimator.CurrentStatus == AnimatorStatus.OnHold
                    && DepthAnimator.CurrentStatus == AnimatorStatus.OnHold)
                {
                    return AnimatorStatus.OnHold;
                }

                return AnimatorStatus.Playing;
            }
        }

        /// <summary>
        ///     Pause the animation
        /// </summary>
        public virtual void Pause()
        {
            if (CurrentStatus == AnimatorStatus.OnHold || CurrentStatus == AnimatorStatus.Playing)
            {
                HorizontalAnimator.Pause();
                VerticalAnimator.Pause();
                DepthAnimator.Pause();
            }
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        public virtual void Play(object targetObject, string propertyName)
        {
            Play(targetObject, propertyName, null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public virtual void Play(object targetObject, string propertyName, SafeInvoker endCallback)
        {
            TargetObject = targetObject;
            var prop = TargetObject.GetType()
                .GetProperty(
                    propertyName,
                    BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance |
                    BindingFlags.SetProperty);
            if (prop == null) return;

            Play(
                new SafeInvoker<Float3D>(
                    value =>
                        prop.SetValue(TargetObject, Convert.ChangeType(value, prop.PropertyType), null),
                    TargetObject),
                endCallback);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        public virtual void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter)
        {
            Play(targetObject, propertySetter, null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        public virtual void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter, SafeInvoker endCallback)
        {
            if (propertySetter == null)
                return;
            TargetObject = targetObject;

            var property =
                ((propertySetter.Body as MemberExpression) ??
                 (((UnaryExpression)propertySetter.Body).Operand as MemberExpression)).Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException();
            }

            Play(
                new SafeInvoker<Float3D>(
                    value =>
                        property.SetValue(TargetObject, Convert.ChangeType(value, property.PropertyType), null),
                    TargetObject),
                endCallback);
        }

        /// <summary>
        ///     Resume the animation from where it paused
        /// </summary>
        public virtual void Resume()
        {
            if (CurrentStatus == AnimatorStatus.Paused)
            {
                HorizontalAnimator.Resume();
                VerticalAnimator.Resume();
                DepthAnimator.Resume();
            }
        }

        /// <summary>
        ///     Stops the animation and resets its status, resume is no longer possible
        /// </summary>
        public virtual void Stop()
        {
            HorizontalAnimator.Stop();
            VerticalAnimator.Stop();
            DepthAnimator.Stop();
            XValue = YValue = ZValue = null;
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="property">
        ///     The property to change
        /// </param>
        public void Play(object targetObject, KnownProperties property)
        {
            Play(targetObject, property, null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="property">
        ///     The property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public void Play(object targetObject, KnownProperties property, SafeInvoker endCallback)
        {
            Play(targetObject, property.ToString(), endCallback);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="frameCallback">
        ///     The callback to get invoked at each frame
        /// </param>
        public void Play(SafeInvoker<Float3D> frameCallback)
        {
            Play(frameCallback, (SafeInvoker)null);
        }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="frameCallback">
        ///     The callback to get invoked at each frame
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        public void Play(SafeInvoker<Float3D> frameCallback, SafeInvoker endCallback)
        {
            Stop();
            FrameCallback = frameCallback;
            EndCallback = endCallback;
            IsEnded = false;
            HorizontalAnimator.Play(
                new SafeInvoker<float>(
                    value =>
                    {
                        XValue = value;
                        InvokeSetter();
                    }),
                new SafeInvoker(InvokeFinisher));
            VerticalAnimator.Play(
                new SafeInvoker<float>(
                    value =>
                    {
                        YValue = value;
                        InvokeSetter();
                    }),
                new SafeInvoker(InvokeFinisher));
            DepthAnimator.Play(
                new SafeInvoker<float>(
                    value =>
                    {
                        ZValue = value;
                        InvokeSetter();
                    }),
                new SafeInvoker(InvokeFinisher));
        }

        private void InvokeFinisher()
        {
            if (EndCallback != null && !IsEnded)
            {
                lock (EndCallback)
                {
                    if (CurrentStatus == AnimatorStatus.Stopped)
                    {
                        IsEnded = true;
                        EndCallback.Invoke();
                    }
                }
            }
        }

        private void InvokeSetter()
        {
            if (XValue != null && YValue != null && ZValue != null)
            {
                FrameCallback.Invoke(new Float3D(XValue.Value, YValue.Value, ZValue.Value));
            }
        }
    }
    #endregion
    #region AnimatorStatus
    /// <summary>
    ///     The possible statuses for an animator instance
    /// </summary>
    public enum AnimatorStatus
    {
        /// <summary>
        ///     Animation is stopped
        /// </summary>
        Stopped,

        /// <summary>
        ///     Animation is now playing
        /// </summary>
        Playing,

        /// <summary>
        ///     Animation is now on hold for path delay, consider this value as playing
        /// </summary>
        OnHold,

        /// <summary>
        ///     Animation is paused
        /// </summary>
        Paused
    }
    #endregion
    #region Float2D
    /// <summary>
    ///     The Float2D class contains two <see langword="float" /> values and
    ///     represents a point in a 2D plane
    /// </summary>
    public class Float2D : IConvertible, IEquatable<Float2D>, IEquatable<Point>, IEquatable<PointF>, IEquatable<Size>,
        IEquatable<SizeF>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Float2D" /> class.
        /// </summary>
        /// <param name="x">
        ///     The horizontal value
        /// </param>
        /// <param name="y">
        ///     The vertical value
        /// </param>
        public Float2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Float2D" /> class.
        /// </summary>
        public Float2D()
            : this(default(float), default(float))
        {
        }

        /// <summary>
        ///     Gets the horizontal value of the point
        /// </summary>
        public float X { get; set; }

        /// <summary>
        ///     Gets the vertical value of the point
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        ///     Returns the <see cref="T:System.TypeCode" /> for this instance.
        /// </summary>
        /// <returns>
        ///     The enumerated constant that is the <see cref="T:System.TypeCode" /> of the class or value type that implements
        ///     this interface.
        /// </returns>
        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting
        ///     information.
        /// </summary>
        /// <returns>
        ///     A Boolean value equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public bool ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 8-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public byte ToByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent Unicode character using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     A Unicode character equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent double-precision floating-point number using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A double-precision floating-point number equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public double ToDouble(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 16-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public short ToInt16(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 32-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public int ToInt32(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 64-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public long ToInt64(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 8-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent single-precision floating-point number using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A single-precision floating-point number equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public float ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 16-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 32-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public uint ToUInt32(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 64-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent <see cref="T:System.String" /> using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> instance equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        public string ToString(IFormatProvider provider)
        {
            return ToString();
        }

        /// <summary>
        ///     Converts the value of this instance to an <see cref="T:System.Object" /> of the specified
        ///     <see cref="T:System.Type" /> that has an equivalent value, using the specified culture-specific formatting
        ///     information.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to
        ///     the value of this instance.
        /// </returns>
        /// <param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted. </param>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(Point))
            {
                return (Point)this;
            }
            if (conversionType == typeof(Size))
            {
                return (Size)this;
            }
            if (conversionType == typeof(PointF))
            {
                return (PointF)this;
            }
            if (conversionType == typeof(SizeF))
            {
                return (SizeF)this;
            }
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Float2D other)
        {
            return this == other;
        }

        /// <summary>
        ///     Indicates whether the current object is equal to a <see cref="Point" /> object.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Point other)
        {
            return this == other;
        }

        /// <summary>
        ///     Indicates whether the current object is equal to a <see cref="PointF" /> object.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(PointF other)
        {
            return this == other;
        }

        /// <summary>
        ///     Indicates whether the current object is equal to a <see cref="Size" /> object.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Size other)
        {
            return this == other;
        }

        /// <summary>
        ///     Indicates whether the current object is equal to a <see cref="SizeF" /> object.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(SizeF other)
        {
            return this == other;
        }

        /// <summary>
        ///     Determines whether the specified <see cref="T:System.Object" /> is equal to the current
        ///     <see cref="T:System.Object" />.
        /// </summary>
        /// <returns>
        ///     true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />;
        ///     otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var conversionType = obj.GetType();
            if (conversionType == typeof(Point))
            {
                return this == (Point)obj;
            }
            if (conversionType == typeof(PointF))
            {
                return this == (PointF)obj;
            }
            if (conversionType == typeof(Size))
            {
                return this == (Size)obj;
            }
            if (conversionType == typeof(SizeF))
            {
                return this == (SizeF)obj;
            }
            return obj.GetType() == GetType() && Equals((Float2D)obj);
        }

        /// <summary>
        ///     Serves as a hash function for a particular type. This code will change of the values of the X and Y changes. Make
        ///     sure to not change the values while stored in a hash dependent data structure.
        /// </summary>
        /// <returns>
        ///     A hash code for the current <see cref="Float2D" />.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                // ReSharper disable NonReadonlyMemberInGetHashCode
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
                // ReSharper restore NonReadonlyMemberInGetHashCode
            }
        }

        /// <summary>
        ///     Compares two <see cref="Float2D" /> objects for equality
        /// </summary>
        /// <param name="left">Left <see cref="Float2D" /> object</param>
        /// <param name="right">Right <see cref="Float2D" /> object</param>
        /// <returns>true if both objects are equal, otherwise false</returns>
        public static bool operator ==(Float2D left, Float2D right)
        {
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return ReferenceEquals(left, null) && ReferenceEquals(right, null);
            }
            // ReSharper disable CompareOfFloatsByEqualityOperator
            return ReferenceEquals(left, right) || ((double)(left.X) == right.X && (double)(left.Y) == right.Y);
            // ReSharper restore CompareOfFloatsByEqualityOperator
        }

        /// <summary>
        ///     Compares two <see cref="Float2D" /> objects for in-equality
        /// </summary>
        /// <param name="left">Left <see cref="Float2D" /> object</param>
        /// <param name="right">Right <see cref="Float2D" /> object</param>
        /// <returns>false if both objects are equal, otherwise true</returns>
        public static bool operator !=(Float2D left, Float2D right)
        {
            return !(left == right);
        }

        /// <summary>
        ///     Represents the values as an instance of the <see cref="Size" /> class
        /// </summary>
        /// <param name="float2D">
        ///     The <see cref="Float2D" /> class to convert
        /// </param>
        /// <returns>
        ///     A new instance of the <see cref="Size" /> class representing the values in the <see cref="Float2D" /> instance
        /// </returns>
        public static implicit operator Size(Float2D float2D)
        {
            return new Size((int)float2D.X, (int)float2D.Y);
        }

        /// <summary>
        ///     Represents the values as an instance of the <see cref="Point" /> class
        /// </summary>
        /// <param name="float2D">
        ///     The <see cref="Float2D" /> class to convert
        /// </param>
        /// <returns>
        ///     A new instance of the <see cref="Point" /> class representing the values in the <see cref="Float2D" /> instance
        /// </returns>
        public static implicit operator Point(Float2D float2D)
        {
            return new Point((int)float2D.X, (int)float2D.Y);
        }


        /// <summary>
        ///     Represents the values as an instance of the <see cref="SizeF" /> class
        /// </summary>
        /// <param name="float2D">
        ///     The <see cref="Float2D" /> class to convert
        /// </param>
        /// <returns>
        ///     A new instance of the <see cref="SizeF" /> class representing the values in the <see cref="Float2D" /> instance
        /// </returns>
        public static implicit operator SizeF(Float2D float2D)
        {
            return new SizeF(float2D.X, float2D.Y);
        }

        /// <summary>
        ///     Represents the values as an instance of the <see cref="PointF" /> class
        /// </summary>
        /// <param name="float2D">
        ///     The <see cref="Float2D" /> class to convert
        /// </param>
        /// <returns>
        ///     A new instance of the <see cref="PointF" /> class representing the values in the <see cref="Float2D" /> instance
        /// </returns>
        public static implicit operator PointF(Float2D float2D)
        {
            return new PointF(float2D.X, float2D.Y);
        }

        /// <summary>
        ///     Returns a string that represents the current <see cref="Float2D" />.
        /// </summary>
        /// <returns>
        ///     A string that represents the current <see cref="Float2D" />.
        /// </returns>
        public override string ToString()
        {
            return "(" + X.ToString("0.00") + "," + Y.ToString("0.00") + ")";
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from a <see cref="Point" /> instance
        /// </summary>
        /// <param name="point">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D FromPoint(Point point)
        {
            return new Float2D(point.X, point.Y);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from a <see cref="PointF" /> instance
        /// </summary>
        /// <param name="point">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D FromPoint(PointF point)
        {
            return new Float2D(point.X, point.Y);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from a <see cref="Size" /> instance
        /// </summary>
        /// <param name="size">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D FromSize(Size size)
        {
            return new Float2D(size.Width, size.Height);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from a <see cref="SizeF" /> instance
        /// </summary>
        /// <param name="size">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D FromSize(SizeF size)
        {
            return new Float2D(size.Width, size.Height);
        }
    }
    #endregion
    #region Float3D
    /// <summary>
    ///     The Float3D class contains two <see langword="float" /> values and
    ///     represents a point in a 3D plane
    /// </summary>
    public class Float3D : IConvertible, IEquatable<Float3D>, IEquatable<Color>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Float3D" /> class.
        /// </summary>
        /// <param name="x">
        ///     The horizontal value
        /// </param>
        /// <param name="y">
        ///     The vertical value
        /// </param>
        /// <param name="z">
        ///     The depth value
        /// </param>
        public Float3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Float3D" /> class.
        /// </summary>
        public Float3D()
            : this(default(float), default(float), default(float))
        {
        }

        /// <summary>
        ///     Gets the horizontal value of the point
        /// </summary>
        public float X { get; set; }

        /// <summary>
        ///     Gets the vertical value of the point
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        ///     Gets the depth value of the point
        /// </summary>
        public float Z { get; set; }

        /// <summary>
        ///     Returns the <see cref="T:System.TypeCode" /> for this instance.
        /// </summary>
        /// <returns>
        ///     The enumerated constant that is the <see cref="T:System.TypeCode" /> of the class or value type that implements
        ///     this interface.
        /// </returns>
        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting
        ///     information.
        /// </summary>
        /// <returns>
        ///     A Boolean value equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public bool ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 8-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public byte ToByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent Unicode character using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     A Unicode character equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent double-precision floating-point number using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A double-precision floating-point number equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public double ToDouble(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 16-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public short ToInt16(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 32-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public int ToInt32(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 64-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public long ToInt64(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 8-bit signed integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent single-precision floating-point number using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A single-precision floating-point number equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public float ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 16-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 32-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public uint ToUInt32(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }


        /// <summary>
        ///     Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <returns>
        ///     An 64-bit unsigned integer equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        /// <exception cref="InvalidCastException">This method is not supported</exception>
        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Converts the value of this instance to an equivalent <see cref="T:System.String" /> using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> instance equivalent to the value of this instance.
        /// </returns>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        public string ToString(IFormatProvider provider)
        {
            return ToString();
        }

        /// <summary>
        ///     Converts the value of this instance to an <see cref="T:System.Object" /> of the specified
        ///     <see cref="T:System.Type" /> that has an equivalent value, using the specified culture-specific formatting
        ///     information.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to
        ///     the value of this instance.
        /// </returns>
        /// <param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted. </param>
        /// <param name="provider">
        ///     An <see cref="T:System.IFormatProvider" /> interface implementation that supplies
        ///     culture-specific formatting information.
        /// </param>
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(Color))
            {
                return (Color)this;
            }
            throw new InvalidCastException();
        }

        /// <summary>
        ///     Indicates whether the current object is equal to a <see cref="Color" /> object.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Color other)
        {
            return this == other;
        }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Float3D other)
        {
            return this == other;
        }

        /// <summary>
        ///     Determines whether the specified <see cref="T:System.Object" /> is equal to the current
        ///     <see cref="T:System.Object" />.
        /// </summary>
        /// <returns>
        ///     true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />;
        ///     otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var conversionType = obj.GetType();
            if (conversionType == typeof(Color))
            {
                return this == (Color)obj;
            }
            return obj.GetType() == GetType() && Equals((Float3D)obj);
        }

        /// <summary>
        ///     Serves as a hash function for a particular type. This code will change of the values of the X and Y changes. Make
        ///     sure to not change the values while stored in a hash dependent data structure.
        /// </summary>
        /// <returns>
        ///     A hash code for the current <see cref="Float3D" />.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                // ReSharper disable NonReadonlyMemberInGetHashCode
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
                // ReSharper restore NonReadonlyMemberInGetHashCode
            }
        }


        /// <summary>
        ///     Compares two <see cref="Float3D" /> objects for equality
        /// </summary>
        /// <param name="left">Left <see cref="Float3D" /> object</param>
        /// <param name="right">Right <see cref="Float3D" /> object</param>
        /// <returns>true if both objects are equal, otherwise false</returns>
        public static bool operator ==(Float3D left, Float3D right)
        {
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return ReferenceEquals(left, null) && ReferenceEquals(right, null);
            }
            // ReSharper disable CompareOfFloatsByEqualityOperator
            return ReferenceEquals(left, right) ||
                   ((double)(left.X) == right.X && (double)(left.Y) == right.Y && (double)(left.Z) == right.Z);
            // ReSharper restore CompareOfFloatsByEqualityOperator
        }

        /// <summary>
        ///     Compares two <see cref="Float3D" /> objects for in-equality
        /// </summary>
        /// <param name="left">Left <see cref="Float3D" /> object</param>
        /// <param name="right">Right <see cref="Float3D" /> object</param>
        /// <returns>false if both objects are equal, otherwise true</returns>
        public static bool operator !=(Float3D left, Float3D right)
        {
            return !(left == right);
        }

        /// <summary>
        ///     Represents the values as an instance of the <see cref="Color" /> class
        /// </summary>
        /// <param name="float3D">
        ///     The <see cref="Float3D" /> class to convert
        /// </param>
        /// <returns>
        ///     A new instance of the <see cref="Color" /> class representing the values in the <see cref="Float3D" /> instance
        /// </returns>
        public static implicit operator Color(Float3D float3D)
        {
            return Color.FromArgb((int)float3D.X, (int)float3D.Y, (int)float3D.Z);
        }

        /// <summary>
        ///     Returns a string that represents the current <see cref="Float3D" />.
        /// </summary>
        /// <returns>
        ///     A string that represents the current <see cref="Float3D" />.
        /// </returns>
        public override string ToString()
        {
            return "(" + X.ToString("0.00") + "," + Y.ToString("0.00") + "," + Z.ToString("0.00") + ")";
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float3D" /> class from a <see cref="Color" /> instance
        /// </summary>
        /// <param name="color">The object to create the <see cref="Float3D" /> instance from</param>
        /// <returns>The newly created <see cref="Float3D" /> instance</returns>
        public static Float3D FromColor(Color color)
        {
            return new Float3D(color.R, color.G, color.B);
        }
    }
    #endregion
    #region FloatExtensions
    /// <summary>
    ///     Contains public extension methods about Float2D and Fload3D classes
    /// </summary>
    public static class FloatExtensions
    {
        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="point">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this Point point)
        {
            return Float2D.FromPoint(point);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="point">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this PointF point)
        {
            return Float2D.FromPoint(point);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="size">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this Size size)
        {
            return Float2D.FromSize(size);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="size">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this SizeF size)
        {
            return Float2D.FromSize(size);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float3D" /> class from this instance
        /// </summary>
        /// <param name="color">The object to create the <see cref="Float3D" /> instance from</param>
        /// <returns>The newly created <see cref="Float3D" /> instance</returns>
        public static Float3D ToFloat3D(this Color color)
        {
            return Float3D.FromColor(color);
        }
    }
    #endregion
    #region FPSLimiterKnownValues
    /// <summary>
    ///     FPS limiter known values
    /// </summary>
    public enum FPSLimiterKnownValues
    {
        /// <summary>
        ///     Limits maximum frames per second to 10fps
        /// </summary>
        LimitTen = 10,

        /// <summary>
        ///     Limits maximum frames per second to 20fps
        /// </summary>
        LimitTwenty = 20,

        /// <summary>
        ///     Limits maximum frames per second to 30fps
        /// </summary>
        LimitThirty = 30,

        /// <summary>
        ///     Limits maximum frames per second to 60fps
        /// </summary>
        LimitSixty = 60,

        /// <summary>
        ///     Limits maximum frames per second to 100fps
        /// </summary>
        LimitOneHundred = 100,

        /// <summary>
        ///     Limits maximum frames per second to 200fps
        /// </summary>
        LimitTwoHundred = 200,

        /// <summary>
        ///     Adds no limit to the number of frames per second
        /// </summary>
        NoFPSLimit = -1
    }
    #endregion
    #region IAnimator
    /// <summary>
    ///     The base interface for any Animator class, custom or build-in
    /// </summary>
    public interface IAnimator
    {
        /// <summary>
        ///     Gets the current status of the animation
        /// </summary>
        AnimatorStatus CurrentStatus { get; }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation after its ending
        /// </summary>
        bool Repeat { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether animator should repeat the animation in reverse after its ending.
        /// </summary>
        bool ReverseRepeat { get; set; }

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        void Play(object targetObject, string propertyName);

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertyName">
        ///     The name of the property to change
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        void Play(object targetObject, string propertyName, SafeInvoker endCallback);

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter);

        /// <summary>
        ///     Starts the playing of the animation
        /// </summary>
        /// <param name="targetObject">
        ///     The target object to change the property
        /// </param>
        /// <param name="propertySetter">
        ///     The expression that represents the property of the target object
        /// </param>
        /// <param name="endCallback">
        ///     The callback to get invoked at the end of the animation
        /// </param>
        /// <typeparam name="T">
        ///     Any object containing a property
        /// </typeparam>
        void Play<T>(T targetObject, Expression<Func<T, object>> propertySetter, SafeInvoker endCallback);

        /// <summary>
        ///     Resume the animation from where it paused
        /// </summary>
        void Resume();

        /// <summary>
        ///     Stops the animation and resets its status, resume is no longer possible
        /// </summary>
        void Stop();

        /// <summary>
        ///     Pause the animation
        /// </summary>
        void Pause();
    }
    #endregion
    #region KnownAnimationFunctions
    /// <summary>
    ///     Contains a list of all known animation functions
    /// </summary>
    public enum KnownAnimationFunctions
    {
        /// <summary>
        ///     No known animation function
        /// </summary>
        None,

        /// <summary>
        ///     The cubic ease-in animation function.
        /// </summary>
        CubicEaseIn,

        /// <summary>
        ///     The cubic ease-in and ease-out animation function.
        /// </summary>
        CubicEaseInOut,

        /// <summary>
        ///     The cubic ease-out animation function.
        /// </summary>
        CubicEaseOut,

        /// <summary>
        ///     The liner animation function.
        /// </summary>
        Liner,

        /// <summary>
        ///     The circular ease-in and ease-out animation function.
        /// </summary>
        CircularEaseInOut,

        /// <summary>
        ///     The circular ease-in animation function.
        /// </summary>
        CircularEaseIn,

        /// <summary>
        ///     The circular ease-out animation function.
        /// </summary>
        CircularEaseOut,

        /// <summary>
        ///     The quadratic ease-in animation function.
        /// </summary>
        QuadraticEaseIn,

        /// <summary>
        ///     The quadratic ease-out animation function.
        /// </summary>
        QuadraticEaseOut,

        /// <summary>
        ///     The quadratic ease-in and ease-out animation function.
        /// </summary>
        QuadraticEaseInOut,

        /// <summary>
        ///     The quartic ease-in animation function.
        /// </summary>
        QuarticEaseIn,

        /// <summary>
        ///     The quartic ease-out animation function.
        /// </summary>
        QuarticEaseOut,

        /// <summary>
        ///     The quartic ease-in and ease-out animation function.
        /// </summary>
        QuarticEaseInOut,

        /// <summary>
        ///     The quintic ease-in and ease-out animation function.
        /// </summary>
        QuinticEaseInOut,

        /// <summary>
        ///     The quintic ease-in animation function.
        /// </summary>
        QuinticEaseIn,

        /// <summary>
        ///     The quintic ease-out animation function.
        /// </summary>
        QuinticEaseOut,

        /// <summary>
        ///     The sinusoidal ease-in animation function.
        /// </summary>
        SinusoidalEaseIn,

        /// <summary>
        ///     The sinusoidal ease-out animation function.
        /// </summary>
        SinusoidalEaseOut,

        /// <summary>
        ///     The sinusoidal ease-in and ease-out animation function.
        /// </summary>
        SinusoidalEaseInOut,

        /// <summary>
        ///     The exponential ease-in animation function.
        /// </summary>
        ExponentialEaseIn,

        /// <summary>
        ///     The exponential ease-out animation function.
        /// </summary>
        ExponentialEaseOut,

        /// <summary>
        ///     The exponential ease-in and ease-out animation function.
        /// </summary>
        ExponentialEaseInOut
    }
    #endregion
    #region Path
    /// <summary>
    ///     The Path class is a representation of a line in a 1D plane and the
    ///     speed in which the animator plays it
    /// </summary>
    public class Path
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        public Path()
            : this(default(float), default(float), default(ulong), 0, null)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting value
        /// </param>
        /// <param name="end">
        ///     The ending value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path(float start, float end, ulong duration)
            : this(start, end, duration, 0, null)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting value
        /// </param>
        /// <param name="end">
        ///     The ending value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path(float start, float end, ulong duration, AnimationFunctions.Function function)
            : this(start, end, duration, 0, function)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting value
        /// </param>
        /// <param name="end">
        ///     The ending value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path(float start, float end, ulong duration, ulong delay)
            : this(start, end, duration, delay, null)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting value
        /// </param>
        /// <param name="end">
        ///     The ending value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path(float start, float end, ulong duration, ulong delay, AnimationFunctions.Function function)
        {
            Start = start;
            End = end;
            Function = function ?? AnimationFunctions.Liner;
            Duration = duration;
            Delay = delay;
        }

        /// <summary>
        ///     Gets the difference of starting and ending values
        /// </summary>
        public float Change = end - start;

        /// <summary>
        ///     Gets or sets the starting delay
        /// </summary>
        public ulong Delay { get; set; }

        /// <summary>
        ///     Gets or sets the duration in milliseconds
        /// </summary>
        public ulong Duration { get; set; }

        /// <summary>
        ///     Gets or sets the ending value
        /// </summary>

        public static float end;
        public float End
        {
            get { return end; }
            set
            {
                end = value;
            }
        }

        /// <summary>
        ///     Gets or sets the animation function
        /// </summary>
        public AnimationFunctions.Function Function { get; set; }

        /// <summary>
        ///     Gets or sets the starting value
        /// </summary>

        public static float start;
        public float Start
        {
            get { return start; }
            set
            {
                start = value;
            }
        }

        /// <summary>
        ///     Creates and returns a new <see cref="Path" /> based on the current path but in reverse order
        /// </summary>
        /// <returns>
        ///     A new <see cref="Path" /> which is the reverse of the current <see cref="Path" />
        /// </returns>
        public Path Reverse()
        {
            return new Path(End, Start, Duration, Delay, Function);
        }
    }
    #endregion
    #region Path2D
    /// <summary>
    ///     The Path2D class is a representation of a line in a 2D plane and the
    ///     speed in which the animator plays it
    /// </summary>
    public class Path2D
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(
            float startX,
            float endX,
            float startY,
            float endY,
            ulong duration,
            ulong delay,
            AnimationFunctions.Function function)
            : this(new Path(startX, endX, duration, delay, function), new Path(startY, endY, duration, delay, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(
            float startX,
            float endX,
            float startY,
            float endY,
            ulong duration,
            ulong delay)
            : this(new Path(startX, endX, duration, delay), new Path(startY, endY, duration, delay))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(
            float startX,
            float endX,
            float startY,
            float endY,
            ulong duration,
            AnimationFunctions.Function function)
            : this(new Path(startX, endX, duration, function), new Path(startY, endY, duration, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(
            float startX,
            float endX,
            float startY,
            float endY,
            ulong duration)
            : this(new Path(startX, endX, duration), new Path(startY, endY, duration))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point or location
        /// </param>
        /// <param name="end">
        ///     The ending point or location
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(Float2D start, Float2D end, ulong duration, ulong delay, AnimationFunctions.Function function)
            : this(
                new Path(start.X, end.X, duration, delay, function),
                new Path(start.Y, end.Y, duration, delay, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point or location
        /// </param>
        /// <param name="end">
        ///     The ending point or location
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(Float2D start, Float2D end, ulong duration, ulong delay)
            : this(
                new Path(start.X, end.X, duration, delay),
                new Path(start.Y, end.Y, duration, delay))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point or location
        /// </param>
        /// <param name="end">
        ///     The ending point or location
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(Float2D start, Float2D end, ulong duration, AnimationFunctions.Function function)
            : this(
                new Path(start.X, end.X, duration, function),
                new Path(start.Y, end.Y, duration, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point or location
        /// </param>
        /// <param name="end">
        ///     The ending point or location
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path2D(Float2D start, Float2D end, ulong duration)
            : this(
                new Path(start.X, end.X, duration),
                new Path(start.Y, end.Y, duration))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path2D" /> class.
        /// </summary>
        /// <param name="x">
        ///     The horizontal path.
        /// </param>
        /// <param name="y">
        ///     The vertical path.
        /// </param>
        public Path2D(Path x, Path y)
        {
            HorizontalPath = x;
            VerticalPath = y;
        }

        /// <summary>
        ///     Gets the horizontal path
        /// </summary>

        public static Path _horizontalPath;
        public Path HorizontalPath
        {
            get { return _horizontalPath; }
            set
            {
                _horizontalPath = value;
            }
        }

        /// <summary>
        ///     Gets the vertical path
        /// </summary>

        public static Path _verticalPath;
        public Path VerticalPath
        {
            get { return _verticalPath; }
            set
            {
                _verticalPath = value;
            }
        }

        /// <summary>
        ///     Gets the starting point of the path
        /// </summary>
        public Float2D Start = new Float2D(_horizontalPath.Start, _verticalPath.Start);


        /// <summary>
        ///     Gets the ending point of the path
        /// </summary>
        public Float2D End = new Float2D(_horizontalPath.End, _verticalPath.End);

        /// <summary>
        ///     Creates and returns a new <see cref="Path2D" /> based on the current path but in reverse order
        /// </summary>
        /// <returns>
        ///     A new <see cref="Path2D" /> which is the reverse of the current <see cref="Path2D" />
        /// </returns>
        public Path2D Reverse()
        {
            return new Path2D(HorizontalPath.Reverse(), VerticalPath.Reverse());
        }
    }
    #endregion
    #region Path2DExtensions
    /// <summary>
    ///     Contains public extensions methods about Path2D class
    /// </summary>
    public static class Path2DExtensions
    {
        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, Float2D end, ulong duration)
        {
            return paths.Concat(new[] { new Path2D(paths.Last().End, end, duration) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, Float2D end, ulong duration,
            AnimationFunctions.Function function)
        {
            return paths.Concat(new[] { new Path2D(paths.Last().End, end, duration, function) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, Float2D end, ulong duration, ulong delay)
        {
            return paths.Concat(new[] { new Path2D(paths.Last().End, end, duration, delay) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, Float2D end, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return paths.Concat(new[] { new Path2D(paths.Last().End, end, duration, delay, function) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, float endX, float endY, ulong duration)
        {
            return paths.Concat(new[] { new Path2D(paths.Last().End, new Float2D(endX, endY), duration) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, float endX, float endY, ulong duration,
            AnimationFunctions.Function function)
        {
            return
                paths.Concat(new[] { new Path2D(paths.Last().End, new Float2D(endX, endY), duration, function) })
                    .ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, float endX, float endY, ulong duration, ulong delay)
        {
            return
                paths.Concat(new[] { new Path2D(paths.Last().End, new Float2D(endX, endY), duration, delay) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, float endX, float endY, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return
                paths.Concat(new[] { new Path2D(paths.Last().End, new Float2D(endX, endY), duration, delay, function) })
                    .ToArray();
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, Float2D end, ulong duration)
        {
            return path.ToArray().ContinueTo(end, duration);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, Float2D end, ulong duration,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(end, duration, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, Float2D end, ulong duration, ulong delay)
        {
            return path.ToArray().ContinueTo(end, duration, delay);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, Float2D end, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(end, duration, delay, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, float endX, float endY, ulong duration)
        {
            return path.ToArray().ContinueTo(endX, endY, duration);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, float endX, float endY, ulong duration,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(endX, endY, duration, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, float endX, float endY, ulong duration, ulong delay)
        {
            return path.ToArray().ContinueTo(endX, endY, duration, delay);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path2D[] ContinueTo(this Path2D path, float endX, float endY, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(endX, endY, duration, delay, function);
        }

        /// <summary>
        ///     Continue the path array with a new ones
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="newPaths">An array of new paths to adds</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path2D[] ContinueTo(this Path2D[] paths, params Path2D[] newPaths)
        {
            return paths.Concat(newPaths).ToArray();
        }

        /// <summary>
        ///     Continue the path with a new ones
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="newPaths">An array of new paths to adds</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path2D[] ContinueTo(this Path2D path, params Path2D[] newPaths)
        {
            return path.ToArray().ContinueTo(newPaths);
        }

        /// <summary>
        ///     Contains a single path in an array
        /// </summary>
        /// <param name="path">The path to add to the array</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path2D[] ToArray(this Path2D path)
        {
            return new[] { path };
        }
    }
    #endregion
    #region Path3D
    /// <summary>
    ///     The Path3D class is a representation of a line in a 3D plane and the
    ///     speed in which the animator plays it
    /// </summary>
    public class Path3D
    {
        public Path3D()
        {

        }
        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="startZ">
        ///     The starting depth value
        /// </param>
        /// <param name="endZ">
        ///     The ending depth value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(
            float startX,
            float endX,
            float startY,
            float endY,
            float startZ,
            float endZ,
            ulong duration,
            ulong delay,
            AnimationFunctions.Function function)
            : this(
                new Path(startX, endX, duration, delay, function),
                new Path(startY, endY, duration, delay, function),
                new Path(startZ, endZ, duration, delay, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="startZ">
        ///     The starting depth value
        /// </param>
        /// <param name="endZ">
        ///     The ending depth value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(
            float startX,
            float endX,
            float startY,
            float endY,
            float startZ,
            float endZ,
            ulong duration,
            ulong delay)
            : this(
                new Path(startX, endX, duration, delay),
                new Path(startY, endY, duration, delay),
                new Path(startZ, endZ, duration, delay))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="startZ">
        ///     The starting depth value
        /// </param>
        /// <param name="endZ">
        ///     The ending depth value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(
            float startX,
            float endX,
            float startY,
            float endY,
            float startZ,
            float endZ,
            ulong duration,
            AnimationFunctions.Function function)
            : this(
                new Path(startX, endX, duration, function),
                new Path(startY, endY, duration, function),
                new Path(startZ, endZ, duration, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="startX">
        ///     The starting horizontal value
        /// </param>
        /// <param name="endX">
        ///     The ending horizontal value
        /// </param>
        /// <param name="startY">
        ///     The starting vertical value
        /// </param>
        /// <param name="endY">
        ///     The ending vertical value
        /// </param>
        /// <param name="startZ">
        ///     The starting depth value
        /// </param>
        /// <param name="endZ">
        ///     The ending depth value
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(
            float startX,
            float endX,
            float startY,
            float endY,
            float startZ,
            float endZ,
            ulong duration)
            : this(new Path(startX, endX, duration), new Path(startY, endY, duration), new Path(startZ, endZ, duration))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point in a 3D plane
        /// </param>
        /// <param name="end">
        ///     The ending point in a 3D plane
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(Float3D start, Float3D end, ulong duration, ulong delay, AnimationFunctions.Function function)
            : this(
                new Path(start.X, end.X, duration, delay, function),
                new Path(start.Y, end.Y, duration, delay, function),
                new Path(start.Z, end.Z, duration, delay, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point in a 3D plane
        /// </param>
        /// <param name="end">
        ///     The ending point in a 3D plane
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="delay">
        ///     The time in miliseconds that the animator must wait before playing this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(Float3D start, Float3D end, ulong duration, ulong delay)
            : this(
                new Path(start.X, end.X, duration, delay),
                new Path(start.Y, end.Y, duration, delay),
                new Path(start.Z, end.Z, duration, delay))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point in a 3D plane
        /// </param>
        /// <param name="end">
        ///     The ending point in a 3D plane
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <param name="function">
        ///     The animation function
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(Float3D start, Float3D end, ulong duration, AnimationFunctions.Function function)
            : this(
                new Path(start.X, end.X, duration, function),
                new Path(start.Y, end.Y, duration, function),
                new Path(start.Z, end.Z, duration, function))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="start">
        ///     The starting point in a 3D plane
        /// </param>
        /// <param name="end">
        ///     The ending point in a 3D plane
        /// </param>
        /// <param name="duration">
        ///     The time in miliseconds that the animator must play this path
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Duration is less than zero
        /// </exception>
        public Path3D(Float3D start, Float3D end, ulong duration)
            : this(
                new Path(start.X, end.X, duration),
                new Path(start.Y, end.Y, duration),
                new Path(start.Z, end.Z, duration))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Path3D" /> class.
        /// </summary>
        /// <param name="x">
        ///     The horizontal path.
        /// </param>
        /// <param name="y">
        ///     The vertical path.
        /// </param>
        /// <param name="z">
        ///     The depth path.
        /// </param>
        public Path3D(Path x, Path y, Path z)
        {
            HorizontalPath = x;
            VerticalPath = y;
            DepthPath = z;
        }

        /// <summary>
        ///     Gets the horizontal path
        /// </summary>

        public static Path _horizontalPath;
        public Path HorizontalPath
        {
            get { return _horizontalPath; }
            set
            {
                _horizontalPath = value;
            }
        }

        /// <summary>
        ///     Gets the vertical path
        /// </summary>

        public static Path _verticalPath;
        public Path VerticalPath
        {
            get { return _verticalPath; }
            set
            {
                _verticalPath = value;
            }
        }

        public static Path _depthPath;
        /// <summary>
        ///     Gets the depth path
        /// </summary>
        public Path DepthPath
        {
            get { return _depthPath; }
            set
            {
                _depthPath = value;
            }
        }


        /// <summary>
        ///     Gets the starting point of the path
        /// </summary>
        public Float3D Start = new Float3D(_horizontalPath.Start, _verticalPath.Start, _depthPath.Start);



        /// <summary>
        ///     Gets the ending point of the path
        /// </summary>
        public Float3D End = new Float3D(_horizontalPath.End, _verticalPath.End, _depthPath.End);

        /// <summary>
        ///     Creates and returns a new <see cref="Path3D" /> based on the current path but in reverse order
        /// </summary>
        /// <returns>
        ///     A new <see cref="Path" /> which is the reverse of the current <see cref="Path3D" />
        /// </returns>
        public Path3D Reverse()
        {
            return new Path3D(HorizontalPath.Reverse(), VerticalPath.Reverse(), DepthPath.Reverse());
        }
    }
    #endregion
    #region Path3DExtensions
    /// <summary>
    ///     Contains public extensions methods about Path3D class
    /// </summary>
    public static class Path3DExtensions
    {
        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, Float3D end, ulong duration)
        {
            return paths.Concat(new[] { new Path3D(paths.Last().End, end, duration) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, Float3D end, ulong duration,
            AnimationFunctions.Function function)
        {
            return paths.Concat(new[] { new Path3D(paths.Last().End, end, duration, function) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, Float3D end, ulong duration, ulong delay)
        {
            return paths.Concat(new[] { new Path3D(paths.Last().End, end, duration, delay) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, Float3D end, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return paths.Concat(new[] { new Path3D(paths.Last().End, end, duration, delay, function) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, float endX, float endY, float endZ, ulong duration)
        {
            return paths.Concat(new[] { new Path3D(paths.Last().End, new Float3D(endX, endY, endZ), duration) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, float endX, float endY, float endZ, ulong duration,
            AnimationFunctions.Function function)
        {
            return
                paths.Concat(new[] { new Path3D(paths.Last().End, new Float3D(endX, endY, endZ), duration, function) })
                    .ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, float endX, float endY, float endZ, ulong duration,
            ulong delay)
        {
            return
                paths.Concat(new[] { new Path3D(paths.Last().End, new Float3D(endX, endY, endZ), duration, delay) })
                    .ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, float endX, float endY, float endZ, ulong duration,
            ulong delay,
            AnimationFunctions.Function function)
        {
            return
                paths.Concat(new[] { new Path3D(paths.Last().End, new Float3D(endX, endY, endZ), duration, delay, function) })
                    .ToArray();
        }


        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, Float3D end, ulong duration)
        {
            return path.ToArray().ContinueTo(end, duration);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, Float3D end, ulong duration,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(end, duration, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, Float3D end, ulong duration, ulong delay)
        {
            return path.ToArray().ContinueTo(end, duration, delay);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, Float3D end, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(end, duration, delay, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, float endX, float endY, float endZ, ulong duration)
        {
            return path.ToArray().ContinueTo(endX, endY, endZ, duration);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, float endX, float endY, float endZ, ulong duration,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(endX, endY, endZ, duration, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, float endX, float endY, float endZ, ulong duration,
            ulong delay)
        {
            return path.ToArray().ContinueTo(endX, endY, endZ, duration, delay);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="endX">Horizontal value of the next point to follow</param>
        /// <param name="endY">Vertical value of the next point to follow</param>
        /// <param name="endZ">Depth value of the next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path3D[] ContinueTo(this Path3D path, float endX, float endY, float endZ, ulong duration,
            ulong delay,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(endX, endY, endZ, duration, delay, function);
        }


        /// <summary>
        ///     Continue the path array with a new ones
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="newPaths">An array of new paths to adds</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path3D[] ContinueTo(this Path3D[] paths, params Path3D[] newPaths)
        {
            return paths.Concat(newPaths).ToArray();
        }

        /// <summary>
        ///     Continue the path with a new ones
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="newPaths">An array of new paths to adds</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path3D[] ContinueTo(this Path3D path, params Path3D[] newPaths)
        {
            return path.ToArray().ContinueTo(newPaths);
        }

        /// <summary>
        ///     Contains a single path in an array
        /// </summary>
        /// <param name="path">The path to add to the array</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path3D[] ToArray(this Path3D path)
        {
            return new[] { path };
        }
    }
    #endregion
    #region PathExtensions
    /// <summary>
    ///     Contains public extensions methods about Path class
    /// </summary>
    public static class PathExtensions
    {
        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path[] paths, float end, ulong duration)
        {
            return paths.Concat(new[] { new Path(paths.Last().End, end, duration) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path[] paths, float end, ulong duration,
            AnimationFunctions.Function function)
        {
            return paths.Concat(new[] { new Path(paths.Last().End, end, duration, function) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path[] paths, float end, ulong duration, ulong delay)
        {
            return paths.Concat(new[] { new Path(paths.Last().End, end, duration, delay) }).ToArray();
        }

        /// <summary>
        ///     Continue the last paths with a new one
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path[] paths, float end, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return paths.Concat(new[] { new Path(paths.Last().End, end, duration, delay, function) }).ToArray();
        }


        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path path, float end, ulong duration)
        {
            return path.ToArray().ContinueTo(end, duration);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path path, float end, ulong duration, AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(end, duration, function);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path path, float end, ulong duration, ulong delay)
        {
            return path.ToArray().ContinueTo(end, duration, delay);
        }

        /// <summary>
        ///     Continue the path with a new one
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="end">Next point to follow</param>
        /// <param name="duration">Duration of the animation</param>
        /// <param name="delay">Starting delay</param>
        /// <param name="function">Animation controller function</param>
        /// <returns>An array of paths including the newly created one</returns>
        public static Path[] ContinueTo(this Path path, float end, ulong duration, ulong delay,
            AnimationFunctions.Function function)
        {
            return path.ToArray().ContinueTo(end, duration, delay, function);
        }


        /// <summary>
        ///     Continue the path array with a new ones
        /// </summary>
        /// <param name="paths">Array of paths</param>
        /// <param name="newPaths">An array of new paths to adds</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path[] ContinueTo(this Path[] paths, params Path[] newPaths)
        {
            return paths.Concat(newPaths).ToArray();
        }

        /// <summary>
        ///     Continue the path with a new ones
        /// </summary>
        /// <param name="path">The path to continue</param>
        /// <param name="newPaths">An array of new paths to adds</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path[] ContinueTo(this Path path, params Path[] newPaths)
        {
            return path.ToArray().ContinueTo(newPaths);
        }

        /// <summary>
        ///     Contains a single path in an array
        /// </summary>
        /// <param name="path">The path to add to the array</param>
        /// <returns>An array of paths including the new ones</returns>
        public static Path[] ToArray(this Path path)
        {
            return new[] { path };
        }
    }
    #endregion
    #region SafeInvoker
    /// <summary>
    ///     The safe invoker class is a delegate reference holder that always
    ///     execute them in the correct thread based on the passed control.
    /// </summary>
    public class SafeInvoker
    {
        private MethodInfo _invokeMethod;

        private PropertyInfo _invokeRequiredProperty;
        private object _targetControl;

        /// <summary>
        ///     Initializes a new instance of the SafeInvoker class.
        /// </summary>
        /// <param name="action">
        ///     The callback to be invoked
        /// </param>
        /// <param name="targetControl">
        ///     The control to be used to invoke the callback in UI thread
        /// </param>
        public SafeInvoker(Action action, object targetControl)
            : this((Delegate)action, targetControl)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the SafeInvoker class.
        /// </summary>
        /// <param name="action">
        ///     The callback to be invoked
        /// </param>
        /// <param name="targetControl">
        ///     The control to be used to invoke the callback in UI thread
        /// </param>
        protected SafeInvoker(Delegate action, object targetControl)
        {
            UnderlyingDelegate = action;
            if (targetControl != null)
            {
                TargetControl = targetControl;
            }
        }

        /// <summary>
        ///     Initializes a new instance of the SafeInvoker class.
        /// </summary>
        /// <param name="action">
        ///     The callback to be invoked
        /// </param>
        public SafeInvoker(Action action)
            : this(action, null)
        {
        }

        /// <summary>
        ///     Gets or sets the reference to the control thats going to be used to invoke the callback in UI thread
        /// </summary>
        protected object TargetControl
        {
            get { return _targetControl; }
            set
            {
                _invokeRequiredProperty = value.GetType()
                    .GetProperty("InvokeRequired", BindingFlags.Instance | BindingFlags.Public);
                _invokeMethod = value.GetType()
                    .GetMethod(
                        "Invoke",
                        BindingFlags.Instance | BindingFlags.Public,
                        Type.DefaultBinder,
                        new[] { typeof(Delegate) },
                        null);
                if (_invokeRequiredProperty != null && _invokeMethod != null)
                {
                    _targetControl = value;
                }
            }
        }


        /// <summary>
        ///     Gets the reference to the callback to be invoked
        /// </summary>
        protected Delegate UnderlyingDelegate { get; set; }

        /// <summary>
        ///     Invoke the contained callback
        /// </summary>
        public virtual void Invoke()
        {
            Invoke(null);
        }

        /// <summary>
        ///     Invoke the referenced callback
        /// </summary>
        /// <param name="value">The argument to send to the callback</param>
        protected void Invoke(object value)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(
                    state =>
                    {
                        if (TargetControl != null && (bool)_invokeRequiredProperty.GetValue(TargetControl, null))
                        {
                            _invokeMethod.Invoke(
                                TargetControl,
                                new object[]
                                {
                                    new Action(
                                        () => UnderlyingDelegate.DynamicInvoke(value != null ? new[] {value} : null))
                                });
                            return;
                        }
                        UnderlyingDelegate.DynamicInvoke(value != null ? new[] { value } : null);
                    });
            }
            catch
            {
                // ignored
            }
        }
    }
    #endregion
    #region SafeInvoker<T>
    /// <summary>
    ///     The safe invoker class is a delegate reference holder that always
    ///     execute them in the correct thread based on the passed control.
    /// </summary>
    public class SafeInvoker<T> : SafeInvoker
    {
        /// <summary>
        ///     Initializes a new instance of the SafeInvoker class.
        /// </summary>
        /// <param name="action">
        ///     The callback to be invoked
        /// </param>
        /// <param name="targetControl">
        ///     The control to be used to invoke the callback in UI thread
        /// </param>
        public SafeInvoker(Action<T> action, object targetControl)
            : base(action, targetControl)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the SafeInvoker class.
        /// </summary>
        /// <param name="action">
        ///     The callback to be invoked
        /// </param>
        public SafeInvoker(Action<T> action)
            : this(action, null)
        {
        }

        /// <summary>
        ///     Invoke the contained callback with the specified value as the parameter
        /// </summary>
        /// <param name="value"></param>
        public void Invoke(T value)
        {
            Invoke((object)value);
        }
    }
    #endregion
    #region Timer
    /// <summary>
    ///     The timer class, will execute your code in specific time frames
    /// </summary>
    public class Timer
    {
        private static Thread _timerThread;

        private static readonly object LockHandle = new object();

        private static readonly long StartTimeAsMs = DateTime.Now.Ticks;

        private static readonly List<Timer> Subscribers = new List<Timer>();

        private readonly Action<ulong> _callback;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Timer" /> class.
        /// </summary>
        /// <param name="callback">
        ///     The callback to be executed at each tick
        /// </param>
        /// <param name="fpsKnownLimit">
        ///     The max ticks per second
        /// </param>
        public Timer(Action<ulong> callback, FPSLimiterKnownValues fpsKnownLimit = FPSLimiterKnownValues.LimitThirty)
            : this(callback, (int)fpsKnownLimit)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Timer" /> class.
        /// </summary>
        /// <param name="callback">
        ///     The callback to be executed at each tick
        /// </param>
        /// <param name="fpsLimit">
        ///     The max ticks per second
        /// </param>
        public Timer(Action<ulong> callback, int fpsLimit)
        {
            if (callback == null)
            {
                throw new ArgumentNullException();
            }

            _callback = callback;
            FrameLimiter = fpsLimit;
            lock (LockHandle)
            {
                if (_timerThread == null)
                {
                    (_timerThread = new Thread(ThreadCycle) { IsBackground = true }).Start();
                }
            }
        }

        /// <summary>
        ///     Gets the time of the last frame/tick related to the global-timer start reference
        /// </summary>
        public long LastTick { get; private set; }

        /// <summary>
        ///     Gets or sets the maximum frames/ticks per second
        /// </summary>
        public int FrameLimiter { get; set; }

        /// <summary>
        ///     Gets the time of the first frame/tick related to the global-timer start reference
        /// </summary>
        public long FirstTick { get; private set; }


        private void Tick()
        {
            if ((1000 / FrameLimiter) < (GetTimeDifferenceAsMs() - LastTick))
            {
                LastTick = GetTimeDifferenceAsMs();
                _callback((ulong)(LastTick - FirstTick));
            }
        }

        private static long GetTimeDifferenceAsMs()
        {
            return (DateTime.Now.Ticks - StartTimeAsMs) / 10000;
        }

        private static void ThreadCycle()
        {
            while (true)
            {
                try
                {
                    bool hibernate;
                    lock (Subscribers)
                    {
                        hibernate = Subscribers.Count == 0;
                        if (!hibernate)
                        {
                            foreach (var t in Subscribers.ToList())
                            {
                                t.Tick();
                            }
                        }
                    }

                    Thread.Sleep(hibernate ? 50 : 1);
                }
                catch
                {
                    // ignored
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }

        /// <summary>
        ///     The method to reset the time of the starting frame/tick
        /// </summary>
        public void ResetClock()
        {
            FirstTick = GetTimeDifferenceAsMs();
        }

        /// <summary>
        ///     The method to resume the timer after stopping it
        /// </summary>
        public void Resume()
        {
            lock (Subscribers)
                if (!Subscribers.Contains(this))
                {
                    FirstTick += GetTimeDifferenceAsMs() - LastTick;
                    Subscribers.Add(this);
                }
        }

        /// <summary>
        ///     The method to start the timer from the beginning
        /// </summary>
        public void Start()
        {
            lock (Subscribers)
                if (!Subscribers.Contains(this))
                {
                    FirstTick = GetTimeDifferenceAsMs();
                    Subscribers.Add(this);
                }
        }

        /// <summary>
        ///     The method to stop the timer from generating any new ticks/frames
        /// </summary>
        public void Stop()
        {
            lock (Subscribers)
                if (Subscribers.Contains(this))
                {
                    Subscribers.Remove(this);
                }
        }
    }
    #endregion

    #endregion
}
