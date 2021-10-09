using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class CpmBannerCampaignCommon
    {
        public CpmBannerCampaignStrategy BiddingStrategy { get; set; }
    }
    public class CpmBannerCampaignStrategy
    {
        public CpmBannerCampaignSearchStrategy Search { get; set; }
        public CpmBannerCampaignNetworkStrategy Network { get; set; }
        public CampaignSettings Settings { get; set; }
         
    }
    public class CpmBannerCampaignSearchStrategy
    {
        /// <summary>
        /// "SERVING_OFF"
        /// </summary>
        public string BiddingStrategyType { get; set; }
    }
    public class CpmBannerCampaignNetworkStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyWbMaximumImpressions WbMaximumImpression { get; set; }
        public StrategyCpMaximumImpressions CpMaximumImpression { get; set; }
        public StrategyWbDecreasedPriceForRepeatedImpressions WbDecreasedPriceForRepeatedImpressions { get; set; }
        public StrategyCpDecreasedPriceForRepeatedImpressions CpDecreasedPriceForRepeatedImpressions { get; set; }
    }
}
