using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoBenefitUseModel Data Structure.
    /// </summary>
    public class AlipayInsAutoBenefitUseModel : AlipayObject
    {
        /// <summary>
        /// 支付宝定义的权益编码
        /// </summary>
        [JsonPropertyName("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// ISV本次使用记录的业务单号，幂等字段
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 权益使用详情
        /// </summary>
        [JsonPropertyName("use_detail")]
        public UseDetail UseDetail { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
