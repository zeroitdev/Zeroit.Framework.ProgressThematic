// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Extended_UC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    [ToolboxItem(false)]
    public partial class Extended_UC : UserControl
    {
        public Extended_UC()
        {
            InitializeComponent();

            #region Add Orientation Enum to ComboBox
            //// get a list of member names from EasingFunctionTypes enum,
            //// figure out the numeric value, and display
            //foreach (string orientation in Enum.GetNames(typeof(ProgressBarDirection)))
            //{
            //    bars_Extended_Orientation_ComboBox.Items.Add(orientation);

            //}
            //for (int i = 0; i < bars_Extended_Orientation_ComboBox.Items.Count; i++)
            //{

            //    bars_Extended_Orientation_ComboBox.SelectedIndex = i;

            //}

            #endregion

            //#region Add Bar Style Enum to ComboBox
            //// get a list of member names from EasingFunctionTypes enum,
            //// figure out the numeric value, and display
            //foreach (string barstyle in Enum.GetNames(typeof(ProgressStyle)))
            //{
            //    bars_Extended_BarStyle_ComboBox.Items.Add(barstyle);

            //}
            //for (int i = 0; i < bars_Extended_BarStyle_ComboBox.Items.Count; i++)
            //{

            //    bars_Extended_BarStyle_ComboBox.SelectedIndex = i;

            //}

            //#endregion

            //#region Add Flood Style Enum to ComboBox
            //// get a list of member names from EasingFunctionTypes enum,
            //// figure out the numeric value, and display
            //foreach (string floodstyle in Enum.GetNames(typeof(ProgressFloodStyle)))
            //{
            //    bars_Extended_FloodStyle_ComboBox.Items.Add(floodstyle);

            //}
            //for (int i = 0; i < bars_Extended_FloodStyle_ComboBox.Items.Count; i++)
            //{

            //    bars_Extended_FloodStyle_ComboBox.SelectedIndex = i;

            //}

            //#endregion

            //#region Add Edge Enum to ComboBox
            //// get a list of member names from EasingFunctionTypes enum,
            //// figure out the numeric value, and display
            //foreach (string edge in Enum.GetNames(typeof(ProgressBarEdge)))
            //{
            //    bars_Extended_Edge_ComboBox.Items.Add(edge);

            //}
            //for (int i = 0; i < bars_Extended_Edge_ComboBox.Items.Count; i++)
            //{

            //    bars_Extended_Edge_ComboBox.SelectedIndex = i;

            //}

            //#endregion

            //#region Add CaptionMode Enum to ComboBox
            //// get a list of member names from EasingFunctionTypes enum,
            //// figure out the numeric value, and display
            //foreach (string captionMode in Enum.GetNames(typeof(ProgressCaptionMode)))
            //{
            //    bars_Extended_CaptionMode_ComboBox.Items.Add(captionMode);

            //}
            //for (int i = 0; i < bars_Extended_CaptionMode_ComboBox.Items.Count; i++)
            //{

            //    bars_Extended_CaptionMode_ComboBox.SelectedIndex = i;

            //}

            //#endregion
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
    }
}
