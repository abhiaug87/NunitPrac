using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO;

namespace NunitPrac.Data
{
    public static class DataReader
    {
        private static readonly Dictionary<string, string> TestData = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "//Data//TestData.json").ReadToEnd());

        public static string ReadItem(string fileName, string itemName)
        {
            if (fileName == "TestData.json")
            {
                return TestData[itemName];
            }
            throw new Exception($"Value {itemName} not found in file {fileName}");
        }
    }
}