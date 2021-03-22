using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// IoTBPaaSKeyValue Data Structure.
    /// </summary>
    public class IoTBPaaSKeyValue : AlipayObject
    {
        /// <summary>
        /// 参数名key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
