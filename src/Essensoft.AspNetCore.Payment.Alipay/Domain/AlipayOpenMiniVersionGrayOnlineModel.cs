using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionGrayOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionGrayOnlineModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，例如投放到支付宝钱包是支付宝端。该参数可选，默认支付宝端，目前仅支持支付宝端，枚举列举：com.alipay.alipaywallet:支付宝端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序灰度策略值，支持p10，p30，p50，其中p10代表10%的用户，p30代表30%的用户，p50代表50%的用户
        /// </summary>
        [JsonPropertyName("gray_strategy")]
        public string GrayStrategy { get; set; }
    }
}
