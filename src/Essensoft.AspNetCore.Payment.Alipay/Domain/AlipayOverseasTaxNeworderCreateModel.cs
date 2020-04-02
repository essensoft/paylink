using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxNeworderCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxNeworderCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 退税单过期时间，退税单据的有效期是6个月，退税打印时间+6个月，格式 : yyyy-MM-dd HH:mm:ss，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("doc_expire_date")]
        public string DocExpireDate { get; set; }

        /// <summary>
        /// 纸质退税单号，应保证和单笔退税接口的doc_id一致
        /// </summary>
        [JsonPropertyName("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 退税单打印时间，格式 : yyyy-MM-dd HH:mm:ss，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("doc_print_date")]
        public string DocPrintDate { get; set; }

        /// <summary>
        /// 扩展参数json格式，1.机构退税单页面标识符，key为page_identifier，value为唯一加密串，跳转机构退税单页面时携带此参数
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 国籍，用户护照上的国家码
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 外部退税商户ID，商户在退税机构的ID，一键退税必填
        /// </summary>
        [JsonPropertyName("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 护照姓名，用户护照上的英文姓名，不允许特殊字符
        /// </summary>
        [JsonPropertyName("passport_name")]
        public string PassportName { get; set; }

        /// <summary>
        /// 护照号码，英文或数据，不允许特殊字符
        /// </summary>
        [JsonPropertyName("passport_no")]
        public string PassportNo { get; set; }

        /// <summary>
        /// 当前状态，新建（INIT），海关已盖章（STAMPED），海关拒绝（REJECTED_BY_CUSTOMS），退税机构收到退税单（RECEIVED），作废（VOIDED），失败（FAILED），过期（EXPIRED），已退税（REFUNDED），已使用非支付宝退税（REFUNDED_NON_ALIPAY）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 当前状态发生的时间(UTC+8)，格式yyyy-MM-dd HH:mm:ss，默认为当前时间
        /// </summary>
        [JsonPropertyName("status_change_time")]
        public string StatusChangeTime { get; set; }

        /// <summary>
        /// 支付宝资金订单号，预授权退税下单接口返回的tax_refund_no，原单笔退税接口返回的refund_order_no，批量退税结果文件倒数第二列。当且status为REFUNDED时必选，其余状态忽略
        /// </summary>
        [JsonPropertyName("tax_payment_no")]
        public string TaxPaymentNo { get; set; }

        /// <summary>
        /// 退税金额，退税公司退税金额，币种由tax_refund_currency指定，精确到币种最小单位，金额大于0，如tax_refund_currency为SGD，币种最小单位为分，100元新币，则tax_refund_amount传入10000.
        /// </summary>
        [JsonPropertyName("tax_refund_amount")]
        public string TaxRefundAmount { get; set; }

        /// <summary>
        /// 退税发生国家, ISO标准alpha-2国家代码
        /// </summary>
        [JsonPropertyName("tax_refund_country")]
        public string TaxRefundCountry { get; set; }

        /// <summary>
        /// 退税公司退税币种，一般指外币，ISO标准退税国家alpha-3币种代码
        /// </summary>
        [JsonPropertyName("tax_refund_currency")]
        public string TaxRefundCurrency { get; set; }
    }
}
