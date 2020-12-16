using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAgreementUserverifyQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAgreementUserverifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 申请时获取的token
        /// </summary>
        [JsonPropertyName("apply_token")]
        public string ApplyToken { get; set; }
    }
}
