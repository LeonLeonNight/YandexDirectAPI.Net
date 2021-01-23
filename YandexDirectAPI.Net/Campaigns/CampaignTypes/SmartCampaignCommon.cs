using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class SmartCampaignCommon
    {
        public SmartCampaignStrategy BiddingStrategy { get; set; }
        public CampaignSettings Settings { get; set; }
        public long CounterId { get; set; }
        public PriorityGoalsArray PriorityGoals { get; set; }
    }

    public class SmartCampaignStrategy
    {
        public SmartCampaignSearchStrategy Search { get; set; }
        public SmartCampaignNetworkStrategy Network { get; set; }

    }
    public class SmartCampaignSearchStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyAverageCpcCampaign AverageCpcPerCampaign { get; set; }
        public StrategyAverageCpcFilter AverageCpcPerFilter { get; set; }
        public StrategyAverageCpaCampaign AverageCpaPerCampaign { get; set; }
        public StrategyAverageCpaFilter AverageCpaPerFilter { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
    }

    public class SmartCampaignNetworkStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyAverageCpcCampaign AverageCpcPerCampaign { get; set; }
        public StrategyAverageCpcFilter AverageCpcPerFilter { get; set; }
        public StrategyAverageCpaCampaign AverageCpaPerCampaign { get; set; }
        public StrategyAverageCpaFilter AverageCpaPerFilter { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
        public StrategyNetworkDefault NetworkDefaul { get; set; }
    }
}
