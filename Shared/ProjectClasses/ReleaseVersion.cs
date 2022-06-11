namespace Shared.ProjectClasses
{
    public class ReleaseVersion
    {
        public int Major { get; set; } = 1;
        public int Minor { get; set; } = 0;

        public ReleaseVersion(int major, int minor)
        {
            Major = major;
            Minor = minor;
        }

        public ReleaseVersion(string version)
        {
            if (string.IsNullOrEmpty(version))
                return;

            version = version.Trim();
            version = version.ToLower();
            var versionArray = version.Split('.');

            switch (versionArray.Length)
            {
                case 2:
                    Major = int.Parse(versionArray[0]);
                    Minor = int.Parse(versionArray[1]);
                    break;
                case 1:
                default:
                    break;
            }
        }

        public ReleaseVersion() { }

        public override string ToString()
        {
            return $"{Major}.{Minor}";
        }
    }
}