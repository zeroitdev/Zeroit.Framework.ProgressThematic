// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Point3D.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.VisualBasic.CompilerServices;


namespace Zeroit.Framework.ProgressThematic.AnimationHelpers.Rotating3DCube
{
    /// <summary>
    /// A class collection for generating Three Dimensional (3D) Points
    /// </summary>
    public class Point3D
    {
        protected double m_x;

        protected double m_y;

        protected double m_z;

        /// <summary>
        /// Property for X value
        /// </summary>
        public double X
        {
            get
            {
                return this.m_x;
            }
            set
            {
                this.m_x = value;
            }
        }

        /// <summary>
        /// Property for Y value
        /// </summary>
        public double Y
        {
            get
            {
                return this.m_y;
            }
            set
            {
                this.m_y = value;
            }
        }

        /// <summary>
        /// Property for Z value
        /// </summary>
        public double Z
        {
            get
            {
                return this.m_z;
            }
            set
            {
                this.m_z = value;
            }
        }

        /// <summary>
        /// Creates an instance of Point 3D
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// For compiler services
        /// </summary>
        /// <param name="viewWidth">Set for viewing Width</param>
        /// <param name="viewHeight">Set for viewing Height</param>
        /// <param name="fov"></param>
        /// <param name="viewDistance">Set for viewing Distance</param>
        /// <returns></returns>
        public object Project(object viewWidth, object viewHeight, object fov, object viewDistance)
        {
            double factor = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Operators.DivideObject(fov, Operators.AddObject(viewDistance, this.Z)));
            double Xn = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Operators.AddObject(this.X * factor, Operators.DivideObject(viewWidth, 2)));
            double Yn = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Operators.AddObject(this.Y * factor, Operators.DivideObject(viewHeight, 2)));
            return new Point3D(Xn, Yn, this.Z);
        }

        /// <summary>
        /// Rotate X
        /// </summary>
        /// <param name="angle">Set angle</param>
        /// <returns></returns>
        public Point3D RotateX(int angle)
        {
            double rad = (double)angle * 3.14159265358979 / 180;
            double cosa = System.Math.Cos(rad);
            double sina = System.Math.Sin(rad);
            double yn = this.Y * cosa - this.Z * sina;
            double zn = this.Y * sina + this.Z * cosa;
            return new Point3D(this.X, yn, zn);
        }

        /// <summary>
        /// Rotate Y
        /// </summary>
        /// <param name="angle">Set angle</param>
        /// <returns></returns>
        public Point3D RotateY(int angle)
        {
            double rad = (double)angle * 3.14159265358979 / 180;
            double cosa = System.Math.Cos(rad);
            double sina = System.Math.Sin(rad);
            double Zn = this.Z * cosa - this.X * sina;
            double Xn = this.Z * sina + this.X * cosa;
            return new Point3D(Xn, this.Y, Zn);
        }

        /// <summary>
        /// Rotate Z
        /// </summary>
        /// <param name="angle">Set angle</param>
        /// <returns></returns>
        public Point3D RotateZ(int angle)
        {
            double rad = (double)angle * 3.14159265358979 / 180;
            double cosa = System.Math.Cos(rad);
            double sina = System.Math.Sin(rad);
            double Xn = this.X * cosa - this.Y * sina;
            double Yn = this.X * sina + this.Y * cosa;
            return new Point3D(Xn, Yn, this.Z);
        }
    }
}
