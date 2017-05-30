using System;
using System.Collections.Generic;
using System.IO;

using libAstroGrep;

namespace AstroGrep
{
   /// <summary>
   /// Constant values for use in this application.
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
   /// [Curtis_Beard]		07/20/2006	Created
   /// [Curtis_Beard]		11/02/2006	ADD: Constants for plugin separators
   /// [Curtis_Beard]	   01/31/2012	CHG: 1947760, update default exclude list to exclude images (bmp,gif,jpg,jpeg,png)
   /// [Curtis_Beard]		02/24/2012	Created: 3488321, ability to change results font
   /// [Curtis_Beard]	   03/07/2012	ADD: 3131609, exclusions
   /// [Curtis_Beard]		10/27/2014	CHG: 88, add file extension column
   /// [Mark_Guerra]       11/06/2014  CHG: 91, exclude compiled java classes and compiled windows html help files (class,chm)
   /// [Curtis_Beard]	   04/08/2015	CHG: add logging
   /// [Curtis_Beard]	   06/02/2015	CHG: move some values to AstroGrep.Common
   /// [Curtis_Beard]	   08/18/2016	CHG: 109, allow up to 25 context lines
   /// [LinkNet]           04/27/2017	CHG: increase minimum search panel width to avoid cutoff text with higher DPI sizes
   /// </history>
   public class Constants
   {
      //Application default window size constants
      /// <summary>Application default width</summary>
      public const int WINDOW_WIDTH = 1024;
      /// <summary>Application default height</summary>
      public const int WINDOW_HEIGHT = 600;
      
      // Maximum value constants
      /// <summary>Maximum number of mru paths allowed</summary>
      public const int MAX_STORED_PATHS = 25;
      /// <summary>Maximum number of context lines allowed</summary>
      public const int MAX_CONTEXT_LINES = 25;

      /// <summary>Separator for search entries</summary>
      public static string SEARCH_ENTRIES_SEPARATOR = "|;;|";
      /// <summary>Separator for colors</summary>
      public static string COLOR_SEPARATOR = "-";
      /// <summary>Separator for fonts</summary>
      public static string FONT_SEPARATOR = "||";      
      /// <summary>Separator for text editor file types</summary>
      public static string TEXT_EDITOR_TYPE_SEPARATOR = "|";
      /// <summary>Separator for plugin arguments</summary>
      public static string PLUGIN_ARGS_SEPARATOR = "|@@|";

      // ListView column index constants
      /// <summary>File Index</summary>
      public const int COLUMN_INDEX_FILE = 0;
      /// <summary>Directory Index</summary>
      public const int COLUMN_INDEX_DIRECTORY = 1;
      /// <summary>File Extension Index</summary>
      public const int COLUMN_INDEX_FILE_EXT = 2;
      /// <summary>Date Index</summary>
      public const int COLUMN_INDEX_DATE = 3;
      /// <summary>Size Index</summary>
      public const int COLUMN_INDEX_SIZE = 4;
      /// <summary>Count Index</summary>
      public const int COLUMN_INDEX_COUNT = 5;
      /// <summary>Grep Index Index</summary>
      public const int COLUMN_INDEX_GREP_INDEX  = 6;   //Must be last

      // ListView column width constants
      /// <summary>File Column Width</summary>
      public const int COLUMN_WIDTH_FILE = 100;
      /// <summary>Directory Column Width</summary>
      public const int COLUMN_WIDTH_DIRECTORY = 200;
      /// <summary>File Extension Column Width</summary>
      public const int COLUMN_WIDTH_FILE_EXT = 110;
      /// <summary>Date Column Width</summary>
      public const int COLUMN_WIDTH_DATE = 140;
      /// <summary>Size Column Width</summary>
      public const int COLUMN_WIDTH_SIZE = 80;
      /// <summary>Count Column Width</summary>
      public const int COLUMN_WIDTH_COUNT = 60;

      //Exclusions window default column width constants
      /// <summary>Exclusions window default column enabled width</summary>
      public const int EXCLUSIONS_DISPLAY_COLUMN_WIDTH_ENABLED = 75;
      /// <summary>Exclusions window default column category width</summary>
      public const int EXCLUSIONS_DISPLAY_COLUMN_WIDTH_CATEGORY = 120;
      /// <summary>Exclusions window default column type width</summary>
      public const int EXCLUSIONS_DISPLAY_COLUMN_WIDTH_TYPE = 120;
      /// <summary>Exclusions window default column value width</summary>
      public const int EXCLUSIONS_DISPLAY_COLUMN_WIDTH_VALUE = 160;
      /// <summary>Exclusions window default column option width</summary>
      public const int EXCLUSIONS_DISPLAY_COLUMN_WIDTH_OPTION = 100;
      
      //LogDisplay window default column width constants
      /// <summary>LogDisplay window default column date width</summary>
      public const int LOG_DISPLAY_COLUMN_WIDTH_DATE = 175;
      /// <summary>LogDisplay window default column type width</summary>
      public const int LOG_DISPLAY_COLUMN_WIDTH_TYPE = 85;
      /// <summary>LogDisplay window default column value width</summary>
      public const int LOG_DISPLAY_COLUMN_WIDTH_VALUE = 600;
      /// <summary>LogDisplay window default column details width</summary>
      public const int LOG_DISPLAY_COLUMN_WIDTH_DETAILS = 425;

      //Options text editor window default column width constants 
      /// <summary>Options text editor window default column 0 width</summary>
      public const int OPTIONS_TEXT_EDITOR_COLUMN_0_WIDTH = 100;
      /// <summary>Options text editor window default column 1 width</summary>
      public const int OPTIONS_TEXT_EDITOR_COLUMN_1_WIDTH = 235;
      /// <summary>Options text editor window default column 2 width</summary>
      public const int OPTIONS_TEXT_EDITOR_COLUMN_2_WIDTH = 115;
      /// <summary>Options text editor window default column 3 width</summary>
      public const int OPTIONS_TEXT_EDITOR_COLUMN_3_WIDTH = 75;

      //Options plugins window default column width constants 
      /// <summary>Options plugins window default column 0 width</summary>
      public const int OPTIONS_PLUGINS_COLUMN_0_WIDTH = 90;
      /// <summary>Options plugins window default column 1 width</summary>
      public const int OPTIONS_PLUGINS_COLUMN_1_WIDTH = 245;
      /// <summary>Options plugins window default column 2 width</summary>
      public const int OPTIONS_PLUGINS_COLUMN_2_WIDTH = 145;

      //Options files window default column width constants 
      /// <summary>Options files window default column 0 width</summary>
      public const int OPTIONS_FILES_COLUMN_0_WIDTH = 75;
      /// <summary>Options files window default column 1 width</summary>
      public const int OPTIONS_FILES_COLUMN_1_WIDTH = 320;
      /// <summary>Options files window default column 2 width</summary>
      public const int OPTIONS_FILES_COLUMN_2_WIDTH = 130;
      
      /// <summary>Identifier for all file types</summary>
      public const string ALL_FILE_TYPES = "*";

      /// <summary>Default language</summary>
      public static string DEFAULT_LANGUAGE = "en-us";

      /// <summary>Default extension exclusion list</summary>
      private static string DEFAULT_EXTENSION_EXCLUDE_LIST = ".exe;.dll;.pdb;.msi;.sys;.ppt;.gif;.jpg;.jpeg;.png;.bmp;.class;.chm";

      /// <summary>Default search panel width</summary>
      public const int DEFAULT_SEARCH_PANEL_WIDTH = 290;

      /// <summary>
      /// Gets the default exclusions
      /// </summary>
      /// <history>
      /// [Curtis_Beard]	   03/07/2012	ADD: 3131609, exclusions
      /// [Curtis_Beard]	   11/06/2014	CHG: update to FilterItem
      /// </history>
      public static string DefaultFilterItems
      {
         get
         {
            return FilterItem.ConvertFilterItemsToString(GetDefaultFilterItemsList());
         }
      }

      /// <summary>
      /// Converts the default extensions list to the a FilterItem list.
      /// </summary>
      /// <returns>List of FilterItems</returns>
      /// <history>
      /// [Curtis_Beard]	   03/07/2012	ADD: 3131609, exclusions
      /// [Curtis_Beard]	   09/18/2013	ADD: 56, add suggested default directory names to exclude for common apps
      /// [Curtis_Beard]	   11/06/2014	CHG: update to FilterItem
      /// </history>
      private static List<FilterItem> GetDefaultFilterItemsList()
      {
         var list = new List<FilterItem>();

         // default extensions
         var exts = DEFAULT_EXTENSION_EXCLUDE_LIST.Split(';');
         foreach (var ext in exts)
         {
            var item = new FilterItem(new FilterType(FilterType.Categories.File, FilterType.SubCategories.Extension), ext, FilterType.ValueOptions.None, false, true);
            list.Add(item);
         }

         // default directory names to ignore (Git, Mercurial, SVN, CVS, Eclipse Metadata, Eclipse Settings)
         list.Add(new FilterItem(new FilterType(FilterType.Categories.Directory, FilterType.SubCategories.Name), ".git", FilterType.ValueOptions.Equals, false, true));
         list.Add(new FilterItem(new FilterType(FilterType.Categories.Directory, FilterType.SubCategories.Name), ".hg", FilterType.ValueOptions.Equals, false, true));
         list.Add(new FilterItem(new FilterType(FilterType.Categories.Directory, FilterType.SubCategories.Name), ".svn", FilterType.ValueOptions.Equals, false, true));
         list.Add(new FilterItem(new FilterType(FilterType.Categories.Directory, FilterType.SubCategories.Name), ".cvs", FilterType.ValueOptions.Equals, false, true));
         list.Add(new FilterItem(new FilterType(FilterType.Categories.Directory, FilterType.SubCategories.Name), ".metadata", FilterType.ValueOptions.Equals, false, true));
         list.Add(new FilterItem(new FilterType(FilterType.Categories.Directory, FilterType.SubCategories.Name), ".settings", FilterType.ValueOptions.Equals, false, true));

         return list;
      }
   }
}
