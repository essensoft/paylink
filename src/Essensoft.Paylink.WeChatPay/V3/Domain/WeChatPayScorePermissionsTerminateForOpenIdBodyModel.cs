using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 解除用户授权关系（openid）- 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_6.shtml">微信支付分 - 解除用户授权关系（openid）API</a> - 最新更新时间：2020.07.20</para>
    /// </remarks>
    public class WeChatPayScorePermissionsTerminateForOpenIdBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限.
        /// <para>示例值：2002000000000558128851361561536</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系.需要在本系统先进行配置.
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 撤销原因
        /// </summary>
        /// <remarks>
        /// 撤销原因
        /// <para>示例值：reason</para>
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
