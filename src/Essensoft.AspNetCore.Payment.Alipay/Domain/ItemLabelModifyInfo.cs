using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemLabelModifyInfo Data Structure.
    /// </summary>
    public class ItemLabelModifyInfo : AlipayObject
    {
        /// <summary>
        /// 标签键  OIL_NUM：油号
        /// </summary>
        [JsonPropertyName("label_key")]
        public string LabelKey { get; set; }

        /// <summary>
        /// 标签值：  OIL_NUM对应的值为：95# 92# 98# 等等
        /// </summary>
        [JsonPropertyName("label_value")]
        public string LabelValue { get; set; }
    }
}
