using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentMerchantPromo Data Structure.
    /// </summary>
    public class InteligentMerchantPromo : AlipayObject
    {
        /// <summary>
        /// 商户自运营活动，当promo_type='GENERAL_MERCHANT',该对象不能为空，其他类型无效
        /// </summary>
        [JsonPropertyName("general_promo")]
        public InteligentGeneralMerchantPromo GeneralPromo { get; set; }

        /// <summary>
        /// 子活动营销类型；枚举值：（GENERAL_MERCHANT：商户自运营活动）
        /// </summary>
        [JsonPropertyName("promo_type")]
        public string PromoType { get; set; }
    }
}
