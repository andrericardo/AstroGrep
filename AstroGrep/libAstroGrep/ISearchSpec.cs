using System.Collections.Generic;

using libAstroGrep.EncodingDetection;

namespace libAstroGrep
{
   /// <summary>
   /// ISearchSpec interface to Grep.
   /// </summary>
   /// <remarks>
   /// AstroGrep File Searching Utility. Written by Theodore L. Ward
   /// Copyright (C) 2002 AstroComma Incorporated.
   /// 
   /// This program is free software; you can redistribute it and/or
   /// modify it under the terms of the GNU General Public License
   /// as published by the Free Software Foundation; either version 2
   /// of the License, or (at your option) any later version.
   /// 
   /// This program is distributed in the hope that it will be useful,
   /// but WITHOUT ANY WARRANTY; without even the implied warranty of
   /// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   /// GNU General Public License for more details.
   /// 
   /// You should have received a copy of the GNU General Public License
   /// along with this program; if not, write to the Free Software
   /// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
   /// 
   /// The author may be contacted at:
   /// ted@astrocomma.com or curtismbeard@gmail.com
   /// </remarks>
   /// <history>
   /// [Curtis_Beard]      02/09/2015	CHG: 92, support for specific file encodings
   /// [Curtis_Beard]      04/02/2015	CHG: remove line numbers option
   /// [Curtis_Beard]	   05/26/2015	FIX: 69, add encoding detection options
   /// [Curtis_Beard]	   09/29/2016	CHG: 24/115, use one interface for search in prep for saving to file
   /// </history>
   public interface ISearchSpec
   {
      /// <summary>Array of start directories</summary>
      string[] StartDirectories { get; }

      /// <summary>Full file paths to files that will be searched (if defined, StartDirectories ignored, can be used for Search within Results)</summary>
      string[] StartFilePaths { get; set; }

      /// <summary>Use of directory recursion for grep</summary>
      bool SearchInSubfolders { get; }

      /// <summary>Use of regular expressions for grep</summary>
      bool UseRegularExpressions { get; }

      /// <summary>Use of a case sensitive grep</summary>
      bool UseCaseSensitivity { get; }

      /// <summary>Use of a whole word match grep</summary>
      bool UseWholeWordMatching { get; }

      /// <summary>Use of negation of the grep results</summary>
      bool UseNegation { get; }

      /// <summary>The number of context lines included in grep results</summary>
      int ContextLines { get; }

      /// <summary>The search text</summary>
      string SearchText { get; }

      /// <summary>Whether to return only file names for grep results</summary>
      bool ReturnOnlyFileNames { get; }

      /// <summary>Sets list of FileEncoding objects to force encoding of certain files selected by user</summary>
      List<FileEncoding> FileEncodings { get; }

      /// <summary>Sets encoding options used when detecting encodings</summary>
      EncodingOptions EncodingDetectionOptions { get; }

      /// <summary>The FileFilter</summary>
      string FileFilter { get; }

      /// <summary>
      /// List of FilterItems that will filter out files/directories based on user inputted options.
      /// </summary>
      /// <remarks>
      /// Examples are Files that are readonly, binary, or the name contains certain text.
      /// Directories that are created after a certain date, or marked as system.
      /// </remarks>
      List<FilterItem> FilterItems { get; }
   }
}