using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRoleGetModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmRoleGetModel : AlipayObject
    {
        /// <summary>
        /// 部门id，不传默认用租户ID
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
