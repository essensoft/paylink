using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAgreementSignModel Data Structure.
    /// </summary>
    public class AlipayInsSceneProductAgreementSignModel : AlipayObject
    {
        /// <summary>
        /// 签约类型，参见com.alipay.insopenprod.common.service.facade.model.enums.InsSignTypeEnum
        /// </summary>
        [JsonPropertyName("agreement_sign_type")]
        public string AgreementSignType { get; set; }

        /// <summary>
        /// 支付宝2088开头的商户userid
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户渠道编码，由系统分配固定值
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 商户产品签约失效时间，格式为： yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 商户产品签约生效起始时间，格式为yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 产品的机构code
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 签约用户ID，月sign_user_type类型匹配
        /// </summary>
        [JsonPropertyName("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签约用户ID的类型，参加枚举SignUserTypeEnum
        /// </summary>
        [JsonPropertyName("sign_user_type")]
        public string SignUserType { get; set; }
    }
}
