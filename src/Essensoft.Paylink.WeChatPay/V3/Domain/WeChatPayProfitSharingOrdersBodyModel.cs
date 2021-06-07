using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 资金应用 - 分账 - 请求分账 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_1.shtml">分账 - 请求分账API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_1.shtml">分账(服务商) - 请求分账API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingOrdersBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的子商户号，即分账的出资商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信分配的商户appid、微信分配的服务商appid
        /// <para>示例值：wx8888888888888888</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用ID
        /// </summary>
        /// <remarks>
        /// 微信分配的子商户公众账号ID，分账接收方类型包含PERSONAL_SUB_OPENID时必填。
        /// <para>示例值：wx8888888888888888</para>
        /// </remarks>
        [JsonPropertyName("sub_appid")]
        public string SubAppId { get; set; }

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
        /// 分账接收方列表
        /// </summary>
        /// <remarks>
        /// 分账接收方列表，可以设置出资商户作为分账接受方，最多可有50个分账接收方
        /// </remarks>
        [JsonPropertyName("receivers")]
        public List<Receiver> Receivers { get; set; }

        /// <summary>
        /// 是否解冻剩余未分资金
        /// </summary>
        /// <remarks>
        /// 1、如果为true，该笔订单剩余未分账的金额会解冻回分账方商户；
        /// 2、如果为false，该笔订单剩余未分账的金额不会解冻回分账方商户，可以对该笔订单再次进行分账。
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("unfreeze_unsplit")]
        public bool UnfreezeUnsplit { get; set; }
    }
}
