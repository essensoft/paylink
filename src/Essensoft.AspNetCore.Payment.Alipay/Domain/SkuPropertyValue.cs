using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuPropertyValue Data Structure.
    /// </summary>
    public class SkuPropertyValue : AlipayObject
    {
        /// <summary>
        /// 外部sku属性值ID,由外部商户定义
        /// </summary>
        [JsonPropertyName("out_pv_id")]
        public string OutPvId { get; set; }

        /// <summary>
        /// 外部商户sku属性值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
