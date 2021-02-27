using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 解除用户授权关系（授权协议号）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_4.shtml">解除用户授权关系（授权协议号）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsTerminateForAuthCodeModel : WeChatPayObject
    {
        /// <summary>
        /// 支付分服务ID
        /// </summary>
        /// <remarks>
        /// 服务ID有本接口对应产品的权限。
        /// 示例值：500001
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 撤销原因
        /// </summary>
        /// <remarks>
        /// 解除授权原因 
        /// 示例值：撤销原因
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
