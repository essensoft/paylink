using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReceiptQuoteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptQuoteInfo : AlipayObject
    {
        /// <summary>
        /// The base currency
        /// </summary>
        [JsonProperty("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// a currency pair is the quotation of the relative value of a currency unit against the unit of another currency.
        /// </summary>
        [JsonProperty("base_currency_unit")]
        public string BaseCurrencyUnit { get; set; }

        /// <summary>
        /// the time of this quote to be unavaible
        /// </summary>
        [JsonProperty("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// fxRate
        /// </summary>
        [JsonProperty("fx_rate")]
        public string FxRate { get; set; }

        /// <summary>
        /// quoteId
        /// </summary>
        [JsonProperty("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// sourceCurrency
        /// </summary>
        [JsonProperty("source_currency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// the startTime this quote to be available.
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// targetCurrency
        /// </summary>
        [JsonProperty("target_currency")]
        public string TargetCurrency { get; set; }
    }
}
