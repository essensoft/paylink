using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniExperienceCreateModel : AlipayObject
    {
        /// <summary>
        /// 商家小程序版本号。
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
