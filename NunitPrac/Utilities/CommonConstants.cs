using System.IO;

namespace NunitPrac.Utilities
{
    internal static class CommonConstants
    {
        internal static class DriverSettings
        {
            // running tests on chrome
            internal static string filepath = Directory.GetParent(NUnit.Framework.TestContext.CurrentContext.TestDirectory).Parent.Parent + "//Driver//";
            internal static string BinaryLocationChrome = filepath;

            // running tests on edge

            internal static string BinaryLocationEdge = filepath;

            // running tests on edge

            internal static string BinaryLocationFireFox = filepath;

            internal static string ChromeBrowser = "Chrome";
            internal static string EdgeBrowser = "Edge";
            internal static string HeadlessBrowser = "Headless";
            internal static string FireFoxBrowser = "FireFox";
            internal static int DefaultWaitTime = 3000;
        }
    }
}
