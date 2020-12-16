using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorPasswordModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthOperatorPasswordModifyModel : AlipayObject
    {
        /// <summary>
        /// 新的密码
        /// </summary>
        [JsonPropertyName("new_password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public OperatorQuery Operator { get; set; }

        /// <summary>
        /// 指定租户ID，新增值需联系蚂蚁操作员operator团队人工处理
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }
    }
}
