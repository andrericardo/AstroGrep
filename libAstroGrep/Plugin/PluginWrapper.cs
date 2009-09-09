namespace libAstroGrep.Plugin
{
   /// <summary>
   /// Wrapper class for IAstroGrepPlugins.
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
   /// [Curtis_Beard]		07/31/2006	Created
   /// [Andrew_Radford]     05/08/2008  CHG: Convert code to C# 3.5
   /// </history>
   public class PluginWrapper
   {

      #region Declarations

       #endregion

      /// <summary>
      /// Initializes a new instance of the PluginWrapper class.
      /// </summary>
      /// <history>
      /// [Curtis_Beard]		07/31/2006	Created
      /// </history>
      public PluginWrapper()
      {
          AssemblyName = string.Empty;
          AssemblyPath = string.Empty;
      }

       /// <summary>
      /// Initializes a new instance of the PluginWrapper class.
      /// </summary>
      /// <param name="plugin">IAstroGrepPlugin</param>
      /// <param name="assemblyPath">Fully qualified file path</param>
      /// <param name="assemblyName">Name of assembly</param>
      /// <param name="internalPlugin">If true the plugin is internal, False is external.</param>
      /// <param name="enabled">If true the plugin is enabled, False is disabled.</param>
      /// <history>
      /// [Curtis_Beard]		07/31/2006	Created
      /// </history>
      public PluginWrapper(IAstroGrepPlugin plugin, string assemblyPath, 
                           string assemblyName, bool internalPlugin, bool enabled)
      {
         Plugin = plugin;
         AssemblyPath = assemblyPath;
         AssemblyName = assemblyName;
         Internal = internalPlugin;
         Enabled = enabled;
      }

       /// <summary>
       /// Contains the IAstroGrepPlugin.
       /// </summary>
       /// <history>
       /// [Curtis_Beard]		07/31/2006	Created
       /// </history>
       public IAstroGrepPlugin Plugin { get; set; }

       /// <summary>
       /// Determines whether the plugin is enabled or disabled.
       /// </summary>
       /// <history>
       /// [Curtis_Beard]		07/31/2006	Created
       /// </history>
       public bool Enabled { get; set; }

       /// <summary>
       /// Determines whether the plugin is an Internal or External plugin.
       /// </summary>
       /// <history>
       /// [Curtis_Beard]		07/31/2006	Created
       /// </history>
       public bool Internal { get; set; }

       /// <summary>
       /// Contains the fully qualified path to the plugin.
       /// </summary>
       /// <history>
       /// [Curtis_Beard]		07/31/2006	Created
       /// </history>
       public string AssemblyPath { get; set; }

       /// <summary>
       /// Contains the full assembly name of the plugin.
       /// </summary>
       /// <history>
       /// [Curtis_Beard]		07/31/2006	Created
       /// </history>
       public string AssemblyName { get; set; }
   }
}