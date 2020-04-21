using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FulfillmentResult Data Structure.
    /// </summary>
    public class FulfillmentResult : AlipayObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [JsonPropertyName("fulfillment_order_no")]
        public string FulfillmentOrderNo { get; set; }

        /// <summary>
        /// 商户履约请求订单号。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
