using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 微信支付分 - 取消支付分订单API - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_16.shtml">微信支付分 - 取消支付分订单API</a> - 最新更新时间：2020.04.23</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderOutOrderNoCancelResponse : WeChatPayResponse
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系。
        /// 此参数需在本系统先进行配置，并与创建订单时的appid保持一致。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        /// <remarks>
        /// 调用接口提交的商户号。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 调用接口提交的商户服务订单号。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 调用该接口提交的服务ID。
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 微信支付服务订单号
        /// </summary>
        /// <remarks>
        /// 微信支付服务订单号，每个微信支付服务订单号与商户号下对应的商户服务订单号一一对应。
        /// <para>示例值：15646546545165651651</para>
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
