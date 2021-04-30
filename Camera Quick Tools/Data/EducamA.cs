using Flurl;
using Flurl.Http;

namespace Camera_Quick_Tools.Data
{
    public class EducamA : ICameraWithLens
    {
        public EducamA(string cameraName, string iPAddress, string username, string password)
        {
            this.CameraName = cameraName;
            this.IPAddress = iPAddress;
            this.Username = username;
            this.Password = password;

        }
        public string OpenLensURL { get; set; } = "/cgi-bin";
        public string CloseLensURL { get; set; }
        public LensStatus LensStatus { get; set; } = LensStatus.UNKNOWN;
        public string CameraName { get; set; }
        public string IPAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StaticImageURL { get; set; }

        public void CloseLens()
        {
            throw new System.NotImplementedException();
        }

        public LensStatus GetLensStatus()
        {
            throw new System.NotImplementedException();
        }

        public void OpenLens()
        {
            throw new System.NotImplementedException();
        }
    }
}