using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 查询支付分订单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">微信支付分 - 查询支付分订单API</a></para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 商户服务订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部服务订单号（不是交易单号），与创建订单时一致
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 回跳查询ID
        /// </summary>
        /// <remarks>
        /// 微信侧回跳到商户前端时用于查单的单据查询id。详见章节“小程序跳转接口，回跳商户接口”。
        /// 商户单号与回跳查询id必填其中一个.不允许都填写或都不填写。
        /// <para>示例值：15646546545165651651</para>
        /// </remarks>
        [JsonPropertyName("query_id")]
        public string QueryId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }
    }
}
