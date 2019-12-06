using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniExperienceCancelModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。支付宝端：com.alipay.alipaywallet,DINGDING端：com.alibaba.android.rimet,高德端:com.amap.app,天猫精灵端:com.alibaba.ailabs.genie.webapps,支付宝IOT:com.alipay.iot.xpaas
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
