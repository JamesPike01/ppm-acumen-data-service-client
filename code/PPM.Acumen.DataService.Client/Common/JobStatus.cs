namespace PPM.Acumen.DataService.Client.Common
{
    /// <summary>Valid values for async job status fields.</summary>
    public static class JobStatus
    {
        public const string Pending = "pending";
        public const string Running = "running";
        public const string Complete = "complete";
        public const string Failed = "failed";
    }
}
