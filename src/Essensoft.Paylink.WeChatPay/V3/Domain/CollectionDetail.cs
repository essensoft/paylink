using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 收款明细列表
    /// </summary>
    public class CollectionDetail : WeChatPayObject
    {
        /// <summary>
        /// 收款序号
        /// </summary>
        /// <remarks>
        /// 从1开始递增
        /// <para>示例值：1</para>
        /// </remarks>
        [JsonPropertyName("seq")]
        public ulong? Seq { get; set; }

        /// <summary>
        /// 单笔收款金额
        /// </summary>
        /// <remarks>
        /// 单笔收款动作的金额，只能为整数，详见支付金额。
        /// <para>示例值：10000</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 收款成功渠道
        /// </summary>
        /// <remarks>
        /// NEWTON：微信支付分
        /// MCH：商户渠道
        /// <para>示例值：NEWTON</para>
        /// </remarks>
        [JsonPropertyName("paid_type")]
        public string PaidType { get; set; }

        /// <summary>
        /// 收款成功时间
        /// </summary>
        /// <remarks>
        /// 支付成功时间，支持两种格式:yyyyMMddHHmmss和yyyyMMdd
        /// 1、传入20091225091010表示2009年12月25日9点10分10秒
        /// 2、传入20091225默认认为时间为2009年12月25日0点0分0秒
        /// <para>示例值：20091225091210</para>
        /// </remarks>
        [JsonPropertyName("paid_time")]
        public string PaidTime { get; set; }

        /// <summary>
        /// 微信支付交易单号
        /// </summary>
        /// <remarks>
        /// 结单交易单号，等于普通支付接口中的transaction_id，可以使用该订单号在APP支付->API列表->查询订单、申请退款。只有单据状态为USER_PAID，且收款成功渠道为支付分渠道，收款金额大于0，才会返回结单交易单号。
        /// <para>示例值：15646546545165651651</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 优惠功能
        /// </summary>
        /// <remarks>
        /// 注：针对2020年5月27日10:00:00以后完结的订单生效
        /// </remarks>
        [JsonPropertyName("promotion_detail")]
        public List<PromotionDetail> PromotionDetail { get; set; }
    }
}
