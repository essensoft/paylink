using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateEdumigrateMigrateserviceModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateEdumigrateMigrateserviceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// data字段为迁移服务数据返回 JSON结构
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
