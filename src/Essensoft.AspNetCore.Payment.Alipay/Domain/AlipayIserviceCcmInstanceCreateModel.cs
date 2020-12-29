using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmInstanceCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmInstanceCreateModel : AlipayObject
    {
        /// <summary>
        /// 创建人id
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 租户实例（数据权限）描述信息
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 租户实例（数据权限）名称，如果名称已经存在，将创建失败
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
