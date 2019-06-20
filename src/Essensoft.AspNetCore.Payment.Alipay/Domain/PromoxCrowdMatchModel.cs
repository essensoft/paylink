using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoxCrowdMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoxCrowdMatchModel : AlipayObject
    {
        /// <summary>
        /// 客群码
        /// </summary>
        [JsonProperty("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 是否匹配
        /// </summary>
        [JsonProperty("is_match")]
        public bool IsMatch { get; set; }
    }
}
