using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel : AlipayObject
    {
        /// <summary>
        /// 企业码账号
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费金额（单位：分）
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        [JsonPropertyName("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 0 员工支付宝账号，1 员工公司员工号
        /// </summary>
        [JsonPropertyName("employee_id_type")]
        public long EmployeeIdType { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 0 是扣款，1 退款
        /// </summary>
        [JsonPropertyName("is_off_set")]
        public long IsOffSet { get; set; }

        /// <summary>
        /// 外部唯一交易ID（幂等）
        /// </summary>
        [JsonPropertyName("out_source_id")]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 调用者身份（道安- DAO_AN）
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }
    }
}
