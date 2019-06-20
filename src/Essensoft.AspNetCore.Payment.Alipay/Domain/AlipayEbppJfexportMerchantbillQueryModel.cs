using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppJfexportMerchantbillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfexportMerchantbillQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型英文名称 ，固定传JF，表示缴费
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 外部商户的业务流水号，需要保证唯一性和幂等性
        /// </summary>
        [JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }
    }
}
