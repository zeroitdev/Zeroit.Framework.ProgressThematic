// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 07-04-2018
// ***********************************************************************
// <copyright file="MyColor.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;


namespace Zeroit.Framework.ProgressThematic.Drawing
{
    public class MyColor
    {
        public static System.Drawing.Color GetBestContrast(System.Drawing.Color BackColor)
        {

            int nThreshold = 105;

            int bgDelta = Convert.ToInt32((BackColor.R * 0.299) + (BackColor.G * 0.587) + (BackColor.B * 0.114));

            System.Drawing.Color ForeColor = (255 - bgDelta < nThreshold) ? System.Drawing.Color.Black : System.Drawing.Color.White;

            return ForeColor;

        }

    }
}
