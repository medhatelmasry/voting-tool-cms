using System;

namespace Web.Models.Helpers
{
    public static class Utility
    {
        public static string GetCurrentDateTime => DateTime.Now.ToString("yyyyMMddHHmmss");
    }
}
