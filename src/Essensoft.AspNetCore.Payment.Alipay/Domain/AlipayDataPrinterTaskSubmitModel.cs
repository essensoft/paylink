using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataPrinterTaskSubmitModel Data Structure.
    /// </summary>
    public class AlipayDataPrinterTaskSubmitModel : AlipayObject
    {
        /// <summary>
        /// 应用token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("origin_id")]
        public string OriginId { get; set; }
    }
}
