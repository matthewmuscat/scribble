﻿#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

namespace Newtonsoft.Json.Tests.Documentation
{
  public class LinqToJsonTests
  {
    // start code ThisIsAInvalidCodeSnippet
    public void LinqToJsonBasic()
    {
      JObject o = JObject.Parse(@"{
        'CPU': 'Intel',
        'Drives': [
          'DVD read/writer',
          '500 gigabyte hard drive'
        ]
      }");

      string cpu = (string)o["CPU"];
      // Intel

      string firstDrive = (string)o["Drives"][0];
      // DVD read/writer

      IList<string> allDrives = o["Drives"].Select(t => (string)t).ToList();
      // DVD read/writer
      // 500 gigabyte hard drive
    }
  }
}