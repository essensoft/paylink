using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductBillPayStatusResponse.
    /// </summary>
    public class AlipayEbppPdeductBillPayStatusResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝协议流水
        /// </summary>
        [JsonProperty("agreement_id")]
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝流billNo
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单的结果码
        /// </summary>
        [JsonProperty("order_result_code")]
        [XmlElement("order_result_code")]
        public string OrderResultCode { get; set; }

        /// <summary>
        /// 订单的结果描述
        /// </summary>
        [JsonProperty("order_result_msg")]
        [XmlElement("order_result_msg")]
        public string OrderResultMsg { get; set; }

        /// <summary>
        /// 外部订单流水
        /// </summary>
        [JsonProperty("out_order_no")]
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单支付状态。  0：未知状态。  1：支付成功。  2：支付失败。
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
