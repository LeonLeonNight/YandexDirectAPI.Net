using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignArchive
    {
        public string @method { get; set; }
        public CampaignArchiveParameters @params { get; set; }
    }
    public class CampaignArchiveParameters
    {
        public long[] Ids { get; set; }
    }
}
