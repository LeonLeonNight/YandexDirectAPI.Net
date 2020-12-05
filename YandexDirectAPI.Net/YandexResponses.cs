﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YandexDirectAPI.Net
{
    public class YandexAPIResponse : StatusMessage
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public Campaigns Campaigns { get; set; }
    }

    public class StatusMessage
    {
        public Error error { get; set; }
    }

    public class Campaigns
    {
        public string Id { get; set; }
        [MaxLength(255), Required]
        public string ClientInfo { get; set; }
        public Notification Notification { get; set; }
        [DefaultValue("Europe/Moscow")]
        public string TimeZone { get; set; }
        [MaxLength(255), Required]
        public string Name { get; set; }
        /// <summary>
        /// Дата начала показов объявлений в формате YYYY-MM-DD. Должна быть не меньше текущей даты.
        /// </summary>
        [Required]
        public string StartDate { get; set; }
        public DailyBudget DailyBudget { get; set; }
        /// <summary>
        /// Дата окончания показов объявлений в формате YYYY-MM-DD.
        /// </summary>
        [Required]
        public string EndDate { get; set; }
        public string[] NegativeKeywords { get; set; }
        public string[] BlockedIps { get; set; }
        public string[] ExcludedSites { get; set; }
        #region Виды рекламных объявлений
        /// <summary>
        /// Текстово-графические объявления
        /// </summary>
        public TextCampaignAddItem TextCampaign { get; set; }
        /// <summary>
        /// Реклама мобильных приложений
        /// </summary>
        public MobileAppCampaignAddItem MobileAppCampaign { get; set; }
        /// <summary>
        /// Динамические объявления
        /// </summary>
        public DynamicTextCampaignAddItem DynamicTextCampaign { get; set; }
        /// <summary>
        /// Медийная кампания
        /// </summary>
        public CpmBannerCampaignAddItem CpmBannerCampaign { get; set; }
        /// <summary>
        /// Смарт-баннеры
        /// </summary>
        public SmartCampaignAddItem SmartCampaign { get; set; }
        #endregion
        public TimeTargetingAdd TimeTargeting { get; set; }
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
        public DailyBudgetModeEnum DailyBudgetModeEnum { get; set; }
    }
    public enum DailyBudgetModeEnum
    {
        STANDARD,
        DISTRIBUTED
    }

    #region Описание моделей рекламных Объявлений 
    public class TextCampaignAddItem
    {

    }
    public class MobileAppCampaignAddItem
    {

    }
    public class DynamicTextCampaignAddItem
    {

    }
    public class CpmBannerCampaignAddItem
    {

    }
    public class SmartCampaignAddItem
    {

    }
    #endregion

    public class TimeTargetingAdd
    {

    }

    public class SmsSettings
    {
        public SmsEventsEnum SmsEventsEnum { get; set; }
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
        public string Enail { get; set; }
        [DefaultValue(60)]
        public int? CheckPositionInterval { get; set; }
        [DefaultValue(20)]
        public int? WarningBalance { get; set; }
        [DefaultValue("NO")]
        public YesNoEnum? SendAccountNews { get; set; }
        [DefaultValue("NO")]
        public YesNoEnum? SendWarnings { get; set; }

    }

    public enum YesNoEnum
    {
        Yes,
        No
    }

    public class Error
    {
        public string error_string { get; set; }
        public string error_detail { get; set; }
        public string request_id { get; set; }
        public string error_code { get; set; }
    }
}
