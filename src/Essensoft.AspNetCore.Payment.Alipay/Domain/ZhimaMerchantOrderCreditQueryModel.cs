using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderCreditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderCreditQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部订单号,包含字母、数字、下划线，调用方需要保证订单号唯一
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 芝麻订单号
        /// </summary>
        [JsonProperty("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
