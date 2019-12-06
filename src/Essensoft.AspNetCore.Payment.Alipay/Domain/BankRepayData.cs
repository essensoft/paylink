using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BankRepayData Data Structure.
    /// </summary>
    public class BankRepayData : AlipayObject
    {
        /// <summary>
        /// 原清算交易中支付宝文件流水传的senderClrgTrcno发行方清算流水号;  追款关联的原银行清算流水号，二选一传入即可
        /// </summary>
        [JsonPropertyName("original_out_trade_no")]
        public string OriginalOutTradeNo { get; set; }

        /// <summary>
        /// 原清算交易中支付宝文件流水传的etcClrgTrcnoETC清算流水号
        /// </summary>
        [JsonPropertyName("original_trade_no")]
        public string OriginalTradeNo { get; set; }
    }
}
