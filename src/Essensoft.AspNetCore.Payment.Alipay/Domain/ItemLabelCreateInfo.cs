using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemLabelCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemLabelCreateInfo : AlipayObject
    {
        /// <summary>
        /// 标签键  OIL_NUM：油号
        /// </summary>
        [JsonProperty("label_key")]
        public string LabelKey { get; set; }

        /// <summary>
        /// 标签值：  OIL_NUM对应的值为：95# 92# 98# 等等
        /// </summary>
        [JsonProperty("label_value")]
        public string LabelValue { get; set; }
    }
}
