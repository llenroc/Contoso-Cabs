﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoCabs.ServiceModels;
using Newtonsoft.Json;

namespace ContosoCabs.ResponseModels.Private
{
    public class PriceEstimateResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<CabEstimate> Estimates { get; set; }
    }
}
