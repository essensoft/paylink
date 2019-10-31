using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentInformation Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentInformation : AlipayObject
    {
        /// <summary>
        /// 处理行为，默认为PAY，也可以是FREEZE等等
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 支付的金额，比如{"FAMILY_POINT":2000}代表支付2000家庭积分，如果是现金单位元
        /// </summary>
        [JsonProperty("amount")]
        public PriceInformation Amount { get; set; }

        /// <summary>
        /// 每个订单下面的支付请求号唯一即可，如果只是一次支付，建议可以直接用out_biz_no作为支付请求号
        /// </summary>
        [JsonProperty("request_no")]
        public string RequestNo { get; set; }
    }
}
