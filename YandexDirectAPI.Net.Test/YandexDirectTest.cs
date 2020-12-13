using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using YandexDirectAPI.Net.Campaigns;

namespace YandexDirectAPI.Net.Test
{
    public class YandexDirectTest
    {
        private readonly ITestOutputHelper _output;

        private YandexHeader options = new YandexHeader()
        {
            Authorization = "Bearer AgAAAAAfpSVrAAa72I2bIlNmy0z5iJBXgaHxU58",
            ClientLogin = "leonnight2017",
            EndPoint = "campaigns",
            Method = "get"
        };

        private static CampaignGetRequest GetCurrent = YandexDirectModelTest.CurrentGetMethod;
        private static CampaignUpdateRequest UpdateCurrent = YandexDirectModelTest.CurrentUpdateMethod;

        public YandexDirectTest(ITestOutputHelper output)
        {
            _output = output;

            var culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        private YandexDirectClient GetYandexClient()
        {
            return new YandexDirectClient(
                options.Authorization,
                options.ClientLogin,
                options.EndPoint,
                options.Method)
            {
                Log = x => _output.WriteLine(x),
                RawLog = y => _output.WriteLine($"<rawLog>{y}</rawLog>")
            };
        }

        [Fact]
        public async Task GetCompaniesList()
        {
            var client = GetYandexClient();
            var result = await client.GetCompanies(GetCurrent, CancellationToken.None);
        }

        [Fact]
        public async Task UpdateCompany()
        {
            var client = GetYandexClient();
            var result = await client.UpdateCompany(UpdateCurrent, CancellationToken.None);
        }
    }
}
