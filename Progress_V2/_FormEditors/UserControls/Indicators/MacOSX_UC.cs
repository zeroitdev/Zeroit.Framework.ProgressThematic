// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MacOSX_UC.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    [ToolboxItem(false)]
    public partial class MacOSX_UC : UserControl
    {
        public MacOSX_UC()
        {
            InitializeComponent();
        }


        private void Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            Preview_Btn.FlatAppearance.BorderSize = 1;
            Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            Preview_Btn.FlatAppearance.BorderSize = 0;
            Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        private void indicator_MacOSX_Automatic_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Automatic =
                (MacOSX_automatic)Enum.Parse(typeof
                        (MacOSX_automatic),
                    indicator_MacOSX_Automatic_ComboBox.SelectedItem.ToString());

        }

        private void indicator_MacOSX_Rotation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Rotation =
                (ZeroitThematicProgress.MacOSX_Direction)Enum.Parse(typeof
                        (ZeroitThematicProgress.MacOSX_Direction),
                    indicator_MacOSX_Rotation_ComboBox.SelectedItem.ToString());

        }

        private void indicator_MacOSX_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    indicator_MacOSX_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void indicator_MacOSX_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    indicator_MacOSX_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void indicator_MacOSX_Interval_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Interval =
                (int)indicator_MacOSX_Interval_Numeric.Value;

        }

        private void indicator_MacOSX_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_StartAngle =
                (int)indicator_MacOSX_StartAngle_Numeric.Value;

        }

        private void indicator_MacOSX_TickColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MacOSX_TickColor = colorSelector.Color;

                indicator_MacOSX_TickColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_MacOSX_CircleCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Maximum =
                (float)indicator_MacOSX_CircleCount_Numeric.Value;

            
        }

        private void indicator_MacOSX_MaxSpokes_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_MaxSpokes =
                (int)indicator_MacOSX_MaxSpokes_Numeric.Value;

        }
    }
}
