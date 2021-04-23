using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExtraInfo Data Structure.
    /// </summary>
    public class ExtraInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息key
        /// </summary>
        [JsonPropertyName("extra_info_key")]
        public string ExtraInfoKey { get; set; }

        /// <summary>
        /// 扩展信息value
        /// </summary>
        [JsonPropertyName("extra_info_value")]
        public string ExtraInfoValue { get; set; }
    }
}
