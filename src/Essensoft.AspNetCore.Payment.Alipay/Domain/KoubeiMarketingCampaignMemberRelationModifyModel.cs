using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberRelationModifyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMemberRelationModifyModel : AlipayObject
    {
        /// <summary>
        /// 会员开通时间
        /// </summary>
        [JsonPropertyName("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 会员过期时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 新的等级（不修改不传）
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

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
        /// 积分
        /// </summary>
        [JsonPropertyName("point")]
        public string Point { get; set; }

        /// <summary>
        /// 外部请求幂等号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会员开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
