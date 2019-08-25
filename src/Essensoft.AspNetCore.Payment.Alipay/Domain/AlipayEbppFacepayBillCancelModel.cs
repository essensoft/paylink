using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppFacepayBillCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFacepayBillCancelModel : AlipayObject
    {
        /// <summary>
        /// 支付宝交易流水号(和user_identity_code、user_id三者至少传一个)
        /// </summary>
        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// ISV交易流水号( 要求全局唯一)
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户ID(和user_identity_code、bill_no三者至少传一个)
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户支付宝付款码(需使用下单时用的码值，10分钟内有效）(和user_id、bill_no三者至少传一个)
        /// </summary>
        [JsonProperty("user_identity_code")]
        public string UserIdentityCode { get; set; }
    }
}
