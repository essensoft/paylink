using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Notify
{
    /// <summary>
    /// 开启/解除授权服务回调通知
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_10.shtml">开启/解除授权服务回调通知API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsOpenOrCancelNotify : WeChatPayNotify
    {
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
        /// 商户签约单号
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的商户请求唯一标识（新签约的用户，且在授权签约中上传了该字段，则在解约授权回调通知中有返回）。
        /// 示例值：1234323JKHDFE1243252
        /// </remarks>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付分服务ID
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 微信用户在商户对应appid下的唯一标识
        /// </summary>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 回调状态
        /// </summary>
        /// <remarks>
        /// 1、USER_OPEN_SERVICE：授权成功 
        /// 2、USER_CLOSE_SERVICE：解除授权成功
        /// 示例值：USER_OPEN_SERVICE
        /// </remarks>
        [JsonPropertyName("user_service_status")]
        public string UserServiceStatus { get; set; }

        /// <summary>
        /// 服务开启/解除授权时间
        /// </summary>
        /// <remarks>
        /// 服务开启/解除授权成功时间。
        /// 示例值：20180225112233
        /// </remarks>
        [JsonPropertyName("openorclose_time")]
        public string OpenOrCloseTime { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 授权协议号，预授权时返回，非预授权不返回
        /// 示例值：1275342195190894594
        /// </remarks>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }
    }
}
