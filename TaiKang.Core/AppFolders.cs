using Abp.Dependency;

namespace TaiKang
{
    public class AppFolders : IAppFolders, ISingletonDependency
    {
        public string TempFileDownloadFolder { get; set; }

        public string SampleProfileImagesFolder { get; set; }

        public string WebLogsFolder { get; set; }
        public string WebSiteImageFolder { get; set; }
    }
}