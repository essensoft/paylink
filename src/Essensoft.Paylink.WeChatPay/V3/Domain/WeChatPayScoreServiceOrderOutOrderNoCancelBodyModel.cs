using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 取消支付分订单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_16.shtml">微信支付分 - 取消支付分订单API</a> - 最新更新时间：2020.04.23</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderOutOrderNoCancelBodyModel : WeChatPayObject
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
        /// 该服务ID有本接口对应产品的权限。
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        /// <remarks>
        /// 最多30个字符，每个汉字/数字/英语都按1个字符计算超过长度报错处理。
        /// <para>示例值：用户投诉</para>
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
