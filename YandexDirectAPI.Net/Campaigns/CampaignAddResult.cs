using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignAddResult
    {
        public AddResult result { get; set; }
    }

    public class AddResult
    {
        public long Id { get; set; }
        public List<AddWarning> Warnings { get; set; }
        public List<AddError> Errors { get; set; }
    }

    public class AddWarning
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }

    public class AddError
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
