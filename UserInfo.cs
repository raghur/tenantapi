using System;

namespace tenantapi
{
    public class UserInfo
    {
        public Guid id { get; set; }
        public string email { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string company { get; set; }
        public string location { get; set; }
    }
}
