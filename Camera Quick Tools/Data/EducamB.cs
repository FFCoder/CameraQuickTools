using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Camera_Quick_Tools.Data
{
    public class EducamB : ICameraWithLens
    {
        public EducamB(string cameraName, string iPAddress, string username, string password)
        {
            this.CameraName = cameraName;
            this.IPAddress = iPAddress;
            this.Username = username;
            this.Password = password;

        }
        public EducamB(string iPAddress, string username, string password)
        {
            this.IPAddress = iPAddress;
            this.Username = username;
            this.Password = password;
            this.CameraName = GetCameraName().Result;
            
        }
        public string OpenLensURL { get; set; } = "/cgi-bin/configManager.cgi?action=setConfig&AELensMask[0].Status=true";
        public string CloseLensURL { get; set; } = "/cgi-bin/configManager.cgi?action=setConfig&AELensMask[0].Status=false";
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

        public void OpenLens()
        {
            throw new System.NotImplementedException();
        }
        private async Task<string> GetCameraName(){
            string rawName = await $"http://{IPAddress}/cgi-bin/configManager.cgi?action=getConfig&name=ChannelTitle".GetStringAsync();
            string[] splitRawName = rawName.Split("=");
            return splitRawName[splitRawName.Length - 1];
        }

        public LensStatus GetLensStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}