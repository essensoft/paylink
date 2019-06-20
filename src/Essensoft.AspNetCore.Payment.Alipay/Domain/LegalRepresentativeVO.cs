using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LegalRepresentativeVO Data Structure.
    /// </summary>
    [Serializable]
    public class LegalRepresentativeVO : AlipayObject
    {
        /// <summary>
        /// 职务
        /// </summary>
        [JsonProperty("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
