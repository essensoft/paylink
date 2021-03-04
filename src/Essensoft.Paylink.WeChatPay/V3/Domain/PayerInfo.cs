using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 支付者信息
    /// </summary>
    public class PayerInfo : WeChatPayObject
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        /// <remarks>
        /// 用户在直连商户appid下的唯一标识。
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }
    }
}
