using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignUnArchive
    {
        public string @method { get; set; }
        public CampaignUnArchiveParameters @params { get; set; }
    }
    public class CampaignUnArchiveParameters
    {
        public long[] Ids { get; set; }
    }
}
