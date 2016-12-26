﻿//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
  [TestClass]
  public class ColorHSVTests : ColorBaseTests<ColorHSV>
  {
    [TestMethod]
    public void Test_IComparable()
    {
      ColorHSV first = new ColorHSV(0.4, 0.3, 0.2);

      Test_IComparable(first);

      ColorHSV second = new ColorHSV(0.1, 0.2, 0.3);

      Test_IComparable_FirstLower(first, second);

      second = new ColorHSV(0.4, 0.3, 0.2);

      Test_IComparable_Equal(first, second);
    }

    [TestMethod]
    public void Test_IEquatable()
    {
      ColorHSV first = new ColorHSV(1.0, 0.5, 0.5);

      Test_IEquatable_NullAndSelf(first);

      ColorHSV second = new ColorHSV(1.0, 0.5, 0.5);

      Test_IEquatable_Equal(first, second);

      second = new ColorHSV(1.0, 0.5, 1.0);

      Test_IEquatable_NotEqual(first, second);
    }
  }
}