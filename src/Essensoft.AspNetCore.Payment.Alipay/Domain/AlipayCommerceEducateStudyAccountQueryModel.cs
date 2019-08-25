using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateStudyAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateStudyAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 学校内标
        /// </summary>
        [JsonProperty("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
