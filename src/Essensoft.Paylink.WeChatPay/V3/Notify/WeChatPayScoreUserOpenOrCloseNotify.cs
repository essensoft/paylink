using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Notify
{
    /// <summary>
    /// 微信支付分 - 开启/解除授权服务回调通知
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_10.shtml">微信支付分 - 开启/解除授权服务回调通知API</a> - 最新更新时间：2020.07.24</para>
    /// </remarks>
    public class WeChatPayScoreUserOpenOrCloseNotify : WeChatPayNotify
    {
        /// <summary>
        /// 公众账号ID
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的公众账号ID。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的商户号。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户签约单号
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的商户请求唯一标识（新签约的用户，且在授权签约中上传了该字段，则在解约授权回调通知中有返回）。
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的服务ID。
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        /// <remarks>
        /// 微信用户在商户对应appid下的唯一标识。
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 回调状态
        /// </summary>
        /// <remarks>
        /// 1、USER_OPEN_SERVICE：授权成功 
        /// 2、USER_CLOSE_SERVICE：解除授权成功
        /// <para>示例值：USER_OPEN_SERVICE</para>
        /// </remarks>
        [JsonPropertyName("user_service_status")]
        public string UserServiceStatus { get; set; }

        /// <summary>
        /// 服务开启/解除授权时间
        /// </summary>
        /// <remarks>
        /// 服务开启/解除授权成功时间。
        /// <para>示例值：20180225112233</para>
        /// </remarks>
        [JsonPropertyName("openorclose_time")]
        public string OpenOrCloseTime { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 授权协议号，预授权时返回，非预授权不返回
        /// <para>示例值：1275342195190894594</para>
        /// </remarks>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }
    }
}
