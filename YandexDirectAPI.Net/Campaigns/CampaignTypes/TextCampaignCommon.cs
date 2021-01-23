using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns.CampaignTypes
{
    public class TextCampaignCommon
    {
        public TextCampaignStrategy BiddingStrategy { get; set; }
        public CampaignSettings Settings { get; set; }
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
        public TextCampaignNetworkStrategy Network { get; set; }
    }

    #region Search
    public class TextCampaignSearchStrategy
    {
        [Required]
        public string BiddingStrategyType { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumConversionRate WbMaximumConversionRate { get; set; }//text prop only
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpaCampaign AverageCpa { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
    }

    #endregion
    #region Network
    public class TextCampaignNetworkStrategy
    {
        public string BiddingStrategyType { get; set; }
        public StrategyNetworkDefault NetworkDefault { get; set; }
        public StrategyMaximumClicks WbMaximumClicks { get; set; }
        public StrategyMaximumConversionRate WbMaximumConversionRate { get; set; }
        public StrategyAverageCpc AverageCpc { get; set; }
        public StrategyAverageCpaCampaign AverageCpa { get; set; }
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }
        public StrategyAverageRoi AverageRoi { get; set; }
        public StrategyPayForConversion PayForConversion { get; set; }
    }
    
    #endregion

    public class RelevantKeywordsSetting
    {
        public int BudgetPercent { get; set; }
        public int? OptimizeGoalId { get; set; }
    }
}
