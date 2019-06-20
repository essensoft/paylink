using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberModifyModel : AlipayObject
    {
        /// <summary>
        /// 会籍的到期时间 注：name与会籍的到期时间两个可选字段至少传一个
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 口碑的会籍id
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会籍名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部请求id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
