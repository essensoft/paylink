using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RefundDetail : AlipayObject
    {
        /// <summary>
        /// 交易退款金额
        /// </summary>
        [JsonProperty("refund_amount")]
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [JsonProperty("refund_memo")]
        [XmlElement("refund_memo")]
        public string RefundMemo { get; set; }

        /// <summary>
        /// 退分润列表
        /// </summary>
        [JsonProperty("refund_royaltys")]
        [XmlArray("refund_royaltys")]
        [XmlArrayItem("refund_royalty_info")]
        public List<RefundRoyaltyInfo> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退补差金额
        /// </summary>
        [JsonProperty("refund_suppl_amount")]
        [XmlElement("refund_suppl_amount")]
        public string RefundSupplAmount { get; set; }

        /// <summary>
        /// 退补差备注
        /// </summary>
        [JsonProperty("refund_suppl_memo")]
        [XmlElement("refund_suppl_memo")]
        public string RefundSupplMemo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
