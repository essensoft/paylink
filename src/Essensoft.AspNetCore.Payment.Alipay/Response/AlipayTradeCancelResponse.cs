using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCancelResponse.
    /// </summary>
    public class AlipayTradeCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 本次撤销触发的交易动作  close：关闭交易，无退款  refund：产生了退款
        /// </summary>
        [JsonProperty("action")]
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonProperty("retry_flag")]
        [XmlElement("retry_flag")]
        public string RetryFlag { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
