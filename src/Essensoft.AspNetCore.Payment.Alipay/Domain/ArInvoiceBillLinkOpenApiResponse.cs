using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArInvoiceBillLinkOpenApiResponse Data Structure.
    /// </summary>
    public class ArInvoiceBillLinkOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 开票金额
        /// </summary>
        [JsonPropertyName("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 应收月账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 可开票时间 yyyymm
        /// </summary>
        [JsonPropertyName("inv_rcpt_month")]
        public string InvRcptMonth { get; set; }

        /// <summary>
        /// 发票ID
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票单据ID
        /// </summary>
        [JsonPropertyName("invoice_receipt_id")]
        public string InvoiceReceiptId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 关联明细号
        /// </summary>
        [JsonPropertyName("link_id")]
        public string LinkId { get; set; }

        /// <summary>
        /// 01主站，02芝麻，03金融云
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 已撤回金额
        /// </summary>
        [JsonPropertyName("ret_amt")]
        public MultiCurrencyMoneyOpenApi RetAmt { get; set; }

        /// <summary>
        /// 关联明细状态   Y：有效，N：无效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户机构id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
