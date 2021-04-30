namespace Camera_Quick_Tools.Data
{
    public enum LensStatus {
        OPEN,
        CLOSE,
        UNKNOWN
    }
    public interface ICameraWithLens : ICamera
    {
         public string OpenLensURL { get; set; }
         public string CloseLensURL { get; set; }
         public LensStatus LensStatus { get; set; }
         public void OpenLens();
         public void CloseLens();
         public LensStatus GetLensStatus();
    }
}