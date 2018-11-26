using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherUserExternalTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUserExternalTradeInfo : AlipayObject
    {
        /// <summary>
        /// 核销金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [JsonProperty("consume_date")]
        [XmlElement("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 券核销的门店id
        /// </summary>
        [JsonProperty("consume_shop_id")]
        [XmlElement("consume_shop_id")]
        public string ConsumeShopId { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [JsonProperty("external_trade_no")]
        [XmlElement("external_trade_no")]
        public string ExternalTradeNo { get; set; }
    }
}
