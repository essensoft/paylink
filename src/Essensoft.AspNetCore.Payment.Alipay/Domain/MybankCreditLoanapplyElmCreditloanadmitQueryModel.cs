using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyElmCreditloanadmitQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoanapplyElmCreditloanadmitQueryModel : AlipayObject
    {
        /// <summary>
        /// 站点会员
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点的会员ID
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
