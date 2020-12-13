using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class TextCampaignUpdateItem
    {
        public TextCampaignStrategy BiddingStrategy { get; set; }
        public TextCampaignSetting Settings { get; set; }
        public RelevantKeywordsSetting RelevantKeywords { get; set; }
        public PriorityGoalsArray PriorityGoals { get; set; }
        /// <summary>
        /// Возможные значения:
        /// FC — первый переход.
        /// LC — последний переход.
        /// LSC — последний значимый переход.
        /// LYDC — последний переход из Яндекс.Директа.
        /// Значение по умолчанию — LYDC.
        /// </summary>
        public string AttributionModel { get; set; }
    }

    public class TextCampaignStrategy
    {
        public TextCampaignSearchStrategy Search { get; set; }
        public TextCampaignNetworkStrategyAdd Network { get; set; }
    }

    #region Search
    public class TextCampaignSearchStrategy
    {
        [Required]
        public string BiddingStrategyType { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumConversionRate WbMaximumConversionRate { get; set; }
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpa AverageCpa { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
    }

    public enum TextCampaignSearchStrategyTypeEnum
    {
        AVERAGE_CPA,
        AVERAGE_ROI,
        AVERAGE_CPC,
        HIGHEST_POSITION,
        PAY_FOR_CONVERSION,
        SERVING_OFF,
        WB_MAXIMUM_CLICKS,
        WB_MAXIMUM_CONVERSION_RATE,
        WEEKLY_CLICK_PACKAGE
    }

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
    #endregion
    #region Network
    public class TextCampaignNetworkStrategyAdd
    {
        public string BiddingStrategyType { get; set; }
        public StrategyNetworkDefaultAdd NetworkDefault { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumConversionRate WbMaximumConversionRate { get; set; }
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpa AverageCpa { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
    }
    public enum TextCampaignNetworkStrategyTypeEnum
    {
        AVERAGE_CPA,
        AVERAGE_CPC,
        AVERAGE_ROI,
        MAXIMUM_COVERAGE,
        NETWORK_DEFAULT,
        PAY_FOR_CONVERSION,
        SERVING_OFF,
        WB_MAXIMUM_CLICKS,
        WB_MAXIMUM_CONVERSION_RATE,
        WEEKLY_CLICK_PACKAGE
    }
    public class StrategyNetworkDefaultAdd
    {
        public int LimitPercent { get; set; }
    }
    #endregion

    public class TextCampaignSetting
    {
        public string Option { get; set; }
        public string Value { get; set; }
    }
    public enum TextCampaignSettingsEnum
    {
        ADD_METRICA_TAG,
        ADD_OPENSTAT_TAG,
        ADD_TO_FAVORITES,
        ENABLE_AREA_OF_INTEREST_TARGETING,
        ENABLE_COMPANY_INFO,
        ENABLE_EXTENDED_AD_TITLE,
        ENABLE_SITE_MONITORING,
        EXCLUDE_PAUSED_COMPETING_ADS,
        MAINTAIN_NETWORK_CPC,
        REQUIRE_SERVICING
    }
    public class RelevantKeywordsSetting
    {
        public int BudgetPercent { get; set; }
        public int? OptimizeGoalId { get; set; }
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
