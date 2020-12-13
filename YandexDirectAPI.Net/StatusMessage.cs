using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net
{
    public class StatusMessage
    {
        public Error error { get; set; }
    }

    public class Error
    {
        public string error_string { get; set; }
        public string error_detail { get; set; }
        public string request_id { get; set; }
        public string error_code { get; set; }
    }
}
