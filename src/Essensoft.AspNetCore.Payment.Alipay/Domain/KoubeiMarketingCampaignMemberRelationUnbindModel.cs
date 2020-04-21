using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberRelationUnbindModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMemberRelationUnbindModel : AlipayObject
    {
        /// <summary>
        /// 会员模版id
        /// </summary>
        [JsonPropertyName("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 商户外部会员号
        /// </summary>
        [JsonPropertyName("out_member_no")]
        public string OutMemberNo { get; set; }

        /// <summary>
        /// 外部请求幂等号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
