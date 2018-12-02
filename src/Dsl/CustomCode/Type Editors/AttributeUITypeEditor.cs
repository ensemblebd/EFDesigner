﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Sawczyn.EFDesigner.EFModel
{
   public class AttributeUITypeEditor: UITypeEditor
   {
      private IWindowsFormsEditorService service;

      /// <summary>Gets the editor style used by the <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)" /> method.</summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to gain additional context information. </param>
      /// <returns>A <see cref="T:System.Drawing.Design.UITypeEditorEditStyle" /> value that indicates the style of editor used by the <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)" /> method. If the <see cref="T:System.Drawing.Design.UITypeEditor" /> does not support this method, then <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle" /> will return <see cref="F:System.Drawing.Design.UITypeEditorEditStyle.None" />.</returns>
      public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
      {
         return UITypeEditorEditStyle.Modal;
      }

      /// <summary>Edits the specified object's value using the editor style indicated by the <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle" /> method.</summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to gain additional context information. </param>
      /// <param name="provider">An <see cref="T:System.IServiceProvider" /> that this editor can use to obtain services. </param>
      /// <param name="value">The object to edit. </param>
      /// <returns>The new value of the object. If the value of the object has not changed, this should return the same object it was passed.</returns>
      public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
      {
         if (context?.Instance == null || service == null)
            return value;

         service = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

         AttributeEditor form = new AttributeEditor();
         

         return base.EditValue(context, provider, value);
      }
   }
}