﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 07-04-2018
// ***********************************************************************
// <copyright file="PathExtensions.cs" company="Zeroit Dev Technologies">
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

using System.Linq;

namespace Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation
{
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
            return paths.Concat(new[] {new Path(paths.Last().End, end, duration)}).ToArray();
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
            return paths.Concat(new[] {new Path(paths.Last().End, end, duration, function)}).ToArray();
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
            return paths.Concat(new[] {new Path(paths.Last().End, end, duration, delay)}).ToArray();
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
            return paths.Concat(new[] {new Path(paths.Last().End, end, duration, delay, function)}).ToArray();
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
            return new[] {path};
        }
    }
}