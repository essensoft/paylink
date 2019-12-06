using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuOperateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPartnerMenuOperateModel : AlipayObject
    {
        /// <summary>
        /// 行为参数
        /// </summary>
        [JsonPropertyName("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 行为类型(in，out，api)
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 服务窗id
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 第三方账号ID ,银行卡号/户号/手机号
        /// </summary>
        [JsonPropertyName("third_account_id")]
        public string ThirdAccountId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
