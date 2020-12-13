using System.Collections.Generic;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignGetResponse : StatusMessage
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public List<Campaign> Campaigns { get; set; }
        public long LimitedBy { get; set; }
    }
}
