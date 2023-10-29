### [OvrClient.cs](https://github.com/DevOculus-Meta-Quest/LibOVR/blob/main/src/LibOVR/OvrClient.cs)
- **Class `OvrClient`**: Manages the lifecycle of the Oculus VR session.
  - **Methods**:
    - `Detect(int timeoutMilliseconds)`: Detects if OVR service is running.
    - `TryInitialize(out OvrClient ovrClient)`: Tries to initialize the OVR client.
    - `TryCreateSession(out OvrSession ovrSession)`: Tries to create a new OVR session.

### [OvrSession.cs](https://github.com/DevOculus-Meta-Quest/LibOVR/blob/main/src/LibOVR/OvrSession.cs)
- **Class `OvrSession`**: Represents a session of the OVR client.
  - **Methods**:
    - `GetHmdDesc()`: Gets the description of the HMD.
    - `GetFovTextureSize(OvrEyeType eye, OvrFovPort fov, float pixelsPerDisplayPixel)`: Gets the texture size based on FOV.
    - `CreateTextureSwapChainDX(IntPtr dxDevice, OvrTextureSwapChainDesc desc, out OvrTextureSwapChain textureSwapChain)`: Creates a texture swap chain for DirectX.

### [OvrTrackingState.cs](https://github.com/DevOculus-Meta-Quest/LibOVR/blob/main/src/LibOVR/OvrTrackingState.cs)
- **Struct `OvrTrackingState`**: Contains tracking state information.
  - **Properties**:
    - `HeadPose`: Pose of the head.
    - `StatusFlags`: Status flags related to tracking.

### [Native.cs](https://github.com/DevOculus-Meta-Quest/LibOVR/blob/main/src/LibOVR/Native.cs)
- **Class `Native`**: Contains PInvoke signatures to interact with the native OVR library.
  - **Methods**:
    - Various methods for interacting directly with the OVR native library such as `ovr_CreateTextureSwapChainDX`, `ovr_GetTrackingState`, etc.

### [OvrControllerType.cs](https://github.com/DevOculus-Meta-Quest/LibOVR/blob/main/src/LibOVR/OvrControllerType.cs)
- **Enum `OvrControllerType`**: Enumerates different types of controllers like LTouch, RTouch, XBox, etc.

### [OvrInputState.cs](https://github.com/DevOculus-Meta-Quest/LibOVR/blob/main/src/LibOVR/OvrInputState.cs)
- **Struct `OvrInputState`**: Contains the state of the input devices.
  - **Properties**:
    - `TimeInSeconds`: Time when the input was captured.
    - `Buttons`: Button states.
    - `Touches`: Touch states.

---

### How to Use the Wrapper
1. **Initialization**
   - Initialize the OVR client using `OvrClient.TryInitialize(out OvrClient ovrClient)`.
   - Create a session using `ovrClient.TryCreateSession(out OvrSession ovrSession)`.

2. **Session Management**
   - Get HMD description using `ovrSession.GetHmdDesc()`.
   - Manage the lifecycle of the session, ensuring to dispose of it properly.

3. **Tracking**
   - Get tracking state using `ovrSession.GetTrackingState(double absTime, OvrBool latencyMarker)`.

4. **Input Handling**
   - Get input states using `ovrSession.GetInputState(OvrControllerType controllerType, out OvrInputState inputState)`.

5. **Rendering**
   - Manage texture swap chains for rendering, creating them using `ovrSession.CreateTextureSwapChainDX`.

### Examples
- **Initializing the OVR Client and Creating a Session**
  ```csharp
  OvrClient ovrClient;
  OvrClient.TryInitialize(out ovrClient);
  OvrSession ovrSession;
  ovrClient.TryCreateSession(out ovrSession);
  ```

- **Getting Tracking State**
  ```csharp
  double absTime = ...; // specify the absolute time
  OvrTrackingState trackingState = ovrSession.GetTrackingState(absTime, OvrBool.False);
  ```

- **Handling Input**
  ```csharp
  OvrInputState inputState;
  ovrSession.GetInputState(OvrControllerType.Touch, out inputState);
  ```

### Conclusion
The LibOVR wrapper provides a managed way to interact with the Oculus PCVR SDK v32. It allows for initialization, session management, tracking, input handling, and rendering functionalities, making it easier to develop VR applications using the Oculus SDK.