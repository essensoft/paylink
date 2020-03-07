using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransEdumigrateMigrateserviceModifyResponse.
    /// </summary>
    public class AlipayFundTransEdumigrateMigrateserviceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// data字段为迁移服务数据返回 JSON结构
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
