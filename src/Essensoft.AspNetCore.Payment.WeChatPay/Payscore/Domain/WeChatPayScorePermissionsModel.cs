using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 商户预授权
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_2.shtml">商户预授权API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsModel : WeChatPayObject
    {
        /// <summary>
        /// AppId
        /// </summary>
        /// <remarks>
        /// 服务商申请的公众号或移动应用APPID
        /// 示例值：wxd678efh567hg6787
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

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
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 预授权成功时的授权协议号，要求此参数只能由数字、大小写字母_-*组成，且在同一个商户号下唯一。详见[商户订单号]。 
        /// 示例值：1234323JKHDFE1243252
        /// </remarks>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// 商户接收授权回调通知的地址 
        /// </summary>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }
    }
}
