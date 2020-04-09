using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TransactionDetailDTO Data Structure.
    /// </summary>
    public class TransactionDetailDTO : AlipayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 非实付金额列表
        /// </summary>
        [JsonPropertyName("amount_modifiers")]
        public List<TransactionAmountModifierDTO> AmountModifiers { get; set; }

        /// <summary>
        /// 支付中断推进方式
        /// </summary>
        [JsonPropertyName("authentication_details")]
        public TransactionAuthenticationDetailDTO AuthenticationDetails { get; set; }

        /// <summary>
        /// 条码id
        /// </summary>
        [JsonPropertyName("barcode_identifier")]
        public string BarcodeIdentifier { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [JsonPropertyName("dpan_identifier")]
        public string DpanIdentifier { get; set; }

        /// <summary>
        /// tradeNo
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [JsonPropertyName("nominal_amount")]
        public string NominalAmount { get; set; }

        /// <summary>
        /// 支付主渠道
        /// </summary>
        [JsonPropertyName("primary_funding_source_description")]
        public string PrimaryFundingSourceDescription { get; set; }

        /// <summary>
        /// pId
        /// </summary>
        [JsonPropertyName("raw_merchant_name")]
        public string RawMerchantName { get; set; }

        /// <summary>
        /// iso8601格式时间
        /// </summary>
        [JsonPropertyName("transaction_date")]
        public string TransactionDate { get; set; }

        /// <summary>
        /// 交易标识
        /// </summary>
        [JsonPropertyName("transaction_identifier")]
        public string TransactionIdentifier { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonPropertyName("transaction_status")]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }
    }
}
