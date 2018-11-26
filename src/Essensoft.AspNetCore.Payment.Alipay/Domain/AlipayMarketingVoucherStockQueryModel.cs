using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherStockQueryModel : AlipayObject
    {
        /// <summary>
        /// 库存ID, 库存创建接口返回
        /// </summary>
        [JsonProperty("stock_id")]
        [XmlElement("stock_id")]
        public string StockId { get; set; }
    }
}
