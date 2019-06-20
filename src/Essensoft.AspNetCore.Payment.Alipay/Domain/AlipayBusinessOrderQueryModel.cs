using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户外部订单号，和支付宝订单号不能同时为空。注：商户已获取order_no（支付宝订单号）的情况下必须优先传入order_no
        /// </summary>
        [JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单号，与商户外部订单号不能同时为空。注：商户已获取order_no的情况下必须优先传入order_no
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户外部支付工具单据号。若不传，则认为是整单查询，将返回整个订单的所有支付工具信息。
        /// </summary>
        [JsonProperty("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }
    }
}
