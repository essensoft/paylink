using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MobileAppInfo Data Structure.
    /// </summary>
    public class MobileAppInfo : AlipayObject
    {
        /// <summary>
        /// 移动应用绑定小程序数量
        /// </summary>
        [JsonPropertyName("bind_mini_app_count")]
        public long BindMiniAppCount { get; set; }

        /// <summary>
        /// 移动应用id
        /// </summary>
        [JsonPropertyName("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 移动应用名称
        /// </summary>
        [JsonPropertyName("mobile_app_name")]
        public string MobileAppName { get; set; }

        /// <summary>
        /// 移动应用签名
        /// </summary>
        [JsonPropertyName("mobile_app_sign")]
        public string MobileAppSign { get; set; }

        /// <summary>
        /// 设备产品信息列表
        /// </summary>
        [JsonPropertyName("related_product_list")]
        public List<DeviceProductInfo> RelatedProductList { get; set; }
    }
}
