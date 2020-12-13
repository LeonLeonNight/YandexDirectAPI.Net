using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignUpdateResponse : StatusMessage
    {
        public UpdateResult result { get; set; }
    }

    public class UpdateResult
    {
        public List<ActionResult> UpdateResults { get; set; }
    }

    public class ActionResult
    {
        public long Id { get; set; }
        public List<ExceptionNotification> Warnings { get; set; }
        public List<ExceptionNotification> Errors { get; set; }
    }

    public class ExceptionNotification
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
