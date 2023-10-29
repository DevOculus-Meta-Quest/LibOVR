# LibOVR: A Wrapper for Oculus PCVR SDK v32

Welcome to LibOVR! This library serves as a wrapper for the Oculus PCVR SDK, providing a managed way to interact with Oculus VR functionalities. It simplifies the process of developing VR applications, allowing developers to focus on creating immersive experiences without getting bogged down by the complexities of the native SDK.

## Table of Contents
1. [Introduction](#introduction)
2. [Features](#features)
3. [Getting Started](#getting-started)
4. [Examples](#examples)
5. [Conclusion](#conclusion)
6. [Support and Contribution](#support-and-contribution)

## Introduction

LibOVR aims to make Oculus VR development smoother and more accessible. It encapsulates various functionalities such as initialization, session management, tracking, input handling, and rendering, providing a comprehensive interface for VR application development.

## Features

- **Initialization and Session Management**: Easily initialize the OVR client and manage VR sessions.
- **Tracking**: Obtain detailed tracking information for implementing immersive experiences.
- **Input Handling**: Handle inputs from various controllers efficiently.
- **Rendering**: Manage texture swap chains for rendering VR content.

## Getting Started

Before diving into the examples, ensure that you have properly set up your development environment and have a basic understanding of Oculus VR development.

## Examples

### 1. **Initializing the OVR Client and Creating a Session**

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

### 2. **Getting Tracking State**

```csharp
double absTime = ...; // specify the absolute time
OvrTrackingState trackingState = ovrSession.GetTrackingState(absTime, OvrBool.False);

// Accessing head pose
OvrPosef headPose = trackingState.HeadPose;
```

### 3. **Handling Input**

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

### 4. **Managing Texture Swap Chains**

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

## Conclusion

LibOVR is a powerful wrapper that simplifies Oculus VR development, allowing you to focus on creating immersive and engaging VR experiences. Explore the various functionalities, and don’t hesitate to dive into the code to understand the intricacies and unleash the full potential of this library.

## Support and Contribution

Feel free to contribute, report issues, or make suggestions by visiting the [GitHub repository](https://github.com/DevOculus-Meta-Quest/LibOVR). Your feedback is highly appreciated!