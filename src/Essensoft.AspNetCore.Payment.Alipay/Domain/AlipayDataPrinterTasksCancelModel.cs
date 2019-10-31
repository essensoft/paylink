using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataPrinterTasksCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataPrinterTasksCancelModel : AlipayObject
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
        /// 设备sn号
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }
    }
}
