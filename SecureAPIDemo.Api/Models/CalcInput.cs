using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SecureAPIDemo.Api.Models
{
    public class CalcInput
    {
        [JsonProperty(PropertyName = "number1")]
        public int Number1 { get; set; }
        [JsonProperty(PropertyName = "number2")]
        public int Number2 { get; set; }
    }
}