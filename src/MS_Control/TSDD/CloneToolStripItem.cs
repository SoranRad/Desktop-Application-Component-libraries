using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.TSDD
{
    public static class CloneToolStripItem
    {

        public static ToolStripItem CloneTo(this ToolStripItem Item)
        {


            // dirt simple clone - just properties, no subitems
            //CopyEventHandlers _copyHelper = new CopyEventHandlers();

            ToolStripItem menuItem =(ToolStripItem) Activator.CreateInstance(Item.GetType()); 
            //menuItem.Events.AddHandlers(Item.Events);
            //_copyHelper.GetHandlersFrom(Item).CopyTo(menuItem);

            menuItem.AccessibleName         = Item.AccessibleName;
            menuItem.AccessibleRole         = Item.AccessibleRole;
            menuItem.Alignment              = Item.Alignment;
            menuItem.AllowDrop              = Item.AllowDrop;
            menuItem.Anchor                 = Item.Anchor;
            menuItem.AutoSize               = Item.AutoSize;
            menuItem.AutoToolTip            = Item.AutoToolTip;
            menuItem.BackColor              = Item.BackColor;
            menuItem.BackgroundImage        = Item.BackgroundImage;
            menuItem.BackgroundImageLayout  = Item.BackgroundImageLayout;
            menuItem.DisplayStyle           = Item.DisplayStyle;
            menuItem.Dock                   = Item.Dock;
            menuItem.DoubleClickEnabled     = Item.DoubleClickEnabled;
            menuItem.Enabled                = Item.Enabled;
            menuItem.Font                   = Item.Font;
            menuItem.ForeColor              = Item.ForeColor;
            menuItem.Image                  = Item.Image;
            menuItem.ImageAlign             = Item.ImageAlign;
            menuItem.ImageScaling           = Item.ImageScaling;
            menuItem.ImageTransparentColor  = Item.ImageTransparentColor;
            menuItem.Margin                 = Item.Margin;
            menuItem.MergeAction            = Item.MergeAction;
            menuItem.MergeIndex             = Item.MergeIndex;
            menuItem.Name                   = Item.Name;
            menuItem.Overflow               = Item.Overflow;
            menuItem.Padding                = Item.Padding;
            menuItem.RightToLeft            = Item.RightToLeft;


            //menuItem.ShortcutKeys = Item.ShortcutKeys;
            //menuItem.ShowShortcutKeys = Item.ShowShortcutKeys;

            menuItem.Tag                    = Item.Tag;
            menuItem.Text                   = Item.Text;
            menuItem.TextAlign              = Item.TextAlign;
            menuItem.TextDirection          = Item.TextDirection;
            menuItem.TextImageRelation      = Item.TextImageRelation;
            menuItem.ToolTipText            = Item.ToolTipText;
            menuItem.Available              = Item.Available;


            if (!Item.AutoSize)
            {
                menuItem.Size = Item.Size;
            }
            return menuItem;
        }


    }
}
