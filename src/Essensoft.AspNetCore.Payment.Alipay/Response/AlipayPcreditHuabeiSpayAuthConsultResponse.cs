using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSpayAuthConsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSpayAuthConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否通过了鉴权的校验，通过了为true，没有通过为false
        /// </summary>
        [JsonPropertyName("auth_approved")]
        public bool AuthApproved { get; set; }

        /// <summary>
        /// 分次支付的支付信息，内部包含明细
        /// </summary>
        [JsonPropertyName("multi_stage_pay_info")]
        public MultiStagePayInfo MultiStagePayInfo { get; set; }

        /// <summary>
        /// 用户没有通过鉴权的接口校验，未能通过的原因;如果用户是可用的，那么这个字段为空；
        /// </summary>
        [JsonPropertyName("refuse_desc")]
        public string RefuseDesc { get; set; }
    }
}
