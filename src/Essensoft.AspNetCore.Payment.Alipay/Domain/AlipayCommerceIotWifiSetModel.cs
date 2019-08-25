using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotWifiSetModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设置wifi
        /// </summary>
        [JsonProperty("pwd")]
        public string Pwd { get; set; }

        /// <summary>
        /// wifi名称
        /// </summary>
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }
}
