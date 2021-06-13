using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundJointaccountMemberConsultResponse.
    /// </summary>
    public class AlipayFundJointaccountMemberConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 员工列表
        /// </summary>
        [JsonPropertyName("member_list")]
        public List<MemberStatusRespDTO> MemberList { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
