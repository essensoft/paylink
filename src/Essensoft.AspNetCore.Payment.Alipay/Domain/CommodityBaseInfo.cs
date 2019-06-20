using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommodityBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommodityBaseInfo : AlipayObject
    {
        /// <summary>
        /// 服务logo
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("service_url")]
        public string ServiceUrl { get; set; }
    }
}
