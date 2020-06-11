using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    public static class HttpClientExtensions
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public static async Task<string> PostAsync<T>(this HttpClient client, IWeChatPayRequest<T> request, IDictionary<string, string> textParams) where T : WeChatPayResponse
        {
            var url = request.GetRequestUrl();
            var content = WeChatPayUtility.BuildContent(textParams);
            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/xml"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                return await respContent.ReadAsStringAsync();
            }
        }

        public static async Task<string> PostAsync<T>(this HttpClient client, IWeChatPayCertRequest<T> request, IDictionary<string, string> textParams) where T : WeChatPayResponse
        {
            var url = request.GetRequestUrl();
            var content = WeChatPayUtility.BuildContent(textParams);
            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/xml"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                return await respContent.ReadAsStringAsync();
            }
        }

        public static async Task<(string serial, string timestamp, string nonce, string signature, string body)> GetAsync<T>(this HttpClient client, IWeChatPayV3GetRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response
        {
            var url = request.GetRequestUrl();
            var authorization = BuildAuthorizationString(url, "GET", null, options);

            client.DefaultRequestHeaders.Add(WeChatPayConsts.Wechatpay_Serial, options.CertificateSerialNo);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", authorization);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var resp = await client.GetAsync(url))
            using (var respContent = resp.Content)
            {
                var serial = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Serial).First();
                var timestamp = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Timestamp).First();
                var nonce = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Nonce).First();
                var signature = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Signature).First();
                var body = await respContent.ReadAsStringAsync();

                return (serial, timestamp, nonce, signature, body);
            }
        }

        public static async Task<(string serial, string timestamp, string nonce, string signature, string body)> PostAsync<T>(this HttpClient client, IWeChatPayV3PostRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response
        {
            var url = request.GetRequestUrl();
            var content = SerializeBizModel(request);
            var authorization = BuildAuthorizationString(url, "POST", content, options);
            client.DefaultRequestHeaders.Add(WeChatPayConsts.Wechatpay_Serial, options.CertificateSerialNo);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", authorization);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/json"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                var serial = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Serial).First();
                var timestamp = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Timestamp).First();
                var nonce = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Nonce).First();
                var signature = resp.Headers.GetValues(WeChatPayConsts.Wechatpay_Signature).First();
                var body = await respContent.ReadAsStringAsync();

                return (serial, timestamp, nonce, signature, body);
            }
        }

        private static string SerializeBizModel<T>(IWeChatPayV3PostRequest<T> request) where T : WeChatPayV3Response
        {
            var bizModel = request.GetBizModel();
            if (bizModel != null)
            {
                return JsonSerializer.Serialize(bizModel, bizModel.GetType(), jsonSerializerOptions);
            }

            throw new WeChatPayException("BizModel is null!");
        }

        private static string BuildAuthorizationString(string url, string method, string content, WeChatPayOptions options)
        {
            var body = string.Empty;
            if (method == "POST" || method == "PUT" || method == "PATCH")
            {
                body = content;
            }

            var uri = new Uri(url).PathAndQuery;
            var timestamp = WeChatPayUtility.GetTimeStamp();
            var nonce = WeChatPayUtility.GenerateNonceStr();
            var message = $"{method}\n{uri}\n{timestamp}\n{nonce}\n{body}\n";
            var signature = options.CertificateRSAPrivateKey.Sign(message);

            return $"mchid=\"{options.MchId}\",nonce_str=\"{nonce}\",timestamp=\"{timestamp}\",serial_no=\"{options.CertificateSerialNo}\",signature=\"{signature}\"";
        }
    }
}
