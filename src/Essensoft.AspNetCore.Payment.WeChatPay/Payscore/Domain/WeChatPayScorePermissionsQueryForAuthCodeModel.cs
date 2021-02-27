using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 查询用户授权记录（授权协议号）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_3.shtml">查询用户授权记录（授权协议号）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsQueryForAuthCodeModel : WeChatPayObject
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
    }
}
