using System.Collections.Generic;
using Newtonsoft.Json;

namespace App
{

    public class ResponseModel
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }


}