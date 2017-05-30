﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using AstroGrep.Common;
using AstroGrep.Common.Logging;
using AstroGrep.Windows;

namespace AstroGrep.Core
{
   /// <summary>
   /// Helper class to handle managing the text editors.
   /// </summary>
   /// <remarks>
   ///   AstroGrep File Searching Utility. Written by Theodore L. Ward
   ///   Copyright (C) 2002 AstroComma Incorporated.
   ///   
   ///   This program is free software; you can redistribute it and/or
   ///   modify it under the terms of the GNU General Public License
   ///   as published by the Free Software Foundation; either version 2
   ///   of the License, or (at your option) any later version.
   ///   
   ///   This program is distributed in the hope that it will be useful,
   ///   but WITHOUT ANY WARRANTY; without even the implied warranty of
   ///   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   ///   GNU General Public License for more details.
   ///   
   ///   You should have received a copy of the GNU General Public License
   ///   along with this program; if not, write to the Free Software
   ///   Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
   /// 
   ///   The author may be contacted at:
   ///   ted@astrocomma.com or curtismbeard@gmail.com
   /// </remarks>
   /// <history>
   /// [Curtis_Beard]      12/06/2012  ADD: create common class to host text editor methods
   /// </history>
   public class TextEditors
   {
      private static TextEditor[] __TextEditors;
      private const string DELIMETER = "|;;|";

      /// <summary>
      /// Open a file with a user defined text editor/executable.
      /// </summary>
      /// <param name="opener">TextEditorOpener object containing the information necessary to edit a file.</param>
      /// <history>
      /// [Theodore_Ward]     ??/??/????  Initial
      /// [Curtis_Beard]	   01/11/2005	.Net Conversion, Try/Catch
      /// [Curtis_Beard]	   06/13/2005	CHG: Used new cmd line arg specification
      /// [Curtis_Beard]	   07/20/2006	CHG: Run the text editor associated with the file's extension
      /// [Curtis_Beard]	   07/26/2006	ADD: 1512026, column position
      /// [Curtis_Beard]      09/28/2012  CHG: 3553474, support multiple file types per editor
      /// [Curtis_Beard]		04/07/2015	CHG: check for a valid line text before using
      /// [Curtis_Beard]	   04/08/2015	CHG: add logging
      /// [Curtis_Beard]	   08/20/2015	FIX: 81, use associated app instead of displaying message
      /// [Curtis_Beard]	   08/16/2016	CHG: use common class for parameters, rename from EditFile -> Open
      /// </history>
      public static void Open(TextEditorOpener opener)
      {
         if (opener != null && opener.HasValue())
         {
            try
            {
               // pick the correct editor to use
               System.IO.FileInfo file = new System.IO.FileInfo(opener.Path);
               TextEditor editorToUse = null;

               // find extension match
               if (__TextEditors != null)
               {
                  foreach (TextEditor editor in __TextEditors)
                  {
                     // handle multiple types for one editor
                     string[] types = new string[1] { editor.FileType };
                     if (editor.FileType.Contains(Constants.TEXT_EDITOR_TYPE_SEPARATOR))
                     {
                        types = editor.FileType.Split(Constants.TEXT_EDITOR_TYPE_SEPARATOR.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                     }

                     // loop through all types defined for this editor
                     foreach (string type in types)
                     {
                        string currentType = type;

                        // add missing start . if file type has it and the user didn't add it.
                        if (currentType != Constants.ALL_FILE_TYPES && !currentType.StartsWith(".") && file.Extension.StartsWith("."))
                           currentType = string.Format(".{0}", currentType);

                        if (currentType.IndexOf(file.Extension, StringComparison.OrdinalIgnoreCase) > -1)
                        {
                           // use this editor
                           editorToUse = editor;
                           break;
                        }
                     }

                     if (editorToUse != null)
                        break;
                  }

                  // try finding default for all types (*)
                  if (editorToUse == null)
                  {
                     foreach (TextEditor editor in __TextEditors)
                     {
                        if (editor.FileType.Equals(Constants.ALL_FILE_TYPES))
                        {
                           // use this editor
                           editorToUse = editor;
                           break;
                        }
                     }
                  }

                  if (editorToUse == null)
                  {
                     // since nothing defined, just use default app associated with file type
                     OpenWithDefault(opener.Path);
                  }
                  else
                  {
                     // adjust column if tab size is set
                     if (editorToUse.TabSize > 0 && opener.ColumnNumber > 0 && !string.IsNullOrEmpty(opener.LineText))
                     {
                        // count how many tabs before found hit column index
                        int count = 0;
                        for (int i = opener.ColumnNumber - 1; i >= 0; i--)
                        {
                           if (opener.LineText[i] == '\t')
                           {
                              count++;
                           }
                        }

                        opener.ColumnNumber += ((count * editorToUse.TabSize) - count);
                     }

                     LaunchEditor(editorToUse, opener.Path, opener.LineNumber, opener.ColumnNumber, string.Empty);
                  }
               }
            }
            catch (Exception ex)
            {
               LogClient.Instance.Logger.Error("Unable to open text editor for file {0} at line {1}, column {2}, with text {3} and message {4}", opener.Path, opener.LineNumber, opener.ColumnNumber, opener.LineText, ex.Message);

               MessageBox.Show(String.Format(Language.GetGenericText("TextEditorsErrorGeneric"), opener.Path, ex.Message),
                     ProductInformation.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
      }

      /// <summary>
      /// Opens the given file using the default associated application.
      /// </summary>
      /// <param name="path">Full path to file</param>
      /// <history>
      /// [Curtis_Beard]      02/12/2014  ADD: 67, open selected file(s) with associated application
      /// </history>
      public static void OpenWithDefault(string path)
      {
         System.Diagnostics.Process.Start(path);
      }

      /// <summary>
      /// Loads the user specified text editors.
      /// </summary>
      /// <history>
      /// [Curtis_Beard]	   07/10/2006   Created
      /// [Curtis_Beard]	   11/07/2012   Renamed
      /// </history>
      public static void Load()
      {
         string editorsString = AstroGrep.Core.GeneralSettings.TextEditors;

         if (editorsString.Length > 0)
         {
            //parse string for each editor
            string[] editors = Utils.SplitByString(editorsString, DELIMETER);
            if (editors.Length > 0)
            {
               __TextEditors = new TextEditor[editors.Length];

               for (int i = 0; i < editors.Length; i++)
               {
                  //parse each editor for class properties
                  __TextEditors[i] = TextEditor.FromString(editors[i]);
               }
            }
         }
         else
         {
            __TextEditors = Windows.Legacy.ConvertTextEditors();
            Save(__TextEditors);
         }
      }

      /// <summary>
      /// Get the text editors that were loaded.
      /// </summary>
      /// <returns>Array of TextEditor objects</returns>
      /// <history>
      /// [Curtis_Beard]	   07/10/2006	Created
      /// [Curtis_Beard]	   11/07/2012	Renamed
      /// </history>
      public static TextEditor[] GetAll()
      {
         return __TextEditors;
      }

      /// <summary>
      /// Saves the given Array of TextEditor objects.
      /// </summary>
      /// <param name="editors">Array of TextEditor objects</param>
      /// <history>
      /// [Curtis_Beard]	   07/10/2006	Created
      /// [Curtis_Beard]	   11/07/2012	Renamed
      /// </history>
      public static void Save(TextEditor[] editors)
      {
         if (editors != null)
         {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(editors.Length);
            __TextEditors = new TextEditor[editors.Length];
            __TextEditors = editors;

            foreach (TextEditor editor in editors)
            {
               if (builder.Length > 0)
               {
                  builder.Append(DELIMETER);
               }

               builder.Append(editor.ToString());
            }

            AstroGrep.Core.GeneralSettings.TextEditors = builder.ToString();
         }
         else
         {
            __TextEditors = null;
            AstroGrep.Core.GeneralSettings.TextEditors = string.Empty;
         }

         AstroGrep.Core.GeneralSettings.Save();
      }

      #region Private Methods

      /// <summary>
      /// Open the defined editor for a file that the user has double clicked on.
      /// </summary>
      /// <param name="textEditor">Text editor object reference</param>
      /// <param name="path">Fully qualified file path</param>
      /// <param name="line">Line number</param>
      /// <param name="column">Column position</param>
      /// <param name="searchText">Current search text</param>
      /// <history>
      /// [Curtis_Beard]	   07/10/2006	ADD: Initial
      /// [Curtis_Beard]	   07/26/2006	ADD: 1512026, column position
      /// [Curtis_Beard]	   08/13/2014	ADD: 80, add ability to open default app when no editor is specified
      /// [Curtis_Beard]		03/06/2015	FIX: 65, check editor for using quotes around file name, cleanup
      /// [Curtis_Beard]	   04/08/2015	CHG: add logging
      /// [Curtis_Beard]	   08/20/2015	CHG: 80, make check for empty editor to use default app the first check.
      /// [Curtis_Beard]	   08/16/2016	CHG: 108, PAT: 3, add search text, rename from OpenEditor to LaunchEditor
      /// </history>
      private static void LaunchEditor(TextEditor textEditor, string path, int line, int column, string searchText)
      {
         try
         {
            if (string.IsNullOrEmpty(textEditor.Editor))
            {
               OpenWithDefault(path);
            }
            else if (textEditor.Arguments.IndexOf("%1") == -1)
            {
               // no file argument specified
               MessageBox.Show(Language.GetGenericText("TextEditorsErrorNoCmdLineForFile"),
                  ProductInformation.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               // replace
               //  %1 with filename 
               //  %2 with line number
               //  %3 with column
               //  %4 with search text
               string args = textEditor.Arguments;
               if (textEditor.UseQuotesAroundFileName)
               {
                  path = "\"" + path + "\"";
               }
               args = args.Replace("%1", path);
               args = args.Replace("%2", line.ToString());
               args = args.Replace("%3", column.ToString());
               args = args.Replace("%4", searchText);

               System.Diagnostics.Process.Start(textEditor.Editor, args);
            }
         }
         catch (Exception ex)
         {
            LogClient.Instance.Logger.Error("Unable to open text editor for editor {0}, file {1} at line {2}, column {3}, with message {4}", textEditor.ToString(), path, line, column, ex.Message);

            MessageBox.Show(String.Format(Language.GetGenericText("TextEditorsErrorGeneric"), path, ex.Message),
               ProductInformation.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      #endregion
   }
}
