﻿using ContosoCabs.ServiceModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoCabs.ResponseModels.Auth
{
    public class SignInResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("data")]
        public User Data { get; set; }
    }
}
