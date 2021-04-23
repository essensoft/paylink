using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenBpaasPushSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenBpaasPushSyncModel : AlipayObject
    {
        /// <summary>
        /// bpaas应用ID
        /// </summary>
        [JsonPropertyName("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [JsonPropertyName("bpaas_app_version")]
        public string BpaasAppVersion { get; set; }

        /// <summary>
        /// 设备SN，支持同一个厂商的SN批量反馈；数组限制最大100
        /// </summary>
        [JsonPropertyName("device_sn")]
        public List<string> DeviceSn { get; set; }

        /// <summary>
        /// 厂商ID，需要和设备端的生产商ID保持一致
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
