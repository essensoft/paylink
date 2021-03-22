using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvQrcodeBindModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationIsvQrcodeBindModel : AlipayObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("business_params")]
        public QrCodeBusinessParam BusinessParams { get; set; }

        /// <summary>
        /// 小程序类型
        /// </summary>
        [JsonPropertyName("mini_type")]
        public string MiniType { get; set; }

        /// <summary>
        /// 目标跳转页面
        /// </summary>
        [JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// 微信公众号二维码码
        /// </summary>
        [JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
