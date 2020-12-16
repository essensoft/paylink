using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayOrderQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradePayOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝UID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 子场景
        /// </summary>
        [JsonPropertyName("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
