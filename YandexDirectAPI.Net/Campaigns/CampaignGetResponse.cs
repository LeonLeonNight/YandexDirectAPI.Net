using System.Collections.Generic;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignGetResponse : StatusMessage
    {
        public GetResult result { get; set; }
    }

    public class GetResult
    {
        public List<Campaign> Campaigns { get; set; }
        public long LimitedBy { get; set; }
    }
}
