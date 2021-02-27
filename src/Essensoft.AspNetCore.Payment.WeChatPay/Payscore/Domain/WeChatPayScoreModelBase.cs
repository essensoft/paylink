using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    public abstract class WeChatPayScoreModelBase : WeChatPayObject
    {
        /// <summary>
        /// AppId
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。
        /// 示例值：wxd678efh567hg6787
        /// </remarks>
        [JsonPropertyName("appid")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// 支付分服务ID
        /// </summary>
        /// <remarks>
        /// 服务ID有本接口对应产品的权限。
        /// 示例值：500001
        /// </remarks>
        [JsonPropertyName("service_id")]
        public virtual string ServiceId { get; set; }
    }
}
