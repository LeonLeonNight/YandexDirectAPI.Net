using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net
{
    public class YandexAPIBody
    {
        public string @method { get; set; }
        public YandexAPIParameters @params { get; set; }
    }
    public class YandexAPIParameters
    {
        public SelectionCriterias SelectionCriteria { get; set; }
        public string[] FieldNames { get; set; }
        public TextCampaignFieldEnum?[] TextCampaignFieldNames { get; set; }
        public MobileAppCampaignFieldEnum?[] MobileAppCampaignFieldNames { get; set; }
        public DynamicTextCampaignFieldEnum?[] DynamicTextCampaignFieldNames { get; set; }
        public CpmBannerCampaignFieldEnum?[] CpmBannerCampaignFieldNames { get; set; }
        public SmartCampaignFieldEnum?[] SmartCampaignFieldNames { get; set; }
        public LimitOffset Page { get; set; }
    }

    #region SelectionCriterias
    public class SelectionCriterias
    {
        /// <summary>
        /// Отбирать кампании с указанными идентификаторами. Не более 1000 элементов в массиве.
        /// </summary>
        public long?[] Ids { get; set; }
        public CampaignTypeEnum?[] Types { get; set; }
        public CampaignStateEnum?[] States { get; set; }
        public CampaignStatusSelectionEnum?[] Statuses { get; set; }
        public CampaignStatusPaymentEnum?[] StatusesPayment { get; set; }

    }

    public enum CampaignTypeEnum
    {
        TEXT_CAMPAIGN,
        MOBILE_APP_CAMPAIGN,
        DYNAMIC_TEXT_CAMPAIGN,
        CPM_BANNER_CAMPAIGN,
        SMART_CAMPAIGN
    }
    public enum CampaignStateEnum
    {
        CONVERTED,
        ARCHIVED,
        SUSPENDED,
        ENDED,
        ON,
        OFF,
        UNKNOWN
    }
    public enum CampaignStatusSelectionEnum
    {
        ACCEPTED,
        DRAFT,
        MODERATION,
        REJECTED
    }
    public enum CampaignStatusPaymentEnum
    {
        DISALLOWED,
        ALLOWED
    }
    #endregion

    public enum TextCampaignFieldEnum
    {
        CounterIds,
        RelevantKeywords,
        Settings,
        BiddingStrategy,
        PriorityGoals,
        AttributionModel
    }
    public enum MobileAppCampaignFieldEnum
    {
        Settings,
        BiddingStrategy
    }
    public enum DynamicTextCampaignFieldEnum
    {
        CounterIds,
        Settings,
        BiddingStrategy,
        PriorityGoals,
        AttributionModel
    }
    public enum CpmBannerCampaignFieldEnum
    {
        CounterIds,
        FrequencyCap,
        Settings,
        BiddingStrategy
    }
    public enum SmartCampaignFieldEnum
    {
        CounterId,
        Settings,
        BiddingStrategy,
        PriorityGoals,
        AttributionModel
    }
    public class LimitOffset
    {
        /// <summary>
        /// 
        /// </summary>
        public long? Limit { get; set; }
        public long? Offset { get; set; }
    }
}
