using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditUserSitememberEnterpriseMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserSitememberEnterpriseMatchModel : AlipayObject
    {
        /// <summary>
        /// 工商注册号，与social_credit_code字段不能同时为空
        /// </summary>
        [JsonProperty("business_reg_no")]
        public string BusinessRegNo { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 站点类型，如支付宝、淘宝等
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点登录号，比如企业支付宝的手机号或邮箱
        /// </summary>
        [JsonProperty("site_login_id")]
        public string SiteLoginId { get; set; }

        /// <summary>
        /// 统一社会信用代码，与business_reg_no字段不能同时为空
        /// </summary>
        [JsonProperty("social_credit_code")]
        public string SocialCreditCode { get; set; }
    }
}
