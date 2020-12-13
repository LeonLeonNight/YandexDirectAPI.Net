using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class YandexGetRequest
    {
        public string @method { get; set; }
        public YandexGetParameters @params { get; set; }
    }
    public class YandexGetParameters
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

    public class LimitOffset
    {
        public long? Limit { get; set; }
        public long? Offset { get; set; }
    }
}
