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
                         Ids = new long?[] { 402835 }
                    },
                    FieldNames = new string[] 
                    { 
                        "Id", 
                        "Name", 
                        "ClientInfo", 
                        "Notification", 
                        "TimeZone", 
                        "DailyBudget", 
                        "EndDate", 
                        "NegativeKeywords" 
                    }
                }
            };

            return YandexAPIBody;
        }
    }
}
