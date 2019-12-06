using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiOperationContext Data Structure.
    /// </summary>
    public class KoubeiOperationContext : AlipayObject
    {
        /// <summary>
        /// 如果是isv代操作，请传入ISV；如果是其他角色（商户MERCHANT、服务商PROVIDER、服务商员工S_STAFF、商户员工M_STAFF）操作，不用填写。
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }
    }
}
