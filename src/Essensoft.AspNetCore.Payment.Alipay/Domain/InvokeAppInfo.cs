using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvokeAppInfo Data Structure.
    /// </summary>
    public class InvokeAppInfo : AlipayObject
    {
        /// <summary>
        /// 调用应用id
        /// </summary>
        [JsonPropertyName("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 调用应用logo
        /// </summary>
        [JsonPropertyName("invoke_app_logo")]
        public string InvokeAppLogo { get; set; }

        /// <summary>
        /// 调用应用名称
        /// </summary>
        [JsonPropertyName("invoke_app_name")]
        public string InvokeAppName { get; set; }

        /// <summary>
        /// 设备产品列表信息
        /// </summary>
        [JsonPropertyName("related_product_list")]
        public List<DeviceProductInfo> RelatedProductList { get; set; }
    }
}
