using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 商户发起催收扣款 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_19.shtml">商户发起催收扣款API</a> - 最新更新时间：2020.03.05</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderPayBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。
        /// 示例值：wxd678efh567hg6787
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限。
        /// 示例值：500001
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
