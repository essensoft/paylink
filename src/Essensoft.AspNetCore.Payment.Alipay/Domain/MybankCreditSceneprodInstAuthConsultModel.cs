using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodInstAuthConsultModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodInstAuthConsultModel : AlipayObject
    {
        /// <summary>
        /// 需要咨询的内容信息，不填默认是机构是否准入咨询
        /// </summary>
        [JsonPropertyName("consult_content")]
        public string ConsultContent { get; set; }

        /// <summary>
        /// 机构码，机构入驻时网商分配
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 网商分配的产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
