using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudyAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateStudyAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的学习账户信息
        /// </summary>
        [JsonPropertyName("alipay_card_list")]
        public StudyAccountInfo AlipayCardList { get; set; }
    }
}
