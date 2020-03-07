using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniCloudDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用的appid。partner_id和mini_appid不能同时为空。
        /// </summary>
        [JsonPropertyName("mini_appid")]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，支付宝分配给商户ID。partner_id和mini_appid不能同时为空。
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
