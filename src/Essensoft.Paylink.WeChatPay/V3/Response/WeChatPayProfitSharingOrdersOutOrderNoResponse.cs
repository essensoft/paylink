using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 资金应用 - 分账 - 查询分账结果 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_2.shtml">分账 - 查询分账结果API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_2.shtml">分账(服务商) - 查询分账结果API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingOrdersOutOrderNoResponse : WeChatPayResponse
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 子商户的商户号，有微信支付生成并下发。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号
        /// <para>示例值：4208450740201411110007820472</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        /// <remarks>
        /// 服务商系统内部的分账单号，在服务商系统内部唯一，同一分账单号多次请求等同一次。只能是数字、大小写字母_-|*@
        /// <para>示例值：P20150806125346</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 微信分账单号
        /// </summary>
        /// <remarks>
        /// 微信分账单号，微信系统返回的唯一标识
        /// <para>示例值：3008450740201411110007820472</para>
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 分账单状态
        /// </summary>
        /// <remarks>
        /// 分账单状态（每个接收方的分账结果请查看receivers中的result字段），枚举值：
        /// 1、PROCESSING：处理中
        /// 2、FINISHED：分账完成
        /// <para>示例值：FINISHED</para>
        /// </remarks>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 分账接收方列表
        /// </summary>
        /// <remarks>
        /// 分账接收方列表
        /// </remarks>
        [JsonPropertyName("receivers")]
        public List<ReceiverResponse> Receivers { get; set; }
    }
}
