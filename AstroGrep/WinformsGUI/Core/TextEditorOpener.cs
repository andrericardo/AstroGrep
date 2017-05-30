using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroGrep.Core
{
   /// <summary>
   /// TextEditor opener object to wrap around necessary values to edit a file.
   /// </summary>
   /// <history>
   /// [Curtis_Beard]	   06/25/2015	Initial
   /// [Curtis_Beard]	   08/16/2016	CHG: moved to own file
   /// </history>
   public class TextEditorOpener
   {
      /// <summary>Full file path</summary>
      public string Path { get; set; }
      /// <summary>Line number</summary>
      public int LineNumber { get; set; }
      /// <summary>Column number</summary>
      public int ColumnNumber { get; set; }
      /// <summary>Current line's text</summary>
      public string LineText { get; set; }
      /// <summary>Current search text</summary>
      public string SearchText { get; set; }

      /// <summary>
      /// Create an instance of this class.
      /// </summary>
      public TextEditorOpener()
      {
         Path = string.Empty;
         LineNumber = 1;
         ColumnNumber = 1;
         LineText = string.Empty;
         SearchText = string.Empty;
      }

      /// <summary>
      /// Create an instance of this class.
      /// </summary>
      /// <param name="path">full file path</param>
      /// <param name="lineNumber">line number</param>
      /// <param name="columnNumber">column number</param>
      /// <param name="lineText">current line's text</param>
      /// <param name="searchText">current search text</param>
      public TextEditorOpener(string path, int lineNumber, int columnNumber, string lineText, string searchText)
         : this()
      {
         Path = path;
         LineNumber = lineNumber;
         ColumnNumber = columnNumber;
         LineText = lineText;
         SearchText = searchText;
      }

      /// <summary>
      /// Determines if object has a value or is empty.
      /// </summary>
      /// <returns>true if value present, false otherwise</returns>
      public bool HasValue()
      {
         return !string.IsNullOrEmpty(Path);
      }

      /// <summary>
      /// Create a TextEditorOpener from a MatchResult object.
      /// </summary>
      /// <param name="match">Current match result object</param>
      /// <param name="searchText">Current search text</param>
      /// <returns>TextEditorOpener object</returns>
      /// <history>
      /// [Curtis_Beard]	   05/27/2015	FIX: 73, open text editor even when no first match (usually during file only search)
      /// [Curtis_Beard]	   08/16/2016	CHG: move to TextEditorOpener class
      /// </history>
      public static TextEditorOpener FromMatch(libAstroGrep.MatchResult match, string searchText)
      {
         var opener = new TextEditorOpener();

         if (match != null)
         {
            // open the default editor at first match
            var lineNumber = 1;
            var columnNumber = 1;
            var lineText = string.Empty;

            var matchLine = match.GetFirstMatch();
            if (matchLine != null)
            {
               lineNumber = matchLine.LineNumber;
               columnNumber = matchLine.ColumnNumber;
               lineText = matchLine.Line;
            }

            opener = new TextEditorOpener(match.File.FullName, lineNumber, columnNumber, lineText, searchText);
         }

         return opener;
      }
   }
}
