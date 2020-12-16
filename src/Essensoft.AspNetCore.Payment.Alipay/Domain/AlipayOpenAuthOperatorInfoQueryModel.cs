using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthOperatorInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作员查询参数
        /// </summary>
        [JsonPropertyName("operator_query")]
        public OperatorQuery OperatorQuery { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }
    }
}
