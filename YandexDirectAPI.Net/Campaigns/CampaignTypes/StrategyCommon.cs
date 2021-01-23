using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class StrategyMaximumClicks
    {
        public long WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
    }
    public class StrategyMaximumConversionRate
    {
        public long WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
        public long GoalId { get; set; }
    }
    public class StrategyAverageCpc
    {
        public long? WeeklySpendLimit { get; set; }
        public long AverageCpc { get; set; }
    }
    public class StrategyAverageCpaCampaign
    {
        public long WeeklySpendLimit { get; set; }
        public long BidCeiling { get; set; }
        public long GoalId { get; set; }
        public long AverageCpa { get; set; }
    }
    public class StrategyAverageCpi
    {
        public long? WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
        public long AverageCpa { get; set; }
    }
    public class StrategyWeeklyClickPackage
    {
        public long ClicksPerWeek { get; set; }
        public long? BidCeiling { get; set; }
        public long? AverageCpc { get; set; }
    }
    public class StrategyAverageRoi
    {
        public int ReserveReturn { get; set; }
        public long RoiCoef { get; set; }
        public long GoalId { get; set; }
        public long WeeklySpendLimit { get; set; }
        public long BidCeiling { get; set; }
        public long Profitability { get; set; }
    }
    public class StrategyPayForConversion
    {
        public long Cpa { get; set; }
        public long GoalId { get; set; }
        public long? WeeklySpendLimit { get; set; }
    }
    public class StrategyNetworkDefault
    {
        public int LimitPercent { get; set; }
    }

    public class CampaignSettings
    {
        /// <summary>
        /// "ADD_METRICA_TAG" | "ADD_OPENSTAT_TAG" | "ADD_TO_FAVORITES" | "ENABLE_AREA_OF_INTEREST_TARGETING" | "ENABLE_COMPANY_INFO" | "ENABLE_EXTENDED_AD_TITLE" | "ENABLE_SITE_MONITORING" | "REQUIRE_SERVICING"
        /// </summary>
        public string Option { get; set; }
        /// <summary>
        /// ( "YES" | "NO" )
        /// </summary>
        public string Value { get; set; }
    }
    public class StrategyMaximumAppInstalls
    {
        public long WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
    }
    public class StrategyAverageCpcCampaign
    {
        public long AverageCpc { get; set; }
        public long WeeklySpendLimit { get; set; }
        public long BidCelling { get; set; }
    }
    public class StrategyAverageCpcFilter
    {
        public long FilterAverageCpc { get; set; }
        public long WeeklySpendLimit { get; set; }
        public long BidCelling { get; set; }
    }    
    public class StrategyAverageCpaFilter
    {
        public long WeeklySpendLimit { get; set; }
        public long BidCeiling { get; set; }
        public long GoalId { get; set; }
        public long FilterCpa { get; set; }
    }
    public class PriorityGoalsArray
    {
        public List<PriorityGoalsItem> Items { get; set; }
    }
    public class PriorityGoalsItem
    {
        public long GoalId { get; set; }
        public long Value { get; set; }
    }
}
