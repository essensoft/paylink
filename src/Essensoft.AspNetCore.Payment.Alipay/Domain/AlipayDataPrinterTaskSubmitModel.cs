using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataPrinterTaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataPrinterTaskSubmitModel : AlipayObject
    {
        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("origin_id")]
        public string OriginId { get; set; }
    }
}
