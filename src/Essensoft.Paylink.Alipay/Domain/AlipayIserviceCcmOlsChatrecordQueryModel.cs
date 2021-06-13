using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmOlsChatrecordQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmOlsChatrecordQueryModel : AlipayObject
    {
        /// <summary>
        /// 租户实例id（数据权限id），不填，则使用默认的租户实例id
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线服务记录id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
