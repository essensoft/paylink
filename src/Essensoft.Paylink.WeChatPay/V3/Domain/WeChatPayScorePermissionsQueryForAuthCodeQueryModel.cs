using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 查询用户授权记录（授权协议号）- 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_3.shtml">微信支付分 - 查询用户授权记录（授权协议号）API</a> - 最新更新时间：2020.09.14</para>
    /// </remarks>
    public class WeChatPayScorePermissionsQueryForAuthCodeQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限。 
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
