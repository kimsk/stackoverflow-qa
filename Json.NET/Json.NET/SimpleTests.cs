using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Json.NET
{
    [TestClass]
    public class SimpleTests
    {
        [TestMethod]
        public void ObjectToJson()
        {
            var obj = new { Name = "Programming F#", Author = "Chris Smith" };

            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            System.Diagnostics.Debug.WriteLine(json);
        }

        [TestMethod]
        public void QueryingJson()
        {
            var json = @"{""Name"": ""Programming F#"",""Author"": ""Chris Smith""}";
            
            JObject jObject = JObject.Parse(json);

            string name = (string)jObject["Name"]; // Programming F#
        }

        [TestMethod]
        public void JsonToArray()
        {
            string json = @"['F#', 'Erlang', 'C#', 'Haskell', 'Prolog']";

            JArray array = JArray.Parse(json);

            foreach (var item in array)
            {
                string name = (string)item;
            }
        }
    }
}
