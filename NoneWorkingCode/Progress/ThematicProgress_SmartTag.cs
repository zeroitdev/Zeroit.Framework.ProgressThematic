using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.ProgressThematic
{
    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(ThematicProgressDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ThematicProgressDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
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
        /// not supported by the <see cref="MACButton"/>.
        /// </summary>
        protected override void PostFilterProperties(IDictionary Properties)
        {
            //Properties.Remove("AllowDrop");
            //Properties.Remove("FlatStyle");
            //Properties.Remove("ForeColor");
            //Properties.Remove("ImageIndex");
            //Properties.Remove("ImageList");
        }
        #endregion

    }

    #endregion

    #region SmartTagActionList
    public class SmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        private ThematicProgress colUserControl;


        private DesignerActionUIService designerActionUISvc = null;


        public SmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as ThematicProgress;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of GetProperties enables undo and menu updates to work properly.
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


        public CircularProgress CircularProgressType
        {
            get
            {
                return colUserControl.CircularProgressType;
            }
            set
            {
                GetPropertyByName("CircularProgressType").SetValue(colUserControl, value);
            }
        }


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


        public ProgressIndicator ProgressIndicator
        {
            get
            {
                return colUserControl.ProgressIndicator;
            }
            set
            {
                GetPropertyByName("ProgressIndicator").SetValue(colUserControl, value);
            }
        }

        #endregion

        #region DesignerActionItemCollection

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));

            items.Add(new DesignerActionPropertyItem("BackColor",
                                 "Back Color", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("ForeColor",
                                 "Fore Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("ProgressType",
                "Progress Type", "General Information",
                "Sets the progress type."));

            items.Add(new DesignerActionPropertyItem("CircularProgressType",
                "Circular Progress Type", "General Information",
                "Sets the circular progress type."));

            items.Add(new DesignerActionPropertyItem("ProgressIndicator",
                "Progress Indicator", "General Information",
                "Sets the Progress Indicator type."));

            items.Add(new DesignerActionPropertyItem("SolidProgressBar",
                "Solid Progress Bar", "General Information",
                "Sets the solid bar type."));

            items.Add(new DesignerActionPropertyItem("AutoAnimate",
                "Auto Animate", "General Information",
                "Sets the control to start animation."));

            items.Add(new DesignerActionPropertyItem("AutoIncrement",
                "Auto Increment", "General Information",
                "Sets the control to start with easing animation."));

            items.Add(new DesignerActionPropertyItem("AnimationSpeed",
                "Animation Speed", "General Information",
                "Sets the animation speed."));

            items.Add(new DesignerActionPropertyItem("FixedSize",
                "Fixed Size", "General Information",
                "Sets the control to have fixed width and height when resized."));

            items.Add(new DesignerActionPropertyItem("Value",
                "Value", "General Information",
                "Sets the progress value."));

            items.Add(new DesignerActionPropertyItem("Maximum",
                "Maximum", "General Information",
                "Sets the maximum value for the progress control."));

            items.Add(new DesignerActionPropertyItem("Minimum",
                "Minimum", "General Information",
                "Sets the minimum value for the progress control."));





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
