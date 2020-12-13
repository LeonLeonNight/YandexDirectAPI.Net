using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YandexDirectAPI.Net.Campaigns;

namespace YandexDirectAPI.Net
{
    public class YandexHeader
    {
        public string Authorization { get; set; }
        public string ClientLogin { get; set; }
        public string EndPoint { get; set; }
        public string Method { get; set; }
    }
    public class YandexDirectClient
    {
        private string BaseEndPoint = "https://api-sandbox.direct.yandex.com/json/v5/";
        private static readonly HttpClient HttpClient = new HttpClient();
        public Action<string> Log;
        public Action<string> RawLog;
        public YandexHeader Head = new YandexHeader();
        public JsonSerializerSettings ContentSerializerSettings;


        public YandexDirectClient(
            string auth,
            string login,
            string endPoint,
            string method)
        {
            Head.Authorization = auth;
            Head.ClientLogin = login;
            Head.EndPoint = endPoint;
            Head.Method = method;

            ContentSerializerSettings = new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.None,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public void RouterEnpoint(
            YandexHeader header,
            YandexGetRequest body)
        {
            //switch (header.EndPoint)
            //{
            //    case "campaigns":
            //}
        }

        public async Task<YandexAPIResponse> GetCompanies(
            YandexGetRequest parameters,
            CancellationToken ct = default)
        {
            parameters.method = Head.Method;

            Log?.Invoke(
                $"For endpoint: {Head.EndPoint} \n" +
                $"Request: {JsonConvert.SerializeObject(parameters, ContentSerializerSettings)}");

            var responseContent = await RestGetAsync(
                Head.EndPoint,
                HttpMethod.Post,
                parameters,
                ct);

            var response = JsonConvert.DeserializeObject<YandexAPIResponse>(responseContent);

            Log?.Invoke(
                $"For endpoint: {Head.EndPoint} \n" +
                $"Response: {JsonConvert.SerializeObject(response, ContentSerializerSettings)}");
            return response;
        }
        
        public async Task<YandexAPIResponse> UpdateCompany(
            YandexUpdateRequest parameters,
            CancellationToken ct = default)
        {
            parameters.method = Head.Method;

            Log?.Invoke(
                $"For endpoint: {Head.EndPoint} \n" +
                $"Request: {JsonConvert.SerializeObject(parameters, ContentSerializerSettings)}");

            var responseContent = await RestUpdateAsync(
                Head.EndPoint,
                HttpMethod.Post,
                parameters,
                ct);

            var response = JsonConvert.DeserializeObject<YandexAPIResponse>(responseContent);

            Log?.Invoke(
                $"For endpoint: {Head.EndPoint} \n" +
                $"Response: {JsonConvert.SerializeObject(response, ContentSerializerSettings)}");
            return response;
        }

        public async Task<string> RestGetAsync(
            string endPointUrl,
            HttpMethod httpMethod,
            YandexGetRequest model,
            CancellationToken ct)
        {
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = (model != null)
                ? JsonConvert.SerializeObject(model, ContentSerializerSettings)
                : string.Empty;

            var request = GetHeaders(endPointUrl, httpMethod, content);
            
            var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);

            var responseContent = !response.Content.Equals(null)
                    ? await response.Content.ReadAsStringAsync().ConfigureAwait(false)
                    : null;

            return responseContent;
        }
        
        public async Task<string> RestUpdateAsync(
            string endPointUrl,
            HttpMethod httpMethod,
            YandexUpdateRequest model,
            CancellationToken ct)
        {
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = (model != null)
                ? JsonConvert.SerializeObject(model, ContentSerializerSettings)
                : string.Empty;

            var request = GetHeaders(endPointUrl, httpMethod, content);
            
            var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);

            var responseContent = !response.Content.Equals(null)
                    ? await response.Content.ReadAsStringAsync().ConfigureAwait(false)
                    : null;

            return responseContent;
        }

        private HttpRequestMessage GetHeaders(string endPoint, HttpMethod httpMethod, string contentString)
        {
            var fullUrl = BaseEndPoint + endPoint;
            var headRequest = new HttpRequestMessage(httpMethod, fullUrl)
            {
                Content =
                !string.IsNullOrEmpty(contentString)
                            ? new StringContent(contentString, Encoding.UTF8, "application/json")
                            : null
            };
            headRequest.Headers.Add("Authorization", $"{Head.Authorization}");
            headRequest.Headers.Add("Accept-Language", "ru");
            headRequest.Headers.Add("Client-Login", Head.ClientLogin);

            return headRequest;
        }

        private string ClearText(string inText)
        {
            var outText = inText?.
                Replace("\r\n", "").
                Replace("\\r\\n", "").
                Replace(" ", "");

            return outText;
        }
    }
}
