using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanPayUser Data Structure.
    /// </summary>
    public class LoanPayUser : AlipayObject
    {
        /// <summary>
        /// 支付宝Id,无需脱敏
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 1.ALIPAY(支付宝)，2.TAOBAO(淘宝)，3.CBU(中文站)，4.ICBU(国际站)
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点用户id
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
