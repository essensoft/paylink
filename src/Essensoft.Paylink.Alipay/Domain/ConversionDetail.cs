using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ConversionDetail Data Structure.
    /// </summary>
    public class ConversionDetail : AlipayObject
    {
        /// <summary>
        /// 转化事件id
        /// </summary>
        [JsonPropertyName("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化事件名称
        /// </summary>
        [JsonPropertyName("conversion_name")]
        public string ConversionName { get; set; }

        /// <summary>
        /// 转化事件类型代码
        /// </summary>
        [JsonPropertyName("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 转化事件类型名称
        /// </summary>
        [JsonPropertyName("conversion_type_name")]
        public string ConversionTypeName { get; set; }

        /// <summary>
        /// 状态: ENABLE( "生效"); DISABLE( "失效"); DELETE("删除")
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
