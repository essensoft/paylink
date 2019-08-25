using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberDeleteModel : AlipayObject
    {
        /// <summary>
        /// 外部会籍id
        /// </summary>
        [JsonProperty("external_member_id")]
        public string ExternalMemberId { get; set; }

        /// <summary>
        /// 健身用户id
        /// </summary>
        [JsonProperty("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 口碑的会籍ID
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外部请求id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
