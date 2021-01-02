using System;
using System.Collections.Generic;
using System.Text;
using YandexDirectAPI.Net.Campaigns;
using YandexDirectAPI.Net.Campaigns.CampaignTypes;

namespace YandexDirectAPI.Net.Test
{
    public static class YandexDirectModelTest
    {
        private const string Get1 = nameof(Get1);
        private const string Update1 = nameof(Update1);
        private const string Delete1 = nameof(Delete1);

        public static Dictionary<string, CampaignGetRequest> GetBodies = new Dictionary<string, CampaignGetRequest>
        {
            //Get
            {
                Get1, new CampaignGetRequest
                {
                    @method = "get",
                    @params = new CampaignGetParameters
                    {
                        SelectionCriteria = new SelectionCriterias()
                        {
                            Ids = new long?[] { } //402835, 402836, 402837
                        },
                        FieldNames = new string[]
                        {
                            "BlockedIps",
                            "ExcludedSites",
                            "Currency",
                            "DailyBudget",
                            "Notification",
                            "EndDate",
                            "Funds",
                            "ClientInfo",
                            "Id",
                            "Name",
                            "NegativeKeywords",
                            "RepresentedBy",
                            "StartDate",
                            "Statistics",
                            "State",
                            "Status",
                            "StatusPayment",
                            "StatusClarification",
                            "SourceId",
                            "TimeTargeting",
                            "TimeZone",
                            "Type"
                        }
                    }
                }
            },
        };
        public static CampaignGetRequest CurrentGetMethod = GetBodies[Get1];

        public static Dictionary<string, CampaignUpdateRequest> UpdateBodies = new Dictionary<string, CampaignUpdateRequest>
        {
            { 
                //Update
                Update1, new CampaignUpdateRequest
                {
                    @method = "update",
                    @params = new CampaignUpdateParameters
                    {
                        Campaigns = new List<Campaign>
                        {
                            new Campaign
                            {
                                  Id = 403233,
                                  TextCampaign = new TextCampaignCommon
                                  {
                                      BiddingStrategy = new TextCampaignStrategy
                                      {
                                          Network = new TextCampaignNetworkStrategy
                                          {
                                              BiddingStrategyType = Enum.GetName(typeof(TextCampaignNetworkStrategyTypeEnum), 3)
                                          }
                                      }
                                  }
                            }
                        }
                    }
                }
            }
        };
        public static CampaignUpdateRequest CurrentUpdateMethod = UpdateBodies[Update1];

        public static Dictionary<string, CampaignDeleteRequest> DeleteBodies = new Dictionary<string, CampaignDeleteRequest>
        {
            //Delete
            {
                Delete1, new CampaignDeleteRequest
                {
                    method = "delete",
                    @params = new CampaignDeleteParameters
                    {
                        SelectionCriteria = new IdsCriteria
                        {
                             Ids = new long[] { 402837 }
                        }
                    }
                }
            }
        };
        public static CampaignDeleteRequest CurrentDeleteMethod = DeleteBodies[Delete1];
    }
}
