using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 解除用户授权关系（授权协议号）- 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_4.shtml">解除用户授权关系（授权协议号）API</a> - 最新更新时间：2020.07.20</para>
    /// </remarks>
    public class WeChatPayScorePermissionsTerminateForAuthCodeBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 服务id
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限. 
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
