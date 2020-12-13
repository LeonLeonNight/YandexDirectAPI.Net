using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class YandexAPIResponse : StatusMessage
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public List<Campaign> Campaigns { get; set; }
        public long LimitedBy { get; set; }
    }

    public class StatusMessage
    {
        public Error error { get; set; }
    }

}
