using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillAccountbookereceiptQueryModel Data Structure.
    /// </summary>
    public class AlipayDataBillAccountbookereceiptQueryModel : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 根据申请id查询状态
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }
    }
}
