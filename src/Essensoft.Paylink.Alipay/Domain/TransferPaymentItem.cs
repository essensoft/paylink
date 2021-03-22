using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferPaymentItem Data Structure.
    /// </summary>
    public class TransferPaymentItem : AlipayObject
    {
        /// <summary>
        /// 缴费接收日期，yyyy-MM-DD
        /// </summary>
        [JsonPropertyName("channel_accept_time")]
        public string ChannelAcceptTime { get; set; }

        /// <summary>
        /// 汇款到账日期，yyyy-MM-DD
        /// </summary>
        [JsonPropertyName("channel_remit_time")]
        public string ChannelRemitTime { get; set; }

        /// <summary>
        /// 是否必须缴纳，"Y"必须缴费，"N"可选
        /// </summary>
        [JsonPropertyName("mandatory_payment")]
        public string MandatoryPayment { get; set; }

        /// <summary>
        /// 是否允许部分缴费，“Y”允许，“N”不允许
        /// </summary>
        [JsonPropertyName("partial_allowed")]
        public string PartialAllowed { get; set; }

        /// <summary>
        /// 是否完成缴费,"Y"已缴费，"N"还未缴费
        /// </summary>
        [JsonPropertyName("payment_completed")]
        public string PaymentCompleted { get; set; }

        /// <summary>
        /// 缴费金额
        /// </summary>
        [JsonPropertyName("payment_item_amount")]
        public TransferAmount PaymentItemAmount { get; set; }

        /// <summary>
        /// 缴费项编号
        /// </summary>
        [JsonPropertyName("payment_item_id")]
        public string PaymentItemId { get; set; }

        /// <summary>
        /// 缴费项名称
        /// </summary>
        [JsonPropertyName("payment_item_name")]
        public string PaymentItemName { get; set; }

        /// <summary>
        /// 缴费项类型
        /// </summary>
        [JsonPropertyName("payment_item_type")]
        public string PaymentItemType { get; set; }

        /// <summary>
        /// 缴费项本地名称
        /// </summary>
        [JsonPropertyName("payment_local_name")]
        public string PaymentLocalName { get; set; }
    }
}
