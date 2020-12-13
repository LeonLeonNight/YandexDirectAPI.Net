using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignUpdateRequest
    {
        public string @method { get; set; }
        public CampaignUpdateParameters @params { get; set; }
    }

    public class CampaignUpdateParameters
    {
        public List<Campaign> Campaigns { get; set; }
    }
}
