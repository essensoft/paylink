using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 微信支付分 - 查询用户授权记录（openid）- 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_5.shtml">查询用户授权记录（openid）API</a> - 最新更新时间：2020.09.14</para>
    /// </remarks>
    public class WeChatPayScorePermissionsQueryForOpenIdResponse : WeChatPayResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限。 
        /// 示例值：2002000000000558128851361561536
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 预授权成功时的授权协议号。
        /// 示例值：1275342195190894594
        /// </remarks>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        /// <remarks>
        /// 标识用户授权服务情况。
        /// UNAVAILABLE：用户未授权服务
        /// AVAILABLE：用户已授权服务
        /// UNBINDUSER：未绑定用户（已经预授权但未完成正式授权）
        /// 示例值：UNAVAILABLE
        /// </remarks>
        [JsonPropertyName("authorization_state")]
        public string AuthorizationState { get; set; }

        /// <summary>
        /// 最近一次解除授权时间
        /// </summary>
        /// <remarks>
        /// 最近一次解除授权时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
        /// 示例值：2015-05-20T13:29:35.120+08:00
        /// </remarks>
        [JsonPropertyName("cancel_authorization_time")]
        public string CancelAuthorizationTime { get; set; }

        /// <summary>
        /// 最近一次授权成功时间
        /// </summary>
        /// <remarks>
        /// 最近一次授权成功时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
        /// 示例值：2015-05-20T13:29:35.120+08:00
        /// </remarks>
        [JsonPropertyName("authorization_success_time")]
        public string AuthorizationSuccessTime { get; set; }
    }
}
