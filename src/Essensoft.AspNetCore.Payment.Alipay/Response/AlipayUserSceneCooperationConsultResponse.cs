using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserSceneCooperationConsultResponse.
    /// </summary>
    public class AlipayUserSceneCooperationConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 脱敏后的支付宝登录号
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 是否是新用户，true/false。
        /// </summary>
        [JsonPropertyName("app_new")]
        public bool AppNew { get; set; }

        /// <summary>
        /// 会员权益信息列表
        /// </summary>
        [JsonPropertyName("benefit_info_list")]
        public List<MemberBenefitInfo> BenefitInfoList { get; set; }

        /// <summary>
        /// true表示该用户运营有价值；false表示没有价值
        /// </summary>
        [JsonPropertyName("consult_result")]
        public bool ConsultResult { get; set; }

        /// <summary>
        /// 表示邀请关系建立结果。true表示邀请关系建立成功，false表示不建立邀请关系或建立失败
        /// </summary>
        [JsonPropertyName("invite_result")]
        public bool InviteResult { get; set; }
    }
}
