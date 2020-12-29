using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmInstanceGetModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmInstanceGetModel : AlipayObject
    {
        /// <summary>
        /// 外部id
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
