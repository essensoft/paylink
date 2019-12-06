using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAgreementQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneProductAgreementQueryModel : AlipayObject
    {
        /// <summary>
        /// 签约协议类型，参见InsSignTypeEnum
        /// </summary>
        [JsonPropertyName("agreement_sign_type")]
        public string AgreementSignType { get; set; }

        /// <summary>
        /// 支付宝2088开头的签约商户的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 签约渠道，有系统分配给用户
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 商户协议有效时间查询的最大时间，格式为yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("end_effect_time")]
        public string EndEffectTime { get; set; }

        /// <summary>
        /// 产品机构编码
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 签约用户id，与sign_user_type匹配
        /// </summary>
        [JsonPropertyName("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签约用户类型，详见SignUserTypeEnum
        /// </summary>
        [JsonPropertyName("sign_user_type")]
        public string SignUserType { get; set; }

        /// <summary>
        /// 查询的有效期范围的开始时间条件
        /// </summary>
        [JsonPropertyName("start_effect_time")]
        public string StartEffectTime { get; set; }

        /// <summary>
        /// 状态枚举详见InsAgreementStatusEnum
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
