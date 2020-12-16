using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayApplepayTransactionBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayPayApplepayTransactionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 拉取结果权限authToken
        /// </summary>
        [JsonPropertyName("authorization")]
        public string Authorization { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 毫秒级时间戳
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}
