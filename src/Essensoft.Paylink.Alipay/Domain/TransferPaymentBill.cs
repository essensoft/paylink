using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferPaymentBill Data Structure.
    /// </summary>
    public class TransferPaymentBill : AlipayObject
    {
        /// <summary>
        /// 账单用户信息
        /// </summary>
        [JsonPropertyName("account_owner")]
        public TransferUser AccountOwner { get; set; }

        /// <summary>
        /// 账单金额信息
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public TransferAmount BillAmount { get; set; }

        /// <summary>
        /// 渠道付款参考号
        /// </summary>
        [JsonPropertyName("channel_payment_ref")]
        public string ChannelPaymentRef { get; set; }

        /// <summary>
        /// 渠道代发日期
        /// </summary>
        [JsonPropertyName("channel_remit_time")]
        public string ChannelRemitTime { get; set; }

        /// <summary>
        /// 预计汇款到账日期
        /// </summary>
        [JsonPropertyName("expect_transfer_time")]
        public string ExpectTransferTime { get; set; }

        /// <summary>
        /// 缴费账号
        /// </summary>
        [JsonPropertyName("payment_account_no")]
        public string PaymentAccountNo { get; set; }

        /// <summary>
        /// 缴费截止日期
        /// </summary>
        [JsonPropertyName("payment_expiry_time")]
        public string PaymentExpiryTime { get; set; }

        /// <summary>
        /// 缴费项列表
        /// </summary>
        [JsonPropertyName("payment_items")]
        public List<TransferPaymentItem> PaymentItems { get; set; }

        /// <summary>
        /// 商品参考会
        /// </summary>
        [JsonPropertyName("reference_goods_id")]
        public string ReferenceGoodsId { get; set; }

        /// <summary>
        /// 代发计算基准日期
        /// </summary>
        [JsonPropertyName("transfer_base_time")]
        public string TransferBaseTime { get; set; }
    }
}
