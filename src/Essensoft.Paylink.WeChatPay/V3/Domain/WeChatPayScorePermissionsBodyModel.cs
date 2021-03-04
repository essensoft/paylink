using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 商户预授权 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_2.shtml">微信支付分 - 商户预授权API</a> - 最新更新时间：2020.07.20</para>
    /// </remarks>
    public class WeChatPayScorePermissionsBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 服务id
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限.
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 服务商申请的公众号或移动应用APPID
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 预授权成功时的授权协议号，要求此参数只能由数字、大小写字母_-*组成，且在同一个商户号下唯一。详见[商户订单号]。 
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <remarks>
        /// 商户接收授权回调通知的地址 
        /// <para>示例值：http://www.qq.com</para>
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }
    }
}
