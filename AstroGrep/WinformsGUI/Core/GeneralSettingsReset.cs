using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroGrep.Core
{
   /// <summary>
   /// Used to reset the general settings.
   /// </summary>
   /// <remarks>
   ///   AstroGrep File Searching Utility. Written by Theodore L. Ward
   ///   Copyright (C) 2002 AstroComma Incorporated.
   ///   
   ///   This program is free software; you can redistribute it and/or
   ///   modify it under the terms of the GNU General public License
   ///   as published by the Free Software Foundation; either version 2
   ///   of the License, or (at your option) any later version.
   ///   
   ///   This program is distributed in the hope that it will be useful,
   ///   but WITHOUT ANY WARRANTY; without even the implied warranty of
   ///   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   ///   GNU General public License for more details.
   ///   
   ///   You should have received a copy of the GNU General public License
   ///   along with this program; if not, write to the Free Software
   ///   Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
   /// 
   ///   The author may be contacted at:
   ///   ted@astrocomma.com or curtismbeard@gmail.com
   /// </remarks>
   /// <history>
   /// [LinkNet]        05/03/2017  ADD: Created
   /// </history>
   public sealed class GeneralSettingsReset
   {
      /// <summary>
      /// Set main window positions to default values.
      /// </summary>
      /// <history>
      /// [LinkNet]        05/03/2017  ADD: Created
      /// </history>
      public static void WindowSetDefaultPositions()
      {
         // set default main window positions
         GeneralSettings.WindowTop = -1;
         GeneralSettings.WindowLeft = -1;
         GeneralSettings.WindowWidth = -1;
         GeneralSettings.WindowHeight = -1;
         GeneralSettings.WindowState = -1;
         GeneralSettings.WindowSearchPanelWidth = -1;
         GeneralSettings.WindowFilePanelHeight = -1;
      }

      /// <summary>
      /// Set file window column positions to default values.
      /// </summary>
      /// <history>
      /// [LinkNet]        05/03/2017  ADD: Created
      /// </history>
      public static void WindowFileSetDefaultPositions()
      {
         // set default file window column positions
         GeneralSettings.WindowFileColumnNameWidth = -1;
         GeneralSettings.WindowFileColumnLocationWidth = -1;
         GeneralSettings.WindowFileColumnFileExtWidth = -1;
         GeneralSettings.WindowFileColumnDateWidth = -1;
         GeneralSettings.WindowFileColumnSizeWidth = -1;
         GeneralSettings.WindowFileColumnCountWidth = -1;
      }

      /// <summary>
      /// Set log display window and column positions to default values.
      /// </summary>
      /// <history>
      /// [LinkNet]        05/03/2017  ADD: Created
      /// </history>
      public static void LogDisplaySetDefaultPositions()
      {
         // set default log display window positions
         GeneralSettings.LogDisplayTop = -1;
         GeneralSettings.LogDisplayLeft = -1;
         GeneralSettings.LogDisplayWidth = -1;
         GeneralSettings.LogDisplayHeight = -1;

         // set default log display window column positions
         GeneralSettings.LogDisplayColumnDateWidth = -1;
         GeneralSettings.LogDisplayColumnTypeWidth = -1;
         GeneralSettings.LogDisplayColumnValueWidth = -1;
         GeneralSettings.LogDisplayColumnDetailsWidth = -1;
      }

      /// <summary>
      /// Set exclusions display window and column positions to default values.
      /// </summary>
      /// <history>
      /// [LinkNet]        05/03/2017  ADD: Created
      /// </history>
      public static void ExclusionsDisplaySetDefaultPositions()
      {
         // set default exclusions display window positions
         GeneralSettings.ExclusionsDisplayTop = -1;
         GeneralSettings.ExclusionsDisplayLeft = -1;
         GeneralSettings.ExclusionsDisplayWidth = -1;
         GeneralSettings.ExclusionsDisplayHeight = -1;

         // set default exclusions window column positions
         GeneralSettings.ExclusionsDisplayColumnEnabledWidth = -1;
         GeneralSettings.ExclusionsDisplayColumnCategoryWidth = -1;
         GeneralSettings.ExclusionsDisplayColumnTypeWidth = -1;
         GeneralSettings.ExclusionsDisplayColumnValueWidth = -1;
         GeneralSettings.ExclusionsDisplayColumnOptionWidth = -1;
      }
   }
}
