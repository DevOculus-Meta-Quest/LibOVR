<div align="center">

![LibOVR Logo](https://example.com/libovr-logo.png) <!-- Replace with your logo URL -->

# LibOVR: A Wrapper for Oculus PCVR SDK

**Simplifying Oculus VR Development for Immersive Experiences**

[![GitHub Issues](https://img.shields.io/github/issues/DevOculus-Meta-Quest/LibOVR.svg)](https://github.com/DevOculus-Meta-Quest/LibOVR/issues)
[![GitHub Pull Requests](https://img.shields.io/github/issues-pr/DevOculus-Meta-Quest/LibOVR.svg)](https://github.com/DevOculus-Meta-Quest/LibOVR/pulls)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

</div>

---

## 🌟 Introduction

**LibOVR** is your gateway to creating cutting-edge VR applications. This wrapper library for the Oculus PCVR SDK streamlines VR development, enabling you to focus on crafting immersive virtual experiences without the complexity of the native SDK.

## 📚 Table of Contents

- [Introduction](#-introduction)
- [Features](#-features)
- [Getting Started](#-getting-started)
- [Examples](#-examples)
- [Conclusion](#-conclusion)
- [Support and Contribution](#-support-and-contribution)

## 💡 Features

- **Initialization and Session Management**: Initiate and manage VR sessions with ease.
- **Tracking**: Capture precise movement and positioning data.
- **Input Handling**: Seamlessly process inputs from various VR controllers.
- **Rendering**: Efficiently manage VR content rendering.

## 🚀 Getting Started

To utilize LibOVR, ensure your development environment is set up for Oculus VR development. Familiarity with VR concepts is recommended.

## 📝 Examples

### Initializing the OVR Client and Creating a Session

```csharp
OvrClient ovrClient;
if (OvrClient.TryInitialize(out ovrClient))
{
    OvrSession ovrSession;
    if (ovrClient.TryCreateSession(out ovrSession))
    {
        // Your code here
    }
}
```

### Getting Tracking State

```csharp
double absTime = ...; // specify the absolute time
OvrTrackingState trackingState = ovrSession.GetTrackingState(absTime, OvrBool.False);

// Accessing head pose
OvrPosef headPose = trackingState.HeadPose;
```

### Handling Input

```csharp
OvrInputState inputState;
if (ovrSession.GetInputState(OvrControllerType.Touch, out inputState))
{
    // Check if a button is pressed
    if ((inputState.Buttons & OvrButton.A) != 0)
    {
        // Button A is pressed
    }
}
```

### Managing Texture Swap Chains

```csharp
OvrTextureSwapChainDesc desc = new OvrTextureSwapChainDesc
{
    Type = OvrTextureType._2D,
    Format = OvrTextureFormat.R8G8B8A8_UNORM_SRGB,
    ArraySize = 1,
    Width = 1024,
    Height = 1024,
    MipLevels = 1,
    SampleCount = 1,
    StaticImage = OvrBool.False,
};

OvrTextureSwapChain textureSwapChain;
ovrSession.CreateTextureSwapChainDX(dxDevice, desc, out textureSwapChain);
```

### Example 5: Session Status Checking
This example demonstrates how to check the status of the VR session, which is important for ensuring that the application responds correctly to changes in the VR environment.

```csharp
OvrSessionStatus sessionStatus;
ovrSession.GetSessionStatus(out sessionStatus);

if (sessionStatus.ShouldQuit)
{
    // Handle session quit request
}
if (sessionStatus.ShouldRecenter)
{
    // Handle recentering request
}
if (sessionStatus.IsVisible)
{
    // Session is visible and can proceed with rendering
}
```

### Example 6: Eye Rendering Information
This snippet shows how to obtain eye rendering information, which is crucial for rendering VR content correctly for each eye.

```csharp
OvrEyeRenderDesc[] eyeRenderDescs = new OvrEyeRenderDesc[2];
eyeRenderDescs[0] = ovrSession.GetRenderDesc(OvrEyeType.Left, ovrSession.DefaultEyeFov[0]);
eyeRenderDescs[1] = ovrSession.GetRenderDesc(OvrEyeType.Right, ovrSession.DefaultEyeFov[1]);

// Use eyeRenderDescs for rendering setup
```

### Example 7: Frame Submission
Here's an example of how to submit a frame for rendering, a key step in the VR rendering loop.

```csharp
OvrLayerEyeFov layer = new OvrLayerEyeFov();
layer.Header.Type = OvrLayerType.EyeFov;
layer.Header.Flags = OvrLayerFlags.None;

// Set up layer parameters, textures, and viewports for each eye
// ...

ovrSession.SubmitFrame(0, IntPtr.Zero, ref layer);
```

### Example 8: Handling Controller Input
This example demonstrates how to handle input from Oculus Touch controllers, an essential part of creating interactive VR experiences.

```csharp
OvrInputState touchState;
if (ovrSession.GetInputState(OvrControllerType.Touch, out touchState))
{
    if ((touchState.Buttons & OvrButton.One) != 0)
    {
        // Handle button one press
    }
    if ((touchState.Touches & OvrTouch.LIndexTrigger) != 0)
    {
        // Handle index trigger touch
    }
}
```

## 🌌 Conclusion

LibOVR empowers you to create next-generation VR experiences with ease. Dive into its functionalities, explore its capabilities, and contribute to its evolution!

## 🤝 Support and Contribution

Your contributions make LibOVR better! Report issues, suggest improvements, or contribute directly by visiting our [GitHub repository](https://github.com/DevOculus-Meta-Quest/LibOVR). We value your input!
