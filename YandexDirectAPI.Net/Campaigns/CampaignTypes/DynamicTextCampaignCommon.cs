using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class DynamicTextCampaignCommon
    {
        public DynamicTextCampaignStrategy BiddingStrategy { get; set; }
        public CampaignSettings Settings { get; set; }
        public Counters CounterIds { get; set; }
        public PriorityGoalsArray PriorityGoals { get; set; }
        /// <summary>
        /// ( "FC" | "LC" | "LSC" | "LYDC" )
        /// </summary>
        public string AttributionModel { get; set; }
    }

    public class DynamicTextCampaignStrategy
    {
        public DynamicTextCampaignSearchStrategy Search { get; set; }
        public DynamicTextCampaignNetworkStrategy Network { get; set; }
    }

    public class DynamicTextCampaignSearchStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumConversionRate WbMaximumConversionRate { get; set; }
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpa AverageCpa { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
    }

    public class DynamicTextCampaignNetworkStrategy
    {
        /// <summary>
        /// ( "SERVING_OFF" ) 
        /// </summary>
        public string BiddingStrategyType { get; set; }
    }

    public class Counters
    {
        public int[] Items { get; set; }
    }
}
