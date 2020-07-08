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

namespace Essensoft.AspNetCore.Payment.WeChatPay.Extensions
{
    public static class HttpClientExtensions
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        #region V2

        public static async Task<string> PostAsync<T>(this HttpClient client, V2.IWeChatPayRequest<T> request, IDictionary<string, string> textParams) where T : V2.WeChatPayResponse
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

        public static async Task<string> PostAsync<T>(this HttpClient client, V2.IWeChatPayCertRequest<T> request, IDictionary<string, string> textParams) where T : V2.WeChatPayResponse
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

        #endregion 

        #region V3

        public static async Task<(string serial, string timestamp, string nonce, string signature, string body, int statusCode)> GetAsync<T>(this HttpClient client, V3.IWeChatPayGetRequest<T> request, WeChatPayOptions options) where T : V3.WeChatPayResponse
        {
            var url = request.GetRequestUrl();
            var token = BuildToken(url, "GET", null, options);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", token);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var resp = await client.GetAsync(url))
            using (var respContent = resp.Content)
            {
                var serial = string.Empty;
                var timestamp = string.Empty;
                var nonce = string.Empty;
                var signature = string.Empty;

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Serial, out var serialValues) && serialValues.Count() == 1)
                {
                    serial = serialValues.ElementAt(0);
                }

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Timestamp, out var timestampValues) && timestampValues.Count() == 1)
                {
                    timestamp = timestampValues.ElementAt(0);
                }

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Nonce, out var nonceValues) && nonceValues.Count() == 1)
                {
                    nonce = nonceValues.ElementAt(0);
                }

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Signature, out var signatureValues) && signatureValues.Count() == 1)
                {
                    signature = signatureValues.ElementAt(0);
                }

                var body = await respContent.ReadAsStringAsync();
                var statusCode = (int)resp.StatusCode;

                return (serial, timestamp, nonce, signature, body, statusCode);
            }
        }

        public static async Task<(string serial, string timestamp, string nonce, string signature, string body, int statusCode)> PostAsync<T>(this HttpClient client, V3.IWeChatPayPostRequest<T> request, WeChatPayOptions options) where T : V3.WeChatPayResponse
        {
            var url = request.GetRequestUrl();
            var content = SerializeQueryModel(request);
            var token = BuildToken(url, "POST", content, options);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", token);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/json"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                var serial = string.Empty;
                var timestamp = string.Empty;
                var nonce = string.Empty;
                var signature = string.Empty;

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Serial, out var serialValues) && serialValues.Count() == 1)
                {
                    serial = serialValues.ElementAt(0);
                }

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Timestamp, out var timestampValues) && timestampValues.Count() == 1)
                {
                    timestamp = timestampValues.ElementAt(0);
                }

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Nonce, out var nonceValues) && nonceValues.Count() == 1)
                {
                    nonce = nonceValues.ElementAt(0);
                }

                if (resp.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Signature, out var signatureValues) && signatureValues.Count() == 1)
                {
                    signature = signatureValues.ElementAt(0);
                }

                var body = await respContent.ReadAsStringAsync();
                var statusCode = (int)resp.StatusCode;

                return (serial, timestamp, nonce, signature, body, statusCode);
            }
        }

        private static string SerializeQueryModel<T>(V3.IWeChatPayPostRequest<T> request) where T : V3.WeChatPayResponse
        {
            var queryModel = request.GetQueryModel();
            if (queryModel != null)
            {
                return JsonSerializer.Serialize(queryModel, queryModel.GetType(), jsonSerializerOptions);
            }

            throw new WeChatPayException("QueryModel is null!");
        }

        private static string BuildToken(string url, string method, string body, WeChatPayOptions options)
        {
            var uri = new Uri(url).PathAndQuery;
            var timestamp = WeChatPayUtility.GetTimeStamp();
            var nonce = WeChatPayUtility.GenerateNonceStr();
            var message = BuildMessage(method, uri, timestamp, nonce, body);
            var signature = options.CertificateRSAPrivateKey.Sign(message);

            return $"mchid=\"{options.MchId}\",nonce_str=\"{nonce}\",timestamp=\"{timestamp}\",serial_no=\"{options.CertificateSerialNo}\",signature=\"{signature}\"";
        }

        private static string BuildMessage(string method, string uri, string timestamp, string nonce, string body)
        {
            return $"{method}\n{uri}\n{timestamp}\n{nonce}\n{body}\n";
        }

        #endregion
    }
}
