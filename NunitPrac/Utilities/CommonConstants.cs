using System.IO;

namespace NunitPrac.Utilities
{
    internal static class CommonConstants
    {
        internal static class DriverSettings
        {

            internal static string FilePath = Directory.GetParent(NUnit.Framework.TestContext.CurrentContext.TestDirectory).Parent.Parent + "//Driver//";
            
            // running tests on chrome
            
            internal static string BinaryLocationChrome = FilePath;

            // running tests on edge

            internal static string BinaryLocationEdge = FilePath;

            // running tests on firefox

            internal static string BinaryLocationFireFox = FilePath;

            internal static string ChromeBrowser = "Chrome";
            internal static string EdgeBrowser = "Edge";
            internal static string HeadlessBrowser = "Headless";
            internal static string FireFoxBrowser = "FireFox";
            internal static int DefaultWaitTime = 3000;
        }
    }
}
