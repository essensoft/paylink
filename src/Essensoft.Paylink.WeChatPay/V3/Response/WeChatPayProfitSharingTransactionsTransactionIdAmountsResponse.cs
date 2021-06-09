using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 资金应用 - 分账 - 查询剩余待分金额 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_6.shtml">分账 - 查询剩余待分金额API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_6.shtml">分账(服务商) - 查询剩余待分金额API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingTransactionsTransactionIdAmountsResponse : WeChatPayResponse
    {
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
        /// 订单剩余待分金额
        /// </summary>
        /// <remarks>
        /// 订单剩余待分金额，整数，单元为分
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("unsplit_amount")]
        public int UnsplitAmount { get; set; }
    }
}
