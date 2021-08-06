using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectinfoModifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectinfoModifyModel : AlipayObject
    {
        /// <summary>
        /// 企业id-共同账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止（yyyy-MM-dd HH:mm:ss，与起始时间必须同时传，且大于起始时间，不传则不修改）
        /// </summary>
        [JsonPropertyName("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始（yyyy-MM-dd HH:mm:ss，与截止时间必须同时传，且小于截止时间，不传则不修改）
        /// </summary>
        [JsonPropertyName("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名（不传则不修改）
        /// </summary>
        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }
    }
}
