using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayAppMarketingConsultResponse.
    /// </summary>
    public class AlipayPayAppMarketingConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 指定优惠信息；商户无需关注内容，调用收单支付接口时需将此字段的取值放在promo_params中透传带入，key为assignDiscounts
        /// </summary>
        [JsonPropertyName("assign_discounts")]
        public string AssignDiscounts { get; set; }

        /// <summary>
        /// 业务标签；当请求入参need_return_tag为true时才会返回
        /// </summary>
        [JsonPropertyName("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 仅当请求使用morse匿名技术时会返回此字段； morse匿名技术使用的盲签名，商户使用此值与私钥一起对混淆后的密文结果进行解密；
        /// </summary>
        [JsonPropertyName("blind_signature")]
        public string BlindSignature { get; set; }

        /// <summary>
        /// 仅当请求使用morse匿名技术时会返回此字段； morse匿名技术产出的混淆后的密文结果，需使用商户私钥及接口返回的盲签名对密文进行解密；
        /// </summary>
        [JsonPropertyName("confused_cipher_list")]
        public List<string> ConfusedCipherList { get; set; }

        /// <summary>
        /// 营销图片地址（使用morse匿名方案时不返回此字段，需要从返回的密文中解密获取）
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 支付运营扩展信息；商户无需关注内容，调用收单支付接口时需将此字段的取值放在business_params中透传带入，key为payOperationInfo
        /// </summary>
        [JsonPropertyName("pay_operation_info")]
        public string PayOperationInfo { get; set; }

        /// <summary>
        /// 已废弃不再使用
        /// </summary>
        [JsonPropertyName("pre_pay_token")]
        public string PrePayToken { get; set; }

        /// <summary>
        /// 营销文案文本内容（使用morse匿名方案时不返回此字段，需要从返回的密文中解密获取）
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
