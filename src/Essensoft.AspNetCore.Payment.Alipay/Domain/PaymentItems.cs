using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentItems Data Structure.
    /// </summary>
    public class PaymentItems : AlipayObject
    {
        /// <summary>
        /// is goods allowed partial payment
        /// </summary>
        [JsonPropertyName("allowd_partial_payment")]
        public string AllowdPartialPayment { get; set; }

        /// <summary>
        /// The date and time when payment expires
        /// </summary>
        [JsonPropertyName("payment_item_end_time")]
        public string PaymentItemEndTime { get; set; }

        /// <summary>
        /// unique id of payment item
        /// </summary>
        [JsonPropertyName("payment_item_id")]
        public string PaymentItemId { get; set; }

        /// <summary>
        /// payment item local name
        /// </summary>
        [JsonPropertyName("payment_item_local_name")]
        public string PaymentItemLocalName { get; set; }

        /// <summary>
        /// payment item name
        /// </summary>
        [JsonPropertyName("payment_item_name")]
        public string PaymentItemName { get; set; }

        /// <summary>
        /// The date and time when payment is effective
        /// </summary>
        [JsonPropertyName("payment_start_time")]
        public string PaymentStartTime { get; set; }

        /// <summary>
        /// payment item amount
        /// </summary>
        [JsonPropertyName("payment_total_amount")]
        public TuitionMoneyDTO PaymentTotalAmount { get; set; }
    }
}
