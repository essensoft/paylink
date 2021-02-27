using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response
{
    /// <summary>
    ///  微信支付分 - 取消支付分订单API
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_16.shtml">取消支付分订单API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderCancelResponse : WeChatPayScoreResponseBase
    {
        /// <summary>
        /// 微信支付服务订单号
        /// </summary>
        /// <remarks>
        /// 微信支付服务订单号，每个微信支付服务订单号与商户号下对应的商户服务订单号一一对应。
        /// 示例值：15646546545165651651
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
