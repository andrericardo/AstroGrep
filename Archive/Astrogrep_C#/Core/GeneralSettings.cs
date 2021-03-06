using System;
using System.IO;

namespace AstroGrep.Core
{
   /// <summary>
   /// Used to access the general settings.
   /// </summary>
   /// <history>
   /// [Curtis_Beard]      11/02/2006  Created
   /// </history>
   public sealed class GeneralSettings
   {
      // This class is fully static.
      private GeneralSettings()  {}

      #region Declarations
      private static GeneralSettings __MySettings = null;

      private static readonly string Location = Path.Combine(Environment.CurrentDirectory, "AstroGrep.general.config");
      private const string VERSION = "1.0";

      private string resultsForeColor = string.Format("0{0}0{0}0{0}255", Constants.COLOR_SEPARATOR);
      private string resultsBackColor = string.Format("255{0}255{0}255{0}255", Constants.COLOR_SEPARATOR);
      private string matchForeColor = string.Format("251{0}127{0}6{0}255", Constants.COLOR_SEPARATOR);
      private string matchBackColor = string.Format("255{0}255{0}255{0}255", Constants.COLOR_SEPARATOR);
      private int mruListCount = 15;

      private string language = "English";
      private string extExcludeList = ".exe;.dll;.pdb;.sys;.ppt";

      private int windowLeft = -1;
      private int windowTop = -1;
      private int windowWidth = 640;
      private int windowHeight = 480;
      private int windowState = -1;

      private int searchPanelWidth = 240;
      private int filePanelHeight = 150;
      private int columnFile = 100;
      private int columnLocation = 200;
      private int columnDate = 150;
      private int columnCount = 60;

      private string searchStartPaths = string.Empty;
      private string searchFilters = string.Format("*.*{0}*.txt{0}*.java{0}*.htm, *.html{0}*.jsp, *.asp{0}*.js, *.inc{0}*.htm, *.html, *.jsp, *.asp{0}*.sql{0}*.bas, *.cls, *.vb{0}*.cs{0}*.cpp, *.c, *.h{0}*.asm", Constants.SEARCH_ENTRIES_SEPARATOR);
      private string searchTexts = string.Empty;

      private string textEditors = string.Format("notepad{0}%1{0}*", Constants.TEXT_EDITOR_ARGS_SEPARATOR);
      #endregion
      
      /// <summary>
      /// Contains the static reference of this class.
      /// </summary>
      private static GeneralSettings MySettings
      {
         get
         {
            if (__MySettings == null)
            {
               __MySettings = new GeneralSettings();
               SettingsIO.Load(__MySettings, Location, VERSION);
            }
            return __MySettings;
         }
      }

      /// <summary>
      /// Save the search options.
      /// </summary>
      /// <returns>Returns true on success, false otherwise</returns>
      static public bool Save()
      {
         return SettingsIO.Save(MySettings, Location, VERSION);
      }

      /// <summary>
      /// Gets/Sets the result fore color.
      /// </summary>
      static public string ResultsForeColor
      {
         get { return MySettings.resultsForeColor; }
         set { MySettings.resultsForeColor = value; }
      }

      /// <summary>
      /// Gets/Sets the result back color.
      /// </summary>
      static public string ResultsBackColor
      {
         get { return MySettings.resultsBackColor; }
         set { MySettings.resultsBackColor = value; }
      }

      /// <summary>
      /// Gets/Sets the highlight fore color.
      /// </summary>
      static public string HighlightForeColor
      {
         get { return MySettings.matchForeColor; }
         set { MySettings.matchForeColor = value; }
      }

      /// <summary>
      /// Gets/Sets the highlight back color.
      /// </summary>
      static public string HighlightBackColor
      {
         get { return MySettings.matchBackColor; }
         set { MySettings.matchBackColor = value; }
      }

      /// <summary>
      /// Gets/Sets the maximum number of mru path to save.
      /// </summary>
      static public int MaximumMRUPaths
      {
         get { return MySettings.mruListCount; }
         set { MySettings.mruListCount = value; }
      }

      /// <summary>
      /// Gets/Sets the application language.
      /// </summary>
      static public string Language
      {
         get { return MySettings.language; }
         set { MySettings.language = value; }
      }

      /// <summary>
      /// Gets/Sets the extension exclusion list.
      /// </summary>
      static public string ExtensionExcludeList
      {
         get { return MySettings.extExcludeList; }
         set { MySettings.extExcludeList = value; }
      }

      /// <summary>
      /// Gets/Sets the window's left value.
      /// </summary>
      static public int WindowLeft
      {
         get { return MySettings.windowLeft; }
         set { MySettings.windowLeft = value; }
      }

      /// <summary>
      /// Gets/Sets the window's top value.
      /// </summary>
      static public int WindowTop
      {
         get { return MySettings.windowTop; }
         set { MySettings.windowTop = value; }
      }

      /// <summary>
      /// Gets/Sets the window's height value.
      /// </summary>
      static public int WindowHeight
      {
         get { return MySettings.windowHeight; }
         set { MySettings.windowHeight = value; }
      }

      /// <summary>
      /// Gets/Sets the window's width value.
      /// </summary>
      static public int WindowWidth
      {
         get { return MySettings.windowWidth; }
         set { MySettings.windowWidth = value; }
      }

      /// <summary>
      /// Gets/Sets the window's WindowState value.
      /// </summary>
      static public int WindowState
      {
         get { return MySettings.windowState; }
         set { MySettings.windowState = value; }
      }

      /// <summary>
      /// Gets/Sets the window's search panel width value.
      /// </summary>
      static public int WindowSearchPanelWidth
      {
         get { return MySettings.searchPanelWidth; }
         set { MySettings.searchPanelWidth = value; }
      }

      /// <summary>
      /// Gets/Sets the window's file panel height value.
      /// </summary>
      static public int WindowFilePanelHeight
      {
         get { return MySettings.filePanelHeight; }
         set { MySettings.filePanelHeight = value; }
      }

      /// <summary>
      /// Gets/Sets the window's file list name column value.
      /// </summary>
      static public int WindowFileColumnNameWidth
      {
         get { return MySettings.columnFile; }
         set { MySettings.columnFile = value; }
      }

      /// <summary>
      /// Gets/Sets the window's file list location column value.
      /// </summary>
      static public int WindowFileColumnLocationWidth
      {
         get { return MySettings.columnLocation; }
         set { MySettings.columnLocation = value; }
      }

      /// <summary>
      /// Gets/Sets the window's file list date column value.
      /// </summary>
      static public int WindowFileColumnDateWidth
      {
         get { return MySettings.columnDate; }
         set { MySettings.columnDate = value; }
      }

      /// <summary>
      /// Gets/Sets the window's file list count column value.
      /// </summary>
      static public int WindowFileColumnCountWidth
      {
         get { return MySettings.columnCount; }
         set { MySettings.columnCount = value; }
      }

      /// <summary>
      /// Gets/Sets the search starting paths.
      /// </summary>
      static public string SearchStarts
      {
         get { return MySettings.searchStartPaths; }
         set { MySettings.searchStartPaths = value; }
      }

      /// <summary>
      /// Gets/Sets the search file filters.
      /// </summary>
      static public string SearchFilters
      {
         get { return MySettings.searchFilters; }
         set { MySettings.searchFilters = value; }
      }

      /// <summary>
      /// Gets/Sets the search's search texts.
      /// </summary>
      static public string SearchTexts
      {
         get { return MySettings.searchTexts; }
         set { MySettings.searchTexts = value; }
      }

      /// <summary>
      /// Gets/Sets the text editors.
      /// </summary>
      static public string TextEditors
      {
         get { return MySettings.textEditors; }
         set { MySettings.textEditors = value; }
      }
   }
}
