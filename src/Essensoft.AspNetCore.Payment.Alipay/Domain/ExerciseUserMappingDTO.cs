using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseUserMappingDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseUserMappingDTO : AlipayObject
    {
        /// <summary>
        /// 健身用户id
        /// </summary>
        [JsonProperty("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
