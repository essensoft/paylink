using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopWxloginQueryModel Data Structure.
    /// </summary>
    public class KoubeiShopWxloginQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，轻店业务传MERCHANT_APP
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 授权，固定值，传authorization_code
        /// </summary>
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 前端页面获取的js_code
        /// </summary>
        [JsonPropertyName("js_code")]
        public string JsCode { get; set; }

        /// <summary>
        /// 微信的app_id
        /// </summary>
        [JsonPropertyName("wx_app_id")]
        public string WxAppId { get; set; }
    }
}
