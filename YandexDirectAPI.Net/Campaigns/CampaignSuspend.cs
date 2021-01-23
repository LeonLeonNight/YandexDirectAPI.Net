using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignSuspend
    {
        public string @method { get; set; }
        public CampaignSuspendParameters @params { get; set; }
    }

    public class CampaignSuspendParameters
    {
        public long[] Ids { get; set; }
    }
}
