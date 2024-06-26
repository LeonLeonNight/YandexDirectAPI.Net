﻿using System;
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
}
