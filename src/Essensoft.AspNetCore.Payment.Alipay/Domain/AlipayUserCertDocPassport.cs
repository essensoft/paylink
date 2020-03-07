using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocPassport Data Structure.
    /// </summary>
    public class AlipayUserCertDocPassport : AlipayObject
    {
        /// <summary>
        /// base64编码后的主页照片
        /// </summary>
        [JsonPropertyName("encoded_img")]
        public string EncodedImg { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 姓氏，拼音
        /// </summary>
        [JsonPropertyName("family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// 名，拼音
        /// </summary>
        [JsonPropertyName("given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
