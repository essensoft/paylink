using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 剩余可用库存数量
        /// </summary>
        [JsonProperty("available_count")]
        [XmlElement("available_count")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 库存总量
        /// </summary>
        [JsonProperty("total_count")]
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
