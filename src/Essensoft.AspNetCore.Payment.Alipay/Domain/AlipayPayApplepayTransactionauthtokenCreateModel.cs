using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenCreateModel Data Structure.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenCreateModel : AlipayObject
    {
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
        /// 卡id列表，与卡id两者不能同时为空
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifiers")]
        public List<string> ProvisioningBundleIdentifiers { get; set; }

        /// <summary>
        /// 推送通知给wagu设备的token
        /// </summary>
        [JsonPropertyName("push_token")]
        public string PushToken { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [JsonPropertyName("reference_identifier")]
        public string ReferenceIdentifier { get; set; }
    }
}
