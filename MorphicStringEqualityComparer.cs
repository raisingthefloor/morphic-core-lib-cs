// Copyright 2022-2023 Raising the Floor - US, Inc.
//
// Licensed under the New BSD license. You may not use this file except in
// compliance with this License.
//
// You may obtain a copy of the License at
// https://github.com/raisingthefloor/morphic-core-lib-cs/blob/main/LICENSE
//
// The R&D leading to these results received funding from the:
// * Rehabilitation Services Administration, US Dept. of Education under
//   grant H421A150006 (APCP)
// * National Institute on Disability, Independent Living, and
//   Rehabilitation Research (NIDILRR)
// * Administration for Independent Living & Dept. of Education under grants
//   H133E080022 (RERC-IT) and H133E130028/90RE5003-01-00 (UIITA-RERC)
// * European Union's Seventh Framework Programme (FP7/2007-2013) grant
//   agreement nos. 289016 (Cloud4all) and 610510 (Prosperity4All)
// * William and Flora Hewlett Foundation
// * Ontario Ministry of Research and Innovation
// * Canadian Foundation for Innovation
// * Adobe Foundation
// * Consumer Electronics Association Foundation

using System;
using System.Collections.Generic;

namespace Morphic.Core;

public class MorphicStringEqualityComparer : IEqualityComparer<string>
{
     StringComparison ComparisonType;

     public MorphicStringEqualityComparer(StringComparison comparisonType = StringComparison.Ordinal)
     {
          this.ComparisonType = comparisonType;
     }

     public bool Equals(string? x, string? y)
     {
          if (x is null && y is null)
          {
               // string are both null
               return true;
          }
          else if (x is null || y is null)
          {
               // one string is null and the other string is not null
               return false;
          }
          else if (String.Compare(x!, y!, this.ComparisonType) == 0)
          {
               // strings are both non-null and are equal
               return true;
          }
          else
          {
               // string are both non-null but are not equal
               return false;
          }
     }

     public int GetHashCode(string obj)
     {
          return obj.GetHashCode();
     }
}
