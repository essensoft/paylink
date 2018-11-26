using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsTradeInfo : AlipayObject
    {
        /// <summary>
        /// 产品编码  交强险-01010000002000000251,   商业险-01010000002000000250
        /// </summary>
        [JsonProperty("product_no")]
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 车险内部订单号
        /// </summary>
        [JsonProperty("trade_biz_id")]
        [XmlElement("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
