// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ThematicProgress_SmartTag.cs" company="Zeroit Dev Technologies">
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
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Text;
using Zeroit.Framework.ProgressThematic.FormEditors;

namespace Zeroit.Framework.ProgressThematic
{
    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(ZeroitThematicProgressDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    /// <summary>
    /// Class ZeroitThematicProgressDesigner.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Design.ControlDesigner" />
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ZeroitThematicProgressDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        /// <summary>
        /// The action lists
        /// </summary>
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
        /// <summary>
        /// Gets the design-time action lists supported by the component associated with the designer.
        /// </summary>
        /// <value>The action lists.</value>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new SmartTagActionList(this.Component));
                }
                return actionLists;
            }
        }

        #region Zeroit Filter (Remove Properties)
        /// <summary>
        /// Remove Button and Control properties that are
        /// not supported by the <see cref="MACButton" />.
        /// </summary>
        /// <param name="Properties">The properties.</param>
        protected override void PostFilterProperties(IDictionary Properties)
        {
            Properties.Remove("ProgressType");
            //Properties.Remove("FlatStyle");
            //Properties.Remove("ForeColor");
            //Properties.Remove("ImageIndex");
            //Properties.Remove("ImageList");
        }
        #endregion

    }

    #endregion

    #region SmartTagActionList
    /// <summary>
    /// Class SmartTagActionList.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Design.DesignerActionList" />
    public class SmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        /// <summary>
        /// The col user control
        /// </summary>
        private ZeroitThematicProgress colUserControl;


        /// <summary>
        /// The designer action UI SVC
        /// </summary>
        private DesignerActionUIService designerActionUISvc = null;


        /// <summary>
        /// Initializes a new instance of the <see cref="SmartTagActionList"/> class.
        /// </summary>
        /// <param name="component">A component related to the <see cref="T:System.ComponentModel.Design.DesignerActionList" />.</param>
        public SmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as ZeroitThematicProgress;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of GetProperties enables undo and menu updates to work properly.
        /// <summary>
        /// Gets the name of the property by.
        /// </summary>
        /// <param name="propName">Name of the property.</param>
        /// <returns>PropertyDescriptor.</returns>
        /// <exception cref="ArgumentException">Matching ColorLabel property not found!</exception>
        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(colUserControl)[propName];
            if (null == prop)
                throw new ArgumentException("Matching ColorLabel property not found!", propName);
            else
                return prop;
        }

        #region Properties that are targets of DesignerActionPropertyItem entries.

        /// <summary>
        /// Gets or sets the color of the back.
        /// </summary>
        /// <value>The color of the back.</value>
        public Color BackColor
        {
            get
            {
                return colUserControl.BackColor;
            }
            set
            {
                GetPropertyByName("BackColor").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color of the fore.
        /// </summary>
        /// <value>The color of the fore.</value>
        public Color ForeColor
        {
            get
            {
                return colUserControl.ForeColor;
            }
            set
            {
                GetPropertyByName("ForeColor").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the size of the fixed.
        /// </summary>
        /// <value>The size of the fixed.</value>
        public Boolean FixedSize
        {
            get
            {
                return colUserControl.FixedSize;
            }
            set
            {
                GetPropertyByName("FixedSize").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic animate].
        /// </summary>
        /// <value><c>true</c> if [automatic animate]; otherwise, <c>false</c>.</value>
        public bool AutoAnimate
        {
            get
            {
                return colUserControl.AutoAnimate;
            }
            set
            {
                GetPropertyByName("AutoAnimate").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic increment].
        /// </summary>
        /// <value><c>true</c> if [automatic increment]; otherwise, <c>false</c>.</value>
        public bool AutoIncrement
        {
            get
            {
                return colUserControl.AutoIncrement;
            }
            set
            {
                GetPropertyByName("AutoIncrement").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The animation speed.</value>
        public int[] AnimationSpeed
        {
            get
            {
                return colUserControl.AnimationSpeed;
            }
            set
            {
                GetPropertyByName("AnimationSpeed").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public float Value
        {
            get
            {
                return colUserControl.Value;
            }
            set
            {
                GetPropertyByName("Value").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        public float Maximum
        {
            get
            {
                return colUserControl.Maximum;
            }
            set
            {
                GetPropertyByName("Maximum").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        public float Minimum
        {
            get
            {
                return colUserControl.Minimum;
            }
            set
            {
                GetPropertyByName("Minimum").SetValue(colUserControl, value);
            }
        }




        /// <summary>
        /// Gets or sets the type of the progress.
        /// </summary>
        /// <value>The type of the progress.</value>
        public ProgressType ProgressType
        {
            get
            {
                return colUserControl.ProgressType;
            }
            set
            {
                GetPropertyByName("ProgressType").SetValue(colUserControl, value);
            }
        }


        //public CircularProgress CircularProgressType
        //{
        //    get
        //    {
        //        return colUserControl.CircularProgressType;
        //    }
        //    set
        //    {
        //        GetPropertyByName("CircularProgressType").SetValue(colUserControl, value);
        //    }
        //}


        /// <summary>
        /// Gets or sets the solid progress bar.
        /// </summary>
        /// <value>The solid progress bar.</value>
        public ProgressBar SolidProgressBar
        {
            get
            {
                return colUserControl.SolidProgressBar;
            }
            set
            {
                GetPropertyByName("SolidProgressBar").SetValue(colUserControl, value);
            }
        }


        //public ProgressIndicator ProgressIndicatorType
        //{
        //    get
        //    {
        //        return colUserControl.ProgressIndicatorType;
        //    }
        //    set
        //    {
        //        GetPropertyByName("ProgressIndicatorType").SetValue(colUserControl, value);
        //    }
        //}

        /// <summary>
        /// Gets or sets the progress input.
        /// </summary>
        /// <value>The progress input.</value>
        public ProgressInput ProgressInput
        {
            get
            {
                return colUserControl.ProgressInput;
            }
            set
            {
                GetPropertyByName("ProgressInput").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        public bool ShowText
        {
            get
            {
                return colUserControl.ShowText;
            }
            set
            {
                GetPropertyByName("ShowText").SetValue(colUserControl, value);
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SmartTagActionList"/> is reverse.
        /// </summary>
        /// <value><c>true</c> if reverse; otherwise, <c>false</c>.</value>
        public bool Reverse
        {
            get
            {
                return colUserControl.Reverse;
            }
            set
            {
                GetPropertyByName("Reverse").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the speed multiplier.
        /// </summary>
        /// <value>The speed multiplier.</value>
        public float SpeedMultiplier
        {
            get
            {
                return colUserControl.SpeedMultiplier;
            }
            set
            {
                GetPropertyByName("SpeedMultiplier").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the change.
        /// </summary>
        /// <value>The change.</value>
        public float Change
        {
            get
            {
                return colUserControl.Change;
            }
            set
            {
                GetPropertyByName("Change").SetValue(colUserControl, value);
            }
        }



        #endregion

        #region DesignerActionItemCollection

        /// <summary>
        /// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem" /> objects contained in the list.
        /// </summary>
        /// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem" /> array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //Define static section header entries.

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Animation"));

            items.Add(new DesignerActionPropertyItem("AutoAnimate",
                "Auto Animate", "Animation",
                "Sets the control to start animation."));

            items.Add(new DesignerActionPropertyItem("AutoIncrement",
                "Auto Increment", "Animation",
                "Sets the control to start with easing animation."));

            items.Add(new DesignerActionPropertyItem("Reverse",
                "Reverse", "Animation",
                "Set to automatically reverse the animation."));

            items.Add(new DesignerActionPropertyItem("SpeedMultiplier",
                "Speed Multiplier", "Animation",
                "Set to multiply the speed by this factor."));

            items.Add(new DesignerActionPropertyItem("Change",
                "Change", "Animation",
                "Set to change the interval for animation."));

            items.Add(new DesignerActionPropertyItem("AnimationSpeed",
                "Animation Speed", "Animation",
                "Sets the animation speed."));

            items.Add(new DesignerActionHeaderItem("Behaviour"));

            
            items.Add(new DesignerActionPropertyItem("FixedSize",
                "Fixed Size", "Behaviour",
                "Sets the control to have fixed width and height when resized."));


            items.Add(new DesignerActionPropertyItem("ShowText",
                "Show Text", "Behaviour",
                "Sets the control to show the progress value."));


            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));


            items.Add(new DesignerActionPropertyItem("ProgressInput",
                "Customize Progress", "Appearance",
                "Sets the values of the Progress."));

            items.Add(new DesignerActionPropertyItem("BackColor",
                                 "Back Color", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("ForeColor",
                                 "Fore Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("SolidProgressBar",
                "Progress", "Appearance",
                "Sets the solid bar type."));


            //items.Add(new DesignerActionPropertyItem("ProgressType",
            //    "Progress Type", "General Information",
            //    "Sets the progress type."));

            //items.Add(new DesignerActionPropertyItem("CircularProgressType",
            //    "Circular Progress Type", "General Information",
            //    "Sets the circular progress type."));

            //items.Add(new DesignerActionPropertyItem("ProgressIndicatorType",
            //    "Progress Indicator", "General Information",
            //    "Sets the Progress Indicator type."));

            
            items.Add(new DesignerActionPropertyItem("Maximum",
                "Maximum", "Appearance",
                "Sets the maximum value for the progress control."));

            items.Add(new DesignerActionPropertyItem("Minimum",
                "Minimum", "Appearance",
                "Sets the minimum value for the progress control."));
            
            items.Add(new DesignerActionPropertyItem("Value",
                "Value", "Appearance",
                "Sets the progress value."));




            //Create entries for static Information section.
            StringBuilder location = new StringBuilder("Product: ");
            location.Append(colUserControl.ProductName);
            StringBuilder size = new StringBuilder("Version: ");
            size.Append(colUserControl.ProductVersion);
            items.Add(new DesignerActionTextItem(location.ToString(),
                             "Information"));
            items.Add(new DesignerActionTextItem(size.ToString(),
                             "Information"));

            return items;
        }

        #endregion




    }

    #endregion

    #endregion
}
