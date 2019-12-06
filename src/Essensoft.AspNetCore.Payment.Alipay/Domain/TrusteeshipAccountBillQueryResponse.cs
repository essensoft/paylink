using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TrusteeshipAccountBillQueryResponse Data Structure.
    /// </summary>
    public class TrusteeshipAccountBillQueryResponse : AlipayObject
    {
        /// <summary>
        /// 账单日
        /// </summary>
        [JsonPropertyName("account_date")]
        public string AccountDate { get; set; }

        /// <summary>
        /// 流水类型，取值为I/O，I表示IN，即流入；O表示OUT，即流出。
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 涉及金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账户剩余金额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 托管流水号
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonPropertyName("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 支付宝ID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
