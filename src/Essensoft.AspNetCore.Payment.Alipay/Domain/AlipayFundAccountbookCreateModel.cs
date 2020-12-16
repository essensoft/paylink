using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundAccountbookCreateModel Data Structure.
    /// </summary>
    public class AlipayFundAccountbookCreateModel : AlipayObject
    {
        /// <summary>
        /// JSON格式，传递业务扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商户系统会员的唯一标识
        /// </summary>
        [JsonPropertyName("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部商户用户类型:BUSINESS_EMPLOYEE
        /// </summary>
        [JsonPropertyName("merchant_user_type")]
        public string MerchantUserType { get; set; }

        /// <summary>
        /// 资金记账本的业务场景
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
