using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 支付者信息
    /// </summary>
    public class PayerInfo : WeChatPayObject
    {
        /// <summary>
        /// 用户标识
        /// 用户在直连商户appid下的唯一标识。
        /// 示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o
        /// </summary>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }
    }
}
