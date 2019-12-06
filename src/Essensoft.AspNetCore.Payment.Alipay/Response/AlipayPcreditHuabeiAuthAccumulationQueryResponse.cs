using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthAccumulationQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthAccumulationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本周期内支付宝端根据用户消费情况试算出的应付费用，仅供参考使用。
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 本周期内用户累计享受的优惠金额
        /// </summary>
        [JsonPropertyName("total_discount_amount")]
        public string TotalDiscountAmount { get; set; }

        /// <summary>
        /// 本周期内用户总的消费次数
        /// </summary>
        [JsonPropertyName("total_pay_count")]
        public string TotalPayCount { get; set; }

        /// <summary>
        /// 本周期内用户累计支付宝付款金额
        /// </summary>
        [JsonPropertyName("total_real_pay_amount")]
        public string TotalRealPayAmount { get; set; }
    }
}
