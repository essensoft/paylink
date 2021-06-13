using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 企业支付宝ID
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
