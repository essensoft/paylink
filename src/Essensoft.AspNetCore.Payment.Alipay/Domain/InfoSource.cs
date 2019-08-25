using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InfoSource Data Structure.
    /// </summary>
    [Serializable]
    public class InfoSource : AlipayObject
    {
        /// <summary>
        /// 儿童信息来源的类型，目前支持name
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 信息来源的取值，比如type为name时，value对应儿童的姓名
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
