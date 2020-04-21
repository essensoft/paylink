using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampuscardQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampuscardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学生的校园卡列表
        /// </summary>
        [JsonPropertyName("alipay_card_list")]
        public List<SchoolCardInfo> AlipayCardList { get; set; }
    }
}
