namespace Proxy.Example2
{
    using System;

    public class SecurityCamera : ISecurityCamera
    {
        private readonly string cameraLocation;

        public SecurityCamera(string cameraLocation)
        {
            this.cameraLocation = cameraLocation;
        }

        public void DisplayLiveFeed()
        {
            Console.WriteLine($"Displaying live feed from the {this.cameraLocation} camera.");
        }
    }
}
