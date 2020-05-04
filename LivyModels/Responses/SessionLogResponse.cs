﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Livy.Net.LivyModels.Responses
{
    public class SessionLogResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("from")]
        public int From { get; set; }
        
        [JsonProperty("size")]
        public int Size { get; set; }
        
        [JsonProperty("log")]
        public IEnumerable<string> Log { get; set; }

        public SessionLogResponse(Models.Responses.SessionLogResponse response)
        {
            Id = response.Id;
            From = response.From;
            Size = response.Size;
            Log = response.Log;
        }

        public SessionLogResponse()
        {
        }
    }
}