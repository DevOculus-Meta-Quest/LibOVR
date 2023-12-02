#region License
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
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct OvrInputState
    {
        public double TimeInSeconds;
        public OvrButton Buttons;
        public OvrTouch Touches;
        public OvrFixedArray2<float> IndexTrigger;
        public OvrFixedArray2<float> HandTrigger;
        public OvrFixedArray2<OvrVector2f> Thumbstick;
        public OvrControllerType ControllerType;
        public OvrFixedArray2<OvrVector2f> IndexTriggerNoDeadzone;
        public OvrFixedArray2<OvrVector2f> HandTriggerNoDeadzone;
        public OvrFixedArray2<OvrVector2f> ThumbstickNoDeadzone;
        public OvrFixedArray2<float> IndexTriggerRaw;
        public OvrFixedArray2<float> HandTriggerRaw;
        public OvrFixedArray2<OvrVector2f> ThumbstickRaw;

        // Method to check if CustomAction1 is pressed
        public bool IsCustomAction1Pressed()
        {
            return (Buttons & OvrButton.CustomAction1) == OvrButton.CustomAction1;
        }

        // Method to check if CustomAction2 is pressed
        public bool IsCustomAction2Pressed()
        {
            return (Buttons & OvrButton.CustomAction2) == OvrButton.CustomAction2;
        }

        public override string ToString()
        {
            return String.Format("{{TimeInSeconds: {0:#.####}, Buttons: [{1}], Touches: [{2}], IndexTrigger: {3}, HandTrigger: {4} }}",
                   TimeInSeconds, Buttons, Touches,
                   string.Format("[{0}, {1}]", IndexTrigger[0], IndexTrigger[1]),
                   string.Format("[{0}, {1}]", HandTrigger[0], HandTrigger[1])
                   );
        }
    }
}