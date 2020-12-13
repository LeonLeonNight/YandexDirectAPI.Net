using System;
using System.Collections.Generic;
using System.Text;

namespace YandexDirectAPI.Net
{
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
