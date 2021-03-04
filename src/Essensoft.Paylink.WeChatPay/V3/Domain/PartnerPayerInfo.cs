using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 支付者信息
    /// </summary>
    public class PartnerPayerInfo : WeChatPayObject
    {
        /// <summary>
        /// 用户服务标识
        /// </summary>
        /// <remarks>
        /// 用户在服务商appid下的唯一标识。
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
        [JsonPropertyName("sp_openid")]
        public string SpOpenId { get; set; }

        /// <summary>
        /// 用户子标识
        /// </summary>
        /// <remarks>
        /// 用户在子商户appid下的唯一标识。
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
        [JsonPropertyName("sub_openid")]
        public string SubOpenId { get; set; }
    }
}
