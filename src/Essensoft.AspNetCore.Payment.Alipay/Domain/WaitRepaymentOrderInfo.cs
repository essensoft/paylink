using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WaitRepaymentOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WaitRepaymentOrderInfo : AlipayObject
    {
        /// <summary>
        /// 垫资单id
        /// </summary>
        [JsonProperty("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 通常为商户签约的收单产品码
        /// </summary>
        [JsonProperty("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 原始的业务单号，通常为支付宝交易号
        /// </summary>
        [JsonProperty("orig_biz_order_id")]
        public string OrigBizOrderId { get; set; }

        /// <summary>
        /// 垫资金额
        /// </summary>
        [JsonProperty("wait_repayment_amount")]
        public long WaitRepaymentAmount { get; set; }
    }
}
