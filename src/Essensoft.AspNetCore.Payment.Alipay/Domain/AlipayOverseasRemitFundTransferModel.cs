using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitFundTransferModel Data Structure.
    /// </summary>
    public class AlipayOverseasRemitFundTransferModel : AlipayObject
    {
        /// <summary>
        /// 汇率的基准币种
        /// </summary>
        [JsonPropertyName("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 发端生成的单据号
        /// </summary>
        [JsonPropertyName("bc_remit_id")]
        public string BcRemitId { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 收端用户收到的金额
        /// </summary>
        [JsonPropertyName("receiver_amount")]
        public string ReceiverAmount { get; set; }

        /// <summary>
        /// 收端用户收到的金额币种
        /// </summary>
        [JsonPropertyName("receiver_currency")]
        public string ReceiverCurrency { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonPropertyName("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端用户的金额
        /// </summary>
        [JsonPropertyName("sender_amount")]
        public string SenderAmount { get; set; }

        /// <summary>
        /// 发端用户金额的币种
        /// </summary>
        [JsonPropertyName("sender_currency")]
        public string SenderCurrency { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonPropertyName("sender_mid")]
        public string SenderMid { get; set; }
    }
}
