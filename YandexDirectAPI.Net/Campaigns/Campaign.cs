using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YandexDirectAPI.Net.Campaigns.CampaignTypes;

namespace YandexDirectAPI.Net.Campaigns
{
    public class Campaign
    {
        [JsonProperty(Order = 1)]
        public long Id { get; set; }

        [JsonProperty(Order = 2), MaxLength(255)]
        public string Name { get; set; }
        /// <summary>
        /// Дата начала показов объявлений в формате YYYY-MM-DD. Должна быть не меньше текущей даты.
        /// </summary>

        [JsonProperty(Order = 3)]
        public string StartDate { get; set; }

        [JsonProperty(Order = 4)]
        public string Type { get; set; }

        [JsonProperty(Order = 5)]
        public string State { get; set; }

        [JsonProperty(Order = 6)]
        public string Status { get; set; }

        [JsonProperty(Order = 7)]
        public string StatusPayment { get; set; }

        [JsonProperty(Order = 8)]
        public string StatusClarification { get; set; }

        [JsonProperty(Order = 9)]
        public long? SourceId { get; set; }

        [JsonProperty(Order = 10)]
        public Statistics Statistics { get; set; }

        /// <summary>
        /// Валюта кампании.
        /// </summary>
        [JsonProperty(Order = 11)]
        public string Currency { get; set; }

        [JsonProperty(Order = 12)]
        public FundsParam Funds { get; set; }

        [JsonProperty(Order = 13)]
        public CampaignAssistant RepresentedBy { get; set; }

        [JsonProperty(Order = 14)]
        public DailyBudget DailyBudget { get; set; }

        /// <summary>
        /// Дата окончания показов объявлений в формате YYYY-MM-DD.
        /// </summary>
        [JsonProperty(Order = 15)]
        public string EndDate { get; set; }

        [JsonProperty(Order = 16)]
        public NegativeKeywords NegativeKeywords { get; set; }

        [JsonProperty(Order = 17)]
        public BlockedIps BlockedIps { get; set; }

        [JsonProperty(Order = 18)]
        public ExcludedSites ExcludedSites { get; set; }

        #region Виды рекламных объявлений
        /// <summary>
        /// Текстово-графические объявления
        /// </summary>
        [JsonProperty(Order = 19)]
        public TextCampaignCommon TextCampaign { get; set; }
        /// <summary>
        /// Реклама мобильных приложений
        /// </summary>
        [JsonProperty(Order = 20)]
        public MobileAppCampaignCommon MobileAppCampaign { get; set; }
        /// <summary>
        /// Динамические объявления
        /// </summary>
        [JsonProperty(Order = 21)]
        public DynamicTextCampaignCommon DynamicTextCampaign { get; set; }
        /// <summary>
        /// Медийная кампания
        /// </summary>
        [JsonProperty(Order = 22)]
        public CpmBannerCampaignAddItem CpmBannerCampaign { get; set; }
        /// <summary>
        /// Смарт-баннеры
        /// </summary>
        [JsonProperty(Order = 23)]
        public SmartCampaignAddItem SmartCampaign { get; set; }
        #endregion

        [JsonProperty(Order = 24), MaxLength(255)]
        public string ClientInfo { get; set; }

        [JsonProperty(Order = 25)]
        public Notification Notification { get; set; }

        [JsonProperty(Order = 26)]
        public TimeTargeting TimeTargeting { get; set; }

        [JsonProperty(Order = 27)]
        public string TimeZone { get; set; }
    }

    public class NegativeKeywords
    {
        public string[] Items { get; set; }
    }
    public class BlockedIps
    {
        public string[] Items { get; set; }
    }
    public class ExcludedSites
    {
        public string[] Items { get; set; }
    }

    public class Statistics
    {
        /// <summary>
        /// Количество показов за время существования кампании.
        /// </summary>
        public long Impressions { get; set; }
        /// <summary>
        /// Количество кликов за время существования кампании.
        /// </summary>
        public long Clicks { get; set; }
    }

    public enum CurrencyEnum
    {
        RUB,
        BYN,
        CHF,
        EUR,
        KZT,
        TRY,
        UAH,
        USD
    }

    public class FundsParam
    {
        /// <summary>
        /// Тип финансовых показателей кампании
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// Финансовые показатели кампании, в случае если общий счет не подключен.
        /// </summary>
        public CampaignFundsParam CampaignFunds { get; set; }
        /// <summary>
        /// Финансовые показатели кампании, в случае если общий счет подключен.
        /// </summary>
        public SharedAccountFundsParam SharedAccountFunds { get; set; }
    }
    public enum CampaignFundsEnum
    {
        CAMPAIGN_FUNDS,
        SHARED_ACCOUNT_FUNDS
    }

    public class CampaignFundsParam
    {
        public long Sum { get; set; }
        public long Balance { get; set; }
        public long BalanceBonus { get; set; }
        public long SumAvailableForTransfer { get; set; }
    }

    public class CampaignAssistant
    {
        public string Manager { get; set; }
        public string Agency { get; set; }
    }

    public class SharedAccountFundsParam
    {
        public long Refund { get; set; }
        public long Spend { get; set; }
    }

    public class Notification
    {
        public SmsSettings SmsSettings { get; set; }
        public EmailSettings EmailSettings { get; set; }
    }

    public class DailyBudget
    {
        [Required]
        public long Amount { get; set; }
        [Required]
        public string DailyBudgetModeEnum { get; set; }
    }
    public enum DailyBudgetModeEnum
    {
        STANDARD,
        DISTRIBUTED
    }

    public class TimeTargeting
    {
        public Shedule Shedule { get; set; }
        public string ConsiderWorkingWeekends { get; set; }
        public TimeTargetingOnPublicHolidays HolidaysSchedule { get; set; }
    }

    public class TimeTargetingOnPublicHolidays
    {
        public string SuspendOnHolidays { get; set; }
        public int BidPercent { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
    }

    public class Shedule
    {
        public string[] Items { get; set; }
    }

    public class SmsSettings
    {
        public string SmsEventsEnum { get; set; }
        /// <summary>
        /// Время, начиная с которого разрешено отправлять SMS о событиях, связанных с кампанией. Указывается в формате HH:MM, минуты задают кратно 15 (0, 15, 30, 45). Например, 19:45. Значение по умолчанию 9:00.
        /// </summary>
        public string TimeFrom { get; set; }
        /// <summary>
        /// Время, до которого разрешено отправлять SMS о событиях, связанных с кампанией. Указывается в формате HH:MM, минуты задают кратно 15 (0, 15, 30, 45). Например, 19:45. Значение по умолчанию 21:00.
        /// </summary>
        public string TimeTo { get; set; }
    }

    public enum SmsEventsEnum
    {
        MONITORING,
        MODERATION,
        MONEY_IN,
        MONEY_OUT,
        FINISHED
    }

    public class EmailSettings
    {
        public string Email { get; set; }
        [DefaultValue(60)]
        public int? CheckPositionInterval { get; set; }
        [DefaultValue(20)]
        public int? WarningBalance { get; set; }
        public string SendAccountNews { get; set; }
        public string SendWarnings { get; set; }

    }

    public enum YesNoEnum
    {
        Yes,
        No
    }
}
