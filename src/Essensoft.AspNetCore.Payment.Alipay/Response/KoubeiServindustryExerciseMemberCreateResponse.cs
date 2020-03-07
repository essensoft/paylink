using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberCreateResponse.
    /// </summary>
    public class KoubeiServindustryExerciseMemberCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑用户健身唯一ID，和支付宝userId一一对应
        /// </summary>
        [JsonPropertyName("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 口碑的会籍ID
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }
    }
}
