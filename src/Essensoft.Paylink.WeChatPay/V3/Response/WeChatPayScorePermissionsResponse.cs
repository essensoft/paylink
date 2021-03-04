using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 微信支付分 - 商户预授权 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_2.shtml">微信支付分 - 商户预授权API</a> - 最新更新时间：2020.07.20</para>
    /// </remarks>
    public class WeChatPayScorePermissionsResponse : WeChatPayResponse
    {
        /// <summary>
        /// 预授权token
        /// </summary>
        /// <remarks>
        /// 用于跳转到微信侧小程序授权数据,跳转到微信侧小程序传入，时效性为1小时
        /// <para>示例值：apply_permissions_token</para>
        /// </remarks>
        [JsonPropertyName("apply_permissions_token")]
        public string ApplyPermissionsToken { get; set; }
    }
}
