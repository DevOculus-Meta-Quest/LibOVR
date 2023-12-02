﻿#region License
//   Copyright 2023 Eliminater74
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
#endregion

using System;
using System.Runtime.InteropServices;

namespace nkast.LibOVR
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public unsafe struct OvrGraphicsLuid
    {
        private fixed byte Reserved[8];

        public override string ToString()
        {
            return String.Format("{{Reserved: [{0:X2},{1:X2},{2:X2},{3:X2},{4:X2},{5:X2},{6:X2},{7:X2}] }}",
                   Reserved[0], Reserved[1], Reserved[2], Reserved[3], Reserved[4], Reserved[5], Reserved[6], Reserved[7]);
        }
    }
}
