using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExerciseUserMappingDTO Data Structure.
    /// </summary>
    public class ExerciseUserMappingDTO : AlipayObject
    {
        /// <summary>
        /// 健身用户id
        /// </summary>
        [JsonPropertyName("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
