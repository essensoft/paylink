using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationPartnerIdentityQueryResponse.
    /// </summary>
    public class AlipayOpenOperationPartnerIdentityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前账号是否实名认证。true表示已经实名认证；false表示未实名认证。
        /// </summary>
        [JsonPropertyName("certified")]
        public bool Certified { get; set; }

        /// <summary>
        /// 登录账号是否主账号。若当前账号已经是开放平台合作伙伴的子账号（即操作员身份），则返回false；否则返回true。
        /// </summary>
        [JsonPropertyName("master")]
        public bool Master { get; set; }

        /// <summary>
        /// 当前账号是否已入驻蚂蚁开放平台。true表示已入驻；false表示未入驻。
        /// </summary>
        [JsonPropertyName("settled")]
        public bool Settled { get; set; }
    }
}
