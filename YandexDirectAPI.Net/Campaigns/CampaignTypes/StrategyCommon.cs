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
    public class StrategyAverageCpa
    {
        public long? WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
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
        public long? WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
        public long? Profitability { get; set; }
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
        public string Option { get; set; }
        public string Value { get; set; }
    }
    public class StrategyMaximumAppInstalls
    {
        public long WeeklySpendLimit { get; set; }
        public long? BidCeiling { get; set; }
    }
}
