using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class JsonBody
    {
        [Newtonsoft.Json.JsonProperty("countPatients")]
        public int countPatients { get; set; } = 1;

        [Newtonsoft.Json.JsonProperty("countOperations")]
        public int countOperations { get; set; } = 40;

        [Newtonsoft.Json.JsonProperty("fileSavePath")]
        public string fileNamePath { get; set; } = Environment.CurrentDirectory;
    }
}
