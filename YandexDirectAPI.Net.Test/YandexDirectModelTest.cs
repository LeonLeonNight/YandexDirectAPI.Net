using System;
using System.Collections.Generic;
using System.Text;
using YandexDirectAPI.Net.Campaigns;

namespace YandexDirectAPI.Net.Test
{
    public static class YandexDirectModelTest
    {
        private const string Get1 = nameof(Get1);
        private const string Update1 = nameof(Update1);
        private const string Delete = nameof(Delete);

        public static Dictionary<string, CampaignGetRequest> GetBodies = new Dictionary<string, CampaignGetRequest>
        {
            //Get
            {
                Get1, new CampaignGetRequest
                {
                    @method = "get",
                    @params = new YandexGetParameters
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

            //Delete
            {
                Delete, new CampaignGetRequest
                {

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

                    }
                }
            }
        };
        public static CampaignUpdateRequest CurrentUpdateMethod = UpdateBodies[Update1];
    }
}
