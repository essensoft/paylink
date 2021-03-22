using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// IoTBPaaSMerchantOrderRequireInfo Data Structure.
    /// </summary>
    public class IoTBPaaSMerchantOrderRequireInfo : AlipayObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonPropertyName("valid")]
        public bool Valid { get; set; }
    }
}
