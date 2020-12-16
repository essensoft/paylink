using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAgreementUserverifyApplyModel Data Structure.
    /// </summary>
    public class AlipayUserAgreementUserverifyApplyModel : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
