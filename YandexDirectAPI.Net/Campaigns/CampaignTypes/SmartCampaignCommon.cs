using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class SmartCampaignCommon
    {
        public SmartCampaignStrategy BiddingStrategy { get; set; }
        public CampaignSettings Settings { get; set; }
    }

    public class SmartCampaignStrategy
    {
        public SmartCampaignSearchStrategy Search { get; set; }

    }
    public class SmartCampaignSearchStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyAverageCpcPerCampaign AverageCpcPerCampaign { get; set; }
        public StrategyAverageCpcPerFilter AverageCpcPerFilter { get; set; }
    }
}
