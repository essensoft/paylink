using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetSubFeedbackInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetSubFeedbackInfo : AlipayObject
    {
        /// <summary>
        /// 返回的信息code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回值的描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 具体的值，例如SN号
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
