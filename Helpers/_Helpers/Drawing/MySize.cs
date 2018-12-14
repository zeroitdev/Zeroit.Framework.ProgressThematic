// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MySize.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.ProgressThematic.Drawing
{
    public class MySize
    {
        public static CompareOutputTypes Compare(Size S1, Size S2)
        {
            if (S1.Height == S2.Height && S1.Width == S2.Width)
                return CompareOutputTypes.Equal;
            if (S1.Height <= S2.Height && S1.Width <= S2.Width)
                return CompareOutputTypes.Smaller;
            if (S1.Height <= S2.Height && S1.Width >= S2.Width)
                return CompareOutputTypes.Unknown;
            return CompareOutputTypes.Larger;

        }
        public enum CompareOutputTypes { Smaller, Equal, Larger,Unknown };
    }
    
}
