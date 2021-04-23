using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceModifyModel : AlipayObject
    {
        /// <summary>
        /// 服务schema版本
        /// </summary>
        [JsonPropertyName("schema_version")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务内容xml格式
        /// </summary>
        [JsonPropertyName("service_xml")]
        public string ServiceXml { get; set; }
    }
}
