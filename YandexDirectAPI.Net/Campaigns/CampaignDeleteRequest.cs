using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignDeleteRequest
    {
        public string @method { get; set; }
        public CampaignDeleteParameters @params { get; set; }
    }

    public class CampaignDeleteParameters
    {
        public IdsCriteria SelectionCriteria { get; set; }
    }

    public class IdsCriteria
    {
        public long[] Ids { get; set; }
    }
}
