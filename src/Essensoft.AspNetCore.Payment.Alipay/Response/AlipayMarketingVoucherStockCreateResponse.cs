using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockCreateResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 本次重复导入数量
        /// </summary>
        [JsonProperty("duplicate_count")]
        [XmlElement("duplicate_count")]
        public long DuplicateCount { get; set; }

        /// <summary>
        /// 本次导入失败数量
        /// </summary>
        [JsonProperty("fail_count")]
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 库存ID, 用于后续追加和查询库存
        /// </summary>
        [JsonProperty("stock_id")]
        [XmlElement("stock_id")]
        public string StockId { get; set; }

        /// <summary>
        /// 本次导入成功数量
        /// </summary>
        [JsonProperty("success_count")]
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
