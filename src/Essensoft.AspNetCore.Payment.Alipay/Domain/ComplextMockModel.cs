using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ComplextMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class ComplextMockModel : AlipayObject
    {
        /// <summary>
        /// biz_model
        /// </summary>
        [JsonProperty("biz_model")]
        public SimpleMockModel BizModel { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// 208xxx
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }
    }
}
