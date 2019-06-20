using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LabelForOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class LabelForOpenapi : AlipayObject
    {
        /// <summary>
        /// 标记类型
        /// </summary>
        [JsonProperty("label_type")]
        public string LabelType { get; set; }

        /// <summary>
        /// 标记类型的值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
