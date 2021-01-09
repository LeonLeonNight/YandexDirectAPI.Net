using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class MobileAppCampaignCommon
    {
        public MobileCampaignStrategy BiddingStrategy { get; set; }
        public CampaignSettings Settings { get; set; }
    }
    public class MobileCampaignStrategy
    {
        public MobileAppCampaignSearchStrategy Search { get; set; }
        public MobileAppCampaignNetworkStrategy Network { get; set; }
    }
    public class MobileAppCampaignSearchStrategy
    {
        [Required]
        public string BiddingStrategyType { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumAppInstalls WbMaximumAppInstalls { get; set; }
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpi AverageCpi { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
    }

    public class MobileAppCampaignNetworkStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyNetworkDefault NetworkDefault { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumAppInstalls WbMaximumAppInstalls { get; set; }
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpi AverageCpi { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
    }
}
