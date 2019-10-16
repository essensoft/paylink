using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransUniTransferResponse.
    /// </summary>
    public class AlipayFundTransUniTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        [JsonProperty("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 转账单据状态。  SUCCESS：成功（对转账到银行卡的单据, 该状态可能变为退票[REFUND]状态）；  FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）；  DEALING：处理中；  REFUND：退票；
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("trans_date")]
        public string TransDate { get; set; }
    }
}
