using System;
using System.Net;

namespace TenMinuteMailApi
{
    public class TenMinuteMailDotCom : ITenMinuteMail
    {
        private const string baseUrl = "http://10minutemail.com";
        private const string indexUrl = baseUrl + "/10MinuteMail/index.html";

        private string email;
        private string sessionId;

        public string ObtainEmailBox(bool renew = false)
        {
            var webClient = new WebClient();
            var result = webClient.DownloadString(new Uri(indexUrl));
            return result;
        }
    }
}