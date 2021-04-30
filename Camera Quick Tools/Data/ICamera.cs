namespace Camera_Quick_Tools.Data
{
    public interface ICamera
    {
        public string CameraName { get; set; }
        public string IPAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public string StaticImageURL { get; set; }

        
        
    }
}