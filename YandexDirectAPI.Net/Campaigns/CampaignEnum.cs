using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    #region SelectionCriterias
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
}
