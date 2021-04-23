using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabillsumQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabillsumQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总商家优惠金额
        /// </summary>
        [JsonPropertyName("mercht_disc_amt")]
        public string MerchtDiscAmt { get; set; }

        /// <summary>
        /// 总订单金额
        /// </summary>
        [JsonPropertyName("order_amt")]
        public string OrderAmt { get; set; }

        /// <summary>
        /// 总交易收款金额
        /// </summary>
        [JsonPropertyName("recv_amt")]
        public string RecvAmt { get; set; }

        /// <summary>
        /// 总交易收款笔数
        /// </summary>
        [JsonPropertyName("recv_cnt")]
        public long RecvCnt { get; set; }

        /// <summary>
        /// 总交易退款金额
        /// </summary>
        [JsonPropertyName("refund_amt")]
        public string RefundAmt { get; set; }

        /// <summary>
        /// 总交易退款笔数
        /// </summary>
        [JsonPropertyName("refund_cnt")]
        public long RefundCnt { get; set; }
    }
}
