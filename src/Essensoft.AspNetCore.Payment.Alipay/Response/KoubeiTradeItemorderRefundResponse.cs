using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeItemorderRefundResponse.
    /// </summary>
    public class KoubeiTradeItemorderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款唯一请求号
        /// </summary>
        [JsonProperty("out_request_no")]
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 实际退的资金。
        /// </summary>
        [JsonProperty("real_refund_amount")]
        [XmlElement("real_refund_amount")]
        public string RealRefundAmount { get; set; }
    }
}
