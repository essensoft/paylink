using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionGrayOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionGrayOnlineModel : AlipayObject
    {
        /// <summary>
        /// 商家小程序版本号，需为审核通过状态的小程序版本。
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，例如投放到支付宝钱包是支付宝端。默认支付宝端。支持： com.alipay.alipaywallet:支付宝端； com.alipay.iot.xpaas：支付宝IoT端。
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序灰度策略值。枚举支持：p10、p30、p50。其中 p10 代表 10% 的用户，p30 代表 30% 的用户，p50 代表 50% 的用户。
        /// </summary>
        [JsonPropertyName("gray_strategy")]
        public string GrayStrategy { get; set; }
    }
}
