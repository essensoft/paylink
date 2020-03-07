using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReceiptQuoteInfo Data Structure.
    /// </summary>
    public class ReceiptQuoteInfo : AlipayObject
    {
        /// <summary>
        /// The base currency
        /// </summary>
        [JsonPropertyName("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// a currency pair is the quotation of the relative value of a currency unit against the unit of another currency.
        /// </summary>
        [JsonPropertyName("base_currency_unit")]
        public string BaseCurrencyUnit { get; set; }

        /// <summary>
        /// the time of this quote to be unavaible
        /// </summary>
        [JsonPropertyName("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// fxRate
        /// </summary>
        [JsonPropertyName("fx_rate")]
        public string FxRate { get; set; }

        /// <summary>
        /// quoteId
        /// </summary>
        [JsonPropertyName("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// sourceCurrency
        /// </summary>
        [JsonPropertyName("source_currency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// the startTime this quote to be available.
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// targetCurrency
        /// </summary>
        [JsonPropertyName("target_currency")]
        public string TargetCurrency { get; set; }
    }
}
