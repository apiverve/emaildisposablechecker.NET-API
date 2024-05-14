using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("isDisposable")]
    public bool isDisposable { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("domain")]
    public string domain { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
