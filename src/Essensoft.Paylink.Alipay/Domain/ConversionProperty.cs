using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ConversionProperty Data Structure.
    /// </summary>
    public class ConversionProperty : AlipayObject
    {
        /// <summary>
        /// 业务转化数据属性
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 转化属性名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务转化属性实例值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
