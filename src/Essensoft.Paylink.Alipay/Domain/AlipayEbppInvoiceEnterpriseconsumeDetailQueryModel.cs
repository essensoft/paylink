using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 企业id-共同和账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 账单凭证ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
