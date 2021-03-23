using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 同步服务订单信息 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">微信支付分 - 同步服务订单信息API</a> - 最新更新时间：2020.03.05</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderSyncBodyModel : WeChatPayObject
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
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 该服务ID有本接口对应产品的权限，需要与创建订单时保持一致。
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        /// <remarks>
        /// 场景类型为“Order_Paid”，字符串表示“订单收款成功” 。
        /// <para>示例值：Order_Paid</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 内容信息详情
        /// </summary>
        /// <remarks>
        /// 场景类型为Order_Paid时，为必填项。
        /// </remarks>
        [JsonPropertyName("detail")]
        public SyncDetail Detail { get; set; }
    }
}
