using System;
using System.Collections.Generic;
using System.Text;
using YandexDirectAPI.Net.Campaigns;

namespace YandexDirectAPI.Net.Test
{
    public class YandexDirectModelTest
    {
        public YandexAPIBody YandexAPIBody { get; set; }
        public YandexDirectModelTest() { }

        public YandexAPIBody GenerateYandexAPIBody()
        {
            YandexAPIBody = new YandexAPIBody
            {
                @method = "get",
                @params = new YandexAPIParameters
                {
                    SelectionCriteria = new SelectionCriterias() 
                    {
                        Ids = new long?[] { 402835 } // 402836, 402837
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
            };

            return YandexAPIBody;
        }
    }
}
