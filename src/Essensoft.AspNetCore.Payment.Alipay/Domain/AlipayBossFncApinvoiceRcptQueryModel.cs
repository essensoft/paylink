using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncApinvoiceRcptQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncApinvoiceRcptQueryModel : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// OU机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 发票开始月份 格式yyyyMM
        /// </summary>
        [JsonPropertyName("invoice_date_begin")]
        public string InvoiceDateBegin { get; set; }

        /// <summary>
        /// 发票结束月份 格式yyyyMM
        /// </summary>
        [JsonPropertyName("invoice_date_end")]
        public string InvoiceDateEnd { get; set; }

        /// <summary>
        /// PAID_INVOICE : "01" : "每月实收开票"  RECEIVABLE_INVOICE : "02" : "应收开票" SUM_PAID_INVOICE : "03" : "累计实收开票"
        /// </summary>
        [JsonPropertyName("invoice_mode")]
        public string InvoiceMode { get; set; }

        /// <summary>
        /// 商户MID
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// SETTLE("06", "SETTLE", "统一结算", "统一结算")
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// REVENUE("1", "应收"), DISCOUNT("2", "返点"), DEFER("4", "递延"), REVENUE_ACCRUAL("21","计提应收账单"), DISCOUNT_ACCRUAL("22","计提返点账单"), DEFER_ACCRUAL("23","递延摊销账单"), SETTLEMENT_BILL("99","结算单"),
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
