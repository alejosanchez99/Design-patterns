namespace Proxy.Example2
{
    using System;

    public class SecurityCameraProxy : ISecurityCamera
    {
        private readonly SecurityCamera securityCamera;
        private bool hasAccess;

        public SecurityCameraProxy(string cameraLocation, bool hasAccess)
        {
            this.securityCamera = new SecurityCamera(cameraLocation);
            this.hasAccess = hasAccess;
        }
        public void DisplayLiveFeed()
        {
            if (this.hasAccess)
            {
                this.securityCamera.DisplayLiveFeed();
            }
            else
            {
                Console.WriteLine("Access denied. you don't have permission to view");
            }

        }
    }
}
