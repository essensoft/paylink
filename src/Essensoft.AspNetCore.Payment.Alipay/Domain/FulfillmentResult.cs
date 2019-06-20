using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FulfillmentResult Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentResult : AlipayObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [JsonProperty("fulfillment_order_no")]
        public string FulfillmentOrderNo { get; set; }

        /// <summary>
        /// 商户履约请求订单号。
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
