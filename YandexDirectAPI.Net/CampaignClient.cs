using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YandexDirectAPI.Net.Campaigns;
using YandexDirectAPI.Net.Campaigns.CampaignTypes;

namespace YandexDirectAPI.Net
{
    public class YandexHeader
    {
        public string Authorization { get; set; }
        public string ClientLogin { get; set; }
        public string BaseEndPoint { get; set; }
    }
    public class CampaignClient : IDisposable
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        public Action<string> Log;
        public Action<string> RawLog;
        public YandexHeader Head = new YandexHeader();
        public JsonSerializerSettings ContentSerializerSettings;

        private readonly string EndPoint = "campaigns";
        private string FullUrl { get; set; }

        public CampaignClient(
            string auth,
            string login,
            string baseEndPoint)
        {
            Head.Authorization = auth;
            Head.ClientLogin = login;
            Head.BaseEndPoint = baseEndPoint;

            FullUrl = Head.BaseEndPoint + EndPoint;
            ContentSerializerSettings = new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.None,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public async Task<CampaignGetResponse> GetCompanies(
            CampaignGetRequest parameters,
            CancellationToken ct = default)
        {
            parameters.method = "get";

            Log?.Invoke(
                $"For point: {EndPoint+"/"+parameters.method} \n" +
                $"Request: {JsonConvert.SerializeObject(parameters, ContentSerializerSettings)}");

            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = (parameters != null)
                ? JsonConvert.SerializeObject(parameters, ContentSerializerSettings)
                : string.Empty;

            var request = GetHeaders(HttpMethod.Post, content);

            var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);

            var responseContent = !response.Content.Equals(null)
                    ? await response.Content.ReadAsStringAsync().ConfigureAwait(true)
                    : null;

            var result = JsonConvert.DeserializeObject<CampaignGetResponse>(responseContent);

            Log?.Invoke(
                $"For point: {EndPoint + "/" + parameters.method} \n" +
                $"Response: {JsonConvert.SerializeObject(result, ContentSerializerSettings)}");
            return result;
        }

        public async Task<CampaignUpdateResponse> UpdateCompany(
            CampaignUpdateRequest parameters,
            CancellationToken ct = default)
        {
            parameters.method = "update";

            Log?.Invoke(
                $"For point: {EndPoint + "/" + parameters.method} \n" +
                $"Request: {JsonConvert.SerializeObject(parameters, ContentSerializerSettings)}");

            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = (parameters != null)
                ? JsonConvert.SerializeObject(parameters, ContentSerializerSettings)
                : string.Empty;

            var request = GetHeaders(HttpMethod.Post, content);

            var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);

            var responseContent = !response.Content.Equals(null)
                    ? await response.Content.ReadAsStringAsync().ConfigureAwait(true)
                    : null;

            var result = JsonConvert.DeserializeObject<CampaignUpdateResponse>(responseContent);

            Log?.Invoke(
                $"For endpoint: {EndPoint} \n" +
                $"Response: {JsonConvert.SerializeObject(result, ContentSerializerSettings)}");
            return result;
        }

        public async Task<CampaignDeleteResponse> DeleteCompany(
            CampaignDeleteRequest parameters,
            CancellationToken ct = default)
        {
            parameters.method = "delete";

            Log?.Invoke(
                $"For point: {EndPoint + "/" + parameters.method} \n" +
                $"Request: {JsonConvert.SerializeObject(parameters, ContentSerializerSettings)}");

            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = (parameters != null)
                ? JsonConvert.SerializeObject(parameters, ContentSerializerSettings)
                : string.Empty;

            var request = GetHeaders(HttpMethod.Post, content);

            var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);

            var responseContent = !response.Content.Equals(null)
                    ? await response.Content.ReadAsStringAsync().ConfigureAwait(true)
                    : null;

            var result = JsonConvert.DeserializeObject<CampaignDeleteResponse>(responseContent);

            Log?.Invoke(
                $"For point: {EndPoint + "/" + parameters.method} \n" +
                $"Response: {JsonConvert.SerializeObject(result, ContentSerializerSettings)}");
            return result;
        }

        public async Task<TextCampaignPostResult> AddTextCampaign(
            TextCampaignPostRequest parameters,
            CancellationToken ct = default)
        {
            parameters.method = "add";

            Log?.Invoke(
                $"For point: {EndPoint + "/" + parameters.method} \n" +
                $"Request: {JsonConvert.SerializeObject(parameters, ContentSerializerSettings)}");

            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = (parameters != null)
                ? JsonConvert.SerializeObject(parameters, ContentSerializerSettings)
                : string.Empty;

            var request = GetHeaders(HttpMethod.Post, content);

            var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);

            var responseContent = !response.Content.Equals(null)
                    ? await response.Content.ReadAsStringAsync().ConfigureAwait(true)
                    : null;

            var result = JsonConvert.DeserializeObject<TextCampaignPostResult>(responseContent);

            Log?.Invoke(
                $"For point: {EndPoint + "/" + parameters.method} \n" +
                $"Response: {JsonConvert.SerializeObject(result, ContentSerializerSettings)}");
            return result;
        }

        //public async Task<string> RestGetAsync(
        //    string endPointUrl,
        //    HttpMethod httpMethod,
        //    CampaignGetRequest model,
        //    CancellationToken ct)
        //{
        //    HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    var content = (model != null)
        //        ? JsonConvert.SerializeObject(model, ContentSerializerSettings)
        //        : string.Empty;
        //    var request = GetHeaders(httpMethod, content);
        //    var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);
        //    var responseContent = !response.Content.Equals(null)
        //            ? await response.Content.ReadAsStringAsync().ConfigureAwait(true)
        //            : null;
        //    return responseContent;
        //}
        //public async Task<string> RestUpdateAsync(
        //    string endPointUrl,
        //    HttpMethod httpMethod,
        //    CampaignUpdateRequest model,
        //    CancellationToken ct)
        //{
        //    HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    var content = (model != null)
        //        ? JsonConvert.SerializeObject(model, ContentSerializerSettings)
        //        : string.Empty;
        //    var request = GetHeaders(httpMethod, content);
        //    var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);
        //    var responseContent = !response.Content.Equals(null)
        //            ? await response.Content.ReadAsStringAsync().ConfigureAwait(false)
        //            : null;
        //    return responseContent;
        //}
        //public async Task<string> RestDeleteAsync(
        //    string endPointUrl,
        //    HttpMethod httpMethod,
        //    CampaignDeleteRequest model,
        //    CancellationToken ct)
        //{
        //    HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    var content = (model != null)
        //        ? JsonConvert.SerializeObject(model, ContentSerializerSettings)
        //        : string.Empty;
        //    var request = GetHeaders(httpMethod, content);
        //    var response = await HttpClient.SendAsync(request, ct).ConfigureAwait(false);
        //    var responseContent = !response.Content.Equals(null)
        //            ? await response.Content.ReadAsStringAsync().ConfigureAwait(false)
        //            : null;
        //    return responseContent;
        //}

        private HttpRequestMessage GetHeaders(HttpMethod httpMethod, string contentString)
        {
            var headRequest = new HttpRequestMessage(httpMethod, FullUrl)
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
