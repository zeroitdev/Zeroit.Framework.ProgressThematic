using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{
    public enum ProgressType
    {
        Bar,
        Circular,
        Indicator
    }

    public enum CircularProgress
    {

        Awesome,
        CircularProgressv2,
        CircularProgressv3,
        CircularProgressv4,
        CircularProgressv5,
        CircularProgressv5aClock,
        GorgeousProgress,
        Ignito,
        MulitCo,
        MultiCoExtended,
        MultiCoV1,
        Perfect,
        ProgressPie,
        RotatingArc,
        RotatingCompass,
        SupremeCircle,
        ZeroitProgressBarCircular,
        ZeroitProgressBarCircularDefault
    }

    public enum ProgressBar
    {
        Alter,
        Clear,
        ExtendedProgress,
        iTunes,
        Maze,
        Perplex,
        ProgressBoxed,
        ProgressGradient,
        ProgressNormal,
        ProgressRect,
        Splitter,
        Transparent,
        ZeroitIndicator,

    }

    public enum ProgressIndicator
    {
        CircularIndeterminate,
        GoogleProgressIndicator,
        IndicatorV1,
        MacOSX,
        MacOSXOptimized,
        Matrix,
        SpinnerCircle,
        SpinnerDivided,
        Unique,
        Vuvuzela,
        Win8Horizontal,
        Win8Ring

    }

    public enum drawMode
    {
        Solid,
        Gradient,
        Hatch
    }

    public enum PeaceAnimatorEasing
    {
        BounceEaseIn,
        BounceEaseInOut,
        BounceEaseOut,
        BounceEaseOutIn,
        CircularEaseIn,
        CircularEaseInOut,
        CircularEaseOut,
        CubicEaseIn,
        CubicEaseInOut,
        CubicEaseOut,
        ExponentialEaseIn,
        ExponentialEaseInOut,
        ExponentialEaseOut,
        Liner,
        None,
        QuadraticEaseIn,
        QuadraticEaseInOut,
        QuadraticEaseOut,
        QuarticEaseIn,
        QuarticEaseInOut,
        QuarticEaseOut,
        QuinticEaseIn,
        QuinticEaseInOut,
        QuinticEaseOut,
        SinusoidalEaseIn,
        SinusoidalEaseInOut,
        SinusoidalEaseOut
    }

    public enum transparencyEasingType
    {
        BounceEaseIn,
        BounceEaseInOut,
        BounceEaseOut,
        BounceEaseOutIn,
        CircularEaseIn,
        CircularEaseInOut,
        CircularEaseOut,
        CubicEaseIn,
        CubicEaseInOut,
        CubicEaseOut,
        ExponentialEaseIn,
        ExponentialEaseInOut,
        ExponentialEaseOut,
        Liner,
        None,
        QuadraticEaseIn,
        QuadraticEaseInOut,
        QuadraticEaseOut,
        QuarticEaseIn,
        QuarticEaseInOut,
        QuarticEaseOut,
        QuinticEaseIn,
        QuinticEaseInOut,
        QuinticEaseOut,
        SinusoidalEaseIn,
        SinusoidalEaseInOut,
        SinusoidalEaseOut
    }

    public enum MacOSX_automatic
    {
        Start,
        FastRotate,
        SlowRotate,
        Stop
    }

    public enum MazeStyleType
    {
        /// <summary>
        /// 	A maze with a single path going left to right.
        /// </summary>
        SingleRight,

        /// <summary>
        /// 	A maze with a single path going left to right.
        /// </summary>
        SingleLeft,

        /// <summary>
        /// 	A maze with a single path going bottom to top.
        /// </summary>
        SingleUp,

        /// <summary>
        /// 	A maze with a single path going top to bottom.
        /// </summary>
        SingleDown,

        /// <summary>
        /// 	A maze in which paths start at the right and left ends, converging in the middle.
        /// </summary>
        SplitConvergeHorizontal,

        /// <summary>
        /// 	A maze in which paths start at the top and bottom, converging in the middle.
        /// </summary>
        SplitConvergeVertical,

        /// <summary>
        /// 	A maze in which paths start in the middle, ending at the right and left ends.
        /// </summary>
        SplitDivergeHorizontal,

        /// <summary>
        /// 	A maze in which paths start in the middle, ending at the top and bottom.
        /// </summary>
        SplitDivergeVertical
    };

    public enum Maze_GradientType
    {
        /// <summary>
        /// 	No gradient coloring.  All filled cells are <c>ForeColor</c>
        /// </summary>
        None,

        /// <summary>
        /// 	Each row in the maze is a different color, spanning a gradient with
        /// 	the first row being <c>GradientStartColor</c>, and the last row being <c>GradientEndColor</c>.
        /// </summary>
        Rows,

        /// <summary>
        /// 	Each column in the maze is a different color, spanning a gradient with
        /// 	the first column being <c>GradientStartColor</c>, and the last column being <c>GradientEndColor</c>.
        /// </summary>
        Columns,

        /// <summary>
        /// 	Each cell in the maze is a different color, spanning a gradient with
        /// 	the first cell being <c>GradientStartColor</c>, and the last cell being <c>GradientEndColor</c>.
        /// </summary>
        Flow
    };

    //ZeroitMultiCo
    public enum Rings
    {
        Default,
        One,
        Two,
        Four,
        Eight,
        Twelve,
        TwentyFour
    }
    
}
