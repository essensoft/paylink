using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberRelationBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberRelationBindModel : AlipayObject
    {
        /// <summary>
        /// 会员开通时间
        /// </summary>
        [JsonProperty("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 会员过期时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// 会员模版id
        /// </summary>
        [JsonProperty("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 商户外部会员号
        /// </summary>
        [JsonProperty("out_member_no")]
        public string OutMemberNo { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        [JsonProperty("point")]
        public string Point { get; set; }

        /// <summary>
        /// 外部请求幂等号
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会员开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
