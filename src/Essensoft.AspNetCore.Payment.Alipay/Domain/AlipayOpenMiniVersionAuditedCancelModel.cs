using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionAuditedCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionAuditedCancelModel : AlipayObject
    {
        /// <summary>
        /// 商家小程序版本号。可将审核中、已过审、审核被驳回的小程序版本退回到开发中的状态。
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，例如投放到支付宝钱包是支付宝端。默认支付宝端。支持： com.alipay.alipaywallet:支付宝端； com.alipay.iot.xpaas：支付宝IoT端。
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
