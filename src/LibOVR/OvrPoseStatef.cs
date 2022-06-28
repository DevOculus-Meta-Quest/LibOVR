﻿#region License
//   Copyright 2022 Kastellanos Nikolaos
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
    public unsafe struct OvrPoseStatef
    {
        public OvrPosef ThePose;
        public OvrVector3f AngularVelocity;
        public OvrVector3f LinearVelocity;
        public OvrVector3f AngularAcceleration;
        public OvrVector3f LinearAcceleration;

        fixed byte pad0[4];

        public double TimeInSeconds; ///< Absolute time that this pose refers to. \see ovr_GetTimeInSeconds

        public override string ToString()
        {
            return String.Format("{{ThePose: {0}, AngularVelocity: {1}, LinearVelocity: {2}, AngularAcceleration: {3}, LinearAcceleration: {4} }}",
                   ThePose, AngularVelocity, LinearVelocity, AngularAcceleration, LinearAcceleration);
        }
    }

}
