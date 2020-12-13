using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net.Campaigns
{
    public class CampaignDeleteResponse : StatusMessage
    {
        public DeleteResult result { get; set; }
    }
    public class DeleteResult
    {
        public List<ActionResult> UpdateResults { get; set; }
    }
}
