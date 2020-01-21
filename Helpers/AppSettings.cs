using System;
namespace B_store.Helpers
{
    public class AppSettings
    {
        // Properties for Jwt Token Signature

        public string Site { get; set; }
        public string Audience { get; set; }
        public string ExpireTime { get; set; }
        public string Secret { get; set; }
    }
}
