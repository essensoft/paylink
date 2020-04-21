using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskDsddAdmitConsultModel Data Structure.
    /// </summary>
    public class MybankCreditCreditriskDsddAdmitConsultModel : AlipayObject
    {
        /// <summary>
        /// 支付宝SMID
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
