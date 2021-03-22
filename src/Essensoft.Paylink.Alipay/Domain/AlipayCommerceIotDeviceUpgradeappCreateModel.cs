using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceUpgradeappCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceUpgradeappCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户问题排查是的问题记录
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 设备的标示
        /// </summary>
        [JsonPropertyName("sn")]
        public List<string> Sn { get; set; }

        /// <summary>
        /// 目标应用的唯一标示
        /// </summary>
        [JsonPropertyName("target_app_id")]
        public string TargetAppId { get; set; }

        /// <summary>
        /// 应用需要升级到的目标版本
        /// </summary>
        [JsonPropertyName("target_app_version")]
        public string TargetAppVersion { get; set; }
    }
}
