using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace libAstroGrep.EncodingDetection.Caching
{
   /// <summary>
   /// Encapsulates an encoding cache item.
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
   /// [Curtis_Beard]		05/28/2015	FIX: 69, Created for speed improvements for encoding detection
   /// [Curtis_Beard]		05/26/2017	FIX: 97, detect file size change to read encoding again
   /// </history>
   [Serializable]
   public class EncodingCacheItem
   {
      /// <summary>Defined Encoding code page value</summary>
      public int CodePage;

      /// <summary>Name of detector used</summary>
      public string DetectorName;

      /// <summary>The file size</summary>
      [OptionalField(VersionAdded = 2)]
      public long FileSize;
   }
}
