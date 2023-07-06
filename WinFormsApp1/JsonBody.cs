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
        public int countPatients { get; set; }

        [Newtonsoft.Json.JsonProperty("countOperations")]
        public int countOperations { get; set; }
    }
}
