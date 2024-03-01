
using Proxy.Example2;

ISecurityCamera bedroomCamera = new SecurityCameraProxy("bedroom", false);
bedroomCamera.DisplayLiveFeed();

ISecurityCamera livingroomCamera = new SecurityCameraProxy("living room", true);
livingroomCamera.DisplayLiveFeed();