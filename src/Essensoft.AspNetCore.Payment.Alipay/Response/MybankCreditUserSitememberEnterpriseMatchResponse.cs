using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditUserSitememberEnterpriseMatchResponse.
    /// </summary>
    public class MybankCreditUserSitememberEnterpriseMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 本接口会通过传入的alipay_login_id查询企业支付宝会员信息，然后与传入的企业信息做比对，同时满足下面2个条件时返回true，反之则为false：  1. 公司名称一致；  2. 支付宝会员中的证件号存在于传入的工商注册号和社会信用代码里的一个
        /// </summary>
        [JsonPropertyName("match")]
        public bool Match { get; set; }

        /// <summary>
        /// MEMBER_NOT_EXIST 会员不存在  MEMBER_CERT_GRADE_NOT_CORRECT 会员认证等级不正确  COMPANY_NAME_DIFF 公司名称不同  COMPANY_CERTNO_DIFF 公司证件号不同
        /// </summary>
        [JsonPropertyName("not_match_code")]
        public string NotMatchCode { get; set; }
    }
}
