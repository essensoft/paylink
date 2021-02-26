using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response
{
    public class WeChatPayScoreResponseBase : WeChatPayResponse
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public virtual string OutOrderNo { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        [JsonPropertyName("appid")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonPropertyName("mchid")]
        public virtual string MchId { get; set; }

        /// <summary>
        /// 支付分服务ID
        /// </summary>
        [JsonPropertyName("service_id")]
        public virtual string ServiceId { get; set; }
    }
}
