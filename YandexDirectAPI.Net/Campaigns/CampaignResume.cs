using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignResume
    {
        public string @method { get; set; }
        public CampaignResumeParameters @params { get; set; }
    }
    public class CampaignResumeParameters
    {
        public long[] Ids { get; set; }
    }
}
