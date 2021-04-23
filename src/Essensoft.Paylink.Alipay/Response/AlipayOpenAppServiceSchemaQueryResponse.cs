using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServiceSchemaQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceSchemaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 服务schema版本
        /// </summary>
        [JsonPropertyName("schema_version")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务schema
        /// </summary>
        [JsonPropertyName("schema_xml")]
        public string SchemaXml { get; set; }
    }
}
