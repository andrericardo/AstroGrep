using System;
using System.Drawing;
using System.Windows.Forms;

namespace AstroGrep.Windows.Forms
{
   /// <summary>
   /// Base form for all forms to inherit from.
   /// </summary>
   public class BaseForm: Form
   {
      /// <summary>
      /// Load event for all forms
      /// </summary>
      /// <param name="e">system parameter</param>
      protected override void OnLoad(EventArgs e)
      {
         //// aid font scaling and all controls use system font
         //foreach (Control ctr in this.Controls)
         //{
         //   ctr.Font = SystemFonts.MessageBoxFont;

         //   // controls in groupboxes are not child of main form
         //   if (ctr.HasChildren)
         //   {
         //      foreach (Control childControl in ctr.Controls)
         //      {
         //         childControl.Font = SystemFonts.MessageBoxFont;
         //      }
         //   }
         //}

         //// aid font scaling
         //AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; //Font will handle both DPI changes and changes to the system font size setting
         //AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); //96dpi

         base.OnLoad(e);
      }
   }
}
