using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionUploadModel : AlipayObject
    {
        /// <summary>
        /// 商家小程序版本号。版本号必须满足 x.y.z, 且均为数字。要求版本号比商户之前最新的版本号高。
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，默认支付宝端 。支持：com.alipay.alipaywallet：支付宝端。 com.alipay.iot.xpaas：支付宝IoT端。 例如投放到支付宝钱包是支付宝端。
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 自定义参数，用于配置商家小程序的个性化内容，具体使用方法参见示例代码。 在小程序中可以通过 <a href="https://opendocs.alipay.com/mini/api/getExtConfig">my.getExtConfig()</a> 或 <a href="https://opendocs.alipay.com/mini/api/getExtConfigSync">my.getExtConfigSync()</a> 获取 ext 参数内容（建议支付宝版本 > 10.1.38，并使用 <a href="https://opendocs.alipay.com/mini/api/can-i-use">my.canIUse</a> 做兼容处理）。
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 小程序模板 APPID。
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 小程序模板版本号。版本号必须满足 x.y.z, 且均为数字。不传默认使用最新在架（已上架）模板版本。
        /// </summary>
        [JsonPropertyName("template_version")]
        public string TemplateVersion { get; set; }
    }
}
