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
        /// 营销联动唯一标识，商户从响应结果获取到此字段后，在后续调支付宝收单接口进行支付时，需将此字段放入扩展参数中透传带入；（使用morse匿名方案时不返回此字段，需要从返回的密文中解密获取）
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
