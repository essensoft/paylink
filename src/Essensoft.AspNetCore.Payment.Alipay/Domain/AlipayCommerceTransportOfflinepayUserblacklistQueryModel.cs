using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayUserblacklistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户黑名单分页ID，1开始
        /// </summary>
        [JsonProperty("page_index")]
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 脱机交易用户黑名单分页页大小，最大页大小不超过1000
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
