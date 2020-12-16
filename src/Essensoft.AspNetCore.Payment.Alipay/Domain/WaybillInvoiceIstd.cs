using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WaybillInvoiceIstd Data Structure.
    /// </summary>
    public class WaybillInvoiceIstd : AlipayObject
    {
        /// <summary>
        /// 失败原因，需要传单个配送单的驳回原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 即时配送运单金额
        /// </summary>
        [JsonPropertyName("waybill_amount")]
        public string WaybillAmount { get; set; }

        /// <summary>
        /// 配送单开票状态  0：处理中 1：已开票  2：开票失败
        /// </summary>
        [JsonPropertyName("waybill_invoice_status")]
        public long WaybillInvoiceStatus { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
